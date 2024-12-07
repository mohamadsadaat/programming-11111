using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rsmangement
{
    public partial class IN : Form
    {
        public IN()
        {
            InitializeComponent();
        }
        public string strcon = "Data Source=DESKTOP-11460QF\\SQLEXPRESS;Initial Catalog=RestaurantDB;Integrated Security=True;";
        public void LoadDataIntoListBox()
        {
            string query = "SELECT MealName FROM Meals";

            using (SqlConnection connection = new SqlConnection(strcon))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["MealName"].ToString());
                }
                reader.Close();
            }
             query = "SELECT Price FROM Meals";

            using (SqlConnection connection = new SqlConnection(strcon))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listBox2.Items.Add(reader["Price"].ToString());
                }
                reader.Close();
            }

        }
        private void DeleteRowByFoodName(string foodName)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Food"].Value?.ToString() == foodName)
                {
                    dataGridView1.Rows.Remove(row);
                    break; // الخروج من الحلقة بعد حذف الصف
                }
            }

            // تحديث ComboBox بعد الحذف
            FillComboBoxWithFoodNames();
        }
        private void IN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDBDataSet.Meals' table. You can move, or remove it, as needed.
            this.mealsTableAdapter.Fill(this.restaurantDBDataSet.Meals);
            LoadDataIntoListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0 && numericUpDown1.Value > 0)
            {
                string food = listBox1.SelectedItems[0].ToString();
                int quantity = (int)numericUpDown1.Value;
                decimal p = clac(food);

                dataGridView1.Rows.Add(food, quantity,p,quantity*p);
            }
            else
            {
                MessageBox.Show("  تاكد من اختيار وجبة وعدد قطع ");
            }
            FillComboBoxWithFoodNames();
        }

        private void SaveData(string num)
        {
            // التأكد من أن DataGridView غير فارغ
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("لا توجد بيانات لحفظها.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(strcon))
            {
                connection.Open();

                // بدء معاملة لحفظ البيانات
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string food = row.Cells["food"].Value.ToString();
                                int quantity = Convert.ToInt32(row.Cells["count"].Value);
                                decimal totalPrice = Convert.ToDecimal(row.Cells["total"].Value);

                                string query = "INSERT INTO orders (MealID,Quantity,TotalPrice,TablrNumber,OrderType) VALUES (select MealID from Meals where MealName=@food, @Quantity, @TotalPrice,@TablrNumber)";
                                SqlCommand command = new SqlCommand(query, connection, transaction);

                                command.Parameters.AddWithValue("@Food", food);
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                command.Parameters.AddWithValue("@TablrNumber", num);

                                command.ExecuteNonQuery();
                            }
                        }

                        // الالتزام بالمعاملة
                        transaction.Commit();
                        MessageBox.Show("تم حفظ البيانات بنجاح.");
                    }
                    catch (Exception ex)
                    {
                        // التراجع عن المعاملة في حالة حدوث خطأ
                        transaction.Rollback();
                        MessageBox.Show("حدث خطأ أثناء حفظ البيانات: " + ex.Message);
                    }
                }
            }
        }
        public decimal clac(string food)
        {
            decimal result = 0;
            string query = "select price from Meals where MealName=@food";
            using (SqlConnection connection = new SqlConnection(strcon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@food", food);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetDecimal(0);
                }
                reader.Close();
            }
            return result;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string foodNameToDelete = comboBox1.SelectedItem?.ToString(); // جلب اسم الأكلة من ComboBox
            if (!string.IsNullOrEmpty(foodNameToDelete))
            {
                DeleteRowByFoodName(foodNameToDelete);
                comboBox1.ResetText(); // إعادة ضبط النص في ComboBox بعد الحذف
            }
            else
            {
                MessageBox.Show("يرجى اختيار اسم الأكلة المراد حذفها.");
            }
        }
    
        private void FillComboBoxWithFoodNames()
        {
            comboBox1.Items.Clear(); // مسح العناصر القديمة

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // تجاهل الصف الجديد (الصف الفارغ المخصص لإدخال البيانات)
                {
                    string food = row.Cells["Food"].Value?.ToString();
                    if (food != null)
                    {
                        comboBox1.Items.Add(food);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1 == null)
            {
                MessageBox.Show("ادخل رقم الطاولة");
            }
            else 
            {
                SaveData(textBox1.Text);
            }
        }
    }
}

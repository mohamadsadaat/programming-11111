using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rsmangement {
	public class user
	{
		
	}
	public class Mgr
	{

		public static string strcon = "Data Source=DESKTOP-11460QF\\SQLEXPRESS;Initial Catalog=RestaurantDB;Integrated Security=True;";
		public static void showAll(DataGridView v1)
		{

			 
			string qure = "SELECT MealID,MealName,Price,Description FROM Meals;";
			SqlConnection con = new SqlConnection(strcon);
			SqlCommand cmd = new SqlCommand(qure, con);
			con.Open();
			SqlDataAdapter a = new SqlDataAdapter(cmd);
			DataTable t = new DataTable();
			a.Fill(t);
			v1.DataSource = t;
			

		}
		public static void showAll(System.Windows.Forms.ComboBox v1)
		{


			string qure = "SELECT MealID,MealName,Price,Description FROM Meals;";
			SqlConnection con = new SqlConnection(strcon);
			SqlCommand cmd = new SqlCommand(qure, con);
			con.Open();
			SqlDataAdapter a = new SqlDataAdapter(cmd);
			DataTable t = new DataTable();
			a.Fill(t);
			v1.DataSource = t;
			v1.DisplayMember = "MealName";
			v1.ValueMember = "MealID";

		}
		public static void Addmeal(string name,string price,string Descraption) {
			string qure = "INSERT INTO Meals (MealName,Price,Description)VALUES(@MealName,@Price,@Description)";
			SqlConnection con = new SqlConnection(strcon);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{

				cmd.Parameters.AddWithValue("@MealName", name);
				cmd.Parameters.AddWithValue("@Price", price);
				cmd.Parameters.AddWithValue("@Description", Descraption);
				
				try
				{
					con.Open();
					int r = cmd.ExecuteNonQuery();
					if (r > 0)
					{
						MessageBox.Show("تم أضافة الوجبة");
					}
					else
					{
						MessageBox.Show("حدث خطأ ما");
					}
					

				}
				catch (Exception)
				{

					MessageBox.Show("هناك حقل فارغ");
				}

			}
		}
		public static void Delaetemeal(int ID)
		{
			string qure = "	DELETE FROM Meals WHERE  MealID=@MealID";
			SqlConnection con = new SqlConnection(strcon);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{


				cmd.Parameters.AddWithValue("@MealID", ID);

				con.Open();
				int r = cmd.ExecuteNonQuery();
				if (r > 0)
				{
					MessageBox.Show("تم حذف الوجبة");

				}
				else
				{
					MessageBox.Show("حدث خطأ ما");
				}
			}
		}
		public static void UpdateMeale(string name, string price, string Descraption,string ID) {
			string qure = "UPDATE  Meals SET  MealName=@MealName,Price=@Price,Description=@Description WHERE MealID=@MealID";
			SqlConnection con = new SqlConnection(strcon);
			using (SqlCommand cmd = new SqlCommand(qure, con))
			{

				cmd.Parameters.AddWithValue("@MealName", name);
				cmd.Parameters.AddWithValue("@Price", price);
				cmd.Parameters.AddWithValue("@Description", Descraption);
				cmd.Parameters.AddWithValue("@MealID", ID);
				try
				{



					con.Open();
					int r = cmd.ExecuteNonQuery();
					if (r > 0)
					{
						MessageBox.Show("تم تعديل الوجبة");
					}
					else
					{
						MessageBox.Show("هناك حقل فارغ");
					}
				}
				catch (Exception)
				{

					MessageBox.Show("حدث خطأ ما");
				}
			}
		}
	}
}
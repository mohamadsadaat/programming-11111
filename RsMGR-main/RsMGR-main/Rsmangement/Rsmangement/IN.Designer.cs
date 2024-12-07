﻿namespace Rsmangement
{
    partial class IN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDBDataSet = new Rsmangement.RestaurantDBDataSet();
            this.mealsTableAdapter = new Rsmangement.RestaurantDBDataSetTableAdapters.MealsTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mealsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataMember = "Meals";
            this.mealsBindingSource.DataSource = this.restaurantDBDataSetBindingSource;
            // 
            // restaurantDBDataSetBindingSource
            // 
            this.restaurantDBDataSetBindingSource.DataSource = this.restaurantDBDataSet;
            this.restaurantDBDataSetBindingSource.Position = 0;
            // 
            // restaurantDBDataSet
            // 
            this.restaurantDBDataSet.DataSetName = "RestaurantDBDataSet";
            this.restaurantDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mealsTableAdapter
            // 
            this.mealsTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.CausesValidation = false;
            this.listBox1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 612);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(459, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "اضف الوجبة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(711, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 27);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "اتمام الطلبية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(914, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "الغاء الطلبية";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // mealsBindingSource1
            // 
            this.mealsBindingSource1.DataMember = "Meals";
            this.mealsBindingSource1.DataSource = this.restaurantDBDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food,
            this.count,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(459, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(762, 472);
            this.dataGridView1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(215, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(238, 612);
            this.listBox2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "حذف الوجبة";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(459, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(795, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم الطاولة";
            // 
            // food
            // 
            this.food.HeaderText = "الوجبة";
            this.food.MinimumWidth = 8;
            this.food.Name = "food";
            this.food.ReadOnly = true;
            this.food.Width = 150;
            // 
            // count
            // 
            this.count.HeaderText = "عدد القطع";
            this.count.MinimumWidth = 8;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 150;
            // 
            // total
            // 
            this.total.HeaderText = "السعر  الاجمالي";
            this.total.MinimumWidth = 8;
            this.total.Name = "total";
            this.total.Width = 150;
            // 
            // IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1233, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Name = "IN";
            this.Text = "IN";
            this.Load += new System.EventHandler(this.IN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource restaurantDBDataSetBindingSource;
        private RestaurantDBDataSet restaurantDBDataSet;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private RestaurantDBDataSetTableAdapters.MealsTableAdapter mealsTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource mealsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}
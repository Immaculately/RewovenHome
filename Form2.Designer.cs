namespace RewovenHome_24658219
{
    partial class Form2
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBookingDate = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(695, 500);
            label1.Name = "label1";
            label1.Size = new Size(220, 17);
            label1.TabIndex = 0;
            label1.Text = "Karabo Ralekoala, 24658219";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkRed;
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 180);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 146);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(191, 28);
            radioButton5.TabIndex = 9;
            radioButton5.TabStop = true;
            radioButton5.Text = "Coffe table (R1350)";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(151, 28);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Couch (R1200)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 116);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(205, 28);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Tableware set (R950)";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(150, 28);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Fridge (R5000)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(246, 28);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Washing machine (R3500)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 493);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 2;
            label2.Text = "TOTAL: R";
            // 
            // textTotal
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(101, 486);
            textBox1.Name = "textTotal";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.DarkRed;
            monthCalendar1.Location = new Point(577, 281);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.DarkRed;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Eco-cleaning upgrde", "Extra storage packaging", "Warranty extention", "Delivery setup service" });
            checkedListBox1.Location = new Point(12, 281);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(262, 88);
            checkedListBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(62, 24);
            label3.TabIndex = 6;
            label3.Text = "Couch";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkRed;
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(403, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 189);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dimensions";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "60 * 60 * 40(small) = R1 350", "100 * 50 * 45(medium) = R2 000", "130 * 70 * 50(large) = R3 500" });
            comboBox4.Location = new Point(182, 148);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(324, 32);
            comboBox4.TabIndex = 13;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "6kg(light load) = R3 500", "8kg(medium oad) = R4 500", "12kg(heavy load) = R7 000" });
            comboBox3.Location = new Point(182, 108);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(324, 32);
            comboBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "55 * 60 * 85(bar fridge) = R3 000", "70 * 70 * 170(single-door) = R5 000", "90 * 75 * 180(double-door) = R8 000" });
            comboBox2.Location = new Point(182, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(324, 32);
            comboBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 156);
            label6.Name = "label6";
            label6.Size = new Size(103, 24);
            label6.TabIndex = 10;
            label6.Text = "Coffe Table";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 111);
            label5.Name = "label5";
            label5.Size = new Size(157, 24);
            label5.TabIndex = 9;
            label5.Text = "Washing machine";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 8;
            label4.Text = "Fridge";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "120 * 80 * 80(2 seater) = R1 200", "180 * 90 * 85( 3 seater) = R1 500", "240 * 100 * 90(large) = R2 500" });
            comboBox1.Location = new Point(182, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(324, 32);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 19);
            label7.Name = "label7";
            label7.Size = new Size(340, 23);
            label7.TabIndex = 8;
            label7.Text = "Product Select and Order here...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(577, 240);
            label8.Name = "label8";
            label8.Size = new Size(232, 21);
            label8.TabIndex = 9;
            label8.Text = "Select Date For Booking";
            // 
            // textBookingDate
            // 
            textBookingDate.Location = new Point(149, 391);
            textBookingDate.Name = "textBookingDate";
            textBookingDate.ReadOnly = true;
            textBookingDate.Size = new Size(125, 27);
            textBookingDate.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(12, 424);
            button1.Name = "button1";
            button1.Size = new Size(262, 29);
            button1.TabIndex = 11;
            button1.Text = "Add Customer Information";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(927, 522);
            Controls.Add(button1);
            Controls.Add(textBookingDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Iventory";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private CheckedListBox checkedListBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Label label3;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBookingDate;
        private Button button1;
    }
}
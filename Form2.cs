using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewovenHome_24658219
{
    public partial class Form2 : Form
    {
        double Total = 0;
        double checkBoxTotal = 0;
        double radioTotal = 0;

        String radioButtonItem = "";
        String comboboxItem = "";
        String totalItem = "";
        String dateSelected = "";

        String[] checkBoxItems;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            radioButton1.Select();
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MinDate = DateTime.Today.AddMonths(1);

            //update the total box when form loads

            //MessageBox.Show(radio1Info);

            //textTotal.Text = radio1Info;
            textBox1.Text = getValueAfterR(radioButton1.Text);


            //add code to listine to the groupbox with radiobuttons

            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += radioButton_CheckedChanged;
                }

            }
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

            monthCalendar1.DateSelected += MonthCalendar1_DateSelected;
        }

        private void MonthCalendar1_DateSelected(object? sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            textBookingDate.Text = selectedDate.ToShortDateString();

        }

        private void checkedListBox1_ItemCheck(object? sender, ItemCheckEventArgs e)
        {
            string theString = "";
            string item = checkedListBox1.Items[e.Index].ToString();
            bool itemChecked = (e.NewValue == CheckState.Checked);
            if (itemChecked)
            {
                theString = getValueAfterR(item);
                checkBoxTotal = checkBoxTotal + double.Parse(theString);
            }
            else
            {
                theString = getValueAfterR(item);
                checkBoxTotal = checkBoxTotal - double.Parse(theString);
            }
            Total = radioTotal + getTotalCheckBoxes();
            textBox1.Text = Total.ToString();
        }

        private string getValueAfterR(string text)
        {
            int indexOfR = text.IndexOf("R") + 1;
            int length = text.Length;
            string textInfo = text.Substring(indexOfR, length - indexOfR);
            return textInfo;
        }

        private void radioButton_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                //MessageBox.Show(radioButton.Text);
                string getValue = getValueAfterR(radioButton.Text);
                radioTotal = double.Parse(getValue);
                Total = radioTotal + getTotalCheckBoxes();
                textBox1.Text = Total.ToString();
            }
        }

        private double getTotalCheckBoxes()
        {
            return checkBoxTotal;
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxItem = comboBox1.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            totalItem = textBox1.Text;
            //MessageBox.Show(totalItem);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBookingDate.Text.Length < 1)
            {
                MessageBox.Show("First select a date for your booking ");
            }
            else
            {
                Form3 form3 = new Form3(radioButtonItem, checkBoxItems, comboboxItem, dateSelected, totalItem);
                form3.Show();
            }
        }

        private void textBookingDate_TextChanged(object sender, EventArgs e)
        {
            dateSelected = textBookingDate.Text;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e, string[] selectedItemsArray1)
        {
            // Create a string array with the same size as the number of checked items
            string[] selectedItemsArray = new string[checkedListBox1.CheckedItems.Count];

            // Loop through and fill the array
            int i = 0;
            foreach (object item in checkedListBox1.CheckedItems)
            {
                selectedItemsArray[i] = item.ToString();
                i++;
            }
            checkBoxItems = selectedItemsArray1; 
        }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = sender as RadioButton;
            if (radioButton1 != null && radioButton1.Checked)
            {
                //MessageBox.Show(radioButton.Text);
                radioButtonItem = radioButton1.Text; 

                // Get the price for the selected item
                string getValue = getValueAfterR(radioButton1.Text); 
                radioTotal = double.Parse(getValue); 

                Total = radioTotal + getTotalCheckBoxes();
                textBox1.Text = Total.ToString();
            }
        }
    }
}

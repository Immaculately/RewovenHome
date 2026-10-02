using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RewovenHome_24658219
{
    public partial class Form3 : Form
    {
        string pubRadioButton, pubComboboxItem, pubDate, pubTotal;
        string[] pubCheckBoxItems;
        public Form3(string radioButtonItem, string[] checkBoxItems, string comboboxItems, string dateSelected, string totalItem)
        {
            InitializeComponent();
            //MessageBox.Show(radioButtonItem);
            //MessageBox.Show(comboboxItems);
            //MessageBox.Show(dateSelected);
            //MessageBox.Show(totalItem);
            //MessageBox.Show(checkBoxItems.Length.ToString());
            pubRadioButton = radioButtonItem;
            pubComboboxItem = comboboxItems;
            pubDate = dateSelected;
            pubTotal = totalItem;
            pubCheckBoxItems = checkBoxItems;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textName.Focus();
        }

        private void textName_Leave(object sender, EventArgs e)
        {
            string nameInput = textName.Text;
            // Pattern to allow only letters and spaces

            string allowedPattern = @"^[A-Za-z\s]+$";
            // Count only the letters

            int letterCount = Regex.Matches(nameInput, "[A-Za-z]").Count;
            if (Regex.IsMatch(nameInput, allowedPattern) && letterCount >= 2)
            {
                //Console.WriteLine("Valid name.");
                textName.Text = textName.Text.ToUpper();

            }
            else
            {
                //Console.WriteLine("Invalid name. Use letters and spaces only, with at least 2 letters.");
                MessageBox.Show("Invalid name. Use letters and spaces only, with at least 2 letters.");
                textName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string path = @"C:\myData\OrderInfo.txt";

            DateTime currentDateOnly = DateTime.Today;
            
            string currentDate = currentDateOnly.ToString("yyyy/MM/dd");
            File.AppendAllText(path, currentDate + ";");
            File.AppendAllText(path, textName.Text + ";");
            File.AppendAllText(path, textCellphone.Text + ";");
            File.AppendAllText(path, textEmail.Text + ";");
            File.AppendAllText(path, textIDNumber.Text + ";");

            
            string checkboxitems = "";
            for (int i = 0; i < pubCheckBoxItems.Length; i++)
            {
                checkboxitems = checkboxitems + pubCheckBoxItems[i] + ","; 
            }
            File.AppendAllText(path, checkboxitems);

            File.AppendAllText(path, pubRadioButton + ";");
            File.AppendAllText(path, pubComboboxItem + ";");
            File.AppendAllText(path, pubTotal + ";");
            File.AppendAllText(path, pubDate);
            File.AppendAllText(path, "\n");
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCellphone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

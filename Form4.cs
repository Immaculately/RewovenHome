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
    public partial class Form4 : Form
    {
        DataTable table = new DataTable();
        private object textTotal;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            double totals = 0;
            dataGridView1.Rows.Clear();
            string filePath = @"C:\Users\karabo\OneDrive\Desktop\ass\ICT2611\RewovenHome_24658219\myData.txt";
            if (!File.Exists(filePath))
            {
                //just incase the file is not found - display a message
                MessageBox.Show("File not found: " + filePath);
                return;
            }
            // Read all lines from the OrderInfo.txt file
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] fields = line.Split(';');
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i] = fields[i].Trim();
                }
                //totals = totals + double.Parse(fields[fields.Length - 2]);
                // Add row directly to existing DataGridView
                dataGridView1.Rows.Add(fields);
                textTotal = totals.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

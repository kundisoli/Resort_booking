using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Resort_booking_system
{
    public partial class Booking_Details : Form
    {
        public Booking_Details()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        private void Booking_Details_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Service_id", typeof(int));
            table.Columns.Add("Check_in", typeof(DateTime));
            table.Columns.Add("Check out", typeof(DateTime));
            table.Columns.Add("Number_of_adults", typeof(int));
            table.Columns.Add("Number of Children", typeof(int));
            table.Columns.Add("Room type", typeof(string));
            table.Columns.Add("Restaurant Name ", typeof(string));
            table.Columns.Add("Ride type", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            dataGridView1.DataSource = table;

        }

        private void cmdViewfile_Click(object sender, EventArgs e)
        {





            string[] lines = File.ReadAllLines(@"\\form\\" + "Customer_Service_details.txt");
            string[] values;
            for (int a = 0; a < lines.Length; a++)
            {
                values = lines[a].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int l = 0; l < values.Length; l++)
                {
                    row[l] = values[l].Trim();
                }
                table.Rows.Add(row);




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        private void MeExit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}

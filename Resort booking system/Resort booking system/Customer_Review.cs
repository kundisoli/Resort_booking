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
    public partial class Customer_Review : Form
    {
        public Customer_Review()
        {
            InitializeComponent();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            Review rev = new Review();

            rev.Customer_username = textBox1.Text;
            rev.Comment = textBox1.Text;

            StreamWriter Review = new StreamWriter(Application.StartupPath + "\\form\\" + "customer_review_details.txt");

            Review.WriteLine(textBox1.Text+"/" + textBox2.Text);
            Review.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

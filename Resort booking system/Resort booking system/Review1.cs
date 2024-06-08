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
    public partial class Review1 : Form
    {
        public Review1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Review rev = new Review();

            rev.Customer_username = textBox2.Text;
            rev.Comment = textBox1.Text;

            StreamWriter Service = new StreamWriter(Application.StartupPath + "\\form\\" + "Review_details.txt");

            Service.WriteLine(textBox2.Text + " /");
             Service.WriteLine( textBox1.Text + "/ " );


            Service.Close();
        }
    }
}

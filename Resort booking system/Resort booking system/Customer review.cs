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
    public partial class Customer_review : Form
    {
        public Customer_review()
        {
            InitializeComponent();
        }

        private void Customer_review_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            StreamReader input;

            OpenFileDialog ofd;
            String file;
            DialogResult selected;

            ofd = new OpenFileDialog();

            selected = ofd.ShowDialog();


            if (selected == DialogResult.OK)
            {
                file = ofd.FileName;
            }
            else
            {
                return;
            }
            input = new StreamReader(file);
            txtReview.Text = input.ReadToEnd();
            input.Close(); 
        }
    }
}

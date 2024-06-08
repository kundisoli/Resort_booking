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
    public partial class Hotel_Service : Form
    {
        public Hotel_Service()
        {
            InitializeComponent();
        }

        Services service = new Services();

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            

            
            service.Number_of_adults = int.Parse(txtAdult.Text);
            service.Number_of_children = int.Parse(txtChild.Text);
               service.Restaurant_name = textBox3.Text;
               service.Reservation_type = comboBox6.SelectedValue.ToString();
               service.Roomtype = comboBox4.SelectedValue.ToString();
               service.Ride_type = comboBox7.SelectedValue.ToString();

            StreamWriter Service = new StreamWriter(Application.StartupPath + "\\form\\" + "Customer_Service_details.txt");

            Service.WriteLine(txtAdult.Text + " /" + txtChild.Text + "/ " + dateTimePicker3.Value + "/ " + dateTimePicker4.Value + "/ " + comboBox4.SelectedValue.ToString() + " /" + textBox3.Text + " /" + comboBox6.SelectedValue.ToString() + "/ " + comboBox4.SelectedValue.ToString() + " /" + textBox3.Text + " /" + comboBox6.SelectedValue.ToString() + " /" + comboBox7.SelectedValue.ToString());
           

            Service.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

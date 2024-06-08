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
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }

        private void LogIn_Form_Load(object sender, EventArgs e)
        {

        
        }
        Account acc = new Account();
        Color select_color = Color.FromArgb(46, 49, 49);
        private void button1_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
            button1.BackColor = select_color;
            panelL.BackColor = Color.Yellow;
            panelR.BackColor = select_color;
            button2.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelRegister.BringToFront();
            button2.BackColor = select_color;
            panelR.BackColor = Color.Yellow;
            panelL.BackColor = select_color;
            button1.BackColor = Color.Black;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name.ToLower().Trim().Equals("full name"))
            {
                txtName.Text = " ";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.ToLower().Trim().Equals("Email"))
            {
                txtEmail.Text = " ";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name.ToLower().Trim().Equals("full name") || name.Trim().Equals(" "))
            {
                txtName.Text = "full name";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.ToLower().Trim().Equals("Email") || email.Trim().Equals(" "))
            {
                txtName.Text = "Email";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            string usert = textBox1.Text;
            if (usert.ToLower().Trim().Equals("User Type"))
            {
                textBox1.Text = " ";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            string uset = textBox1.Text; ;
            if (uset.ToLower().Trim().Equals("User Type") || uset.Trim().Equals(" "))
            {
                txtName.Text = "User Type";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void txtUsern_Enter(object sender, EventArgs e)
        {
            string username = txtUsern.Text;
            if (username.ToLower().Trim().Equals("Username"))
            {
                txtUsern.Text = " ";
                txtUsern.ForeColor = Color.Black;
            }

        }

        private void txtUsern_Leave(object sender, EventArgs e)
        {
            string username = txtUsern.Text;
            if (username.ToLower().Trim().Equals("Username") || username.Trim().Equals(" "))
            {
                txtUsern.Text = "Username";
                txtUsern.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            if (pass.ToLower().Trim().Equals("Password") || pass.Trim().Equals(" "))
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            string pass = txtPassword.Text;
            if (pass.ToLower().Trim().Equals("Password"))
            {
                txtPassword.Text = " ";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            string confirm = txtConfirm.Text;
            if (confirm.ToLower().Trim().Equals("Cofirm Password") || confirm.Trim().Equals(" "))
            {
                txtConfirm.Text = "Confirm Password";
                txtConfirm.ForeColor = Color.Gray;
            }
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {

            string confirm = txtPassword.Text;
            if (confirm.ToLower().Trim().Equals("Confirm Password"))
            {
                txtConfirm.Text = " ";
                txtConfirm.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            if (username.ToLower().Trim().Equals("Username") || username.Trim().Equals(" "))
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {

            string username = txtUsern.Text;
            if (username.ToLower().Trim().Equals("Username"))
            {
                txtUser.Text = " ";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

            string pass = txtPass.Text;
            if (pass.ToLower().Trim().Equals("Password") || pass.Trim().Equals(" "))
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            if (pass.ToLower().Trim().Equals("Password"))
            {
                txtPass.Text = " ";
                txtPass.ForeColor = Color.Black;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        User u = new User();



        private void button3_Click(object sender, EventArgs e)
        {
            

                try
                {
                    var sr = new System.IO.StreamReader(Application.StartupPath + "\\form\\" + "Registration_details.txt");
                    u.Username = sr.ReadLine();

                    u.Password = sr.ReadLine();
                    sr.Close();



                    if (u.Username == txtUser.Text && u.Password == txtPass.Text)
                    {
                        MessageBox.Show("Welcome");
                    }

                    else
                    {
                        MessageBox.Show("Username or Password is wrong!,.Error!");
                    }

                }
                catch (System.IO.DirectoryNotFoundException ex)
                {
                    MessageBox.Show("The user doesnt exist", "Error");

                }            

        }
      
        
        private void cmdRegister_Click(object sender, EventArgs e)
        {
            acc.Name = txtName.Text;
            acc.Email = txtEmail.Text;
            acc.User_Type = textBox1.Text;
            acc.Username = txtUsern.Text;
            acc.Password = txtPassword.Text;

            try
            {
                var sw = new System.IO.StreamWriter(Application.StartupPath + "\\form\\" + "Reigistration_details.txt");
                sw.Write(txtName.Text + "\n" + txtEmail.Text + "\n" + textBox1.Text + "\n" + txtUsern.Text + "\n" + txtPassword.Text);
                sw.Close();
            }

            catch (System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\form\\" + "Reigistration_details.txt");
                var sw = new StreamWriter(Application.StartupPath + "\\form\\" + "Reigistration_details.txt");
                sw.Write(txtName.Text + "\n" + textBox1.Text + "\n" + txtUsern.Text + "\n" + txtPassword.Text);
                sw.Close();

            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
        
        }
    }
}
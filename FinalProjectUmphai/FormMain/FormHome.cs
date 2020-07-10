using FinalProjectUmphai.ManagePages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectUmphai.FormMain
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            UserPanel.Width = 1;
            ManagePanel.Width = 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(UserPanel.Width== 550)
            {
                UserPanel.Width = 1;

            }
            else
            {
                UserPanel.Width = 550;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();


            login.Show();
            this.Hide();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if(ManagePanel.Width== 250)
            {
                ManagePanel.Width = 1;

            }
            else
            {
                ManagePanel.Width = 250;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            FormUserMages formUserManages  = new FormUserMages();
            formUserManages.TopLevel = false;
            panel2.Controls.Add(formUserManages);
            formUserManages.Dock = DockStyle.Fill;
            formUserManages.Show();
            UserManageButton.BorderColor = Color.Green;
            EmployeeManageButton.BorderColor = Color.Transparent;
            


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
          
            EmployeeManageButton.BorderColor = Color.Green;
            UserManageButton.BorderColor = Color.Transparent;
            
        }

        private void manageEmployee1_Load(object sender, EventArgs e)
        {

        }
    }
}

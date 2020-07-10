using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectUmphai.ManagePages
{
    public partial class FormUserMages : Form
    {
        public FormUserMages()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String sql = "select*from tb_users where user_id='"+textSearchUser.Text+"'";
            DataBaseClass.GetData(sql, DatagridUser);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUserMages_Load(object sender, EventArgs e)
        {
            String sql = "select*from tb_users";
            DataBaseClass.GetData(sql, DatagridUser);
        }

        private void textSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (textSearchUser.Text == "")
            {
                String sql = "select*from tb_users where user_id='" + textSearchUser.Text + "'";
                DataBaseClass.GetData(sql, DatagridUser);
            }
            else
            {
                String sql = "select*from tb_users where user_id='" + textSearchUser.Text + "'";
                DataBaseClass.GetData(sql, DatagridUser);
            }
        }
    }
}

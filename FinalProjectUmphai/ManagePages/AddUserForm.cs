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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String sql = "select*from tb_employee where em_id='"+textEmpID.Text+"'";
            

            if (DataBaseClass.SearchQuery(sql) == true)
            {
                String empname = DataBaseClass.ds.Tables["tbSearch"].Rows[0]["name"].ToString();
                textEmpname.Text = empname;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DataBaseClass.GetConnet();
            String sql = "insert into tb_users values('"+textUserid.Text+"','"+textGetPassword.Text+"','"+textEmpID.Text+"')";
            if (DataBaseClass.InsertQuery(sql) == true)
            {
                MessageBox.Show("ເພີ່ມສຳເລັດແລ້ວ");
                textEmpID.Clear();
                textEmpname.Clear();
                textGetPassword.Clear();
                textUserid.Clear();
            }

        }
    }
}

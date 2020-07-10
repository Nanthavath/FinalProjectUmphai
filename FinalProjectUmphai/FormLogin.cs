using FinalProjectUmphai.FormMain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectUmphai
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataBaseClass.GetConnet();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            if (textUsername.Text=="" || textPaasword.Text == "")
            {
                MessageBox.Show("ກະລຸນາໃສ່ຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່າານເພື່ອໃຊ້ງານ");
            }
            else
            {
                String sql = "select*from v_login where user_id='"+textUsername.Text+"' and password='"+textPaasword.Text+"'";
                if (DataBaseClass.GetLogin(sql) == true)
                {
                    String _status = DataBaseClass.ds.Tables["dsLogin"].Rows[0]["position"].ToString();
                    MessageBox.Show("You are "+_status);
                    formHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່າານບໍ່ຖືກຕ້ອງ");
                    textUsername.Clear();
                    textPaasword.Clear();
                }

            }
        }
    }
}

using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelFormsApp
{
    public partial class LoginForm : Form
    {
        IHostelOwnerRepository hostelOwnerRepository = new HostelOwnerRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HostelOwner hostelOwner = hostelOwnerRepository.GetHostelOwnerByUsernameAndPassword(txtUsername.Text, txtPassword.Text);
            if (hostelOwner == null)
            {
                lbMessage.Text = "Invaild account!";
                return;
            }
            else
            {
                //this.Hide();
                //frmMain frmMain = new frmMain();              
                //frmMain.Show();
                //frmMain.ShowDialog();
                //frmMain.Parent 
                //this.Close();

                MessageBox.Show("Đăng nhập thành công!!!", "Success",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}

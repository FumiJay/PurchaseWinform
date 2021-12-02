using PurchaseWinform.loginManager;
using System;
using System.Windows.Forms;

namespace PurchaseWinform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Acc = this.txtAccount.Text;
            string PW = this.txtPW.Text;

            bool logined = LoginHelper.tryLogin(Acc, PW);

            if (logined)
            {
                this.Hide();
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.Mess.Text = "帳號或密碼錯誤，請重新登入!";
            }
        }
    }
}

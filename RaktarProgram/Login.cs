using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RaktarProgram
{
    public partial class Login : UserControl
    {
        Storage str;
        DBConnect conn;

        public Login()
        {
            InitializeComponent();
        }

        public void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null) conn = new DBConnect();
                //Lekérdezés
                List<string>[] users = conn.Select("SELECT `user`, `pwd` FROM users", "user", "pwd");

                for (int i = 0; i < users[0].Count; i++)
                {
                    //Bejelentkezési adatok ellenőrzése
                    if (users[0][i] == tbUsername.Text && users[1][i] == tbPassword.Text)
                    {
                        lblLoginStatus.ForeColor = Color.Green;
                        lblLoginStatus.Text = "A bejelentkezés sikeres volt!";
                        str = (Storage)Form.ActiveForm;
                        str.ShowItems();
                        break;
                    }
                    else
                    {
                        lblLoginStatus.ForeColor = Color.Red;
                        lblLoginStatus.Text = "A bejelentkezés sikertelen volt!";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkGreen;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Black;
        }
    }
}

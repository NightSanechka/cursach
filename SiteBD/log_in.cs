using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteBD
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 50;
            textBoxLogin.MaxLength = 50;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        menu menu;
        private void buttonAutorization_Click(object sender, EventArgs e)
        {
            
            var loginUser = textBoxLogin.Text;
            var loginPassword = textBoxPassword.Text;
            if (loginUser == "ARTrofimenko" && loginPassword == "BFU")
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menu = new menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверны", "Такого аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

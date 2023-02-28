using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSMS_interface
{
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBox_serverName.Text = Properties.Settings.Default.serverName;
            textBox_dbName.Text = Properties.Settings.Default.dbName;
            textBox_password.PasswordChar = '•';
 //           this.BackColor =SystemColors.ControlDark;
           // dataBase.openConnection("admin","123");
        }

        private void button_db_authorization_Click(object sender, EventArgs e)
        {
            var serverName = textBox_serverName.Text;
            var dbName = textBox_dbName.Text;
            var logUser = textBox_login.Text;
            var password = textBox_password.Text;
            if (dataBase.openConnection(serverName,dbName,logUser, password)) 
            {
                main_form form = new main_form(dataBase);
                Properties.Settings.Default.serverName = serverName;
                Properties.Settings.Default.dbName = dbName;
                Properties.Settings.Default.Save();
                form.Show();
                this.Close();
                //Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка подключения к бд");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SSMS_interface
{
    public partial class main_form : Form
    {
        DataBase dataBase;
        SqlDataAdapter adapter;
        BindingSource bindingSource1;
        DataTable table;
        SqlCommandBuilder builder;
        string showedTable="";
        Boolean admin=true;
        public main_form(DataBase db)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase = db;
            // selectShow("select * from CarDrivers");
            fillTreeView();
            //  splitContainer2.BorderStyle
            userInterface();
            fillTreeViewUsers();
            button_executeCommand.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            tabControl.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Boolean adminCheck()
        {
            //SELECT HAS_PERMS_BY_NAME (NULL, 'DATABASE', 'INSERT');
            Boolean check = false;
            SqlCommand сommand = new SqlCommand("SELECT * FROM fn_my_permissions (NULL, 'DATABASE');", dataBase.getConnection());
            SqlDataReader reader = сommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(2) == "ALTER ANY ROLE") {
                    check = true;
                    break;
                }
            }
            reader.Close();
            return check;
        }

        private void userInterface()
        {
            if (!adminCheck())
            {
                tabControl.TabPages.Remove(tabPage2);
                button_update.Dispose();
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.ReadOnly = true;
                admin = false;
            }
        }

        private void fillTreeView() {
            SqlCommand сommand = new SqlCommand("SELECT * FROM sys.objects WHERE type in (N'U')", dataBase.getConnection());
            SqlDataReader reader = сommand.ExecuteReader();
            treeView.BeginUpdate();
            treeView.Nodes.Add("Таблицы");
            treeView.EndUpdate();

            while (reader.Read())
            {
                treeView.BeginUpdate();
                treeView.Nodes[0].Nodes.Add(reader.GetString(0));
                treeView.EndUpdate();
            }
            reader.Close();
            treeView.Nodes[0].Expand();

            сommand = new SqlCommand("select * from  sys.all_views where schema_id=1", dataBase.getConnection());
            reader = сommand.ExecuteReader();
            treeView.BeginUpdate();
            treeView.Nodes.Add("Представления");
            treeView.EndUpdate();

            while (reader.Read())
            {
                treeView.BeginUpdate();
                treeView.Nodes[1].Nodes.Add(reader.GetString(0));
                treeView.EndUpdate();
            }
            reader.Close();
            treeView.Nodes[1].Expand();
        }

        private void selectShow(String sqlCommand, DataGridView grd)
        {
            bindingSource1 = new BindingSource();
            // SqlCommand сommand = new SqlCommand("SELECT cd.Seria_and_number_of_car,d.FIO,c.Mark, COUNT(sv.NumOfViol) AS 'Кол-во нарушений' FROM CarDrivers AS cd JOIN  Drivers AS d ON cd.Seria_and_number_of_driver = d.Seria_and_number JOIN  Cars AS c ON cd.Seria_and_number_of_car = c.Seria_and_number JOIN SpecificViolation AS sv ON d.Seria_and_number = sv.Seria_and_number WHERE[Date] BETWEEN '2020-02-02' AND '2022-04-13' GROUP BY cd.Seria_and_number_of_car, d.FIO, c.Mark", dataBase.getConnection());

            SqlCommand сommand = new SqlCommand(sqlCommand, dataBase.getConnection());
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = сommand;

            builder = new SqlCommandBuilder(adapter);

            table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            // dataGridView.Dock = DockStyle.Fill;
            // Automatically generate the DataGridView columns.
            grd.AutoGenerateColumns = true;
            // Set up the data source.
            bindingSource1.DataSource = table;
            grd.DataSource = bindingSource1;
            // Automatically resize the visible rows.
            //   dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            // Set the DataGridView control's border.
            //  dataGridView.BorderStyle = BorderStyle.Fixed3D;
            // Put the cells in edit mode when user enters them.
            //dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView.SelectedNode.Text != "Таблицы")
            {
                labelTableSelected.Text = "Выбрана таблица: " + treeView.SelectedNode.Text;
            }
        }

        private void showColumnsOfTable (string tableName)
        {
            SqlCommand сommand = new SqlCommand($"SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('{tableName}') ", dataBase.getConnection());
            SqlDataReader reader = сommand.ExecuteReader();
            comboBox.Items.Clear();
            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString(1));
            }
            comboBox.SelectedItem = comboBox.Items[0];
            reader.Close();
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            //System.NullReferenceException
            TreeNode node = treeView.SelectedNode;
            //     /*
            if (node != null)
            {
                if (node.Text != "Таблицы") {
                    selectShow("select * from " + treeView.SelectedNode.Text, dataGridView);
                    showedTable = treeView.SelectedNode.Text;
                    showColumnsOfTable(treeView.SelectedNode.Text);
                }
                else
                {
                    MessageBox.Show("Не выбрана таблица для вывода", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Не выбрана таблица для вывода", "Ошибка");
            }
        }

        private void updateDB()
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Невзоможно сохранить данные, нет выведенной таблицы", "Ошибка");
            }
            else {
                try
                {
                    builder.GetUpdateCommand();
                    adapter.Update(table);
                    MessageBox.Show("Измененные данные успешно сохраненны в базе данных", "Сохранение");
                }
                catch
                {
                    MessageBox.Show("При сохранении данных произошла ошибка, не правильный тип данных для поля", "Ошибка");
                }
            }
        }

        private string userSqlCommandCheck() 
        {
            string check = "ok";
            if (admin == false)
            {
                string[] fobidenComands = { "insert", "delete", "update", "drop" };
                string str = richTextBox_sqlCommand.Text.ToLower();
                for (int i = 0; i < fobidenComands.Length; i++)
                {
                    if (str.Contains(fobidenComands[i]))
                    {
                        check = fobidenComands[i];
                    }
                }
            }
            return check;
        }

        private void button_executeCommand_Click(object sender, EventArgs e)
        {
            richTextBox_sqlCommandInput.ForeColor = System.Drawing.Color.Black;
            /*
            string str = richTextBox_sqlCommand.Text.ToLower();
            if (str.Contains("select"))
            {
                richTextBox_sqlCommandInput.Text = "working";
                selectShow(richTextBox_sqlCommand.Text,dataGridView_sqlCommandInput);
            }
            else {
                try
                {
                    SqlCommand сommand = new SqlCommand(richTextBox_sqlCommand.Text, dataBase.getConnection());
                    richTextBox_sqlCommandInput.Text = "Команда успешно выполнена"+ Environment.NewLine+ "Задействовано строк: " + сommand.ExecuteNonQuery().ToString();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    richTextBox_sqlCommandInput.ForeColor = System.Drawing.Color.Red;
                    richTextBox_sqlCommandInput.Text = "Неправильно введена SQL инструкция";
                }
            }
            */
            //Environment.NewLine
            //sp_helplogins 'admin'
            string str = userSqlCommandCheck();
            if (str == "ok")
            {
                try
                {
                    richTextBox_sqlCommandInput.Text = "Команда успешно выполнена";
                    selectShow(richTextBox_sqlCommand.Text, dataGridView_sqlCommandInput);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    richTextBox_sqlCommandInput.ForeColor = System.Drawing.Color.Red;
                    richTextBox_sqlCommandInput.Text = "Неправильно введена SQL инструкция";
                }
            }
            else 
            {
                MessageBox.Show("Вы юзер и не можете использовать команду " + str, "Ошибка");
            }


        }

        private void addUser(string login, string password, Boolean admin)
        {
            try
            {
                if (admin)
                {
                    SqlCommand сommand = new SqlCommand($@"CREATE USER {login} WITH PASSWORD = '{password}' ALTER ROLE db_datareader ADD MEMBER {login} ALTER ROLE db_datawriter ADD MEMBER {login} ALTER ROLE db_securityadmin ADD MEMBER {login}", dataBase.getConnection());
                    сommand.ExecuteNonQuery();
                }
                else {
                    SqlCommand сommand = new SqlCommand($@"CREATE USER {login} WITH PASSWORD = '{password}' ALTER ROLE db_datareader ADD MEMBER {login}", dataBase.getConnection());
                    сommand.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось добавить пользователя", "Ошибка");
            }
        }

        private void deleteUser(string login)
        {
            try
            {
                SqlCommand сommand = new SqlCommand($@"sp_dropuser '{login}'", dataBase.getConnection());
                сommand.ExecuteNonQuery();
              //  MessageBox.Show("Пользователь успешно удален", "Успех");
            }
            catch
            {
                MessageBox.Show("Не удалось удалить пользователя", "Ошибка");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            updateDB();
        }

        private void fillTreeViewUsers() 
        {
            SqlCommand сommand = new SqlCommand("SELECT pr.type_desc, pr.name, ISNULL(pe.state_desc, 'No permission statements') AS state_desc, ISNULL(pe.permission_name, 'No permission statements') AS permission_name FROM sys.database_principals AS pr LEFT JOIN sys.database_permissions AS pe ON pr.principal_id = pe.grantee_principal_id WHERE pr.is_fixed_role = 0 AND pr.type_desc = 'SQL_USER' AND state_desc='GRANT' ORDER BY pr.name, type_desc;", dataBase.getConnection());
            SqlDataReader reader = сommand.ExecuteReader();
            treeView_users.BeginUpdate();
            treeView_users.Nodes.Clear();
            treeView_users.Nodes.Add("Пользователи");
            treeView_users.EndUpdate();

            while (reader.Read())
            {
                treeView_users.BeginUpdate();
                treeView_users.Nodes[0].Nodes.Add(reader.GetString(1));
                treeView_users.EndUpdate();
            }
            reader.Close();
            treeView_users.Nodes[0].Expand();
        }

        private void button_deleteUser_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView_users.SelectedNode;
            if (node != null)
            {
                if (node.Text != "Пользователи")
                {
                    deleteUser(node.Text);
                    fillTreeViewUsers();
                }
                else
                {
                    MessageBox.Show("Не выбран пользователь для удаления", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Не выбран пользователь для удаления", "Ошибка");
            }
            
        }

        private void button_addUser_Click(object sender, EventArgs e)
        {
            if ((textBox_login.Text == "") | (textBox_password.Text == ""))
            {
                MessageBox.Show("Поля не могут быть пустыми", "Ошибка");
            }
            else 
            {
                addUser(textBox_login.Text, textBox_password.Text, checkBox_adminCheck.Checked);
                textBox_login.Text = "";
                textBox_password.Text = "";
                fillTreeViewUsers();
            }

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (showedTable != "")
            {
                selectShow($"select * from {showedTable} where {comboBox.SelectedItem}='{textBox_search.Text}'", dataGridView);
            }
            else 
            {
                MessageBox.Show("Не выбран таблица для поиска", "Ошибка");
            }
        }
    }
}

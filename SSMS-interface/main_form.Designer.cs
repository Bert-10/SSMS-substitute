
namespace SSMS_interface
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonShowTable = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button_update = new System.Windows.Forms.Button();
            this.labelTableSelected = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox_sqlCommand = new System.Windows.Forms.RichTextBox();
            this.button_executeCommand = new System.Windows.Forms.Button();
            this.richTextBox_sqlCommandInput = new System.Windows.Forms.RichTextBox();
            this.dataGridView_sqlCommandInput = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView_users = new System.Windows.Forms.TreeView();
            this.checkBox_adminCheck = new System.Windows.Forms.CheckBox();
            this.button_deleteUser = new System.Windows.Forms.Button();
            this.button_addUser = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sqlCommandInput)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(401, 435);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonShowTable
            // 
            this.buttonShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowTable.Location = new System.Drawing.Point(7, 239);
            this.buttonShowTable.Name = "buttonShowTable";
            this.buttonShowTable.Size = new System.Drawing.Size(202, 31);
            this.buttonShowTable.TabIndex = 1;
            this.buttonShowTable.Text = "Вывод таблицы";
            this.buttonShowTable.UseVisualStyleBackColor = true;
            this.buttonShowTable.Click += new System.EventHandler(this.buttonShowTable_Click);
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(206, 213);
            this.treeView.TabIndex = 4;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(641, 467);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблицы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.button_search);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_search);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.comboBox);
            this.splitContainer2.Panel1.Controls.Add(this.button_update);
            this.splitContainer2.Panel1.Controls.Add(this.treeView);
            this.splitContainer2.Panel1.Controls.Add(this.buttonShowTable);
            this.splitContainer2.Panel1.Controls.Add(this.labelTableSelected);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(627, 435);
            this.splitContainer2.SplitterDistance = 216;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update.Location = new System.Drawing.Point(3, 396);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(202, 34);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Сохранить измененные данные";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // labelTableSelected
            // 
            this.labelTableSelected.AutoSize = true;
            this.labelTableSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableSelected.Location = new System.Drawing.Point(4, 219);
            this.labelTableSelected.Name = "labelTableSelected";
            this.labelTableSelected.Size = new System.Drawing.Size(127, 15);
            this.labelTableSelected.TabIndex = 5;
            this.labelTableSelected.Text = "Таблица не выбрана";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(633, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL запросы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_sqlCommandInput);
            this.splitContainer1.Size = new System.Drawing.Size(633, 441);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 2;
            // 
            // richTextBox_sqlCommand
            // 
            this.richTextBox_sqlCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_sqlCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_sqlCommand.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_sqlCommand.Name = "richTextBox_sqlCommand";
            this.richTextBox_sqlCommand.Size = new System.Drawing.Size(272, 283);
            this.richTextBox_sqlCommand.TabIndex = 1;
            this.richTextBox_sqlCommand.Text = "";
            this.richTextBox_sqlCommand.WordWrap = false;
            // 
            // button_executeCommand
            // 
            this.button_executeCommand.Location = new System.Drawing.Point(3, 4);
            this.button_executeCommand.Name = "button_executeCommand";
            this.button_executeCommand.Size = new System.Drawing.Size(266, 43);
            this.button_executeCommand.TabIndex = 0;
            this.button_executeCommand.Text = "Выполнить SQL команду";
            this.button_executeCommand.UseVisualStyleBackColor = true;
            this.button_executeCommand.Click += new System.EventHandler(this.button_executeCommand_Click);
            // 
            // richTextBox_sqlCommandInput
            // 
            this.richTextBox_sqlCommandInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_sqlCommandInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_sqlCommandInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_sqlCommandInput.Name = "richTextBox_sqlCommandInput";
            this.richTextBox_sqlCommandInput.Size = new System.Drawing.Size(272, 97);
            this.richTextBox_sqlCommandInput.TabIndex = 0;
            this.richTextBox_sqlCommandInput.Text = "";
            // 
            // dataGridView_sqlCommandInput
            // 
            this.dataGridView_sqlCommandInput.AllowUserToAddRows = false;
            this.dataGridView_sqlCommandInput.AllowUserToDeleteRows = false;
            this.dataGridView_sqlCommandInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sqlCommandInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_sqlCommandInput.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_sqlCommandInput.Name = "dataGridView_sqlCommandInput";
            this.dataGridView_sqlCommandInput.ReadOnly = true;
            this.dataGridView_sqlCommandInput.Size = new System.Drawing.Size(351, 441);
            this.dataGridView_sqlCommandInput.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_login);
            this.tabPage2.Controls.Add(this.textBox_password);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.treeView_users);
            this.tabPage2.Controls.Add(this.checkBox_adminCheck);
            this.tabPage2.Controls.Add(this.button_deleteUser);
            this.tabPage2.Controls.Add(this.button_addUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(299, 105);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(195, 29);
            this.textBox_login.TabIndex = 9;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(299, 144);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(195, 29);
            this.textBox_password.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(217, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // treeView_users
            // 
            this.treeView_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView_users.Location = new System.Drawing.Point(6, 6);
            this.treeView_users.Name = "treeView_users";
            this.treeView_users.Size = new System.Drawing.Size(206, 213);
            this.treeView_users.TabIndex = 3;
            // 
            // checkBox_adminCheck
            // 
            this.checkBox_adminCheck.AutoSize = true;
            this.checkBox_adminCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_adminCheck.Location = new System.Drawing.Point(338, 190);
            this.checkBox_adminCheck.Name = "checkBox_adminCheck";
            this.checkBox_adminCheck.Size = new System.Drawing.Size(86, 28);
            this.checkBox_adminCheck.TabIndex = 2;
            this.checkBox_adminCheck.Text = "админ";
            this.checkBox_adminCheck.UseVisualStyleBackColor = true;
            // 
            // button_deleteUser
            // 
            this.button_deleteUser.Location = new System.Drawing.Point(6, 225);
            this.button_deleteUser.Name = "button_deleteUser";
            this.button_deleteUser.Size = new System.Drawing.Size(206, 36);
            this.button_deleteUser.TabIndex = 1;
            this.button_deleteUser.Text = "Удалить пользователя";
            this.button_deleteUser.UseVisualStyleBackColor = true;
            this.button_deleteUser.Click += new System.EventHandler(this.button_deleteUser_Click);
            // 
            // button_addUser
            // 
            this.button_addUser.Location = new System.Drawing.Point(288, 225);
            this.button_addUser.Name = "button_addUser";
            this.button_addUser.Size = new System.Drawing.Size(206, 36);
            this.button_addUser.TabIndex = 0;
            this.button_addUser.Text = "Добавить пользователя";
            this.button_addUser.UseVisualStyleBackColor = true;
            this.button_addUser.Click += new System.EventHandler(this.button_addUser_Click);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(3, 291);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(202, 23);
            this.comboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Столбец таблицы для поиска";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(3, 335);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(202, 20);
            this.textBox_search.TabIndex = 9;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(3, 361);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(202, 29);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите данные для поиска";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.richTextBox_sqlCommandInput);
            this.splitContainer3.Size = new System.Drawing.Size(272, 441);
            this.splitContainer3.SplitterDistance = 334;
            this.splitContainer3.SplitterWidth = 10;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.richTextBox_sqlCommand);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button_executeCommand);
            this.splitContainer4.Size = new System.Drawing.Size(272, 334);
            this.splitContainer4.SplitterDistance = 283;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 465);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "Работа с бд";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sqlCommandInput)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonShowTable;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTableSelected;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_executeCommand;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBox_sqlCommand;
        private System.Windows.Forms.RichTextBox richTextBox_sqlCommandInput;
        private System.Windows.Forms.DataGridView dataGridView_sqlCommandInput;
        private System.Windows.Forms.Button button_deleteUser;
        private System.Windows.Forms.Button button_addUser;
        private System.Windows.Forms.CheckBox checkBox_adminCheck;
        private System.Windows.Forms.TreeView treeView_users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineSimulator.Interfaces;
using MachineSimulator.SQLite;
using MachineSimulator.SQLServerCompact;

namespace MachineSimulator
{
    public partial class Form1 : Form
    {
        private IDatabaseEngine _databaseEngine;

        private ModalPopupForm _modalPopupForm;

        public Form1()
        {
            InitializeComponent();
            this._modalPopupForm = new ModalPopupForm();
        }


        // Events
        #region Events
        private void pictureBox_Sqlite_Click(object sender, EventArgs e)
        {
            this._databaseEngine = new SqliteEngine();
            this.HideMainMenu();
            pictureBox_LogoSqlite.Visible = true;
            pictureBox_LogoSSce.Visible = false;
            this.LoadContent();
        }

        private void pictureBox_SqlCe_Click(object sender, EventArgs e)
        {
            this._databaseEngine = new SqlCeEngine();
            this.HideMainMenu();
            pictureBox_LogoSqlite.Visible = false;
            pictureBox_LogoSSce.Visible = true;
            this.LoadContent();
        }

        private void comboBox_Connections_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dbName = ((string[]) comboBox_Connections.DataSource)[comboBox_Connections.SelectedIndex];
            
            try
            {
                AppEngine.CurrentDbName = dbName;
                _databaseEngine.Connect(AppEngine.CurrentDbName);
                this.SetCurrentConnectionText(AppEngine.CurrentDbName);
                MessageBox.Show($"Succesfully connected to {AppEngine.CurrentDbName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Exit();
        }

        private void button_Menu_CheckSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AppEngine.GetCurrentDbSize().ToString(CultureInfo.InvariantCulture) + @" kB");
        }

        private void button_Menu_Erase_Click(object sender, EventArgs e)
        {
            this.TruncateDatabase();
        }

        private void button_GenerateData_Click(object sender, EventArgs e)
        {
            this._modalPopupForm.ShowDialog();
        }
        #endregion


        // Methods
        #region Methods
        private void LoadContent()
        {
            try
            {
                // Collect available files
                AppEngine.GatherDbFiles(_databaseEngine.Extension);

                // Connect to database
                _databaseEngine.Connect(AppEngine.CurrentDbName);

                // Set UI
                this.InitializeConnectionComboBox(AppEngine.DbFilesNameList.ToArray());
                this.SetCurrentConnectionText(AppEngine.CurrentDbName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.ShowMainMenu();
            }
        }

        private void TruncateDatabase()
        {
            try
            {
                _databaseEngine.TruncateDatabase();
                MessageBox.Show(@"All database tables has been successfully truncated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.ShowMainMenu();
            }
        }


        #endregion


        // UI Helpers
        #region UI Helpers
        private void HideMainMenu()
        {
            pictureBox_SqlCe.Visible = false;
            pictureBox_Sqlite.Visible = false;
            groupBox_Main.Visible = true;
        }

        private void ShowMainMenu()
        {
            pictureBox_SqlCe.Visible = true;
            pictureBox_Sqlite.Visible = true;
            groupBox_Main.Visible = false;
        }

        private void Exit()
        {
            _databaseEngine.Close();
            ShowMainMenu();
        }

        private void SetCurrentConnectionText(string txt)
        {
            textBox_CurrentConnection.Text = txt;
        }

        private void InitializeConnectionComboBox(string[] list)
        {
            comboBox_Connections.DataSource = list;
            comboBox_Connections.SelectedIndex = 0;
            comboBox_Connections.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_Connections.SelectedIndexChanged += new System.EventHandler(this.comboBox_Connections_SelectedIndexChanged);
        }


        #endregion

 
    }
}

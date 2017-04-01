namespace MachineSimulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Sqlite = new System.Windows.Forms.PictureBox();
            this.pictureBox_SqlCe = new System.Windows.Forms.PictureBox();
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.groupBox_Simulator = new System.Windows.Forms.GroupBox();
            this.groupBox_SimulatorMenu = new System.Windows.Forms.GroupBox();
            this.button_GenerateData = new System.Windows.Forms.Button();
            this.button_Menu_Erase = new System.Windows.Forms.Button();
            this.button_Menu_CheckSize = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_LogoSSce = new System.Windows.Forms.PictureBox();
            this.pictureBox_LogoSqlite = new System.Windows.Forms.PictureBox();
            this.label_CurrentConnection = new System.Windows.Forms.Label();
            this.comboBox_Connections = new System.Windows.Forms.ComboBox();
            this.textBox_CurrentConnection = new System.Windows.Forms.TextBox();
            this.label_ChooseConnection = new System.Windows.Forms.Label();
            this.pictureBox_RobotArm = new System.Windows.Forms.PictureBox();
            this.groupBox_Connection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sqlite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SqlCe)).BeginInit();
            this.groupBox_Main.SuspendLayout();
            this.groupBox_Simulator.SuspendLayout();
            this.groupBox_SimulatorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoSSce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoSqlite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RobotArm)).BeginInit();
            this.groupBox_Connection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Sqlite
            // 
            this.pictureBox_Sqlite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Sqlite.Image")));
            this.pictureBox_Sqlite.Location = new System.Drawing.Point(8, 8);
            this.pictureBox_Sqlite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Sqlite.Name = "pictureBox_Sqlite";
            this.pictureBox_Sqlite.Size = new System.Drawing.Size(489, 244);
            this.pictureBox_Sqlite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Sqlite.TabIndex = 0;
            this.pictureBox_Sqlite.TabStop = false;
            this.pictureBox_Sqlite.Click += new System.EventHandler(this.pictureBox_Sqlite_Click);
            // 
            // pictureBox_SqlCe
            // 
            this.pictureBox_SqlCe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SqlCe.Image")));
            this.pictureBox_SqlCe.Location = new System.Drawing.Point(8, 255);
            this.pictureBox_SqlCe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_SqlCe.Name = "pictureBox_SqlCe";
            this.pictureBox_SqlCe.Size = new System.Drawing.Size(489, 244);
            this.pictureBox_SqlCe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_SqlCe.TabIndex = 1;
            this.pictureBox_SqlCe.TabStop = false;
            this.pictureBox_SqlCe.Click += new System.EventHandler(this.pictureBox_SqlCe_Click);
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.groupBox_Simulator);
            this.groupBox_Main.Controls.Add(this.button_Exit);
            this.groupBox_Main.Controls.Add(this.groupBox_Connection);
            this.groupBox_Main.Location = new System.Drawing.Point(8, 8);
            this.groupBox_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Main.Size = new System.Drawing.Size(489, 492);
            this.groupBox_Main.TabIndex = 2;
            this.groupBox_Main.TabStop = false;
            this.groupBox_Main.Text = "Administration Tool";
            this.groupBox_Main.Visible = false;
            // 
            // groupBox_Simulator
            // 
            this.groupBox_Simulator.Controls.Add(this.pictureBox_RobotArm);
            this.groupBox_Simulator.Controls.Add(this.groupBox_SimulatorMenu);
            this.groupBox_Simulator.Controls.Add(this.pictureBox_LogoSSce);
            this.groupBox_Simulator.Controls.Add(this.pictureBox_LogoSqlite);
            this.groupBox_Simulator.Location = new System.Drawing.Point(4, 140);
            this.groupBox_Simulator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Simulator.Name = "groupBox_Simulator";
            this.groupBox_Simulator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Simulator.Size = new System.Drawing.Size(481, 322);
            this.groupBox_Simulator.TabIndex = 8;
            this.groupBox_Simulator.TabStop = false;
            this.groupBox_Simulator.Text = "Simulator";
            // 
            // groupBox_SimulatorMenu
            // 
            this.groupBox_SimulatorMenu.Controls.Add(this.button_GenerateData);
            this.groupBox_SimulatorMenu.Controls.Add(this.button_Menu_Erase);
            this.groupBox_SimulatorMenu.Controls.Add(this.button_Menu_CheckSize);
            this.groupBox_SimulatorMenu.Location = new System.Drawing.Point(4, 16);
            this.groupBox_SimulatorMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_SimulatorMenu.Name = "groupBox_SimulatorMenu";
            this.groupBox_SimulatorMenu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_SimulatorMenu.Size = new System.Drawing.Size(163, 228);
            this.groupBox_SimulatorMenu.TabIndex = 0;
            this.groupBox_SimulatorMenu.TabStop = false;
            this.groupBox_SimulatorMenu.Text = "Menu";
            // 
            // button_GenerateData
            // 
            this.button_GenerateData.Location = new System.Drawing.Point(4, 77);
            this.button_GenerateData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_GenerateData.Name = "button_GenerateData";
            this.button_GenerateData.Size = new System.Drawing.Size(155, 27);
            this.button_GenerateData.TabIndex = 3;
            this.button_GenerateData.Text = "Generate data";
            this.button_GenerateData.UseVisualStyleBackColor = true;
            this.button_GenerateData.Click += new System.EventHandler(this.button_GenerateData_Click);
            // 
            // button_Menu_Erase
            // 
            this.button_Menu_Erase.Location = new System.Drawing.Point(4, 47);
            this.button_Menu_Erase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Menu_Erase.Name = "button_Menu_Erase";
            this.button_Menu_Erase.Size = new System.Drawing.Size(155, 27);
            this.button_Menu_Erase.TabIndex = 2;
            this.button_Menu_Erase.Text = "Truncate database";
            this.button_Menu_Erase.UseVisualStyleBackColor = true;
            this.button_Menu_Erase.Click += new System.EventHandler(this.button_Menu_Erase_Click);
            // 
            // button_Menu_CheckSize
            // 
            this.button_Menu_CheckSize.Location = new System.Drawing.Point(4, 16);
            this.button_Menu_CheckSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Menu_CheckSize.Name = "button_Menu_CheckSize";
            this.button_Menu_CheckSize.Size = new System.Drawing.Size(155, 27);
            this.button_Menu_CheckSize.TabIndex = 1;
            this.button_Menu_CheckSize.Text = "Check database size";
            this.button_Menu_CheckSize.UseVisualStyleBackColor = true;
            this.button_Menu_CheckSize.Click += new System.EventHandler(this.button_Menu_CheckSize_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(4, 466);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(481, 22);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox_LogoSSce
            // 
            this.pictureBox_LogoSSce.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LogoSSce.Image")));
            this.pictureBox_LogoSSce.Location = new System.Drawing.Point(4, 248);
            this.pictureBox_LogoSSce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_LogoSSce.Name = "pictureBox_LogoSSce";
            this.pictureBox_LogoSSce.Size = new System.Drawing.Size(163, 70);
            this.pictureBox_LogoSSce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_LogoSSce.TabIndex = 6;
            this.pictureBox_LogoSSce.TabStop = false;
            // 
            // pictureBox_LogoSqlite
            // 
            this.pictureBox_LogoSqlite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LogoSqlite.Image")));
            this.pictureBox_LogoSqlite.Location = new System.Drawing.Point(4, 248);
            this.pictureBox_LogoSqlite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_LogoSqlite.Name = "pictureBox_LogoSqlite";
            this.pictureBox_LogoSqlite.Size = new System.Drawing.Size(163, 70);
            this.pictureBox_LogoSqlite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LogoSqlite.TabIndex = 5;
            this.pictureBox_LogoSqlite.TabStop = false;
            // 
            // label_CurrentConnection
            // 
            this.label_CurrentConnection.AutoSize = true;
            this.label_CurrentConnection.Location = new System.Drawing.Point(4, 23);
            this.label_CurrentConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CurrentConnection.Name = "label_CurrentConnection";
            this.label_CurrentConnection.Size = new System.Drawing.Size(97, 13);
            this.label_CurrentConnection.TabIndex = 0;
            this.label_CurrentConnection.Text = "Current connection";
            // 
            // comboBox_Connections
            // 
            this.comboBox_Connections.FormattingEnabled = true;
            this.comboBox_Connections.Location = new System.Drawing.Point(7, 85);
            this.comboBox_Connections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Connections.Name = "comboBox_Connections";
            this.comboBox_Connections.Size = new System.Drawing.Size(470, 21);
            this.comboBox_Connections.TabIndex = 3;
            // 
            // textBox_CurrentConnection
            // 
            this.textBox_CurrentConnection.Enabled = false;
            this.textBox_CurrentConnection.Location = new System.Drawing.Point(7, 38);
            this.textBox_CurrentConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_CurrentConnection.Name = "textBox_CurrentConnection";
            this.textBox_CurrentConnection.Size = new System.Drawing.Size(470, 20);
            this.textBox_CurrentConnection.TabIndex = 1;
            // 
            // label_ChooseConnection
            // 
            this.label_ChooseConnection.AutoSize = true;
            this.label_ChooseConnection.Location = new System.Drawing.Point(4, 70);
            this.label_ChooseConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ChooseConnection.Name = "label_ChooseConnection";
            this.label_ChooseConnection.Size = new System.Drawing.Size(99, 13);
            this.label_ChooseConnection.TabIndex = 2;
            this.label_ChooseConnection.Text = "Choose connection";
            // 
            // pictureBox_RobotArm
            // 
            this.pictureBox_RobotArm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_RobotArm.Image")));
            this.pictureBox_RobotArm.Location = new System.Drawing.Point(171, 17);
            this.pictureBox_RobotArm.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_RobotArm.Name = "pictureBox_RobotArm";
            this.pictureBox_RobotArm.Size = new System.Drawing.Size(306, 301);
            this.pictureBox_RobotArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_RobotArm.TabIndex = 7;
            this.pictureBox_RobotArm.TabStop = false;
            // 
            // groupBox_Connection
            // 
            this.groupBox_Connection.Controls.Add(this.label_CurrentConnection);
            this.groupBox_Connection.Controls.Add(this.comboBox_Connections);
            this.groupBox_Connection.Controls.Add(this.textBox_CurrentConnection);
            this.groupBox_Connection.Controls.Add(this.label_ChooseConnection);
            this.groupBox_Connection.Location = new System.Drawing.Point(4, 23);
            this.groupBox_Connection.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Connection.Name = "groupBox_Connection";
            this.groupBox_Connection.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Connection.Size = new System.Drawing.Size(481, 114);
            this.groupBox_Connection.TabIndex = 4;
            this.groupBox_Connection.TabStop = false;
            this.groupBox_Connection.Text = "Database and connection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 508);
            this.Controls.Add(this.groupBox_Main);
            this.Controls.Add(this.pictureBox_SqlCe);
            this.Controls.Add(this.pictureBox_Sqlite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Machine .NET Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sqlite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SqlCe)).EndInit();
            this.groupBox_Main.ResumeLayout(false);
            this.groupBox_Simulator.ResumeLayout(false);
            this.groupBox_SimulatorMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoSSce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoSqlite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RobotArm)).EndInit();
            this.groupBox_Connection.ResumeLayout(false);
            this.groupBox_Connection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Sqlite;
        private System.Windows.Forms.PictureBox pictureBox_SqlCe;
        private System.Windows.Forms.GroupBox groupBox_Main;
        private System.Windows.Forms.Label label_CurrentConnection;
        private System.Windows.Forms.TextBox textBox_CurrentConnection;
        private System.Windows.Forms.Label label_ChooseConnection;
        private System.Windows.Forms.ComboBox comboBox_Connections;
        private System.Windows.Forms.PictureBox pictureBox_LogoSqlite;
        private System.Windows.Forms.PictureBox pictureBox_LogoSSce;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox_Simulator;
        private System.Windows.Forms.GroupBox groupBox_SimulatorMenu;
        private System.Windows.Forms.Button button_Menu_CheckSize;
        private System.Windows.Forms.Button button_Menu_Erase;
        private System.Windows.Forms.Button button_GenerateData;
        private System.Windows.Forms.PictureBox pictureBox_RobotArm;
        private System.Windows.Forms.GroupBox groupBox_Connection;
    }
}


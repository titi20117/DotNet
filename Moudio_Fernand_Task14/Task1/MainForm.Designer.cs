namespace Task1
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ctlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlFileRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctlUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAwards = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlAwards = new System.Windows.Forms.DataGridView();
            this.AwardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwardTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwardDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu.SuspendLayout();
            this.ctlTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFile,
            this.ctlHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ctlFile
            // 
            this.ctlFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlFileInsert,
            this.ctlFileEdit,
            this.ctlFileRemove,
            this.toolStripSeparator1,
            this.ctlFileExit});
            this.ctlFile.Name = "ctlFile";
            this.ctlFile.Size = new System.Drawing.Size(37, 20);
            this.ctlFile.Text = "File";
            // 
            // ctlFileInsert
            // 
            this.ctlFileInsert.Name = "ctlFileInsert";
            this.ctlFileInsert.Size = new System.Drawing.Size(180, 22);
            this.ctlFileInsert.Text = "Add";
            this.ctlFileInsert.Click += new System.EventHandler(this.ctlFileInsert_Click);
            // 
            // ctlFileEdit
            // 
            this.ctlFileEdit.Name = "ctlFileEdit";
            this.ctlFileEdit.Size = new System.Drawing.Size(180, 22);
            this.ctlFileEdit.Text = "Edit";
            this.ctlFileEdit.Click += new System.EventHandler(this.ctlFileEdit_Click);
            // 
            // ctlFileRemove
            // 
            this.ctlFileRemove.Name = "ctlFileRemove";
            this.ctlFileRemove.Size = new System.Drawing.Size(180, 22);
            this.ctlFileRemove.Text = "Delete";
            this.ctlFileRemove.Click += new System.EventHandler(this.ctlFileRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ctlFileExit
            // 
            this.ctlFileExit.Name = "ctlFileExit";
            this.ctlFileExit.Size = new System.Drawing.Size(180, 22);
            this.ctlFileExit.Text = "Exit";
            this.ctlFileExit.Click += new System.EventHandler(this.ctlFileExit_Click);
            // 
            // ctlHelp
            // 
            this.ctlHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlHelpAbout});
            this.ctlHelp.Name = "ctlHelp";
            this.ctlHelp.Size = new System.Drawing.Size(44, 20);
            this.ctlHelp.Text = "Help";
            // 
            // ctlHelpAbout
            // 
            this.ctlHelpAbout.Name = "ctlHelpAbout";
            this.ctlHelpAbout.Size = new System.Drawing.Size(168, 22);
            this.ctlHelpAbout.Text = "About program....";
            // 
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.tabPage1);
            this.ctlTab.Controls.Add(this.tabPage2);
            this.ctlTab.Location = new System.Drawing.Point(0, 92);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(800, 329);
            this.ctlTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlUsers);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlUsers
            // 
            this.ctlUsers.BackgroundColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctlUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ctlUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserFirstName,
            this.UserLastName,
            this.UserBirthdate,
            this.UserAge,
            this.UserAwards});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctlUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.ctlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsers.Location = new System.Drawing.Point(3, 3);
            this.ctlUsers.Name = "ctlUsers";
            this.ctlUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctlUsers.Size = new System.Drawing.Size(786, 297);
            this.ctlUsers.TabIndex = 0;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "ID";
            this.UserID.HeaderText = "ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 50;
            // 
            // UserFirstName
            // 
            this.UserFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserFirstName.DataPropertyName = "FirstName";
            this.UserFirstName.HeaderText = "First Name";
            this.UserFirstName.Name = "UserFirstName";
            // 
            // UserLastName
            // 
            this.UserLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserLastName.DataPropertyName = "LastName";
            this.UserLastName.HeaderText = "Last Name";
            this.UserLastName.Name = "UserLastName";
            // 
            // UserBirthdate
            // 
            this.UserBirthdate.DataPropertyName = "Birthdate";
            this.UserBirthdate.HeaderText = "Birthdate";
            this.UserBirthdate.Name = "UserBirthdate";
            // 
            // UserAge
            // 
            this.UserAge.DataPropertyName = "Age";
            this.UserAge.HeaderText = "Age";
            this.UserAge.Name = "UserAge";
            this.UserAge.ReadOnly = true;
            this.UserAge.Width = 50;
            // 
            // UserAwards
            // 
            this.UserAwards.DataPropertyName = "Award";
            this.UserAwards.HeaderText = "Awards";
            this.UserAwards.Name = "UserAwards";
            this.UserAwards.Text = "Show";
            this.UserAwards.UseColumnTextForButtonValue = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlAwards);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Awards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlAwards
            // 
            this.ctlAwards.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctlAwards.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ctlAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardID,
            this.AwardTitle,
            this.AwardDescription});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctlAwards.DefaultCellStyle = dataGridViewCellStyle4;
            this.ctlAwards.Location = new System.Drawing.Point(0, 6);
            this.ctlAwards.Name = "ctlAwards";
            this.ctlAwards.Size = new System.Drawing.Size(789, 294);
            this.ctlAwards.TabIndex = 0;
            // 
            // AwardID
            // 
            this.AwardID.DataPropertyName = "ID";
            this.AwardID.HeaderText = "ID";
            this.AwardID.Name = "AwardID";
            this.AwardID.ReadOnly = true;
            this.AwardID.Width = 50;
            // 
            // AwardTitle
            // 
            this.AwardTitle.DataPropertyName = "Title";
            this.AwardTitle.HeaderText = "Title";
            this.AwardTitle.Name = "AwardTitle";
            this.AwardTitle.Width = 200;
            // 
            // AwardDescription
            // 
            this.AwardDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AwardDescription.DataPropertyName = "Description";
            this.AwardDescription.HeaderText = "Description";
            this.AwardDescription.Name = "AwardDescription";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ctlTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlAwards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlFile;
        private System.Windows.Forms.ToolStripMenuItem ctlFileInsert;
        private System.Windows.Forms.ToolStripMenuItem ctlFileEdit;
        private System.Windows.Forms.ToolStripMenuItem ctlFileRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctlFileExit;
        private System.Windows.Forms.ToolStripMenuItem ctlHelp;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ctlUsers;
        private System.Windows.Forms.DataGridView ctlAwards;
        private System.Windows.Forms.ToolStripMenuItem ctlHelpAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAge;
        private System.Windows.Forms.DataGridViewButtonColumn UserAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardDescription;
    }
}


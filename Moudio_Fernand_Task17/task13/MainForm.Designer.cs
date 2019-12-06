namespace task13
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwRewards = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRewards = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditRewards = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.msFile = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRewards)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.msFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRewards
            // 
            this.dgwRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRewards.Location = new System.Drawing.Point(0, 3);
            this.dgwRewards.MaximumSize = new System.Drawing.Size(772, 185);
            this.dgwRewards.MinimumSize = new System.Drawing.Size(772, 185);
            this.dgwRewards.Name = "dgwRewards";
            this.dgwRewards.RowHeadersWidth = 30;
            this.dgwRewards.RowTemplate.Height = 24;
            this.dgwRewards.Size = new System.Drawing.Size(772, 185);
            this.dgwRewards.TabIndex = 1;
            this.dgwRewards.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_ColumnHeaderMouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 260);
            this.tabControl1.MaximumSize = new System.Drawing.Size(782, 195);
            this.tabControl1.MinimumSize = new System.Drawing.Size(782, 195);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 195);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwUsers
            // 
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Location = new System.Drawing.Point(0, 3);
            this.dgwUsers.MaximumSize = new System.Drawing.Size(772, 185);
            this.dgwUsers.MinimumSize = new System.Drawing.Size(772, 185);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.RowHeadersWidth = 30;
            this.dgwUsers.RowTemplate.Height = 24;
            this.dgwUsers.Size = new System.Drawing.Size(772, 185);
            this.dgwUsers.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgwRewards);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rewards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRewards,
            this.btnAddUsers,
            this.btnEditRewards,
            this.btnEditUsers});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(46, 24);
            this.file.Text = "File";
            // 
            // btnAddRewards
            // 
            this.btnAddRewards.Name = "btnAddRewards";
            this.btnAddRewards.Size = new System.Drawing.Size(224, 26);
            this.btnAddRewards.Text = "Add rewards";
            this.btnAddRewards.Click += new System.EventHandler(this.btnAddRewards_Click);
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(224, 26);
            this.btnAddUsers.Text = "Add users";
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnEditRewards
            // 
            this.btnEditRewards.Name = "btnEditRewards";
            this.btnEditRewards.Size = new System.Drawing.Size(224, 26);
            this.btnEditRewards.Text = "Edit rewards";
            this.btnEditRewards.Click += new System.EventHandler(this.btnEditRewards_Click);
            // 
            // btnEditUsers
            // 
            this.btnEditUsers.Name = "btnEditUsers";
            this.btnEditUsers.Size = new System.Drawing.Size(224, 26);
            this.btnEditUsers.Text = "Edit users";
            this.btnEditUsers.Click += new System.EventHandler(this.btnEditUsers_Click);
            // 
            // msFile
            // 
            this.msFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file});
            this.msFile.Location = new System.Drawing.Point(0, 0);
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(782, 28);
            this.msFile.TabIndex = 7;
            this.msFile.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.msFile);
            this.MainMenuStrip = this.msFile;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRewards)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.msFile.ResumeLayout(false);
            this.msFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgwRewards;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.DataGridView dgwUsers;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ToolStripMenuItem file;
        public System.Windows.Forms.ToolStripMenuItem btnAddRewards;
        public System.Windows.Forms.ToolStripMenuItem btnAddUsers;
        public System.Windows.Forms.ToolStripMenuItem btnEditRewards;
        public System.Windows.Forms.ToolStripMenuItem btnEditUsers;
        public System.Windows.Forms.MenuStrip msFile;
    }
}


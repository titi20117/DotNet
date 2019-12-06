namespace Task1
{
    partial class UserAwardForm
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
            this.dgvUserAward = new System.Windows.Forms.DataGridView();
            this.IDUserAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleUserAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionUserAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUserAwardAdd = new System.Windows.Forms.Button();
            this.btnUserAwardCancel = new System.Windows.Forms.Button();
            this.dgvListAward = new System.Windows.Forms.DataGridView();
            this.ListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserAward = new System.Windows.Forms.Label();
            this.lblListAward = new System.Windows.Forms.Label();
            this.btnUserAwardOK = new System.Windows.Forms.Button();
            this.btnUserAwardDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAward)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserAward
            // 
            this.dgvUserAward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDUserAward,
            this.TitleUserAward,
            this.DescriptionUserAward});
            this.dgvUserAward.Location = new System.Drawing.Point(12, 29);
            this.dgvUserAward.Name = "dgvUserAward";
            this.dgvUserAward.Size = new System.Drawing.Size(398, 355);
            this.dgvUserAward.TabIndex = 1;
            // 
            // IDUserAward
            // 
            this.IDUserAward.DataPropertyName = "ID";
            this.IDUserAward.HeaderText = "ID";
            this.IDUserAward.Name = "IDUserAward";
            this.IDUserAward.Width = 40;
            // 
            // TitleUserAward
            // 
            this.TitleUserAward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TitleUserAward.DataPropertyName = "Title";
            this.TitleUserAward.HeaderText = "Title";
            this.TitleUserAward.Name = "TitleUserAward";
            // 
            // DescriptionUserAward
            // 
            this.DescriptionUserAward.DataPropertyName = "Description";
            this.DescriptionUserAward.HeaderText = "Description";
            this.DescriptionUserAward.Name = "DescriptionUserAward";
            // 
            // btnUserAwardAdd
            // 
            this.btnUserAwardAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUserAwardAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserAwardAdd.FlatAppearance.BorderSize = 0;
            this.btnUserAwardAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAwardAdd.ForeColor = System.Drawing.Color.Green;
            this.btnUserAwardAdd.Location = new System.Drawing.Point(416, 176);
            this.btnUserAwardAdd.Name = "btnUserAwardAdd";
            this.btnUserAwardAdd.Size = new System.Drawing.Size(75, 39);
            this.btnUserAwardAdd.TabIndex = 2;
            this.btnUserAwardAdd.Text = "<<<";
            this.btnUserAwardAdd.UseVisualStyleBackColor = false;
            this.btnUserAwardAdd.Click += new System.EventHandler(this.btnUserAwardAdd_Click);
            // 
            // btnUserAwardCancel
            // 
            this.btnUserAwardCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAwardCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUserAwardCancel.Location = new System.Drawing.Point(267, 410);
            this.btnUserAwardCancel.Name = "btnUserAwardCancel";
            this.btnUserAwardCancel.Size = new System.Drawing.Size(93, 28);
            this.btnUserAwardCancel.TabIndex = 4;
            this.btnUserAwardCancel.Text = "Cancel";
            this.btnUserAwardCancel.UseVisualStyleBackColor = true;
            // 
            // dgvListAward
            // 
            this.dgvListAward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAward.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ListID,
            this.ListTitle,
            this.ListDescription});
            this.dgvListAward.Location = new System.Drawing.Point(497, 29);
            this.dgvListAward.Name = "dgvListAward";
            this.dgvListAward.Size = new System.Drawing.Size(376, 355);
            this.dgvListAward.TabIndex = 5;
            // 
            // ListID
            // 
            this.ListID.DataPropertyName = "ID";
            this.ListID.HeaderText = "ID";
            this.ListID.Name = "ListID";
            this.ListID.Width = 40;
            // 
            // ListTitle
            // 
            this.ListTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ListTitle.DataPropertyName = "Title";
            this.ListTitle.HeaderText = "Title";
            this.ListTitle.Name = "ListTitle";
            // 
            // ListDescription
            // 
            this.ListDescription.DataPropertyName = "Description";
            this.ListDescription.HeaderText = "Description";
            this.ListDescription.Name = "ListDescription";
            // 
            // lblUserAward
            // 
            this.lblUserAward.AutoSize = true;
            this.lblUserAward.Location = new System.Drawing.Point(12, 9);
            this.lblUserAward.Name = "lblUserAward";
            this.lblUserAward.Size = new System.Drawing.Size(90, 13);
            this.lblUserAward.TabIndex = 6;
            this.lblUserAward.Text = "Award for an user";
            // 
            // lblListAward
            // 
            this.lblListAward.AutoSize = true;
            this.lblListAward.Location = new System.Drawing.Point(494, 9);
            this.lblListAward.Name = "lblListAward";
            this.lblListAward.Size = new System.Drawing.Size(117, 13);
            this.lblListAward.TabIndex = 7;
            this.lblListAward.Text = "List of available awards";
            // 
            // btnUserAwardOK
            // 
            this.btnUserAwardOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAwardOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUserAwardOK.Location = new System.Drawing.Point(141, 415);
            this.btnUserAwardOK.Name = "btnUserAwardOK";
            this.btnUserAwardOK.Size = new System.Drawing.Size(75, 23);
            this.btnUserAwardOK.TabIndex = 8;
            this.btnUserAwardOK.Text = "Record";
            this.btnUserAwardOK.UseVisualStyleBackColor = true;
            this.btnUserAwardOK.Click += new System.EventHandler(this.btnUserAwardOK_Click);
            // 
            // btnUserAwardDelete
            // 
            this.btnUserAwardDelete.Location = new System.Drawing.Point(27, 415);
            this.btnUserAwardDelete.Name = "btnUserAwardDelete";
            this.btnUserAwardDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserAwardDelete.TabIndex = 9;
            this.btnUserAwardDelete.Text = "Delete";
            this.btnUserAwardDelete.UseVisualStyleBackColor = true;
            // 
            // UserAwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.btnUserAwardDelete);
            this.Controls.Add(this.btnUserAwardOK);
            this.Controls.Add(this.lblListAward);
            this.Controls.Add(this.lblUserAward);
            this.Controls.Add(this.dgvListAward);
            this.Controls.Add(this.btnUserAwardCancel);
            this.Controls.Add(this.btnUserAwardAdd);
            this.Controls.Add(this.dgvUserAward);
            this.Name = "UserAwardForm";
            this.Text = "UserAwardForm";
            this.Load += new System.EventHandler(this.UserAwardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUserAward;
        private System.Windows.Forms.Button btnUserAwardAdd;
        private System.Windows.Forms.Button btnUserAwardCancel;
        private System.Windows.Forms.DataGridView dgvListAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListDescription;
        private System.Windows.Forms.Label lblUserAward;
        private System.Windows.Forms.Label lblListAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUserAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleUserAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionUserAward;
        private System.Windows.Forms.Button btnUserAwardOK;
        private System.Windows.Forms.Button btnUserAwardDelete;
    }
}
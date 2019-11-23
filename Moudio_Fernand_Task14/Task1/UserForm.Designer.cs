namespace Task1
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.lblUserFirstName = new System.Windows.Forms.Label();
            this.lblUserLastName = new System.Windows.Forms.Label();
            this.lblUserBirthdate = new System.Windows.Forms.Label();
            this.textUserFirstName = new System.Windows.Forms.TextBox();
            this.textUserLastName = new System.Windows.Forms.TextBox();
            this.btnUserOK = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textUserID = new System.Windows.Forms.TextBox();
            this.btnUserAddAward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.Location = new System.Drawing.Point(49, 49);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblUserFirstName.TabIndex = 0;
            this.lblUserFirstName.Text = "First name";
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Location = new System.Drawing.Point(49, 86);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(58, 13);
            this.lblUserLastName.TabIndex = 1;
            this.lblUserLastName.Text = "Last Name";
            // 
            // lblUserBirthdate
            // 
            this.lblUserBirthdate.AutoSize = true;
            this.lblUserBirthdate.Location = new System.Drawing.Point(49, 126);
            this.lblUserBirthdate.Name = "lblUserBirthdate";
            this.lblUserBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblUserBirthdate.TabIndex = 2;
            this.lblUserBirthdate.Text = "Birthdate";
            // 
            // textUserFirstName
            // 
            this.textUserFirstName.Location = new System.Drawing.Point(165, 46);
            this.textUserFirstName.Name = "textUserFirstName";
            this.textUserFirstName.Size = new System.Drawing.Size(281, 20);
            this.textUserFirstName.TabIndex = 3;
            this.textUserFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textUserFirstName_Validating);
            this.textUserFirstName.Validated += new System.EventHandler(this.textUserFirstName_Validated);
            // 
            // textUserLastName
            // 
            this.textUserLastName.Location = new System.Drawing.Point(165, 83);
            this.textUserLastName.Name = "textUserLastName";
            this.textUserLastName.Size = new System.Drawing.Size(281, 20);
            this.textUserLastName.TabIndex = 4;
            this.textUserLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textUserLastName_Validating);
            this.textUserLastName.Validated += new System.EventHandler(this.textUserLastName_Validated);
            // 
            // btnUserOK
            // 
            this.btnUserOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUserOK.Location = new System.Drawing.Point(283, 176);
            this.btnUserOK.Name = "btnUserOK";
            this.btnUserOK.Size = new System.Drawing.Size(92, 23);
            this.btnUserOK.TabIndex = 6;
            this.btnUserOK.Text = "Save";
            this.btnUserOK.UseVisualStyleBackColor = true;
            this.btnUserOK.Click += new System.EventHandler(this.btnUserOK_Click);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUserCancel.Location = new System.Drawing.Point(401, 175);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(95, 23);
            this.btnUserCancel.TabIndex = 7;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(49, 13);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(18, 13);
            this.lblUserID.TabIndex = 8;
            this.lblUserID.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(1995, 1, 22, 0, 0, 0, 0);
            this.dateTimePicker1.Validated += new System.EventHandler(this.dateTimePicker1_Validated);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(165, 13);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(94, 20);
            this.textUserID.TabIndex = 11;
            this.textUserID.Validating += new System.ComponentModel.CancelEventHandler(this.textUserID_Validating);
            this.textUserID.Validated += new System.EventHandler(this.textUserID_Validated);
            // 
            // btnUserAddAward
            // 
            this.btnUserAddAward.Location = new System.Drawing.Point(22, 175);
            this.btnUserAddAward.Name = "btnUserAddAward";
            this.btnUserAddAward.Size = new System.Drawing.Size(75, 23);
            this.btnUserAddAward.TabIndex = 12;
            this.btnUserAddAward.Text = "Add Award";
            this.btnUserAddAward.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(524, 211);
            this.Controls.Add(this.btnUserAddAward);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.btnUserOK);
            this.Controls.Add(this.textUserLastName);
            this.Controls.Add(this.textUserFirstName);
            this.Controls.Add(this.lblUserBirthdate);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.lblUserFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserFirstName;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserBirthdate;
        private System.Windows.Forms.TextBox textUserFirstName;
        private System.Windows.Forms.TextBox textUserLastName;
        private System.Windows.Forms.Button btnUserOK;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Button btnUserAddAward;
    }
}
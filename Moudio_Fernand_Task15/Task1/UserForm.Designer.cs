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
            this.UserFirstNameBox = new System.Windows.Forms.TextBox();
            this.UserLastNameBox = new System.Windows.Forms.TextBox();
            this.btnUserOK = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUserAward = new System.Windows.Forms.Label();
            this.cbBoxAwards = new System.Windows.Forms.ComboBox();
            this.btnAddUserAward = new System.Windows.Forms.Button();
            this.btnDeleteUserAward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserFirstName
            // 
            this.lblUserFirstName.AutoSize = true;
            this.lblUserFirstName.Location = new System.Drawing.Point(49, 21);
            this.lblUserFirstName.Name = "lblUserFirstName";
            this.lblUserFirstName.Size = new System.Drawing.Size(55, 13);
            this.lblUserFirstName.TabIndex = 0;
            this.lblUserFirstName.Text = "First name";
            // 
            // lblUserLastName
            // 
            this.lblUserLastName.AutoSize = true;
            this.lblUserLastName.Location = new System.Drawing.Point(49, 53);
            this.lblUserLastName.Name = "lblUserLastName";
            this.lblUserLastName.Size = new System.Drawing.Size(58, 13);
            this.lblUserLastName.TabIndex = 1;
            this.lblUserLastName.Text = "Last Name";
            // 
            // lblUserBirthdate
            // 
            this.lblUserBirthdate.AutoSize = true;
            this.lblUserBirthdate.Location = new System.Drawing.Point(49, 90);
            this.lblUserBirthdate.Name = "lblUserBirthdate";
            this.lblUserBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblUserBirthdate.TabIndex = 2;
            this.lblUserBirthdate.Text = "Birthdate";
            // 
            // UserFirstNameBox
            // 
            this.UserFirstNameBox.Location = new System.Drawing.Point(145, 21);
            this.UserFirstNameBox.Name = "UserFirstNameBox";
            this.UserFirstNameBox.Size = new System.Drawing.Size(281, 20);
            this.UserFirstNameBox.TabIndex = 3;
            // 
            // UserLastNameBox
            // 
            this.UserLastNameBox.Location = new System.Drawing.Point(145, 53);
            this.UserLastNameBox.Name = "UserLastNameBox";
            this.UserLastNameBox.Size = new System.Drawing.Size(281, 20);
            this.UserLastNameBox.TabIndex = 4;
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
            this.btnUserCancel.Click += new System.EventHandler(this.BtnUserCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(1995, 1, 22, 0, 0, 0, 0);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblUserAward
            // 
            this.lblUserAward.AutoSize = true;
            this.lblUserAward.Location = new System.Drawing.Point(52, 129);
            this.lblUserAward.Name = "lblUserAward";
            this.lblUserAward.Size = new System.Drawing.Size(67, 13);
            this.lblUserAward.TabIndex = 11;
            this.lblUserAward.Text = "User Awards";
            // 
            // cbBoxAwards
            // 
            this.cbBoxAwards.FormattingEnabled = true;
            this.cbBoxAwards.Location = new System.Drawing.Point(145, 129);
            this.cbBoxAwards.Name = "cbBoxAwards";
            this.cbBoxAwards.Size = new System.Drawing.Size(121, 21);
            this.cbBoxAwards.TabIndex = 12;
            // 
            // btnAddUserAward
            // 
            this.btnAddUserAward.Location = new System.Drawing.Point(302, 126);
            this.btnAddUserAward.Name = "btnAddUserAward";
            this.btnAddUserAward.Size = new System.Drawing.Size(43, 23);
            this.btnAddUserAward.TabIndex = 13;
            this.btnAddUserAward.Text = "Add";
            this.btnAddUserAward.UseVisualStyleBackColor = true;
            this.btnAddUserAward.Click += new System.EventHandler(this.BtnAddUserAward_Click);
            // 
            // btnDeleteUserAward
            // 
            this.btnDeleteUserAward.Location = new System.Drawing.Point(370, 127);
            this.btnDeleteUserAward.Name = "btnDeleteUserAward";
            this.btnDeleteUserAward.Size = new System.Drawing.Size(38, 23);
            this.btnDeleteUserAward.TabIndex = 14;
            this.btnDeleteUserAward.Text = "Del";
            this.btnDeleteUserAward.UseVisualStyleBackColor = true;
            this.btnDeleteUserAward.Click += new System.EventHandler(this.BtnDeleteUserAward_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(524, 211);
            this.Controls.Add(this.btnDeleteUserAward);
            this.Controls.Add(this.btnAddUserAward);
            this.Controls.Add(this.cbBoxAwards);
            this.Controls.Add(this.lblUserAward);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.btnUserOK);
            this.Controls.Add(this.UserLastNameBox);
            this.Controls.Add(this.UserFirstNameBox);
            this.Controls.Add(this.lblUserBirthdate);
            this.Controls.Add(this.lblUserLastName);
            this.Controls.Add(this.lblUserFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserFirstName;
        private System.Windows.Forms.Label lblUserLastName;
        private System.Windows.Forms.Label lblUserBirthdate;
        private System.Windows.Forms.TextBox UserFirstNameBox;
        private System.Windows.Forms.TextBox UserLastNameBox;
        private System.Windows.Forms.Button btnUserOK;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnDeleteUserAward;
        private System.Windows.Forms.Button btnAddUserAward;
        private System.Windows.Forms.ComboBox cbBoxAwards;
        private System.Windows.Forms.Label lblUserAward;
    }
}
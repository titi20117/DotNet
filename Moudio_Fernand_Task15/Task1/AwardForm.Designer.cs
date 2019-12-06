namespace Task1
{
    partial class AwardForm
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
            this.lblAwardID = new System.Windows.Forms.Label();
            this.lblAwardTitle = new System.Windows.Forms.Label();
            this.lblAwardDescription = new System.Windows.Forms.Label();
            this.txtAwardTitle = new System.Windows.Forms.TextBox();
            this.txtAwardDescription = new System.Windows.Forms.TextBox();
            this.btnAwardOK = new System.Windows.Forms.Button();
            this.btnAwardCancel = new System.Windows.Forms.Button();
            this.txtAwardID = new System.Windows.Forms.TextBox();
            this.errorProviderAward = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAward)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAwardID
            // 
            this.lblAwardID.AutoSize = true;
            this.lblAwardID.Location = new System.Drawing.Point(28, 40);
            this.lblAwardID.Name = "lblAwardID";
            this.lblAwardID.Size = new System.Drawing.Size(18, 13);
            this.lblAwardID.TabIndex = 0;
            this.lblAwardID.Text = "ID";
            // 
            // lblAwardTitle
            // 
            this.lblAwardTitle.AutoSize = true;
            this.lblAwardTitle.Location = new System.Drawing.Point(28, 75);
            this.lblAwardTitle.Name = "lblAwardTitle";
            this.lblAwardTitle.Size = new System.Drawing.Size(27, 13);
            this.lblAwardTitle.TabIndex = 1;
            this.lblAwardTitle.Text = "Title";
            // 
            // lblAwardDescription
            // 
            this.lblAwardDescription.AutoSize = true;
            this.lblAwardDescription.Location = new System.Drawing.Point(28, 112);
            this.lblAwardDescription.Name = "lblAwardDescription";
            this.lblAwardDescription.Size = new System.Drawing.Size(60, 13);
            this.lblAwardDescription.TabIndex = 2;
            this.lblAwardDescription.Text = "Description";
            // 
            // txtAwardTitle
            // 
            this.txtAwardTitle.Location = new System.Drawing.Point(118, 72);
            this.txtAwardTitle.Name = "txtAwardTitle";
            this.txtAwardTitle.Size = new System.Drawing.Size(224, 20);
            this.txtAwardTitle.TabIndex = 4;
            this.txtAwardTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtAwardTitle_Validating);
            this.txtAwardTitle.Validated += new System.EventHandler(this.txtAwardTitle_Validated);
            // 
            // txtAwardDescription
            // 
            this.txtAwardDescription.Location = new System.Drawing.Point(118, 105);
            this.txtAwardDescription.Name = "txtAwardDescription";
            this.txtAwardDescription.Size = new System.Drawing.Size(224, 20);
            this.txtAwardDescription.TabIndex = 5;
            this.txtAwardDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtAwardDescription_Validating);
            this.txtAwardDescription.Validated += new System.EventHandler(this.txtAwardDescription_Validated);
            // 
            // btnAwardOK
            // 
            this.btnAwardOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAwardOK.Location = new System.Drawing.Point(163, 182);
            this.btnAwardOK.Name = "btnAwardOK";
            this.btnAwardOK.Size = new System.Drawing.Size(75, 23);
            this.btnAwardOK.TabIndex = 6;
            this.btnAwardOK.Text = "Save";
            this.btnAwardOK.UseVisualStyleBackColor = true;
            this.btnAwardOK.Click += new System.EventHandler(this.btnAwardOK_Click);
            // 
            // btnAwardCancel
            // 
            this.btnAwardCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAwardCancel.Location = new System.Drawing.Point(267, 182);
            this.btnAwardCancel.Name = "btnAwardCancel";
            this.btnAwardCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAwardCancel.TabIndex = 7;
            this.btnAwardCancel.Text = "Cancel";
            this.btnAwardCancel.UseVisualStyleBackColor = true;
            // 
            // txtAwardID
            // 
            this.txtAwardID.Location = new System.Drawing.Point(118, 40);
            this.txtAwardID.Name = "txtAwardID";
            this.txtAwardID.Size = new System.Drawing.Size(100, 20);
            this.txtAwardID.TabIndex = 8;
            this.txtAwardID.Validating += new System.ComponentModel.CancelEventHandler(this.txtAwardID_Validating);
            this.txtAwardID.Validated += new System.EventHandler(this.txtAwardID_Validated);
            // 
            // errorProviderAward
            // 
            this.errorProviderAward.ContainerControl = this;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(365, 221);
            this.Controls.Add(this.txtAwardID);
            this.Controls.Add(this.btnAwardCancel);
            this.Controls.Add(this.btnAwardOK);
            this.Controls.Add(this.txtAwardDescription);
            this.Controls.Add(this.txtAwardTitle);
            this.Controls.Add(this.lblAwardDescription);
            this.Controls.Add(this.lblAwardTitle);
            this.Controls.Add(this.lblAwardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AwardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AwardForm";
            this.Load += new System.EventHandler(this.AwardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAward)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAwardID;
        private System.Windows.Forms.Label lblAwardTitle;
        private System.Windows.Forms.Label lblAwardDescription;
        private System.Windows.Forms.TextBox txtAwardTitle;
        private System.Windows.Forms.TextBox txtAwardDescription;
        private System.Windows.Forms.Button btnAwardOK;
        private System.Windows.Forms.Button btnAwardCancel;
        private System.Windows.Forms.TextBox txtAwardID;
        private System.Windows.Forms.ErrorProvider errorProviderAward;
    }
}
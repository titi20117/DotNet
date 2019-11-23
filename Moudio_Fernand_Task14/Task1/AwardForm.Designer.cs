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
            this.lblAwardID = new System.Windows.Forms.Label();
            this.lblAwardTitle = new System.Windows.Forms.Label();
            this.lblAwardDescription = new System.Windows.Forms.Label();
            this.numericUpDownAwardID = new System.Windows.Forms.NumericUpDown();
            this.txtAwardTitle = new System.Windows.Forms.TextBox();
            this.textAwardDescription = new System.Windows.Forms.TextBox();
            this.btnAwardSave = new System.Windows.Forms.Button();
            this.btnAwardCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAwardID)).BeginInit();
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
            // numericUpDownAwardID
            // 
            this.numericUpDownAwardID.Location = new System.Drawing.Point(118, 38);
            this.numericUpDownAwardID.Name = "numericUpDownAwardID";
            this.numericUpDownAwardID.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAwardID.TabIndex = 3;
            this.numericUpDownAwardID.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownAwardID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAwardTitle
            // 
            this.txtAwardTitle.Location = new System.Drawing.Point(118, 72);
            this.txtAwardTitle.Name = "txtAwardTitle";
            this.txtAwardTitle.Size = new System.Drawing.Size(224, 20);
            this.txtAwardTitle.TabIndex = 4;
            // 
            // textAwardDescription
            // 
            this.textAwardDescription.Location = new System.Drawing.Point(118, 105);
            this.textAwardDescription.Name = "textAwardDescription";
            this.textAwardDescription.Size = new System.Drawing.Size(224, 20);
            this.textAwardDescription.TabIndex = 5;
            // 
            // btnAwardSave
            // 
            this.btnAwardSave.Location = new System.Drawing.Point(163, 182);
            this.btnAwardSave.Name = "btnAwardSave";
            this.btnAwardSave.Size = new System.Drawing.Size(75, 23);
            this.btnAwardSave.TabIndex = 6;
            this.btnAwardSave.Text = "Save";
            this.btnAwardSave.UseVisualStyleBackColor = true;
            // 
            // btnAwardCancel
            // 
            this.btnAwardCancel.Location = new System.Drawing.Point(267, 182);
            this.btnAwardCancel.Name = "btnAwardCancel";
            this.btnAwardCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAwardCancel.TabIndex = 7;
            this.btnAwardCancel.Text = "Cancel";
            this.btnAwardCancel.UseVisualStyleBackColor = true;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 221);
            this.Controls.Add(this.btnAwardCancel);
            this.Controls.Add(this.btnAwardSave);
            this.Controls.Add(this.textAwardDescription);
            this.Controls.Add(this.txtAwardTitle);
            this.Controls.Add(this.numericUpDownAwardID);
            this.Controls.Add(this.lblAwardDescription);
            this.Controls.Add(this.lblAwardTitle);
            this.Controls.Add(this.lblAwardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AwardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AwardForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAwardID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAwardID;
        private System.Windows.Forms.Label lblAwardTitle;
        private System.Windows.Forms.Label lblAwardDescription;
        private System.Windows.Forms.NumericUpDown numericUpDownAwardID;
        private System.Windows.Forms.TextBox txtAwardTitle;
        private System.Windows.Forms.TextBox textAwardDescription;
        private System.Windows.Forms.Button btnAwardSave;
        private System.Windows.Forms.Button btnAwardCancel;
    }
}
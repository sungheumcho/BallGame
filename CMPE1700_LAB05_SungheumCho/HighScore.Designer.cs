namespace CMPE1700_LAB05_SungheumCho
{
    partial class HighScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.UI_tbxName = new System.Windows.Forms.TextBox();
            this.UI_btnOK = new System.Windows.Forms.Button();
            this.UI_btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // UI_tbxName
            // 
            this.UI_tbxName.Location = new System.Drawing.Point(111, 26);
            this.UI_tbxName.Name = "UI_tbxName";
            this.UI_tbxName.Size = new System.Drawing.Size(216, 22);
            this.UI_tbxName.TabIndex = 1;
            // 
            // UI_btnOK
            // 
            this.UI_btnOK.Location = new System.Drawing.Point(15, 71);
            this.UI_btnOK.Name = "UI_btnOK";
            this.UI_btnOK.Size = new System.Drawing.Size(75, 23);
            this.UI_btnOK.TabIndex = 2;
            this.UI_btnOK.Text = "OK";
            this.UI_btnOK.UseVisualStyleBackColor = true;
            this.UI_btnOK.Click += new System.EventHandler(this.UI_btnOK_Click);
            // 
            // UI_btnCancel
            // 
            this.UI_btnCancel.Location = new System.Drawing.Point(251, 71);
            this.UI_btnCancel.Name = "UI_btnCancel";
            this.UI_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.UI_btnCancel.TabIndex = 3;
            this.UI_btnCancel.Text = "Cancel";
            this.UI_btnCancel.UseVisualStyleBackColor = true;
            this.UI_btnCancel.Click += new System.EventHandler(this.UI_btnCancel_Click);
            // 
            // HighScore
            // 
            this.AcceptButton = this.UI_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 106);
            this.Controls.Add(this.UI_btnCancel);
            this.Controls.Add(this.UI_btnOK);
            this.Controls.Add(this.UI_tbxName);
            this.Controls.Add(this.label1);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_tbxName;
        private System.Windows.Forms.Button UI_btnOK;
        private System.Windows.Forms.Button UI_btnCancel;
    }
}
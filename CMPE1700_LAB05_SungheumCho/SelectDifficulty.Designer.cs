namespace CMPE1700_LAB05_SungheumCho
{
    partial class SelectDifficulty
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_rbtnHard = new System.Windows.Forms.RadioButton();
            this.UI_rbtnMedium = new System.Windows.Forms.RadioButton();
            this.UI_rbtnEasy = new System.Windows.Forms.RadioButton();
            this.UI_btnOK = new System.Windows.Forms.Button();
            this.UI_btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_rbtnHard);
            this.groupBox1.Controls.Add(this.UI_rbtnMedium);
            this.groupBox1.Controls.Add(this.UI_rbtnEasy);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // UI_rbtnHard
            // 
            this.UI_rbtnHard.AutoSize = true;
            this.UI_rbtnHard.Location = new System.Drawing.Point(7, 88);
            this.UI_rbtnHard.Name = "UI_rbtnHard";
            this.UI_rbtnHard.Size = new System.Drawing.Size(60, 21);
            this.UI_rbtnHard.TabIndex = 2;
            this.UI_rbtnHard.Text = "Hard";
            this.UI_rbtnHard.UseVisualStyleBackColor = true;
            this.UI_rbtnHard.CheckedChanged += new System.EventHandler(this.UI_rbtnHard_CheckedChanged);
            // 
            // UI_rbtnMedium
            // 
            this.UI_rbtnMedium.AutoSize = true;
            this.UI_rbtnMedium.Location = new System.Drawing.Point(7, 60);
            this.UI_rbtnMedium.Name = "UI_rbtnMedium";
            this.UI_rbtnMedium.Size = new System.Drawing.Size(78, 21);
            this.UI_rbtnMedium.TabIndex = 1;
            this.UI_rbtnMedium.Text = "Medium";
            this.UI_rbtnMedium.UseVisualStyleBackColor = true;
            this.UI_rbtnMedium.CheckedChanged += new System.EventHandler(this.UI_rbtnMedium_CheckedChanged);
            // 
            // UI_rbtnEasy
            // 
            this.UI_rbtnEasy.AutoSize = true;
            this.UI_rbtnEasy.Checked = true;
            this.UI_rbtnEasy.Location = new System.Drawing.Point(7, 32);
            this.UI_rbtnEasy.Name = "UI_rbtnEasy";
            this.UI_rbtnEasy.Size = new System.Drawing.Size(60, 21);
            this.UI_rbtnEasy.TabIndex = 0;
            this.UI_rbtnEasy.TabStop = true;
            this.UI_rbtnEasy.Text = "Easy";
            this.UI_rbtnEasy.UseVisualStyleBackColor = true;
            this.UI_rbtnEasy.CheckedChanged += new System.EventHandler(this.UI_rbtnEasy_CheckedChanged);
            // 
            // UI_btnOK
            // 
            this.UI_btnOK.Location = new System.Drawing.Point(12, 162);
            this.UI_btnOK.Name = "UI_btnOK";
            this.UI_btnOK.Size = new System.Drawing.Size(75, 23);
            this.UI_btnOK.TabIndex = 1;
            this.UI_btnOK.Text = "OK";
            this.UI_btnOK.UseVisualStyleBackColor = true;
            this.UI_btnOK.Click += new System.EventHandler(this.UI_btnOK_Click);
            // 
            // UI_btnCancel
            // 
            this.UI_btnCancel.Location = new System.Drawing.Point(137, 162);
            this.UI_btnCancel.Name = "UI_btnCancel";
            this.UI_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.UI_btnCancel.TabIndex = 2;
            this.UI_btnCancel.Text = "Cancel";
            this.UI_btnCancel.UseVisualStyleBackColor = true;
            this.UI_btnCancel.Click += new System.EventHandler(this.UI_btnCancel_Click);
            // 
            // SelectDifficulty
            // 
            this.AcceptButton = this.UI_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 203);
            this.Controls.Add(this.UI_btnCancel);
            this.Controls.Add(this.UI_btnOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectDifficulty";
            this.Text = "SelectDifficulty";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_rbtnHard;
        private System.Windows.Forms.RadioButton UI_rbtnMedium;
        private System.Windows.Forms.RadioButton UI_rbtnEasy;
        private System.Windows.Forms.Button UI_btnOK;
        private System.Windows.Forms.Button UI_btnCancel;
    }
}
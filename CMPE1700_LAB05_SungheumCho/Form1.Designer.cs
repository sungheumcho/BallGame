namespace CMPE1700_LAB05_SungheumCho
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
            this.components = new System.ComponentModel.Container();
            this.UI_cbxShowScore = new System.Windows.Forms.CheckBox();
            this.UI_cbxShowAniSpeed = new System.Windows.Forms.CheckBox();
            this.UI_btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_cbxShowScore
            // 
            this.UI_cbxShowScore.AutoSize = true;
            this.UI_cbxShowScore.Location = new System.Drawing.Point(13, 13);
            this.UI_cbxShowScore.Name = "UI_cbxShowScore";
            this.UI_cbxShowScore.Size = new System.Drawing.Size(105, 21);
            this.UI_cbxShowScore.TabIndex = 0;
            this.UI_cbxShowScore.Text = "Show Score";
            this.UI_cbxShowScore.UseVisualStyleBackColor = true;
            this.UI_cbxShowScore.CheckedChanged += new System.EventHandler(this.UI_cbxShowScore_CheckedChanged);
            // 
            // UI_cbxShowAniSpeed
            // 
            this.UI_cbxShowAniSpeed.AutoSize = true;
            this.UI_cbxShowAniSpeed.Location = new System.Drawing.Point(13, 41);
            this.UI_cbxShowAniSpeed.Name = "UI_cbxShowAniSpeed";
            this.UI_cbxShowAniSpeed.Size = new System.Drawing.Size(175, 21);
            this.UI_cbxShowAniSpeed.TabIndex = 1;
            this.UI_cbxShowAniSpeed.Text = "Show Animation Speed";
            this.UI_cbxShowAniSpeed.UseVisualStyleBackColor = true;
            this.UI_cbxShowAniSpeed.CheckedChanged += new System.EventHandler(this.UI_cbxShowAniSpeed_CheckedChanged);
            // 
            // UI_btnPlay
            // 
            this.UI_btnPlay.Location = new System.Drawing.Point(133, 80);
            this.UI_btnPlay.Name = "UI_btnPlay";
            this.UI_btnPlay.Size = new System.Drawing.Size(75, 23);
            this.UI_btnPlay.TabIndex = 2;
            this.UI_btnPlay.Text = "Play";
            this.UI_btnPlay.UseVisualStyleBackColor = true;
            this.UI_btnPlay.Click += new System.EventHandler(this.UI_btnPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.UI_btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 115);
            this.Controls.Add(this.UI_btnPlay);
            this.Controls.Add(this.UI_cbxShowAniSpeed);
            this.Controls.Add(this.UI_cbxShowScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_cbxShowScore;
        private System.Windows.Forms.CheckBox UI_cbxShowAniSpeed;
        private System.Windows.Forms.Button UI_btnPlay;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace CMPE1700_LAB05_SungheumCho
{
    partial class AnimationSpeed
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
            this.UI_tbarAni = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_tbarAni)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_tbarAni
            // 
            this.UI_tbarAni.Location = new System.Drawing.Point(13, 12);
            this.UI_tbarAni.Maximum = 200;
            this.UI_tbarAni.Minimum = 10;
            this.UI_tbarAni.Name = "UI_tbarAni";
            this.UI_tbarAni.Size = new System.Drawing.Size(257, 56);
            this.UI_tbarAni.TabIndex = 0;
            this.UI_tbarAni.TickFrequency = 10;
            this.UI_tbarAni.Value = 10;
            this.UI_tbarAni.Scroll += new System.EventHandler(this.UI_tbarAni_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "10ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "200ms";
            // 
            // AnimationSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 106);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_tbarAni);
            this.Name = "AnimationSpeed";
            this.Text = "AnimationSpeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationSpeed_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_tbarAni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_tbarAni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1700_LAB05_SungheumCho
{
    
    public partial class AnimationSpeed : Form
    {
        public DelVoidVoid aniCheckBoxOff = null;
        public DelVoidInt aniSpeed = null;
        public AnimationSpeed()
        {
            InitializeComponent();
        }

        //if the user close the form, uncheck the check box in the main form
        private void AnimationSpeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (aniCheckBoxOff !=null)
                {
                    
                    e.Cancel = true;
                    aniCheckBoxOff.Invoke();
                    this.Hide();
                }
            }           
        }

        //using delegate to transfer animation speed to main form
        private void UI_tbarAni_Scroll(object sender, EventArgs e)
        {
            if (aniSpeed != null)
            {
                aniSpeed.Invoke((int)UI_tbarAni.Value);
            }
        }
    }
}

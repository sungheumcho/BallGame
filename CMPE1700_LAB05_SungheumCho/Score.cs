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
    public partial class Score : Form
    {
        public DelVoidVoid checkboxHide=null;
        int score = 0;
        public Score()
        {
            InitializeComponent();
        }

        //setting the score into the score label
        public int setScore
        {
            set { score = value;
                UI_lblScore.Text = score.ToString();
            }
        }

        //if the user close the form, uncheck the check box in the main form
        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (checkboxHide != null)
                {
                    checkboxHide.Invoke();
                    e.Cancel = true;
                    this.Hide();
                }
            }
        }
    }
}

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
    public partial class SelectDifficulty : Form
    {
        //different color of the ball that could be generated
        Color[] colors = new Color[5] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange };
        Random random = new Random();
        //randomly generated balls is stored
        Ball[,] ballArray;

        static int width = 0, height = 0;   
        //use to send what user selected for the difficulty to the main form
        string level;

        //setting the max balls in the array for x-axis
        public int SetWidth{
            set{width = value;}
        }
        //setting the max balls in the array for y-axis
        public int SetHeight
        {
            set { height = value; }
        }

        //transfering what difficulty user selected to main form
        public string GetLevel
        {
            get { return level; }
        }

        //returning randomly generated balls to the main form
        public Ball[,] GetBallArray
        {
            get { return ballArray; }
        }

        public SelectDifficulty()
        {
            InitializeComponent();
        }

        //for easy mode
        private void UI_rbtnEasy_CheckedChanged(object sender, EventArgs e)
        {
            ballArray = new Ball[width + 1, height + 1];
            level = "Easy";
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    ballArray[i, j] = new Ball(colors[random.Next(0, 3)]);
                }
            }
        }

        //for medium mode
        private void UI_rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            ballArray = new Ball[width + 1, height + 1];
            level = "Medium";
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    ballArray[i, j] = new Ball(colors[random.Next(0, 4)]);
                }
            }
        }

        //for hard mode
        private void UI_rbtnHard_CheckedChanged(object sender, EventArgs e)
        {
            ballArray = new Ball[width + 1, height + 1];
            level = "Hard";
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    ballArray[i, j] = new Ball(colors[random.Next(0, 5)]);
                }
            }
        }

        private void UI_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //if user press ok in the difficulty form 
        private void UI_btnOK_Click(object sender, EventArgs e)
        {
            //if easy mode is check for default, make easy mode's ball array
            if (UI_rbtnEasy.Checked) { UI_rbtnEasy_CheckedChanged(sender, e); }
            DialogResult = DialogResult.OK;
        }
    }
}

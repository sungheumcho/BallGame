//*****************************************************************************
//Program: LAB5.cs
//Description: Designing “Dropping Object” game using arrays, structures 
//and recursion to create a graphical game 
//Date: Apr. 19/2018
//Author: Sungheum Cho
//Course: CMPE1600
//Class: CNTA02
//*****************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1700_LAB05_SungheumCho
{
    //delegates to share infomation between other form
    //and in thread
    public delegate void DelVoidVoid();
    public delegate void DelVoidInt(int num);
    public delegate int DelIntVoid();
    
    //each ball's status, if it alive or dead
    //and it will only print alive balls
    public enum State { Alive, Dead }

    //the ball's infomation
    public struct Ball
    {
        public Color ballColor;
        public State state;
        public Ball(Color c)
        {
            ballColor = c;
            state = State.Alive;
        }
    }
    public partial class Form1 : Form
    {
        //initializing new forms
        //selecting difficulty form
        SelectDifficulty selectDifficulty;
        //animation speed form
        AnimationSpeed animationSpeedForm;
        //score form
        Score scoreForm = new Score();

        //initializing CDrawer
        static CDrawer _canvas = new CDrawer();

        //constants variables
        const int ballSize = 50;
        //x & y position for how many balls can fit in specific size of canvas
        static int width = _canvas.ScaledWidth / ballSize;
        static int height = _canvas.ScaledHeight / ballSize;

        //creating 2D array for balls to display in the canvas
        Ball[,] ballArray = new Ball[width , height ];
        //initial score is zero
        int score = 0;
        //initial animation speed is 10
        int aniSpeed = 10;
        //getting information about what difficulty user selected
        string level;

        public Form1()
        {
            InitializeComponent();
        }

        //when user clicks play button
        private void UI_btnPlay_Click(object sender, EventArgs e)
        {           
            //if select difficulty form is not made 
            if (selectDifficulty == null)
            {
                //new difficulty form
                selectDifficulty = new SelectDifficulty();
                //passing max balls in x & y axis to randomly generate balls
                selectDifficulty.SetWidth = width;
                selectDifficulty.SetHeight = height;              
            }
            //if user presses OK in difficulty form
            if (selectDifficulty.ShowDialog() == DialogResult.OK)
            {               
                score = 0;
                timer1.Enabled = true;
                UI_btnPlay.Enabled = false;

                //getting randomly generated balls into the form's array
                ballArray = selectDifficulty.GetBallArray;
                //getting info about selected difficulty
                level = selectDifficulty.GetLevel;
                //in score form set score as 0
                scoreForm.setScore = 0;
                //display balls in canvas
                Display(_canvas);
            }          
        }

        //display all the balls that in the array
        private void Display(CDrawer _canvas)
        {
            _canvas.Clear();

            //going over x and y axis and adding circles into the canvas
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    //if the ball is alive add the circle into that location
                    if (ballArray[i, j].state == State.Alive)
                    {
                        _canvas.AddEllipse(i * ballSize, j * ballSize, ballSize, ballSize, ballArray[i, j].ballColor);                       
                    }                   
                }              
            }
        }

        //checking how many balls are alive in the array in that instance
        private int Ballalive(Ball[,] balls)
        {
            int ballAlive = 0;

            //going over x and y axis to see how many balls are alive
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    if (balls[i, j].state == State.Alive)
                    {
                        ballAlive++;
                    }
                }
            }
            //and return amount of balls that are alive
            return ballAlive;
        }

        //at the specific location kill the balls with same color
        private int CheckBalls(int x, int y, Color color)
        {
            int killed = 0;
            //escape conditions 
            //if the position is out of bound in canvas size, return
            if (x < 0 || y < 0 || x>width || y>height) { return 0; }
            //if all the balls are dead, return
            if (ballArray[x, y].state == State.Dead) { return 0; }
            //if the ball with same color is dead at the instance, return
            if (ballArray[x, y].ballColor != color) { return 0; }

            //selected position's ball is killed
            ballArray[x, y].state = State.Dead;
            killed += 1;

            //checks left, right, up, down to see any same color ball
            //needed to be killed
            killed += CheckBalls(x + 1, y, color);
            killed += CheckBalls(x - 1, y, color);
            killed += CheckBalls(x, y + 1, color);
            killed += CheckBalls(x, y - 1, color);

            return killed;
        }
        //once balls are killed move down balls that are still alive
        private int StepDown(Ball[,] balls, CDrawer _canvas)
        {
            int ballDroped = 0;
            
            //going over 2D array of the ball
            for (int j = 0; j < height; ++j)
            {
                for (int i = 0; i < width; ++i)
                {
                    //if the current position's ball is dead
                    if (balls[i, j].state == State.Dead)
                    {
                        //and the upper ball in that current postion is alive or not out of bound
                        //then switch those two position, if not remain  
                        if (j - 1 >= 0 && balls[i, j - 1].state == State.Alive)
                        {
                            balls[i, j].ballColor = balls[i, j - 1].ballColor;
                            balls[i, j].state = State.Alive;
                            balls[i, j - 1].state = State.Dead;
                            ballDroped++;                    
                        }
                    }
                }
            }

            Display(_canvas);

            //Delay the ball drop thus it looks like balls are dropping down
            Thread.Sleep(aniSpeed);

            return ballDroped;
        }

        //keeps dropping the balls until no more ball is dropped
        private int FallDown(Ball[,] balls, CDrawer _canvas)
        {
            int totalBallDroped = 0;
            int ballDropped = 0;

            while (true)
            {
                //keep track of how many balls are dropped
                ballDropped = StepDown(balls, _canvas);
                //until no more ball is dropped, exit
                if (ballDropped == 0)
                    break;
                totalBallDroped += ballDropped;
            }
            //returns total balls that are dropped in that instance
            return totalBallDroped;
        }

        //when user picks the ball at specific location
        private int Pick(Ball[,] balls, CDrawer _canvas)
        {
            int x = 0;
            int y = 0;
            int killed = 0;
            Point pos = new Point();

            //when user presses the left mouse 
            if (_canvas.GetLastMousePosition(out pos))
            {
                //getting the x and y index of the position clicked
                x = pos.X / ballSize;
                y = pos.Y / ballSize;
                //getting value of how many balls are killed
                killed = CheckBalls(x, y, balls[x, y].ballColor);
            }
            //drops all the balls that are alive 
            FallDown(balls, _canvas);
            //if number of balls killed is more than 1 then bouns score
            if (killed > 1)
            {
                killed += 2;
            }
            return 50 * killed;
        }

        //if user clicks the score check box 
        private void UI_cbxShowScore_CheckedChanged(object sender, EventArgs e)
        {
            //if the check box is checked shows the score form
            //and pass in call back method of score check box off 
            if (UI_cbxShowScore.Checked)
            {
                scoreForm.Show();
                scoreForm.checkboxHide = setScoreCheckBoxOff;
            }
            else
            {
                scoreForm.Hide();
            }
        }

        //if user clicks the animation speed check box 
        private void UI_cbxShowAniSpeed_CheckedChanged(object sender, EventArgs e)
        {
            //if user checks it, show the speed form
            if (UI_cbxShowAniSpeed.Checked)
            {
                if (animationSpeedForm == null)
                {
                    animationSpeedForm = new AnimationSpeed();
                }
                animationSpeedForm.Show();
                //setting call back method for setting the animation speed, and check box off 
                animationSpeedForm.aniSpeed = setSpeed;
                animationSpeedForm.aniCheckBoxOff = setAniCheckBoxOff;
            }
            else
            {
                animationSpeedForm.Hide();
            }
        }

        //when game is started, constantly checking score and balls status
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point point = new Point();

            //if the user clicks left mouse
            if (_canvas.GetLastMouseLeftClick(out point))
            {
                //getting the score for that instance of how many balls are killed
                score += Pick(ballArray, _canvas);
                //update the score in the form
                Invoke(new DelVoidInt(setScore), score);

                //if all the balls are killed, game is done
                if (Ballalive(ballArray) == 0)
                {
                    _canvas.AddText("Game Over!", 50);
                    //enable the play button agian
                    Invoke(new DelVoidVoid(enableButton));
                    //make new high score form
                    HighScore hs = new HighScore();
                    //if user wants to store the name for the game play
                    if (hs.ShowDialog() == DialogResult.OK)
                    {
                        string name = hs.GetUserName;

                        //write the name, level, and score into the file name highscore.txt
                        try
                        {
                            StreamWriter sw = new StreamWriter("HighScore.txt", true);
                            sw.WriteLine(name + "," + level + "," + score);
                            sw.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error!");
                        }
                    }
                }
            }
        }

        //call back methods
        private void enableButton()
        {
            UI_btnPlay.Enabled = true;
        }

        private void setScore(int s)
        {
            scoreForm.setScore = score;
        }

        private void setScoreCheckBoxOff()
        {
            UI_cbxShowScore.Checked = false;
        }

        private void setAniCheckBoxOff()
        {
            UI_cbxShowAniSpeed.Checked = false;
        }

        private void setSpeed(int speed)
        {
            aniSpeed = speed;
        }

      
    }
}

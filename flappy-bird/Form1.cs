using System;
using System.Windows.Forms;
using System.Media;

namespace flappy_bird
{
    public partial class Form1 : Form
    {

        private SoundPlayer _soundPlayer1 , _soundPlayer2, _soundPlayer3;
        
        int gravity = 13;
        int speedpipe = 6;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            _soundPlayer1 = new SoundPlayer("2flappybird.wav");
            _soundPlayer2 = new SoundPlayer("1flappybird.wav");
            _soundPlayer3 = new SoundPlayer("3flappybird.wav");
        }
        
        private void gametimer(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipebottom.Left -= speedpipe;
            pipebottom2.Left -= speedpipe;
            pipebottom3.Left -= speedpipe;
            pipebottom4.Left -= speedpipe;
            pipetop.Left -= speedpipe;
            pipetop2.Left -= speedpipe;
            pipetop3.Left -= speedpipe;
            pipetop4.Left -= speedpipe;

            score1.Text = "Score: " + score;

            if (pipebottom.Left < -50)
            {
                _soundPlayer1.Play();
                pipebottom.Left = 1316;
                score++;
                
            }
            else if (pipetop.Left < -50)
            {
                pipetop.Left = 1310;
            }
            else if (pipebottom2.Left < -50)
            {
                _soundPlayer1.Play();
                pipebottom2.Left = 1316;
                score++;
            }
            else if (pipetop2.Left < -50)
            {
                pipetop2.Left = 1310;
            }
            else if (pipebottom3.Left < -50)
            {
                pipebottom3.Left = 1316;
                score++;
            }
            else if (pipetop3.Left < -50)
            {
                _soundPlayer1.Play();
                pipetop3.Left = 1310;
            }
            else if (pipebottom4.Left < -50)
            {
                pipebottom4.Left = 1316;
                score++;
            }
            else if (pipetop4.Left < -50)
            {
                _soundPlayer1.Play();
                pipetop4.Left = 1310;
            }

            if(flappybird.Bounds.IntersectsWith(pictureBox4.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipebottom.Bounds) || flappybird.Bounds.IntersectsWith(pipetop.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipebottom2.Bounds) || flappybird.Bounds.IntersectsWith(pipetop2.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipebottom3.Bounds) || flappybird.Bounds.IntersectsWith(pipetop3.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipebottom4.Bounds) || flappybird.Bounds.IntersectsWith(pipetop4.Bounds))
            {
                _soundPlayer3.Stop();
                endgame();
                _soundPlayer2.Play();
            }

            increaseSpeed();

        }

        private void gamebirdKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -12;
            }
            if(e.KeyCode == Keys.P)
            {
                timer1.Stop();
                pause.Hide();
                start.Show();
                
            }
            
            else if(e.KeyCode == Keys.S)
            {
                timer1.Start();
                pause.Show();
                start.Hide();

            }
          
        }

        private void gamebirdKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _soundPlayer3.Play();
                gravity = 7;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start.Hide();
            startGameagain.Hide();
            exit.Hide();

        }

        public void endgame()
        {
            timer1.Stop();
            gameover.Text = "Game Over!! " + "\n    Score: "+ score;
            exit.Show();
            score1.Hide();
            pause.Hide();
            startGameagain.Show();
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void increaseSpeed()
        {
            int scorevalue = 5;
            int speedvalue = 8;

            for (int i = 1; i < scorevalue; i++)
            {

                if (score >= scorevalue)
                {
                    speedpipe = speedvalue;
                    scorevalue += 5;
                    speedvalue += 2;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

       
    }
}

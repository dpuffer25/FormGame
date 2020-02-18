using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FormGame
{
    public partial class PowForm : Form
    {
        Random r;

        int tartgetSpeed;
        int totalScore;
        int secondsLeft;

        SoundPlayer soundPlayer;


        public PowForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void targetTimer_Tick(object sender, EventArgs e)
        {

         //   tartgetSpeed = r.Next(2, 11); 
            targetPictureBox.Left = targetPictureBox.Left + tartgetSpeed;
            if (targetPictureBox.Left >= this.Width)
            {
                // picTarget.Left = 24;
                targetPictureBox.Location = new Point(0, 34);
                tartgetSpeed = r.Next(4, 15);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {


            r = new Random();
            tartgetSpeed = r.Next(4, 15);
           
            targetTimer.Interval = 20;
            gameTimer.Interval = 1000;
            bulletTimer.Interval = 10;

            targetPictureBox.Left = 0;
            bulletPictureBox.Top = 250;

            totalScore = 0;
            powPrefixLabel.Text = Convert.ToString(totalScore);

            statusLabel.Visible = true;
            targetPictureBox.Visible = true;
            bulletPictureBox.Visible = true;

            fireButton.Enabled = true;
            fireButton.Visible = true;
            powPrefixLabel.Visible = true;
            powSuffixLabel.Visible = true;


            secondsLeft = 60;
            statusLabel.Text = Convert.ToString(secondsLeft);

            targetTimer.Start();
            gameTimer.Start();

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft = secondsLeft - 1;
            if (secondsLeft > 0)
                statusLabel.Text = Convert.ToString(secondsLeft);
            else
            {
                gameTimer.Stop();
                bulletTimer.Stop();
                targetTimer.Stop();
                fireButton.Enabled = false;

                statusLabel.Text = "Game Over";
            }
            

        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            bulletPictureBox.Visible = true;
            bulletTimer.Start();
        }

        private void bulletTimer_Tick(object sender, EventArgs e)
        {
            bulletPictureBox.Top -= 7;
            if (Collided())
            {
                totalScore = totalScore + 1;
                powPrefixLabel.Text = Convert.ToString(totalScore);

                bulletTimer.Stop();
                targetTimer.Stop();
              
              //  picTarget.Image = FormGame.Properties.Resources.ship;
                targetPictureBox.ImageLocation = "pow.png";
                   
                targetPictureBox.Height = 0;
                targetPictureBox.Width = 0;
                bulletPictureBox.Visible = false;

                powTimer.Start();


            }

            if (bulletPictureBox.Top <= 0)
            {
                bulletTimer.Stop();
                bulletPictureBox.Visible = true;
                bulletPictureBox.Top = 250;

            }
        }

        private bool Collided()
        {
            if ((bulletPictureBox.Left >= targetPictureBox.Left && bulletPictureBox.Left <= targetPictureBox.Right) &&
              (bulletPictureBox.Top <= targetPictureBox.Bottom && bulletPictureBox.Top >= targetPictureBox.Top))
            {
                return true;

            }
 
            if ((bulletPictureBox.Right >= targetPictureBox.Left && bulletPictureBox.Right <= targetPictureBox.Right) &&
                (bulletPictureBox.Top <= targetPictureBox.Bottom && bulletPictureBox.Top >= targetPictureBox.Top))
            {
                return true;

            }
            else
                return false;


        }

        private void powTimer_Tick(object sender, EventArgs e)
        {
   
                targetPictureBox.Height++;
                targetPictureBox.Width++;

                if (targetPictureBox.Width == 25)
                {
                    powTimer.Stop();
                    bulletPictureBox.Top = 250;
                    bulletPictureBox.Visible = true;

                    targetPictureBox.Height = 40;
                    targetPictureBox.Width = 40;
                    targetPictureBox.Location = new Point(0, 34);
                    targetPictureBox.ImageLocation = "ship.png";

                    tartgetSpeed = r.Next(4, 15);

                    targetTimer.Start();
                    
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer("s2.wav");
            soundPlayer.Load();
            soundPlayer.PlayLooping();
        }

        private void PowForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Right:
            
                bulletPictureBox.Left += 10;
                    break;

                case Keys.Left:
            
                  bulletPictureBox.Left -= 10;
                    break;

                case Keys.Space:
            
                    fireButton_Click(this, EventArgs.Empty);
                    break;
            }

        }

        private void PowForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //use a and d keys for left and right
            switch (e.KeyChar)
            {
                case 'd':

                    bulletPictureBox.Left += 10;
                    break;

                case 'a':

                    bulletPictureBox.Left -= 10;
                    break;

                case ' ':

                    fireButton_Click(this, EventArgs.Empty);
                    break;
            }

        }
    }
}

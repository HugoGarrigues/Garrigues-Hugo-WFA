using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // Variables Personnages //
        bool goLeft, goRight, jumping, isGameOver, canJump;
        int jumpSpeed;
        int playerSpeed = 6;

        bool isPlayerDead = false;

        int borderSize = 15;
        int score = 0;

        // Variables RockHead //
        int rockheadSpeed = 2;
        bool isDescending = true;
        int PositionInitial = 55;
        int PositionFinal = 191;
        int PositionActuel;

        Label deathLabel;
        Label deathLabel2;

        public Form1()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
            deathLabel = labelMort;
            deathLabel2 = labelMort2;

        }


        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (player.Left < borderSize)
            {
                player.Left = borderSize;
            }
            if (player.Right > ClientSize.Width - borderSize)
            {
                player.Left = ClientSize.Width - player.Width - borderSize;
            }
            if (player.Top < borderSize)
            {
                player.Top = borderSize;
            }


            if (jumping)
            {
                player.Top -= jumpSpeed;
                jumpSpeed--;
                if (jumpSpeed <= 0)
                {
                    jumping = false;
                }
            }
            else
            {
                if (player.Top + player.Height < this.ClientSize.Height)
                {
                    player.Top += 5;
                }
                else
                {
                    canJump = true;
                }
            }
            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight && player.Right < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            /* quand il passe sur un spiketrap ca tp le player */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "spiketrap")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameTimer.Stop();
                        isPlayerDead = true;
                        deathLabel.Visible = true;
                        deathLabel2.Visible = true;
                    }
                }
            }
            /* recupere apple et incremente score */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "apple")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        Controls.Remove(control);
                        score++;
                        txtScore.Text = "Score : " + score.ToString();
                    }
                }
            }
            /* Collision du haut de la platform */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "platform")
                {
                    PictureBox platform = (PictureBox)control;
                    if (player.Bounds.IntersectsWith(platform.Bounds))
                    {
                        if (player.Bottom > platform.Top && player.Top < platform.Top)
                        {
                            player.Top = platform.Top - player.Height;
                            jumpSpeed = 0;
                            canJump = true;
                        }
                        else if (player.Top < platform.Bottom && player.Bottom > platform.Bottom)
                        {
                            player.Top = platform.Bottom;
                            jumpSpeed = 0;
                            jumping = false;
                        }
                    }
                }
            }
            /* Mouvement rockhead */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag is string tag && tag == "rockhead")
                {
                    if (isDescending)
                    {
                        PositionActuel += rockheadSpeed;
                        if (PositionActuel >= PositionFinal)
                        {
                            PositionActuel = PositionFinal;
                            isDescending = false;
                        }
                    }
                    else
                    {
                        PositionActuel -= rockheadSpeed;
                        if (PositionActuel <= PositionInitial)
                        {
                            PositionActuel = PositionInitial;
                            isDescending = true;
                        }
                    }
                    control.Top = PositionActuel;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "rockhead")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameTimer.Stop();
                        isPlayerDead = true;
                        deathLabel.Visible = true;
                        deathLabel2.Visible = true;
                    }
                }
            }


            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "floor")
                {
                    PictureBox floor = (PictureBox)control;

                    if (player.Bounds.IntersectsWith(floor.Bounds))
                    {
                        player.Top = floor.Top - player.Height;
                        jumpSpeed = 0;
                        canJump = true;
                    }
                }
            }

            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "door")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameTimer.Stop();
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.Show();
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (!isPlayerDead) 
            {
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                }
                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                }
                if (e.KeyCode == Keys.Space && !jumping && canJump)
                {
                    jumping = true;
                    jumpSpeed = 10;
                    canJump = false;
                }
            }
            else if (e.KeyCode == Keys.R) 
            {
                Respawn(); 
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }
        private void Respawn()
        {
            player.Location = new Point(20, 319);

            jumping = false;
            canJump = true;
            jumpSpeed = 0;

            GameTimer.Start();
            isPlayerDead = false;

            deathLabel.Visible = false;
            deathLabel2.Visible = false;

        }

        private void ClosedGame(object sender, FormClosedEventArgs e)
        {
        }
    }
}
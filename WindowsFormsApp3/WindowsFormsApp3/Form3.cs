using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.Form1;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        bool goLeft, goRight, jumping, isGameOver, canJump;
        int jumpSpeed;
        int playerSpeed = 6;

        bool isPlayerDead = false;

        int borderSize = 15;

        // Variables Saw //
        int sawSpeed = 2;
        bool deplacement = true;
        int PositionInitial = 296;
        int PositionFinal = 447;
        int PositionActuel;

        Label deathLabel;
        Label deathLabel2;
        public Form3()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
            deathLabel = labelMort;
            deathLabel2 = labelMort2;
            this.KeyDown += Form2_KeyDown;
            PositionActuel = PositionInitial;
            txtScore.Text = "Score : " + GameData.Score.ToString();
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
                        GameData.Score++;
                        txtScore.Text = "Score : " + GameData.Score.ToString();
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
            /* Mouvement saw */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag is string tag && tag == "saw")
                {
                    if (deplacement)
                    {
                        PositionActuel += sawSpeed;
                        if (PositionActuel >= PositionFinal)
                        {
                            PositionActuel = PositionFinal;
                            deplacement = false;
                        }
                    }
                    else
                    {
                        PositionActuel -= sawSpeed;
                        if (PositionActuel <= PositionInitial)
                        {
                            PositionActuel = PositionInitial;
                            deplacement = true;
                        }
                    }
                    control.Left = PositionActuel;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "saw")
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
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "grass")
                {
                    PictureBox grass = (PictureBox)control;
                    if (player.Bounds.IntersectsWith(grass.Bounds) && player.Bottom >= grass.Top && player.Top < grass.Top + playerSpeed)
                    {
                        player.Top = grass.Top - player.Height;
                        jumpSpeed = 0;
                        canJump = true;
                    }
                    else if (player.Bounds.IntersectsWith(grass.Bounds) && player.Right >= grass.Left && player.Right <= grass.Left + playerSpeed)
                    {
                        player.Left = grass.Left - player.Width;
                    }
                    else if (player.Bounds.IntersectsWith(grass.Bounds) && player.Left <= grass.Right && player.Left >= grass.Right - playerSpeed)
                    {
                        player.Left = grass.Right;
                    }
                }
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "trampoline")
                {
                    PictureBox trampoline = (PictureBox)control;
                    if (player.Bounds.IntersectsWith(trampoline.Bounds) && player.Bottom >= trampoline.Top && player.Bottom <= trampoline.Top + playerSpeed)
                    {
                        jumpSpeed = 20;
                        canJump = false;
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
                        Fin fin = new Fin();
                        this.Hide();
                        fin.Show();
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
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

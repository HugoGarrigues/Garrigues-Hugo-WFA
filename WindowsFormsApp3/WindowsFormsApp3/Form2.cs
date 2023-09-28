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
    public partial class Form2 : Form
    {
        bool goLeft, goRight, jumping, isGameOver, canJump;
        int jumpSpeed;
        int score = 0;
        int playerSpeed = 6;
        int borderSize = 15;


        int rockheadSpeed = 2;
        private bool isDescending = true;
        private int initialY = 55;
        private int finalY = 191;
        private int currentY;
        public Form2()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
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
                        player.Location = new Point(20, 319);
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
                        currentY += rockheadSpeed;
                        if (currentY >= finalY)
                        {
                            currentY = finalY;
                            isDescending = false;
                        }
                    }
                    else
                    {
                        currentY -= rockheadSpeed;
                        if (currentY <= initialY)
                        {
                            currentY = initialY;
                            isDescending = true;
                        }
                    }
                    control.Top = currentY;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "rockhead")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        player.Location = new Point(20, 319);
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

        }


        private void KeyIsDown(object sender, KeyEventArgs e)
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

        private void ClosedGame(object sender, FormClosedEventArgs e)
        {

        }
    }
}

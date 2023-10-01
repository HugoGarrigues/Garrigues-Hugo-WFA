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
    public partial class Form4 : Form
    {
        bool goLeft, goRight, jumping, canJump;
        int jumpSpeed;
        int playerSpeed = 6;

        bool isPlayerDead = false;

        int borderSize = 15;

        // Variables Rock X //
        int rockspeedX = 5;
        bool deplacementX = true;
        int PositionInitialX = 106;
        int PositionFinalX = 502;
        int PositionActuelX;

        // Variables Rock Y //
        int rockheadSpeedY = 2;
        bool isDescendingY = true;
        int PositionInitialY = 186;
        int PositionFinalY = 264;
        int PositionActuelY;

        // Variables Saw X //

        int sawSpeed = 2;
        bool deplacementSaw = true;
        int PositionInitialSaw = 81;
        int PositionFinalSaw = 214;
        int PositionActuelSaw;


        int PositionInitial = 314;
        bool playerOnSpecialPlatform = false;

        Label deathLabel;
        Label deathLabel2;
        public Form4()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
            this.KeyDown += Form_KeyDown;
            deathLabel = labelMort;
            deathLabel2 = labelMort2;
            PositionActuelX = PositionInitialX;
            PositionActuelY = PositionInitialY;
            PositionActuelSaw = PositionInitialSaw;
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
            /* Mouvement Rockhead */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag is string tag && tag == "rockheadRight")
                {
                    if (deplacementX)
                    {
                        PositionActuelX += rockspeedX;
                        if (PositionActuelX >= PositionFinalX)
                        {
                            PositionActuelX = PositionFinalX;
                            deplacementX = false;
                        }
                    }
                    else
                    {
                        PositionActuelX -= rockspeedX;
                        if (PositionActuelX <= PositionInitialX)
                        {
                            PositionActuelX = PositionInitialX;
                            deplacementX = true;
                        }
                    }
                    control.Left = PositionActuelX;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "rockheadRight")
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
                if (control is PictureBox && control.Tag is string tag && tag == "rockheadbottom")
                {
                    if (isDescendingY)
                    {
                        PositionActuelY += rockheadSpeedY;
                        if (PositionActuelY >= PositionFinalY)
                        {
                            PositionActuelY = PositionFinalY;
                            isDescendingY = false;
                        }
                    }
                    else
                    {
                        PositionActuelY -= rockheadSpeedY;
                        if (PositionActuelY <= PositionInitialY)
                        {
                            PositionActuelY = PositionInitialY;
                            isDescendingY = true;
                        }
                    }
                    control.Top = PositionActuelY;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "rockheadbottom")
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
                        jumpSpeed = 12;
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
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag is string tag && tag == "saw")
                {
                    if (deplacementSaw)
                    {
                        PositionActuelSaw += sawSpeed;
                        if (PositionActuelSaw >= PositionFinalSaw)
                        {
                            PositionActuelSaw = PositionFinalSaw;
                            deplacementSaw = false;
                        }
                    }
                    else
                    {
                        PositionActuelSaw -= sawSpeed;
                        if (PositionActuelSaw <= PositionInitialSaw)
                        {
                            PositionActuelSaw = PositionInitialSaw;
                            deplacementSaw = true;
                        }
                    }
                    control.Left = PositionActuelSaw;
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
            player.Location = new Point(16, 27);

            jumping = false;
            canJump = true;
            jumpSpeed = 0;

            GameTimer.Start();
            isPlayerDead = false;

            deathLabel.Visible = false;
            deathLabel2.Visible = false;

            GameData.Mort++;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
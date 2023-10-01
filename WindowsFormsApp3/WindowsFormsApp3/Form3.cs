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
        // Variables Personnages //
        bool goLeft, goRight, jumping, canJump;
        int jumpSpeed;
        int playerSpeed = 6;
        bool isPlayerDead = false;

        // Variables Autres
        int borderSize = 15;
        Label deathLabel;
        Label deathLabel2;

        // Variables Rockhead //
        int rockSpeed = 5;
        bool deplacement = true;
        int PositionInitial = 291;
        int PositionFinal = 503;
        int PositionActuel;


        public Form3()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
            this.KeyDown += Form_KeyDown;
            deathLabel = labelMort;
            deathLabel2 = labelMort2;
            PositionActuel = PositionInitial;
            txtScore.Text = "Score : " + GameData.Score.ToString();
        }

        // Fonction MainTimerEvent //
        private void MainTimerEvent(object sender, EventArgs e)
        {
            // Conditions permettant de gérer les collisions avec les bordures du jeu ( Marge de 15 pixels ajouter pour correspondre a l'esthétique ) //
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

            // Conditions si le personnage saute qui sert a décrementer la jumpspeed pendant le saut et une fois la distance du saut atteint passe la valeur du saut a 0 pour le faire tomber //
            if (jumping)
            {
                player.Top -= jumpSpeed;
                jumpSpeed--;
                if (jumpSpeed <= 0)
                {
                    jumping = false;
                }
            }
            // Conditions su le personnage n'est pas en train de sauter et donc lui accorder un nouveau saut / baisse le player pour faire qu'il retombe plus lentement ( système de gravité )  // 
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
            // Gestions des mouvements gauche et droite en fonction de la vitesse de déplacement ( playerspeed )//
            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight && player.Right < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            /* Boucle qui fait en sorte que les spike trap tue le player quand il rentre en contact avec */
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
            /* Boucle qui gere l'implémentation du score en fonction de la pomme récupéré */
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
            /* Boucle qui gere les collisions entre le player et la plateforme */
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
            /* Boucle qui gere les mouvement de la rockhead a l'horizontal */
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag is string tag && tag == "rockhead")
                {
                    if (deplacement)
                    {
                        PositionActuel += rockSpeed;
                        if (PositionActuel >= PositionFinal)
                        {
                            PositionActuel = PositionFinal;
                            deplacement = false;
                        }
                    }
                    else
                    {
                        PositionActuel -= rockSpeed;
                        if (PositionActuel <= PositionInitial)
                        {
                            PositionActuel = PositionInitial;
                            deplacement = true;
                        }
                    }
                    control.Left = PositionActuel;
                }
            }

            // Boucle qui gere la mort du player en fonction de sa collision avec la rockhead //
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

            // Boucle qui gere le floor et qui place le joueur en permanence au dessus si il est en contact avec  //
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

            // Boucle qui gere la Grass et qui place le joueur dessus si il rentre en contact avec par le dessus et le fait tomber sur les cotés // 
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

            // Boucle qui augmente la valeur du saut du player si il se situe sur un trampoline // 
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
            // Boucle qui quand le joueur rentre en contact avec la porte ferme le form actuel et ouvre le suivant // 
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "door")
                {
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameTimer.Stop();
                        Form4 form4 = new Form4();
                        this.Hide();
                        form4.Show();
                    }
                }
            }
        }
        // Fonction qui est apellé quand l'utilisateur appuie sur une touche // 
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
        // Fonction qui est apellé quand l'utilisateur relache une touche // 
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

        // Fonction Respawn permettant au personnage quand il meurt de le faire réapparaitre //
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

            GameData.Mort++;
        }
        // Fonction permettant de fermer le form a l'aide de la touche Echap // 
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

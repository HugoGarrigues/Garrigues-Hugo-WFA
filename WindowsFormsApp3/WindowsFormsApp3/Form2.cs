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
    public partial class Form2 : Form
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

        // Variables Saw //
        int sawSpeed = 2;
        bool deplacement = true;
        int PositionInitial = 296;
        int PositionFinal = 447;
        int PositionActuel;

        public Form2()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
            deathLabel = labelMort;
            deathLabel2 = labelMort2;
            this.KeyDown += Form_KeyDown;
            PositionActuel = PositionInitial;
            // Recupération et affichage du score des niveaux prècedent //
            txtScore.Text = "Score : " + GameData.Score.ToString();
        }


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

            /* Boucle permettant de parcourir tous les controls avec comme tag "spiketrap" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "spiketrap")
                {
                    // Système de mort : Si collision detecté alors fonction respawn appelé et affichage des labels necessaires //
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameTimer.Stop();
                        isPlayerDead = true;
                        deathLabel.Visible = true;
                        deathLabel2.Visible = true;
                    }
                }
            }
            /* Boucle permettant de parcourir tous les controls avec comme tag "APPLE" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "apple")
                {
                    // Systeme d'incrementation de point : Si collision detectée alors le control en question est remove et le score est incrementé de 1 // 
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        Controls.Remove(control);
                        GameData.Score++;
                        txtScore.Text = "Score : " + GameData.Score.ToString();
                    }
                }
            }
            /* Boucle permettant de parcourir tous les controls avec comme tag "platform" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "platform")
                {
                    // Converti la pictureBox de sorte a pouvoir l'utiliser //
                    PictureBox platform = (PictureBox)control;
                    // Verifie si intersection il y a eu //
                    if (player.Bounds.IntersectsWith(platform.Bounds))
                    {
                        // Conditions pour le dessus de la platform : Verification si le bas du player est > au haut de la platform //
                        if (player.Bottom > platform.Top && player.Top < platform.Top)
                        {
                            // Place le player au dessus de la plateforme //
                            player.Top = platform.Top - player.Height;
                            // Rénitialise le saut du player //
                            jumpSpeed = 0;
                            canJump = true;
                        }
                        // Conditions pour le dessous de la platform : Verification si le haut du player est < au bas de la platform //
                        else if (player.Top < platform.Bottom && player.Bottom > platform.Bottom)
                        {
                            // Place le player en dessous de la plateforme //
                            player.Top = platform.Bottom;
                            // Stop le saut du joueur //
                            jumpSpeed = 0;
                            jumping = false;
                        }
                    }
                }
            }
            /* Boucle permettant de parcourir tous les controls avec comme tag "saw" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag is string tag && tag == "saw")
                {
                    // Si la saw est en mouvement // 
                    if (deplacement)
                    {
                        // Continue de la déplacer, en augmentant sa position  //
                        PositionActuel += sawSpeed;
                        if (PositionActuel >= PositionFinal)
                        {
                            // Verifie si la position final est atteinte pour arreter le mouvement et le faire partir dans l'autre mouvement//
                            PositionActuel = PositionFinal;
                            deplacement = false;
                        }
                    }
                    else
                    // Si la saw se déplace dans l'autre sens // 
                    {
                        // Continue de la déplacer, en diminuant sa position  //
                        PositionActuel -= sawSpeed;
                        if (PositionActuel <= PositionInitial)
                        {
                            // Verifie si la position final est atteinte pour arreter le mouvement et le faire partir dans l'autre mouvement// 
                            PositionActuel = PositionInitial;
                            deplacement = true;
                        }
                    }
                    // Actualise la proprieté left de la saw a l'aide de la nouvelle position //
                    control.Left = PositionActuel; 
                }
            }
            /* Boucle permettant de parcourir tous les controls avec comme tag "rockhead" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "saw")
                {
                    // Système de mort : Si collision detecté alors fonction respawn appelé et affichage des labels necessaires //
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        GameTimer.Stop();
                        isPlayerDead = true;
                        deathLabel.Visible = true;
                        deathLabel2.Visible = true;
                    }
                }
            }


            /* Boucle permettant de parcourir tous les controls avec comme tag "floor" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "floor")
                {
                    // Converti la pictureBox de sorte a pouvoir l'utiliser //
                    PictureBox floor = (PictureBox)control;
                    // Vérifie l' intersection entre joueur et le floor // 
                    if (player.Bounds.IntersectsWith(floor.Bounds))
                    {
                        // Place le joueur au dessus du floor //
                        player.Top = floor.Top - player.Height;
                        // Rénitialise le saut du player //
                        jumpSpeed = 0;
                        canJump = true;
                    }
                }
            }
            /* Boucle permettant de parcourir tous les controls avec comme tag "grass" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "grass")
                {
                    // Converti la pictureBox de sorte a pouvoir l'utiliser //
                    PictureBox grass = (PictureBox)control;
                    // Si collision entre player et haut de l'herbe cela le place sur l'herbe //
                    if (player.Bounds.IntersectsWith(grass.Bounds) && player.Bottom >= grass.Top && player.Top < grass.Top + playerSpeed)
                    {
                        // Réniatialise son saut // 
                        player.Top = grass.Top - player.Height;
                        jumpSpeed = 0;
                        canJump = true;
                    }
                    // Gere la colision entre le player et la partie gauche et droite et le place sur chaqun de ses cotés // 
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

            /* Boucle permettant de parcourir tous les controls avec comme tag "trampoline" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "trampoline")
                {
                    // Converti la pictureBox de sorte a pouvoir l'utiliser //
                    PictureBox trampoline = (PictureBox)control;
                    // Si le player est exactement sur le trampoline alors sa jumpspeed passe a 20 //
                    if (player.Bounds.IntersectsWith(trampoline.Bounds) && player.Bottom >= trampoline.Top && player.Bottom <= trampoline.Top + playerSpeed)
                    {
                        jumpSpeed = 20; 
                        canJump = false; 
                    }
                }
            }
            /* Boucle permettant de parcourir tous les controls avec comme tag "door" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "door")
                {
                    // Vérifie l' intersection entre joueur et la door // 
                    if (player.Bounds.IntersectsWith(control.Bounds))
                    {
                        // Arrete le gametimer et cache le form actuel pour dévoiler le suivant // 
                        GameTimer.Stop();
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.Show();
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
            // Teleporte le joueur a son endroit de spawn // 
            player.Location = new Point(20, 319);

            // Réniatialise son saut // 
            jumping = false;
            canJump = true;
            jumpSpeed = 0;

            // Redémarre le Jeu //
            GameTimer.Start();
            isPlayerDead = false;

            deathLabel.Visible = false;
            deathLabel2.Visible = false;

            // Itere de 1 son nombre de morts 
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
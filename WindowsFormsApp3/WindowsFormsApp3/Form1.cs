﻿using System;
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
        bool goLeft, goRight, jumping, canJump;
        int jumpSpeed;
        int playerSpeed = 6;
        bool isPlayerDead = false;
        
        // Variables Autres
        int borderSize = 15;
        Label deathLabel;
        Label deathLabel2;

        // Variables RockHead //
        int rockheadSpeed = 2;
        bool isDescending = true;
        int PositionInitial = 55;
        int PositionFinal = 191;
        int PositionActuel;

        public Form1()
        {
            InitializeComponent();
            canJump = true;
            this.DoubleBuffered = true;
            // Récuperation des labels de mort //
            deathLabel = labelMort;
            deathLabel2 = labelMort2;
            // Initialisation de la fonction pour fermer le formulaire
            this.KeyDown += Form_KeyDown;
            // Initialisation à 0 des variables Mort et Score //
            GameData.Score = 0;
            GameData.Mort = 0;
            PositionActuel = PositionInitial;
        }
        
        // Initialisation des variables static du Score et des Morts //
        public static class GameData
        {
            public static int Score { get; set; } = 0;
            public static int Mort { get; set; } = 0;
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
            /* Boucle permettant de parcourir tous les controls avec comme tag "rockhead" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag is string tag && tag == "rockhead")
                {
                    // Si la rockhead est en train de descendre // 
                    if (isDescending)
                    {
                        // Continue de baisser la rockhead, en augmentant la position verticale //
                        PositionActuel += rockheadSpeed;
                        // Verifie si la position final est atteinte pour arreter le mouvement et le faire partir dans l'autre mouvement// 
                        if (PositionActuel >= PositionFinal)
                        {
                            PositionActuel = PositionFinal;
                            isDescending = false;
                        }
                    }
                    else
                    // Si est en train de monter // 
                    {
                        // Continue de monter la rockhead, en baissant la position verticale // 
                        PositionActuel -= rockheadSpeed;
                        // Verifie si la position final est atteinte pour arreter le mouvement et le faire partir dans l'autre mouvement// 
                        if (PositionActuel <= PositionInitial)
                        {
                            PositionActuel = PositionInitial;
                            isDescending = true;
                        }
                    }
                    // Actualise la proprieté top de la rockHead a l'aide de la nouvelle position //
                    control.Top = PositionActuel;
                }
            }

            /* Boucle permettant de parcourir tous les controls avec comme tag "rockhead" */
            foreach (Control control in Controls)
            {
                // Vérification du tag de la picture box // 
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "rockhead")
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
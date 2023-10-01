﻿using System;
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
    public partial class Fin : Form
    {
        public Fin()
        {
            InitializeComponent();
            finalScore.Text = GameData.Score.ToString();
            finalMort.Text = GameData.Mort.ToString();
            this.KeyDown += Form_KeyDown;
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

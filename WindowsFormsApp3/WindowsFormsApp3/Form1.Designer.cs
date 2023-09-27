namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.border = new System.Windows.Forms.PictureBox();
            this.border2 = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.rockhead = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.spiketrap = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiketrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.border_wall;
            this.border.Location = new System.Drawing.Point(-1, -6);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(564, 15);
            this.border.TabIndex = 1;
            this.border.TabStop = false;
            this.border.Tag = "border";
            // 
            // border2
            // 
            this.border2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.vertical_border_wall;
            this.border2.Location = new System.Drawing.Point(549, -1);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(14, 368);
            this.border2.TabIndex = 3;
            this.border2.TabStop = false;
            this.border2.Tag = "border";
            // 
            // platform
            // 
            this.platform.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.platform.Location = new System.Drawing.Point(389, 255);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(48, 16);
            this.platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.platform.TabIndex = 15;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.door;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door.Location = new System.Drawing.Point(14, 17);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(58, 58);
            this.door.TabIndex = 38;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // rockhead
            // 
            this.rockhead.BackColor = System.Drawing.Color.Transparent;
            this.rockhead.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.idle_rock_head;
            this.rockhead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockhead.Location = new System.Drawing.Point(468, 55);
            this.rockhead.Name = "rockhead";
            this.rockhead.Size = new System.Drawing.Size(48, 51);
            this.rockhead.TabIndex = 43;
            this.rockhead.TabStop = false;
            this.rockhead.Tag = "rockhead";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WindowsFormsApp3.Properties.Resources.Idle__32x32_;
            this.player.Location = new System.Drawing.Point(15, 319);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 51;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.border_wall;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 15);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "border";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.vertical_border_wall;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 350);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "border";
            // 
            // spiketrap
            // 
            this.spiketrap.BackColor = System.Drawing.Color.Transparent;
            this.spiketrap.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Idle1;
            this.spiketrap.Location = new System.Drawing.Point(245, 255);
            this.spiketrap.Name = "spiketrap";
            this.spiketrap.Size = new System.Drawing.Size(48, 17);
            this.spiketrap.TabIndex = 35;
            this.spiketrap.TabStop = false;
            this.spiketrap.Tag = "spiketrap";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Idle1;
            this.pictureBox19.Location = new System.Drawing.Point(347, 160);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(48, 17);
            this.pictureBox19.TabIndex = 84;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "spiketrap";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox21.Location = new System.Drawing.Point(406, 235);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(12, 14);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 100;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "apple";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox22.Location = new System.Drawing.Point(304, 160);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(12, 14);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox22.TabIndex = 101;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "apple";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox17.Location = new System.Drawing.Point(322, 160);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(12, 14);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox17.TabIndex = 102;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "apple";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 18;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(240, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 20);
            this.txtScore.TabIndex = 114;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Score : 0";
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = global::WindowsFormsApp3.Properties.Resources.platform;
            this.pictureBox38.Location = new System.Drawing.Point(468, 231);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(46, 5);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox38.TabIndex = 118;
            this.pictureBox38.TabStop = false;
            this.pictureBox38.Tag = "platform";
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox37.Location = new System.Drawing.Point(197, 272);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(48, 16);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox37.TabIndex = 120;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Tag = "platform";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox14.Location = new System.Drawing.Point(299, 177);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(48, 16);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 121;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "platform";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox15.Location = new System.Drawing.Point(344, 177);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(48, 16);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 122;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "platform";
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox40.Location = new System.Drawing.Point(389, 177);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(48, 16);
            this.pictureBox40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox40.TabIndex = 124;
            this.pictureBox40.TabStop = false;
            this.pictureBox40.Tag = "platform";
            // 
            // pictureBox45
            // 
            this.pictureBox45.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox45.Location = new System.Drawing.Point(64, 75);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(48, 16);
            this.pictureBox45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox45.TabIndex = 128;
            this.pictureBox45.TabStop = false;
            this.pictureBox45.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox10.Location = new System.Drawing.Point(244, 272);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(48, 16);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 129;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox3.Location = new System.Drawing.Point(131, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(12, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "apple";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox4.Location = new System.Drawing.Point(114, 302);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 130;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox5.Location = new System.Drawing.Point(141, 113);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 132;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox7.Location = new System.Drawing.Point(160, 93);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(12, 14);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 134;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "apple";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox8.Location = new System.Drawing.Point(291, 272);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 16);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 135;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp3.Properties.Resources.platform;
            this.pictureBox9.Location = new System.Drawing.Point(213, 160);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(46, 5);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 136;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox6.Location = new System.Drawing.Point(16, 75);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 137;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.gray_background;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.rockhead);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.door);
            this.Controls.Add(this.spiketrap);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedGame);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiketrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.PictureBox border2;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox rockhead;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox spiketrap;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}


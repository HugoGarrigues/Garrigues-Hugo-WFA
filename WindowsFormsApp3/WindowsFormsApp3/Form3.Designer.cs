namespace WindowsFormsApp3
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.border2 = new System.Windows.Forms.PictureBox();
            this.border = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelMort2 = new System.Windows.Forms.Label();
            this.labelMort = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.door = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            this.SuspendLayout();
            // 
            // border2
            // 
            this.border2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.vertical_border_wall;
            this.border2.Location = new System.Drawing.Point(549, -3);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(14, 368);
            this.border2.TabIndex = 59;
            this.border2.TabStop = false;
            this.border2.Tag = "border";
            // 
            // border
            // 
            this.border.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.border_wall;
            this.border.Location = new System.Drawing.Point(-5, -6);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(564, 15);
            this.border.TabIndex = 58;
            this.border.TabStop = false;
            this.border.Tag = "border";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.vertical_border_wall;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 350);
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "border";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.border_wall;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 15);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "floor";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.grass_ground1;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 322);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(564, 42);
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "grass";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WindowsFormsApp3.Properties.Resources.Idle__32x32_;
            this.player.Location = new System.Drawing.Point(29, 284);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 65;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 18;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // labelMort2
            // 
            this.labelMort2.AutoSize = true;
            this.labelMort2.BackColor = System.Drawing.Color.Black;
            this.labelMort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMort2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMort2.Location = new System.Drawing.Point(203, 191);
            this.labelMort2.Name = "labelMort2";
            this.labelMort2.Size = new System.Drawing.Size(149, 16);
            this.labelMort2.TabIndex = 141;
            this.labelMort2.Tag = "labelMort";
            this.labelMort2.Text = "Press R to respawn !";
            this.labelMort2.Visible = false;
            // 
            // labelMort
            // 
            this.labelMort.AutoSize = true;
            this.labelMort.BackColor = System.Drawing.Color.Black;
            this.labelMort.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMort.Location = new System.Drawing.Point(136, 149);
            this.labelMort.Name = "labelMort";
            this.labelMort.Size = new System.Drawing.Size(287, 42);
            this.labelMort.TabIndex = 140;
            this.labelMort.Tag = "labelMort";
            this.labelMort.Text = "You Are Dead !";
            this.labelMort.Visible = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(254, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 20);
            this.txtScore.TabIndex = 150;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Score : 0";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.door;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door.Location = new System.Drawing.Point(99, 268);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(58, 58);
            this.door.TabIndex = 151;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.gray_background;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.door);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.labelMort2);
            this.Controls.Add(this.labelMort);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(574, 396);
            this.Name = "Form3";
            this.Text = "Form3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox border2;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label labelMort2;
        private System.Windows.Forms.Label labelMort;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox door;
    }
}
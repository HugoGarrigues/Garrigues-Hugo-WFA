namespace WindowsFormsApp3
{
    partial class Form2
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.border2 = new System.Windows.Forms.PictureBox();
            this.border = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.saw = new System.Windows.Forms.PictureBox();
            this.labelMort2 = new System.Windows.Forms.Label();
            this.labelMort = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 18;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WindowsFormsApp3.Properties.Resources.Idle__32x32_;
            this.player.Location = new System.Drawing.Point(16, 317);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.border_wall;
            this.pictureBox1.Location = new System.Drawing.Point(0, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 15);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "floor";
            // 
            // border2
            // 
            this.border2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.vertical_border_wall;
            this.border2.Location = new System.Drawing.Point(548, -3);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(14, 368);
            this.border2.TabIndex = 55;
            this.border2.TabStop = false;
            this.border2.Tag = "border";
            // 
            // border
            // 
            this.border.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.border_wall;
            this.border.Location = new System.Drawing.Point(-3, -6);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(564, 15);
            this.border.TabIndex = 54;
            this.border.TabStop = false;
            this.border.Tag = "border";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.vertical_border_wall;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 350);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "border";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.grass_ground1;
            this.pictureBox3.Location = new System.Drawing.Point(128, 307);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(433, 42);
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "grass";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.grass_ground1;
            this.pictureBox4.Location = new System.Drawing.Point(128, 233);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 42);
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "grass";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.grass_ground1;
            this.pictureBox5.Location = new System.Drawing.Point(128, 211);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 42);
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "grass";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.grass_ground1;
            this.pictureBox6.Location = new System.Drawing.Point(128, 281);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(128, 42);
            this.pictureBox6.TabIndex = 60;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "grass";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.grass_ground1;
            this.pictureBox7.Location = new System.Drawing.Point(128, 259);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(128, 42);
            this.pictureBox7.TabIndex = 61;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "grass";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::WindowsFormsApp3.Properties.Resources.Idle2;
            this.pictureBox8.Location = new System.Drawing.Point(79, 324);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 62;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "trampoline";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::WindowsFormsApp3.Properties.Resources.Idle2;
            this.pictureBox10.Location = new System.Drawing.Point(505, 283);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(28, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 64;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "trampoline";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox14.Location = new System.Drawing.Point(437, 116);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(48, 16);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox14.TabIndex = 122;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "platform";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox11.Location = new System.Drawing.Point(390, 116);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(48, 16);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 123;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "platform";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox12.Location = new System.Drawing.Point(343, 116);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(48, 16);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 124;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox9.Location = new System.Drawing.Point(295, 116);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(48, 16);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 126;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox15.Location = new System.Drawing.Point(106, 116);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(48, 16);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox15.TabIndex = 130;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "platform";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox16.Location = new System.Drawing.Point(154, 116);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(48, 16);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox16.TabIndex = 129;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "platform";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox17.Location = new System.Drawing.Point(201, 116);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(48, 16);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox17.TabIndex = 128;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "platform";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox19.Location = new System.Drawing.Point(10, 116);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(48, 16);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox19.TabIndex = 133;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "platform";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox20.Location = new System.Drawing.Point(58, 116);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(48, 16);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox20.TabIndex = 132;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "platform";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.Idle1;
            this.pictureBox18.Location = new System.Drawing.Point(154, 100);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(48, 17);
            this.pictureBox18.TabIndex = 134;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "spiketrap";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.door;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door.Location = new System.Drawing.Point(17, 59);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(58, 58);
            this.door.TabIndex = 135;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox21.Location = new System.Drawing.Point(165, 192);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(12, 14);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 136;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "apple";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox22.Location = new System.Drawing.Point(190, 192);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(12, 14);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox22.TabIndex = 137;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "apple";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox23.Location = new System.Drawing.Point(213, 192);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(12, 14);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox23.TabIndex = 138;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "apple";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox24.Location = new System.Drawing.Point(218, 96);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(12, 14);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox24.TabIndex = 139;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "apple";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox25.Location = new System.Drawing.Point(401, 285);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(12, 14);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox25.TabIndex = 141;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "apple";
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox26.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox26.Location = new System.Drawing.Point(378, 285);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(12, 14);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox26.TabIndex = 140;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Tag = "apple";
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox29.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox29.Location = new System.Drawing.Point(425, 191);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(12, 14);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox29.TabIndex = 145;
            this.pictureBox29.TabStop = false;
            this.pictureBox29.Tag = "apple";
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox30.Image = global::WindowsFormsApp3.Properties.Resources.Apple;
            this.pictureBox30.Location = new System.Drawing.Point(402, 191);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(12, 14);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox30.TabIndex = 144;
            this.pictureBox30.TabStop = false;
            this.pictureBox30.Tag = "apple";
            // 
            // saw
            // 
            this.saw.BackColor = System.Drawing.Color.Transparent;
            this.saw.Image = global::WindowsFormsApp3.Properties.Resources.Off;
            this.saw.Location = new System.Drawing.Point(447, 94);
            this.saw.Name = "saw";
            this.saw.Size = new System.Drawing.Size(38, 38);
            this.saw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.saw.TabIndex = 146;
            this.saw.TabStop = false;
            this.saw.Tag = "saw";
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
            this.labelMort2.TabIndex = 148;
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
            this.labelMort.TabIndex = 147;
            this.labelMort.Tag = "labelMort";
            this.labelMort.Text = "You Are Dead !";
            this.labelMort.Visible = false;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(242, 11);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(72, 20);
            this.txtScore.TabIndex = 149;
            this.txtScore.Tag = "txtScore";
            this.txtScore.Text = "Score : 0";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox13.Location = new System.Drawing.Point(341, 211);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(48, 16);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox13.TabIndex = 152;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "platform";
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox27.Location = new System.Drawing.Point(389, 211);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(48, 16);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox27.TabIndex = 151;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "platform";
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = global::WindowsFormsApp3.Properties.Resources.horizontal_long_block;
            this.pictureBox28.Location = new System.Drawing.Point(436, 211);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(48, 16);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox28.TabIndex = 150;
            this.pictureBox28.TabStop = false;
            this.pictureBox28.Tag = "platform";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.gray_background;
            this.ClientSize = new System.Drawing.Size(558, 357);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.labelMort2);
            this.Controls.Add(this.labelMort);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.border);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.saw);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox10);
            this.MaximumSize = new System.Drawing.Size(574, 396);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox border2;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox saw;
        private System.Windows.Forms.Label labelMort2;
        private System.Windows.Forms.Label labelMort;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
    }
}
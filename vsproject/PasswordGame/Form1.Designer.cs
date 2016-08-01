namespace PasswordGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbBlitz = new System.Windows.Forms.CheckBox();
            this.cbThreeClue = new System.Windows.Forms.CheckBox();
            this.cbClassic = new System.Windows.Forms.CheckBox();
            this.cbCharades = new System.Windows.Forms.CheckBox();
            this.cbPictionary = new System.Windows.Forms.CheckBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cbTech = new System.Windows.Forms.CheckBox();
            this.cbHero = new System.Windows.Forms.CheckBox();
            this.cbVillain = new System.Windows.Forms.CheckBox();
            this.cbMovies = new System.Windows.Forms.CheckBox();
            this.cbHard = new System.Windows.Forms.CheckBox();
            this.cbStarWars = new System.Windows.Forms.CheckBox();
            this.cbMiddleEarth = new System.Windows.Forms.CheckBox();
            this.cbWrite = new System.Windows.Forms.CheckBox();
            this.cbSport = new System.Windows.Forms.CheckBox();
            this.cbBasic = new System.Windows.Forms.CheckBox();
            this.btnEndRound = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Location = new System.Drawing.Point(2, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 119);
            this.lblStatus.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 14);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "used words...";
            // 
            // cbBlitz
            // 
            this.cbBlitz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlitz.Location = new System.Drawing.Point(5, 110);
            this.cbBlitz.Name = "cbBlitz";
            this.cbBlitz.Size = new System.Drawing.Size(104, 24);
            this.cbBlitz.TabIndex = 4;
            this.cbBlitz.Text = "blitz";
            this.cbBlitz.UseVisualStyleBackColor = true;
            this.cbBlitz.Click += new System.EventHandler(this.cbBlitz_Click);
            // 
            // cbThreeClue
            // 
            this.cbThreeClue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThreeClue.Location = new System.Drawing.Point(5, 80);
            this.cbThreeClue.Name = "cbThreeClue";
            this.cbThreeClue.Size = new System.Drawing.Size(104, 24);
            this.cbThreeClue.TabIndex = 3;
            this.cbThreeClue.Text = "three-clue";
            this.cbThreeClue.UseVisualStyleBackColor = true;
            this.cbThreeClue.Click += new System.EventHandler(this.cbThreeClue_Click);
            // 
            // cbClassic
            // 
            this.cbClassic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassic.Location = new System.Drawing.Point(5, 52);
            this.cbClassic.Name = "cbClassic";
            this.cbClassic.Size = new System.Drawing.Size(104, 24);
            this.cbClassic.TabIndex = 2;
            this.cbClassic.Text = "classic";
            this.cbClassic.UseVisualStyleBackColor = true;
            this.cbClassic.Click += new System.EventHandler(this.cbClassic_Click);
            // 
            // cbCharades
            // 
            this.cbCharades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCharades.Location = new System.Drawing.Point(5, 25);
            this.cbCharades.Name = "cbCharades";
            this.cbCharades.Size = new System.Drawing.Size(104, 24);
            this.cbCharades.TabIndex = 1;
            this.cbCharades.Text = "charades";
            this.cbCharades.UseVisualStyleBackColor = true;
            this.cbCharades.Click += new System.EventHandler(this.cbCharades_Click);
            // 
            // cbPictionary
            // 
            this.cbPictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPictionary.Location = new System.Drawing.Point(5, 0);
            this.cbPictionary.Name = "cbPictionary";
            this.cbPictionary.Size = new System.Drawing.Size(104, 24);
            this.cbPictionary.TabIndex = 0;
            this.cbPictionary.Text = "pictionary";
            this.cbPictionary.UseVisualStyleBackColor = true;
            this.cbPictionary.Click += new System.EventHandler(this.cbPictionary_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.White;
            this.btnRandom.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandom.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRandom.Image = ((System.Drawing.Image)(resources.GetObject("btnRandom.Image")));
            this.btnRandom.Location = new System.Drawing.Point(303, 107);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(60, 60);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // cbTech
            // 
            this.cbTech.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTech.BackColor = System.Drawing.Color.White;
            this.cbTech.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTech.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbTech.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTech.Image = ((System.Drawing.Image)(resources.GetObject("cbTech.Image")));
            this.cbTech.Location = new System.Drawing.Point(350, 207);
            this.cbTech.Name = "cbTech";
            this.cbTech.Size = new System.Drawing.Size(60, 60);
            this.cbTech.TabIndex = 6;
            this.cbTech.UseVisualStyleBackColor = false;
            this.cbTech.Click += new System.EventHandler(this.cbTech_Click);
            // 
            // cbHero
            // 
            this.cbHero.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbHero.BackColor = System.Drawing.Color.White;
            this.cbHero.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbHero.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbHero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbHero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbHero.Image = ((System.Drawing.Image)(resources.GetObject("cbHero.Image")));
            this.cbHero.Location = new System.Drawing.Point(174, 174);
            this.cbHero.Name = "cbHero";
            this.cbHero.Size = new System.Drawing.Size(60, 60);
            this.cbHero.TabIndex = 8;
            this.cbHero.UseVisualStyleBackColor = false;
            this.cbHero.Click += new System.EventHandler(this.cbHero_Click);
            // 
            // cbVillain
            // 
            this.cbVillain.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbVillain.BackColor = System.Drawing.Color.White;
            this.cbVillain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbVillain.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbVillain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbVillain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbVillain.Image = ((System.Drawing.Image)(resources.GetObject("cbVillain.Image")));
            this.cbVillain.Location = new System.Drawing.Point(255, 207);
            this.cbVillain.Name = "cbVillain";
            this.cbVillain.Size = new System.Drawing.Size(60, 60);
            this.cbVillain.TabIndex = 7;
            this.cbVillain.UseVisualStyleBackColor = false;
            this.cbVillain.Click += new System.EventHandler(this.cbVillain_Click);
            // 
            // cbMovies
            // 
            this.cbMovies.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMovies.BackColor = System.Drawing.Color.White;
            this.cbMovies.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cbMovies.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbMovies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMovies.Image = ((System.Drawing.Image)(resources.GetObject("cbMovies.Image")));
            this.cbMovies.Location = new System.Drawing.Point(106, 107);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(60, 60);
            this.cbMovies.TabIndex = 9;
            this.cbMovies.UseVisualStyleBackColor = false;
            this.cbMovies.Click += new System.EventHandler(this.cbMovies_Click);
            // 
            // cbHard
            // 
            this.cbHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbHard.BackColor = System.Drawing.Color.White;
            this.cbHard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbHard.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbHard.Image = ((System.Drawing.Image)(resources.GetObject("cbHard.Image")));
            this.cbHard.Location = new System.Drawing.Point(174, 41);
            this.cbHard.Name = "cbHard";
            this.cbHard.Size = new System.Drawing.Size(60, 60);
            this.cbHard.TabIndex = 10;
            this.cbHard.UseVisualStyleBackColor = false;
            this.cbHard.Click += new System.EventHandler(this.cbHard_Click);
            // 
            // cbStarWars
            // 
            this.cbStarWars.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbStarWars.BackColor = System.Drawing.Color.White;
            this.cbStarWars.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbStarWars.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbStarWars.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbStarWars.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbStarWars.Image = ((System.Drawing.Image)(resources.GetObject("cbStarWars.Image")));
            this.cbStarWars.Location = new System.Drawing.Point(425, 174);
            this.cbStarWars.Name = "cbStarWars";
            this.cbStarWars.Size = new System.Drawing.Size(60, 60);
            this.cbStarWars.TabIndex = 5;
            this.cbStarWars.UseVisualStyleBackColor = false;
            this.cbStarWars.Click += new System.EventHandler(this.cbStarWars_Click);
            // 
            // cbMiddleEarth
            // 
            this.cbMiddleEarth.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbMiddleEarth.BackColor = System.Drawing.Color.White;
            this.cbMiddleEarth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbMiddleEarth.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbMiddleEarth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMiddleEarth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMiddleEarth.Image = ((System.Drawing.Image)(resources.GetObject("cbMiddleEarth.Image")));
            this.cbMiddleEarth.Location = new System.Drawing.Point(501, 107);
            this.cbMiddleEarth.Name = "cbMiddleEarth";
            this.cbMiddleEarth.Size = new System.Drawing.Size(60, 60);
            this.cbMiddleEarth.TabIndex = 4;
            this.cbMiddleEarth.UseVisualStyleBackColor = false;
            this.cbMiddleEarth.Click += new System.EventHandler(this.cbMiddleEarth_Click);
            // 
            // cbWrite
            // 
            this.cbWrite.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbWrite.BackColor = System.Drawing.Color.White;
            this.cbWrite.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbWrite.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbWrite.Image = ((System.Drawing.Image)(resources.GetObject("cbWrite.Image")));
            this.cbWrite.Location = new System.Drawing.Point(425, 44);
            this.cbWrite.Name = "cbWrite";
            this.cbWrite.Size = new System.Drawing.Size(60, 60);
            this.cbWrite.TabIndex = 3;
            this.cbWrite.UseVisualStyleBackColor = false;
            this.cbWrite.Click += new System.EventHandler(this.cbWrite_Click);
            // 
            // cbSport
            // 
            this.cbSport.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSport.BackColor = System.Drawing.Color.White;
            this.cbSport.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbSport.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbSport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSport.Image = ((System.Drawing.Image)(resources.GetObject("cbSport.Image")));
            this.cbSport.Location = new System.Drawing.Point(350, 12);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(60, 60);
            this.cbSport.TabIndex = 2;
            this.cbSport.UseVisualStyleBackColor = false;
            this.cbSport.Click += new System.EventHandler(this.cbSport_Click);
            // 
            // cbBasic
            // 
            this.cbBasic.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBasic.BackColor = System.Drawing.Color.White;
            this.cbBasic.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cbBasic.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.cbBasic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbBasic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBasic.Location = new System.Drawing.Point(255, 12);
            this.cbBasic.Name = "cbBasic";
            this.cbBasic.Size = new System.Drawing.Size(60, 60);
            this.cbBasic.TabIndex = 1;
            this.cbBasic.Text = "BASIC";
            this.cbBasic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbBasic.UseVisualStyleBackColor = false;
            this.cbBasic.Click += new System.EventHandler(this.cbBasic_Click);
            // 
            // btnEndRound
            // 
            this.btnEndRound.Enabled = false;
            this.btnEndRound.Location = new System.Drawing.Point(163, 269);
            this.btnEndRound.Name = "btnEndRound";
            this.btnEndRound.Size = new System.Drawing.Size(75, 23);
            this.btnEndRound.TabIndex = 21;
            this.btnEndRound.Text = "End Round";
            this.btnEndRound.UseVisualStyleBackColor = true;
            this.btnEndRound.Visible = false;
            this.btnEndRound.Click += new System.EventHandler(this.btnEndRound_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.Green;
            this.lblTimeLeft.Location = new System.Drawing.Point(251, -7);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(171, 83);
            this.lblTimeLeft.TabIndex = 22;
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderSize = 3;
            this.btnNext.Location = new System.Drawing.Point(300, 183);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 75);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Password";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(433, 215);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(0, 20);
            this.lblRemaining.TabIndex = 24;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoEllipsis = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Tomato;
            this.lblPassword.Location = new System.Drawing.Point(84, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(514, 55);
            this.lblPassword.TabIndex = 25;
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBlitz);
            this.panel1.Controls.Add(this.cbPictionary);
            this.panel1.Controls.Add(this.cbThreeClue);
            this.panel1.Controls.Add(this.cbCharades);
            this.panel1.Controls.Add(this.cbClassic);
            this.panel1.Location = new System.Drawing.Point(12, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 135);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRandom);
            this.panel2.Controls.Add(this.cbBasic);
            this.panel2.Controls.Add(this.cbHard);
            this.panel2.Controls.Add(this.cbMovies);
            this.panel2.Controls.Add(this.cbHero);
            this.panel2.Controls.Add(this.cbTech);
            this.panel2.Controls.Add(this.cbVillain);
            this.panel2.Controls.Add(this.cbSport);
            this.panel2.Controls.Add(this.cbWrite);
            this.panel2.Controls.Add(this.cbMiddleEarth);
            this.panel2.Controls.Add(this.cbStarWars);
            this.panel2.Location = new System.Drawing.Point(12, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 272);
            this.panel2.TabIndex = 27;
            // 
            // lblHint
            // 
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(240, 157);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(193, 23);
            this.lblHint.TabIndex = 28;
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(657, 584);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnEndRound);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox cbWrite;
        private System.Windows.Forms.CheckBox cbSport;
        private System.Windows.Forms.CheckBox cbBasic;
        private System.Windows.Forms.CheckBox cbBlitz;
        private System.Windows.Forms.CheckBox cbThreeClue;
        private System.Windows.Forms.CheckBox cbClassic;
        private System.Windows.Forms.CheckBox cbCharades;
        private System.Windows.Forms.CheckBox cbPictionary;
        private System.Windows.Forms.CheckBox cbTech;
        private System.Windows.Forms.CheckBox cbHero;
        private System.Windows.Forms.CheckBox cbVillain;
        private System.Windows.Forms.CheckBox cbMovies;
        private System.Windows.Forms.CheckBox cbHard;
        private System.Windows.Forms.CheckBox cbStarWars;
        private System.Windows.Forms.CheckBox cbMiddleEarth;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnEndRound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHint;
    }
}


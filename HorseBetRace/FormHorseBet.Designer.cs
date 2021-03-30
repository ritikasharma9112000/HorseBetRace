﻿namespace HorseBetRace
{
    partial class FormHorseBet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAl = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBob = new System.Windows.Forms.Label();
            this.nudHorseNumber = new System.Windows.Forms.NumericUpDown();
            this.lblJoe = new System.Windows.Forms.Label();
            this.nudCash = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBettor = new System.Windows.Forms.Label();
            this.lblMaxBet = new System.Windows.Forms.Label();
            this.lblPunter = new System.Windows.Forms.Label();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.btnRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbHorse4 = new System.Windows.Forms.PictureBox();
            this.pbHorse3 = new System.Windows.Forms.PictureBox();
            this.pbHorse2 = new System.Windows.Forms.PictureBox();
            this.pbHorse1 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblAl);
            this.panel1.Controls.Add(this.btnBet);
            this.panel1.Controls.Add(this.lblBob);
            this.panel1.Controls.Add(this.nudHorseNumber);
            this.panel1.Controls.Add(this.lblJoe);
            this.panel1.Controls.Add(this.nudCash);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBettor);
            this.panel1.Controls.Add(this.lblMaxBet);
            this.panel1.Controls.Add(this.lblPunter);
            this.panel1.Controls.Add(this.rbAl);
            this.panel1.Controls.Add(this.rbBob);
            this.panel1.Controls.Add(this.rbJoe);
            this.panel1.Location = new System.Drawing.Point(16, 484);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 133);
            this.panel1.TabIndex = 0;
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(487, 80);
            this.lblAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(144, 17);
            this.lblAl.TabIndex = 24;
            this.lblAl.Text = "Al hasn\'t placed a bet";
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBet.Location = new System.Drawing.Point(304, 38);
            this.btnBet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(132, 47);
            this.btnBet.TabIndex = 20;
            this.btnBet.Text = "Place Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Location = new System.Drawing.Point(487, 54);
            this.lblBob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(157, 17);
            this.lblBob.TabIndex = 23;
            this.lblBob.Text = "Bob hasn\'t placed a bet";
            // 
            // nudHorseNumber
            // 
            this.nudHorseNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudHorseNumber.Location = new System.Drawing.Point(433, 100);
            this.nudHorseNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudHorseNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudHorseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHorseNumber.Name = "nudHorseNumber";
            this.nudHorseNumber.Size = new System.Drawing.Size(49, 22);
            this.nudHorseNumber.TabIndex = 19;
            this.nudHorseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJoe
            // 
            this.lblJoe.AutoSize = true;
            this.lblJoe.Location = new System.Drawing.Point(487, 31);
            this.lblJoe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(155, 17);
            this.lblJoe.TabIndex = 22;
            this.lblJoe.Text = "Joe hasn\'t placed a bet";
            // 
            // nudCash
            // 
            this.nudCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudCash.Location = new System.Drawing.Point(268, 100);
            this.nudCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCash.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCash.Name = "nudCash";
            this.nudCash.Size = new System.Drawing.Size(49, 22);
            this.nudCash.TabIndex = 18;
            this.nudCash.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Bet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(325, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Horse number #";
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBettor.Location = new System.Drawing.Point(224, 102);
            this.lblBettor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(58, 17);
            this.lblBettor.TabIndex = 16;
            this.lblBettor.Text = "Bettor $";
            // 
            // lblMaxBet
            // 
            this.lblMaxBet.AutoSize = true;
            this.lblMaxBet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaxBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxBet.Location = new System.Drawing.Point(19, 102);
            this.lblMaxBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxBet.Name = "lblMaxBet";
            this.lblMaxBet.Size = new System.Drawing.Size(65, 17);
            this.lblMaxBet.TabIndex = 15;
            this.lblMaxBet.Text = "Max Bet";
            // 
            // lblPunter
            // 
            this.lblPunter.AutoSize = true;
            this.lblPunter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunter.Location = new System.Drawing.Point(19, 10);
            this.lblPunter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunter.Name = "lblPunter";
            this.lblPunter.Size = new System.Drawing.Size(52, 17);
            this.lblPunter.TabIndex = 9;
            this.lblPunter.Text = "Bettor";
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbAl.Location = new System.Drawing.Point(23, 78);
            this.rbAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(41, 21);
            this.rbAl.TabIndex = 8;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = false;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbBob.Location = new System.Drawing.Point(23, 52);
            this.rbBob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(54, 21);
            this.rbBob.TabIndex = 7;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = false;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbJoe.Location = new System.Drawing.Point(23, 28);
            this.rbJoe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(52, 21);
            this.rbJoe.TabIndex = 6;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = false;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(53, 15);
            this.btnRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(229, 47);
            this.btnRace.TabIndex = 21;
            this.btnRace.Text = "Race!!!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbHorse4
            // 
            this.pbHorse4.BackColor = System.Drawing.Color.Transparent;
            this.pbHorse4.BackgroundImage = global::HorseBetRace.MainResource.Horse4;
            this.pbHorse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHorse4.Location = new System.Drawing.Point(39, 369);
            this.pbHorse4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHorse4.Name = "pbHorse4";
            this.pbHorse4.Size = new System.Drawing.Size(85, 44);
            this.pbHorse4.TabIndex = 5;
            this.pbHorse4.TabStop = false;
            // 
            // pbHorse3
            // 
            this.pbHorse3.BackgroundImage = global::HorseBetRace.MainResource.Horse3;
            this.pbHorse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHorse3.Location = new System.Drawing.Point(39, 279);
            this.pbHorse3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHorse3.Name = "pbHorse3";
            this.pbHorse3.Size = new System.Drawing.Size(85, 48);
            this.pbHorse3.TabIndex = 4;
            this.pbHorse3.TabStop = false;
            // 
            // pbHorse2
            // 
            this.pbHorse2.BackgroundImage = global::HorseBetRace.MainResource.Horse2;
            this.pbHorse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHorse2.Location = new System.Drawing.Point(39, 183);
            this.pbHorse2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHorse2.Name = "pbHorse2";
            this.pbHorse2.Size = new System.Drawing.Size(85, 48);
            this.pbHorse2.TabIndex = 3;
            this.pbHorse2.TabStop = false;
            // 
            // pbHorse1
            // 
            this.pbHorse1.BackColor = System.Drawing.Color.Transparent;
            this.pbHorse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHorse1.Image = global::HorseBetRace.MainResource.Horse1;
            this.pbHorse1.InitialImage = null;
            this.pbHorse1.Location = new System.Drawing.Point(39, 89);
            this.pbHorse1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbHorse1.Name = "pbHorse1";
            this.pbHorse1.Size = new System.Drawing.Size(85, 48);
            this.pbHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHorse1.TabIndex = 2;
            this.pbHorse1.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackgroundImage = global::HorseBetRace.MainResource.racetrack;
            this.pbRaceTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRaceTrack.Location = new System.Drawing.Point(16, 60);
            this.pbRaceTrack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(691, 416);
            this.pbRaceTrack.TabIndex = 1;
            this.pbRaceTrack.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.IndianRed;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(367, 15);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(149, 47);
            this.btnRestart.TabIndex = 22;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(524, 15);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(149, 47);
            this.btnQuit.TabIndex = 23;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnRace);
            this.panel3.Controls.Add(this.btnQuit);
            this.panel3.Controls.Add(this.btnRestart);
            this.panel3.Location = new System.Drawing.Point(16, 624);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 81);
            this.panel3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 30);
            this.label3.TabIndex = 25;
            this.label3.Text = "Horse Betting Race!!!";
            // 
            // FormHorseBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(716, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbHorse4);
            this.Controls.Add(this.pbHorse3);
            this.Controls.Add(this.pbHorse2);
            this.Controls.Add(this.pbHorse1);
            this.Controls.Add(this.pbRaceTrack);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHorseBet";
            this.Text = "FormHorseBet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label lblMaxBet;
        private System.Windows.Forms.Label lblPunter;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.PictureBox pbHorse1;
        private System.Windows.Forms.PictureBox pbHorse2;
        private System.Windows.Forms.PictureBox pbHorse3;
        private System.Windows.Forms.PictureBox pbHorse4;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHorseNumber;
        private System.Windows.Forms.NumericUpDown nudCash;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblJoe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblBob;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}


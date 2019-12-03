namespace Guessing_Game
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.panelfirst = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnplayagain = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btntoohogh = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btntoolow = new System.Windows.Forms.Button();
            this.lbresult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbmsg = new System.Windows.Forms.Label();
            this.lbmyguess = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelfirst.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelfirst
            // 
            this.panelfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelfirst.Controls.Add(this.panel2);
            this.panelfirst.Controls.Add(this.panel1);
            this.panelfirst.Controls.Add(this.btnstart);
            this.panelfirst.Controls.Add(this.txtname);
            this.panelfirst.Controls.Add(this.label1);
            this.panelfirst.Location = new System.Drawing.Point(-2, 428);
            this.panelfirst.Name = "panelfirst";
            this.panelfirst.Size = new System.Drawing.Size(685, 53);
            this.panelfirst.TabIndex = 0;
            this.panelfirst.Paint += new System.Windows.Forms.PaintEventHandler(this.panelfirst_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(206, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 3);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 59);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guessing_Game.Properties.Resources.main2;
            this.pictureBox1.Location = new System.Drawing.Point(398, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Develop By : -";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnstart.FlatAppearance.BorderSize = 0;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.Black;
            this.btnstart.Location = new System.Drawing.Point(172, 221);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(367, 49);
            this.btnstart.TabIndex = 2;
            this.btnstart.Text = "START GAME";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtname.Location = new System.Drawing.Point(206, 137);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(299, 30);
            this.txtname.TabIndex = 1;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR NAME TO STRAT GAME";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.lbusername);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-2, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 42);
            this.panel3.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(9, 7);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(55, 27);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Visible = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(361, 10);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(47, 23);
            this.lbusername.TabIndex = 2;
            this.lbusername.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "User name is : -";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.btnplayagain);
            this.panel4.Controls.Add(this.btnplay);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-2, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 201);
            this.panel4.TabIndex = 2;
            // 
            // btnplayagain
            // 
            this.btnplayagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnplayagain.FlatAppearance.BorderSize = 0;
            this.btnplayagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplayagain.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplayagain.ForeColor = System.Drawing.Color.Black;
            this.btnplayagain.Location = new System.Drawing.Point(360, 139);
            this.btnplayagain.Name = "btnplayagain";
            this.btnplayagain.Size = new System.Drawing.Size(174, 45);
            this.btnplayagain.TabIndex = 6;
            this.btnplayagain.Text = "PLAY AGAIN";
            this.btnplayagain.UseVisualStyleBackColor = false;
            this.btnplayagain.Click += new System.EventHandler(this.btnplayagain_Click);
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnplay.FlatAppearance.BorderSize = 0;
            this.btnplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplay.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.Color.Black;
            this.btnplay.Location = new System.Drawing.Point(168, 139);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(174, 45);
            this.btnplay.TabIndex = 5;
            this.btnplay.Text = "PLAY";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Click PLAY when ready.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(563, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Think of a number between 1 and 100. And I\' ll try to guess it.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number Guess Guesser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 30);
            this.label4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.btntoohogh);
            this.panel5.Controls.Add(this.btnright);
            this.panel5.Controls.Add(this.btntoolow);
            this.panel5.Controls.Add(this.lbresult);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.lbmsg);
            this.panel5.Controls.Add(this.lbmyguess);
            this.panel5.Location = new System.Drawing.Point(-2, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(685, 183);
            this.panel5.TabIndex = 3;
            // 
            // btntoohogh
            // 
            this.btntoohogh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btntoohogh.FlatAppearance.BorderSize = 0;
            this.btntoohogh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoohogh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoohogh.ForeColor = System.Drawing.Color.Black;
            this.btntoohogh.Location = new System.Drawing.Point(497, 135);
            this.btntoohogh.Name = "btntoohogh";
            this.btntoohogh.Size = new System.Drawing.Size(166, 32);
            this.btntoohogh.TabIndex = 9;
            this.btntoohogh.Text = "Too High";
            this.btntoohogh.UseVisualStyleBackColor = false;
            this.btntoohogh.Click += new System.EventHandler(this.btntoohogh_Click);
            // 
            // btnright
            // 
            this.btnright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnright.FlatAppearance.BorderSize = 0;
            this.btnright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnright.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnright.ForeColor = System.Drawing.Color.Black;
            this.btnright.Location = new System.Drawing.Point(257, 135);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(166, 32);
            this.btnright.TabIndex = 8;
            this.btnright.Text = "Exactly Right";
            this.btnright.UseVisualStyleBackColor = false;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btntoolow
            // 
            this.btntoolow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btntoolow.FlatAppearance.BorderSize = 0;
            this.btntoolow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoolow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoolow.ForeColor = System.Drawing.Color.Black;
            this.btntoolow.Location = new System.Drawing.Point(17, 135);
            this.btntoolow.Name = "btntoolow";
            this.btntoolow.Size = new System.Drawing.Size(166, 32);
            this.btntoolow.TabIndex = 7;
            this.btntoolow.Text = "Too Low";
            this.btntoolow.UseVisualStyleBackColor = false;
            this.btntoolow.Click += new System.EventHandler(this.btntoolow_Click);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.Location = new System.Drawing.Point(329, 44);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(34, 37);
            this.lbresult.TabIndex = 5;
            this.lbresult.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 37);
            this.label8.TabIndex = 6;
            this.label8.Text = "......................";
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmsg.Location = new System.Drawing.Point(202, 92);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(140, 22);
            this.lbmsg.TabIndex = 4;
            this.lbmsg.Text = "message lable";
            // 
            // lbmyguess
            // 
            this.lbmyguess.AutoSize = true;
            this.lbmyguess.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmyguess.Location = new System.Drawing.Point(271, 9);
            this.lbmyguess.Name = "lbmyguess";
            this.lbmyguess.Size = new System.Drawing.Size(150, 28);
            this.lbmyguess.TabIndex = 3;
            this.lbmyguess.Text = "My Guess is";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(-3, 425);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(685, 59);
            this.panel6.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Guessing_Game.Properties.Resources.main2;
            this.pictureBox2.Location = new System.Drawing.Point(405, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 30);
            this.label9.TabIndex = 4;
            this.label9.Text = "Develop By : -";
            // 
            // frmmain
            // 
            this.AcceptButton = this.btnplay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panelfirst);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.panelfirst.ResumeLayout(false);
            this.panelfirst.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelfirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Label lbmyguess;
        private System.Windows.Forms.Button btntoohogh;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btntoolow;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnplayagain;
    }
}


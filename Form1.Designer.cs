namespace rsp
{
    partial class dd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cpuText = new System.Windows.Forms.Label();
            this.playerResult = new System.Windows.Forms.Label();
            this.cpuResult = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameNum = new System.Windows.Forms.NumericUpDown();
            this.gamesCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paperPlayer = new System.Windows.Forms.PictureBox();
            this.ScissorsPlayer = new System.Windows.Forms.PictureBox();
            this.rockPlayer = new System.Windows.Forms.PictureBox();
            this.rockCPU = new System.Windows.Forms.PictureBox();
            this.scissorsCPU = new System.Windows.Forms.PictureBox();
            this.paperCPU = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cpuText);
            this.panel1.Controls.Add(this.playerResult);
            this.panel1.Controls.Add(this.cpuResult);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.gameNum);
            this.panel1.Controls.Add(this.gamesCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 543);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(3, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PLAYER";
            // 
            // cpuText
            // 
            this.cpuText.AutoSize = true;
            this.cpuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpuText.ForeColor = System.Drawing.Color.Snow;
            this.cpuText.Location = new System.Drawing.Point(3, 201);
            this.cpuText.Name = "cpuText";
            this.cpuText.Size = new System.Drawing.Size(54, 25);
            this.cpuText.TabIndex = 6;
            this.cpuText.Text = "CPU";
            // 
            // playerResult
            // 
            this.playerResult.AutoSize = true;
            this.playerResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerResult.ForeColor = System.Drawing.Color.Red;
            this.playerResult.Location = new System.Drawing.Point(3, 258);
            this.playerResult.Name = "playerResult";
            this.playerResult.Size = new System.Drawing.Size(23, 25);
            this.playerResult.TabIndex = 5;
            this.playerResult.Text = "0";
            // 
            // cpuResult
            // 
            this.cpuResult.AutoSize = true;
            this.cpuResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpuResult.ForeColor = System.Drawing.Color.Red;
            this.cpuResult.Location = new System.Drawing.Point(3, 226);
            this.cpuResult.Name = "cpuResult";
            this.cpuResult.Size = new System.Drawing.Size(23, 25);
            this.cpuResult.TabIndex = 4;
            this.cpuResult.Text = "0";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(63, 429);
            this.startButton.Name = "startButton";
            this.startButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startButton.Size = new System.Drawing.Size(47, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startButton_MouseClick);
            // 
            // gameNum
            // 
            this.gameNum.Location = new System.Drawing.Point(12, 428);
            this.gameNum.Name = "gameNum";
            this.gameNum.Size = new System.Drawing.Size(45, 22);
            this.gameNum.TabIndex = 2;
            this.gameNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gameNum.ValueChanged += new System.EventHandler(this.gameNum_ValueChanged);
            // 
            // gamesCount
            // 
            this.gamesCount.AutoSize = true;
            this.gamesCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesCount.ForeColor = System.Drawing.Color.Red;
            this.gamesCount.Location = new System.Drawing.Point(44, 498);
            this.gamesCount.Name = "gamesCount";
            this.gamesCount.Size = new System.Drawing.Size(0, 29);
            this.gamesCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAMES";
            // 
            // paperPlayer
            // 
            this.paperPlayer.Enabled = false;
            this.paperPlayer.Image = global::rsp.Properties.Resources.paper;
            this.paperPlayer.Location = new System.Drawing.Point(128, 368);
            this.paperPlayer.Name = "paperPlayer";
            this.paperPlayer.Size = new System.Drawing.Size(169, 160);
            this.paperPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperPlayer.TabIndex = 1;
            this.paperPlayer.TabStop = false;
            this.paperPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paperPlayer_MouseClick);
            // 
            // ScissorsPlayer
            // 
            this.ScissorsPlayer.Enabled = false;
            this.ScissorsPlayer.Image = global::rsp.Properties.Resources.scissors;
            this.ScissorsPlayer.Location = new System.Drawing.Point(478, 368);
            this.ScissorsPlayer.Name = "ScissorsPlayer";
            this.ScissorsPlayer.Size = new System.Drawing.Size(169, 160);
            this.ScissorsPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScissorsPlayer.TabIndex = 2;
            this.ScissorsPlayer.TabStop = false;
            this.ScissorsPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScissorsPlayer_MouseClick);
            // 
            // rockPlayer
            // 
            this.rockPlayer.Enabled = false;
            this.rockPlayer.Image = global::rsp.Properties.Resources.rock;
            this.rockPlayer.Location = new System.Drawing.Point(303, 368);
            this.rockPlayer.Name = "rockPlayer";
            this.rockPlayer.Size = new System.Drawing.Size(169, 160);
            this.rockPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockPlayer.TabIndex = 3;
            this.rockPlayer.TabStop = false;
            this.rockPlayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rockPlayer_MouseClick);
            // 
            // rockCPU
            // 
            this.rockCPU.Image = global::rsp.Properties.Resources.rockCPU;
            this.rockCPU.Location = new System.Drawing.Point(303, 12);
            this.rockCPU.Name = "rockCPU";
            this.rockCPU.Size = new System.Drawing.Size(169, 160);
            this.rockCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockCPU.TabIndex = 6;
            this.rockCPU.TabStop = false;
            // 
            // scissorsCPU
            // 
            this.scissorsCPU.Image = global::rsp.Properties.Resources.scissorsCPU;
            this.scissorsCPU.Location = new System.Drawing.Point(478, 12);
            this.scissorsCPU.Name = "scissorsCPU";
            this.scissorsCPU.Size = new System.Drawing.Size(169, 160);
            this.scissorsCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissorsCPU.TabIndex = 5;
            this.scissorsCPU.TabStop = false;
            // 
            // paperCPU
            // 
            this.paperCPU.Image = global::rsp.Properties.Resources.paperCPU;
            this.paperCPU.Location = new System.Drawing.Point(128, 12);
            this.paperCPU.Name = "paperCPU";
            this.paperCPU.Size = new System.Drawing.Size(169, 160);
            this.paperCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paperCPU.TabIndex = 4;
            this.paperCPU.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(-1, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "ROCK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-1, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "PAPER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(0, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "SCISSORS";
            // 
            // dd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(657, 541);
            this.Controls.Add(this.rockCPU);
            this.Controls.Add(this.scissorsCPU);
            this.Controls.Add(this.paperCPU);
            this.Controls.Add(this.rockPlayer);
            this.Controls.Add(this.ScissorsPlayer);
            this.Controls.Add(this.paperPlayer);
            this.Controls.Add(this.panel1);
            this.Name = "dd";
            this.Text = "Rock, Paper, Scissors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label gamesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown gameNum;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox paperPlayer;
        private System.Windows.Forms.PictureBox ScissorsPlayer;
        private System.Windows.Forms.PictureBox rockPlayer;
        private System.Windows.Forms.PictureBox rockCPU;
        private System.Windows.Forms.PictureBox scissorsCPU;
        private System.Windows.Forms.PictureBox paperCPU;
        private System.Windows.Forms.Label cpuResult;
        private System.Windows.Forms.Label playerResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cpuText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}


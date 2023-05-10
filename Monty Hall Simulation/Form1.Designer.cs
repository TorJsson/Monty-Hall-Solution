using System;

namespace Monty_Hall_Simulation
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
            this.cbChangeDoor = new System.Windows.Forms.CheckBox();
            this.tbNumberOfGames = new System.Windows.Forms.TextBox();
            this.lblProb = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbProbability = new System.Windows.Forms.Label();
            this.tbProb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lbWinResult = new System.Windows.Forms.Label();
            this.lbLossesResult = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.lbLosses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbChangeDoor
            // 
            this.cbChangeDoor.AutoSize = true;
            this.cbChangeDoor.Location = new System.Drawing.Point(215, 110);
            this.cbChangeDoor.Name = "cbChangeDoor";
            this.cbChangeDoor.Size = new System.Drawing.Size(104, 20);
            this.cbChangeDoor.TabIndex = 0;
            this.cbChangeDoor.Text = "Change door";
            this.cbChangeDoor.UseVisualStyleBackColor = true;
            // 
            // tbNumberOfGames
            // 
            this.tbNumberOfGames.Location = new System.Drawing.Point(215, 136);
            this.tbNumberOfGames.Name = "tbNumberOfGames";
            this.tbNumberOfGames.Size = new System.Drawing.Size(100, 22);
            this.tbNumberOfGames.TabIndex = 1;
            // 
            // lblProb
            // 
            this.lblProb.AutoSize = true;
            this.lblProb.Location = new System.Drawing.Point(92, 175);
            this.lblProb.Name = "lblProb";
            this.lblProb.Size = new System.Drawing.Size(110, 16);
            this.lblProb.TabIndex = 2;
            this.lblProb.Text = "Probability to win:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(382, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbProbability
            // 
            this.lbProbability.AutoSize = true;
            this.lbProbability.Location = new System.Drawing.Point(215, 165);
            this.lbProbability.Name = "lbProbability";
            this.lbProbability.Size = new System.Drawing.Size(0, 16);
            this.lbProbability.TabIndex = 4;
            // 
            // tbProb
            // 
            this.tbProb.Location = new System.Drawing.Point(215, 175);
            this.tbProb.Name = "tbProb";
            this.tbProb.ReadOnly = true;
            this.tbProb.Size = new System.Drawing.Size(100, 22);
            this.tbProb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of games:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(215, 204);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(0, 16);
            this.lblWins.TabIndex = 8;
            // 
            // lbWinResult
            // 
            this.lbWinResult.AutoSize = true;
            this.lbWinResult.Location = new System.Drawing.Point(212, 224);
            this.lbWinResult.Name = "lbWinResult";
            this.lbWinResult.Size = new System.Drawing.Size(0, 16);
            this.lbWinResult.TabIndex = 9;
            // 
            // lbLossesResult
            // 
            this.lbLossesResult.AutoSize = true;
            this.lbLossesResult.Location = new System.Drawing.Point(212, 253);
            this.lbLossesResult.Name = "lbLossesResult";
            this.lbLossesResult.Size = new System.Drawing.Size(0, 16);
            this.lbLossesResult.TabIndex = 10;
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.Location = new System.Drawing.Point(95, 224);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(40, 16);
            this.lbWin.TabIndex = 11;
            this.lbWin.Text = "Wins:";
            // 
            // lbLosses
            // 
            this.lbLosses.AutoSize = true;
            this.lbLosses.Location = new System.Drawing.Point(95, 253);
            this.lbLosses.Name = "lbLosses";
            this.lbLosses.Size = new System.Drawing.Size(54, 16);
            this.lbLosses.TabIndex = 12;
            this.lbLosses.Text = "Losses:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLosses);
            this.Controls.Add(this.lbWin);
            this.Controls.Add(this.lbLossesResult);
            this.Controls.Add(this.lbWinResult);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbProb);
            this.Controls.Add(this.lbProbability);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblProb);
            this.Controls.Add(this.tbNumberOfGames);
            this.Controls.Add(this.cbChangeDoor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.CheckBox cbChangeDoor;
        private System.Windows.Forms.TextBox tbNumberOfGames;
        private System.Windows.Forms.Label lblProb;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbProbability;
        private System.Windows.Forms.TextBox tbProb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lbWinResult;
        private System.Windows.Forms.Label lbLossesResult;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.Label lbLosses;
    }
}


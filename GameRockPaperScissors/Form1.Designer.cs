namespace GameRockPaperScissors
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
            this.rock_btn = new System.Windows.Forms.Button();
            this.paper_btn = new System.Windows.Forms.Button();
            this.scissors_btn = new System.Windows.Forms.Button();
            this.restart_btn = new System.Windows.Forms.Button();
            this.pc_score_label = new System.Windows.Forms.Label();
            this.player_score_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pc_choice_label = new System.Windows.Forms.Label();
            this.player_choice_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rock_btn
            // 
            this.rock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rock_btn.Location = new System.Drawing.Point(153, 325);
            this.rock_btn.Name = "rock_btn";
            this.rock_btn.Size = new System.Drawing.Size(137, 57);
            this.rock_btn.TabIndex = 0;
            this.rock_btn.Text = "Rock";
            this.rock_btn.UseVisualStyleBackColor = true;
            this.rock_btn.Click += new System.EventHandler(this.rock_btn_Click);
            // 
            // paper_btn
            // 
            this.paper_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper_btn.Location = new System.Drawing.Point(319, 325);
            this.paper_btn.Name = "paper_btn";
            this.paper_btn.Size = new System.Drawing.Size(137, 57);
            this.paper_btn.TabIndex = 1;
            this.paper_btn.Text = "Paper";
            this.paper_btn.UseVisualStyleBackColor = true;
            this.paper_btn.Click += new System.EventHandler(this.paper_btn_Click);
            // 
            // scissors_btn
            // 
            this.scissors_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissors_btn.Location = new System.Drawing.Point(484, 325);
            this.scissors_btn.Name = "scissors_btn";
            this.scissors_btn.Size = new System.Drawing.Size(137, 57);
            this.scissors_btn.TabIndex = 2;
            this.scissors_btn.Text = "Scissors";
            this.scissors_btn.UseVisualStyleBackColor = true;
            this.scissors_btn.Click += new System.EventHandler(this.scissors_btn_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(651, 51);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(137, 57);
            this.restart_btn.TabIndex = 3;
            this.restart_btn.Text = "Restart game";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // pc_score_label
            // 
            this.pc_score_label.AutoSize = true;
            this.pc_score_label.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_score_label.Location = new System.Drawing.Point(416, 185);
            this.pc_score_label.Name = "pc_score_label";
            this.pc_score_label.Size = new System.Drawing.Size(69, 72);
            this.pc_score_label.TabIndex = 5;
            this.pc_score_label.Text = "0";
            // 
            // player_score_label
            // 
            this.player_score_label.AutoSize = true;
            this.player_score_label.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_score_label.Location = new System.Drawing.Point(307, 185);
            this.player_score_label.Name = "player_score_label";
            this.player_score_label.Size = new System.Drawing.Size(69, 72);
            this.player_score_label.TabIndex = 6;
            this.player_score_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // pc_choice_label
            // 
            this.pc_choice_label.AutoSize = true;
            this.pc_choice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_choice_label.Location = new System.Drawing.Point(481, 107);
            this.pc_choice_label.Name = "pc_choice_label";
            this.pc_choice_label.Size = new System.Drawing.Size(55, 33);
            this.pc_choice_label.TabIndex = 8;
            this.pc_choice_label.Text = "PC";
            // 
            // player_choice_label
            // 
            this.player_choice_label.AutoSize = true;
            this.player_choice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_choice_label.Location = new System.Drawing.Point(245, 107);
            this.player_choice_label.Name = "player_choice_label";
            this.player_choice_label.Size = new System.Drawing.Size(79, 33);
            this.player_choice_label.TabIndex = 9;
            this.player_choice_label.Text = "YOU";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.Location = new System.Drawing.Point(348, 51);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(108, 29);
            this.result_label.TabIndex = 10;
            this.result_label.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.player_choice_label);
            this.Controls.Add(this.pc_choice_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.player_score_label);
            this.Controls.Add(this.pc_score_label);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.scissors_btn);
            this.Controls.Add(this.paper_btn);
            this.Controls.Add(this.rock_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock_btn;
        private System.Windows.Forms.Button paper_btn;
        private System.Windows.Forms.Button scissors_btn;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Label pc_score_label;
        private System.Windows.Forms.Label player_score_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pc_choice_label;
        private System.Windows.Forms.Label player_choice_label;
        private System.Windows.Forms.Label result_label;
    }
}


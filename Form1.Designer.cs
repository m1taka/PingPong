namespace PingPong
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
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(357, 420);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(145, 250);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.points_lbl);
            this.playground.Controls.Add(this.score_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(789, 452);
            this.playground.TabIndex = 2;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameover_lbl.Location = new System.Drawing.Point(292, 62);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(277, 220);
            this.gameover_lbl.TabIndex = 5;
            this.gameover_lbl.Text = "Game Over\r\n\r\nF1 - Restart\r\nEsc - Exit";
            this.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points_lbl.Location = new System.Drawing.Point(161, 9);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(39, 42);
            this.points_lbl.TabIndex = 4;
            this.points_lbl.Text = "0";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score_lbl.Location = new System.Drawing.Point(12, 9);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(143, 42);
            this.score_lbl.TabIndex = 2;
            this.score_lbl.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 452);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label score_lbl;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label gameover_lbl;
    }
}


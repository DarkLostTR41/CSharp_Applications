namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Graund = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeBotton = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOver_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBotton)).BeginInit();
            this.SuspendLayout();
            // 
            // Graund
            // 
            this.Graund.Image = ((System.Drawing.Image)(resources.GetObject("Graund.Image")));
            this.Graund.Location = new System.Drawing.Point(-3, 594);
            this.Graund.Name = "Graund";
            this.Graund.Size = new System.Drawing.Size(711, 91);
            this.Graund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Graund.TabIndex = 0;
            this.Graund.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(75, 290);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(60, 49);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop.Image")));
            this.PipeTop.Location = new System.Drawing.Point(378, -119);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(86, 312);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 2;
            this.PipeTop.TabStop = false;
            // 
            // PipeBotton
            // 
            this.PipeBotton.Image = ((System.Drawing.Image)(resources.GetObject("PipeBotton.Image")));
            this.PipeBotton.Location = new System.Drawing.Point(256, 431);
            this.PipeBotton.Name = "PipeBotton";
            this.PipeBotton.Size = new System.Drawing.Size(86, 194);
            this.PipeBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBotton.TabIndex = 3;
            this.PipeBotton.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Playbill", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.Black;
            this.ScoreText.Location = new System.Drawing.Point(31, 28);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(100, 33);
            this.ScoreText.TabIndex = 5;
            this.ScoreText.Text = "Score :  0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // GameOver_label
            // 
            this.GameOver_label.AutoSize = true;
            this.GameOver_label.Font = new System.Drawing.Font("Swis721 BlkEx BT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver_label.ForeColor = System.Drawing.Color.Red;
            this.GameOver_label.Location = new System.Drawing.Point(45, 262);
            this.GameOver_label.Name = "GameOver_label";
            this.GameOver_label.Size = new System.Drawing.Size(0, 57);
            this.GameOver_label.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 685);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.GameOver_label);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Graund);
            this.Controls.Add(this.PipeBotton);
            this.Controls.Add(this.flappyBird);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Flappy bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Graund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBotton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Graund;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeBotton;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label GameOver_label;
    }
}


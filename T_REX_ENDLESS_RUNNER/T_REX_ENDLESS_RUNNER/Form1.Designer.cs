namespace T_REX_ENDLESS_RUNNER
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
            this.Trex = new System.Windows.Forms.PictureBox();
            this.Obstacle = new System.Windows.Forms.PictureBox();
            this.obstacle_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameOver_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Trex
            // 
            this.Trex.Image = global::T_REX_ENDLESS_RUNNER.Properties.Resources.running;
            this.Trex.Location = new System.Drawing.Point(75, 363);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(40, 43);
            this.Trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Trex.TabIndex = 0;
            this.Trex.TabStop = false;
            // 
            // Obstacle
            // 
            this.Obstacle.Image = global::T_REX_ENDLESS_RUNNER.Properties.Resources.obstacle_1;
            this.Obstacle.Location = new System.Drawing.Point(462, 360);
            this.Obstacle.Name = "Obstacle";
            this.Obstacle.Size = new System.Drawing.Size(23, 46);
            this.Obstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Obstacle.TabIndex = 1;
            this.Obstacle.TabStop = false;
            this.Obstacle.Tag = "obstacle";
            // 
            // obstacle_2
            // 
            this.obstacle_2.Image = global::T_REX_ENDLESS_RUNNER.Properties.Resources.obstacle_2;
            this.obstacle_2.Location = new System.Drawing.Point(635, 373);
            this.obstacle_2.Name = "obstacle_2";
            this.obstacle_2.Size = new System.Drawing.Size(32, 33);
            this.obstacle_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle_2.TabIndex = 2;
            this.obstacle_2.TabStop = false;
            this.obstacle_2.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(1, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(805, 45);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(18, 26);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(123, 31);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score :0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // GameOver_label
            // 
            this.GameOver_label.AutoSize = true;
            this.GameOver_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver_label.Location = new System.Drawing.Point(141, 145);
            this.GameOver_label.Name = "GameOver_label";
            this.GameOver_label.Size = new System.Drawing.Size(0, 73);
            this.GameOver_label.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameOver_label);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.obstacle_2);
            this.Controls.Add(this.Obstacle);
            this.Controls.Add(this.Trex);
            this.Name = "Form1";
            this.Text = "T Rex Endless Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Trex;
        private System.Windows.Forms.PictureBox Obstacle;
        private System.Windows.Forms.PictureBox obstacle_2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label GameOver_label;
    }
}


namespace Floaty_Fish
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.floor = new System.Windows.Forms.PictureBox();
            this.coralBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.floatyFish = new System.Windows.Forms.PictureBox();
            this.boatTop = new System.Windows.Forms.PictureBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coralBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatyFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatTop)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Navy;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreText.Location = new System.Drawing.Point(1, 1);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(118, 37);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.SandyBrown;
            this.floor.Location = new System.Drawing.Point(-4, 624);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(3847, 48);
            this.floor.TabIndex = 6;
            this.floor.TabStop = false;
            this.floor.Click += new System.EventHandler(this.floor_Click);
            // 
            // coralBottom
            // 
            this.coralBottom.BackColor = System.Drawing.Color.Transparent;
            this.coralBottom.Image = global::Floaty_Fish.Properties.Resources.pipe3;
            this.coralBottom.Location = new System.Drawing.Point(338, 320);
            this.coralBottom.Name = "coralBottom";
            this.coralBottom.Size = new System.Drawing.Size(310, 374);
            this.coralBottom.TabIndex = 4;
            this.coralBottom.TabStop = false;
            this.coralBottom.Click += new System.EventHandler(this.coralBottom_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.SandyBrown;
            this.ground.Location = new System.Drawing.Point(-1, 1011);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1476, 50);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // floatyFish
            // 
            this.floatyFish.BackColor = System.Drawing.Color.Transparent;
            this.floatyFish.Image = global::Floaty_Fish.Properties.Resources.fish2;
            this.floatyFish.Location = new System.Drawing.Point(-1, 124);
            this.floatyFish.Name = "floatyFish";
            this.floatyFish.Size = new System.Drawing.Size(124, 111);
            this.floatyFish.TabIndex = 2;
            this.floatyFish.TabStop = false;
            this.floatyFish.Click += new System.EventHandler(this.floatyFish_Click);
            // 
            // boatTop
            // 
            this.boatTop.BackColor = System.Drawing.Color.Transparent;
            this.boatTop.Image = global::Floaty_Fish.Properties.Resources.boat5;
            this.boatTop.Location = new System.Drawing.Point(146, -18);
            this.boatTop.Name = "boatTop";
            this.boatTop.Size = new System.Drawing.Size(375, 93);
            this.boatTop.TabIndex = 1;
            this.boatTop.TabStop = false;
            this.boatTop.Click += new System.EventHandler(this.boatTop_Click);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.BackColor = System.Drawing.Color.SandyBrown;
            this.Copyright.Location = new System.Drawing.Point(466, 655);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(153, 13);
            this.Copyright.TabIndex = 7;
            this.Copyright.Text = "Copyright © 2022 T.Kalvintech";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.Color.SandyBrown;
            this.Version.Location = new System.Drawing.Point(5, 655);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(148, 13);
            this.Version.TabIndex = 8;
            this.Version.Text = "Version 1.0 Beta (0000.0.001)";
            this.Version.Click += new System.EventHandler(this.Version_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(622, 671);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.floatyFish);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.coralBottom);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.boatTop);
            this.Name = "Form1";
            this.Text = "Floaty Fish";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coralBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatyFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox floatyFish;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox coralBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox boatTop;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label Version;
    }
}


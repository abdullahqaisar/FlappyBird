
namespace ProjectFloopyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Uperblock = new System.Windows.Forms.PictureBox();
            this.lowerblock = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uperblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerblock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::ProjectFloopyBird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(24, 110);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(49, 43);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // Uperblock
            // 
            this.Uperblock.Image = global::ProjectFloopyBird.Properties.Resources.pipedown;
            this.Uperblock.Location = new System.Drawing.Point(557, -17);
            this.Uperblock.Name = "Uperblock";
            this.Uperblock.Size = new System.Drawing.Size(80, 196);
            this.Uperblock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Uperblock.TabIndex = 1;
            this.Uperblock.TabStop = false;
            this.Uperblock.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lowerblock
            // 
            this.lowerblock.Image = global::ProjectFloopyBird.Properties.Resources.pipe;
            this.lowerblock.Location = new System.Drawing.Point(402, 295);
            this.lowerblock.Name = "lowerblock";
            this.lowerblock.Size = new System.Drawing.Size(80, 217);
            this.lowerblock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lowerblock.TabIndex = 2;
            this.lowerblock.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::ProjectFloopyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-28, 462);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(837, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(667, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.lowerblock);
            this.Controls.Add(this.Uperblock);
            this.Controls.Add(this.bird);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "SCORE : ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Uperblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerblock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox Uperblock;
        private System.Windows.Forms.PictureBox lowerblock;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gametimer;
    }
}


namespace Topic_9___Assignment
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
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.imgGood = new System.Windows.Forms.PictureBox();
            this.imgBad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGood.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.Location = new System.Drawing.Point(189, 375);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(126, 63);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.Location = new System.Drawing.Point(481, 375);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(126, 63);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // imgGood
            // 
            this.imgGood.Image = global::Topic_9___Assignment.Properties.Resources.download__4_;
            this.imgGood.Location = new System.Drawing.Point(255, 68);
            this.imgGood.Name = "imgGood";
            this.imgGood.Size = new System.Drawing.Size(301, 241);
            this.imgGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGood.TabIndex = 3;
            this.imgGood.TabStop = false;
            this.imgGood.Visible = false;
            // 
            // imgBad
            // 
            this.imgBad.Image = global::Topic_9___Assignment.Properties.Resources.prisoner;
            this.imgBad.Location = new System.Drawing.Point(255, 68);
            this.imgBad.Name = "imgBad";
            this.imgBad.Size = new System.Drawing.Size(301, 241);
            this.imgBad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBad.TabIndex = 2;
            this.imgBad.TabStop = false;
            this.imgBad.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgGood);
            this.Controls.Add(this.imgBad);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox imgBad;
        private System.Windows.Forms.PictureBox imgGood;
    }
}


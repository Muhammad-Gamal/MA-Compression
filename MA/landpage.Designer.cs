
namespace MA
{
    partial class landpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landpage));
            this.picGIF = new System.Windows.Forms.PictureBox();
            this.startBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // picGIF
            // 
            this.picGIF.Image = ((System.Drawing.Image)(resources.GetObject("picGIF.Image")));
            this.picGIF.Location = new System.Drawing.Point(-5, -6);
            this.picGIF.Margin = new System.Windows.Forms.Padding(2);
            this.picGIF.Name = "picGIF";
            this.picGIF.Size = new System.Drawing.Size(914, 485);
            this.picGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGIF.TabIndex = 4;
            this.picGIF.TabStop = false;
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.startBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.startBTN.FlatAppearance.BorderSize = 0;
            this.startBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.Black;
            this.startBTN.Location = new System.Drawing.Point(642, 345);
            this.startBTN.Margin = new System.Windows.Forms.Padding(2);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(130, 41);
            this.startBTN.TabIndex = 5;
            this.startBTN.Text = "Get Started";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // landpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(920, 490);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.picGIF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "landpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "landpage";
            ((System.ComponentModel.ISupportInitialize)(this.picGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGIF;
        private System.Windows.Forms.Button startBTN;
    }
}
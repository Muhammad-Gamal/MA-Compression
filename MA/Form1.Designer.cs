namespace MA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnHF = new System.Windows.Forms.Button();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnLZW = new System.Windows.Forms.Button();
            this.btnVLC = new System.Windows.Forms.Button();
            this.btnRLC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnHF);
            this.panel1.Controls.Add(this.btnAD);
            this.panel1.Controls.Add(this.btnLZW);
            this.panel1.Controls.Add(this.btnVLC);
            this.panel1.Controls.Add(this.btnRLC);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 600);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 157);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(2, 81);
            this.pnlNav.TabIndex = 9;
            // 
            // btnHF
            // 
            this.btnHF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHF.FlatAppearance.BorderSize = 0;
            this.btnHF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHF.ForeColor = System.Drawing.Color.White;
            this.btnHF.Location = new System.Drawing.Point(0, 264);
            this.btnHF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHF.Name = "btnHF";
            this.btnHF.Size = new System.Drawing.Size(128, 32);
            this.btnHF.TabIndex = 8;
            this.btnHF.Text = "Huffman";
            this.btnHF.UseVisualStyleBackColor = true;
            this.btnHF.Click += new System.EventHandler(this.btnHF_Click);
            this.btnHF.Leave += new System.EventHandler(this.btnHF_Leave);
            // 
            // btnAD
            // 
            this.btnAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAD.FlatAppearance.BorderSize = 0;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAD.ForeColor = System.Drawing.Color.White;
            this.btnAD.Location = new System.Drawing.Point(0, 232);
            this.btnAD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(128, 32);
            this.btnAD.TabIndex = 7;
            this.btnAD.Text = "Adaptive";
            this.btnAD.UseVisualStyleBackColor = true;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            this.btnAD.Leave += new System.EventHandler(this.btnAD_Leave);
            // 
            // btnLZW
            // 
            this.btnLZW.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLZW.FlatAppearance.BorderSize = 0;
            this.btnLZW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLZW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLZW.ForeColor = System.Drawing.Color.White;
            this.btnLZW.Location = new System.Drawing.Point(0, 200);
            this.btnLZW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLZW.Name = "btnLZW";
            this.btnLZW.Size = new System.Drawing.Size(128, 32);
            this.btnLZW.TabIndex = 6;
            this.btnLZW.Text = "LZW";
            this.btnLZW.UseVisualStyleBackColor = true;
            this.btnLZW.Click += new System.EventHandler(this.btnLZW_Click);
            this.btnLZW.Leave += new System.EventHandler(this.btnLZW_Leave);
            // 
            // btnVLC
            // 
            this.btnVLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVLC.FlatAppearance.BorderSize = 0;
            this.btnVLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVLC.ForeColor = System.Drawing.Color.White;
            this.btnVLC.Location = new System.Drawing.Point(0, 168);
            this.btnVLC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVLC.Name = "btnVLC";
            this.btnVLC.Size = new System.Drawing.Size(128, 32);
            this.btnVLC.TabIndex = 5;
            this.btnVLC.Text = "VLC";
            this.btnVLC.UseVisualStyleBackColor = true;
            this.btnVLC.Click += new System.EventHandler(this.button2_Click);
            this.btnVLC.Leave += new System.EventHandler(this.btnVLC_Leave);
            // 
            // btnRLC
            // 
            this.btnRLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRLC.FlatAppearance.BorderSize = 0;
            this.btnRLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRLC.ForeColor = System.Drawing.Color.White;
            this.btnRLC.Location = new System.Drawing.Point(0, 136);
            this.btnRLC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRLC.Name = "btnRLC";
            this.btnRLC.Size = new System.Drawing.Size(128, 32);
            this.btnRLC.TabIndex = 4;
            this.btnRLC.Text = "RLC";
            this.btnRLC.UseVisualStyleBackColor = true;
            this.btnRLC.Click += new System.EventHandler(this.button1_Click_1);
            this.btnRLC.Leave += new System.EventHandler(this.btnRLC_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MA.Properties.Resources.Black__White_and_Teal_Sound_Bar_Djor_Music_Dj_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlLoader
            // 
            this.pnlLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLoader.Location = new System.Drawing.Point(128, 11);
            this.pnlLoader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLoader.Name = "pnlLoader";
            this.pnlLoader.Size = new System.Drawing.Size(792, 589);
            this.pnlLoader.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.pnlLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRLC;
        private System.Windows.Forms.Button btnVLC;
        private System.Windows.Forms.Button btnHF;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnLZW;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlLoader;
        private System.Windows.Forms.Button button1;
    }
}


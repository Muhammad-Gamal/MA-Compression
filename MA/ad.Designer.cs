namespace MA
{
    partial class ad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ad));
            this.ad2 = new System.Windows.Forms.Label();
            this.AD_Encode = new System.Windows.Forms.Button();
            this.lz = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AD_Tree = new System.Windows.Forms.Button();
            this.txtAD_result = new System.Windows.Forms.RichTextBox();
            this.AD_Entropy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.AD_Decode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // ad2
            // 
            this.ad2.AutoSize = true;
            this.ad2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ad2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad2.ForeColor = System.Drawing.Color.White;
            this.ad2.Location = new System.Drawing.Point(45, 96);
            this.ad2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ad2.Name = "ad2";
            this.ad2.Size = new System.Drawing.Size(110, 13);
            this.ad2.TabIndex = 36;
            this.ad2.Text = "Enter Your Message";
            // 
            // AD_Encode
            // 
            this.AD_Encode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.AD_Encode.FlatAppearance.BorderSize = 0;
            this.AD_Encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_Encode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD_Encode.Location = new System.Drawing.Point(521, 48);
            this.AD_Encode.Margin = new System.Windows.Forms.Padding(2);
            this.AD_Encode.Name = "AD_Encode";
            this.AD_Encode.Size = new System.Drawing.Size(93, 35);
            this.AD_Encode.TabIndex = 34;
            this.AD_Encode.Text = "Encode";
            this.AD_Encode.UseVisualStyleBackColor = false;
            this.AD_Encode.Click += new System.EventHandler(this.AD_Encode_Click);
            // 
            // lz
            // 
            this.lz.AutoSize = true;
            this.lz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lz.ForeColor = System.Drawing.SystemColors.Control;
            this.lz.Location = new System.Drawing.Point(43, 49);
            this.lz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lz.Name = "lz";
            this.lz.Size = new System.Drawing.Size(91, 25);
            this.lz.TabIndex = 33;
            this.lz.Text = "Adaptive";
            // 
            // txtAD
            // 
            this.txtAD.BackColor = System.Drawing.Color.DimGray;
            this.txtAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAD.ForeColor = System.Drawing.Color.White;
            this.txtAD.Location = new System.Drawing.Point(47, 118);
            this.txtAD.Margin = new System.Windows.Forms.Padding(2);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(433, 35);
            this.txtAD.TabIndex = 32;
            this.txtAD.Text = "";
            this.txtAD.TextChanged += new System.EventHandler(this.txtAD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "size";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // AD_Tree
            // 
            this.AD_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.AD_Tree.FlatAppearance.BorderSize = 0;
            this.AD_Tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_Tree.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD_Tree.Location = new System.Drawing.Point(521, 126);
            this.AD_Tree.Margin = new System.Windows.Forms.Padding(2);
            this.AD_Tree.Name = "AD_Tree";
            this.AD_Tree.Size = new System.Drawing.Size(93, 35);
            this.AD_Tree.TabIndex = 37;
            this.AD_Tree.Text = "Tree";
            this.AD_Tree.UseVisualStyleBackColor = false;
            this.AD_Tree.Click += new System.EventHandler(this.AD_Tree_Click);
            // 
            // txtAD_result
            // 
            this.txtAD_result.BackColor = System.Drawing.Color.DimGray;
            this.txtAD_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAD_result.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAD_result.ForeColor = System.Drawing.Color.White;
            this.txtAD_result.Location = new System.Drawing.Point(47, 165);
            this.txtAD_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtAD_result.Name = "txtAD_result";
            this.txtAD_result.Size = new System.Drawing.Size(433, 35);
            this.txtAD_result.TabIndex = 39;
            this.txtAD_result.Text = "";
            this.txtAD_result.Visible = false;
            this.txtAD_result.TextChanged += new System.EventHandler(this.txtAD_result_TextChanged);
            // 
            // AD_Entropy
            // 
            this.AD_Entropy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.AD_Entropy.FlatAppearance.BorderSize = 0;
            this.AD_Entropy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_Entropy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD_Entropy.Location = new System.Drawing.Point(521, 165);
            this.AD_Entropy.Margin = new System.Windows.Forms.Padding(2);
            this.AD_Entropy.Name = "AD_Entropy";
            this.AD_Entropy.Size = new System.Drawing.Size(93, 35);
            this.AD_Entropy.TabIndex = 38;
            this.AD_Entropy.Text = "Entropy";
            this.AD_Entropy.UseVisualStyleBackColor = false;
            this.AD_Entropy.Click += new System.EventHandler(this.AD_Entropy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 566);
            this.panel1.TabIndex = 40;
            this.panel1.Visible = false;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(711, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 44;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AD_Decode
            // 
            this.AD_Decode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.AD_Decode.FlatAppearance.BorderSize = 0;
            this.AD_Decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_Decode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AD_Decode.Location = new System.Drawing.Point(521, 87);
            this.AD_Decode.Margin = new System.Windows.Forms.Padding(2);
            this.AD_Decode.Name = "AD_Decode";
            this.AD_Decode.Size = new System.Drawing.Size(93, 35);
            this.AD_Decode.TabIndex = 41;
            this.AD_Decode.Text = "Decode";
            this.AD_Decode.UseVisualStyleBackColor = false;
            this.AD_Decode.Click += new System.EventHandler(this.AD_Decode_Click);
            // 
            // ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(920, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AD_Tree);
            this.Controls.Add(this.txtAD_result);
            this.Controls.Add(this.AD_Entropy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ad2);
            this.Controls.Add(this.AD_Encode);
            this.Controls.Add(this.lz);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.AD_Decode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ad";
            this.Load += new System.EventHandler(this.ad_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ad2;
        private System.Windows.Forms.Button AD_Encode;
        private System.Windows.Forms.Label lz;
        private System.Windows.Forms.RichTextBox txtAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AD_Tree;
        private System.Windows.Forms.RichTextBox txtAD_result;
        private System.Windows.Forms.Button AD_Entropy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button AD_Decode;
    }
}
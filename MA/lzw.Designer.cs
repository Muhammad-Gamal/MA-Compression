namespace MA
{
    partial class lzw
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
            this.lz2 = new System.Windows.Forms.Label();
            this.lz = new System.Windows.Forms.Label();
            this.txtLZW = new System.Windows.Forms.RichTextBox();
            this.LZW_Encode = new System.Windows.Forms.Button();
            this.LZW_Decode = new System.Windows.Forms.Button();
            this.txtLZW_result = new System.Windows.Forms.RichTextBox();
            this.LZW_Entropy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lz2
            // 
            this.lz2.AutoSize = true;
            this.lz2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lz2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lz2.ForeColor = System.Drawing.Color.White;
            this.lz2.Location = new System.Drawing.Point(45, 96);
            this.lz2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lz2.Name = "lz2";
            this.lz2.Size = new System.Drawing.Size(110, 13);
            this.lz2.TabIndex = 31;
            this.lz2.Text = "Enter Your Message";
            // 
            // lz
            // 
            this.lz.AutoSize = true;
            this.lz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lz.ForeColor = System.Drawing.SystemColors.Control;
            this.lz.Location = new System.Drawing.Point(43, 49);
            this.lz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lz.Name = "lz";
            this.lz.Size = new System.Drawing.Size(172, 25);
            this.lz.TabIndex = 28;
            this.lz.Text = "Lempel-Ziv-Welch";
            // 
            // txtLZW
            // 
            this.txtLZW.BackColor = System.Drawing.Color.DimGray;
            this.txtLZW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLZW.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLZW.ForeColor = System.Drawing.Color.White;
            this.txtLZW.Location = new System.Drawing.Point(47, 118);
            this.txtLZW.Margin = new System.Windows.Forms.Padding(2);
            this.txtLZW.Name = "txtLZW";
            this.txtLZW.Size = new System.Drawing.Size(433, 35);
            this.txtLZW.TabIndex = 27;
            this.txtLZW.Text = "";
            this.txtLZW.TextChanged += new System.EventHandler(this.txtLZW_TextChanged);
            // 
            // LZW_Encode
            // 
            this.LZW_Encode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.LZW_Encode.FlatAppearance.BorderSize = 0;
            this.LZW_Encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LZW_Encode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZW_Encode.Location = new System.Drawing.Point(521, 70);
            this.LZW_Encode.Margin = new System.Windows.Forms.Padding(2);
            this.LZW_Encode.Name = "LZW_Encode";
            this.LZW_Encode.Size = new System.Drawing.Size(93, 35);
            this.LZW_Encode.TabIndex = 32;
            this.LZW_Encode.Text = "Encode";
            this.LZW_Encode.UseVisualStyleBackColor = false;
            this.LZW_Encode.Click += new System.EventHandler(this.LZW_Encode_Click);
            // 
            // LZW_Decode
            // 
            this.LZW_Decode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.LZW_Decode.FlatAppearance.BorderSize = 0;
            this.LZW_Decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LZW_Decode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZW_Decode.Location = new System.Drawing.Point(521, 118);
            this.LZW_Decode.Margin = new System.Windows.Forms.Padding(2);
            this.LZW_Decode.Name = "LZW_Decode";
            this.LZW_Decode.Size = new System.Drawing.Size(93, 35);
            this.LZW_Decode.TabIndex = 33;
            this.LZW_Decode.Text = "Decode";
            this.LZW_Decode.UseVisualStyleBackColor = false;
            this.LZW_Decode.Click += new System.EventHandler(this.LZW_Decode_Click);
            // 
            // txtLZW_result
            // 
            this.txtLZW_result.BackColor = System.Drawing.Color.DimGray;
            this.txtLZW_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLZW_result.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLZW_result.ForeColor = System.Drawing.Color.White;
            this.txtLZW_result.Location = new System.Drawing.Point(48, 166);
            this.txtLZW_result.Margin = new System.Windows.Forms.Padding(2);
            this.txtLZW_result.Name = "txtLZW_result";
            this.txtLZW_result.Size = new System.Drawing.Size(433, 35);
            this.txtLZW_result.TabIndex = 35;
            this.txtLZW_result.Text = "";
            this.txtLZW_result.Visible = false;
            // 
            // LZW_Entropy
            // 
            this.LZW_Entropy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.LZW_Entropy.FlatAppearance.BorderSize = 0;
            this.LZW_Entropy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LZW_Entropy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LZW_Entropy.Location = new System.Drawing.Point(521, 166);
            this.LZW_Entropy.Margin = new System.Windows.Forms.Padding(2);
            this.LZW_Entropy.Name = "LZW_Entropy";
            this.LZW_Entropy.Size = new System.Drawing.Size(93, 35);
            this.LZW_Entropy.TabIndex = 34;
            this.LZW_Entropy.Text = "Entropy";
            this.LZW_Entropy.UseVisualStyleBackColor = false;
            this.LZW_Entropy.Click += new System.EventHandler(this.LZW_Entropy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(455, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "size";
            // 
            // lzw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(920, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LZW_Encode);
            this.Controls.Add(this.LZW_Decode);
            this.Controls.Add(this.txtLZW_result);
            this.Controls.Add(this.LZW_Entropy);
            this.Controls.Add(this.lz2);
            this.Controls.Add(this.lz);
            this.Controls.Add(this.txtLZW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lzw";
            this.Text = "lzw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lz2;
        private System.Windows.Forms.Label lz;
        private System.Windows.Forms.RichTextBox txtLZW;
        private System.Windows.Forms.Button LZW_Encode;
        private System.Windows.Forms.Button LZW_Decode;
        private System.Windows.Forms.RichTextBox txtLZW_result;
        private System.Windows.Forms.Button LZW_Entropy;
        private System.Windows.Forms.Label label1;
    }
}
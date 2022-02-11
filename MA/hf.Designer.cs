namespace MA
{
    partial class hf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hf));
            this.hf2 = new System.Windows.Forms.Label();
            this.HF_Tree = new System.Windows.Forms.Button();
            this.hf1 = new System.Windows.Forms.Label();
            this.txtHF = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HF_Table = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.PictureBox();
            this.HF_result = new System.Windows.Forms.Button();
            this.txtHF_entropy = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // hf2
            // 
            this.hf2.AutoSize = true;
            this.hf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.hf2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hf2.ForeColor = System.Drawing.Color.White;
            this.hf2.Location = new System.Drawing.Point(45, 96);
            this.hf2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hf2.Name = "hf2";
            this.hf2.Size = new System.Drawing.Size(110, 13);
            this.hf2.TabIndex = 26;
            this.hf2.Text = "Enter Your Message";
            // 
            // HF_Tree
            // 
            this.HF_Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.HF_Tree.FlatAppearance.BorderSize = 0;
            this.HF_Tree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HF_Tree.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HF_Tree.Location = new System.Drawing.Point(520, 70);
            this.HF_Tree.Margin = new System.Windows.Forms.Padding(2);
            this.HF_Tree.Name = "HF_Tree";
            this.HF_Tree.Size = new System.Drawing.Size(93, 35);
            this.HF_Tree.TabIndex = 24;
            this.HF_Tree.Text = "Tree";
            this.HF_Tree.UseVisualStyleBackColor = false;
            this.HF_Tree.Click += new System.EventHandler(this.HF_Tree_Click);
            // 
            // hf1
            // 
            this.hf1.AutoSize = true;
            this.hf1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hf1.ForeColor = System.Drawing.SystemColors.Control;
            this.hf1.Location = new System.Drawing.Point(43, 49);
            this.hf1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hf1.Name = "hf1";
            this.hf1.Size = new System.Drawing.Size(92, 25);
            this.hf1.TabIndex = 23;
            this.hf1.Text = "Huffman";
            // 
            // txtHF
            // 
            this.txtHF.BackColor = System.Drawing.Color.DimGray;
            this.txtHF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHF.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHF.ForeColor = System.Drawing.Color.White;
            this.txtHF.Location = new System.Drawing.Point(47, 118);
            this.txtHF.Margin = new System.Windows.Forms.Padding(2);
            this.txtHF.Name = "txtHF";
            this.txtHF.Size = new System.Drawing.Size(433, 35);
            this.txtHF.TabIndex = 22;
            this.txtHF.Text = "";
            this.txtHF.TextChanged += new System.EventHandler(this.txtHF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(454, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 566);
            this.panel1.TabIndex = 27;
            this.panel1.Visible = false;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HF_Table
            // 
            this.HF_Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.HF_Table.FlatAppearance.BorderSize = 0;
            this.HF_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HF_Table.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HF_Table.Location = new System.Drawing.Point(520, 118);
            this.HF_Table.Margin = new System.Windows.Forms.Padding(2);
            this.HF_Table.Name = "HF_Table";
            this.HF_Table.Size = new System.Drawing.Size(93, 35);
            this.HF_Table.TabIndex = 28;
            this.HF_Table.Text = "Table";
            this.HF_Table.UseVisualStyleBackColor = false;
            this.HF_Table.Click += new System.EventHandler(this.HF_Table_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(728, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 29);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 44;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // HF_result
            // 
            this.HF_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(195)))), ((int)(((byte)(147)))));
            this.HF_result.FlatAppearance.BorderSize = 0;
            this.HF_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HF_result.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HF_result.Location = new System.Drawing.Point(520, 166);
            this.HF_result.Margin = new System.Windows.Forms.Padding(2);
            this.HF_result.Name = "HF_result";
            this.HF_result.Size = new System.Drawing.Size(93, 35);
            this.HF_result.TabIndex = 29;
            this.HF_result.Text = "Entropy";
            this.HF_result.UseVisualStyleBackColor = false;
            this.HF_result.Click += new System.EventHandler(this.HF_Entropy_Click);
            // 
            // txtHF_entropy
            // 
            this.txtHF_entropy.BackColor = System.Drawing.Color.DimGray;
            this.txtHF_entropy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHF_entropy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHF_entropy.ForeColor = System.Drawing.Color.White;
            this.txtHF_entropy.Location = new System.Drawing.Point(47, 166);
            this.txtHF_entropy.Margin = new System.Windows.Forms.Padding(2);
            this.txtHF_entropy.Name = "txtHF_entropy";
            this.txtHF_entropy.Size = new System.Drawing.Size(433, 35);
            this.txtHF_entropy.TabIndex = 30;
            this.txtHF_entropy.Text = "";
            this.txtHF_entropy.Visible = false;
            // 
            // hf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(920, 590);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hf2);
            this.Controls.Add(this.HF_Tree);
            this.Controls.Add(this.hf1);
            this.Controls.Add(this.txtHF);
            this.Controls.Add(this.HF_Table);
            this.Controls.Add(this.txtHF_entropy);
            this.Controls.Add(this.HF_result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hf";
            this.Load += new System.EventHandler(this.hf_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hf2;
        private System.Windows.Forms.Button HF_Tree;
        private System.Windows.Forms.Label hf1;
        private System.Windows.Forms.RichTextBox txtHF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HF_Table;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button HF_result;
        private System.Windows.Forms.RichTextBox txtHF_entropy;
    }
}
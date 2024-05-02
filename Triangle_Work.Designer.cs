namespace WinKolmNurk
{
    partial class Triangle_Work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triangle_Work));
            this.stars_btn = new System.Windows.Forms.Button();
            this.lw = new System.Windows.Forms.ListView();
            this.Parameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vaartus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A_txt = new System.Windows.Forms.TextBox();
            this.B_txt = new System.Windows.Forms.TextBox();
            this.C_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stars_btn
            // 
            this.stars_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stars_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.stars_btn.Location = new System.Drawing.Point(424, 317);
            this.stars_btn.Name = "stars_btn";
            this.stars_btn.Size = new System.Drawing.Size(159, 67);
            this.stars_btn.TabIndex = 0;
            this.stars_btn.Text = "Arvuta";
            this.stars_btn.UseVisualStyleBackColor = true;
            this.stars_btn.Click += new System.EventHandler(this.stars_btn_DoubleClick);
            // 
            // lw
            // 
            this.lw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Parameter,
            this.Vaartus});
            this.lw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)), true);
            this.lw.HideSelection = false;
            this.lw.Location = new System.Drawing.Point(268, 12);
            this.lw.MultiSelect = false;
            this.lw.Name = "lw";
            this.lw.Size = new System.Drawing.Size(284, 282);
            this.lw.TabIndex = 1;
            this.lw.UseCompatibleStateImageBehavior = false;
            this.lw.View = System.Windows.Forms.View.Details;
            // 
            // Parameter
            // 
            this.Parameter.Text = "Parameter";
            this.Parameter.Width = 150;
            // 
            // Vaartus
            // 
            this.Vaartus.Text = "Väärtus";
            this.Vaartus.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Külg A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Külg B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Külg C:";
            // 
            // A_txt
            // 
            this.A_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.A_txt.Location = new System.Drawing.Point(94, 18);
            this.A_txt.Name = "A_txt";
            this.A_txt.Size = new System.Drawing.Size(100, 26);
            this.A_txt.TabIndex = 5;
            // 
            // B_txt
            // 
            this.B_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.B_txt.Location = new System.Drawing.Point(94, 56);
            this.B_txt.Name = "B_txt";
            this.B_txt.Size = new System.Drawing.Size(100, 26);
            this.B_txt.TabIndex = 6;
            // 
            // C_txt
            // 
            this.C_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.C_txt.Location = new System.Drawing.Point(94, 98);
            this.C_txt.Name = "C_txt";
            this.C_txt.Size = new System.Drawing.Size(100, 26);
            this.C_txt.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 165);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(150, 150);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(150, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Triangle_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(594, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.C_txt);
            this.Controls.Add(this.B_txt);
            this.Controls.Add(this.A_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lw);
            this.Controls.Add(this.stars_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Triangle_Work";
            this.Text = "Triangle ";
            this.Load += new System.EventHandler(this.Triangle_Work_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stars_btn;
        private System.Windows.Forms.ListView lw;
        private System.Windows.Forms.ColumnHeader Parameter;
        private System.Windows.Forms.ColumnHeader Vaartus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox A_txt;
        private System.Windows.Forms.TextBox B_txt;
        private System.Windows.Forms.TextBox C_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


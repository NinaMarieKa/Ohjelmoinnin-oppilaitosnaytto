namespace OhjelmoinninProto
{
    partial class Etusivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etusivu));
            this.LBTervetuloa = new System.Windows.Forms.Label();
            this.LBEtusivuOhje = new System.Windows.Forms.Label();
            this.PNEtusivu = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LBKirjaudu = new System.Windows.Forms.ToolStripLabel();
            this.SLBRekisteroidy = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNEtusivu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBTervetuloa
            // 
            this.LBTervetuloa.AutoSize = true;
            this.LBTervetuloa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTervetuloa.Location = new System.Drawing.Point(268, 38);
            this.LBTervetuloa.Name = "LBTervetuloa";
            this.LBTervetuloa.Size = new System.Drawing.Size(161, 33);
            this.LBTervetuloa.TabIndex = 0;
            this.LBTervetuloa.Text = "Tervetuloa!";
            // 
            // LBEtusivuOhje
            // 
            this.LBEtusivuOhje.AutoSize = true;
            this.LBEtusivuOhje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEtusivuOhje.Location = new System.Drawing.Point(109, 81);
            this.LBEtusivuOhje.Name = "LBEtusivuOhje";
            this.LBEtusivuOhje.Size = new System.Drawing.Size(479, 25);
            this.LBEtusivuOhje.TabIndex = 1;
            this.LBEtusivuOhje.Text = "Valitse haluamasi toiminto yllä olevasta valikosta";
            // 
            // PNEtusivu
            // 
            this.PNEtusivu.BackColor = System.Drawing.Color.RosyBrown;
            this.PNEtusivu.Controls.Add(this.toolStrip1);
            this.PNEtusivu.Controls.Add(this.LBTervetuloa);
            this.PNEtusivu.Controls.Add(this.LBEtusivuOhje);
            this.PNEtusivu.Location = new System.Drawing.Point(2, 1);
            this.PNEtusivu.Name = "PNEtusivu";
            this.PNEtusivu.Size = new System.Drawing.Size(776, 125);
            this.PNEtusivu.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBKirjaudu,
            this.SLBRekisteroidy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LBKirjaudu
            // 
            this.LBKirjaudu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBKirjaudu.Name = "LBKirjaudu";
            this.LBKirjaudu.Size = new System.Drawing.Size(114, 22);
            this.LBKirjaudu.Text = "KIRJAUDU SISÄÄN";
            this.LBKirjaudu.Click += new System.EventHandler(this.LBKirjaudu_Click);
            // 
            // SLBRekisteroidy
            // 
            this.SLBRekisteroidy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLBRekisteroidy.Name = "SLBRekisteroidy";
            this.SLBRekisteroidy.Size = new System.Drawing.Size(92, 22);
            this.SLBRekisteroidy.Text = "REKISTERÖIDY";
            this.SLBRekisteroidy.Click += new System.EventHandler(this.SLBRekisteroidy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(777, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PNEtusivu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Etusivu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etusivu";
            this.PNEtusivu.ResumeLayout(false);
            this.PNEtusivu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBTervetuloa;
        private System.Windows.Forms.Label LBEtusivuOhje;
        private System.Windows.Forms.Panel PNEtusivu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LBKirjaudu;
        private System.Windows.Forms.ToolStripLabel SLBRekisteroidy;
    }
}


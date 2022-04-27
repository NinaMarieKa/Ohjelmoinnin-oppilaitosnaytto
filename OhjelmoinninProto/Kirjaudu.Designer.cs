namespace OhjelmoinninProto
{
    partial class Kirjaudu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kirjaudu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNEtusivu = new System.Windows.Forms.Panel();
            this.LBTervetuloa = new System.Windows.Forms.Label();
            this.LBEtusivuOhje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNKirjaudu = new System.Windows.Forms.Button();
            this.TBKirjauduSalasana = new System.Windows.Forms.TextBox();
            this.TBKirjauduTunnus = new System.Windows.Forms.TextBox();
            this.LBKirjauduSalasana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PNEtusivu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PNEtusivu
            // 
            this.PNEtusivu.BackColor = System.Drawing.Color.RosyBrown;
            this.PNEtusivu.Controls.Add(this.LBTervetuloa);
            this.PNEtusivu.Controls.Add(this.LBEtusivuOhje);
            this.PNEtusivu.Location = new System.Drawing.Point(-2, -3);
            this.PNEtusivu.Name = "PNEtusivu";
            this.PNEtusivu.Size = new System.Drawing.Size(787, 129);
            this.PNEtusivu.TabIndex = 5;
            // 
            // LBTervetuloa
            // 
            this.LBTervetuloa.AutoSize = true;
            this.LBTervetuloa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTervetuloa.Location = new System.Drawing.Point(280, 23);
            this.LBTervetuloa.Name = "LBTervetuloa";
            this.LBTervetuloa.Size = new System.Drawing.Size(215, 33);
            this.LBTervetuloa.TabIndex = 0;
            this.LBTervetuloa.Text = "Kirjaudu sisään";
            // 
            // LBEtusivuOhje
            // 
            this.LBEtusivuOhje.AutoSize = true;
            this.LBEtusivuOhje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEtusivuOhje.Location = new System.Drawing.Point(182, 77);
            this.LBEtusivuOhje.Name = "LBEtusivuOhje";
            this.LBEtusivuOhje.Size = new System.Drawing.Size(400, 25);
            this.LBEtusivuOhje.TabIndex = 1;
            this.LBEtusivuOhje.Text = "Kirjaudu sisään alla olevalla lomakkeella";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.BTNKirjaudu);
            this.panel1.Controls.Add(this.TBKirjauduSalasana);
            this.panel1.Controls.Add(this.TBKirjauduTunnus);
            this.panel1.Controls.Add(this.LBKirjauduSalasana);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(185, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 196);
            this.panel1.TabIndex = 7;
            // 
            // BTNKirjaudu
            // 
            this.BTNKirjaudu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNKirjaudu.Location = new System.Drawing.Point(182, 147);
            this.BTNKirjaudu.Name = "BTNKirjaudu";
            this.BTNKirjaudu.Size = new System.Drawing.Size(158, 31);
            this.BTNKirjaudu.TabIndex = 10;
            this.BTNKirjaudu.Text = "KIRJAUDU";
            this.BTNKirjaudu.UseVisualStyleBackColor = true;
            this.BTNKirjaudu.Click += new System.EventHandler(this.BTNKirjaudu_Click);
            // 
            // TBKirjauduSalasana
            // 
            this.TBKirjauduSalasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKirjauduSalasana.Location = new System.Drawing.Point(182, 98);
            this.TBKirjauduSalasana.Name = "TBKirjauduSalasana";
            this.TBKirjauduSalasana.Size = new System.Drawing.Size(158, 29);
            this.TBKirjauduSalasana.TabIndex = 9;
            this.TBKirjauduSalasana.UseSystemPasswordChar = true;
            // 
            // TBKirjauduTunnus
            // 
            this.TBKirjauduTunnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBKirjauduTunnus.Location = new System.Drawing.Point(182, 41);
            this.TBKirjauduTunnus.Name = "TBKirjauduTunnus";
            this.TBKirjauduTunnus.Size = new System.Drawing.Size(158, 29);
            this.TBKirjauduTunnus.TabIndex = 8;
            // 
            // LBKirjauduSalasana
            // 
            this.LBKirjauduSalasana.AutoSize = true;
            this.LBKirjauduSalasana.BackColor = System.Drawing.Color.Transparent;
            this.LBKirjauduSalasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBKirjauduSalasana.Location = new System.Drawing.Point(23, 101);
            this.LBKirjauduSalasana.Name = "LBKirjauduSalasana";
            this.LBKirjauduSalasana.Size = new System.Drawing.Size(91, 24);
            this.LBKirjauduSalasana.TabIndex = 7;
            this.LBKirjauduSalasana.Text = "Salasana:";
            // 
            // Kirjaudu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PNEtusivu);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kirjaudu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kirjaudu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PNEtusivu.ResumeLayout(false);
            this.PNEtusivu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PNEtusivu;
        private System.Windows.Forms.Label LBTervetuloa;
        private System.Windows.Forms.Label LBEtusivuOhje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNKirjaudu;
        private System.Windows.Forms.TextBox TBKirjauduSalasana;
        private System.Windows.Forms.TextBox TBKirjauduTunnus;
        private System.Windows.Forms.Label LBKirjauduSalasana;
    }
}
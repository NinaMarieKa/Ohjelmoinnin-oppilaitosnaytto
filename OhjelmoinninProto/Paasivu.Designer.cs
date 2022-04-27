namespace OhjelmoinninProto
{
    partial class Paasivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paasivu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNEtusivu = new System.Windows.Forms.Panel();
            this.LBTervetuloa = new System.Windows.Forms.Label();
            this.LBEtusivuOhje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBKurssi = new System.Windows.Forms.Label();
            this.CBOhtu = new System.Windows.Forms.CheckBox();
            this.CBTuotanto = new System.Windows.Forms.CheckBox();
            this.CBKehto = new System.Windows.Forms.CheckBox();
            this.LBTentti = new System.Windows.Forms.Label();
            this.RBEka = new System.Windows.Forms.RadioButton();
            this.RBToka = new System.Windows.Forms.RadioButton();
            this.RBKolmas = new System.Windows.Forms.RadioButton();
            this.CBKieli = new System.Windows.Forms.ComboBox();
            this.LBKieli = new System.Windows.Forms.Label();
            this.TBViesti = new System.Windows.Forms.TextBox();
            this.LBViesti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PNEtusivu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PNEtusivu
            // 
            this.PNEtusivu.BackColor = System.Drawing.Color.RosyBrown;
            this.PNEtusivu.Controls.Add(this.panel1);
            this.PNEtusivu.Controls.Add(this.pictureBox1);
            this.PNEtusivu.Controls.Add(this.LBTervetuloa);
            this.PNEtusivu.Controls.Add(this.LBEtusivuOhje);
            this.PNEtusivu.Location = new System.Drawing.Point(2, 0);
            this.PNEtusivu.Name = "PNEtusivu";
            this.PNEtusivu.Size = new System.Drawing.Size(793, 640);
            this.PNEtusivu.TabIndex = 4;
            // 
            // LBTervetuloa
            // 
            this.LBTervetuloa.AutoSize = true;
            this.LBTervetuloa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTervetuloa.Location = new System.Drawing.Point(224, 19);
            this.LBTervetuloa.Name = "LBTervetuloa";
            this.LBTervetuloa.Size = new System.Drawing.Size(300, 33);
            this.LBTervetuloa.TabIndex = 0;
            this.LBTervetuloa.Text = "Tervetuloa pääsivulle!";
            // 
            // LBEtusivuOhje
            // 
            this.LBEtusivuOhje.AutoSize = true;
            this.LBEtusivuOhje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBEtusivuOhje.Location = new System.Drawing.Point(249, 64);
            this.LBEtusivuOhje.Name = "LBEtusivuOhje";
            this.LBEtusivuOhje.Size = new System.Drawing.Size(239, 25);
            this.LBEtusivuOhje.TabIndex = 1;
            this.LBEtusivuOhje.Text = "Täytä alla oleva lomake";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBViesti);
            this.panel1.Controls.Add(this.TBViesti);
            this.panel1.Controls.Add(this.LBKieli);
            this.panel1.Controls.Add(this.CBKieli);
            this.panel1.Controls.Add(this.RBKolmas);
            this.panel1.Controls.Add(this.RBToka);
            this.panel1.Controls.Add(this.RBEka);
            this.panel1.Controls.Add(this.LBTentti);
            this.panel1.Controls.Add(this.CBKehto);
            this.panel1.Controls.Add(this.CBTuotanto);
            this.panel1.Controls.Add(this.CBOhtu);
            this.panel1.Controls.Add(this.LBKurssi);
            this.panel1.Location = new System.Drawing.Point(132, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 377);
            this.panel1.TabIndex = 6;
            // 
            // LBKurssi
            // 
            this.LBKurssi.AutoSize = true;
            this.LBKurssi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBKurssi.Location = new System.Drawing.Point(18, 22);
            this.LBKurssi.Name = "LBKurssi";
            this.LBKurssi.Size = new System.Drawing.Size(221, 24);
            this.LBKurssi.TabIndex = 0;
            this.LBKurssi.Text = "Valitse suoritettava kurssi:";
            // 
            // CBOhtu
            // 
            this.CBOhtu.AutoSize = true;
            this.CBOhtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBOhtu.Location = new System.Drawing.Point(22, 53);
            this.CBOhtu.Name = "CBOhtu";
            this.CBOhtu.Size = new System.Drawing.Size(192, 24);
            this.CBOhtu.TabIndex = 1;
            this.CBOhtu.Text = "Ohjelmiston prototyyppi";
            this.CBOhtu.UseVisualStyleBackColor = true;
            // 
            // CBTuotanto
            // 
            this.CBTuotanto.AutoSize = true;
            this.CBTuotanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTuotanto.Location = new System.Drawing.Point(22, 76);
            this.CBTuotanto.Name = "CBTuotanto";
            this.CBTuotanto.Size = new System.Drawing.Size(216, 24);
            this.CBTuotanto.TabIndex = 2;
            this.CBTuotanto.Text = "Ohjelmiston tuotantoversio";
            this.CBTuotanto.UseVisualStyleBackColor = true;
            // 
            // CBKehto
            // 
            this.CBKehto.AutoSize = true;
            this.CBKehto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBKehto.Location = new System.Drawing.Point(22, 97);
            this.CBKehto.Name = "CBKehto";
            this.CBKehto.Size = new System.Drawing.Size(203, 24);
            this.CBKehto.TabIndex = 3;
            this.CBKehto.Text = "Kehitysympäristön käyttö";
            this.CBKehto.UseVisualStyleBackColor = true;
            // 
            // LBTentti
            // 
            this.LBTentti.AutoSize = true;
            this.LBTentti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTentti.Location = new System.Drawing.Point(18, 137);
            this.LBTentti.Name = "LBTentti";
            this.LBTentti.Size = new System.Drawing.Size(157, 24);
            this.LBTentti.TabIndex = 4;
            this.LBTentti.Text = "Valitse tenttipäivä:";
            // 
            // RBEka
            // 
            this.RBEka.AutoSize = true;
            this.RBEka.Location = new System.Drawing.Point(22, 164);
            this.RBEka.Name = "RBEka";
            this.RBEka.Size = new System.Drawing.Size(79, 17);
            this.RBEka.TabIndex = 5;
            this.RBEka.TabStop = true;
            this.RBEka.Text = "26.04.2022";
            this.RBEka.UseVisualStyleBackColor = true;
            // 
            // RBToka
            // 
            this.RBToka.AutoSize = true;
            this.RBToka.Location = new System.Drawing.Point(22, 187);
            this.RBToka.Name = "RBToka";
            this.RBToka.Size = new System.Drawing.Size(79, 17);
            this.RBToka.TabIndex = 6;
            this.RBToka.TabStop = true;
            this.RBToka.Text = "26.08.2022";
            this.RBToka.UseVisualStyleBackColor = true;
            // 
            // RBKolmas
            // 
            this.RBKolmas.AutoSize = true;
            this.RBKolmas.Location = new System.Drawing.Point(22, 210);
            this.RBKolmas.Name = "RBKolmas";
            this.RBKolmas.Size = new System.Drawing.Size(79, 17);
            this.RBKolmas.TabIndex = 7;
            this.RBKolmas.TabStop = true;
            this.RBKolmas.Text = "18.12.2022";
            this.RBKolmas.UseVisualStyleBackColor = true;
            // 
            // CBKieli
            // 
            this.CBKieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBKieli.FormattingEnabled = true;
            this.CBKieli.Items.AddRange(new object[] {
            "JavaScript",
            "C#"});
            this.CBKieli.Location = new System.Drawing.Point(22, 288);
            this.CBKieli.Name = "CBKieli";
            this.CBKieli.Size = new System.Drawing.Size(153, 28);
            this.CBKieli.TabIndex = 8;
            this.CBKieli.Text = "valitse tästä";
            // 
            // LBKieli
            // 
            this.LBKieli.AutoSize = true;
            this.LBKieli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBKieli.Location = new System.Drawing.Point(18, 248);
            this.LBKieli.Name = "LBKieli";
            this.LBKieli.Size = new System.Drawing.Size(198, 24);
            this.LBKieli.TabIndex = 9;
            this.LBKieli.Text = "Valitse ohjelmointikieli:";
            // 
            // TBViesti
            // 
            this.TBViesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBViesti.Location = new System.Drawing.Point(276, 100);
            this.TBViesti.Multiline = true;
            this.TBViesti.Name = "TBViesti";
            this.TBViesti.Size = new System.Drawing.Size(216, 216);
            this.TBViesti.TabIndex = 10;
            // 
            // LBViesti
            // 
            this.LBViesti.AutoSize = true;
            this.LBViesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBViesti.Location = new System.Drawing.Point(272, 53);
            this.LBViesti.Name = "LBViesti";
            this.LBViesti.Size = new System.Drawing.Size(239, 24);
            this.LBViesti.TabIndex = 11;
            this.LBViesti.Text = "Jätä vapaamuotoinen viesti:";
            // 
            // Paasivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 601);
            this.Controls.Add(this.PNEtusivu);
            this.Name = "Paasivu";
            this.Text = "Pääsivu";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBKieli;
        private System.Windows.Forms.RadioButton RBKolmas;
        private System.Windows.Forms.RadioButton RBToka;
        private System.Windows.Forms.RadioButton RBEka;
        private System.Windows.Forms.Label LBTentti;
        private System.Windows.Forms.CheckBox CBKehto;
        private System.Windows.Forms.CheckBox CBTuotanto;
        private System.Windows.Forms.CheckBox CBOhtu;
        private System.Windows.Forms.Label LBKurssi;
        private System.Windows.Forms.Label LBKieli;
        private System.Windows.Forms.Label LBViesti;
        private System.Windows.Forms.TextBox TBViesti;
    }
}
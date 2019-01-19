namespace JIPP5ZaliczenieMG
{
    partial class EdycjaFiszek
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPytanie = new System.Windows.Forms.TextBox();
            this.btDodajPytanie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOdpowiedz = new System.Windows.Forms.TextBox();
            this.btDodajOdpowiedz = new System.Windows.Forms.Button();
            this.btPolecenie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPytanieZrodlo = new System.Windows.Forms.TextBox();
            this.tbOdpowiedzZrodlo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pytanie";
            // 
            // tbPytanie
            // 
            this.tbPytanie.Location = new System.Drawing.Point(90, 29);
            this.tbPytanie.Multiline = true;
            this.tbPytanie.Name = "tbPytanie";
            this.tbPytanie.Size = new System.Drawing.Size(235, 61);
            this.tbPytanie.TabIndex = 1;
            // 
            // btDodajPytanie
            // 
            this.btDodajPytanie.Location = new System.Drawing.Point(90, 117);
            this.btDodajPytanie.Name = "btDodajPytanie";
            this.btDodajPytanie.Size = new System.Drawing.Size(235, 23);
            this.btDodajPytanie.TabIndex = 2;
            this.btDodajPytanie.Text = "Dodaj plik pytanie";
            this.btDodajPytanie.UseVisualStyleBackColor = true;
            this.btDodajPytanie.Click += new System.EventHandler(this.btDodajPytanie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odpowiedź";
            // 
            // tbOdpowiedz
            // 
            this.tbOdpowiedz.Location = new System.Drawing.Point(514, 26);
            this.tbOdpowiedz.Multiline = true;
            this.tbOdpowiedz.Name = "tbOdpowiedz";
            this.tbOdpowiedz.Size = new System.Drawing.Size(232, 64);
            this.tbOdpowiedz.TabIndex = 4;
            // 
            // btDodajOdpowiedz
            // 
            this.btDodajOdpowiedz.Location = new System.Drawing.Point(514, 116);
            this.btDodajOdpowiedz.Name = "btDodajOdpowiedz";
            this.btDodajOdpowiedz.Size = new System.Drawing.Size(232, 23);
            this.btDodajOdpowiedz.TabIndex = 5;
            this.btDodajOdpowiedz.Text = "Dodaj plik odpowiedź";
            this.btDodajOdpowiedz.UseVisualStyleBackColor = true;
            this.btDodajOdpowiedz.Click += new System.EventHandler(this.btDodajOdpowiedz_Click);
            // 
            // btPolecenie
            // 
            this.btPolecenie.Location = new System.Drawing.Point(350, 396);
            this.btPolecenie.Name = "btPolecenie";
            this.btPolecenie.Size = new System.Drawing.Size(75, 23);
            this.btPolecenie.TabIndex = 6;
            this.btPolecenie.Text = "Zatwierdź";
            this.btPolecenie.UseVisualStyleBackColor = true;
            this.btPolecenie.Click += new System.EventHandler(this.btPolecenie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Źródło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Źródło";
            // 
            // tbPytanieZrodlo
            // 
            this.tbPytanieZrodlo.Location = new System.Drawing.Point(91, 171);
            this.tbPytanieZrodlo.Name = "tbPytanieZrodlo";
            this.tbPytanieZrodlo.Size = new System.Drawing.Size(234, 20);
            this.tbPytanieZrodlo.TabIndex = 9;
            // 
            // tbOdpowiedzZrodlo
            // 
            this.tbOdpowiedzZrodlo.Location = new System.Drawing.Point(514, 172);
            this.tbOdpowiedzZrodlo.Name = "tbOdpowiedzZrodlo";
            this.tbOdpowiedzZrodlo.Size = new System.Drawing.Size(232, 20);
            this.tbOdpowiedzZrodlo.TabIndex = 10;
            // 
            // EdycjaFiszek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbOdpowiedzZrodlo);
            this.Controls.Add(this.tbPytanieZrodlo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btPolecenie);
            this.Controls.Add(this.btDodajOdpowiedz);
            this.Controls.Add(this.tbOdpowiedz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDodajPytanie);
            this.Controls.Add(this.tbPytanie);
            this.Controls.Add(this.label1);
            this.Name = "EdycjaFiszek";
            this.Text = "EdycjaFiszek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPytanie;
        private System.Windows.Forms.Button btDodajPytanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOdpowiedz;
        private System.Windows.Forms.Button btDodajOdpowiedz;
        private System.Windows.Forms.Button btPolecenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPytanieZrodlo;
        private System.Windows.Forms.TextBox tbOdpowiedzZrodlo;
    }
}
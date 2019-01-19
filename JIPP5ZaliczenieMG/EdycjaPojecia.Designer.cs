namespace JIPP5ZaliczenieMG
{
    partial class EdycjaPojecia
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
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // tbNazwa
            // 
            this.tbNazwa.Location = new System.Drawing.Point(78, 35);
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa.TabIndex = 1;
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(78, 101);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(100, 20);
            this.tbTag.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tag";
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(78, 181);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 4;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            // 
            // EdycjaPojecia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 252);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbNazwa);
            this.Controls.Add(this.label1);
            this.Name = "EdycjaPojecia";
            this.Text = "DodajPojecie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDodaj;
    }
}
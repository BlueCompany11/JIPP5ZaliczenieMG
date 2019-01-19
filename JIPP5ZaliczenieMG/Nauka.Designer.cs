namespace JIPP5ZaliczenieMG
{
    partial class Nauka
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.btPokazOdpowiedz = new System.Windows.Forms.Button();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(794, 180);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Treść pytania";
            // 
            // btPokazOdpowiedz
            // 
            this.btPokazOdpowiedz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPokazOdpowiedz.Location = new System.Drawing.Point(3, 183);
            this.btPokazOdpowiedz.Name = "btPokazOdpowiedz";
            this.btPokazOdpowiedz.Size = new System.Drawing.Size(794, 39);
            this.btPokazOdpowiedz.TabIndex = 1;
            this.btPokazOdpowiedz.Text = "Pokaż odpowiedź";
            this.btPokazOdpowiedz.UseVisualStyleBackColor = true;
            this.btPokazOdpowiedz.Click += new System.EventHandler(this.btPokazOdpowiedz_Click);
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOdpowiedz.Location = new System.Drawing.Point(3, 225);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(794, 180);
            this.labelOdpowiedz.TabIndex = 3;
            this.labelOdpowiedz.Text = "Treść odpowiedzi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelQuestion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelOdpowiedz, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btPokazOdpowiedz, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btNext, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btNext
            // 
            this.btNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btNext.Location = new System.Drawing.Point(3, 408);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(794, 39);
            this.btNext.TabIndex = 4;
            this.btNext.Text = "Dalej";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Nauka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Nauka";
            this.Text = "Nauka";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button btPokazOdpowiedz;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btNext;
    }
}
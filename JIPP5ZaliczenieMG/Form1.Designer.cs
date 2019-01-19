namespace JIPP5ZaliczenieMG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEdytujPojecie = new System.Windows.Forms.Button();
            this.btUsunPojecie = new System.Windows.Forms.Button();
            this.btDodajPojecie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btEdytujFiszke = new System.Windows.Forms.Button();
            this.btUsunFiszke = new System.Windows.Forms.Button();
            this.btDodajFiszke = new System.Windows.Forms.Button();
            this.dataGridViewFiszki = new System.Windows.Forms.DataGridView();
            this.dataGridViewPojecia = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pojeciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btNauka = new System.Windows.Forms.Button();
            this.pojeciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiszki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPojecia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojeciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojeciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewFiszki, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPojecia, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btNauka, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 547);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEdytujPojecie);
            this.panel1.Controls.Add(this.btUsunPojecie);
            this.panel1.Controls.Add(this.btDodajPojecie);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 203);
            this.panel1.TabIndex = 7;
            // 
            // btEdytujPojecie
            // 
            this.btEdytujPojecie.Location = new System.Drawing.Point(3, 61);
            this.btEdytujPojecie.Name = "btEdytujPojecie";
            this.btEdytujPojecie.Size = new System.Drawing.Size(92, 23);
            this.btEdytujPojecie.TabIndex = 3;
            this.btEdytujPojecie.Text = "Edytuj pojęcie";
            this.btEdytujPojecie.UseVisualStyleBackColor = true;
            this.btEdytujPojecie.Click += new System.EventHandler(this.btEdytujPojecie_Click);
            // 
            // btUsunPojecie
            // 
            this.btUsunPojecie.Location = new System.Drawing.Point(3, 32);
            this.btUsunPojecie.Name = "btUsunPojecie";
            this.btUsunPojecie.Size = new System.Drawing.Size(92, 23);
            this.btUsunPojecie.TabIndex = 2;
            this.btUsunPojecie.Text = "Usuń pojęcie";
            this.btUsunPojecie.UseVisualStyleBackColor = true;
            this.btUsunPojecie.Click += new System.EventHandler(this.btUsunPojecie_Click);
            // 
            // btDodajPojecie
            // 
            this.btDodajPojecie.Location = new System.Drawing.Point(3, 3);
            this.btDodajPojecie.Name = "btDodajPojecie";
            this.btDodajPojecie.Size = new System.Drawing.Size(92, 23);
            this.btDodajPojecie.TabIndex = 0;
            this.btDodajPojecie.Text = "Dodaj pojęcie";
            this.btDodajPojecie.UseVisualStyleBackColor = true;
            this.btDodajPojecie.Click += new System.EventHandler(this.btDodajPojecie_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btEdytujFiszke);
            this.panel2.Controls.Add(this.btUsunFiszke);
            this.panel2.Controls.Add(this.btDodajFiszke);
            this.panel2.Location = new System.Drawing.Point(499, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 203);
            this.panel2.TabIndex = 8;
            // 
            // btEdytujFiszke
            // 
            this.btEdytujFiszke.Location = new System.Drawing.Point(-1, 61);
            this.btEdytujFiszke.Name = "btEdytujFiszke";
            this.btEdytujFiszke.Size = new System.Drawing.Size(94, 23);
            this.btEdytujFiszke.TabIndex = 2;
            this.btEdytujFiszke.Text = "Edytuj fiszkę";
            this.btEdytujFiszke.UseVisualStyleBackColor = true;
            this.btEdytujFiszke.Click += new System.EventHandler(this.btEdytujFiszke_Click);
            // 
            // btUsunFiszke
            // 
            this.btUsunFiszke.Location = new System.Drawing.Point(0, 32);
            this.btUsunFiszke.Name = "btUsunFiszke";
            this.btUsunFiszke.Size = new System.Drawing.Size(93, 23);
            this.btUsunFiszke.TabIndex = 1;
            this.btUsunFiszke.Text = "Usuń fiszke";
            this.btUsunFiszke.UseVisualStyleBackColor = true;
            this.btUsunFiszke.Click += new System.EventHandler(this.btUsunFiszke_Click);
            // 
            // btDodajFiszke
            // 
            this.btDodajFiszke.Location = new System.Drawing.Point(0, 3);
            this.btDodajFiszke.Name = "btDodajFiszke";
            this.btDodajFiszke.Size = new System.Drawing.Size(94, 23);
            this.btDodajFiszke.TabIndex = 0;
            this.btDodajFiszke.Text = "Dodaj fiszkę";
            this.btDodajFiszke.UseVisualStyleBackColor = true;
            this.btDodajFiszke.Click += new System.EventHandler(this.btDodajFiszke_Click);
            // 
            // dataGridViewFiszki
            // 
            this.dataGridViewFiszki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiszki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiszki.Location = new System.Drawing.Point(598, 3);
            this.dataGridViewFiszki.Name = "dataGridViewFiszki";
            this.dataGridViewFiszki.Size = new System.Drawing.Size(591, 458);
            this.dataGridViewFiszki.TabIndex = 9;
            // 
            // dataGridViewPojecia
            // 
            this.dataGridViewPojecia.AutoGenerateColumns = false;
            this.dataGridViewPojecia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPojecia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn});
            this.dataGridViewPojecia.DataSource = this.pojeciaBindingSource1;
            this.dataGridViewPojecia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPojecia.Location = new System.Drawing.Point(102, 3);
            this.dataGridViewPojecia.Name = "dataGridViewPojecia";
            this.dataGridViewPojecia.ReadOnly = true;
            this.dataGridViewPojecia.Size = new System.Drawing.Size(391, 458);
            this.dataGridViewPojecia.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pojeciaBindingSource1
            // 
            this.pojeciaBindingSource1.DataSource = typeof(JIPP5ZaliczenieMG.Pojecia);
            // 
            // btNauka
            // 
            this.btNauka.Location = new System.Drawing.Point(102, 467);
            this.btNauka.Name = "btNauka";
            this.btNauka.Size = new System.Drawing.Size(391, 66);
            this.btNauka.TabIndex = 10;
            this.btNauka.Text = "Ucz się";
            this.btNauka.UseVisualStyleBackColor = true;
            this.btNauka.Click += new System.EventHandler(this.btNauka_Click);
            // 
            // pojeciaBindingSource
            // 
            this.pojeciaBindingSource.DataSource = typeof(JIPP5ZaliczenieMG.Pojecia);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 547);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiszki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPojecia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojeciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojeciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btDodajPojecie;
        private System.Windows.Forms.Button btUsunPojecie;
        private System.Windows.Forms.DataGridView dataGridViewPojecia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEdytujPojecie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btEdytujFiszke;
        private System.Windows.Forms.Button btUsunFiszke;
        private System.Windows.Forms.Button btDodajFiszke;
        private System.Windows.Forms.DataGridView dataGridViewFiszki;
        private System.Windows.Forms.BindingSource pojeciaBindingSource;
        private System.Windows.Forms.BindingSource pojeciaBindingSource1;
        private System.Windows.Forms.Button btNauka;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
    }
}


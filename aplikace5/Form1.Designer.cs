namespace Aplikace5
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.NazevSouboru = new System.Windows.Forms.TextBox();
            this.Seznam = new System.Windows.Forms.DataGridView();
            this.Cesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velikost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosledniZmena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PocetRadku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxVelikost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPocetRadku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZmenaTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.Kontrola = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.NastavInterval = new System.Windows.Forms.Button();
            this.PosDatKont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Seznam)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(429, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vybrat soubor(y)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NazevSouboru
            // 
            this.NazevSouboru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazevSouboru.Location = new System.Drawing.Point(23, 26);
            this.NazevSouboru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NazevSouboru.Name = "NazevSouboru";
            this.NazevSouboru.ReadOnly = true;
            this.NazevSouboru.Size = new System.Drawing.Size(1085, 20);
            this.NazevSouboru.TabIndex = 2;
            // 
            // Seznam
            // 
            this.Seznam.AllowUserToAddRows = false;
            this.Seznam.AllowUserToDeleteRows = false;
            this.Seznam.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Seznam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Seznam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cesta,
            this.Nazev,
            this.Velikost,
            this.PosledniZmena,
            this.PocetRadku,
            this.MaxVelikost,
            this.MaxPocetRadku,
            this.ZmenaTest});
            this.Seznam.Location = new System.Drawing.Point(23, 98);
            this.Seznam.Name = "Seznam";
            this.Seznam.RowHeadersVisible = false;
            this.Seznam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Seznam.Size = new System.Drawing.Size(1085, 272);
            this.Seznam.TabIndex = 3;
            this.Seznam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seznam_CellContentClick);
            this.Seznam.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seznam_CellValueChanged);
            // 
            // Cesta
            // 
            this.Cesta.HeaderText = "Cesta";
            this.Cesta.Name = "Cesta";
            this.Cesta.ReadOnly = true;
            this.Cesta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cesta.Width = 300;
            // 
            // Nazev
            // 
            this.Nazev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nazev.HeaderText = "Název";
            this.Nazev.Name = "Nazev";
            this.Nazev.ReadOnly = true;
            this.Nazev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Velikost
            // 
            this.Velikost.HeaderText = "Velikost [MB]";
            this.Velikost.Name = "Velikost";
            this.Velikost.ReadOnly = true;
            this.Velikost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PosledniZmena
            // 
            this.PosledniZmena.HeaderText = "Poslední změna";
            this.PosledniZmena.Name = "PosledniZmena";
            this.PosledniZmena.ReadOnly = true;
            this.PosledniZmena.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PosledniZmena.Width = 120;
            // 
            // PocetRadku
            // 
            this.PocetRadku.HeaderText = "Počet řádků";
            this.PocetRadku.Name = "PocetRadku";
            this.PocetRadku.ReadOnly = true;
            this.PocetRadku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaxVelikost
            // 
            this.MaxVelikost.HeaderText = "Maximální velikost";
            this.MaxVelikost.Name = "MaxVelikost";
            this.MaxVelikost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaxPocetRadku
            // 
            this.MaxPocetRadku.HeaderText = "Maximální počet řádků";
            this.MaxPocetRadku.Name = "MaxPocetRadku";
            this.MaxPocetRadku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ZmenaTest
            // 
            this.ZmenaTest.HeaderText = "";
            this.ZmenaTest.Name = "ZmenaTest";
            this.ZmenaTest.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ZmenaTest.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ZmenaTest.Width = 80;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(574, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Vybrat adreář(e)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kontrola
            // 
            this.Kontrola.Location = new System.Drawing.Point(319, 392);
            this.Kontrola.Name = "Kontrola";
            this.Kontrola.Size = new System.Drawing.Size(138, 22);
            this.Kontrola.TabIndex = 5;
            this.Kontrola.Text = "Kontrola";
            this.Kontrola.UseVisualStyleBackColor = true;
            this.Kontrola.Click += new System.EventHandler(this.Kontrola_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(23, 438);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(1085, 124);
            this.Log.TabIndex = 6;
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntervalTextBox.Location = new System.Drawing.Point(570, 392);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(74, 20);
            this.IntervalTextBox.TabIndex = 7;
            // 
            // NastavInterval
            // 
            this.NastavInterval.Location = new System.Drawing.Point(665, 391);
            this.NastavInterval.Name = "NastavInterval";
            this.NastavInterval.Size = new System.Drawing.Size(111, 20);
            this.NastavInterval.TabIndex = 8;
            this.NastavInterval.Text = "Nastav interval";
            this.NastavInterval.UseVisualStyleBackColor = true;
            this.NastavInterval.Click += new System.EventHandler(this.NastavInterval_Click);
            // 
            // PosDatKont
            // 
            this.PosDatKont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosDatKont.Location = new System.Drawing.Point(930, 391);
            this.PosDatKont.Name = "PosDatKont";
            this.PosDatKont.Size = new System.Drawing.Size(114, 20);
            this.PosDatKont.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 574);
            this.Controls.Add(this.PosDatKont);
            this.Controls.Add(this.NastavInterval);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Kontrola);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Seznam);
            this.Controls.Add(this.NazevSouboru);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Seznam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NazevSouboru;
        private System.Windows.Forms.DataGridView Seznam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Kontrola;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Button NastavInterval;
        private System.Windows.Forms.TextBox PosDatKont;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velikost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosledniZmena;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocetRadku;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxVelikost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPocetRadku;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ZmenaTest;
    }
}


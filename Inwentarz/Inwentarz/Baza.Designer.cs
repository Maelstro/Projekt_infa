namespace Inwentarz
{
    partial class Baza
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.identyfikatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wykonawcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tytułDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokWydaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumyDataSet = new Inwentarz.AlbumyDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bazaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stwórzRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drukujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażKoszykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.albumyTableAdapter = new Inwentarz.AlbumyDataSetTableAdapters.AlbumyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumyDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wyszukiwarka:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(788, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(788, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(788, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(788, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wykonawca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tytuł";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identyfikatorDataGridViewTextBoxColumn,
            this.wykonawcaDataGridViewTextBoxColumn,
            this.tytułDataGridViewTextBoxColumn,
            this.rokWydaniaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.stanDataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.albumyBindingSource;
            this.dgv1.Location = new System.Drawing.Point(12, 27);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(542, 497);
            this.dgv1.TabIndex = 12;
            // 
            // identyfikatorDataGridViewTextBoxColumn
            // 
            this.identyfikatorDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.HeaderText = "Identyfikator";
            this.identyfikatorDataGridViewTextBoxColumn.Name = "identyfikatorDataGridViewTextBoxColumn";
            this.identyfikatorDataGridViewTextBoxColumn.Width = 90;
            // 
            // wykonawcaDataGridViewTextBoxColumn
            // 
            this.wykonawcaDataGridViewTextBoxColumn.DataPropertyName = "Wykonawca";
            this.wykonawcaDataGridViewTextBoxColumn.HeaderText = "Wykonawca";
            this.wykonawcaDataGridViewTextBoxColumn.Name = "wykonawcaDataGridViewTextBoxColumn";
            this.wykonawcaDataGridViewTextBoxColumn.Width = 92;
            // 
            // tytułDataGridViewTextBoxColumn
            // 
            this.tytułDataGridViewTextBoxColumn.DataPropertyName = "Tytuł";
            this.tytułDataGridViewTextBoxColumn.HeaderText = "Tytuł";
            this.tytułDataGridViewTextBoxColumn.Name = "tytułDataGridViewTextBoxColumn";
            this.tytułDataGridViewTextBoxColumn.Width = 57;
            // 
            // rokWydaniaDataGridViewTextBoxColumn
            // 
            this.rokWydaniaDataGridViewTextBoxColumn.DataPropertyName = "Rok wydania";
            this.rokWydaniaDataGridViewTextBoxColumn.HeaderText = "Rok wydania";
            this.rokWydaniaDataGridViewTextBoxColumn.Name = "rokWydaniaDataGridViewTextBoxColumn";
            this.rokWydaniaDataGridViewTextBoxColumn.Width = 94;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 57;
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            this.ilośćDataGridViewTextBoxColumn.Width = 54;
            // 
            // stanDataGridViewTextBoxColumn
            // 
            this.stanDataGridViewTextBoxColumn.DataPropertyName = "Stan";
            this.stanDataGridViewTextBoxColumn.HeaderText = "Stan";
            this.stanDataGridViewTextBoxColumn.Name = "stanDataGridViewTextBoxColumn";
            this.stanDataGridViewTextBoxColumn.Width = 54;
            // 
            // albumyBindingSource
            // 
            this.albumyBindingSource.DataMember = "Albumy";
            this.albumyBindingSource.DataSource = this.albumyDataSet;
            // 
            // albumyDataSet
            // 
            this.albumyDataSet.DataSetName = "AlbumyDataSet";
            this.albumyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaDanychToolStripMenuItem,
            this.zamówieniaToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bazaDanychToolStripMenuItem
            // 
            this.bazaDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.bazaDanychToolStripMenuItem.Name = "bazaDanychToolStripMenuItem";
            this.bazaDanychToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bazaDanychToolStripMenuItem.Text = "Baza danych";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // zamówieniaToolStripMenuItem
            // 
            this.zamówieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kupToolStripMenuItem,
            this.stwórzRaportToolStripMenuItem,
            this.drukujToolStripMenuItem});
            this.zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            this.zamówieniaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.zamówieniaToolStripMenuItem.Text = "Zamówienia";
            // 
            // kupToolStripMenuItem
            // 
            this.kupToolStripMenuItem.Name = "kupToolStripMenuItem";
            this.kupToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.kupToolStripMenuItem.Text = "Dodaj zamówienie";
            // 
            // stwórzRaportToolStripMenuItem
            // 
            this.stwórzRaportToolStripMenuItem.Name = "stwórzRaportToolStripMenuItem";
            this.stwórzRaportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.stwórzRaportToolStripMenuItem.Text = "Stwórz raport";
            // 
            // drukujToolStripMenuItem
            // 
            this.drukujToolStripMenuItem.Name = "drukujToolStripMenuItem";
            this.drukujToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.drukujToolStripMenuItem.Text = "Drukuj";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażKoszykToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // pokażKoszykToolStripMenuItem
            // 
            this.pokażKoszykToolStripMenuItem.Name = "pokażKoszykToolStripMenuItem";
            this.pokażKoszykToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pokażKoszykToolStripMenuItem.Text = "Pokaż koszyk";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem1});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // pomocToolStripMenuItem1
            // 
            this.pomocToolStripMenuItem1.Name = "pomocToolStripMenuItem1";
            this.pomocToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pomocToolStripMenuItem1.Text = "Pomoc";
            this.pomocToolStripMenuItem1.Click += new System.EventHandler(this.pomocToolStripMenuItem1_Click);
            // 
            // albumyTableAdapter
            // 
            this.albumyTableAdapter.ClearBeforeFill = true;
            // 
            // Baza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 536);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Baza";
            this.Text = "Baza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Baza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumyDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stwórzRaportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drukujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażKoszykToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem1;
        private AlbumyDataSet albumyDataSet;
        private System.Windows.Forms.BindingSource albumyBindingSource;
        private AlbumyDataSetTableAdapters.AlbumyTableAdapter albumyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wykonawcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytułDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokWydaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanDataGridViewTextBoxColumn;
    }
}
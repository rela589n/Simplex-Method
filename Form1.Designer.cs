namespace Symplex_method
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matrixX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrixX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrixX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matrixX4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iterativeTable = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dzTable = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.startX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startX4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzFREECOLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dzX7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterativeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matrixX1,
            this.matrixX2,
            this.matrixX3,
            this.matrixX4});
            this.dataGridView1.Location = new System.Drawing.Point(70, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(670, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // matrixX1
            // 
            this.matrixX1.HeaderText = "x1";
            this.matrixX1.MinimumWidth = 6;
            this.matrixX1.Name = "matrixX1";
            this.matrixX1.Width = 125;
            // 
            // matrixX2
            // 
            this.matrixX2.HeaderText = "x2";
            this.matrixX2.MinimumWidth = 6;
            this.matrixX2.Name = "matrixX2";
            this.matrixX2.Width = 125;
            // 
            // matrixX3
            // 
            this.matrixX3.HeaderText = "x3";
            this.matrixX3.MinimumWidth = 6;
            this.matrixX3.Name = "matrixX3";
            this.matrixX3.Width = 125;
            // 
            // matrixX4
            // 
            this.matrixX4.HeaderText = "x4";
            this.matrixX4.MinimumWidth = 6;
            this.matrixX4.Name = "matrixX4";
            this.matrixX4.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock});
            this.dataGridView2.Location = new System.Drawing.Point(822, 74);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(133, 131);
            this.dataGridView2.TabIndex = 1;
            // 
            // stock
            // 
            this.stock.HeaderText = "Зап.Сир";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Width = 125;
            // 
            // iterativeTable
            // 
            this.iterativeTable.AllowUserToAddRows = false;
            this.iterativeTable.AllowUserToDeleteRows = false;
            this.iterativeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iterativeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.basis,
            this.CBasis,
            this.freeColumn,
            this.x1,
            this.x2,
            this.x3,
            this.x4,
            this.x5,
            this.x6,
            this.x7,
            this.teta});
            this.iterativeTable.Location = new System.Drawing.Point(16, 249);
            this.iterativeTable.Margin = new System.Windows.Forms.Padding(4);
            this.iterativeTable.Name = "iterativeTable";
            this.iterativeTable.ReadOnly = true;
            this.iterativeTable.RowHeadersVisible = false;
            this.iterativeTable.RowHeadersWidth = 51;
            this.iterativeTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iterativeTable.Size = new System.Drawing.Size(1472, 111);
            this.iterativeTable.TabIndex = 2;
            this.iterativeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "<="});
            this.comboBox1.Location = new System.Drawing.Point(750, 98);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "<="});
            this.comboBox2.Location = new System.Drawing.Point(750, 132);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "<="});
            this.comboBox3.Location = new System.Drawing.Point(750, 165);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(63, 24);
            this.comboBox3.TabIndex = 13;
            // 
            // dzTable
            // 
            this.dzTable.AllowUserToAddRows = false;
            this.dzTable.AllowUserToDeleteRows = false;
            this.dzTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dzTable.ColumnHeadersVisible = false;
            this.dzTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dzFREECOLUMN,
            this.dzX1,
            this.dzX2,
            this.dzX3,
            this.dzX4,
            this.dzX5,
            this.dzX6,
            this.dzX7});
            this.dzTable.Location = new System.Drawing.Point(215, 368);
            this.dzTable.Margin = new System.Windows.Forms.Padding(4);
            this.dzTable.Name = "dzTable";
            this.dzTable.ReadOnly = true;
            this.dzTable.RowHeadersVisible = false;
            this.dzTable.RowHeadersWidth = 51;
            this.dzTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dzTable.Size = new System.Drawing.Size(1152, 32);
            this.dzTable.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(209, 438);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(267, 22);
            this.textBox5.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 442);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "X опт.=";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(998, 117);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 19;
            this.button2.Text = "Наступна ітерація";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(998, 177);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "На кінець";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startX1,
            this.startX2,
            this.startX3,
            this.startX4});
            this.dataGridView5.Location = new System.Drawing.Point(4, 7);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView5.Size = new System.Drawing.Size(736, 59);
            this.dataGridView5.TabIndex = 21;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView5_CellContentClick);
            // 
            // startX1
            // 
            this.startX1.HeaderText = "x1";
            this.startX1.MinimumWidth = 6;
            this.startX1.Name = "startX1";
            this.startX1.Width = 125;
            // 
            // startX2
            // 
            this.startX2.HeaderText = "x2";
            this.startX2.MinimumWidth = 6;
            this.startX2.Name = "startX2";
            this.startX2.Width = 125;
            // 
            // startX3
            // 
            this.startX3.HeaderText = "x3";
            this.startX3.MinimumWidth = 6;
            this.startX3.Name = "startX3";
            this.startX3.Width = 125;
            // 
            // startX4
            // 
            this.startX4.HeaderText = "x4";
            this.startX4.MinimumWidth = 6;
            this.startX4.Name = "startX4";
            this.startX4.Width = 125;
            // 
            // basis
            // 
            this.basis.HeaderText = "Базис";
            this.basis.MinimumWidth = 6;
            this.basis.Name = "basis";
            this.basis.ReadOnly = true;
            this.basis.Width = 75;
            // 
            // CBasis
            // 
            this.CBasis.HeaderText = "C баз";
            this.CBasis.MinimumWidth = 6;
            this.CBasis.Name = "CBasis";
            this.CBasis.ReadOnly = true;
            this.CBasis.Width = 75;
            // 
            // freeColumn
            // 
            this.freeColumn.HeaderText = "А";
            this.freeColumn.MinimumWidth = 6;
            this.freeColumn.Name = "freeColumn";
            this.freeColumn.ReadOnly = true;
            this.freeColumn.Width = 125;
            // 
            // x1
            // 
            this.x1.HeaderText = "X1";
            this.x1.MinimumWidth = 6;
            this.x1.Name = "x1";
            this.x1.ReadOnly = true;
            // 
            // x2
            // 
            this.x2.HeaderText = "X2";
            this.x2.MinimumWidth = 6;
            this.x2.Name = "x2";
            this.x2.ReadOnly = true;
            // 
            // x3
            // 
            this.x3.HeaderText = "X3";
            this.x3.MinimumWidth = 6;
            this.x3.Name = "x3";
            this.x3.ReadOnly = true;
            // 
            // x4
            // 
            this.x4.HeaderText = "X4";
            this.x4.MinimumWidth = 6;
            this.x4.Name = "x4";
            this.x4.ReadOnly = true;
            // 
            // x5
            // 
            this.x5.HeaderText = "X5";
            this.x5.MinimumWidth = 6;
            this.x5.Name = "x5";
            this.x5.ReadOnly = true;
            // 
            // x6
            // 
            this.x6.HeaderText = "X6";
            this.x6.MinimumWidth = 6;
            this.x6.Name = "x6";
            this.x6.ReadOnly = true;
            // 
            // x7
            // 
            this.x7.HeaderText = "X7";
            this.x7.MinimumWidth = 6;
            this.x7.Name = "x7";
            this.x7.ReadOnly = true;
            // 
            // teta
            // 
            this.teta.HeaderText = "TETA";
            this.teta.MinimumWidth = 6;
            this.teta.Name = "teta";
            this.teta.ReadOnly = true;
            // 
            // dzFREECOLUMN
            // 
            this.dzFREECOLUMN.HeaderText = "Column1";
            this.dzFREECOLUMN.MinimumWidth = 6;
            this.dzFREECOLUMN.Name = "dzFREECOLUMN";
            this.dzFREECOLUMN.ReadOnly = true;
            this.dzFREECOLUMN.Width = 125;
            // 
            // dzX1
            // 
            this.dzX1.HeaderText = "Column2";
            this.dzX1.MinimumWidth = 6;
            this.dzX1.Name = "dzX1";
            this.dzX1.ReadOnly = true;
            // 
            // dzX2
            // 
            this.dzX2.HeaderText = "Column3";
            this.dzX2.MinimumWidth = 6;
            this.dzX2.Name = "dzX2";
            this.dzX2.ReadOnly = true;
            // 
            // dzX3
            // 
            this.dzX3.HeaderText = "Column4";
            this.dzX3.MinimumWidth = 6;
            this.dzX3.Name = "dzX3";
            this.dzX3.ReadOnly = true;
            // 
            // dzX4
            // 
            this.dzX4.HeaderText = "Column10";
            this.dzX4.MinimumWidth = 6;
            this.dzX4.Name = "dzX4";
            this.dzX4.ReadOnly = true;
            // 
            // dzX5
            // 
            this.dzX5.HeaderText = "Column11";
            this.dzX5.MinimumWidth = 6;
            this.dzX5.Name = "dzX5";
            this.dzX5.ReadOnly = true;
            // 
            // dzX6
            // 
            this.dzX6.HeaderText = "Column12";
            this.dzX6.MinimumWidth = 6;
            this.dzX6.Name = "dzX6";
            this.dzX6.ReadOnly = true;
            // 
            // dzX7
            // 
            this.dzX7.HeaderText = "Column1";
            this.dzX7.MinimumWidth = 6;
            this.dzX7.Name = "dzX7";
            this.dzX7.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 554);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dzTable);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.iterativeTable);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterativeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dzTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView iterativeTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dzTable;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrixX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrixX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrixX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn matrixX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn startX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn startX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn basis;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3;
        private System.Windows.Forms.DataGridViewTextBoxColumn x4;
        private System.Windows.Forms.DataGridViewTextBoxColumn x5;
        private System.Windows.Forms.DataGridViewTextBoxColumn x6;
        private System.Windows.Forms.DataGridViewTextBoxColumn x7;
        private System.Windows.Forms.DataGridViewTextBoxColumn teta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzFREECOLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dzX7;
    }
}


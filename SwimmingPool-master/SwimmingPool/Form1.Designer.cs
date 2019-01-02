namespace SwimmingPool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonenti = new System.Windows.Forms.DataGridView();
            this.indetifikator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mwvrtneli = new System.Windows.Forms.DataGridView();
            this.indetifikator1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eqimi = new System.Windows.Forms.DataGridView();
            this.indetifikatori2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cnoba1 = new System.Windows.Forms.DataGridView();
            this.indetifikatori3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fasi = new System.Windows.Forms.DataGridView();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.abonenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mwvrtneli)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eqimi)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cnoba1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fasi)).BeginInit();
            this.SuspendLayout();
            // 
            // abonenti
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.abonenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.abonenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indetifikator,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.TelNum,
            this.Adres});
            this.abonenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abonenti.Location = new System.Drawing.Point(3, 21);
            this.abonenti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.abonenti.Name = "abonenti";
            this.abonenti.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.abonenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.abonenti.RowTemplate.ReadOnly = true;
            this.abonenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.abonenti.Size = new System.Drawing.Size(1066, 628);
            this.abonenti.TabIndex = 0;
            // 
            // indetifikator
            // 
            this.indetifikator.HeaderText = "აბონემენტის ნომერი";
            this.indetifikator.Name = "indetifikator";
            this.indetifikator.ReadOnly = true;
            this.indetifikator.Width = 120;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "სახელი";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "გვარი";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 200;
            // 
            // BirthDate
            // 
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.BirthDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.BirthDate.HeaderText = "დაბადების თარიღი";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            this.BirthDate.Width = 150;
            // 
            // TelNum
            // 
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.TelNum.DefaultCellStyle = dataGridViewCellStyle7;
            this.TelNum.HeaderText = "ტელეფონის ნომერი";
            this.TelNum.Name = "TelNum";
            this.TelNum.ReadOnly = true;
            this.TelNum.Width = 150;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "მისამართი";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.abonenti);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 652);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "აბონენტი";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(1107, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "აბონენტის ძებნა";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 25);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mwvrtneli);
            this.groupBox3.Location = new System.Drawing.Point(12, 670);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 294);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "მწვრთნელი";
            // 
            // mwvrtneli
            // 
            this.mwvrtneli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mwvrtneli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indetifikator1,
            this.FirstName1,
            this.LastName1});
            this.mwvrtneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mwvrtneli.Location = new System.Drawing.Point(3, 21);
            this.mwvrtneli.Name = "mwvrtneli";
            this.mwvrtneli.ReadOnly = true;
            this.mwvrtneli.RowTemplate.ReadOnly = true;
            this.mwvrtneli.Size = new System.Drawing.Size(346, 270);
            this.mwvrtneli.TabIndex = 0;
            // 
            // indetifikator1
            // 
            this.indetifikator1.HeaderText = "ნომერი";
            this.indetifikator1.Name = "indetifikator1";
            this.indetifikator1.ReadOnly = true;
            // 
            // FirstName1
            // 
            this.FirstName1.HeaderText = "სახელი";
            this.FirstName1.Name = "FirstName1";
            this.FirstName1.ReadOnly = true;
            // 
            // LastName1
            // 
            this.LastName1.HeaderText = "ვარი";
            this.LastName1.Name = "LastName1";
            this.LastName1.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.eqimi);
            this.groupBox4.Location = new System.Drawing.Point(373, 670);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 294);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ექიმი";
            // 
            // eqimi
            // 
            this.eqimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eqimi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indetifikatori2,
            this.FirstName2,
            this.LastName2});
            this.eqimi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eqimi.Location = new System.Drawing.Point(3, 21);
            this.eqimi.Name = "eqimi";
            this.eqimi.ReadOnly = true;
            this.eqimi.RowTemplate.ReadOnly = true;
            this.eqimi.Size = new System.Drawing.Size(345, 270);
            this.eqimi.TabIndex = 0;
            // 
            // indetifikatori2
            // 
            this.indetifikatori2.HeaderText = "ნომერი";
            this.indetifikatori2.Name = "indetifikatori2";
            this.indetifikatori2.ReadOnly = true;
            // 
            // FirstName2
            // 
            this.FirstName2.HeaderText = "სახელი";
            this.FirstName2.Name = "FirstName2";
            this.FirstName2.ReadOnly = true;
            // 
            // LastName2
            // 
            this.LastName2.HeaderText = "გვარი";
            this.LastName2.Name = "LastName2";
            this.LastName2.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cnoba1);
            this.groupBox5.Location = new System.Drawing.Point(727, 670);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 294);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ცნობა";
            // 
            // cnoba1
            // 
            this.cnoba1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cnoba1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indetifikatori3,
            this.cnoba});
            this.cnoba1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnoba1.Location = new System.Drawing.Point(3, 21);
            this.cnoba1.Name = "cnoba1";
            this.cnoba1.ReadOnly = true;
            this.cnoba1.RowTemplate.ReadOnly = true;
            this.cnoba1.Size = new System.Drawing.Size(243, 270);
            this.cnoba1.TabIndex = 0;
            // 
            // indetifikatori3
            // 
            this.indetifikatori3.HeaderText = "აბონენტის ნომერი";
            this.indetifikatori3.Name = "indetifikatori3";
            this.indetifikatori3.ReadOnly = true;
            // 
            // cnoba
            // 
            this.cnoba.HeaderText = "ცნობა";
            this.cnoba.Name = "cnoba";
            this.cnoba.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fasi);
            this.groupBox6.Location = new System.Drawing.Point(982, 670);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(254, 294);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ფასი";
            // 
            // fasi
            // 
            this.fasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Price,
            this.Time});
            this.fasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fasi.Location = new System.Drawing.Point(3, 21);
            this.fasi.Name = "fasi";
            this.fasi.ReadOnly = true;
            this.fasi.RowTemplate.ReadOnly = true;
            this.fasi.Size = new System.Drawing.Size(248, 270);
            this.fasi.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.HeaderText = "ფასი";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "საათი";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(1107, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 122);
            this.button1.TabIndex = 7;
            this.button1.Text = "აბონენტის დამატება";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1385, 765);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "აბონენტები";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.abonenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mwvrtneli)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eqimi)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cnoba1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView abonenti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indetifikator;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView mwvrtneli;
        private System.Windows.Forms.DataGridViewTextBoxColumn indetifikator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView eqimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn indetifikatori2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView cnoba1;
        private System.Windows.Forms.DataGridViewTextBoxColumn indetifikatori3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoba;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView fasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button button1;
    }
}


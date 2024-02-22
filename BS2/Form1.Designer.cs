namespace BS2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MSKcarnt = new System.Windows.Forms.MaskedTextBox();
            this.TXBnom = new System.Windows.Forms.TextBox();
            this.TXBapell = new System.Windows.Forms.TextBox();
            this.MSKacum = new System.Windows.Forms.MaskedTextBox();
            this.MSKexam = new System.Windows.Forms.MaskedTextBox();
            this.TXBfinal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNbase = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNcalc = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(39, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(642, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Carnet";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Acumulado";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Examen";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nota final";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Acumulado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Examen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nota final";
            // 
            // MSKcarnt
            // 
            this.MSKcarnt.Location = new System.Drawing.Point(39, 73);
            this.MSKcarnt.Mask = "9999";
            this.MSKcarnt.Name = "MSKcarnt";
            this.MSKcarnt.Size = new System.Drawing.Size(100, 23);
            this.MSKcarnt.TabIndex = 7;
            this.MSKcarnt.ValidatingType = typeof(int);
            // 
            // TXBnom
            // 
            this.TXBnom.Location = new System.Drawing.Point(173, 73);
            this.TXBnom.Name = "TXBnom";
            this.TXBnom.Size = new System.Drawing.Size(100, 23);
            this.TXBnom.TabIndex = 8;
            this.TXBnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBnom_KeyPress);
            // 
            // TXBapell
            // 
            this.TXBapell.Location = new System.Drawing.Point(321, 73);
            this.TXBapell.Name = "TXBapell";
            this.TXBapell.Size = new System.Drawing.Size(100, 23);
            this.TXBapell.TabIndex = 9;
            this.TXBapell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBapell_KeyPress);
            // 
            // MSKacum
            // 
            this.MSKacum.Location = new System.Drawing.Point(463, 73);
            this.MSKacum.Mask = "99";
            this.MSKacum.Name = "MSKacum";
            this.MSKacum.Size = new System.Drawing.Size(100, 23);
            this.MSKacum.TabIndex = 10;
            this.MSKacum.ValidatingType = typeof(int);
            // 
            // MSKexam
            // 
            this.MSKexam.Location = new System.Drawing.Point(597, 71);
            this.MSKexam.Mask = "99";
            this.MSKexam.Name = "MSKexam";
            this.MSKexam.Size = new System.Drawing.Size(100, 23);
            this.MSKexam.TabIndex = 11;
            this.MSKexam.ValidatingType = typeof(int);
            // 
            // TXBfinal
            // 
            this.TXBfinal.Location = new System.Drawing.Point(728, 71);
            this.TXBfinal.Name = "TXBfinal";
            this.TXBfinal.Size = new System.Drawing.Size(100, 23);
            this.TXBfinal.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.BTNbase);
            this.groupBox1.Controls.Add(this.BTNsalir);
            this.groupBox1.Controls.Add(this.BTNcalc);
            this.groupBox1.Location = new System.Drawing.Point(706, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 174);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // BTNbase
            // 
            this.BTNbase.Location = new System.Drawing.Point(22, 136);
            this.BTNbase.Name = "BTNbase";
            this.BTNbase.Size = new System.Drawing.Size(110, 23);
            this.BTNbase.TabIndex = 2;
            this.BTNbase.Text = "Ver base actual";
            this.BTNbase.UseVisualStyleBackColor = true;
            this.BTNbase.Click += new System.EventHandler(this.BTNbase_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(38, 96);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 1;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNcalc
            // 
            this.BTNcalc.Location = new System.Drawing.Point(38, 45);
            this.BTNcalc.Name = "BTNcalc";
            this.BTNcalc.Size = new System.Drawing.Size(75, 23);
            this.BTNcalc.TabIndex = 0;
            this.BTNcalc.Text = "Calcular";
            this.BTNcalc.UseVisualStyleBackColor = true;
            this.BTNcalc.Click += new System.EventHandler(this.BTNcalc_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView2.Location = new System.Drawing.Point(39, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(642, 174);
            this.dataGridView2.TabIndex = 14;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Carnet";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nombre";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Apellido";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Acumulado";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Examen";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Nota final";
            this.Column12.Name = "Column12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 326);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXBfinal);
            this.Controls.Add(this.MSKexam);
            this.Controls.Add(this.MSKacum);
            this.Controls.Add(this.TXBapell);
            this.Controls.Add(this.TXBnom);
            this.Controls.Add(this.MSKcarnt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox MSKcarnt;
        private TextBox TXBnom;
        private TextBox TXBapell;
        private MaskedTextBox MSKacum;
        private MaskedTextBox MSKexam;
        private TextBox TXBfinal;
        private GroupBox groupBox1;
        private Button BTNsalir;
        private Button BTNcalc;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button BTNbase;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}
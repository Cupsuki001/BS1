namespace WinFormsApp1
{
    partial class Formulario
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
            this.TXBcarnet = new System.Windows.Forms.TextBox();
            this.TXBnom = new System.Windows.Forms.TextBox();
            this.TXBaplli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MSKacumul = new System.Windows.Forms.MaskedTextBox();
            this.MSKexamen = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXBnotafin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNborrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXBcarnet
            // 
            this.TXBcarnet.Location = new System.Drawing.Point(29, 95);
            this.TXBcarnet.Name = "TXBcarnet";
            this.TXBcarnet.Size = new System.Drawing.Size(100, 23);
            this.TXBcarnet.TabIndex = 0;
            this.TXBcarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBcarnet_KeyPress);
            // 
            // TXBnom
            // 
            this.TXBnom.Location = new System.Drawing.Point(178, 95);
            this.TXBnom.Name = "TXBnom";
            this.TXBnom.Size = new System.Drawing.Size(100, 23);
            this.TXBnom.TabIndex = 1;
            this.TXBnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBnom_KeyPress);
            // 
            // TXBaplli
            // 
            this.TXBaplli.Location = new System.Drawing.Point(323, 95);
            this.TXBaplli.Name = "TXBaplli";
            this.TXBaplli.Size = new System.Drawing.Size(100, 23);
            this.TXBaplli.TabIndex = 2;
            this.TXBaplli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXBaplli_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // MSKacumul
            // 
            this.MSKacumul.Location = new System.Drawing.Point(462, 95);
            this.MSKacumul.Mask = "99";
            this.MSKacumul.Name = "MSKacumul";
            this.MSKacumul.Size = new System.Drawing.Size(100, 23);
            this.MSKacumul.TabIndex = 6;
            this.MSKacumul.ValidatingType = typeof(int);
            // 
            // MSKexamen
            // 
            this.MSKexamen.Location = new System.Drawing.Point(595, 95);
            this.MSKexamen.Mask = "99";
            this.MSKexamen.Name = "MSKexamen";
            this.MSKexamen.Size = new System.Drawing.Size(100, 23);
            this.MSKexamen.TabIndex = 7;
            this.MSKexamen.ValidatingType = typeof(int);
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(641, 162);
            this.dataGridView1.TabIndex = 8;
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
            // TXBnotafin
            // 
            this.TXBnotafin.Location = new System.Drawing.Point(731, 95);
            this.TXBnotafin.Name = "TXBnotafin";
            this.TXBnotafin.Size = new System.Drawing.Size(100, 23);
            this.TXBnotafin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nota final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Acumulado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Examen";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(43, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(43, 75);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(75, 23);
            this.BTNsalir.TabIndex = 14;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNborrar
            // 
            this.BTNborrar.Location = new System.Drawing.Point(43, 125);
            this.BTNborrar.Name = "BTNborrar";
            this.BTNborrar.Size = new System.Drawing.Size(75, 23);
            this.BTNborrar.TabIndex = 15;
            this.BTNborrar.Text = "Borrar";
            this.BTNborrar.UseVisualStyleBackColor = true;
            this.BTNborrar.Click += new System.EventHandler(this.BTNborrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.BTNsalir);
            this.groupBox1.Controls.Add(this.BTNborrar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(683, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 162);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXBnotafin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MSKexamen);
            this.Controls.Add(this.MSKacumul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXBaplli);
            this.Controls.Add(this.TXBnom);
            this.Controls.Add(this.TXBcarnet);
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TXBcarnet;
        private TextBox TXBnom;
        private TextBox TXBaplli;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox MSKacumul;
        private MaskedTextBox MSKexamen;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox TXBnotafin;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button BTNsalir;
        private Button BTNborrar;
        private GroupBox groupBox1;
    }
}
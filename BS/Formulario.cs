using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BS;

namespace WinFormsApp1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        public int num =0;

        private void Formulario_Load(object sender, EventArgs e)
        {
            TXBnotafin.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Est es = new Est();
            es.nombre = TXBnom.Text;
            es.carnet = Convert.ToInt16(TXBcarnet.Text);
            es.apelli = TXBaplli.Text;
            es.acum = Convert.ToInt16(MSKacumul.Text);
            es.exam = Convert.ToInt16(MSKexamen.Text);
           

            int result = Est2.agregar(es);

            if(result > 0) 
            {
                MessageBox.Show("si");
            }
            else 
            {
                MessageBox.Show("no");
            }


            try
            {
                double exam, acum, tt;

                // Verificar si los campos están vacíos
                if (string.IsNullOrEmpty(TXBnom.Text) || string.IsNullOrEmpty(TXBaplli.Text) ||
                    string.IsNullOrEmpty(TXBcarnet.Text) || string.IsNullOrEmpty(MSKacumul.Text) || string.IsNullOrEmpty(MSKexamen.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Convertir los valores de los campos
                exam = Convert.ToDouble(MSKexamen.Text);
                acum = Convert.ToDouble(MSKacumul.Text);

                if (acum < 0 || acum > 70)
                {
                    MessageBox.Show("No puede ser 0 o mayor a 70");
                }
                else
                {
                    if (exam < 0 || exam > 30)
                    {
                        MessageBox.Show("No puede ser 0 o mayor a 30");
                    }
                    else
                    {
                        tt = exam + acum;
                        TXBnotafin.Text = tt.ToString();
                        es.final = Convert.ToInt16(TXBnotafin.Text);

                        int num = dataGridView1.Rows.Add();
                        dataGridView1.Rows[num].Cells[0].Value = TXBcarnet.Text + "U";
                        dataGridView1.Rows[num].Cells[1].Value = TXBnom.Text;
                        dataGridView1.Rows[num].Cells[2].Value = TXBaplli.Text;
                        dataGridView1.Rows[num].Cells[3].Value = MSKacumul.Text;
                        dataGridView1.Rows[num].Cells[4].Value = MSKexamen.Text;
                        dataGridView1.Rows[num].Cells[5].Value = TXBnotafin.Text;

                        TXBnom.Text = "";
                        TXBaplli.Text = "";
                        TXBcarnet.Text = "";
                        MSKacumul.Text = "";
                        MSKexamen.Text = "";
                    }
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede estar en blanco");
            }


           
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNborrar_Click(object sender, EventArgs e)
        {
            if (num != -1)
            {
                dataGridView1.Rows.RemoveAt(num);
            }
        }

        private void TXBcarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Solo Numeros , la letra se agregara automatixamente");
                e.Handled = true;
            }
        }

        private void TXBnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TXBaplli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

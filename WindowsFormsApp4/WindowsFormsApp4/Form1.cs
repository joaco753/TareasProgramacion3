using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Argentina");
            comboBox1.Items.Add("Brasil");
            comboBox1.Items.Add("Uruguay");
            comboBox1.Items.Add("Paraguay");
            comboBox1.Items.Add("Bolivia");
            comboBox1.Items.Add("Venezuela");
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ThisYear = DateTime.Now.Year;
            int Userage = dateTimePicker1.Value.Year;

            if (String.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true || string.IsNullOrEmpty(comboBox1.Text) == true || radioButton1.Checked == false && radioButton2.Checked == false)
            {
                string Errormessage = "Por favor, llene todos los campos del formulario";
                MessageBox.Show(Errormessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ThisYear - Userage < 18)
            {
                string Errormessage = "Tienes que ser mayo de 18 años";
                MessageBox.Show(Errormessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Succesmessage = "Todos los campos fueron cargados con exito!";
                MessageBox.Show(Succesmessage, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SIMULACION_EXAMEN_PARCIAL
{
    public partial class Form1 : Form
    {
        List<Departamentos> departamento = new List<Departamentos>();
        public Form1()
        {
            InitializeComponent();

            string nombreArchivo = "Departamentos.txt";

            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                string texto = reader.ReadLine();
                comboBox1.Items.Add(texto);
            }
            reader.Close();
        }

        private void GuardarRegistro()
        {
            FileStream stream= new FileStream("Temperaturas.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach(var departaemnto in departamento)
            {
                writer.WriteLine(departaemnto.numDep);
                writer.WriteLine(departaemnto.temperatura);
                writer.WriteLine(departaemnto.fechaRegristro);
            }
            writer.Close();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departamentos departamentos = new Departamentos();
            departamentos.numDep = comboBox1.Text;
            departamentos.temperatura = textBox1.Text+" grados centigrados ";
            departamentos.fechaRegristro = Convert.ToDateTime(dateTimePicker1.Text);

            departamento.Add(departamentos);
            GuardarRegistro();  
        }
    }
}

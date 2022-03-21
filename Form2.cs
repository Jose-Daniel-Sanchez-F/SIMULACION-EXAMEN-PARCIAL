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
    public partial class Form2 : Form
    {
        List<Mostrar> mostrarTemp = new List<Mostrar>();
        public Form2()
        {
            InitializeComponent();
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("Temperaturas.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {
                Mostrar mostrar = new Mostrar();
                mostrar.Dep=reader.ReadLine();
                mostrar.temperatura = Convert.ToDecimal(reader.ReadLine());
                mostrar.fechaRegristro = Convert.ToDateTime(reader.ReadLine());

                mostrarTemp.Add(mostrar);
            }
            reader.Close();
            dataGridView1.DataSource = null;
            //dataGridView1.Refresh();
            dataGridView1.DataSource = mostrarTemp;
            dataGridView1.Refresh();

            Decimal maxima = mostrarTemp.Max(a => a.temperatura);
            labelMax.Text = maxima.ToString() + " grados centigrados.";

            Decimal minima = mostrarTemp.Min(b => b.temperatura);
            labelMin.Text = minima.ToString() + " grados centigrados.";

        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            mostrarTemp = mostrarTemp.OrderBy(n => n.temperatura).ToList();
            MessageBox.Show("Opcion no disponible."); 


        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {
          

            label1.Text=mostrarTemp.Average(a=>a.temperatura).ToString();
        }
    }
}

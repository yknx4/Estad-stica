using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAE
{
    public partial class Form1 : Form
    {
        BindingList<BindingList<double>> estratos = new BindingList<BindingList<double>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estratos.Add(new BindingList<double>());
            cmbEstratos.DataSource = estratos;
            lstEstratos.DataSource = estratos[0];
        }
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                estratos[cmbEstratos.SelectedIndex].Add(double.Parse(txtValor.Text));
                txtValor.Clear();
            }
        }
        private void txtAddV_Click(object sender, EventArgs e)
        {
            estratos[cmbEstratos.SelectedIndex].Add(double.Parse(txtValor.Text));
            txtValor.Clear();
        }

        private void cmbEstratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEstratos.DataSource = estratos[cmbEstratos.SelectedIndex];
        }

        private void btnAddEstrato_Click(object sender, EventArgs e)
        {
            estratos.Add(new BindingList<double>());
            cmbEstratos.DataSource = estratos;
        }

        private double calcularPromedioPorEstrato(BindingList<double> datos)
        {
            double suma = 0;
            foreach (double val in datos)
            {
                suma += val;
            }
            return suma / datos.Count;

        }
        private double calcularPromedioTotal(params double[] datos)
        {
            double suma = 0;
            foreach (double val in datos)
            {
                suma += val;
            }
            return suma / datos.Count();

        }

        private void refrescar(object sender, MouseEventArgs e)
        {
            double countTotal = 0;
            int N =int.Parse(txtTamaño.Text);
            double valorTabla = double.Parse(txtTabla.Text);
            double preParaEstMed = double.Parse(txtPreParaM.Text);
            List<double> promedios = new List<double>();
            List<double> varianzas = new List<double>();
            List<double> valoresDeMuestra_n = new List<double>();
            List<double> valoresDeMuestra_nf = new List<double>();
            txtDatos.Clear();
            int count = 1;
            //Calculo de promedio por estrato
            txtDatos.AppendText("A)" + Environment.NewLine);
            foreach (var lista in estratos)
            {
                countTotal += lista.Count;
                double pro = calcularPromedioPorEstrato(lista);
                promedios.Add(pro);
                txtDatos.AppendText("Promedio estrato " + count + " : "+pro.ToString()+Environment.NewLine);
                count++;
            }
            double promedioEstr =0;
            count =0;
            //Calculo de promedio estratificado
            foreach (var lista in estratos)
            {
                promedioEstr += promedios[count]*((lista.Count/countTotal)*N);
                    count++;
            }
            
            promedioEstr /= N;
            txtDatos.AppendText("Promedio estratificado : " + promedioEstr.ToString() + Environment.NewLine);
            //Calculo de estimación puntual
            txtDatos.AppendText("B)" + Environment.NewLine);
            double estPunt = promedioEstr * N;
            txtDatos.AppendText("T^ = " + estPunt.ToString() + Environment.NewLine);
            count = 0;
            //Calculo de Varianzas por estrato
            txtDatos.AppendText("C)" + Environment.NewLine);
            foreach (var lista in estratos)
            {
                double currVar = 0;
                foreach (double val in lista)
                {
                    double calc = val - promedios[count];
                    currVar += (calc * calc);
                }
                currVar /= (lista.Count - 1);
                varianzas.Add(currVar);
                txtDatos.AppendText("Varianza estrato " + (count + 1) + " : " + currVar.ToString() + Environment.NewLine);
                count++;
            }
            //Calculo de varianza total y desviación estandar;
            double varianzaEstr = 0;
            double desvEstr = 0;
            count = 0;
            
            foreach (var lista in estratos)
            {
                double Nh = (lista.Count / countTotal) * N;
                varianzaEstr += (Nh*Nh)*((Nh-lista.Count)/Nh)*(varianzas[count]/lista.Count);
                count++;
            }

            varianzaEstr /= (N*N);
            txtDatos.AppendText("Varianza estratificada : " + varianzaEstr.ToString() + Environment.NewLine);
            desvEstr = Math.Sqrt(varianzaEstr);
            txtDatos.AppendText("Desv Est estratificada : " + desvEstr.ToString() + Environment.NewLine);

            //Intervalo de confianza
            txtDatos.AppendText("D)" + Environment.NewLine);
            double intConf = valorTabla*desvEstr;
            txtDatos.AppendText((promedioEstr - intConf) + " <= Uest <= " + (promedioEstr + intConf) + Environment.NewLine);
            //Intervalo de confianza2
            txtDatos.AppendText("E)" + Environment.NewLine);
            double valNeceInt = varianzaEstr * N * N;
            double intConf2 = valorTabla * Math.Sqrt(valNeceInt);
            txtDatos.AppendText((estPunt - intConf2) + " <= T^ <= " + (estPunt + intConf2) + Environment.NewLine);
            //Tamaño de muestra
            txtDatos.AppendText("F)" + Environment.NewLine);
            double nFi = 0;
            double whsh2=0;
            count = 0;
            foreach (var lista in estratos)
            {
                double Nh = (lista.Count / countTotal);
                whsh2 += Nh * varianzas[count];
                count++;
            }
            double d = preParaEstMed * promedioEstr;
            nFi = (N * valorTabla * valorTabla * whsh2) / ((N * d * d) + (valorTabla * valorTabla * whsh2));
            txtDatos.AppendText("(tamaño muestra) n : " + nFi.ToString() + Environment.NewLine);
            count = 0;
            foreach (var lista in estratos)
            {
                double Nh = (lista.Count / countTotal) * nFi;
                valoresDeMuestra_n.Add(Nh);
                txtDatos.AppendText("(tamaño muestra) n "+(count+1)+": " + Nh.ToString() + Environment.NewLine);
                count++;
            }
            //Tamaño de muestra
            txtDatos.AppendText("G)" + Environment.NewLine);
            double nFi2 = 0;
            double d2 = preParaEstMed * estPunt;
            nFi2 = (N*N * valorTabla * valorTabla * whsh2) / ((d2 * d2) + (valorTabla * valorTabla * whsh2));
            txtDatos.AppendText("(tamaño muestra final) n : " + nFi2.ToString() + Environment.NewLine);
            count = 0;
            foreach (var lista in estratos)
            {
                double Nh = (lista.Count / countTotal) * nFi2;
                valoresDeMuestra_nf.Add(Nh);
                txtDatos.AppendText("(tamaño muestra final) n " + (count + 1) + ": " + Nh.ToString() + Environment.NewLine);
                count++;
            }
        }
    }
}

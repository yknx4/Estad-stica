using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAEPP
{
    public partial class Form1 : Form
    {
        Muestreo muest;
        BindingList<Muestreo.Estrato> estratos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            estratos = new BindingList<Muestreo.Estrato>();
            muest = new Muestreo(estratos);
            cmbEstratos.DataSource = estratos;
        }

        private void btnAddEstrato_Click(object sender, EventArgs e)
        {
            Muestreo.Estrato est;
            int N = int.Parse(txtNH.Text);
            int n = int.Parse(txtn.Text);
            int a = int.Parse(txta.Text);
            est = new Muestreo.Estrato(N, n, a);
            estratos.Add(est);
        }
        private void Refrescar()
        {
            int count = 0;
            txtDatos.AppendText("A)" + Environment.NewLine);
            foreach (var lista in estratos)
            {
                count++;
                txtDatos.AppendText("Proporcion estrato " + count + " : " + lista.p.ToString() + Environment.NewLine);
                
            }
            count=0;
            txtDatos.AppendText("Proporcion estratificado : " + muest.Pst().ToString() + Environment.NewLine);
            //Calculo de estimación puntual
            txtDatos.AppendText("B)" + Environment.NewLine);
            
            txtDatos.AppendText("T^ = " + muest.TotalEst().ToString() + Environment.NewLine);
            
           
            //Calculo de Varianzas por estrato
            txtDatos.AppendText("C)" + Environment.NewLine);
            foreach (var lista in estratos)
            {
              
                txtDatos.AppendText("Varianza estrato " + (count + 1) + " : " + lista.S2.ToString() + Environment.NewLine);
                count++;
            }
            count=0;
            //Calculo de varianza total y desviación estandar;
           
           
            txtDatos.AppendText("Varianza estratificada : " + muest.S2ph().ToString() + Environment.NewLine);
     
            //txtDatos.AppendText("Desv Est estratificada : " + desvEstr.ToString() + Environment.NewLine);

            //Intervalo de confianza
            txtDatos.AppendText("D)" + Environment.NewLine);
            
            txtDatos.AppendText(muest.ICpropEst() + Environment.NewLine);
            //Intervalo de confianza2
            txtDatos.AppendText("E)" + Environment.NewLine);
            
            txtDatos.AppendText(muest.ICtotal() + Environment.NewLine);
            //Tamaño de muestra
            
            txtDatos.AppendText("F)" + Environment.NewLine);

            MAEPP.Muestreo.Muestra f = muest.muestraPreliminar(.05);

               txtDatos.AppendText("(tamaño muestra) n : " + f.n.ToString() + Environment.NewLine);
            
            foreach (var lista in f.nh)
            {
               
                txtDatos.AppendText("(tamaño muestra) n " + (count + 1) + ": " + lista.ToString() + Environment.NewLine);
                count++; 
            }
            count = 0;
            //Tamaño de muestra
            f = muest.muestraFinal(.05);
            txtDatos.AppendText("G)" + Environment.NewLine);
            txtDatos.AppendText("(tamaño muestra final) n : " + f.n.ToString() + Environment.NewLine);

            foreach (var lista in f.nh)
            {

                txtDatos.AppendText("(tamaño muestra final) n " + (count + 1) + ": " + lista.ToString() + Environment.NewLine);
                count++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbEstratos.SelectedItem != null)
            {
                estratos.Remove((Muestreo.Estrato)cmbEstratos.SelectedItem);
                loadEstrato(new Muestreo.Estrato(0, 0, 0));
            }
        }

        private void loadEstrato(Muestreo.Estrato input){
            txtn.Text = input.n.ToString();
            txtNH.Text = input.N.ToString();
            txta.Text = input.a.ToString();
        }

        private void cambiaN(object sender, EventArgs e)
        {
            int N;
            if (int.TryParse(txtNG.Text, out N))
            {
                Muestreo.Estrato.N_total = N;
            }
        }

        private void cambiaConf(object sender, EventArgs e)
        {
            double N;
            if (double.TryParse(txtConf.Text, out N))
            {
                muest.Confiabilidad = N;
            }
        }

        private void calcular(object sender, EventArgs e)
        {
            Refrescar();
            
        }
    }
}

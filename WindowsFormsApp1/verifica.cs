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

namespace WindowsFormsApp1
{
    public partial class verifica : Form
    {
        public verifica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 verifica = new Form1();
            verifica.ShowDialog();
            this.Hide();
            this.Close();
            StreamReader sr = new StreamReader(@"./dati.csv");
            string line;
            line= sr.ReadLine();
            char[] recordo = line.ToCharArray();   
            int cont = recordo.Length;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                recordo = line.ToCharArray();
                if(cont == recordo.Length)
                {
                    MessageBox.Show("tutti i record sono di lunghezza uguale");
                }
                else
                {
                    MessageBox.Show("i record sono di lunghezza diversa");
                }
             
                
            }
            
        }
    }
}

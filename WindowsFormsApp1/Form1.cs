﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verifica("hashsa");
        }
        public void verifica(string filename)
        {
            StreamReader sr = new StreamReader(@"./dati.csv");
            string line;
            line = sr.ReadLine();
            char[] recordo = line.ToCharArray();
            int cont = recordo.Length;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                recordo = line.ToCharArray();
                if (cont == recordo.Length)
                {
                    MessageBox.Show("tutti i record sono di lunghezza uguale");
                    return;
                }
                
            }
            MessageBox.Show("i record sono di lunghezza diversa");
            return;
        }
    }
}

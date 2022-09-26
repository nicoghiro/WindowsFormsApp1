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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int verifica(int modo)
        {
            string line;
            var f = new FileStream(@"./dati.csv", FileMode.Open, FileAccess.ReadWrite);
            int ver = 1;
            byte[] br;
            int recordlenght=0;
            f.Seek(0, SeekOrigin.Begin);
            BinaryReader reader = new BinaryReader(f);
            while (ver != 1&&f.Position<f.Length)
            {
                br = reader.ReadBytes(1);
                line = Encoding.ASCII.GetString(br, 0, 1);
                if (line == "#" && modo == 1)
                {
                    f.Close();
                    return recordlenght;
                }

                if (line == "#" && modo==0)
                {
                    MessageBox.Show(line);
                    string popi = Convert.ToString(recordlenght);
                    MessageBox.Show(popi);
                    ver++;
                    while(f.Position < f.Length) { 
                    f.Seek(recordlenght, SeekOrigin.Current);
                        
                    br = reader.ReadBytes(1);
                    line = Encoding.ASCII.GetString(br, 0, br.Length);
                        if (line == "#")
                        {
                            string lungh=Convert.ToString(f.Position);
                            MessageBox.Show(lungh);
                            
                        }
                        else
                        {
                            MessageBox.Show("i record sono di lunghezza diversa");
                            
                            f.Close();
                            return recordlenght;
                        }
                        
                        
                        

                        
                                
                    }
                   
                }
                else
                {
                    
                    recordlenght++;
                }
            }
            if (ver == 1)
            {
                MessageBox.Show("i record sono lunghi uguali");
                f.Close();
                return recordlenght;
            }
            else
            {
                MessageBox.Show("i record sono lunghezza diversa");
                f.Close();
                return recordlenght;
            }
                        
        }
        public void button2_Click(object sender, EventArgs e)
        {
            verifica(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int lunghezza= verifica(1);
            string lung = Convert.ToString(lunghezza);
            MessageBox.Show(lung);
        }
    }
}

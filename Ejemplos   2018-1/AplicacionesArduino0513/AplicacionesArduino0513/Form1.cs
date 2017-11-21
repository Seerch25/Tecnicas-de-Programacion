using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AplicacionesArduino0513
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;
        StreamReader sr;
        FileStream fs;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog = new SaveFileDialog();
                if( saveFileDialog.ShowDialog() == DialogResult.OK  )
                {
                    fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine(txt_ingresa.Text);
                }
                


            }
            catch (IOException error)
            {
                MessageBox.Show("Error " + error.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                
            }

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    txt_mostrar.Text= sr.ReadLine();

                }

            }
            catch (IOException error)
            {
                MessageBox.Show("Error " + error.Message);
            }
        
            finally
            {
                sr.Close();
                fs.Close();
            }
        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperatura FormTemperatura = new Temperatura();
            FormTemperatura.MdiParent = this;
            FormTemperatura.Show();
        }
    }
}

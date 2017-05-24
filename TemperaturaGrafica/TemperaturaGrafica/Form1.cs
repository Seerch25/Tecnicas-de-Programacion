using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace TemperaturaGrafica
{
    public partial class Form1 : Form
    {
        private SerialPort miPuerto;
        private int temperatura_leida;
        private int tiempo;
        Random aleatorio = new Random();
        public Form1()
        {

             InitializeComponent();
            tiempo_adquisicion.Start();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            cmb_puertos.Items.AddRange(puertos);
            configurarToolStripMenuItem.Enabled = false;

        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                miPuerto = new SerialPort();
                miPuerto.BaudRate = 9600;
                miPuerto.PortName = cmb_puertos.SelectedItem.ToString();
                miPuerto.Open();
                iniciarToolStripMenuItem.Enabled = false;
                tiempo_adquisicion.Start();
                detenerToolStripMenuItem.Enabled = true;
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);

            }
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaArduino pruebaArduino = new PruebaArduino(miPuerto);
            pruebaArduino.Show();

        }

        private void tiempo_adquisicion_Tick(object sender, EventArgs e)
        {
            /*
            temperatura_leida = miPuerto.ReadByte();
            dgv_tiempo_temperatura.Rows.Add(tiempo, temperatura_leida );
            cht_graficar.Series["tiempo_temperatura"].Points.AddXY(tiempo, temperatura_leida);
            tiempo++;
            */
            int valor = aleatorio.Next(100);
            MessageBox.Show(valor.ToString());

        }

        private void detenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tiempo_adquisicion.Stop();
            miPuerto.Close();
            iniciarToolStripMenuItem.Enabled = true;
            detenerToolStripMenuItem.Enabled = false;
        }

        string dato = "";
        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            StreamReader sr = null;
            if( openfile.ShowDialog()  == DialogResult.OK  )
            {
                sr = new StreamReader(openfile.FileName);
                dato = sr.ReadLine();
                while( dato != null  )
                {
                    string[] datos = dato.Split(new char[] { '\t' }, 2);

                    dgv_tiempo_temperatura.Rows.Add(datos[0], datos[1]);
                    dato = sr.ReadLine();
                }

                sr.Close();

            }




            /*
            OpenFileDialog open = new OpenFileDialog();
            StreamReader sr = null;
            

            if (open.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(open.FileName);

                dato = sr.ReadLine();
                while(dato != null)
                {
                    string[] cadena = dato.Split(new char [] { '\t'},2);
                    dgv_tiempo_temperatura.Rows.Add(cadena[0], cadena[1]);
                    dato = sr.ReadLine();
                }
                

                sr.Close();
            }
            */
        }

        private void graficarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            for( int i=0; i < dgv_tiempo_temperatura.Rows.Count; i++ )
            {
                cht_graficar.Series["tiempo_temperatura"].Points.AddXY(dgv_tiempo_temperatura[0, i].Value, dgv_tiempo_temperatura[1, i].Value);
            }
            
            
            
            
            


            /*
            int j = dgv_tiempo_temperatura.Columns.Count;
            for(int i = 0;  i < dgv_tiempo_temperatura.Rows.Count; i++)
            {             
                    cht_graficar.Series["tiempo_temperatura"].Points.AddXY(dgv_tiempo_temperatura[0,i].Value, dgv_tiempo_temperatura[1,i].Value);              

            }
            */
     
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = " txt, tp | *.txt, *.tp  ";
            StreamWriter sw = null;
            if( savefile.ShowDialog() == DialogResult.OK  )
            {
                sw = new StreamWriter(savefile.FileName);

                for( int i =0; i < dgv_tiempo_temperatura.Rows.Count; i++)
                {
                    sw.WriteLine( dgv_tiempo_temperatura[0,i].Value + "," + dgv_tiempo_temperatura[1,i].Value);
                }

                sw.Close();

            }
            
            
            
            /*
            SaveFileDialog save = new SaveFileDialog();

            StreamWriter sw;

            if(save.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(save.FileName);
                sw.WriteLine("x\tf(x)");

                for (int i = 0; i < dgv_tiempo_temperatura.Rows.Count; i++)
                {
                    sw.WriteLine(dgv_tiempo_temperatura[0, i].Value + "\t" + dgv_tiempo_temperatura[1, i].Value);
                }

                sw.Close();
            }
            */
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePdf = new SaveFileDialog();
            savePdf.Filter = "pdf | *.pdf";
            savePdf.Title = "Exportando a PDF";

            if (savePdf.ShowDialog() == DialogResult.OK)
            {
                Document documento = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter pdfescribe = PdfWriter.GetInstance(documento, new FileStream(savePdf.FileName, FileMode.Append));
                documento.Open();

                MemoryStream memoriaFlujo = new MemoryStream();
                cht_graficar.SaveImage(memoriaFlujo, ChartImageFormat.Png);
                iTextSharp.text.Image GraficaImagenText = iTextSharp.text.Image.GetInstance(memoriaFlujo.GetBuffer());
                documento.Add(GraficaImagenText);
                documento.Close();

            }
            
            
            
            /*
            SaveFileDialog  savePdf = new SaveFileDialog();
            
            savePdf.Filter = "pdf| *.pdf";
            savePdf.Title = "Exportando a pdf";
            if (savePdf.ShowDialog() == DialogResult.OK)
            {
                string path = savePdf.FileName;

                Document documento = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter documentoPDF = PdfWriter.GetInstance(documento, new FileStream(path, FileMode.Append));
                documento.Open();                
                var MemoriaImage = new MemoryStream();
                cht_graficar.SaveImage(MemoriaImage, ChartImageFormat.Png);
                iTextSharp.text.Image Grafimagen = iTextSharp.text.Image.GetInstance(MemoriaImage.GetBuffer());
                documento.Add(Grafimagen);
                documento.Close();
                
            }

    */

        }
    }
}

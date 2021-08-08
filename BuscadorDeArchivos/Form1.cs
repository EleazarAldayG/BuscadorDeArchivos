using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BuscadorDeArchivos
{
    public partial class Form1 : Form
    {
        String patronBusqueda = @"(fisico|físico|financiero|\.\.\.|60|fin|fis)";
        String rutaFolderBusqueda,rutaFolderResultado,rutaPosibleCoincidencia;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogFolderBusqueda = new FolderBrowserDialog();
            dialogFolderBusqueda.Description = "Elige el folder a utilizar";
            DialogResult resultFolderBusqueda = dialogFolderBusqueda.ShowDialog();
            if (resultFolderBusqueda == DialogResult.OK)
            {
                RutaFolderBusqueda.Text = dialogFolderBusqueda.SelectedPath;
                rutaFolderBusqueda = RutaFolderBusqueda.Text;
                Console.WriteLine("Se selecciono la ruta de busqueda: " + rutaFolderBusqueda);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogFolderBusqueda = new FolderBrowserDialog();
            dialogFolderBusqueda.Description = "Elige el folder a utilizar";
            DialogResult resultFolderBusqueda = dialogFolderBusqueda.ShowDialog();
            if (resultFolderBusqueda == DialogResult.OK)
            {
                RutaFolderResultado.Text = dialogFolderBusqueda.SelectedPath;
                rutaFolderResultado = RutaFolderResultado.Text;
                Console.WriteLine("Se selecciono la ruta de resultado: " + rutaFolderResultado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(rutaFolderBusqueda == null || rutaFolderResultado == null || rutaFolderBusqueda.Length < 2 || rutaFolderResultado.Length < 2)
            {
                MessageBox.Show("Actualiza las carpetas de búsqueda y de resultados", "¡No has elegido un folder!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Regex rgxs = new Regex(patronBusqueda);
                logBox.AppendText("Iniciando búsqueda en: " + rutaFolderBusqueda + Environment.NewLine);
                //definirFolderPosibleCoincidencia();
                System.IO.Directory.CreateDirectory(rutaPosibleCoincidencia);
                numeroCoincidenciasEncontradas.Text = "0";
                numeroFolderRevisados.Text = "0";
                numeroArchivosRevisados.Text = "0";
                button3.Text = "Buscando ...";
                buscarArchivos(rgxs, rutaFolderBusqueda);
                button3.Text = "Iniciar otra búsqueda";
                MessageBox.Show("Búsqueda finalizada", "Revisa el folder de resutados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logBox_DoubleClick(object sender, EventArgs e)
        {
            logBox.AppendText("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patronBusqueda = @textoPatronBusqueda.Text;
            Console.WriteLine("Se cambio el patron de busqueda a: " + patronBusqueda);
        }

        /*private void definirFolderPosibleCoincidencia()
        {
            rutaPosibleCoincidencia = rutaFolderResultado + @"\PosibleCoincidencia";
        }*/

        private void buscarArchivos(Regex rgxs, string rutaDeBusquedaActual)
        {
            string fileName = "";
            string destFile = "";

            try
            {
                
                numeroFolderRevisados.Text = (Int32.Parse(numeroFolderRevisados.Text) + 1).ToString();
                foreach (string f in Directory.GetFiles(rutaDeBusquedaActual))
                {
                    numeroArchivosRevisados.Text = (Int32.Parse(numeroArchivosRevisados.Text) + 1).ToString();
                    if (rgxs.IsMatch(f))
                    {
                        logBox.AppendText("Encontró " + f + Environment.NewLine);
                        numeroCoincidenciasEncontradas.Text = (Int32.Parse(numeroCoincidenciasEncontradas.Text) + 1).ToString();
                        fileName = Path.GetFileName(f);
                        destFile = Path.Combine(rutaFolderResultado, fileName);
                        if (File.Exists(destFile))
                        {
                            destFile = System.IO.Path.Combine(rutaFolderResultado, (fileName +  "_" + numeroArchivosRevisados.Text));
                        }
                        File.Copy(f, destFile);
                    }
                }

                foreach (string d in Directory.GetDirectories(rutaDeBusquedaActual))
                {
                    buscarArchivos(rgxs, d);
                }
            }
            catch (System.Exception excpt)
            {
                logBox.AppendText("ERROR EN  " + fileName + "|" + rutaDeBusquedaActual + Environment.NewLine);
                Console.WriteLine(excpt.Message);
            }
        }
    }
}

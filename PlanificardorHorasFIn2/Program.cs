using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanificardorHorasFIn2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.IO.Directory.Exists(@"c:\PDM") == false)
            {
                System.IO.Directory.CreateDirectory(@"C:\PDM");

            }
            if (System.IO.File.Exists("C:\\PDM\\dbpdm.s3db") == false)
            {
                new clsDiasFeriados().crearTablaDiasFeriados();
            }
            
           // MessageBox.Show(conexion.conectar().ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPlanificador());
        }
    }
}

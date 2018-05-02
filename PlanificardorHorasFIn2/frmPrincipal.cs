using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanificardorHorasFIn2
{
    public partial class frmPlanificador : Form
    {

        List<CheckBox> chk = new List<CheckBox>();//Lista de los checkbox para asignarles un número
        List<int> seleccionados = new List<int>();//Lista de los días seleccionados
        public frmPlanificador()
        {
            InitializeComponent();
            cargarDias();

        }
        public void cargarDias()
        {
            chk.Add(chkLunes);
            chk.Add(chkMartes);
            chk.Add(chkMiercoles);
            chk.Add(chkJueves);
            chk.Add(chkViernes);
            chk.Add(chkSabado);
            chk.Add(chkDomingo);
   
        }
        public void cargarSeleccionados()//Método que carga los seleccionados en una lista
        {
            seleccionados.Clear();
            foreach (var item in chk)
            {
                if (item.Checked == true)
                {

                    seleccionados.Add(chk.IndexOf(item));
                }
            }
        }
             
      

        private void button1_Click(object sender, EventArgs e)
        {
            cargarSeleccionados();
            
            for (int i = 0; i < 1; i++)
            {

             for (int s = 0; s < seleccionados.Count; s++)
                {    if (s+1>seleccionados.Count-1)
                    {
                        break;
                    }
                    else
                    {

                   dateTimePicker1.Value= dateTimePicker1.Value.AddDays(seleccionados[s+1]- seleccionados[s]);
                        i++;
                    }

                 }
                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(7- seleccionados[seleccionados.Count-1]);
                i++;
            }
          
        }

        private void chkLunesViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLunesViernes.Checked == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    chk[i].Checked = true;
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    chk[i].Checked = false;
                }
            }
        }
    }
}

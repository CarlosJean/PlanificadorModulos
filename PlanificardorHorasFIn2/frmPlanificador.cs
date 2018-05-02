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
       
        List<int> seleccionados = new List<int>();
        public frmPlanificador()
        {
            InitializeComponent();
            new Principal().cargarDias(new CheckBox[] { chkLunes, chkMartes, chkMiercoles, chkJueves, chkViernes, chkSabado, chkDomingo });
            reestablecer();
          
        }
        public void reestablecer()
        {
            dtpHoraFin.Value = Convert.ToDateTime("14:00");
            dtpHoraInicio.Value = Convert.ToDateTime("8:00");
            chkLunesViernes.Checked = true;
            chkLunesViernes.Checked = false;
            chkSabado.Checked = false;
            chkDomingo.Checked = false;
            lstHorasSemana.Items.Clear();
            txtFechaFinalizaciion.Clear();
            txtDias.Clear();
            txtHorasExtras.Clear();
            nudHoras.Value=nudHoras.Minimum;
            lsbxDiasFeriados.Items.Clear();

        }

        private void chkLunesViernes_CheckedChanged(object sender, EventArgs e)
        {
            new Principal().seleccionarLunesViernes(chkLunesViernes);
        }

        bool valido = true;
        public bool diaSemana()//Método para verificar si el dia seleccionado en el datetimepicker está dentro de los seleccionados
        {
            
           
            /*   foreach (var seleccionado in seleccionados)
            {

                if (Convert.ToInt32(dateTimePicker1.Value.DayOfWeek)-1 != seleccionado)
                {
                    valido = false;
                }
                else
                {
                    valido = true;
                }
               
          
            }*/
            return valido;
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(nudHoras.Value) >= Convert.ToDouble(Convert.ToDouble(dtpHoraFin.Value.Hour) - Convert.ToDouble(dtpHoraInicio.Value.Hour)))
                {
                    if (dtpHoraFin.Value.Hour > dtpHoraInicio.Value.Hour)
                    {
                        lstHorasSemana.Items.Clear();
                        lsbxDiasFeriados.Items.Clear();
                        new Principal().calculo(dtpHoraInicio, dtpHoraFin, nudHoras, seleccionados, dateTimePicker1, txtDias, txtHorasExtras, txtFechaFinalizaciion, lstHorasSemana,lsbxDiasFeriados);
                    }
                    else
                    {
                        MessageBox.Show("Hora de finalización es menor a la hora de inicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("El total de horas es menor a las horas diarias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Debe seleccionar los días que se imparte el módulo.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }

      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            new frmDiasFeriados().Show();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            n = 0;
            Clipboard.SetDataObject(txtFechaFinalizaciion.Text);
            timer1.Start();
        }
        int n;
        private void timer1_Tick(object sender, EventArgs e)
        {
            n+=5;
            label1.Visible = true;
            if (n==100)
            {
                timer1.Stop();
                label1.Visible = false;
            
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            reestablecer();
        }
    }
}

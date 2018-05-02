using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlanificardorHorasFIn2
{
    public partial class frmDiasFeriados : Form
    {
        DataTable dt = null;
        public frmDiasFeriados()
        {
            InitializeComponent();
            /*cmbDesde.Items.Add("Todo el día");
            for (int i = 8; i < 21; i++)
            {
                cmbDesde.Items.Add(string.Format(i.ToString()+":00"));
            }
            cmbDesde.SelectedIndex = 0;*/
           
            cargarDiasFeriados();
            dtpDesde.Value =Convert.ToDateTime("12:00");
            

        }

        public void llenarListadoFeriados()//Llena la lista de feriados que est´en la clase 'Principal'
        {

            Principal.feriados.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                new Principal().mantenimientoFeriados(row.Cells[1].Value.ToString());
            }
        }
        public void cargarDiasFeriados()
        {
            
            dt = new clsDiasFeriados().consultar();
            dataGridView1.DataSource = dt;
            if (dataGridView1.RowCount>0)
            {
            dataGridView1.Columns[0].Visible = false;

            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                monthCalendar1.AddBoldedDate(Convert.ToDateTime(row.Cells[1].Value.ToString()));
          
            }
            llenarListadoFeriados();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime feriadoSeleccionado;
            feriadoSeleccionado = Convert.ToDateTime(monthCalendar1.SelectionStart.ToShortDateString());
            monthCalendar1.AddBoldedDate(feriadoSeleccionado);
            monthCalendar1.UpdateBoldedDates();

            // new Principal().mantenimientoFeriados(feriadoSeleccionado.ToShortDateString());

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString() == feriadoSeleccionado.ToShortDateString())
                {
                    new clsDiasFeriados().eliminar(monthCalendar1.SelectionStart.ToShortDateString());
                }
            }
            new clsDiasFeriados().insertar(new string[] {feriadoSeleccionado.ToShortDateString(),dtpDesde.Value.ToString("HH:mm")});
            cargarDiasFeriados();
          
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
         //   MessageBox.Show(monthCalendar1.SelectionStart.ToShortDateString());
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            new clsDiasFeriados().eliminar(monthCalendar1.SelectionStart.ToShortDateString());
            cargarDiasFeriados();
            monthCalendar1.RemoveBoldedDate(Convert.ToDateTime(monthCalendar1.SelectionStart.ToShortDateString()));
            monthCalendar1.UpdateBoldedDates();
           // llenarListadoFeriados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Principal.feriados.Count; i++)
            {
                MessageBox.Show(Principal.feriados[i].ToString());
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime str = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            monthCalendar1.SelectionStart = str;
        }
    }
}

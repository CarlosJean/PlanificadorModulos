using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Collections;
namespace PlanificardorHorasFIn2
{
    class Principal
    {


        DataTable dt = null;
        List<string> al= new List<string>();//Variable que almacena la cantidad de horas por semana.
        double horasSemana;
        List<string> diasFeriados = new List<string>(); //Lista que almacena los días feriados para ser mostrados en los resultados
        public static List<System.Windows.Forms.CheckBox> chk = new List<System.Windows.Forms.CheckBox>();//Lista de los checkbox para asignarles un número
        public static List<string> feriados = new List<string>();
        public void cargarDias(System.Windows.Forms.CheckBox[] chkDias)
        {

            chk.Add(chkDias[0]);
            chk.Add(chkDias[1]);
            chk.Add(chkDias[2]);
            chk.Add(chkDias[3]);
            chk.Add(chkDias[4]);
            chk.Add(chkDias[5]);
            chk.Add(chkDias[6]);

        }
        public void cargarSeleccionados(List<int>seleccionados)//Método que carga los seleccionados en una lista
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

        public void seleccionarLunesViernes(System.Windows.Forms.CheckBox chkLunesViernes)//Método para seleccionar los días de lunes a viernes 
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

        double horasExtras;//Almacena los días en tipo entero para tomar las horas extras
        double dias;
        public void obtenerHorasExtras(double CalculoDias) //Separa los decimales en dos partes
        {
           
            String[] valor=Convert.ToString(CalculoDias).Split(Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
           
            
            dias = Convert.ToInt32(valor[0]);
            if (valor.Length > 1)
            {
                horasExtras = Convert.ToDouble("0." + valor[1].ToString())*horasDiarias;
            }
            else
            {
                horasExtras = 0;
            }
           
        }


        //double calculoDias;
        double diaParaMostrar; //Variable que almacena el día que debe mostrar en el textbox como resultado final
        double horasDiarias; // Variable que almacena la cantidad de horas diarias
        public double cantidadDias(DateTimePicker dtpInicio, DateTimePicker dtpFin,NumericUpDown horas)
        {
           
            horasDiarias = Convert.ToDouble(dtpFin.Value.Hour)-Convert.ToDouble(dtpInicio.Value.Hour);
            double  calculoDias = Convert.ToDouble(horas.Text) / horasDiarias;
            
            obtenerHorasExtras(calculoDias);
            diaParaMostrar = dias;
            if (Convert.ToDouble(horas.Text) % horasDiarias!=0)
            { dias += 1;}
            return dias;
        }
        double horasImpartidas;//Variable que almacena las horas impartidas.

        bool f;
        public void calculo(DateTimePicker dtpInicio, DateTimePicker dtpFin, NumericUpDown horas, List<int>seleccionados,DateTimePicker dtp, TextBox cDias, TextBox txthorasExtras,TextBox txtFechaFin,ListBox horasporSemana,ListBox lstDiasFeriados)//Método que calcula la fecha de finalización
        {
            dt = new clsDiasFeriados().consultar();//Carga los días feriados en un datatable
            double cantidadDias = this.cantidadDias(dtpInicio,dtpFin,horas);//Determina la cantidad de días
            cargarSeleccionados(seleccionados);//Carga en una lista los días seleccionados
            string fechaInicio = dtp.Value.ToShortDateString();//Almacena la fecha de inicio para ser mostrada una vez se realice la operación
            chequearDiasFeriados(dtp);
            if (chequearFecha(dtp) == true && Convert.ToDateTime(Convert.ToDateTime(stringArr[2].ToString()).ToString("HH:mm")) <= Convert.ToDateTime(dtpInicio.Value.ToString("HH:mm")))
            {

                MessageBox.Show("Este es un día feriado, seleccione otro.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (seleccionados.Contains(Convert.ToInt32(diaSeleccionado(dtp))) ==false)
            {
                MessageBox.Show("Debe seleccionar un día que está dentro de los seleccionados.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtFechaFin.Clear();
                txthorasExtras.Clear();
                cDias.Clear();
            }
            else
            {
                if (chequearFecha(dtp) == true)
                {
                    f = false;
                }
                else
                {
                    f = true;
                }
                for (int i = Convert.ToInt32(f); i <= cantidadDias;i++ )
                {
                   
                    for (int s = diaSeleccionado(dtp); s < seleccionados.Count - 1; s++)
                    {
                        if (s + 1 > seleccionados.Count - 1) //Si llegó al último día de la semana hace el salto
                        {
                            break;

                        }
                        else
                        {
                            if (i >= cantidadDias )
                             {
                                if (chequearDiasFeriados(dtp) == false || Convert.ToDateTime(Convert.ToDateTime(stringArr[2].ToString()).ToString("HH:mm")) >= Convert.ToDateTime(dtpFin.Value.ToString("HH:mm")))
                                {
                                    if (horasExtras==0)
                                    {
                                        horasSemana += horasDiarias;

                                    }
                                    break;
                                }
                                else
                                {
                                    diasFeriados.Add(dtp.Value.ToShortDateString());
                                  //  i--;
                                    cantidadDias++;
                                    //break;
                                }

                            }
                            else
                            {
                                if (chequearDiasFeriados(dtp) == false)
                                {
                                    
                                    horasImpartidas += horasDiarias;
                                    i++;
                                    if (i >= cantidadDias && horasImpartidas >= Convert.ToDouble(horas.Value))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        horasSemana += horasDiarias;
                                    }
                                   
                                    
                                    
                                   
                                }
                                else
                                {
                                    diasFeriados.Add(dtp.Value.ToShortDateString());
                                    if (Convert.ToDateTime(Convert.ToDateTime(stringArr[2].ToString()).ToString("HH:mm")) >= Convert.ToDateTime(dtpFin.Value.ToString("HH:mm")))
                                    {
                                        i++;
                                        horasSemana += horasDiarias;
                                        horasImpartidas += horasDiarias;

                                    }
                                    else if (TimeSpan.Parse(stringArr[2]).TotalHours > TimeSpan.Parse(dtpInicio.Value.ToString("HH:mm")).TotalHours)
                                    {
                                        //diasFeriados.Add(dtp.Value.ToShortDateString());
                                        horasExtras += Convert.ToDouble(TimeSpan.Parse(dtpFin.Value.ToString("HH:mm")).TotalHours) - Convert.ToDouble(TimeSpan.Parse(stringArr[2]).TotalHours.ToString());

                                        if (horasExtras > horasDiarias)
                                        {
                                            cantidadDias++;
                                            diaParaMostrar++;
                                            horasExtras -= horasDiarias;
                                        }
                                        i++;
                                        // horasSemana += horasExtras;
                                        //MessageBox.Show(horasSemana.ToString());
                                        horasSemana += horasDiarias - (Convert.ToDouble(TimeSpan.Parse(dtpFin.Value.ToString("HH:mm")).TotalHours) - Convert.ToDouble(TimeSpan.Parse(stringArr[2]).TotalHours.ToString()));
                                        MessageBox.Show(horasSemana.ToString());
                                        horasImpartidas += horasDiarias - (Convert.ToDouble(TimeSpan.Parse(dtpFin.Value.ToString("HH:mm")).TotalHours) - Convert.ToDouble(TimeSpan.Parse(stringArr[2]).TotalHours.ToString()));

                                    }

                                }
                                }
                         dtp.Value = dtp.Value.AddDays(seleccionados[s + 1] - seleccionados[s]);
                        }

                    }
                    if (i < cantidadDias)//Hace el salto a la siguiente semana
                    {
                        if (chequearDiasFeriados(dtp) == true)
                        {
                          diasFeriados.Add(dtp.Value.ToShortDateString());
                          cantidadDias++;
                        }
                        else
                        {
                           horasSemana += horasDiarias;
                            horasImpartidas += horasDiarias;

                        }
                        al.Add(Math.Round(horasSemana, 2).ToString());
                        horasSemana = 0;
                        dtp.Value = dtp.Value.AddDays((7 - seleccionados[seleccionados.Count - 1]) + seleccionados[0]);
                    }
                    else
                    {
                        if (chequearDiasFeriados(dtp) == false || Convert.ToDateTime(Convert.ToDateTime(stringArr[2].ToString()).ToString("HH:mm")) >= Convert.ToDateTime(dtpFin.Value.ToString("HH:mm")))
                        {
                            if (horasExtras == 0)
                            {
                                horasSemana += horasDiarias;
                                horasImpartidas += horasDiarias;

                            }
                            else
                            { 
                            
                            horasSemana += horasExtras;
                            horasImpartidas += horasExtras;
                            }

                            al.Add(Math.Round(horasSemana, 2).ToString());
                            horasSemana = 0;

                            break;

                        }
                        else
                        {
                            diasFeriados.Add(dtp.Value.ToShortDateString());
                        }
                    
                    }

                    if (chequearDiasFeriados(dtp) == true) //Verifica si el día que finalizó el módulo es feriado. Esto está de más
                    {
                        if (Convert.ToDateTime(Convert.ToDateTime(stringArr[2].ToString()).ToString("HH:mm")) >= Convert.ToDateTime(dtpFin.Value.ToString("HH:mm")))
                        {
                            i++;
                            horasSemana += horasDiarias;
                            horasImpartidas += horasDiarias;
                        }


                        else if (TimeSpan.Parse(stringArr[2]).TotalHours > TimeSpan.Parse(dtpInicio.Value.ToString("HH:mm")).TotalHours)
                        {
                            if (diasFeriados.Contains(dtp.Value.ToShortDateString()) == false)
                            {
                                diasFeriados.Add(dtp.Value.ToShortDateString());

                            }

                            horasExtras += Convert.ToDouble(TimeSpan.Parse(dtpFin.Value.ToString("HH:mm")).TotalHours) - Convert.ToDouble(TimeSpan.Parse(stringArr[2]).TotalHours.ToString());

                            if (horasExtras > horasDiarias)
                            {
                                cantidadDias++;
                                diaParaMostrar++;
                                horasExtras -= horasDiarias;
                                horasSemana += horasExtras;
                            }

                            horasSemana += horasDiarias - (Convert.ToDouble(TimeSpan.Parse(dtpFin.Value.ToString("HH:mm")).TotalHours) - Convert.ToDouble(TimeSpan.Parse(stringArr[2]).TotalHours.ToString()));

                            al.Add(Math.Round(horasSemana, 2).ToString());
                            horasSemana = 0;

                            horasImpartidas += horasDiarias - (Convert.ToDouble(TimeSpan.Parse(dtpFin.Value.ToString("HH:mm")).TotalHours) - Convert.ToDouble(TimeSpan.Parse(stringArr[2]).TotalHours.ToString()));

                        }
                        /*else
                         {
                             i--;
                            cantidadDias++;
                             continue;

                         }*/



                    }
                    /*else if (chequearDiasFeriados(dtp)==false)
                    {
                        i++;
                        horasSemana += horasDiarias;
                        if (i<cantidadDias)
                        {
                            MessageBox.Show("NUnca");
                            break;
                        }
                        al.Add(Math.Round(horasSemana, 2).ToString());

                    }*/



                }
                cDias.Text = diaParaMostrar.ToString(); //Muestra la cantidad de días
                txthorasExtras.Text = TimeSpan.FromHours(Convert.ToDouble(horasExtras.ToString())).ToString();//Muestra las horas extras
                txtFechaFin.Text = dtp.Value.ToShortDateString();//Muestra la fecha de finalización
                dtp.Value = Convert.ToDateTime(fechaInicio); //Muestra la fecha de inicio del módulo
                for (int i = 0; i < al.Count; i++)
                {

                  horasporSemana.Items.Add((i+1).ToString()+") "+al[i]);
                }
                //MessageBox.Show(horasImpartidas.ToString());
             
                for (int i = 0; i < diasFeriados.Count; i++)
                {
                    lstDiasFeriados.Items.Add(diasFeriados[i]);
                }
            }
        }
        
        string[] stringArr;
        public bool chequearDiasFeriados(DateTimePicker dtp) //Método que chequea si la fecha tocada es feriado
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    for (int numeroFila = 0; numeroFila < dt.Rows.Count; numeroFila++)
                    {
                        stringArr = dt.Rows[numeroFila].ItemArray.Select(x => x.ToString()).ToArray();
                        if (stringArr[1].ToString() == dtp.Value.ToShortDateString())
                        {
                            return true;
                        }
                    }

                }

            }
            catch (NullReferenceException)
            {

                //throw;
            }

            return false; 
        }

            int diadeSemana;
        public int diaSeleccionado(DateTimePicker dtp) //Método que retorna el dia seleccionado en el calendario
        {
            if (Convert.ToInt32(dtp.Value.DayOfWeek) == 0)
            {
                diadeSemana = 6;
            }
            else if(Convert.ToInt32(dtp.Value.DayOfWeek) == 1)
            {
                diadeSemana = 0;
            }
            else if (Convert.ToInt32(dtp.Value.DayOfWeek) == 2)
            {
                diadeSemana = 1;
            }
            else if (Convert.ToInt32(dtp.Value.DayOfWeek) == 3)
            {
                diadeSemana = 2;
            }
            else if (Convert.ToInt32(dtp.Value.DayOfWeek) == 4)
            {
                diadeSemana = 3;
            }
            else if (Convert.ToInt32(dtp.Value.DayOfWeek) == 5)
            {
                diadeSemana = 4;
            }
            else if (Convert.ToInt32(dtp.Value.DayOfWeek) == 6)
            {
                diadeSemana = 5;
            }
            return diadeSemana;

        }

        public bool chequearFecha(DateTimePicker dtp) //Avisa si el día seleccionado es un  dia feriado todo el día
        {
            try
            {
                if (stringArr[1].ToString() == dtp.Value.ToShortDateString())
                { 
                    return true;
                }
            }
            catch (NullReferenceException)
            {

            //    throw;
            }
        

            return false;
        }

        public void mantenimientoFeriados(string datos)
        {
            feriados.Add(datos);
        }

    }
}

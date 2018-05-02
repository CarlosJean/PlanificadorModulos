using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace PlanificardorHorasFIn2
{
    class clsDiasFeriados
    {
        DataTable dt;
        public void crearTablaDiasFeriados()
        {

                SQLiteConnection cn = conexion.conectar();
            try
            {
                cn.Open();

                SQLiteCommand cmd = new SQLiteCommand("create table tbl_feriados(id integer primary key autoincrement, fecha varchar(20), desde varchar(20) )",cn);

                cmd.ExecuteNonQuery();
             

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            cn.Close();
        }
        public bool insertar(string [] datos)
        {
            try
            {
                string query = "insert into tbl_feriados (fecha,desde) values('"+datos[0]+"','"+datos[1]+"')";
                SQLiteConnection cn = conexion.conectar();
                cn.Open();
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = query ;
            
                if (cmd.ExecuteNonQuery()>0)
                {
                    cn.Close();
                    return true;

                }
               
            }
            catch (Exception ex )
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            return false;
        }

        public DataTable consultar()
        {



            string query = "select * from tbl_feriados order by fecha asc";
            SQLiteConnection cn = conexion.conectar();
            cn.Open();
            SQLiteCommand cmd = cn.CreateCommand();
            cmd.CommandText = query;
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                nombrarColumnas();
            while (reader.Read())
            {
                    dt.Rows.Add(reader["id"].ToString(),reader["fecha"].ToString(),reader["desde"].ToString());
            }

            }


            return dt;
        }

        public bool eliminar(string fecha)
        {
            try
            {
                string query = "delete from tbl_feriados where fecha='" + fecha + "'";
                SQLiteConnection cn = conexion.conectar();
                cn.Open();
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery()>0)
                {
                    cn.Close();
                    return true;
                }
            }
            catch (Exception ex )
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            return false;
        }

        public void nombrarColumnas()
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Desde");
        }
    }
}

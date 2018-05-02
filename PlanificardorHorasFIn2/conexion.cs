using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace PlanificardorHorasFIn2
{
    class conexion
    {
       public static SQLiteConnection conectar()
        {
            string ruta = @"Data source=C:\PDM\dbPDM.s3db;Version=3";
            SQLiteConnection cn = new SQLiteConnection(ruta);
            return cn;
        }
    }
}

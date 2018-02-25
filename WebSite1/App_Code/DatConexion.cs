using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Descripción breve de DatConexion
/// </summary>
public class DatConexion
{
    MySqlConnection conectar = new MySqlConnection();
    public DatConexion()
    {
    }
    public void conexion() {
        conectar.ConnectionString = "server=localhost;Database=ejemasp;user id=root;password=root;pooling=false";
        conectar.Open();

    }
    public DataTable leerDatosEmpleado() {
        DataTable datos = new DataTable();
        conexion();
        MySqlCommand comando = new MySqlCommand("Select * from empleado",conectar);
        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
        DataSet ds = new DataSet();
        adaptador.Fill(ds,"empleado");
        datos = ds.Tables["empleado"];
        conectar.Clone();
        return datos;
    }
  


}
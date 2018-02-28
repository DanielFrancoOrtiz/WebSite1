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
    MySqlConnection conectar;
    public DatConexion()
    {
    }
    public void conexion() {
      
            conectar = new MySqlConnection();
            conectar.ConnectionString = "server=localhost;Database=ejemasp;" +
            "user id=root;password=root;pooling=false";
            conectar.Open();
        

    }
    public DataTable leerDatosEmpleado() {
        DataTable datos = new DataTable();
        conexion();
        MySqlCommand comando = new MySqlCommand("Select * from empleado", conectar);
        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
        DataSet ds = new DataSet();
        adaptador.Fill(ds, "empleado");
        datos = ds.Tables["empleado"];
        conectar.Clone();
        return datos;
    }

    public bool insertarEmpleado(Empleado em) {
      
            conexion();
            MySqlCommand comando = new MySqlCommand("insert into empleado values(null,@nombre_emp,@edad,@direccion,@telefono)", conectar);
            comando.Parameters.AddWithValue("nombre_emp", em.Nombre);
            comando.Parameters.AddWithValue("edad", em.Edad);
            comando.Parameters.AddWithValue("direccion", em.Direccion);
            comando.Parameters.AddWithValue("telefono", em.Telefono);
            comando.ExecuteNonQuery();
            conectar.Clone();
            return true;
        

    }

    public bool actualizarEmpleado(Empleado em)
    {

        conexion();
        MySqlCommand comando = new MySqlCommand("update empleado set nombre_emp = @nombre_emp, edad=@edad," +
            "direccion = @direccion, telefono = @telefono where id = @id", conectar);
        comando.Parameters.AddWithValue("nombre_emp", em.Nombre);
        comando.Parameters.AddWithValue("edad", em.Edad);
        comando.Parameters.AddWithValue("direccion", em.Direccion);
        comando.Parameters.AddWithValue("telefono", em.Telefono);
        comando.Parameters.AddWithValue("id", em.Id);

        comando.ExecuteNonQuery();
        conectar.Clone();
        return true;


    }
    public bool eliminarEmpleado(int id)
    {
        
            conexion();
            MySqlCommand comando = new MySqlCommand("delete from empleado where id=@id", conectar);
            comando.Parameters.AddWithValue("id", id);
            comando.ExecuteNonQuery();
        conectar.Clone();
            return true;
       
    }
    public Empleado buscarEmpleado(int id) {
        conexion();
       
        MySqlDataAdapter objAdapter =
                        new MySqlDataAdapter("select * from empleado where id = " +id, conectar);
        Empleado em = null;
        DataTable resultado = new DataTable();
        
        objAdapter.Fill(resultado);

        if (resultado != null && resultado.Rows.Count > 0)
        {
          
            DataRow fila = resultado.Rows[0];
            em = new Empleado(int.Parse(fila["id"].ToString()),
                fila["nombre_emp"].ToString(),int.Parse(fila["edad"].ToString()),
                fila["direccion"].ToString(),fila["telefono"].ToString());

            return em;
        }

        return null;
    }

}
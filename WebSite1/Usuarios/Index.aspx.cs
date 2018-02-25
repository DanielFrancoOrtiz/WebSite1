using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


public partial class Usuarios_Index : System.Web.UI.Page
{
    DatConexion obj = new DatConexion();

    protected void Page_Load(object sender, EventArgs e)
    {
        //llenar los datos
        GridView1.DataSource = obj.leerDatosEmpleado();
        GridView1.DataBind();

    }

}








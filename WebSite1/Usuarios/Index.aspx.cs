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


    protected void btnEditar_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.ToString() != null)
        {
            if (TextBox1.Text.Length > 0)
            {
                Response.Redirect("wfrmEmpleado.aspx?id=" + TextBox1.Text);
            }
        }

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
       
        obj.eliminarEmpleado(Convert.ToInt32(TextBox1.Text));
        Response.Redirect("Index.aspx");
    }
}








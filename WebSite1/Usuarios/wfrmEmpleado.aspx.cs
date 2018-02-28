using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Usuarios_wfrmEmpleado : System.Web.UI.Page
{
    int idEmpleado = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"]!=null)
        {
            if (Request.QueryString["id"].Length > 0)
            {
                idEmpleado = Convert.ToInt32(Request.QueryString["id"]);
                //Response.Write(idEmpleado);
                Button1.Text = "Actualizar";
                Empleado em = dao.buscarEmpleado(idEmpleado);
                if (em != null) {
                    lblId.Text = em.Id.ToString();
                    lblNonAnt.Text = "Nombre anterior : " + em.Nombre;
                    lblEdadAnt.Text = "Edad anterior: " + em.Edad;
                    lblDirAnt.Text = "Direccion anterior: " + em.Direccion;
                    lblTelAnt.Text = "Telefono anterior; " + em.Telefono;
                }
            }
        }
        else {
            Button1.Text = "Agregar";
        }
        
    }
    DatConexion dao = new DatConexion();
    protected void Button1_Click(object sender, EventArgs e)
    {
        Empleado emp = new Empleado();
        emp.Nombre = txtNombre.Text;
        emp.Edad = int.Parse(txtEdad.Text);
        emp.Direccion = txtDireccion.Text;
        emp.Telefono = txtTelefono.Text;

        if (Button1.Text.ToString() == "Agregar")
        {
           
            if (dao.insertarEmpleado(emp))
            {
                Response.Redirect("Index.aspx");
            }
            else {
                Response.Write("Error");
            }
        }
        else {
            
            emp.Id = idEmpleado;

            //emp.Nombre = "Nombre";
            //emp.Edad = 30;
            //emp.Direccion = "direccion";
            //emp.Telefono = "453643252464";
            //emp.Id = idEmpleado;


            if (dao.actualizarEmpleado(emp))
            {
                Response.Redirect("Index.aspx");
                
            }
            else {
                Response.Write("Error");
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");

    }
}
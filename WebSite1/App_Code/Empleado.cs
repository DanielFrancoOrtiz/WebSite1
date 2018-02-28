using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Empleado
/// </summary>
public class Empleado
{
    private int id;
    private string nombre;
    private int edad;
    private string direccionn;
    private string telefono;

    public Empleado()
    {
    }
    public Empleado(int id, string nombre, int edad, string direccion, string telefono) {
        this.id = id;
        this.nombre = nombre;
        this.edad = edad;
        this.direccionn = direccion;
        this.telefono = telefono;
    }
    public int Id { get { return id; } set { id = value; } }
    public string Nombre { get { return nombre; }set { nombre = value; } }
    public int Edad { get { return edad; }set { edad = value; } }
    public string Direccion { get { return direccionn; } set { direccionn = value; } }
    public string Telefono { get { return telefono; } set { telefono = value; } }
}
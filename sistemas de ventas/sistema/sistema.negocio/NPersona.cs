using sistema.datos;
using sistema.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.negocio
{
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static DataTable ListarProveedores()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarProveedores();
        }
        public static DataTable ListarClientes()
        {
            DPersona Datos = new DPersona();
            return Datos.ListarClientes();
        }

        public static DataTable Buscar(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(Valor);
        }
        public static DataTable BuscarClientes(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarClientes(Valor);
        }
        public static DataTable BuscarProveedores(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.BuscarProveedores(Valor);
        }
        public static string Insertar(string TipoPersona, string Nombre, string TipoDocumento, string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "Ya existe esta persona.";
            }
            else
            {
                Persona Obj = new Persona();
                Obj.TipoPersona = TipoPersona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Insertar(Obj);
            }


        }
        public static string Actualizar(int Id, string TipoPersona, string Nombre, string TipoDocumento, string NumDocumentoAnt,string NumDocumento, string Direccion, string Telefono, string Email)
        {
            DPersona Datos = new DPersona();
            Persona Obj = new Persona();

            if (NumDocumentoAnt.Equals(NumDocumento))
            {
                Obj.IdPersona = Id;
                Obj.TipoPersona = TipoPersona;
                Obj.Nombre = Nombre;
                Obj.TipoDocumento = TipoDocumento;
                Obj.NumDocumento = NumDocumento;
                Obj.Direccion = Direccion;
                Obj.Telefono = Telefono;
                Obj.Email = Email;
                return Datos.Actualizar(Obj);
            }
            else
            {
                string Existe = Datos.Existe(NumDocumento);
                if (Existe.Equals("1"))
                {
                    return "Hay una persona con ese Documento."+NumDocumento;
                }
                else
                {
                    Obj.IdPersona = Id;
                    Obj.TipoPersona = TipoPersona;
                    Obj.Nombre = Nombre;
                    Obj.TipoDocumento = TipoDocumento;
                    Obj.NumDocumento = NumDocumento;
                    Obj.Direccion = Direccion;
                    Obj.Telefono = Telefono;
                    Obj.Email = Email;
                    return Datos.Actualizar(Obj);


                }
            }


        }
        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }
    }
}

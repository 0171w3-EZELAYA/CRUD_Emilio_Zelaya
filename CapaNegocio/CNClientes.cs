using System.Windows.Forms;
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNClientes //esto nos a a permitir que el usuario ingrese informacion valida.
    {
        CDClientes cDClientes = new CDClientes();

        public bool ValidarDatos(CEClientes clientes)
        {
            bool Resultado = true;
            if (clientes.Nombres == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El nobre es obligatotio");
            }
            if (clientes.Apellidos == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El apellido es obligatorio");
            }
            if (clientes.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La foto es obligatoria");
               
            }
            //else
            //{
            //   Resultado = true;
            // }
            return Resultado;
        }
        public void PruebaMySql() 
        {
            cDClientes.PruebaConexion();
        }
        public void CrearCliente(CEClientes cE)
        {
            cDClientes.Crear(cE);
        }

        // editar cliente
        public void EditarCliente(CEClientes cE)
        {
            cDClientes.Editar(cE);
        }// fin editar

        // Eliminar cliente
        public void EliminarCliente(CEClientes cE)
        {
            cDClientes.Eliminar(cE);
        }// fin editar

        public DataSet ObtenerDatos()
        {
            return cDClientes.Listar();


        }

    }
}

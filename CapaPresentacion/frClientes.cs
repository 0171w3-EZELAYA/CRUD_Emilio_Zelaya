using CapaEntidad; //esto nos da acceso a todas las clases de tipo entidad dentro de este formulario
using CapaNegocio; //
using System.Windows.Forms;//para los formularios de windows

namespace CapaPresentacion
{
    public partial class frClientes : Form
    {
        CNClientes cNClientes = new CNClientes();
        public frClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void btnEliminar_Click(object sender, EventArgs e) //tuve que volverlo a poner
        {
            if (txtID.Value == 0) return;

            if (MessageBox.Show("¿Deseas eliminar el registro","Titulo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                { 
                CEClientes cE = new CEClientes();
                cE.Id = (int)txtID.Value;
                cNClientes.EliminarCliente(cE);
                CargarDatos();//Cargar datos en el Grid
                LimpiarForm(); //limpiar formulario
                }

            
        }
            
        //me dio error este boton de ierda
        //se me elimino el boton de eliminar y me mandba un error

        // funcion del boton nuevo

        private void btnNuevo_Click(object sender, EventArgs e) //este boton nos permite limpiar el formulario
        {
            LimpiarForm();
        }
         // metodo para limpiar el formulario
        private void LimpiarForm()
        {
            txtID.Value = 0; // aqui indicamos que el valor de id se limpie a 0 porque es un int
            txtNombres.Text = string.Empty; // aca indicamos que limpie la cadena del textbox
            txtApellidos.Text = string.Empty; //igual limpiamos la cadena del textbox
            picFoto.Image = null; //aqui limpiamos el picturebox a null

        }

        //cargar una imagen en el picturefoto con el linklabel
        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //Mientras haya un cuadro de dialogo abierto el progrma no ejecutara ningun codigo
            ofdFoto.FileName = string.Empty; //asignamos a filename una cadena vacia.
            //ofdFoto.ShowDialog ();// este es el cuadro de dialogo que agregamos pero no se ve en el formulario
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(ofdFoto.FileName); //esto permite llamar a un archivo y cargarlo en el picturefoto
            }
            ofdFoto.FileName = string.Empty; //volvemos a limpiar el filename
        }

        private void frClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            gridDatos.DataSource = cNClientes.ObtenerDatos().Tables["tbl"]; //para obtener los datos de la tabla
        }
        //funcion del boton guardar, para validar que el cliente ingrese datos correctos.
        private void btnGuardar_Click(object sender, EventArgs e)//BOTON GUARDAR
        {
            bool Resultado;
            CEClientes cEClientes = new CEClientes();
            cEClientes.Id = (int)txtID.Value;
            cEClientes.Nombres = txtNombres.Text;
            cEClientes.Apellidos = txtApellidos.Text;
            cEClientes.Foto = picFoto.ImageLocation;

            Resultado = cNClientes.ValidarDatos(cEClientes);
            if (Resultado == false)
            {
                return;
            }
            //Aqui vamos a validar si estamos creando un cliente nuevo o si estamos editando uno existente
            if (cEClientes.Id == 0)
            {
                cNClientes.CrearCliente(cEClientes);
            }
            else
            {
                cNClientes.EditarCliente(cEClientes);
            }

                //MessageBox.Show("Todo bien vamos a insertar");
                CargarDatos(); //Para que muestre los datos en el Grid al guardar un nuevo registro
            LimpiarForm(); //para que limpie el formulario
        }

        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Value = (int)gridDatos.CurrentRow.Cells["id"].Value;
            txtNombres.Text = gridDatos.CurrentRow.Cells["nombres"].Value.ToString();
            txtApellidos.Text = gridDatos.CurrentRow.Cells["apellidos"].Value.ToString();
            picFoto.Load(gridDatos.CurrentRow.Cells["foto"].Value.ToString());
        }
    }
}
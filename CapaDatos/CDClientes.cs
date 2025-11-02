using CapaEntidad;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDClientes
    {
        string CadenaConexion = "Server=localhost;User=root;Password=123456;Port=3306;database=curso_sc";
        public void PruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse con la base de datos: " + ex.Message);
                return;
            }
            mySqlConnection.Close();
            MessageBox.Show("Conexion Satisfactoria");

        }
        public void Crear(CEClientes cE)
        {// Inicio del crear registro
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "INSERT INTO clientes (Nombres, Apellidos, Foto) VALUES (@Nombres, @Apellidos, @Foto)";
            //esto lo saque de internet por que con el otro metodo me daba error
            using (MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection))
            {
                // Asigna valores a los parámetros
                mySqlCommand.Parameters.AddWithValue("@Nombres", cE.Nombres);
                mySqlCommand.Parameters.AddWithValue("@Apellidos", cE.Apellidos);
                mySqlCommand.Parameters.AddWithValue("@Foto", cE.Foto);

                mySqlCommand.ExecuteNonQuery();
            }

            //MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro creado");
        } // fin del Crear Registro    

        //copiamos el metodo crear para actualiza los registro
        //solo realizarenos unos cambios
        public void Editar(CEClientes cE) //cambiamos el nombre del metodo a Editar
        {// Inicio del editar registro
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "UPDATE clientes SET Nombres = @Nombres, Apellidos = @Apellidos, Foto = @Foto WHERE Id = @Id";
            //esto lo saque de internet por que con el otro metodo me daba error
            using (MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection))
            {
                // Asigna valores a los parámetros
                mySqlCommand.Parameters.AddWithValue("@Nombres", cE.Nombres);
                mySqlCommand.Parameters.AddWithValue("@Apellidos", cE.Apellidos);
                mySqlCommand.Parameters.AddWithValue("@Foto", cE.Foto);
                mySqlCommand.Parameters.AddWithValue("@Id", cE.Id);
                mySqlCommand.ExecuteNonQuery();
            }
            //MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Actualizado");
        } // fin del Editar Registro    



        // aqui empieza el comando eliminar
        public void Eliminar(CEClientes cE) //cambiamos el nombre del metodo a Editar
        {// Inicio del editar registro
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "DELETE FROM clientes WHERE Id = @Id";
            using (MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection))
            {
             // Asigna valores a los parámetros
             mySqlCommand.Parameters.AddWithValue("@Id", cE.Id);
                mySqlCommand.ExecuteNonQuery();
            //mySqlCommand.ExecuteNonQuery();
            }

            //MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
            //mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        } // fin del Crear Registro    

        //aqui termina UPDATE
        public DataSet Listar()
        { //Inicio del listar datos
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            string Query = "SELECT * FROM clientes LIMIT 1000;";//`para que pudiea correr le tuve que quitar las comillas simples 
            MySqlDataAdapter Adaptador;                         //Ya que en esta version las comillas invertidad las toma como un caracter especial
            DataSet dataSet = new DataSet();    
            //El adaptador debera ser una instancia de Sql y recibir 2 parametros el query y la conexion 
            Adaptador = new MySqlDataAdapter(Query, mySqlConnection);
            Adaptador.Fill(dataSet, "tbl");// esto se hace poruqe los tipos de datos pueden cambiar un dataset puede tner una o mas tablas
            return dataSet;
            
        }//Fin del listar datos

    }
}

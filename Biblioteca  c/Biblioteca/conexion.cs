using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{



  
   public  class conexion
    {
        

        SqlConnection con = new SqlConnection("Data Source = usuario-pc\\sqlexpress; Initial Catalog = sesion; Integrated Security = True");
       
        //Login
        public void logear(string usuario, string contrasena)
        {


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select nombre,tipo from usuarios where usuario = @usuario AND pass = @pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new inicioAdmin(dt.Rows[0][0].ToString()).Show();


                    }
                    else if (dt.Rows[0][1].ToString() == "usuario")
                    {
                        new inicio().Show();

                    }

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                    new Form1().Show();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }

        }

        //Insertar Usuario
        public void InsertarUsuario(string nombre, string Apaterno, string Amaterno, string direccion, string telefono, string edad, DateTime ingreso)
        {
            string status = "Activo";
            

            try
            {
                con.Open();
              SqlCommand   cmd = new SqlCommand("insert into usuarios_p (nombre,apaterno,amaterno,direccion,telefono,edad,ingreso,status) values ('"+nombre+"','"+ Apaterno + "','"+ Amaterno+"','"+ direccion + "','"+ telefono + "','"+ edad + "','"+ ingreso + "','" + status + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El registro fue ingresado correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }

        }

        //Validar Usuario
        public int ValidarUsuario(string nombre, string Apaterno, string Amaterno)
        {
            int contador = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from usuarios_p where nombre = " + "'"+ nombre +"'"+  " and apaterno = " + "'" + Apaterno + "'" + " and  amaterno =  " + "'" + Amaterno + "'" + "", con);
               SqlDataReader  dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;

                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("El usuario ya existe " + e.ToString());
                throw;
            }
            return contador;
        }


        //Buscar Usuario
        public DataTable  BuscarUsuario(string nombre, string Apaterno, string Amaterno)
        {
           try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id_persona, nombre,apaterno,amaterno,direccion,telefono,edad,ingreso,status from usuarios_p where nombre = " + "'" + nombre + "'" + " and apaterno = " + "'" + Apaterno + "'" + " and  amaterno =  " + "'" + Amaterno + "'" + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtbuscar = new DataTable();
                da.Fill(dtbuscar);
                return dtbuscar;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("El usuario no se encuentra " + e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }
  }


        //buscar usuario para prestamo

        public DataTable BuscarUsuarioPrestamo(string nombre, string Apaterno, string Amaterno)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select id_persona, nombre,apaterno,amaterno,direccion,telefono,edad,ingreso,status from usuarios_p where nombre = " + "'" + nombre + "'" + " and apaterno = " + "'" + Apaterno + "'" + " and  amaterno =  " + "'" + Amaterno + "'"+ " and status = 'Activo' " + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtbuscar = new DataTable();
                da.Fill(dtbuscar);
                return dtbuscar;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("El usuario no se encuentra " + e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }
        }

        //Modificar Usuario
        public void ModificarUsuario(int id, string nombre, string Apaterno, string Amaterno, string direccion, string telefono, string edad, DateTime ingreso, string status)
        {

            //crear el registro antes de modificar

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into historial(id_persona,nombre_usuario,apaterno_usuario,amaterno_usuario,direccion_usuario,telefono_usuario,edad_usuario,ingreso_usuario,status_usuario) select id_persona,nombre,apaterno,amaterno,direccion,telefono,edad,ingreso,status  from usuarios_p where id_persona = " + "'" + id + "'" + "", con);
                cmd.ExecuteNonQuery();
                con.Close();
               

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }

            //realizzar la modificación

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update usuarios_p set nombre = '" + nombre + "',apaterno = '" + Apaterno  + "', amaterno = '" + Amaterno + "', direccion = '" + direccion  + "', telefono = '" + telefono + "', edad = '" + edad + "', ingreso = '" + ingreso  + "' , status = '" + status + "' where id_persona = '" + id  + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El usuario ha sido modificado correctamente");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            finally
            {
                con.Close();
            }

        }

    }
}

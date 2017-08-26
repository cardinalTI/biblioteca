using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Biblioteca
{
    class metodos_prestamo
    {
        SqlConnection con = new SqlConnection("Data Source = usuario-pc\\sqlexpress; Initial Catalog = sesion; Integrated Security = True");

        //Agregar un nuevo prestamo

        public void generar_prestamo(string codigo_usuario, string codigo_libro, string fecha_prestamo,string status)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into prestamos (codigo_usuario,codigo_libro,fecha_prestamo,status) values ('" + codigo_usuario + "','" + codigo_libro + "','" + fecha_prestamo + "','" + status + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El registro del prestamo fue ingresado correctamente");

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

        //buscar los prestamos realizados

        public DataTable Buscarprestamo(string filtro, string buscar)
        {
            DataTable dtbuscar = new DataTable();

            //Buscar por libro

            if (filtro == "Numero de Usuario")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_prestamo,codigo_usuario,codigo_libro,fecha_prestamo,status from prestamos where codigo_usuario = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
                    con.Close();
                }

                catch (Exception e)
                {
                    MessageBox.Show("El prestamo no se encuentra " + e.ToString());
                    throw;
                }

                finally
                {
                    con.Close();
                }
            }

            //Buscar por Autor
            if (filtro == "Codigo Libro")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_prestamo,codigo_usuario,codigo_libro,fecha_prestamo,status from prestamos where codigo_libro = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
                    con.Close();
                }

                catch (Exception e)
                {
                    MessageBox.Show("El prestamo no se encuentra " + e.ToString());
                    throw;
                }

                finally
                {
                    con.Close();
                }
            }
         
            return dtbuscar;
        }


        //actualizar prestamos

        public void ModificarPrestamo(int id, string codigo_usuario, string codigo_libro, string fecha_prestamo, string status)
        {

            //crear el registro antes de modificar

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into historial(id_prestamo,codigoregistro_usuario,codigoregistro_libro,fecha_prestamo,status_prestamo)  select id_prestamo,codigo_usuario,codigo_libro,fecha_prestamo,status from prestamos where id_prestamo = " + "'" + id + "'" + "", con);
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
                SqlCommand cmd = new SqlCommand("update prestamos set codigo_usuario = '" + codigo_usuario + "', codigo_libro = '" + codigo_libro + "', fecha_prestamo = '" + fecha_prestamo + "', status = '" + status + "'  where id_prestamo = '" + id + "'  ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("El prestamo ha sido modificado correctamente");

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

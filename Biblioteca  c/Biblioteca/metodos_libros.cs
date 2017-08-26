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
    class metodos_libros
    {

        SqlConnection con = new SqlConnection("Data Source = usuario-pc\\sqlexpress; Initial Catalog = sesion; Integrated Security = True");


        //Insertar libros
        public void Insertarlibro( string nombre, string editorial, string genero, string autor, string idioma, string year, string paginas, string edicion,int cantidad )
        {
            string status = "Disponible";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into libros (nombre,editorial,genero,autor,idioma,year,npaginas,edicion,cantidad,status) values ('" + nombre + "','" + editorial  + "','" + genero + "','" + autor + "','" + idioma  + "','" + year + "','" + paginas + "','" + edicion+ "','" + cantidad + "','" + status + "')", con);
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

        //validar libros

        public int Validarlibro(string nombre, string autor, string editorial)
        {
            int contador = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from libros where nombre = " + "'" + nombre + "'" + " and autor = " + "'" + autor + "'" + " and  editorial =  " + "'" + editorial + "'" + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;

                }
                dr.Close();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("El Libro que intenta ingresar ya existe " + e.ToString());
                throw;
            }
            return contador;
        }

        //modificar libro info

        public void Modificarlibro(int id,string nombre, string editorial, string genero, string autor, string idioma, string year, string paginas, string edicion, string cantidad,string status)
        {

            //crear el registro antes de modificar

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into historial(id_libro,nombre_libro,editorial_libro,genero_libro,autor_libro,idioma_libro,year_libro,npaginas_libro,edicion_libro,cantidad_libro,status_libro) select id_libro,nombre,editorial,genero,autor,idioma,year,npaginas,edicion,cantidad,status from libros where id_libro = " + "'" + id + "'" + "", con);
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
                SqlCommand cmd = new SqlCommand("update libros set nombre = '" + nombre + "',editorial = '" + editorial + "', genero = '" + genero + "', autor = '" + autor + "', idioma = '" + idioma + "', year = '" + year + "', npaginas = '" + paginas + "' , edicion = '" + edicion + "', cantidad = '" + cantidad + "', status = '" + status + "' where id_libro = '" + id + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("La informacion del libro ha sido modificada correctamente");

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





        //Buscar libro (Tres formas de busqueda)
        public System.Data.DataTable Buscarlibro(string filtro, string buscar)
        {
            DataTable dtbuscar = new DataTable();
            
            //Buscar por libro

            if (filtro == "Nombre del Libro")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_libro,nombre,editorial,genero,autor,idioma,year,npaginas,edicion,cantidad,status from libros where nombre = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
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

            //Buscar por Autor
            if (filtro == "Autor")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_libro,nombre,editorial,genero,autor,idioma,year,npaginas,edicion,cantidad,status from libros where autor = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
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
            //Buscar por Editorial
            if (filtro == "Editorial")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select id_libro,nombre,editorial,genero,autor,idioma,year,npaginas,edicion,cantidad,status from libros where editorial = " + "'" + buscar + "'" + "", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtbuscar);
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

            return dtbuscar;
        }

    }
}

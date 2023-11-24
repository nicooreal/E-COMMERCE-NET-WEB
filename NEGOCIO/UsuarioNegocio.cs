using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using NEGOCIO;


namespace NEGOCIO
{
    public class UsuarioNegocio
    {
        public bool Loguear( Usuario usuario)
        {
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearQuery("Select Id, usuario, pass, tipouser from Usuarios Where Usuario = @user AND Pass = @pass");
				datos.setParameters("@user", usuario.User);
                datos.setParameters("@pass", usuario.Pass);
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					usuario.Id = (int)datos.Lector["Id"];

              

                    //usuario.TipoUsuario = (int)(datos.Lector["tipouser"]) == 2 ? TipoUsuario.ADMIN : TipoUsuario.VENDEDOR;
					
				 if ((int)(datos.Lector["tipouser"]) == 2) 
					{ 
						usuario.TipoUsuario = TipoUsuario.ADMIN;  
					}

                if ((int)(datos.Lector["tipouser"]) == 1)
					{
						usuario.TipoUsuario = TipoUsuario.VENDEDOR; 
					}




                    return true;
				}
				return false;
            }
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{

             datos.cerrarConexion();	
			}
        }


		public int Registrar(Usuario usuario)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearProcedimiento("Registrar");
				datos.setParameters("@user", usuario.User);
                datos.setParameters("@pass", usuario.Pass);
                datos.setParameters("@tipo", usuario.TipoUsuario);
				return datos.ejecutarAccionScalar();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

    }
}

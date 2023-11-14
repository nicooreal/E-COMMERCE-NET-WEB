using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            try
            {
            

                int idEditar = int.Parse(Request.QueryString["id"]);


          
                ProductoNegocio productoNegocio = new ProductoNegocio();
                List<Producto> lista = productoNegocio.listar();
                Producto produc = lista.Find(x => x.id == idEditar);


                    if (idEditar > 0)
                    {

                         txtId.Text = produc.id.ToString();
                txtPrecioCompra.Text =produc.precioCompra.ToString();
                     txtNombre.Text = produc.nombre;
                txtPrecioVenta.Text = produc.precioVenta.ToString();
                txtStockActual.Text = produc.stockActual.ToString();
                txtStockMinimo.Text = produc.stockMinimo.ToString();
                txtDescripcion.Text = produc.descripcion.ToString();
                //txtIdProveedor.Text = produc.proveedor.idProveedor.ToString();
                //    txtIdMarca.Text = produc.idmarca.idMarca.ToString();
                //txtIdCategoria.Text = produc.idcategoria.idCategoria.ToString();

                    }

                if (idEditar == 0) 
                
                {

                   int cantidadElementosLIsta = lista.Count();

                txtId.Text = (cantidadElementosLIsta + 1).ToString();
                
                } 
                
                else 
                {




                }





                if (idEditar == 0) 
                    { 
                    
                    } 

                 

                    dropDownListprov.DataSource = lista;
                    dropDownListprov.DataTextField = "proveedor";
                    dropDownListprov.DataValueField = "proveedor";
                    dropDownListprov.DataBind();
                    
                    dropDownListCategoria.DataSource = lista;
                    dropDownListCategoria.DataTextField = "idcategoria";
                    dropDownListCategoria.DataValueField = "idcategoria";
                    dropDownListCategoria.DataBind();

                    dropDownListMarca.DataSource = lista;
                    dropDownListMarca.DataTextField = "idmarca";
                    dropDownListMarca.DataValueField = "idmarca";
                    dropDownListMarca.DataBind();

             


                

            }
            catch (Exception exe)
            {

                throw exe;
            }
            





        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {

            AccesoDatos datos = new AccesoDatos();



            if (txtId.Text != null)
            {

                int id = int.Parse(txtId.Text);
                string nombrenuevo = txtNombre.Text;
                decimal precioVenta = decimal.Parse(txtPrecioVenta.Text);
                decimal precioCompra = decimal.Parse(txtPrecioCompra.Text);
                int stockActual = int.Parse(txtStockActual.Text);
                int stockMinimo = int.Parse(txtStockMinimo.Text);
                string descripcion = txtDescripcion.Text;
                //int idProveedor = int.Parse(txtIdProveedor.Text);
                //int idCategoria = int.Parse(txtIdCategoria.Text);
                //int idmarca = int.Parse(txtIdMarca.Text);

                datos.setParameters("@nombre", nombrenuevo);
                datos.setParameters("@id", id);
                datos.setParameters("@precioVenta", precioVenta);
                datos.setParameters("@precioCompra", precioCompra);
                datos.setParameters("@stockMinimo", stockMinimo);
                datos.setParameters("@stockActual", stockActual);
                datos.setParameters("@descripcion", descripcion);
                //datos.setParameters("@idProveedor", idProveedor);
                //datos.setParameters("@idCategoria", idCategoria);
                //datos.setParameters("@idMarca", idmarca);

                datos.setearQuery("UPDATE Productos SET idMarca = @idMarca, idProveedor = @idProveedor, idCategoria = @idCategoria, nombre = @nombre, precioCompra = @precioCompra, precioVenta = @precioVenta, stockMinimo = @stockMinimo, stockActual = @stockActual, descripcion = @descripcion   WHERE idProducto = @id");
              

                datos.ejecutarLectura();
                datos.cerrarConexion();
            }



        }

        protected void ButtonBajaLogica_Click(object sender, EventArgs e)
          {
          
           
        if ( IsPostBack)
            
         {

            if ( CheckBoxBaja.Checked == true)
            {

            
                AccesoDatos datos = new AccesoDatos();
            int idParaEliminar = int.Parse(txtId.Text);
            datos.setParameters("@idParaEliminar", idParaEliminar);
            datos.setearQuery("update Productos set estado = 0 where idProducto = @idParaEliminar");
            datos.ejecutarLectura();

                LabelBajaProducto.Text = "ELIMINACION EXIOTOSA";
            
            
            } else {
                LabelBajaProducto.Text = "CONFIRME LA ELIMINACION";
            }
        
         }            
            
          }
    }
    
}

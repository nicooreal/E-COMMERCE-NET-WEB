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

                if (!IsPostBack)
                {

                
                
                int idEditar = int.Parse(Request.QueryString["id"]);
            



          
                ProductoNegocio productoNegocio = new ProductoNegocio();
                List<Producto> lista = productoNegocio.listar();
                Producto produc = lista.Find(x => x.id == idEditar);
                

                ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
                    List<DOMINIO.Proveedor> listaProv = proveedorNegocio.listar();

                 MarcaNegocio marcaNegocio = new MarcaNegocio();
                    List<Marcas> listaMarca = marcaNegocio.listar();

                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    List<Categoria> listaCategoria = categoriaNegocio.listar();


                    dropDownListprov.DataSource = listaProv;
                    dropDownListCategoria.DataSource = listaCategoria;
                    dropDownListMarca.DataSource = listaMarca;









                    if (idEditar > 0)
                    {

                         txtId.Text = produc.id.ToString();
                txtPrecioCompra.Text =produc.precioCompra.ToString();
                     txtNombre.Text = produc.nombre;
                txtPrecioVenta.Text = produc.precioVenta.ToString();
                txtStockActual.Text = produc.stockActual.ToString();
                txtStockMinimo.Text = produc.stockMinimo.ToString();
                txtDescripcion.Text = produc.descripcion.ToString();


                        //dropDownListprov.DataTextField = produc.proveedor.nombreEmpresa;
                        //dropDownListprov.DataValueField = produc.proveedor.idProveedor.ToString();

                        //dropDownListMarca.DataTextField = produc.idmarca.nomMarca;
                        //dropDownListMarca.DataValueField = produc.idmarca.idMarca.ToString();

                        //dropDownListCategoria.DataTextField = produc.idcategoria.nomCategoria;
                        //dropDownListCategoria.DataValueField = produc.idcategoria.idCategoria.ToString();
                    
                    }

                if (idEditar == 0) 
                
                {

                   int cantidadElementosLIsta = lista.Count();

                txtId.Text = (cantidadElementosLIsta + 1).ToString();
                


                
              

                 

                } 
                  
                    dropDownListprov.DataTextField = "nombreEmpresa";
                    dropDownListprov.DataValueField = "idProveedor";
                    dropDownListprov.DataBind();
                    
                 
                    dropDownListCategoria.DataTextField = "nomCategoria";
                    dropDownListCategoria.DataValueField = "idCategoria";
                    dropDownListCategoria.DataBind();

                 
                    dropDownListMarca.DataTextField = "nomMarca";
                    dropDownListMarca.DataValueField = "idMarca";
                    dropDownListMarca.DataBind();

             
                }
                

            }
            catch (Exception exe)
            {

                throw exe;
            }
            





        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {

             AccesoDatos datos = new AccesoDatos();
             int idEditar = int.Parse(Request.QueryString["id"]);




                int id = int.Parse(txtId.Text);
                string nombrenuevo = txtNombre.Text;
                decimal precioVenta = decimal.Parse(txtPrecioVenta.Text);
                decimal precioCompra = decimal.Parse(txtPrecioCompra.Text);
                int stockActual = int.Parse(txtStockActual.Text);
                int stockMinimo = int.Parse(txtStockMinimo.Text);
                string descripcion = txtDescripcion.Text;
                int idCategoria = int.Parse(dropDownListCategoria.Text);
                int idProveedor = int.Parse(dropDownListprov.Text);
                int idMarca = int.Parse(dropDownListMarca.Text);

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
                datos.setParameters("@idProveedor", idProveedor);
                datos.setParameters("@idCategoria", idCategoria);
                datos.setParameters("@idMarca", idMarca);

            if (idEditar == 0) // mando 0 cuando toco el boton de agregar nuevo producto desde el aspx de producto
            {

                datos.setearQuery("INSERT INTO Productos (nombre, precioCompra, precioVenta, idMarca, idCategoria, stockActual, stockMinimo, estado, descripcion, idProveedor) VALUES (@nombre, @precioCompra,@precioVenta ,@idMarca , @idCategoria, @stockActual,@stockMinimo, 1, @descripcion, @idProveedor)");

            }   else
            
            {

            datos.setearQuery("UPDATE Productos SET idMarca = @idMarca, idProveedor = @idProveedor, idCategoria = @idCategoria, nombre = @nombre, precioCompra = @precioCompra, precioVenta = @precioVenta, stockMinimo = @stockMinimo, stockActual = @stockActual, descripcion = @descripcion   WHERE idProducto = @id");

            }
            LabelConfirmacion.ForeColor = System.Drawing.Color.Green;
            LabelConfirmacion.Text = "GUARDADO CON EXITO";
                datos.ejecutarLectura();
                datos.cerrarConexion();
            



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

                LabelConfirmacion.ForeColor = System.Drawing.Color.Red;
                LabelConfirmacion.Text = "ELIMINACION EXIOTOSA";
            
            
            } else {
                LabelBajaProducto.Text = "CONFIRME LA ELIMINACION";
            }
        
         }            
            
          }
    }
    
}

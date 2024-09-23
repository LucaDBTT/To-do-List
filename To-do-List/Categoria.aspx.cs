using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidad;

namespace To_do_List
{
    public partial class Categoria : System.Web.UI.Page
    {
        public List<Entidad.Categoria> Categorias {  get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CategoriaNegocio categorianeg = new CategoriaNegocio();
                Categorias = categorianeg.ListarCategorias();
                RepCat.DataSource = Categorias;
                RepCat.DataBind();
            }
        }

        protected void EliminarBtn_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)sender;
            int idCat = Convert.ToInt32(btnEliminar.CommandArgument);

            CategoriaNegocio categorianeg = new CategoriaNegocio();
            categorianeg.EliminarCategoria(idCat);
            Response.Redirect("Categoria.aspx", false);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string desc = txtDescripcion.Text;
            Entidad.Categoria cate = new Entidad.Categoria();
            cate.NombreCategoria = nombre;
            cate.Descripcion = desc;

            CategoriaNegocio categorianeg = new CategoriaNegocio();
            categorianeg.AgregarCategoria(cate);
            Response.Redirect("Categoria.aspx", false);
        }
    }
}
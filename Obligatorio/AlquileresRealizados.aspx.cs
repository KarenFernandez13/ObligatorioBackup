using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class AlquileresRealizados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkAdministracion").Visible = BaseDeDatos.usuarioLogueado.GetVerAdministracion();
            Master.FindControl("lnkClientes").Visible = BaseDeDatos.usuarioLogueado.GetVerClientes();
            Master.FindControl("lnkVehiculos").Visible = BaseDeDatos.usuarioLogueado.GetVerVehiculos();
            Master.FindControl("lnkVentas").Visible = BaseDeDatos.usuarioLogueado.GetVerVentas();
            Master.FindControl("lnkAlquileres").Visible = BaseDeDatos.usuarioLogueado.GetVerAlquileres();
            
            if (!Page.IsPostBack)
            {
                this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
                this.gvAlquileres.DataBind();                
            }
        }
        protected void gvAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        protected void gvAlquileres_EntrgarClick(object sender, EventArgs e)
        {



        }

        protected void gvVehiculos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvVehiculos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {



        }

        protected void gvVehiculos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvAlquileres.EditIndex = e.NewEditIndex;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();
        }

        protected void gvVehiculos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow filaSeleccionada = gvAlquileres.Rows[e.RowIndex];
            string NumAlquiler = this.gvAlquileres.DataKeys[e.RowIndex].Values[0].ToString();

            bool devuelto = (filaSeleccionada.FindControl("chkDevueltoGrid") as CheckBox).Checked;

            foreach (var alquiler in BaseDeDatos.ListaAlquileres)
            {
                if (alquiler.NumeroAlquiler.ToString() == NumAlquiler)
                {
                    alquiler.Devuelto = devuelto;
                }
            }

            this.gvAlquileres.EditIndex = -1;
            this.gvAlquileres.DataSource = BaseDeDatos.ListaAlquileres;
            this.gvAlquileres.DataBind();
        }      
    }
}
   
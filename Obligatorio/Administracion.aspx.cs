using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("lnkAdministracion").Visible = true;
            Master.FindControl("lnkClientes").Visible = true;
            Master.FindControl("lnkVehiculos").Visible = true;
            Master.FindControl("lnkVentas").Visible = true;
            Master.FindControl("lnkAlquileres").Visible = true;
            Master.FindControl("LogOut").Visible = true;
            gvVV.Visible = false;

            if (!Page.IsPostBack)
            {
                lstUsuarios.DataSource = BaseDeDatos.ListaUsuarios;
                lstUsuarios.DataValueField = "Documento";
                lstUsuarios.DataTextField = "Documento";
                lstUsuarios.DataBind();   
                gvVV.Visible = false;

                this.gvVV.DataSource = BaseDeDatos.ListaVentas;
                this.gvVV.DataBind();
            }
        }

        protected void btnUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }

        protected void btnVerVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentasRealizadas.aspx");
        }

        protected void btnVerAlquileres_Click(object sender, EventArgs e)
        {
            Response.Redirect("AlquileresRealizados.aspx");
        }

        protected void btnVV_Click(object sender, EventArgs e)
        {
            txtBuscar.Visible = true;
            btnBuscar.Visible = true;
            lstUsuarios.Visible = true;            
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string docu = txtBuscar.Text;
            ListItem usuarioEncontrado = lstUsuarios.Items.FindByValue(docu);
            List<Venta>VentasPorVendedor = new List<Venta>();
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Selected = true;
                foreach (var venta in BaseDeDatos.ListaVentas)
                {
                    if (venta.GetDocumentoEmpleado() == docu)
                    {
                        VentasPorVendedor.Add(venta);
                    }
                }      
                gvVV.DataSource = VentasPorVendedor;
                gvVV.DataBind();
                gvVV.Visible = true;

            }
            else
            {
                lblMessage.Text = "No hay un usuario registrado con ese documento";
                lblMessage.Visible = true;
                txtBuscar.Text = String.Empty;
                lstUsuarios.SelectedIndex = -1;
            }


        }

        protected void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                lblMessage.Text = "Debe seleccionar un vendedor";
            }
            else
            {
                lblMessage.Text = String.Empty;
            }
        }
       
    }
}
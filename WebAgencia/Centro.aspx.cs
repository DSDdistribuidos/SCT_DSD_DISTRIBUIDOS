using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAgencia.proxyCentros;

namespace WebAgencia
{
    public partial class Centro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarGrilla();
            }
        }
        void cargarGrilla()
        {
            proxyCentros.CentrosClient centro = new CentrosClient();
            var dato = centro.ListarCentro();
            gvCentro.DataSource = dato;
            gvCentro.DataBind();
        }

        void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
           
        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";

                proxyCentros.CentrosClient centro = new CentrosClient();
              //  centro.CrearCentro(txtDescripcion.Text);//.ID_CENTRO.ToString();//ddlEmpresa.SelectedValue(Empresa)
                cargarGrilla();
                limpiar();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error registrar datos :" + ex.Message;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                int codigoCent = int.Parse(txtCodigo.Text);
                lblMensaje.Text = "";
                proxyCentros.CentrosClient centro = new CentrosClient();

               // var cent = centro.ModificarCentro(codigoCent,txtDescripcion.Text,ddlEmpresa.SelectedValue).ID_CENTRO.ToString();
                cargarGrilla();
                limpiar();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al modificar datos....";


            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                int codigoCen = int.Parse(txtCodigo.Text);
                lblMensaje.Text = "";
                proxyCentros.CentrosClient centro = new CentrosClient();

                var cen = centro.ObtenerCentro(codigoCen);

                if (cen == null)
                {
                    lblMensaje.Text = "Centro no registrado....";
                }
                else
                {
                    txtDescripcion.Text = cen.DESCRIPCION.ToString();
                    ddlEmpresa.SelectedValue = cen.EMPRESA.ToString();
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = "Error obtener datos....";


            }
        }

    }
}
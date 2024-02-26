﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace PokedexWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee user = new Trainee();
                TraineeNegocio traineenegocio = new TraineeNegocio();
                EmailService emailService = new EmailService();
                user.Email = txtEmail.Text;
                user.Pass = txtPasword.Text;
                int id = traineenegocio.insetrarNuevo(user);

                emailService.armarCorreo(user.Email, "Bienvenida Trainee", "Hola te damos la bienvenida a la App...");
                emailService.enviarEmail();
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}
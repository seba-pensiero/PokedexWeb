﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace PokedexWeb
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgAvatar.ImageUrl = "https://simg.nicepng.com/png/small/202-2022264_usuario-annimo-usuario-annimo-user-icon-png-transparent.png";
            if (!(Page is Login || Page is Default1 || Page is Registro))
            {
                if (!Seguridad.sessionActiva(Session["trainee"]))
                    Response.Redirect("Login.aspx", false);
                else
                {
                    Trainee user = (Trainee)Session["trainee"];
                    lblUser.Text = user.Email;
                    if (!string.IsNullOrEmpty(user.ImagenPerfil))
                        imgAvatar.ImageUrl = "~/Images/" + user.ImagenPerfil;
                }
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}
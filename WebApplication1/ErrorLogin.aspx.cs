﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ErrorLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          /*  if (Session["error"] != null)
            {
                lblMensaje.Text = Session["error"].ToString();
          
            }
          */
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

     
    }
}
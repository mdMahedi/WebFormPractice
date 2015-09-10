﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormPractice
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        private int ClicksCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ViewState["Clicks"]!=null)
            {
                ClicksCount = (int)ViewState["Clicks"] + 1;
            }
            TextBox1.Text = ClicksCount.ToString();
            ViewState["Clicks"] = ClicksCount;
        }
    }
}
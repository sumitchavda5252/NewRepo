﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Calculater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
      
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "3";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "4";

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text="5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text="6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "7";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "8";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text="9";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            TextBox1.Text="0";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            int num1= int .Parse(TextBox1.Text);
            int num2= int.Parse(TextBox1.Text);

            int sum = num1 + num2;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "1";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
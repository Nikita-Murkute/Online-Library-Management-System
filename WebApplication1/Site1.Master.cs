﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            try
            {
                //if (Session["role"].Equals(""))
                if (Session["role"] == null)
                {
                    LinkButton2.Visible = true; // user login link button
                    LinkButton3.Visible = true; // sign up link button

                    LinkButton4.Visible = false; // logout link button
                    LinkButton5.Visible = false; // hello user link button


                    LinkButton6.Visible = true; // admin login link button
                    LinkButton7.Visible = false; // author management link button
                    LinkButton8.Visible = false; // publisher management link button
                    LinkButton9.Visible = false; // book inventory link button
                    LinkButton10.Visible = false; // book issuing link button
                    LinkButton11.Visible = false; // member management link button

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton2.Visible = false; // user login link button
                    LinkButton3.Visible = false; // sign up link button

                    LinkButton4.Visible = true; // logout link button
                    LinkButton5.Visible = true; // hello user link button
                    LinkButton6.Text = "Hello " + Session["username"].ToString();


                    LinkButton6.Visible = true; // admin login link button
                    LinkButton7.Visible = false; // author management link button
                    LinkButton8.Visible = false; // publisher management link button
                    LinkButton9.Visible = false; // book inventory link button
                    LinkButton10.Visible = false; // book issuing link button
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton2.Visible = false; // user login link button
                    LinkButton3.Visible = false; // sign up link button

                    LinkButton4.Visible = true; // logout link button
                    LinkButton5.Visible = true; // hello user link button
                    LinkButton5.Text = "Hello Admin";


                    LinkButton6.Visible = false; // admin login link button
                    LinkButton7.Visible = true; // author management link button
                    LinkButton8.Visible = true; // publisher management link button
                    LinkButton9.Visible = true; // book inventory link button
                    LinkButton10.Visible = true; // book issuing link button
                }
            }
            catch (Exception ex)
            {

            }


        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAuthorManagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPublisherManagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBookInventary.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBookIssuing.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMemberManagement.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton2.Visible = true; // user login link button
            LinkButton3.Visible = true; // sign up link button

            LinkButton4.Visible = false; // logout link button
            LinkButton5.Visible = false; // hello user link button


            LinkButton6.Visible = true; // admin login link button
            LinkButton7.Visible = false; // author management link button
            LinkButton8.Visible = false; // publisher management link button
            LinkButton9.Visible = false; // book inventory link button
            LinkButton10.Visible = false; // book issuing link button
            LinkButton11.Visible = false; // member management link button

            Response.Redirect("HomePage.aspx");
        }


        protected void LinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }
    }

}

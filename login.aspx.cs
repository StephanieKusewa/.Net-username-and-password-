using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace class1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String username,   password;
            username = txtUsername.Text;
            password = (txtPassword.Text);
            if ( username == "user" && password == "12345")
            {
                lbOutput.Text = "Right login credentials";
                lbOutput.ForeColor = System.Drawing.Color.Green;
            }
                else
            {
                lbOutput.Text = "Wrong login credentials";
                lbOutput.ForeColor= System.Drawing.Color.Red;
            }



        }
    }
}
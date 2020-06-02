using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class lotto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToString(Session["account"]) == "000" && Convert.ToString(Session["password"]) == "111")
            {
                Response.Redirect("https://www.yahoo.com.tw");
            }
            else
            {
            }
            //Random r = new Random();
            //Label1.Text = $"{r.Next(1,48)},{r.Next(1, 48)},{r.Next(1, 48)},{r.Next(1, 48)},{r.Next(1, 48)},{r.Next(1, 48)}";
            //Application.Lock();
            //String test = Convert.ToString(Application["TEST"]);
            //Response.Write(test);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Application.Lock();
            //Application["TEST"] += ("<br/>" + account.Text);
            //Application.UnLock();
            //Response.Write(Application["TEST"]);
            if (account.Text == "000" && password.Text == "111")
            {
                Session["account"] = "000";
                Session["password"] = "111";
                Response.Redirect("https://www.yahoo.com.tw");
            }
            else
            {
            }
        }
    }
}
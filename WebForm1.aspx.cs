using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace s09.RegisterStartupScriptMethod
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Page.ClientScript.RegisterStartupScript(
                TextBox1.GetType(),                                       // Δηλαδή θα επιστρέψει την TextBox class.
                "clientScript",                                           // Ενα οτιδήποτε string.
                "document.getElementById('TextBox1').value=new Date();",  // Τι ζητάω.true 
                true                                                      // Θα δημιουργήσει τα script tags για εμάς.

                );


        }
    }
}
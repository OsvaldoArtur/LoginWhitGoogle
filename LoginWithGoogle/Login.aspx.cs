using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


using ASPSnippets.GoogleAPI;

namespace LoginWithGoogle
{
    public partial class Login : System.Web.UI.Page
    {
     //  EmailCode ab = new EmailCode();
        protected void Page_Load(object sender, EventArgs e)
        {
            GoogleConnect.ClientId = "257048884331-7p8367n9n5n5ouq7rl4004uemt3bcnrv.apps.googleusercontent.com";
            GoogleConnect.ClientSecret = "wkijjMQTCQBfDjsSqS-FDnJG";

            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];

            if (!string.IsNullOrEmpty(Request.QueryString["code"]))
            {
                string code = Request.QueryString["code"];
                string json = GoogleConnect.Fetch("me", code);
            GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);
                lblId.Text = profile.Id;
                lblNome.Text = profile.DisplayName;
                lblEmail.Text = profile.Emails.Find(email => email.Type == "account").Value;
                lblSexo.Text = profile.Gender;
                lblTipo.Text = profile.ObjectType;
                ProfileImage.ImageUrl = profile.Image.Url;
                pnlProfile.Visible = true;
                btnLogin.Enabled = false;
            }
            if (Request.QueryString["error"] == "access_denied")
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
            }

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            GoogleConnect.Clear(Request.QueryString["code"]);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            

            GoogleConnect.Authorize("profile", "email");
        }
        public class GoogleProfile
        {
            public string Id { get; set; }
            public string DisplayName { get; set; }
            public Image Image { get; set; }
            public List<Email> Emails { get; set; }
            public string Gender { get; set; }
            public string ObjectType { get; set; }
        }

        public class Email
        {
            public string Value { get; set; }
            public string Type { get; set; }
        }

        public class Image
        {
            public string Url { get; set; }
        }
    }
}
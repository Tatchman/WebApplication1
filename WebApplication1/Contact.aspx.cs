using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
using System.Data;
using System.Net.Mail;
using System.Text;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
            txtName.Text = "";
            txtMessage.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Code 1 start
            const string ToAddress = "Jake@gmail.com";
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("Jake@gmail.com", "password");

            try
            {
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage(txtMail.Text, ToAddress);
                mm.Body = txtMessage.Text;
                mm.Subject = "Online Test";
                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.Send(mm);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            //Code 1 End
        }
    }
}
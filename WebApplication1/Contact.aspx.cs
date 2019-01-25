using System;
using System.Web.UI;
using System.Net.Mail;
using System.Text;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnReset_Click(object sender, EventArgs e)                                   //Executes when the Reset button is clicked.\\
        {
            txtMail.Text = "";                                                                      //Makes the Email box blank.\\
            txtName.Text = "";                                                                      //Makes the Name box blank.\\
            txtMessage.Text = "";                                                                   //Makes the message box blank.\\
        }
        protected void btnSubmit_Click(object sender, EventArgs e)                                  //Executes when the Submit button is clicked.\\
        {
            //Code for sending the message
            const string ToAddress = "Jake@gmail.com";                                              //Sets the string "ToAddress" to the email address of the inbox.\\
            SmtpClient client = new SmtpClient();                                                   //Declares the SmtpClient.\\
            client.Port = 587;                                                                      //Sets the Smtp port to 587\\
            client.Host = "smtp.gmail.com";                                                         //Sets the Smtp host to gmail.\\
            client.EnableSsl = true;                                                                //Sets the client to use the Secure Socket Layer.\\
            client.Timeout = 10000;                                                                 //Times out the operation if incomplete after 10 seconds.\\
            client.DeliveryMethod = SmtpDeliveryMethod.Network;                                     //Declares the delivery method as the SMTP one.\\
            client.UseDefaultCredentials = false;                                                   //Informs the client to no use default login.\\
            client.Credentials = new System.Net.NetworkCredential("Jake@gmail.com", "password");    //Sets the login credentials for the system.\\

            //Try/Catch error management
            try //Tries to send the message
            {
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage(txtMail.Text, ToAddress);
                mm.Body = txtMessage.Text;                                                          //Sets the body of the email as the text input from the message box.\\
                mm.Subject = "Online Test";                                                         //Sets the subject of the email, so the recipient knows its from the wbesite.\\
                mm.BodyEncoding = UTF8Encoding.UTF8;                                                //Sets the encoding of the message as UTF-8.\\
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;             //Sets a notification for the user if the message failes to send.\\
                client.Send(mm);                                                                    //Sends the email.\\
            }
            catch (Exception ex) //On failiue it displays the error message on a label
            {
                lblError.Text = ex.Message;                                                         //Sets the error label to display the error message if the try sections fails.\\
            }
            
        }
    }
}


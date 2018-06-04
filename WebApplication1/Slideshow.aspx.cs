using System;
using System.Web.UI;

namespace WebApplication1
{
    public partial class Slideshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                slideImage();
            }
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            slideImage();
        }
        private void slideImage()
        {
            //Upon loading, sets the image to Image 1
            if (ViewState["displayedImage"] == null)
            {
                slides.ImageUrl = "~/images/Image1.jpg";
                ViewState["displayedImage"] = 1;
                Label1.Text = "Displaying image: 1";
            }           
            else
            {
                //When image 4 is reached, on the next iteration it sends it back to Image 1
                int x = (int)ViewState["displayedImage"];
                if (x == 4)
                {
                    slides.ImageUrl = "~/images/Image1.jpg";
                    ViewState["displayedImage"] = 1;
                    Label1.Text = "Displaying image: 1";
                }
                else
                //Iterates onto the next image
                {
                    x = x + 1;
                    slides.ImageUrl = "~/images/Image" + x.ToString() + ".jpg";
                    ViewState["displayedImage"] = x;
                    Label1.Text = "Displaying image: " + x.ToString();
                }
            }
        }
    }
}
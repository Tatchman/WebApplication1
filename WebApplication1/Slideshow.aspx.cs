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
            if (ViewState["displayedImage"] == null)        //If the ViewState variable "displayedImage" is null, it runs the initialisation segment.
            {                                               //This is for the initial setup of the image slider when the page is first initialised.\\
                slides.ImageUrl = "~/images/Image1.jpg";    //Sets the location of the jpg file for the first image.\\
                ViewState["displayedImage"] = 1;            //Sets the variable for "displayedImage" to 1.\\
                Label1.Text = "Displaying image: 1";        //Sets the label of the image to "Displaying image: 1.\\
            }           
            else
            {
                //When image 4 is reached, on the next iteration it sends it back to Image 1
                int x = (int)ViewState["displayedImage"];   //Sets the variable X to the value of "displayedImage".\\
                if (x == 4)                                 //If the variable X is equal to 4 it runs this section of code.\\
                {
                    slides.ImageUrl = "~/images/Image1.jpg";    //This is the same code as the setup of the initialisation section at the start of the function.\\
                    ViewState["displayedImage"] = 1;
                    Label1.Text = "Displaying image: 1";
                }
                else
                //Iterates onto the next image
                {
                    x = x + 1;                                                  //Takes the value of X and adds 1 to it.\\
                    slides.ImageUrl = "~/images/Image" + x.ToString() + ".jpg"; //Sets the image file to one that corresponds to the value of X.\\
                    ViewState["displayedImage"] = x;                            //Sets the "displayedImage" variable to the value of X.\\
                    Label1.Text = "Displaying image: " + x.ToString();          //Sets the image label to "Displaying image: x"\\
                }
            }
        }
    }
}
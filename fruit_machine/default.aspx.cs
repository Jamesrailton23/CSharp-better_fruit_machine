using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fruit_machine
{
    public partial class _default : System.Web.UI.Page
    {
        // GLOBAL VARBILES
        double bet_input;
       
        //USED TO CALUATE PAYOUT AND ASSIGN FRUIT TO WEBPAGE IMAGES
        string image_one;
        string image_two;
        string image_three;
        
        // THE FRUIT ARRAY
        string[] images;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            // PLACE HOLDER FOR 3 IMAGES (ONLY SETS ON PAGE LOAD DUE TO POSTBACK 
            if (!Page.IsPostBack)
            {
                image_1.ImageUrl = "/images/spin.png";
                image_2.ImageUrl = "/images/spin.png";
                image_3.ImageUrl = "/images/spin.png";
            }
        }

        protected void image_button_one_Click(object sender, ImageClickEventArgs e) //MAIN TRIGGER OF EVENTS
        {
            fruit_machine(); // METHOD TO ASSIGN FRUIT TYPE TO IMAGES & FRUIT TYPE TO VARIBLE TO USE IN WININGS METHOD

            // ASSIGNES THE USER INPUT TO A DOUBLE VARBIBLE TO BE USED IN CALUALTIONG THE PAYOUT 
            bet_input = double.Parse(tb_bet.Text);
            lable_payout.Text = String.Format("{0:C}", payout_calc(bet_input));
        }
        protected double payout_calc(double the_bet) // METHOD TO CALCUALTE WININGS (ONCE RETURN HAS BEEN CALLED METHOD IS EXITED)
        {
           if(image_one == "Diamond" && image_two == "Diamond" && image_three == "Diamond")
           {
                the_bet *= 10;
                return the_bet;
           }
          else if(image_one == "cherry" || image_two == "cherry" || image_three == "cherry")
          {
                the_bet *= 1.5;
                return the_bet;
          }
          else if(image_one == "bar" || image_two == "bar" || image_three == "bar")
          {
                the_bet *= 2;
          }
          else if (image_one == image_two && image_two == image_three)
          {
                the_bet *= 3;
                return the_bet;
          }
           
            return the_bet = 0; //IF NONE OF THE IF STATMENTS ABOVE ARE TRUE IT RETURNS 0 

        }
        protected void fruit_machine() //THE METHOD TO ASSIGN THE FRUIT TO IMAGES AND VARIABLES USING AN ARRAY (ASSIGNS FRUIT TO IMAGES AND THE VARBLIES ALSO RANDOMISES THE IMAGES EACH TIME THROUGH RANDOM NUMBER GENRATOR)
        {
            //STRING ARRAY FOR DIFFRENT TYPES OF FRUIT
            images = new string[12];
            images[0] = "bar";
            images[1] = "cherry";
            images[2] = "bell";
            images[3] = "Diamond";
            images[4] = "Lemon";
            images[5] = "horseShoe";
            images[6] = "Strawberry";
            images[7] = "watermellon";
            images[8] = "clover";
            images[9] = "Seven";
            images[10] = "Plum";
            images[11] = "Orange";

            //RANDOM NUMBER GENRATOR
            Random random_val = new Random();
            random_val.Next(11);

            //ASSIGNS THE OUTPUT OF THE STRING ARRAY TO THE IMAGE_1,2,3 VARIBLE TO BE USED
            image_one = images[random_val.Next(12)];
            image_two = images[random_val.Next(12)];
            image_three = images[random_val.Next(12)];

            //ASSIGNS THE FRUIT PICTURES TO THE THREE IMAGES ON WEBFORM
            image_1.ImageUrl = "/images/" + image_one + ".png";
            image_2.ImageUrl = "/images/" + image_two + ".png";
            image_3.ImageUrl = "/images/" + image_three + ".png";
        }
    }
}
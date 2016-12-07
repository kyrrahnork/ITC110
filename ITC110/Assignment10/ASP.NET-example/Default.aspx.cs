using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateEntree();
            PopulateDrinks();
        }
    }

    protected void PopulateEntree()
    {
        string[] entree = { "Hamburger", "Hotdog", "Mac & Cheese", "Corndog", "Spaghetti", "French Dip"};
        CBLEntree.DataSource = entree;
        CBLEntree.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MealOrder meal = new MealOrder();
        foreach(ListItem item in CBLEntree.Items)
        {
            if(item.Selected)
            {
                meal.AddEntree(item.Text);
            }
        }//end of entree foreach
        foreach (ListItem item in CBLDrinks.Items)
        {
            if (item.Selected)
            {
                meal.AddDrinks(item.Text);
            }
        }//end of drink foreach
        Session["Meal"] = meal;
        Response.Redirect("Receipt.aspx");
    }//end of button

    protected void PopulateDrinks()
    {
        string[] drinks = { "Sprite", "Coke", "Milkshake", "Coffee", "Tea", "Orange Juice" };
        CBLDrinks.DataSource = drinks;
        CBLDrinks.DataBind();
    }
}
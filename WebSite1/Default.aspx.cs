using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        calculate.Click += new EventHandler(this.Calculate);
        count.Click += new EventHandler(this.Count);

    }

    protected void Calculate(object sender, EventArgs e)
    {
        int n1 = Int32.Parse(number1.Text);
        int n2 = Int32.Parse(number2.Text);
        int n3 = 0;

        string value = option.SelectedValue;

        if (value == "add")
        {
            n3 = n1 + n2;
        }
        else if (value == "minus")
        {
            n3 = n1 - n2;
        }

        else if (value == "multiple")
        {
            n3 = n1 * n2;
        }
        else
        {
            n3 = n1 / n2;
        }

        String n4 = n3.ToString();
        String n5 = Convert.ToString(n3, 2);
        Base10.Text = n4;
        Base2.Text = n5;

    }

    protected void Count(object sender, EventArgs e)
    {
        int length = Base2.Text.Length;
        int num0 = 0;
        int num1 = 0;
        
        for (int counter = 0; counter < length; counter++)
        {
            if (Base2.Text[counter] == '0')
            {
                num0 += 1;
            }
            else
            {
                num1 += 1;
            }
        }
        Numof0.Text = num0.ToString();
        Numof1.Text = num1.ToString();

    }
}
/*
 * Author: Blake Allen
 * Date: 04/16/2023
 * Course: CIS162AD
 * Description: A Windows Form program that utilizes a GUI to place an order at Nina's Cookie Source, the program
 * can take as input: the type of cookie, quantity, and date of order.
 */
using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinasCookieSource
{
    public partial class NinasCookieSource : Form
    {
        //Initializing variables for the type of cookies, total cost of the cookies, the selected date for delivery, and the price variable is for the price of one dozen of each cookie.
        String cookieSelect;
        double totalCost;
        DateTime selectedDate;
        double price;

        public NinasCookieSource()
        {
            InitializeComponent();
        }

        private void SugarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Sugar cookie radio button
            //pressing this radio button sets the cookieSelect variable to this flavor of cookie
            cookieSelect = "sugar";
        }

        private void OatmealRaisinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Oatmeal raisin radio button
            //pressing this radio button sets the cookieSelect variable to this flavor of cookie
            cookieSelect = "oatmeal";
        }

        private void StrawberryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Strawberry radio button
            //pressing this radio button sets the cookieSelect variable to this flavor of cookie
            cookieSelect = "strawberry";
        }

        private void HowManyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //This code controls the quantity selection box

            //Setting the price based on which flavor of cookie is selected
            if (cookieSelect == "sugar")
                    price = 4.50;
            else if (cookieSelect == "oatmeal")
                    price = 6.50;
            else if (cookieSelect == "strawberry")
                price = 10.50;
            else
                return;

            //Setting the total cost based on the price of the selected flavor multiplied by the quantity
            if (howManyListBox.SelectedIndex == 0)
                totalCost = .5 * price;
            else if (howManyListBox.SelectedIndex == 1)
                totalCost = 1 * price;
            else if (howManyListBox.SelectedIndex == 2)
                totalCost = 2 * price;
            else if (howManyListBox.SelectedIndex == 3)
                totalCost = 3 * price;
            else
                return;
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //This code controls the calendar control

            //Setting the maximum number of selected dates to one
            monthCalendar1.MaxSelectionCount = 1;
            //Setting the selectedDate variable to the value selected on the calendar control
            selectedDate = monthCalendar1.SelectionStart.Date;
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            //This code controls the update info button

            //Displays the delivery date and total cost of cookies.
            deliveryDateLabel.Text = ("Cookies will be delivered on " + selectedDate.AddDays(3).ToString("MM/dd/yyyy"));
            totalCostLabel.Text = ("Total is " + totalCost.ToString("C"));
        }

        
    }
}

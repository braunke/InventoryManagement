using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global list of articles of clothing so they can be accessed from anywhere 
        string[,] listShirt =
                { {"T-shirt","100"},{ "A-shirt","55"},{  "Ripped","33" },{ "Dress", "222"},{ "Fancy", "52"},{ "Flannel", "32"},{ "Puffy","82"} };
        string[,] listPants =
               { {"Khakis","4343"},{ "Capris","455"},{  "Ripped","44" },{ "Hammer ", "262"},{ "Fancy", "42"},{ "Flannel ", "333"},{ "Puffy ","82"} };
        string[,] listShoes =
                { {"Boots","100"},{"Tap","55"},{"Fancy","33"},{"Ripped", "222"} };
        private void ClickRadioButton(object sender, EventArgs e)
        {
            Options.Items.Clear();

            // making the radio buttons point to array holding different types of shirts
            if (rdoShirts.Checked)
            {

                
                string productsString = "";

                //for loop to run through our RECTANGULAR array
                for (int x = 0; x < listShirt.GetLength(0); x++)

                {
                    for (int y = 0; y < listShirt.GetLength(1); y++)
                        productsString += listShirt[x, y] + "\t\t";

                    Options.Items.Add(productsString);
                    productsString = "";

                }

            }
            // making the radio buttons point to array holding different types of pants
            if (rdoPants.Checked)
            {
                
                string productsString = "";

                //for loop to run through our RECTANGULAR array
                for (int x = 0; x < listPants.GetLength(0); x++)

                {
                    for (int y = 0; y < listPants.GetLength(1); y++)
                        productsString += listPants[x, y] + "\t\t";

                    Options.Items.Add(productsString);
                    productsString = "";

                }

            }
            // making the radio buttons point to the array holding different types of shoes
            if (rdoShoes.Checked)
            {
                
                string productsString = "";

                //for loop to run through our RECTANGULAR array
                for (int x = 0; x < listShoes.GetLength(0); x++)

                {
                    for (int y = 0; y < listShoes.GetLength(1); y++)
                        productsString += listShoes[x, y] + "\t\t";

                    Options.Items.Add(productsString);
                    productsString = "";

                }
            }
        }         


        private void btnExit_Click(object sender, EventArgs e)
        {
            //this closes the application
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[,] List = null;
            //checks what radio button is selected to see what list to use 
            if (rdoPants.Checked) List = listPants;
            if (rdoShirts.Checked) List = listShirt;
            if (rdoShoes.Checked) List = listShoes;
            //gets the index of the selected item 
            int index = Options.SelectedIndex;
            //validation --probably a better way? 
            if (index != -1 && List != null)
            {
                
                //gets the number of items in string form from selected item 
                string currentQuantity = List[index, 1];
                //converts to int so we can perform addition 
                int currentAmount = Convert.ToInt32(currentQuantity);
                //adds on eto the current amount 
                int newAmount = currentAmount + 1;
                //converts back to string to add back into list 
                string newQuantity = Convert.ToString(newAmount);
                //changes the quantity in the list 
                List[index, 1] = newQuantity;
                //calls the clickradiobutton to display new item quantity 
                ClickRadioButton(sender, e);
            }
        }
    }
}

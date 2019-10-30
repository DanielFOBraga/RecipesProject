using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL; //para não ser preciso escrever o nome compelto

namespace RecipesWin
{
    public partial class frmIngredient : Form
    {
        public frmIngredient()
        {
            InitializeComponent();
        }

        private void buttonInsertIngredient_Click(object sender, EventArgs e)
        {
            Ingredient newingredient = new Ingredient();
            newingredient.Name = txtIngredient.Text;
            if (newingredient.Insert())
            {
                MessageBox.Show("Ingredient insert sucessfully");
            }
            else
            {
                MessageBox.Show("An error occurred, ingredient was not inserted");
            }
            
        }
    }
}

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
        bool _flag = false;
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
                LoadComboBox();
            }
            else
            {
                MessageBox.Show("An error occurred, ingredient was not inserted");
            }            
        }

        private void frmIngredient_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            _flag = true; //isto foi criado porque quando o cbbIngredients.DisplayMember é atribuido conta como SelectedIndexChanged 
                          //dando erro abaixo (tenta escrever na textbox um valor que não existe)
        }

        private void cbbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtUpdateIngredient.Text = cbbIngredients.Text;                
            }            
        }

        private void buttonIngredientUpdate_Click(object sender, EventArgs e)
        {            
            Ingredient UpdatedIngredient = new Ingredient();
            UpdatedIngredient.Id = (int)cbbIngredients.SelectedValue;
            UpdatedIngredient.Name = txtUpdateIngredient.Text;
            if (UpdatedIngredient.Update())
            {
                MessageBox.Show("Ingredient updated sucessfully");
                LoadComboBox();
            }
            else
            {
                MessageBox.Show("Error updating ingredient");
            }            
        }
        private void LoadComboBox()
        {
            Ingredients Listingredients = new Ingredients();
            cbbIngredients.DataSource = Listingredients.ListAll();
            cbbIngredients.DisplayMember = "Name";
            cbbIngredients.ValueMember = "Id";
        }

        private void buttonDeleteIngredient_Click(object sender, EventArgs e)
        {
            Ingredient ingredientToDelete = new Ingredient();
            int id = (int)cbbIngredients.SelectedValue;
            ingredientToDelete.Id = id;
            if (ingredientToDelete.Delete())
            {
                MessageBox.Show("Ingredient deleted sucessfully");
                LoadComboBox();
            }
            else
            {
                MessageBox.Show("An error occurred, ingredient was not deleted");
            }
        }
    }
}

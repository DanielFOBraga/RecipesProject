using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace RecipesWin
{
    public partial class frmCuisineTypesAndDishTypes : Form
    {
        bool _flag = false;
        public frmCuisineTypesAndDishTypes()
        {
            InitializeComponent();
        }

        private void buttonInsertCuisineType_Click(object sender, EventArgs e)
        {
            CuisineType cuisineType = new CuisineType(txtInsertCuisineType.Text);
            if (cuisineType.Insert())
            {
                MessageBox.Show("Cuisine type inserted sucessfully");
                LoadComboBoxCuisinetype();
            }
            else
            {
                MessageBox.Show("Error inserting cuisine type");
            }
        }
        private void cbbCuisineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtUpdateDeleteCuisineType.Text = cbbCuisineType.Text;
            }
        }
        private void buttonUpdateCuisineType_Click(object sender, EventArgs e)
        {
            CuisineType cuisineTypeToUpdate = new CuisineType();
            cuisineTypeToUpdate.IdCuisine = (int)cbbCuisineType.SelectedValue;
            cuisineTypeToUpdate.CuisineTypeName = txtUpdateDeleteCuisineType.Text;
            if (cuisineTypeToUpdate.Update())
            {
                MessageBox.Show("Cuisine type updated sucessfully");
                LoadComboBoxCuisinetype();
            }
            else
            {
                MessageBox.Show("Error updating cuisine type");
            }
        }
        private void buttonDeleteCuisineType_Click(object sender, EventArgs e)
        {
            //CuisineType cuisineTypeToDelete = new CuisineType((int)cbbCuisineType.SelectedValue, txtInsertCuisineType.Text); did not work!
            CuisineType cuisineTypeToDelete = new CuisineType();
            cuisineTypeToDelete.IdCuisine = (int)cbbCuisineType.SelectedValue;
            cuisineTypeToDelete.CuisineTypeName = txtInsertCuisineType.Text;
            if (cuisineTypeToDelete.Delete())
            {
                MessageBox.Show("Cuisine type deleted sucessfully");
                LoadComboBoxCuisinetype();
            }
            else
            {
                MessageBox.Show("Error deleting cuisine type");
            }
        }
        private void frmCuisineTypesAndDishTypes_Load(object sender, EventArgs e)
        {
            LoadComboBoxCuisinetype();
            LoadComboBoxDishCategories();
            _flag = true;
        }
        private void LoadComboBoxCuisinetype()
        {
            CuisineTypes listCuisineTypes = new CuisineTypes();
            cbbCuisineType.DataSource = listCuisineTypes.ListAllCuisineType();
            cbbCuisineType.DisplayMember = "CuisineTypeName";
            cbbCuisineType.ValueMember = "IdCuisine";
        }
        #region Dish Category
        private void buttonInsertDishCategory_Click(object sender, EventArgs e)
        {
            DishCategory dishCategoryToInsert = new DishCategory(txtInsertDishCategory.Text);
            if (dishCategoryToInsert.Insert())
            {
                MessageBox.Show("Dish category inserted sucessfully");
                LoadComboBoxDishCategories();
            }
            else
            {
                MessageBox.Show("An error occurred, dish category was not inserted");
            }
        }
        private void cbbDishCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtUpdateDeleteDishCategory.Text = cbbDishCategory.Text;
            }
        }

        private void buttonUpdateDishCategory_Click(object sender, EventArgs e)
        {
            DishCategory dishCategoryToUpdate = new DishCategory((int)cbbDishCategory.SelectedValue, txtUpdateDeleteDishCategory.Text);
            if (dishCategoryToUpdate.Update())
            {
                MessageBox.Show("Dish category updated sucessfully");
                LoadComboBoxDishCategories();
            }
            else
            {
                MessageBox.Show("An error occurred, dish category was not updated");
            }
        }

        private void buttonDeleteDishCategory_Click(object sender, EventArgs e)
        {
            DishCategory dishCategoryToDelete = new DishCategory((int)cbbDishCategory.SelectedValue, txtUpdateDeleteDishCategory.Text);
            if (dishCategoryToDelete.Delete())
            {
                MessageBox.Show("Dish category deleted sucessfully");
                LoadComboBoxDishCategories();
            }
            else
            {
                MessageBox.Show("An error occurred, dish category was not deleted");
            }
        }
        private void cbbDishCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtUpdateDeleteDishCategory.Text = cbbDishCategory.Text;
            }
        }
        private void LoadComboBoxDishCategories()
        {
            DishCategories listDishCategories = new DishCategories();
            cbbDishCategory.DataSource = listDishCategories.ListAllDishCategories();
            cbbDishCategory.ValueMember = "DishCategoryID";
            cbbDishCategory.DisplayMember = "DishCategoryName";
        }
        #endregion
    }
}

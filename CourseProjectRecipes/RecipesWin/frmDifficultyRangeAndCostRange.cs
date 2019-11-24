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
    public partial class frmDifficultyRangeAndCostRange : Form
    {
        bool _flag = false;
        public frmDifficultyRangeAndCostRange()
        {
            InitializeComponent();
        }

        private void buttonInsertDifficultyRange_Click(object sender, EventArgs e)
        {
            DifficultyRange difficultyRangeToAdd = new DifficultyRange(txtInsertDificultyRange.Text);
            if (difficultyRangeToAdd.Insert())
            {
                MessageBox.Show("Difficulty category added successfully");
            }
            else
            {
                MessageBox.Show("Error adding difficulty category");
            }
        }

        private void frmDifficultyRangeAndCostRange_Load(object sender, EventArgs e)
        {
            LoadComboBoxDifficultyRange();
            LoadComboBoxCostRange();
            _flag = true;
        }
        private void buttonUpdateDifficulty_Click(object sender, EventArgs e)
        {
            DifficultyRange difficultyRangeToUpdate = new DifficultyRange();
            difficultyRangeToUpdate.IdDifficulty = (int)cbbDifficultyRange.SelectedValue;
            difficultyRangeToUpdate.Difficulty = txtDifficultyRangeToUpdateDelete.Text;
            if (difficultyRangeToUpdate.Update())
            {
                MessageBox.Show("Difficulty category updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating difficulty category");
            }
            LoadComboBoxDifficultyRange();
        }         
        private void buttonDeleteDifficulty_Click(object sender, EventArgs e)
        {
            DifficultyRange difficultyRangeToDelete = new DifficultyRange();
            difficultyRangeToDelete.IdDifficulty = (int)cbbDifficultyRange.SelectedValue;
            difficultyRangeToDelete.Difficulty = txtCostRangeToUpdateDelete.Text;
            if (difficultyRangeToDelete.Delete())
            {
                MessageBox.Show("Difficulty category deleted successfully");
            }
            else
            {
                MessageBox.Show("Error deleting difficulty category");
            }
            LoadComboBoxDifficultyRange();
        }
        private void cbbDifficultyRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtDifficultyRangeToUpdateDelete.Text = cbbDifficultyRange.Text;
            }
        }
        private void LoadComboBoxDifficultyRange()
        {
            DifficultieRanges difficultieRanges = new DifficultieRanges();
            cbbDifficultyRange.DataSource = difficultieRanges.ListAllDifficutyRanges();
            cbbDifficultyRange.DisplayMember = "Difficulty";
            cbbDifficultyRange.ValueMember = "IdDifficulty";
        }
        #region Cost Range
        private void buttonInsertCostRange_Click(object sender, EventArgs e)
        {
            CostRange costRangeToInsert = new CostRange(txtInsertCostRange.Text);
            if (costRangeToInsert.Insert())
            {
                MessageBox.Show("Cost level inserted successfully");
            }
            else
            {
                MessageBox.Show("Error inserting cost level");
            }
            LoadComboBoxCostRange();
        }
        private void buttonUpdateCost_Click(object sender, EventArgs e)
        {
            CostRange costRangeToUpdate = new CostRange();
            costRangeToUpdate.IDcost = (int)cbbCostRange.SelectedValue;
            costRangeToUpdate.Cost = txtCostRangeToUpdateDelete.Text;
            if (costRangeToUpdate.Update())
            {
                MessageBox.Show("Cost level updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating cost level");
            }
            LoadComboBoxCostRange();
        }

        private void buttonDeleteCost_Click(object sender, EventArgs e)
        {
            CostRange costRangeToDelete = new CostRange();
            costRangeToDelete.IDcost = (int)cbbCostRange.SelectedValue;
            costRangeToDelete.Cost = txtCostRangeToUpdateDelete.Text;
            if (costRangeToDelete.Delete())
            {
                MessageBox.Show("Cost level deleted successfully");
            }
            else
            {
                MessageBox.Show("Error deleted cost level");
            }
            LoadComboBoxCostRange();
        }
        private void cbbCostRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtCostRangeToUpdateDelete.Text = cbbCostRange.Text;
            }
        }
        private void LoadComboBoxCostRange()
        {
            CostRanges costRanges = new CostRanges();
            cbbCostRange.DataSource = costRanges.ListAllCostRanges();
            cbbCostRange.DisplayMember = "Cost";
            cbbCostRange.ValueMember = "IDcost";
        }
        #endregion        
    }
}

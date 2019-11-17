using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipesWin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to leave?", 
                "Exit",MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void manageIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngredient frmIngredient = new frmIngredient();
            frmIngredient.MdiParent = this;
            frmIngredient.Show();
        }

        private void manageMeasurementUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeasurementUnit frmMeasurementUnit = new frmMeasurementUnit();
            frmMeasurementUnit.MdiParent = this;
            frmMeasurementUnit.Show();
        }

        private void manageCuisineTypesAndDishTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuisineTypesAndDishTypes frmCuisineTypesAndDishTypes = new frmCuisineTypesAndDishTypes();
            frmCuisineTypesAndDishTypes.MdiParent = this;
            frmCuisineTypesAndDishTypes.Show();
        }
    }
}

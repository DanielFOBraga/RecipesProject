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
    public partial class frmMeasurementUnit : Form
    {
        bool _flag = false;
        public frmMeasurementUnit()
        {
            InitializeComponent();
        }

        private void buttonInsertMeasurementUnit_Click(object sender, EventArgs e)
        {
            MeasurementUnit newMeasurementUnit = new MeasurementUnit();
            newMeasurementUnit.Name = txtInsertMeasurementUnit.Text;
            if (newMeasurementUnit.InsertMeasurementUnit())
            {
                MessageBox.Show("Measurement Unit insert sucessfully");
                LoadComboBox();
            }
            else
            {
                MessageBox.Show("An error occurred, measurement unit was not inserted");
            }
        }

        private void cbbMeasurementUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_flag)
            {
                txtMeasurementUnitUpdate.Text = cbbMeasurementUnit.Text;
            }
        }
       
        private void updateMeasurementUnit_Click(object sender, EventArgs e)
        {
            MeasurementUnit measurementUnitToUpdate = new MeasurementUnit();
            measurementUnitToUpdate.Id = (int)cbbMeasurementUnit.SelectedValue;
            measurementUnitToUpdate.Name = txtMeasurementUnitUpdate.Text;
            if (measurementUnitToUpdate.UpdatedMeasurementUnit())
            {
                MessageBox.Show("Measurement unit updated sucessfully");
                LoadComboBox();
            }
            else
            {
                MessageBox.Show("Error updating measurement unit");
            }
        }       
        private void frmMeasurementUnit_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            _flag = true;
        }
        private void deleteMeasurementUnit_Click(object sender, EventArgs e)
        {
            MeasurementUnit measurementUnitToDelete = new MeasurementUnit();
            measurementUnitToDelete.Id = (int)cbbMeasurementUnit.SelectedValue;
            measurementUnitToDelete.Name = txtMeasurementUnitUpdate.Text;
            if (measurementUnitToDelete.DeleteMeasurementUnit())
            {
                MessageBox.Show("Measurement unit deleted sucessfully");
                LoadComboBox();
            }
            else
            {
                MessageBox.Show("Error deleting measurement unit");
            }
        }
        private void LoadComboBox()
        {
            MeasurementUnits listMeasurementUnits = new MeasurementUnits();
            cbbMeasurementUnit.DataSource = listMeasurementUnits.ListMeasurementUnits();
            cbbMeasurementUnit.DisplayMember = "Name";
            cbbMeasurementUnit.ValueMember = "Id";
        }
    }
}

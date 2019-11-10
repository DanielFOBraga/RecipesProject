namespace RecipesWin
{
    partial class frmMeasurementUnit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInsertMeasurementUnit = new System.Windows.Forms.TextBox();
            this.buttonInsertMeasurementUnit = new System.Windows.Forms.Button();
            this.cbbMeasurementUnit = new System.Windows.Forms.ComboBox();
            this.updateMeasurementUnit = new System.Windows.Forms.Button();
            this.deleteMeasurementUnit = new System.Windows.Forms.Button();
            this.txtMeasurementUnitUpdate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInsertMeasurementUnit);
            this.groupBox1.Controls.Add(this.txtInsertMeasurementUnit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Measurement Unit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMeasurementUnitUpdate);
            this.groupBox2.Controls.Add(this.deleteMeasurementUnit);
            this.groupBox2.Controls.Add(this.updateMeasurementUnit);
            this.groupBox2.Controls.Add(this.cbbMeasurementUnit);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update or Delete Measurement Unit";
            // 
            // txtInsertMeasurementUnit
            // 
            this.txtInsertMeasurementUnit.Location = new System.Drawing.Point(19, 43);
            this.txtInsertMeasurementUnit.Name = "txtInsertMeasurementUnit";
            this.txtInsertMeasurementUnit.Size = new System.Drawing.Size(227, 20);
            this.txtInsertMeasurementUnit.TabIndex = 0;
            // 
            // buttonInsertMeasurementUnit
            // 
            this.buttonInsertMeasurementUnit.Location = new System.Drawing.Point(300, 42);
            this.buttonInsertMeasurementUnit.Name = "buttonInsertMeasurementUnit";
            this.buttonInsertMeasurementUnit.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertMeasurementUnit.TabIndex = 1;
            this.buttonInsertMeasurementUnit.Text = "Insert";
            this.buttonInsertMeasurementUnit.UseVisualStyleBackColor = true;
            this.buttonInsertMeasurementUnit.Click += new System.EventHandler(this.buttonInsertMeasurementUnit_Click);
            // 
            // cbbMeasurementUnit
            // 
            this.cbbMeasurementUnit.FormattingEnabled = true;
            this.cbbMeasurementUnit.Location = new System.Drawing.Point(19, 69);
            this.cbbMeasurementUnit.Name = "cbbMeasurementUnit";
            this.cbbMeasurementUnit.Size = new System.Drawing.Size(227, 21);
            this.cbbMeasurementUnit.TabIndex = 0;
            this.cbbMeasurementUnit.SelectedIndexChanged += new System.EventHandler(this.cbbMeasurementUnit_SelectedIndexChanged);
            // 
            // updateMeasurementUnit
            // 
            this.updateMeasurementUnit.Location = new System.Drawing.Point(300, 111);
            this.updateMeasurementUnit.Name = "updateMeasurementUnit";
            this.updateMeasurementUnit.Size = new System.Drawing.Size(75, 23);
            this.updateMeasurementUnit.TabIndex = 1;
            this.updateMeasurementUnit.Text = "Update";
            this.updateMeasurementUnit.UseVisualStyleBackColor = true;
            this.updateMeasurementUnit.Click += new System.EventHandler(this.updateMeasurementUnit_Click);
            // 
            // deleteMeasurementUnit
            // 
            this.deleteMeasurementUnit.Location = new System.Drawing.Point(219, 111);
            this.deleteMeasurementUnit.Name = "deleteMeasurementUnit";
            this.deleteMeasurementUnit.Size = new System.Drawing.Size(75, 23);
            this.deleteMeasurementUnit.TabIndex = 2;
            this.deleteMeasurementUnit.Text = "Delete";
            this.deleteMeasurementUnit.UseVisualStyleBackColor = true;
            this.deleteMeasurementUnit.Click += new System.EventHandler(this.deleteMeasurementUnit_Click);
            // 
            // txtMeasurementUnitUpdate
            // 
            this.txtMeasurementUnitUpdate.Location = new System.Drawing.Point(252, 69);
            this.txtMeasurementUnitUpdate.Name = "txtMeasurementUnitUpdate";
            this.txtMeasurementUnitUpdate.Size = new System.Drawing.Size(164, 20);
            this.txtMeasurementUnitUpdate.TabIndex = 3;
            // 
            // frmMeasurementUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMeasurementUnit";
            this.Text = "frmMeasurementUnit";
            this.Load += new System.EventHandler(this.frmMeasurementUnit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonInsertMeasurementUnit;
        private System.Windows.Forms.TextBox txtInsertMeasurementUnit;
        private System.Windows.Forms.Button deleteMeasurementUnit;
        private System.Windows.Forms.Button updateMeasurementUnit;
        private System.Windows.Forms.ComboBox cbbMeasurementUnit;
        private System.Windows.Forms.TextBox txtMeasurementUnitUpdate;
    }
}
namespace RecipesWin
{
    partial class frmCuisineTypesAndDishTypes
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
            this.txtInsertCuisineType = new System.Windows.Forms.TextBox();
            this.buttonInsertCuisineType = new System.Windows.Forms.Button();
            this.buttonInsertDishCategory = new System.Windows.Forms.Button();
            this.txtInsertDishCategory = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbCuisineType = new System.Windows.Forms.ComboBox();
            this.txtUpdateDeleteCuisineType = new System.Windows.Forms.TextBox();
            this.buttonUpdateCuisineType = new System.Windows.Forms.Button();
            this.buttonDeleteCuisineType = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteDishCategory = new System.Windows.Forms.Button();
            this.buttonUpdateDishCategory = new System.Windows.Forms.Button();
            this.txtUpdateDeleteDishCategory = new System.Windows.Forms.TextBox();
            this.cbbDishCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInsertCuisineType);
            this.groupBox1.Controls.Add(this.txtInsertCuisineType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Cuisine Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonInsertDishCategory);
            this.groupBox2.Controls.Add(this.txtInsertDishCategory);
            this.groupBox2.Location = new System.Drawing.Point(357, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Dish Category";
            // 
            // txtInsertCuisineType
            // 
            this.txtInsertCuisineType.Location = new System.Drawing.Point(7, 40);
            this.txtInsertCuisineType.Name = "txtInsertCuisineType";
            this.txtInsertCuisineType.Size = new System.Drawing.Size(200, 20);
            this.txtInsertCuisineType.TabIndex = 0;
            // 
            // buttonInsertCuisineType
            // 
            this.buttonInsertCuisineType.Location = new System.Drawing.Point(223, 37);
            this.buttonInsertCuisineType.Name = "buttonInsertCuisineType";
            this.buttonInsertCuisineType.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertCuisineType.TabIndex = 1;
            this.buttonInsertCuisineType.Text = "Insert";
            this.buttonInsertCuisineType.UseVisualStyleBackColor = true;
            this.buttonInsertCuisineType.Click += new System.EventHandler(this.buttonInsertCuisineType_Click);
            // 
            // buttonInsertDishCategory
            // 
            this.buttonInsertDishCategory.Location = new System.Drawing.Point(235, 39);
            this.buttonInsertDishCategory.Name = "buttonInsertDishCategory";
            this.buttonInsertDishCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDishCategory.TabIndex = 3;
            this.buttonInsertDishCategory.Text = "Insert";
            this.buttonInsertDishCategory.UseVisualStyleBackColor = true;
            this.buttonInsertDishCategory.Click += new System.EventHandler(this.buttonInsertDishCategory_Click);
            // 
            // txtInsertDishCategory
            // 
            this.txtInsertDishCategory.Location = new System.Drawing.Point(19, 42);
            this.txtInsertDishCategory.Name = "txtInsertDishCategory";
            this.txtInsertDishCategory.Size = new System.Drawing.Size(200, 20);
            this.txtInsertDishCategory.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDeleteCuisineType);
            this.groupBox3.Controls.Add(this.buttonUpdateCuisineType);
            this.groupBox3.Controls.Add(this.txtUpdateDeleteCuisineType);
            this.groupBox3.Controls.Add(this.cbbCuisineType);
            this.groupBox3.Location = new System.Drawing.Point(13, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update or Delete Cuisine Type";
            // 
            // cbbCuisineType
            // 
            this.cbbCuisineType.FormattingEnabled = true;
            this.cbbCuisineType.Location = new System.Drawing.Point(6, 79);
            this.cbbCuisineType.Name = "cbbCuisineType";
            this.cbbCuisineType.Size = new System.Drawing.Size(163, 21);
            this.cbbCuisineType.TabIndex = 0;
            this.cbbCuisineType.SelectedIndexChanged += new System.EventHandler(this.cbbCuisineType_SelectedIndexChanged);
            // 
            // txtUpdateDeleteCuisineType
            // 
            this.txtUpdateDeleteCuisineType.Location = new System.Drawing.Point(175, 79);
            this.txtUpdateDeleteCuisineType.Name = "txtUpdateDeleteCuisineType";
            this.txtUpdateDeleteCuisineType.Size = new System.Drawing.Size(142, 20);
            this.txtUpdateDeleteCuisineType.TabIndex = 1;
            // 
            // buttonUpdateCuisineType
            // 
            this.buttonUpdateCuisineType.Location = new System.Drawing.Point(131, 143);
            this.buttonUpdateCuisineType.Name = "buttonUpdateCuisineType";
            this.buttonUpdateCuisineType.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCuisineType.TabIndex = 2;
            this.buttonUpdateCuisineType.Text = "Update";
            this.buttonUpdateCuisineType.UseVisualStyleBackColor = true;
            this.buttonUpdateCuisineType.Click += new System.EventHandler(this.buttonUpdateCuisineType_Click);
            // 
            // buttonDeleteCuisineType
            // 
            this.buttonDeleteCuisineType.Location = new System.Drawing.Point(222, 143);
            this.buttonDeleteCuisineType.Name = "buttonDeleteCuisineType";
            this.buttonDeleteCuisineType.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCuisineType.TabIndex = 3;
            this.buttonDeleteCuisineType.Text = "Delete";
            this.buttonDeleteCuisineType.UseVisualStyleBackColor = true;
            this.buttonDeleteCuisineType.Click += new System.EventHandler(this.buttonDeleteCuisineType_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDeleteDishCategory);
            this.groupBox4.Controls.Add(this.buttonUpdateDishCategory);
            this.groupBox4.Controls.Add(this.txtUpdateDeleteDishCategory);
            this.groupBox4.Controls.Add(this.cbbDishCategory);
            this.groupBox4.Location = new System.Drawing.Point(357, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 200);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update or Delete Dish Category";
            // 
            // buttonDeleteDishCategory
            // 
            this.buttonDeleteDishCategory.Location = new System.Drawing.Point(222, 143);
            this.buttonDeleteDishCategory.Name = "buttonDeleteDishCategory";
            this.buttonDeleteDishCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDishCategory.TabIndex = 3;
            this.buttonDeleteDishCategory.Text = "Delete";
            this.buttonDeleteDishCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteDishCategory.Click += new System.EventHandler(this.buttonDeleteDishCategory_Click);
            // 
            // buttonUpdateDishCategory
            // 
            this.buttonUpdateDishCategory.Location = new System.Drawing.Point(131, 143);
            this.buttonUpdateDishCategory.Name = "buttonUpdateDishCategory";
            this.buttonUpdateDishCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDishCategory.TabIndex = 2;
            this.buttonUpdateDishCategory.Text = "Update";
            this.buttonUpdateDishCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateDishCategory.Click += new System.EventHandler(this.buttonUpdateDishCategory_Click);
            // 
            // txtUpdateDeleteDishCategory
            // 
            this.txtUpdateDeleteDishCategory.Location = new System.Drawing.Point(175, 79);
            this.txtUpdateDeleteDishCategory.Name = "txtUpdateDeleteDishCategory";
            this.txtUpdateDeleteDishCategory.Size = new System.Drawing.Size(142, 20);
            this.txtUpdateDeleteDishCategory.TabIndex = 1;
            // 
            // cbbDishCategory
            // 
            this.cbbDishCategory.FormattingEnabled = true;
            this.cbbDishCategory.Location = new System.Drawing.Point(6, 79);
            this.cbbDishCategory.Name = "cbbDishCategory";
            this.cbbDishCategory.Size = new System.Drawing.Size(163, 21);
            this.cbbDishCategory.TabIndex = 0;
            this.cbbDishCategory.SelectedIndexChanged += new System.EventHandler(this.cbbDishCategory_SelectedIndexChanged);
            this.cbbDishCategory.SelectedValueChanged += new System.EventHandler(this.cbbDishCategory_SelectedValueChanged);
            // 
            // frmCuisineTypesAndDishTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 341);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCuisineTypesAndDishTypes";
            this.Text = "frmCuisineTypesAndDishTypes";
            this.Load += new System.EventHandler(this.frmCuisineTypesAndDishTypes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonInsertCuisineType;
        private System.Windows.Forms.TextBox txtInsertCuisineType;
        private System.Windows.Forms.Button buttonInsertDishCategory;
        private System.Windows.Forms.TextBox txtInsertDishCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDeleteCuisineType;
        private System.Windows.Forms.Button buttonUpdateCuisineType;
        private System.Windows.Forms.TextBox txtUpdateDeleteCuisineType;
        private System.Windows.Forms.ComboBox cbbCuisineType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeleteDishCategory;
        private System.Windows.Forms.Button buttonUpdateDishCategory;
        private System.Windows.Forms.TextBox txtUpdateDeleteDishCategory;
        private System.Windows.Forms.ComboBox cbbDishCategory;
    }
}
namespace RecipesWin
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRecipesPortalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageIngredientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMeasurementUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCuisineTypesAndDishTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageRecipesPortalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageRecipesPortalToolStripMenuItem
            // 
            this.manageRecipesPortalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageIngredientToolStripMenuItem,
            this.manageMeasurementUnitsToolStripMenuItem,
            this.manageCuisineTypesAndDishTypesToolStripMenuItem});
            this.manageRecipesPortalToolStripMenuItem.Name = "manageRecipesPortalToolStripMenuItem";
            this.manageRecipesPortalToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.manageRecipesPortalToolStripMenuItem.Text = "Manage Recipes Portal";
            // 
            // manageIngredientToolStripMenuItem
            // 
            this.manageIngredientToolStripMenuItem.Name = "manageIngredientToolStripMenuItem";
            this.manageIngredientToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.manageIngredientToolStripMenuItem.Text = "Manage Ingredient";
            this.manageIngredientToolStripMenuItem.Click += new System.EventHandler(this.manageIngredientToolStripMenuItem_Click);
            // 
            // manageMeasurementUnitsToolStripMenuItem
            // 
            this.manageMeasurementUnitsToolStripMenuItem.Name = "manageMeasurementUnitsToolStripMenuItem";
            this.manageMeasurementUnitsToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.manageMeasurementUnitsToolStripMenuItem.Text = "Manage Measurement Units";
            this.manageMeasurementUnitsToolStripMenuItem.Click += new System.EventHandler(this.manageMeasurementUnitsToolStripMenuItem_Click);
            // 
            // manageCuisineTypesAndDishTypesToolStripMenuItem
            // 
            this.manageCuisineTypesAndDishTypesToolStripMenuItem.Name = "manageCuisineTypesAndDishTypesToolStripMenuItem";
            this.manageCuisineTypesAndDishTypesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.manageCuisineTypesAndDishTypesToolStripMenuItem.Text = "Manage Cuisine Types and Dish Types";
            this.manageCuisineTypesAndDishTypesToolStripMenuItem.Click += new System.EventHandler(this.manageCuisineTypesAndDishTypesToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Recipes Portal Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRecipesPortalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageIngredientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMeasurementUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCuisineTypesAndDishTypesToolStripMenuItem;
    }
}
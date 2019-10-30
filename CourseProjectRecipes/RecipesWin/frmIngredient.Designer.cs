namespace RecipesWin
{
    partial class frmIngredient
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
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.buttonInsertIngredient = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.groupBoxInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.txtIngredient);
            this.groupBoxInsert.Controls.Add(this.buttonInsertIngredient);
            this.groupBoxInsert.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(439, 111);
            this.groupBoxInsert.TabIndex = 1;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "Insert";
            // 
            // buttonInsertIngredient
            // 
            this.buttonInsertIngredient.Location = new System.Drawing.Point(341, 49);
            this.buttonInsertIngredient.Name = "buttonInsertIngredient";
            this.buttonInsertIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertIngredient.TabIndex = 0;
            this.buttonInsertIngredient.Text = "Insert";
            this.buttonInsertIngredient.UseVisualStyleBackColor = true;
            this.buttonInsertIngredient.Click += new System.EventHandler(this.buttonInsertIngredient_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(12, 49);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(292, 20);
            this.txtIngredient.TabIndex = 1;
            // 
            // frmIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 142);
            this.Controls.Add(this.groupBoxInsert);
            this.Name = "frmIngredient";
            this.Text = "frmIngredient";
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button buttonInsertIngredient;
    }
}


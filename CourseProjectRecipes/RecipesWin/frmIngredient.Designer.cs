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
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.buttonInsertIngredient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbIngredients = new System.Windows.Forms.ComboBox();
            this.txtUpdateIngredient = new System.Windows.Forms.TextBox();
            this.buttonIngredientUpdate = new System.Windows.Forms.Button();
            this.buttonDeleteIngredient = new System.Windows.Forms.Button();
            this.groupBoxInsert.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(12, 49);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(292, 20);
            this.txtIngredient.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteIngredient);
            this.groupBox1.Controls.Add(this.buttonIngredientUpdate);
            this.groupBox1.Controls.Add(this.txtUpdateIngredient);
            this.groupBox1.Controls.Add(this.cbbIngredients);
            this.groupBox1.Location = new System.Drawing.Point(13, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update and Delete";
            // 
            // cbbIngredients
            // 
            this.cbbIngredients.FormattingEnabled = true;
            this.cbbIngredients.Location = new System.Drawing.Point(11, 42);
            this.cbbIngredients.Name = "cbbIngredients";
            this.cbbIngredients.Size = new System.Drawing.Size(211, 21);
            this.cbbIngredients.TabIndex = 0;
            this.cbbIngredients.SelectedIndexChanged += new System.EventHandler(this.cbbIngredients_SelectedIndexChanged);
            // 
            // txtUpdateIngredient
            // 
            this.txtUpdateIngredient.Location = new System.Drawing.Point(228, 42);
            this.txtUpdateIngredient.Name = "txtUpdateIngredient";
            this.txtUpdateIngredient.Size = new System.Drawing.Size(203, 20);
            this.txtUpdateIngredient.TabIndex = 1;
            // 
            // buttonIngredientUpdate
            // 
            this.buttonIngredientUpdate.Location = new System.Drawing.Point(331, 90);
            this.buttonIngredientUpdate.Name = "buttonIngredientUpdate";
            this.buttonIngredientUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonIngredientUpdate.TabIndex = 2;
            this.buttonIngredientUpdate.Text = "Update";
            this.buttonIngredientUpdate.UseVisualStyleBackColor = true;
            this.buttonIngredientUpdate.Click += new System.EventHandler(this.buttonIngredientUpdate_Click);
            // 
            // buttonDeleteIngredient
            // 
            this.buttonDeleteIngredient.Location = new System.Drawing.Point(250, 90);
            this.buttonDeleteIngredient.Name = "buttonDeleteIngredient";
            this.buttonDeleteIngredient.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteIngredient.TabIndex = 6;
            this.buttonDeleteIngredient.Text = "Delete";
            this.buttonDeleteIngredient.UseVisualStyleBackColor = true;
            this.buttonDeleteIngredient.Click += new System.EventHandler(this.buttonDeleteIngredient_Click);
            // 
            // frmIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInsert);
            this.Name = "frmIngredient";
            this.Text = "frmIngredient";
            this.Load += new System.EventHandler(this.frmIngredient_Load);
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Button buttonInsertIngredient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonIngredientUpdate;
        private System.Windows.Forms.TextBox txtUpdateIngredient;
        private System.Windows.Forms.ComboBox cbbIngredients;
        private System.Windows.Forms.Button buttonDeleteIngredient;
    }
}


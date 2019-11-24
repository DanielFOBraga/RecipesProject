﻿namespace RecipesWin
{
    partial class frmDifficultyRangeAndCostRange
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
            this.txtInsertDificultyRange = new System.Windows.Forms.TextBox();
            this.buttonInsertDifficultyRange = new System.Windows.Forms.Button();
            this.txtInsertCostRange = new System.Windows.Forms.TextBox();
            this.buttonInsertCostRange = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbDifficultyRange = new System.Windows.Forms.ComboBox();
            this.cbbCostRange = new System.Windows.Forms.ComboBox();
            this.txtDifficultyRangeToUpdateDelete = new System.Windows.Forms.TextBox();
            this.txtCostRangeToUpdateDelete = new System.Windows.Forms.TextBox();
            this.buttonDeleteDifficulty = new System.Windows.Forms.Button();
            this.buttonUpdateDifficulty = new System.Windows.Forms.Button();
            this.buttonDeleteCost = new System.Windows.Forms.Button();
            this.buttonUpdateCost = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInsertDifficultyRange);
            this.groupBox1.Controls.Add(this.txtInsertDificultyRange);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Difficulty Range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonInsertCostRange);
            this.groupBox2.Controls.Add(this.txtInsertCostRange);
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 131);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert Cost Range";
            // 
            // txtInsertDificultyRange
            // 
            this.txtInsertDificultyRange.Location = new System.Drawing.Point(20, 58);
            this.txtInsertDificultyRange.Name = "txtInsertDificultyRange";
            this.txtInsertDificultyRange.Size = new System.Drawing.Size(201, 20);
            this.txtInsertDificultyRange.TabIndex = 0;
            // 
            // buttonInsertDifficultyRange
            // 
            this.buttonInsertDifficultyRange.Location = new System.Drawing.Point(258, 56);
            this.buttonInsertDifficultyRange.Name = "buttonInsertDifficultyRange";
            this.buttonInsertDifficultyRange.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertDifficultyRange.TabIndex = 1;
            this.buttonInsertDifficultyRange.Text = "Insert";
            this.buttonInsertDifficultyRange.UseVisualStyleBackColor = true;
            this.buttonInsertDifficultyRange.Click += new System.EventHandler(this.buttonInsertDifficultyRange_Click);
            // 
            // txtInsertCostRange
            // 
            this.txtInsertCostRange.Location = new System.Drawing.Point(32, 57);
            this.txtInsertCostRange.Name = "txtInsertCostRange";
            this.txtInsertCostRange.Size = new System.Drawing.Size(201, 20);
            this.txtInsertCostRange.TabIndex = 0;
            // 
            // buttonInsertCostRange
            // 
            this.buttonInsertCostRange.Location = new System.Drawing.Point(270, 55);
            this.buttonInsertCostRange.Name = "buttonInsertCostRange";
            this.buttonInsertCostRange.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertCostRange.TabIndex = 1;
            this.buttonInsertCostRange.Text = "Insert";
            this.buttonInsertCostRange.UseVisualStyleBackColor = true;
            this.buttonInsertCostRange.Click += new System.EventHandler(this.buttonInsertCostRange_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonUpdateDifficulty);
            this.groupBox3.Controls.Add(this.buttonDeleteDifficulty);
            this.groupBox3.Controls.Add(this.txtDifficultyRangeToUpdateDelete);
            this.groupBox3.Controls.Add(this.cbbDifficultyRange);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 188);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update or Delete Difficulty Range";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonUpdateCost);
            this.groupBox4.Controls.Add(this.txtCostRangeToUpdateDelete);
            this.groupBox4.Controls.Add(this.buttonDeleteCost);
            this.groupBox4.Controls.Add(this.cbbCostRange);
            this.groupBox4.Location = new System.Drawing.Point(398, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 188);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update or Delete Cost Range";
            // 
            // cbbDifficultyRange
            // 
            this.cbbDifficultyRange.FormattingEnabled = true;
            this.cbbDifficultyRange.Location = new System.Drawing.Point(20, 82);
            this.cbbDifficultyRange.Name = "cbbDifficultyRange";
            this.cbbDifficultyRange.Size = new System.Drawing.Size(201, 21);
            this.cbbDifficultyRange.TabIndex = 0;
            this.cbbDifficultyRange.SelectedIndexChanged += new System.EventHandler(this.cbbDifficultyRange_SelectedIndexChanged);
            // 
            // cbbCostRange
            // 
            this.cbbCostRange.FormattingEnabled = true;
            this.cbbCostRange.Location = new System.Drawing.Point(20, 83);
            this.cbbCostRange.Name = "cbbCostRange";
            this.cbbCostRange.Size = new System.Drawing.Size(201, 21);
            this.cbbCostRange.TabIndex = 0;
            this.cbbCostRange.SelectedIndexChanged += new System.EventHandler(this.cbbCostRange_SelectedIndexChanged);
            // 
            // txtDifficultyRangeToUpdateDelete
            // 
            this.txtDifficultyRangeToUpdateDelete.Location = new System.Drawing.Point(227, 82);
            this.txtDifficultyRangeToUpdateDelete.Name = "txtDifficultyRangeToUpdateDelete";
            this.txtDifficultyRangeToUpdateDelete.Size = new System.Drawing.Size(136, 20);
            this.txtDifficultyRangeToUpdateDelete.TabIndex = 1;
            // 
            // txtCostRangeToUpdateDelete
            // 
            this.txtCostRangeToUpdateDelete.Location = new System.Drawing.Point(227, 83);
            this.txtCostRangeToUpdateDelete.Name = "txtCostRangeToUpdateDelete";
            this.txtCostRangeToUpdateDelete.Size = new System.Drawing.Size(136, 20);
            this.txtCostRangeToUpdateDelete.TabIndex = 1;
            // 
            // buttonDeleteDifficulty
            // 
            this.buttonDeleteDifficulty.Location = new System.Drawing.Point(258, 148);
            this.buttonDeleteDifficulty.Name = "buttonDeleteDifficulty";
            this.buttonDeleteDifficulty.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteDifficulty.TabIndex = 2;
            this.buttonDeleteDifficulty.Text = "Delete";
            this.buttonDeleteDifficulty.UseVisualStyleBackColor = true;
            this.buttonDeleteDifficulty.Click += new System.EventHandler(this.buttonDeleteDifficulty_Click);
            // 
            // buttonUpdateDifficulty
            // 
            this.buttonUpdateDifficulty.Location = new System.Drawing.Point(177, 148);
            this.buttonUpdateDifficulty.Name = "buttonUpdateDifficulty";
            this.buttonUpdateDifficulty.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDifficulty.TabIndex = 2;
            this.buttonUpdateDifficulty.Text = "Update";
            this.buttonUpdateDifficulty.UseVisualStyleBackColor = true;
            this.buttonUpdateDifficulty.Click += new System.EventHandler(this.buttonUpdateDifficulty_Click);
            // 
            // buttonDeleteCost
            // 
            this.buttonDeleteCost.Location = new System.Drawing.Point(270, 148);
            this.buttonDeleteCost.Name = "buttonDeleteCost";
            this.buttonDeleteCost.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteCost.TabIndex = 2;
            this.buttonDeleteCost.Text = "Delete";
            this.buttonDeleteCost.UseVisualStyleBackColor = true;
            this.buttonDeleteCost.Click += new System.EventHandler(this.buttonDeleteCost_Click);
            // 
            // buttonUpdateCost
            // 
            this.buttonUpdateCost.Location = new System.Drawing.Point(189, 148);
            this.buttonUpdateCost.Name = "buttonUpdateCost";
            this.buttonUpdateCost.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateCost.TabIndex = 2;
            this.buttonUpdateCost.Text = "Update";
            this.buttonUpdateCost.UseVisualStyleBackColor = true;
            this.buttonUpdateCost.Click += new System.EventHandler(this.buttonUpdateCost_Click);
            // 
            // frmDifficultyRangeAndCostRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 363);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDifficultyRangeAndCostRange";
            this.Text = "frmDifficultyRangeAndCostRange";
            this.Load += new System.EventHandler(this.frmDifficultyRangeAndCostRange_Load);
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
        private System.Windows.Forms.Button buttonInsertDifficultyRange;
        private System.Windows.Forms.TextBox txtInsertDificultyRange;
        private System.Windows.Forms.Button buttonInsertCostRange;
        private System.Windows.Forms.TextBox txtInsertCostRange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbDifficultyRange;
        private System.Windows.Forms.TextBox txtDifficultyRangeToUpdateDelete;
        private System.Windows.Forms.TextBox txtCostRangeToUpdateDelete;
        private System.Windows.Forms.ComboBox cbbCostRange;
        private System.Windows.Forms.Button buttonUpdateDifficulty;
        private System.Windows.Forms.Button buttonDeleteDifficulty;
        private System.Windows.Forms.Button buttonUpdateCost;
        private System.Windows.Forms.Button buttonDeleteCost;
    }
}
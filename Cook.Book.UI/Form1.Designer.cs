namespace Cook.Book.UI
{
    partial class mainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.cookBookMDFDataSet = new Cook.Book.UI.CookBookMDFDataSet();
            this.recipesLabel = new System.Windows.Forms.Label();
            this.recipeListBox = new System.Windows.Forms.ListBox();
            this.ingredientListbox = new System.Windows.Forms.ListBox();
            this.ingredientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cookBookMDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cookBookMDFDataSet
            // 
            this.cookBookMDFDataSet.DataSetName = "CookBookMDFDataSet";
            this.cookBookMDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesLabel
            // 
            this.recipesLabel.AutoSize = true;
            this.recipesLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recipesLabel.Location = new System.Drawing.Point(41, 41);
            this.recipesLabel.Name = "recipesLabel";
            this.recipesLabel.Size = new System.Drawing.Size(70, 23);
            this.recipesLabel.TabIndex = 0;
            this.recipesLabel.Text = "Recipes";
            // 
            // recipeListBox
            // 
            this.recipeListBox.FormattingEnabled = true;
            this.recipeListBox.ItemHeight = 16;
            this.recipeListBox.Location = new System.Drawing.Point(44, 79);
            this.recipeListBox.Name = "recipeListBox";
            this.recipeListBox.Size = new System.Drawing.Size(255, 180);
            this.recipeListBox.TabIndex = 1;
            this.recipeListBox.SelectedIndexChanged += new System.EventHandler(this.recipeListBox_SelectedIndexChanged);
            // 
            // ingredientListbox
            // 
            this.ingredientListbox.FormattingEnabled = true;
            this.ingredientListbox.ItemHeight = 16;
            this.ingredientListbox.Location = new System.Drawing.Point(380, 79);
            this.ingredientListbox.Name = "ingredientListbox";
            this.ingredientListbox.Size = new System.Drawing.Size(255, 180);
            this.ingredientListbox.TabIndex = 3;
            this.ingredientListbox.SelectedIndexChanged += new System.EventHandler(this.ingredientListbox_SelectedIndexChanged);
            // 
            // ingredientLabel
            // 
            this.ingredientLabel.AutoSize = true;
            this.ingredientLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ingredientLabel.Location = new System.Drawing.Point(377, 41);
            this.ingredientLabel.Name = "ingredientLabel";
            this.ingredientLabel.Size = new System.Drawing.Size(94, 23);
            this.ingredientLabel.TabIndex = 2;
            this.ingredientLabel.Text = "Ingredient";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 555);
            this.Controls.Add(this.ingredientListbox);
            this.Controls.Add(this.ingredientLabel);
            this.Controls.Add(this.recipeListBox);
            this.Controls.Add(this.recipesLabel);
            this.Name = "mainForm";
            this.Text = "Varecka";
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cookBookMDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CookBookMDFDataSet cookBookMDFDataSet;
        private System.Windows.Forms.Label recipesLabel;
        private System.Windows.Forms.ListBox recipeListBox;
        private System.Windows.Forms.ListBox ingredientListbox;
        private System.Windows.Forms.Label ingredientLabel;
    }
}


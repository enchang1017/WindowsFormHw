namespace Homework1
{
    partial class RestaurantSide
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
            this._restaurantTabControl = new System.Windows.Forms.TabControl();
            this._mealManagerTabPage = new System.Windows.Forms.TabPage();
            this._categoryManagerTabPage = new System.Windows.Forms.TabPage();
            this._mealListBox = new System.Windows.Forms.ListBox();
            this._addNewMealButton = new System.Windows.Forms.Button();
            this._deleteMealButton = new System.Windows.Forms.Button();
            this._editMealGroupBox = new System.Windows.Forms.GroupBox();
            this._mealNeamTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._mealPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._mealCateogryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._mealPathTextBox = new System.Windows.Forms.TextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._MealSaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._categoryListBox = new System.Windows.Forms.ListBox();
            this._addCategoryButton = new System.Windows.Forms.Button();
            this._daleteCategoryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this._categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._usingCategoryListBox = new System.Windows.Forms.ListBox();
            this._categorySaveButton = new System.Windows.Forms.Button();
            this._restaurantTabControl.SuspendLayout();
            this._mealManagerTabPage.SuspendLayout();
            this._categoryManagerTabPage.SuspendLayout();
            this._editMealGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _restaurantTabControl
            // 
            this._restaurantTabControl.Controls.Add(this._mealManagerTabPage);
            this._restaurantTabControl.Controls.Add(this._categoryManagerTabPage);
            this._restaurantTabControl.Location = new System.Drawing.Point(9, 10);
            this._restaurantTabControl.Name = "_restaurantTabControl";
            this._restaurantTabControl.SelectedIndex = 0;
            this._restaurantTabControl.Size = new System.Drawing.Size(1031, 508);
            this._restaurantTabControl.TabIndex = 0;
            // 
            // _mealManagerTabPage
            // 
            this._mealManagerTabPage.Controls.Add(this._editMealGroupBox);
            this._mealManagerTabPage.Controls.Add(this._deleteMealButton);
            this._mealManagerTabPage.Controls.Add(this._addNewMealButton);
            this._mealManagerTabPage.Controls.Add(this._mealListBox);
            this._mealManagerTabPage.Location = new System.Drawing.Point(4, 22);
            this._mealManagerTabPage.Name = "_mealManagerTabPage";
            this._mealManagerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._mealManagerTabPage.Size = new System.Drawing.Size(1023, 482);
            this._mealManagerTabPage.TabIndex = 0;
            this._mealManagerTabPage.Text = "Meal Manager";
            this._mealManagerTabPage.UseVisualStyleBackColor = true;
            // 
            // _categoryManagerTabPage
            // 
            this._categoryManagerTabPage.Controls.Add(this.groupBox1);
            this._categoryManagerTabPage.Controls.Add(this._daleteCategoryButton);
            this._categoryManagerTabPage.Controls.Add(this._addCategoryButton);
            this._categoryManagerTabPage.Controls.Add(this._categoryListBox);
            this._categoryManagerTabPage.Location = new System.Drawing.Point(4, 22);
            this._categoryManagerTabPage.Name = "_categoryManagerTabPage";
            this._categoryManagerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._categoryManagerTabPage.Size = new System.Drawing.Size(1023, 482);
            this._categoryManagerTabPage.TabIndex = 1;
            this._categoryManagerTabPage.Text = "Category Manager";
            this._categoryManagerTabPage.UseVisualStyleBackColor = true;
            // 
            // _mealListBox
            // 
            this._mealListBox.FormattingEnabled = true;
            this._mealListBox.Location = new System.Drawing.Point(9, 11);
            this._mealListBox.Name = "_mealListBox";
            this._mealListBox.Size = new System.Drawing.Size(395, 420);
            this._mealListBox.TabIndex = 0;
            this._mealListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedChangedEventMealListBox);
            // 
            // _addNewMealButton
            // 
            this._addNewMealButton.Location = new System.Drawing.Point(9, 446);
            this._addNewMealButton.Name = "_addNewMealButton";
            this._addNewMealButton.Size = new System.Drawing.Size(152, 24);
            this._addNewMealButton.TabIndex = 1;
            this._addNewMealButton.Text = "Add New Meal";
            this._addNewMealButton.UseVisualStyleBackColor = true;
            // 
            // _deleteMealButton
            // 
            this._deleteMealButton.Location = new System.Drawing.Point(252, 446);
            this._deleteMealButton.Name = "_deleteMealButton";
            this._deleteMealButton.Size = new System.Drawing.Size(152, 24);
            this._deleteMealButton.TabIndex = 2;
            this._deleteMealButton.Text = "Delete Selected Meal";
            this._deleteMealButton.UseVisualStyleBackColor = true;
            // 
            // _editMealGroupBox
            // 
            this._editMealGroupBox.Controls.Add(this.label6);
            this._editMealGroupBox.Controls.Add(this._MealSaveButton);
            this._editMealGroupBox.Controls.Add(this._descriptionRichTextBox);
            this._editMealGroupBox.Controls.Add(this._browseButton);
            this._editMealGroupBox.Controls.Add(this._mealPathTextBox);
            this._editMealGroupBox.Controls.Add(this.label5);
            this._editMealGroupBox.Controls.Add(this._mealCateogryComboBox);
            this._editMealGroupBox.Controls.Add(this.label4);
            this._editMealGroupBox.Controls.Add(this.label3);
            this._editMealGroupBox.Controls.Add(this._mealPriceTextBox);
            this._editMealGroupBox.Controls.Add(this.label2);
            this._editMealGroupBox.Controls.Add(this.label1);
            this._editMealGroupBox.Controls.Add(this._mealNeamTextBox);
            this._editMealGroupBox.Location = new System.Drawing.Point(416, 12);
            this._editMealGroupBox.Name = "_editMealGroupBox";
            this._editMealGroupBox.Size = new System.Drawing.Size(593, 457);
            this._editMealGroupBox.TabIndex = 3;
            this._editMealGroupBox.TabStop = false;
            this._editMealGroupBox.Text = "EditMeal";
            // 
            // _mealNeamTextBox
            // 
            this._mealNeamTextBox.Location = new System.Drawing.Point(134, 41);
            this._mealNeamTextBox.Name = "_mealNeamTextBox";
            this._mealNeamTextBox.Size = new System.Drawing.Size(433, 20);
            this._mealNeamTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meal Name (*)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(43, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meal Price (*)";
            // 
            // _mealPriceTextBox
            // 
            this._mealPriceTextBox.Location = new System.Drawing.Point(134, 111);
            this._mealPriceTextBox.Name = "_mealPriceTextBox";
            this._mealPriceTextBox.Size = new System.Drawing.Size(131, 20);
            this._mealPriceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(271, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "NTD";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(316, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Meal Category (*)";
            // 
            // _mealCateogryComboBox
            // 
            this._mealCateogryComboBox.FormattingEnabled = true;
            this._mealCateogryComboBox.Location = new System.Drawing.Point(419, 110);
            this._mealCateogryComboBox.Name = "_mealCateogryComboBox";
            this._mealCateogryComboBox.Size = new System.Drawing.Size(148, 21);
            this._mealCateogryComboBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(43, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Meal Image Relative Path (*)";
            // 
            // _mealPathTextBox
            // 
            this._mealPathTextBox.Location = new System.Drawing.Point(197, 192);
            this._mealPathTextBox.Name = "_mealPathTextBox";
            this._mealPathTextBox.Size = new System.Drawing.Size(283, 20);
            this._mealPathTextBox.TabIndex = 8;
            // 
            // _browseButton
            // 
            this._browseButton.Location = new System.Drawing.Point(498, 187);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(69, 25);
            this._browseButton.TabIndex = 9;
            this._browseButton.Text = "Browse...";
            this._browseButton.UseVisualStyleBackColor = true;
            // 
            // _descriptionRichTextBox
            // 
            this._descriptionRichTextBox.Location = new System.Drawing.Point(46, 254);
            this._descriptionRichTextBox.Name = "_descriptionRichTextBox";
            this._descriptionRichTextBox.Size = new System.Drawing.Size(521, 165);
            this._descriptionRichTextBox.TabIndex = 10;
            this._descriptionRichTextBox.Text = "";
            // 
            // _MealSaveButton
            // 
            this._MealSaveButton.Location = new System.Drawing.Point(498, 425);
            this._MealSaveButton.Name = "_MealSaveButton";
            this._MealSaveButton.Size = new System.Drawing.Size(69, 25);
            this._MealSaveButton.TabIndex = 11;
            this._MealSaveButton.Text = "Save";
            this._MealSaveButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(43, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Meal Description";
            // 
            // _categoryListBox
            // 
            this._categoryListBox.FormattingEnabled = true;
            this._categoryListBox.Location = new System.Drawing.Point(9, 11);
            this._categoryListBox.Name = "_categoryListBox";
            this._categoryListBox.Size = new System.Drawing.Size(395, 420);
            this._categoryListBox.TabIndex = 0;
            // 
            // _addCategoryButton
            // 
            this._addCategoryButton.Location = new System.Drawing.Point(9, 446);
            this._addCategoryButton.Name = "_addCategoryButton";
            this._addCategoryButton.Size = new System.Drawing.Size(152, 24);
            this._addCategoryButton.TabIndex = 1;
            this._addCategoryButton.Text = "Add Category";
            this._addCategoryButton.UseVisualStyleBackColor = true;
            // 
            // _daleteCategoryButton
            // 
            this._daleteCategoryButton.Location = new System.Drawing.Point(252, 446);
            this._daleteCategoryButton.Name = "_daleteCategoryButton";
            this._daleteCategoryButton.Size = new System.Drawing.Size(152, 24);
            this._daleteCategoryButton.TabIndex = 2;
            this._daleteCategoryButton.Text = "Delete Selected Category";
            this._daleteCategoryButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._categorySaveButton);
            this.groupBox1.Controls.Add(this._usingCategoryListBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._categoryNameTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(416, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 457);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(43, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Category Name (*)";
            // 
            // _categoryNameTextBox
            // 
            this._categoryNameTextBox.Location = new System.Drawing.Point(134, 41);
            this._categoryNameTextBox.Name = "_categoryNameTextBox";
            this._categoryNameTextBox.Size = new System.Drawing.Size(433, 20);
            this._categoryNameTextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(43, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Meals Using this Category:";
            // 
            // _usingCategoryListBox
            // 
            this._usingCategoryListBox.FormattingEnabled = true;
            this._usingCategoryListBox.Location = new System.Drawing.Point(46, 121);
            this._usingCategoryListBox.Name = "_usingCategoryListBox";
            this._usingCategoryListBox.Size = new System.Drawing.Size(520, 290);
            this._usingCategoryListBox.TabIndex = 13;
            // 
            // _categorySaveButton
            // 
            this._categorySaveButton.Location = new System.Drawing.Point(497, 426);
            this._categorySaveButton.Name = "_categorySaveButton";
            this._categorySaveButton.Size = new System.Drawing.Size(69, 25);
            this._categorySaveButton.TabIndex = 14;
            this._categorySaveButton.Text = "Save";
            this._categorySaveButton.UseVisualStyleBackColor = true;
            // 
            // RestaurantSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 529);
            this.Controls.Add(this._restaurantTabControl);
            this.Name = "RestaurantSide";
            this.Text = "RestaurantSide";
            this._restaurantTabControl.ResumeLayout(false);
            this._mealManagerTabPage.ResumeLayout(false);
            this._categoryManagerTabPage.ResumeLayout(false);
            this._editMealGroupBox.ResumeLayout(false);
            this._editMealGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void _mealListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl _restaurantTabControl;
        private System.Windows.Forms.TabPage _mealManagerTabPage;
        private System.Windows.Forms.GroupBox _editMealGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _mealCateogryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _mealPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _mealNeamTextBox;
        private System.Windows.Forms.Button _deleteMealButton;
        private System.Windows.Forms.Button _addNewMealButton;
        private System.Windows.Forms.ListBox _mealListBox;
        private System.Windows.Forms.TabPage _categoryManagerTabPage;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.TextBox _mealPathTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _MealSaveButton;
        private System.Windows.Forms.RichTextBox _descriptionRichTextBox;
        private System.Windows.Forms.ListBox _categoryListBox;
        private System.Windows.Forms.Button _daleteCategoryButton;
        private System.Windows.Forms.Button _addCategoryButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox _usingCategoryListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _categoryNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button _categorySaveButton;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this._restaurantTabControl = new System.Windows.Forms.TabControl();
            this._mealManagerTabPage = new System.Windows.Forms.TabPage();
            this._editMealGroupBox = new System.Windows.Forms.GroupBox();
            this._mealDescriptionLabel = new System.Windows.Forms.Label();
            this._mealSaveButton = new System.Windows.Forms.Button();
            this._descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._browseButton = new System.Windows.Forms.Button();
            this._mealPathTextBox = new System.Windows.Forms.TextBox();
            this._mealPathLabel = new System.Windows.Forms.Label();
            this._mealCategoryComboBox = new System.Windows.Forms.ComboBox();
            this._mealCategoryLabel = new System.Windows.Forms.Label();
            this._unitLabel = new System.Windows.Forms.Label();
            this._mealPriceTextBox = new System.Windows.Forms.TextBox();
            this._mealPriceLabel = new System.Windows.Forms.Label();
            this._mealNameLabel = new System.Windows.Forms.Label();
            this._mealNameTextBox = new System.Windows.Forms.TextBox();
            this._deleteMealButton = new System.Windows.Forms.Button();
            this._addNewMealButton = new System.Windows.Forms.Button();
            this._mealListBox = new System.Windows.Forms.ListBox();
            this._mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._categoryManagerTabPage = new System.Windows.Forms.TabPage();
            this._editCategoryGroupBox = new System.Windows.Forms.GroupBox();
            this._categorySaveButton = new System.Windows.Forms.Button();
            this._usingCategoryListBox = new System.Windows.Forms.ListBox();
            this._mealUsingLabel = new System.Windows.Forms.Label();
            this._categoryNameTextBox = new System.Windows.Forms.TextBox();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._deleteCategoryButton = new System.Windows.Forms.Button();
            this._addCategoryButton = new System.Windows.Forms.Button();
            this._categoryListBox = new System.Windows.Forms.ListBox();
            this._mealBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._restaurantTabControl.SuspendLayout();
            this._mealManagerTabPage.SuspendLayout();
            this._editMealGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource)).BeginInit();
            this._categoryManagerTabPage.SuspendLayout();
            this._editCategoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _restaurantTabControl
            // 
            this._restaurantTabControl.AccessibleName = "restaurantTabControl";
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
            this._mealManagerTabPage.AccessibleName = "mealTabPage";
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
            // _editMealGroupBox
            // 
            this._editMealGroupBox.Controls.Add(this._mealDescriptionLabel);
            this._editMealGroupBox.Controls.Add(this._mealSaveButton);
            this._editMealGroupBox.Controls.Add(this._descriptionRichTextBox);
            this._editMealGroupBox.Controls.Add(this._browseButton);
            this._editMealGroupBox.Controls.Add(this._mealPathTextBox);
            this._editMealGroupBox.Controls.Add(this._mealPathLabel);
            this._editMealGroupBox.Controls.Add(this._mealCategoryComboBox);
            this._editMealGroupBox.Controls.Add(this._mealCategoryLabel);
            this._editMealGroupBox.Controls.Add(this._unitLabel);
            this._editMealGroupBox.Controls.Add(this._mealPriceTextBox);
            this._editMealGroupBox.Controls.Add(this._mealPriceLabel);
            this._editMealGroupBox.Controls.Add(this._mealNameLabel);
            this._editMealGroupBox.Controls.Add(this._mealNameTextBox);
            this._editMealGroupBox.Location = new System.Drawing.Point(416, 12);
            this._editMealGroupBox.Name = "_editMealGroupBox";
            this._editMealGroupBox.Size = new System.Drawing.Size(593, 457);
            this._editMealGroupBox.TabIndex = 3;
            this._editMealGroupBox.TabStop = false;
            this._editMealGroupBox.Text = "EditMeal";
            // 
            // _mealDescriptionLabel
            // 
            this._mealDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._mealDescriptionLabel.Location = new System.Drawing.Point(43, 236);
            this._mealDescriptionLabel.Name = "_mealDescriptionLabel";
            this._mealDescriptionLabel.Size = new System.Drawing.Size(101, 15);
            this._mealDescriptionLabel.TabIndex = 12;
            this._mealDescriptionLabel.Text = "Meal Description";
            // 
            // _mealSaveButton
            // 
            this._mealSaveButton.AccessibleName = "mealSave";
            this._mealSaveButton.Enabled = false;
            this._mealSaveButton.Location = new System.Drawing.Point(498, 425);
            this._mealSaveButton.Name = "_mealSaveButton";
            this._mealSaveButton.Size = new System.Drawing.Size(69, 25);
            this._mealSaveButton.TabIndex = 11;
            this._mealSaveButton.Text = "Save";
            this._mealSaveButton.UseVisualStyleBackColor = true;
            this._mealSaveButton.Click += new System.EventHandler(this.ClickMealSaveButton);
            // 
            // _descriptionRichTextBox
            // 
            this._descriptionRichTextBox.AccessibleName = "mealDescription";
            this._descriptionRichTextBox.Location = new System.Drawing.Point(46, 254);
            this._descriptionRichTextBox.Name = "_descriptionRichTextBox";
            this._descriptionRichTextBox.Size = new System.Drawing.Size(521, 165);
            this._descriptionRichTextBox.TabIndex = 10;
            this._descriptionRichTextBox.Text = "";
            // 
            // _browseButton
            // 
            this._browseButton.AccessibleName = "browseButton";
            this._browseButton.Location = new System.Drawing.Point(498, 187);
            this._browseButton.Name = "_browseButton";
            this._browseButton.Size = new System.Drawing.Size(69, 25);
            this._browseButton.TabIndex = 9;
            this._browseButton.Text = "Browse...";
            this._browseButton.UseVisualStyleBackColor = true;
            this._browseButton.Click += new System.EventHandler(this.BrowseImageFile);
            // 
            // _mealPathTextBox
            // 
            this._mealPathTextBox.AccessibleName = "mealPath";
            this._mealPathTextBox.Location = new System.Drawing.Point(197, 192);
            this._mealPathTextBox.Name = "_mealPathTextBox";
            this._mealPathTextBox.ReadOnly = true;
            this._mealPathTextBox.Size = new System.Drawing.Size(283, 20);
            this._mealPathTextBox.TabIndex = 8;
            // 
            // _mealPathLabel
            // 
            this._mealPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._mealPathLabel.Location = new System.Drawing.Point(43, 197);
            this._mealPathLabel.Name = "_mealPathLabel";
            this._mealPathLabel.Size = new System.Drawing.Size(209, 15);
            this._mealPathLabel.TabIndex = 7;
            this._mealPathLabel.Text = "Meal Image Relative Path (*)";
            // 
            // _mealCategoryComboBox
            // 
            this._mealCategoryComboBox.AccessibleName = "mealCategoryComboBox";
            this._mealCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._mealCategoryComboBox.FormattingEnabled = true;
            this._mealCategoryComboBox.Location = new System.Drawing.Point(419, 110);
            this._mealCategoryComboBox.Name = "_mealCategoryComboBox";
            this._mealCategoryComboBox.Size = new System.Drawing.Size(148, 21);
            this._mealCategoryComboBox.TabIndex = 6;
            // 
            // _mealCategoryLabel
            // 
            this._mealCategoryLabel.AccessibleName = "mealCategory";
            this._mealCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._mealCategoryLabel.Location = new System.Drawing.Point(316, 116);
            this._mealCategoryLabel.Name = "_mealCategoryLabel";
            this._mealCategoryLabel.Size = new System.Drawing.Size(97, 15);
            this._mealCategoryLabel.TabIndex = 5;
            this._mealCategoryLabel.Text = "Meal Category (*)";
            // 
            // _unitLabel
            // 
            this._unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._unitLabel.Location = new System.Drawing.Point(271, 114);
            this._unitLabel.Name = "_unitLabel";
            this._unitLabel.Size = new System.Drawing.Size(75, 15);
            this._unitLabel.TabIndex = 4;
            this._unitLabel.Text = "NTD";
            // 
            // _mealPriceTextBox
            // 
            this._mealPriceTextBox.AccessibleName = "mealPrice";
            this._mealPriceTextBox.Location = new System.Drawing.Point(134, 111);
            this._mealPriceTextBox.Name = "_mealPriceTextBox";
            this._mealPriceTextBox.Size = new System.Drawing.Size(131, 20);
            this._mealPriceTextBox.TabIndex = 3;
            // 
            // _mealPriceLabel
            // 
            this._mealPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._mealPriceLabel.Location = new System.Drawing.Point(43, 116);
            this._mealPriceLabel.Name = "_mealPriceLabel";
            this._mealPriceLabel.Size = new System.Drawing.Size(75, 15);
            this._mealPriceLabel.TabIndex = 2;
            this._mealPriceLabel.Text = "Meal Price (*)";
            // 
            // _mealNameLabel
            // 
            this._mealNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._mealNameLabel.Location = new System.Drawing.Point(43, 44);
            this._mealNameLabel.Name = "_mealNameLabel";
            this._mealNameLabel.Size = new System.Drawing.Size(75, 15);
            this._mealNameLabel.TabIndex = 1;
            this._mealNameLabel.Text = "Meal Name (*)";
            // 
            // _mealNameTextBox
            // 
            this._mealNameTextBox.AccessibleName = "mealName";
            this._mealNameTextBox.Location = new System.Drawing.Point(134, 41);
            this._mealNameTextBox.Name = "_mealNameTextBox";
            this._mealNameTextBox.Size = new System.Drawing.Size(433, 20);
            this._mealNameTextBox.TabIndex = 0;
            // 
            // _deleteMealButton
            // 
            this._deleteMealButton.AccessibleName = "deleteMeal";
            this._deleteMealButton.Location = new System.Drawing.Point(252, 446);
            this._deleteMealButton.Name = "_deleteMealButton";
            this._deleteMealButton.Size = new System.Drawing.Size(152, 24);
            this._deleteMealButton.TabIndex = 2;
            this._deleteMealButton.Text = "Delete Selected Meal";
            this._deleteMealButton.UseVisualStyleBackColor = true;
            this._deleteMealButton.Click += new System.EventHandler(this.ClickDeleteMealButton);
            // 
            // _addNewMealButton
            // 
            this._addNewMealButton.AccessibleName = "addMeal";
            this._addNewMealButton.Location = new System.Drawing.Point(9, 446);
            this._addNewMealButton.Name = "_addNewMealButton";
            this._addNewMealButton.Size = new System.Drawing.Size(152, 24);
            this._addNewMealButton.TabIndex = 1;
            this._addNewMealButton.Text = "Add New Meal";
            this._addNewMealButton.UseVisualStyleBackColor = true;
            this._addNewMealButton.Click += new System.EventHandler(this.ClickAddNewMealButton);
            // 
            // _mealListBox
            // 
            this._mealListBox.AccessibleName = "mealListBox";
            this._mealListBox.DataSource = this._mealBindingSource;
            this._mealListBox.DisplayMember = "MealName";
            this._mealListBox.FormattingEnabled = true;
            this._mealListBox.Location = new System.Drawing.Point(9, 11);
            this._mealListBox.Name = "_mealListBox";
            this._mealListBox.Size = new System.Drawing.Size(395, 420);
            this._mealListBox.TabIndex = 0;
            // 
            // _mealBindingSource
            // 
            this._mealBindingSource.DataSource = typeof(Homework1.Model.Meal);
            // 
            // _categoryManagerTabPage
            // 
            this._categoryManagerTabPage.AccessibleName = "categoryTabPage";
            this._categoryManagerTabPage.Controls.Add(this._editCategoryGroupBox);
            this._categoryManagerTabPage.Controls.Add(this._deleteCategoryButton);
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
            // _editCategoryGroupBox
            // 
            this._editCategoryGroupBox.Controls.Add(this._categorySaveButton);
            this._editCategoryGroupBox.Controls.Add(this._usingCategoryListBox);
            this._editCategoryGroupBox.Controls.Add(this._mealUsingLabel);
            this._editCategoryGroupBox.Controls.Add(this._categoryNameTextBox);
            this._editCategoryGroupBox.Controls.Add(this._categoryNameLabel);
            this._editCategoryGroupBox.Location = new System.Drawing.Point(416, 12);
            this._editCategoryGroupBox.Name = "_editCategoryGroupBox";
            this._editCategoryGroupBox.Size = new System.Drawing.Size(593, 457);
            this._editCategoryGroupBox.TabIndex = 3;
            this._editCategoryGroupBox.TabStop = false;
            this._editCategoryGroupBox.Text = "Edit Category";
            // 
            // _categorySaveButton
            // 
            this._categorySaveButton.AccessibleName = "saveCategory";
            this._categorySaveButton.Enabled = false;
            this._categorySaveButton.Location = new System.Drawing.Point(497, 426);
            this._categorySaveButton.Name = "_categorySaveButton";
            this._categorySaveButton.Size = new System.Drawing.Size(69, 25);
            this._categorySaveButton.TabIndex = 14;
            this._categorySaveButton.Text = "Save";
            this._categorySaveButton.UseVisualStyleBackColor = true;
            this._categorySaveButton.Click += new System.EventHandler(this.ClickCategorySaveButton);
            // 
            // _usingCategoryListBox
            // 
            this._usingCategoryListBox.AccessibleName = "usingCategoryList";
            this._usingCategoryListBox.FormattingEnabled = true;
            this._usingCategoryListBox.Location = new System.Drawing.Point(46, 121);
            this._usingCategoryListBox.Name = "_usingCategoryListBox";
            this._usingCategoryListBox.Size = new System.Drawing.Size(520, 290);
            this._usingCategoryListBox.TabIndex = 13;
            // 
            // _mealUsingLabel
            // 
            this._mealUsingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._mealUsingLabel.Location = new System.Drawing.Point(43, 96);
            this._mealUsingLabel.Name = "_mealUsingLabel";
            this._mealUsingLabel.Size = new System.Drawing.Size(166, 15);
            this._mealUsingLabel.TabIndex = 12;
            this._mealUsingLabel.Text = "Meals Using this Category:";
            // 
            // _categoryNameTextBox
            // 
            this._categoryNameTextBox.AccessibleName = "categoryName";
            this._categoryNameTextBox.Location = new System.Drawing.Point(155, 41);
            this._categoryNameTextBox.Name = "_categoryNameTextBox";
            this._categoryNameTextBox.Size = new System.Drawing.Size(412, 20);
            this._categoryNameTextBox.TabIndex = 3;
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._categoryNameLabel.Location = new System.Drawing.Point(43, 44);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(106, 15);
            this._categoryNameLabel.TabIndex = 2;
            this._categoryNameLabel.Text = "Category Name (*)";
            // 
            // _deleteCategoryButton
            // 
            this._deleteCategoryButton.AccessibleName = "deleteCategory";
            this._deleteCategoryButton.Location = new System.Drawing.Point(252, 446);
            this._deleteCategoryButton.Name = "_deleteCategoryButton";
            this._deleteCategoryButton.Size = new System.Drawing.Size(152, 24);
            this._deleteCategoryButton.TabIndex = 2;
            this._deleteCategoryButton.Text = "Delete Selected Category";
            this._deleteCategoryButton.UseVisualStyleBackColor = true;
            this._deleteCategoryButton.Click += new System.EventHandler(this.ClickDeleteCategoryButton);
            // 
            // _addCategoryButton
            // 
            this._addCategoryButton.AccessibleName = "addCategory";
            this._addCategoryButton.Location = new System.Drawing.Point(9, 446);
            this._addCategoryButton.Name = "_addCategoryButton";
            this._addCategoryButton.Size = new System.Drawing.Size(152, 24);
            this._addCategoryButton.TabIndex = 1;
            this._addCategoryButton.Text = "Add Category";
            this._addCategoryButton.UseVisualStyleBackColor = true;
            this._addCategoryButton.Click += new System.EventHandler(this.ClickAddCategoryButton);
            // 
            // _categoryListBox
            // 
            this._categoryListBox.AccessibleName = "categoryListBox";
            this._categoryListBox.FormattingEnabled = true;
            this._categoryListBox.Location = new System.Drawing.Point(9, 11);
            this._categoryListBox.Name = "_categoryListBox";
            this._categoryListBox.Size = new System.Drawing.Size(395, 420);
            this._categoryListBox.TabIndex = 0;
            this._categoryListBox.SelectedIndexChanged += new System.EventHandler(this.SelectChangedEventCategoryListBox);
            // 
            // _mealBindingSource1
            // 
            this._mealBindingSource1.DataSource = typeof(Homework1.Model.Meal);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "_openFileDialog";
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
            this._editMealGroupBox.ResumeLayout(false);
            this._editMealGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource)).EndInit();
            this._categoryManagerTabPage.ResumeLayout(false);
            this._editCategoryGroupBox.ResumeLayout(false);
            this._editCategoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }
        /// <summary>
        /// 123
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _mealListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl _restaurantTabControl;
        private System.Windows.Forms.TabPage _mealManagerTabPage;
        private System.Windows.Forms.GroupBox _editMealGroupBox;
        private System.Windows.Forms.Label _mealPathLabel;
        private System.Windows.Forms.ComboBox _mealCategoryComboBox;
        private System.Windows.Forms.Label _mealCategoryLabel;
        private System.Windows.Forms.Label _unitLabel;
        private System.Windows.Forms.TextBox _mealPriceTextBox;
        private System.Windows.Forms.Label _mealPriceLabel;
        private System.Windows.Forms.Label _mealNameLabel;
        private System.Windows.Forms.TextBox _mealNameTextBox;
        private System.Windows.Forms.Button _deleteMealButton;
        private System.Windows.Forms.Button _addNewMealButton;
        private System.Windows.Forms.ListBox _mealListBox;
        private System.Windows.Forms.TabPage _categoryManagerTabPage;
        private System.Windows.Forms.Button _browseButton;
        private System.Windows.Forms.TextBox _mealPathTextBox;
        private System.Windows.Forms.Label _mealDescriptionLabel;
        private System.Windows.Forms.Button _mealSaveButton;
        private System.Windows.Forms.RichTextBox _descriptionRichTextBox;
        private System.Windows.Forms.ListBox _categoryListBox;
        private System.Windows.Forms.Button _deleteCategoryButton;
        private System.Windows.Forms.Button _addCategoryButton;
        private System.Windows.Forms.GroupBox _editCategoryGroupBox;
        private System.Windows.Forms.ListBox _usingCategoryListBox;
        private System.Windows.Forms.Label _mealUsingLabel;
        private System.Windows.Forms.TextBox _categoryNameTextBox;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.Button _categorySaveButton;
        private System.Windows.Forms.BindingSource _mealBindingSource;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.BindingSource _mealBindingSource1;
    }
}
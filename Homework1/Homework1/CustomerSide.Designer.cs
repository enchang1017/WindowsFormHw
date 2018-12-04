namespace Homework1
{
    partial class CustomerSide
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._deleteColumns = new System.Windows.Forms.DataGridViewButtonColumn();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._categoryTabControl = new System.Windows.Forms.TabControl();
            this._mealDescriptionBox = new System.Windows.Forms.RichTextBox();
            this._addButton = new System.Windows.Forms.Button();
            this._previousPageButton = new System.Windows.Forms.Button();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._pageLabel = new System.Windows.Forms.Label();
            this._mealNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantityDataGridViewTextBoxColumn = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._mealBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this._mealGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.AccessibleName = "dataGridView";
            this._orderDataGridView.AllowUserToAddRows = false;
            this._orderDataGridView.AutoGenerateColumns = false;
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumns,
            this._mealNameDataGridViewTextBoxColumn,
            this._mealPriceDataGridViewTextBoxColumn,
            this._categoryDataGridViewTextBoxColumn,
            this._quantityDataGridViewTextBoxColumn,
            this._subtotalDataGridViewTextBoxColumn});
            this._orderDataGridView.DataSource = this._mealBindingSource;
            this._orderDataGridView.Location = new System.Drawing.Point(565, 26);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.RowHeadersVisible = false;
            this._orderDataGridView.Size = new System.Drawing.Size(540, 731);
            this._orderDataGridView.TabIndex = 0;
            this._orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickDataGridViewCellContent);
            // 
            // _deleteColumns
            // 
            this._deleteColumns.DataPropertyName = "Delete";
            this._deleteColumns.HeaderText = "Delete";
            this._deleteColumns.Name = "_deleteColumns";
            this._deleteColumns.ReadOnly = true;
            this._deleteColumns.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._deleteColumns.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _totalLabel
            // 
            this._totalLabel.AccessibleName = "totalPriceLabel";
            this._totalLabel.AutoSize = true;
            this._totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this._totalLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold);
            this._totalLabel.ForeColor = System.Drawing.Color.DarkRed;
            this._totalLabel.Location = new System.Drawing.Point(949, 775);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(89, 27);
            this._totalLabel.TabIndex = 1;
            this._totalLabel.Text = "Label1";
            this._totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._categoryTabControl);
            this._mealGroupBox.Controls.Add(this._mealDescriptionBox);
            this._mealGroupBox.Controls.Add(this._addButton);
            this._mealGroupBox.Controls.Add(this._previousPageButton);
            this._mealGroupBox.Controls.Add(this._nextPageButton);
            this._mealGroupBox.Controls.Add(this._pageLabel);
            this._mealGroupBox.Location = new System.Drawing.Point(12, 26);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(515, 731);
            this._mealGroupBox.TabIndex = 2;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meals";
            // 
            // _categoryTabControl
            // 
            this._categoryTabControl.AccessibleName = "mealTabControl";
            this._categoryTabControl.Location = new System.Drawing.Point(6, 19);
            this._categoryTabControl.Name = "_categoryTabControl";
            this._categoryTabControl.SelectedIndex = 0;
            this._categoryTabControl.Size = new System.Drawing.Size(502, 520);
            this._categoryTabControl.TabIndex = 5;
            // 
            // _mealDescriptionBox
            // 
            this._mealDescriptionBox.AccessibleName = "descriptionBox";
            this._mealDescriptionBox.Location = new System.Drawing.Point(6, 545);
            this._mealDescriptionBox.Name = "_mealDescriptionBox";
            this._mealDescriptionBox.ReadOnly = true;
            this._mealDescriptionBox.Size = new System.Drawing.Size(502, 114);
            this._mealDescriptionBox.TabIndex = 4;
            this._mealDescriptionBox.Text = "";
            // 
            // _addButton
            // 
            this._addButton.AccessibleName = "addButton";
            this._addButton.Enabled = false;
            this._addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this._addButton.Location = new System.Drawing.Point(389, 668);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 23);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _previousPageButton
            // 
            this._previousPageButton.AccessibleName = "previousPage";
            this._previousPageButton.Location = new System.Drawing.Point(236, 696);
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(120, 23);
            this._previousPageButton.TabIndex = 2;
            this._previousPageButton.Text = "Previous Page";
            this._previousPageButton.UseVisualStyleBackColor = true;
            this._previousPageButton.Click += new System.EventHandler(this.ClickPreviousPageButton);
            // 
            // _nextPageButton
            // 
            this._nextPageButton.AccessibleName = "nextPage";
            this._nextPageButton.Location = new System.Drawing.Point(389, 697);
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(120, 23);
            this._nextPageButton.TabIndex = 1;
            this._nextPageButton.Text = "Next Page";
            this._nextPageButton.UseVisualStyleBackColor = true;
            this._nextPageButton.Click += new System.EventHandler(this.ClickNextPageButton);
            // 
            // _pageLabel
            // 
            this._pageLabel.AccessibleName = "pageLabel";
            this._pageLabel.AutoSize = true;
            this._pageLabel.Font = new System.Drawing.Font("新細明體", 16F);
            this._pageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._pageLabel.Location = new System.Drawing.Point(6, 697);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(60, 22);
            this._pageLabel.TabIndex = 0;
            this._pageLabel.Text = "label1";
            // 
            // _mealNameDataGridViewTextBoxColumn
            // 
            this._mealNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._mealNameDataGridViewTextBoxColumn.DataPropertyName = "MealName";
            this._mealNameDataGridViewTextBoxColumn.HeaderText = "Meal Name";
            this._mealNameDataGridViewTextBoxColumn.Name = "_mealNameDataGridViewTextBoxColumn";
            this._mealNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _mealPriceDataGridViewTextBoxColumn
            // 
            this._mealPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._mealPriceDataGridViewTextBoxColumn.DataPropertyName = "MealPrice";
            this._mealPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this._mealPriceDataGridViewTextBoxColumn.Name = "_mealPriceDataGridViewTextBoxColumn";
            this._mealPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _categoryDataGridViewTextBoxColumn
            // 
            this._categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this._categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this._categoryDataGridViewTextBoxColumn.Name = "_categoryDataGridViewTextBoxColumn";
            this._categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _quantityDataGridViewTextBoxColumn
            // 
            this._quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this._quantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            this._quantityDataGridViewTextBoxColumn.Name = "_quantityDataGridViewTextBoxColumn";
            this._quantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._quantityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _subtotalDataGridViewTextBoxColumn
            // 
            this._subtotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this._subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this._subtotalDataGridViewTextBoxColumn.Name = "_subtotalDataGridViewTextBoxColumn";
            this._subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _mealBindingSource
            // 
            this._mealBindingSource.DataSource = typeof(Homework1.Model.Meal);
            // 
            // _mealBindingSource1
            // 
            this._mealBindingSource1.DataSource = typeof(Homework1.Model.Meal);
            // 
            // _orderBindingSource
            // 
            this._orderBindingSource.DataSource = typeof(Homework1.Model.Order);
            // 
            // CustomerSide
            // 
            this.AccessibleName = "CustomerForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 811);
            this.Controls.Add(this._mealGroupBox);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._orderDataGridView);
            this.Name = "CustomerSide";
            this.Text = "POS-Customer Side";
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).EndInit();
            this._mealGroupBox.ResumeLayout(false);
            this._mealGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._mealBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _orderDataGridView;
        private System.Windows.Forms.Label _totalLabel;
        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _previousPageButton;
        private System.Windows.Forms.Button _nextPageButton;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.RichTextBox _mealDescriptionBox;
        private System.Windows.Forms.TabControl _categoryTabControl;
        private System.Windows.Forms.BindingSource _mealBindingSource;
        private System.Windows.Forms.BindingSource _orderBindingSource;
        private System.Windows.Forms.BindingSource _mealBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _mealPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _categoryDataGridViewTextBoxColumn;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _subtotalDataGridViewTextBoxColumn;
    }
}


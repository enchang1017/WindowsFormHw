namespace Homework1
{
    partial class Form1
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
            this._orderDataGridView = new System.Windows.Forms.DataGridView();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._pageLabel = new System.Windows.Forms.Label();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._previousPageButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).BeginInit();
            this._mealGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _orderDataGridView
            // 
            this._orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDataGridView.Location = new System.Drawing.Point(565, 26);
            this._orderDataGridView.Name = "_orderDataGridView";
            this._orderDataGridView.Size = new System.Drawing.Size(543, 674);
            this._orderDataGridView.TabIndex = 0;
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this._totalLabel.Location = new System.Drawing.Point(895, 718);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(39, 13);
            this._totalLabel.TabIndex = 1;
            this._totalLabel.Text = "Label1";
            this._totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._addButton);
            this._mealGroupBox.Controls.Add(this._previousPageButton);
            this._mealGroupBox.Controls.Add(this._nextPageButton);
            this._mealGroupBox.Controls.Add(this._pageLabel);
            this._mealGroupBox.Location = new System.Drawing.Point(12, 26);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(515, 674);
            this._mealGroupBox.TabIndex = 2;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "groupBox1";
            // 
            // _pageLabel
            // 
            this._pageLabel.AutoSize = true;
            this._pageLabel.Location = new System.Drawing.Point(17, 646);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(35, 13);
            this._pageLabel.TabIndex = 0;
            this._pageLabel.Text = "label1";
            // 
            // _nextPageButton
            // 
            this._nextPageButton.Location = new System.Drawing.Point(389, 636);
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(75, 23);
            this._nextPageButton.TabIndex = 1;
            this._nextPageButton.Text = "button1";
            this._nextPageButton.UseVisualStyleBackColor = true;
            // 
            // _previousPageButton
            // 
            this._previousPageButton.Location = new System.Drawing.Point(238, 636);
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(75, 23);
            this._previousPageButton.TabIndex = 2;
            this._previousPageButton.Text = "button2";
            this._previousPageButton.UseVisualStyleBackColor = true;
            // 
            // _addButton
            // 
            this._addButton.Location = new System.Drawing.Point(389, 595);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(75, 23);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "button3";
            this._addButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 767);
            this.Controls.Add(this._mealGroupBox);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._orderDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._orderDataGridView)).EndInit();
            this._mealGroupBox.ResumeLayout(false);
            this._mealGroupBox.PerformLayout();
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
    }
}


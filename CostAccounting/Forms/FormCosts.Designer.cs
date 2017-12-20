namespace CostAccounting.Forms
{
    partial class FormCosts
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
            this.dgvCosts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameAnalytic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDateCostFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateCostTo = new System.Windows.Forms.DateTimePicker();
            this.clbAnalytics = new System.Windows.Forms.CheckedListBox();
            this.clbArticles = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxAllAnalytics = new System.Windows.Forms.CheckBox();
            this.checkBoxAllArticles = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteConMenuItemGrid = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosts)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCosts
            // 
            this.dgvCosts.AllowUserToAddRows = false;
            this.dgvCosts.AllowUserToDeleteRows = false;
            this.dgvCosts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameArticle,
            this.NameAnalytic,
            this.Date,
            this.Sum,
            this.Message});
            this.dgvCosts.ContextMenuStrip = this.contextMenuStrip;
            this.dgvCosts.Location = new System.Drawing.Point(13, 151);
            this.dgvCosts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCosts.Name = "dgvCosts";
            this.dgvCosts.Size = new System.Drawing.Size(746, 420);
            this.dgvCosts.TabIndex = 0;
            this.dgvCosts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCosts_CellValueChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NameArticle
            // 
            this.NameArticle.DataPropertyName = "NameArticle";
            this.NameArticle.HeaderText = "Статья";
            this.NameArticle.Name = "NameArticle";
            this.NameArticle.ReadOnly = true;
            this.NameArticle.Width = 150;
            // 
            // NameAnalytic
            // 
            this.NameAnalytic.DataPropertyName = "NameAnalytic";
            this.NameAnalytic.HeaderText = "Аналитика";
            this.NameAnalytic.Name = "NameAnalytic";
            this.NameAnalytic.ReadOnly = true;
            this.NameAnalytic.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Сумма";
            this.Sum.Name = "Sum";
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Комментарий";
            this.Message.Name = "Message";
            this.Message.Width = 200;
            // 
            // dtpDateCostFrom
            // 
            this.dtpDateCostFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCostFrom.Location = new System.Drawing.Point(26, 120);
            this.dtpDateCostFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateCostFrom.Name = "dtpDateCostFrom";
            this.dtpDateCostFrom.Size = new System.Drawing.Size(106, 23);
            this.dtpDateCostFrom.TabIndex = 1;
            // 
            // dtpDateCostTo
            // 
            this.dtpDateCostTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCostTo.Location = new System.Drawing.Point(140, 120);
            this.dtpDateCostTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateCostTo.Name = "dtpDateCostTo";
            this.dtpDateCostTo.Size = new System.Drawing.Size(106, 23);
            this.dtpDateCostTo.TabIndex = 2;
            // 
            // clbAnalytics
            // 
            this.clbAnalytics.CheckOnClick = true;
            this.clbAnalytics.FormattingEnabled = true;
            this.clbAnalytics.Location = new System.Drawing.Point(264, 49);
            this.clbAnalytics.Name = "clbAnalytics";
            this.clbAnalytics.Size = new System.Drawing.Size(164, 94);
            this.clbAnalytics.TabIndex = 3;
            // 
            // clbArticles
            // 
            this.clbArticles.CheckOnClick = true;
            this.clbArticles.FormattingEnabled = true;
            this.clbArticles.Location = new System.Drawing.Point(448, 49);
            this.clbArticles.Name = "clbArticles";
            this.clbArticles.Size = new System.Drawing.Size(164, 94);
            this.clbArticles.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(634, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Аналитики";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Статьи";
            // 
            // checkBoxAllAnalytics
            // 
            this.checkBoxAllAnalytics.AutoSize = true;
            this.checkBoxAllAnalytics.Location = new System.Drawing.Point(264, 26);
            this.checkBoxAllAnalytics.Name = "checkBoxAllAnalytics";
            this.checkBoxAllAnalytics.Size = new System.Drawing.Size(51, 21);
            this.checkBoxAllAnalytics.TabIndex = 8;
            this.checkBoxAllAnalytics.Text = "Все";
            this.checkBoxAllAnalytics.UseVisualStyleBackColor = true;
            this.checkBoxAllAnalytics.CheckedChanged += new System.EventHandler(this.checkBoxAllAnalytics_CheckedChanged);
            // 
            // checkBoxAllArticles
            // 
            this.checkBoxAllArticles.AutoSize = true;
            this.checkBoxAllArticles.Location = new System.Drawing.Point(448, 26);
            this.checkBoxAllArticles.Name = "checkBoxAllArticles";
            this.checkBoxAllArticles.Size = new System.Drawing.Size(51, 21);
            this.checkBoxAllArticles.TabIndex = 9;
            this.checkBoxAllArticles.Text = "Все";
            this.checkBoxAllArticles.UseVisualStyleBackColor = true;
            this.checkBoxAllArticles.CheckedChanged += new System.EventHandler(this.checkBoxAllArticles_CheckedChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteConMenuItemGrid});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // deleteConMenuItemGrid
            // 
            this.deleteConMenuItemGrid.Name = "deleteConMenuItemGrid";
            this.deleteConMenuItemGrid.Size = new System.Drawing.Size(118, 22);
            this.deleteConMenuItemGrid.Text = "Удалить";
            // 
            // FormCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 581);
            this.Controls.Add(this.checkBoxAllArticles);
            this.Controls.Add(this.checkBoxAllAnalytics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.clbArticles);
            this.Controls.Add(this.clbAnalytics);
            this.Controls.Add(this.dtpDateCostTo);
            this.Controls.Add(this.dtpDateCostFrom);
            this.Controls.Add(this.dgvCosts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCosts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ежедневный учет";
            this.Load += new System.EventHandler(this.FormCosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosts)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCosts;
        private System.Windows.Forms.DateTimePicker dtpDateCostFrom;
        private System.Windows.Forms.DateTimePicker dtpDateCostTo;
        private System.Windows.Forms.CheckedListBox clbAnalytics;
        private System.Windows.Forms.CheckedListBox clbArticles;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameAnalytic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.CheckBox checkBoxAllAnalytics;
        private System.Windows.Forms.CheckBox checkBoxAllArticles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteConMenuItemGrid;
    }
}
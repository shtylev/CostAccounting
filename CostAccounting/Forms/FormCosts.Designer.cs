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
            this.dgvCosts = new System.Windows.Forms.DataGridView();
            this.dtpDateCostFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateCostTo = new System.Windows.Forms.DateTimePicker();
            this.clbAnalytics = new System.Windows.Forms.CheckedListBox();
            this.clbArticles = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCosts
            // 
            this.dgvCosts.AllowUserToAddRows = false;
            this.dgvCosts.AllowUserToDeleteRows = false;
            this.dgvCosts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCosts.Location = new System.Drawing.Point(13, 114);
            this.dgvCosts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCosts.Name = "dgvCosts";
            this.dgvCosts.Size = new System.Drawing.Size(738, 293);
            this.dgvCosts.TabIndex = 0;
            // 
            // dtpDateCostFrom
            // 
            this.dtpDateCostFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCostFrom.Location = new System.Drawing.Point(11, 83);
            this.dtpDateCostFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateCostFrom.Name = "dtpDateCostFrom";
            this.dtpDateCostFrom.Size = new System.Drawing.Size(106, 23);
            this.dtpDateCostFrom.TabIndex = 1;
            // 
            // dtpDateCostTo
            // 
            this.dtpDateCostTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCostTo.Location = new System.Drawing.Point(136, 83);
            this.dtpDateCostTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDateCostTo.Name = "dtpDateCostTo";
            this.dtpDateCostTo.Size = new System.Drawing.Size(106, 23);
            this.dtpDateCostTo.TabIndex = 2;
            // 
            // clbAnalytics
            // 
            this.clbAnalytics.CheckOnClick = true;
            this.clbAnalytics.FormattingEnabled = true;
            this.clbAnalytics.Location = new System.Drawing.Point(261, 12);
            this.clbAnalytics.Name = "clbAnalytics";
            this.clbAnalytics.Size = new System.Drawing.Size(164, 94);
            this.clbAnalytics.TabIndex = 3;
            // 
            // clbArticles
            // 
            this.clbArticles.CheckOnClick = true;
            this.clbArticles.FormattingEnabled = true;
            this.clbArticles.Location = new System.Drawing.Point(452, 12);
            this.clbArticles.Name = "clbArticles";
            this.clbArticles.Size = new System.Drawing.Size(164, 94);
            this.clbArticles.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(633, 75);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FormCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.clbArticles);
            this.Controls.Add(this.clbAnalytics);
            this.Controls.Add(this.dtpDateCostTo);
            this.Controls.Add(this.dtpDateCostFrom);
            this.Controls.Add(this.dgvCosts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCosts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ежедневный учет";
            this.Load += new System.EventHandler(this.FormCosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCosts;
        private System.Windows.Forms.DateTimePicker dtpDateCostFrom;
        private System.Windows.Forms.DateTimePicker dtpDateCostTo;
        private System.Windows.Forms.CheckedListBox clbAnalytics;
        private System.Windows.Forms.CheckedListBox clbArticles;
        private System.Windows.Forms.Button btnUpdate;
    }
}
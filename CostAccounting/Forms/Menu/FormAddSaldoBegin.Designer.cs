namespace CostAccounting.Forms.Menu
{
    partial class FormAddSaldoBegin
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
            this.cmbRefAnalytics = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumAnalytic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAnalytics = new System.Windows.Forms.GroupBox();
            this.btnAddAnalytic = new System.Windows.Forms.Button();
            this.groupBoxArticles = new System.Windows.Forms.GroupBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRefArticles = new System.Windows.Forms.ComboBox();
            this.txtSumArticle = new System.Windows.Forms.TextBox();
            this.dgwSaldoBegin = new System.Windows.Forms.DataGridView();
            this.NameRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAnalytics.SuspendLayout();
            this.groupBoxArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaldoBegin)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRefAnalytics
            // 
            this.cmbRefAnalytics.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRefAnalytics.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefAnalytics.FormattingEnabled = true;
            this.cmbRefAnalytics.Location = new System.Drawing.Point(6, 56);
            this.cmbRefAnalytics.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRefAnalytics.Name = "cmbRefAnalytics";
            this.cmbRefAnalytics.Size = new System.Drawing.Size(170, 24);
            this.cmbRefAnalytics.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите аналитику:";
            // 
            // txtSumAnalytic
            // 
            this.txtSumAnalytic.Location = new System.Drawing.Point(200, 57);
            this.txtSumAnalytic.Name = "txtSumAnalytic";
            this.txtSumAnalytic.Size = new System.Drawing.Size(107, 23);
            this.txtSumAnalytic.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите сумму:";
            // 
            // groupBoxAnalytics
            // 
            this.groupBoxAnalytics.Controls.Add(this.btnAddAnalytic);
            this.groupBoxAnalytics.Controls.Add(this.label1);
            this.groupBoxAnalytics.Controls.Add(this.label2);
            this.groupBoxAnalytics.Controls.Add(this.cmbRefAnalytics);
            this.groupBoxAnalytics.Controls.Add(this.txtSumAnalytic);
            this.groupBoxAnalytics.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAnalytics.Name = "groupBoxAnalytics";
            this.groupBoxAnalytics.Size = new System.Drawing.Size(330, 134);
            this.groupBoxAnalytics.TabIndex = 4;
            this.groupBoxAnalytics.TabStop = false;
            this.groupBoxAnalytics.Text = "Аналитики";
            // 
            // btnAddAnalytic
            // 
            this.btnAddAnalytic.Location = new System.Drawing.Point(101, 87);
            this.btnAddAnalytic.Name = "btnAddAnalytic";
            this.btnAddAnalytic.Size = new System.Drawing.Size(94, 31);
            this.btnAddAnalytic.TabIndex = 4;
            this.btnAddAnalytic.Text = "Добавить";
            this.btnAddAnalytic.UseVisualStyleBackColor = true;
            this.btnAddAnalytic.Click += new System.EventHandler(this.btnAddAnalytic_Click);
            // 
            // groupBoxArticles
            // 
            this.groupBoxArticles.Controls.Add(this.btnAddArticle);
            this.groupBoxArticles.Controls.Add(this.label3);
            this.groupBoxArticles.Controls.Add(this.label4);
            this.groupBoxArticles.Controls.Add(this.cmbRefArticles);
            this.groupBoxArticles.Controls.Add(this.txtSumArticle);
            this.groupBoxArticles.Location = new System.Drawing.Point(12, 178);
            this.groupBoxArticles.Name = "groupBoxArticles";
            this.groupBoxArticles.Size = new System.Drawing.Size(330, 134);
            this.groupBoxArticles.TabIndex = 5;
            this.groupBoxArticles.TabStop = false;
            this.groupBoxArticles.Text = "Статьи";
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(101, 87);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(94, 31);
            this.btnAddArticle.TabIndex = 4;
            this.btnAddArticle.Text = "Добавить";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Выберите статью:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите сумму:";
            // 
            // cmbRefArticles
            // 
            this.cmbRefArticles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRefArticles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefArticles.FormattingEnabled = true;
            this.cmbRefArticles.Location = new System.Drawing.Point(6, 56);
            this.cmbRefArticles.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRefArticles.Name = "cmbRefArticles";
            this.cmbRefArticles.Size = new System.Drawing.Size(170, 24);
            this.cmbRefArticles.TabIndex = 0;
            // 
            // txtSumArticle
            // 
            this.txtSumArticle.Location = new System.Drawing.Point(200, 57);
            this.txtSumArticle.Name = "txtSumArticle";
            this.txtSumArticle.Size = new System.Drawing.Size(107, 23);
            this.txtSumArticle.TabIndex = 2;
            // 
            // dgwSaldoBegin
            // 
            this.dgwSaldoBegin.AllowUserToAddRows = false;
            this.dgwSaldoBegin.AllowUserToDeleteRows = false;
            this.dgwSaldoBegin.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwSaldoBegin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSaldoBegin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameRef,
            this.Sum});
            this.dgwSaldoBegin.Location = new System.Drawing.Point(364, 12);
            this.dgwSaldoBegin.MultiSelect = false;
            this.dgwSaldoBegin.Name = "dgwSaldoBegin";
            this.dgwSaldoBegin.ReadOnly = true;
            this.dgwSaldoBegin.Size = new System.Drawing.Size(296, 300);
            this.dgwSaldoBegin.TabIndex = 6;
            // 
            // NameRef
            // 
            this.NameRef.DataPropertyName = "Name";
            this.NameRef.HeaderText = "Название";
            this.NameRef.Name = "NameRef";
            this.NameRef.ReadOnly = true;
            this.NameRef.Width = 150;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Сумма";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // FormAddSaldoBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 332);
            this.Controls.Add(this.dgwSaldoBegin);
            this.Controls.Add(this.groupBoxArticles);
            this.Controls.Add(this.groupBoxAnalytics);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddSaldoBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сальдо на начало периода";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddSaldoBegin_FormClosing);
            this.Load += new System.EventHandler(this.FormAddSaldoBegin_Load);
            this.groupBoxAnalytics.ResumeLayout(false);
            this.groupBoxAnalytics.PerformLayout();
            this.groupBoxArticles.ResumeLayout(false);
            this.groupBoxArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSaldoBegin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRefAnalytics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSumAnalytic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAnalytics;
        private System.Windows.Forms.Button btnAddAnalytic;
        private System.Windows.Forms.GroupBox groupBoxArticles;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRefArticles;
        private System.Windows.Forms.TextBox txtSumArticle;
        private System.Windows.Forms.DataGridView dgwSaldoBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}
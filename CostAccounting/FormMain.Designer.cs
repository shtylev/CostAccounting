namespace CostAccounting
{
    partial class formMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemReference = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddSaldoBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnalyticsReference = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArticlesReference = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCosts = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSumCost = new System.Windows.Forms.TextBox();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCostDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCostsArticles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCostsAnalytics = new System.Windows.Forms.ComboBox();
            this.dgvSvod = new System.Windows.Forms.DataGridView();
            this.dgvSaldoEndPeriod = new System.Windows.Forms.DataGridView();
            this.NameRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnalytic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSaldoEndPeriod = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSvod = new System.Windows.Forms.Button();
            this.dtpSvodDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpSvodDateFrom = new System.Windows.Forms.DateTimePicker();
            this.menuMain.SuspendLayout();
            this.groupBoxCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldoEndPeriod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.Menu;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReference});
            this.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1369, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemReference
            // 
            this.menuItemReference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddSaldoBegin,
            this.menuItemAnalyticsReference,
            this.menuItemArticlesReference});
            this.menuItemReference.Name = "menuItemReference";
            this.menuItemReference.Size = new System.Drawing.Size(94, 20);
            this.menuItemReference.Text = "Справочники";
            // 
            // menuItemAddSaldoBegin
            // 
            this.menuItemAddSaldoBegin.Name = "menuItemAddSaldoBegin";
            this.menuItemAddSaldoBegin.Size = new System.Drawing.Size(222, 22);
            this.menuItemAddSaldoBegin.Text = "Сальдо на начало периода";
            this.menuItemAddSaldoBegin.Click += new System.EventHandler(this.menuItemAddSaldoBegin_Click);
            // 
            // menuItemAnalyticsReference
            // 
            this.menuItemAnalyticsReference.Name = "menuItemAnalyticsReference";
            this.menuItemAnalyticsReference.Size = new System.Drawing.Size(222, 22);
            this.menuItemAnalyticsReference.Text = "Аналитики";
            this.menuItemAnalyticsReference.Click += new System.EventHandler(this.menuItemAnalyticsReference_Click);
            // 
            // menuItemArticlesReference
            // 
            this.menuItemArticlesReference.Name = "menuItemArticlesReference";
            this.menuItemArticlesReference.Size = new System.Drawing.Size(222, 22);
            this.menuItemArticlesReference.Text = "Статьи";
            this.menuItemArticlesReference.Click += new System.EventHandler(this.menuItemArticlesReference_Click);
            // 
            // groupBoxCosts
            // 
            this.groupBoxCosts.Controls.Add(this.label5);
            this.groupBoxCosts.Controls.Add(this.txtSumCost);
            this.groupBoxCosts.Controls.Add(this.btnAddCost);
            this.groupBoxCosts.Controls.Add(this.label4);
            this.groupBoxCosts.Controls.Add(this.txtCostMessage);
            this.groupBoxCosts.Controls.Add(this.label3);
            this.groupBoxCosts.Controls.Add(this.dtpCostDate);
            this.groupBoxCosts.Controls.Add(this.label2);
            this.groupBoxCosts.Controls.Add(this.cmbCostsArticles);
            this.groupBoxCosts.Controls.Add(this.label1);
            this.groupBoxCosts.Controls.Add(this.cmbCostsAnalytics);
            this.groupBoxCosts.Location = new System.Drawing.Point(13, 28);
            this.groupBoxCosts.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCosts.Name = "groupBoxCosts";
            this.groupBoxCosts.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCosts.Size = new System.Drawing.Size(1013, 127);
            this.groupBoxCosts.TabIndex = 1;
            this.groupBoxCosts.TabStop = false;
            this.groupBoxCosts.Text = "Расходы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите сумму:";
            // 
            // txtSumCost
            // 
            this.txtSumCost.Location = new System.Drawing.Point(388, 52);
            this.txtSumCost.Name = "txtSumCost";
            this.txtSumCost.Size = new System.Drawing.Size(107, 23);
            this.txtSumCost.TabIndex = 9;
            // 
            // btnAddCost
            // 
            this.btnAddCost.Location = new System.Drawing.Point(403, 87);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(83, 28);
            this.btnAddCost.TabIndex = 8;
            this.btnAddCost.Text = "Добавить";
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите сообщение:";
            // 
            // txtCostMessage
            // 
            this.txtCostMessage.Location = new System.Drawing.Point(646, 52);
            this.txtCostMessage.Name = "txtCostMessage";
            this.txtCostMessage.Size = new System.Drawing.Size(358, 23);
            this.txtCostMessage.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите дату:";
            // 
            // dtpCostDate
            // 
            this.dtpCostDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCostDate.Location = new System.Drawing.Point(516, 52);
            this.dtpCostDate.Name = "dtpCostDate";
            this.dtpCostDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpCostDate.Size = new System.Drawing.Size(109, 23);
            this.dtpCostDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите статью:";
            // 
            // cmbCostsArticles
            // 
            this.cmbCostsArticles.FormattingEnabled = true;
            this.cmbCostsArticles.Location = new System.Drawing.Point(198, 52);
            this.cmbCostsArticles.Name = "cmbCostsArticles";
            this.cmbCostsArticles.Size = new System.Drawing.Size(170, 24);
            this.cmbCostsArticles.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите аналитику:";
            // 
            // cmbCostsAnalytics
            // 
            this.cmbCostsAnalytics.FormattingEnabled = true;
            this.cmbCostsAnalytics.Location = new System.Drawing.Point(7, 52);
            this.cmbCostsAnalytics.Name = "cmbCostsAnalytics";
            this.cmbCostsAnalytics.Size = new System.Drawing.Size(170, 24);
            this.cmbCostsAnalytics.TabIndex = 0;
            // 
            // dgvSvod
            // 
            this.dgvSvod.AllowUserToAddRows = false;
            this.dgvSvod.AllowUserToDeleteRows = false;
            this.dgvSvod.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSvod.Location = new System.Drawing.Point(10, 56);
            this.dgvSvod.Name = "dgvSvod";
            this.dgvSvod.ReadOnly = true;
            this.dgvSvod.Size = new System.Drawing.Size(994, 281);
            this.dgvSvod.TabIndex = 2;
            // 
            // dgvSaldoEndPeriod
            // 
            this.dgvSaldoEndPeriod.AllowUserToAddRows = false;
            this.dgvSaldoEndPeriod.AllowUserToDeleteRows = false;
            this.dgvSaldoEndPeriod.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSaldoEndPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaldoEndPeriod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameRef,
            this.Sum,
            this.idAnalytic,
            this.idArticle,
            this.Id});
            this.dgvSaldoEndPeriod.Location = new System.Drawing.Point(8, 26);
            this.dgvSaldoEndPeriod.Name = "dgvSaldoEndPeriod";
            this.dgvSaldoEndPeriod.ReadOnly = true;
            this.dgvSaldoEndPeriod.Size = new System.Drawing.Size(296, 300);
            this.dgvSaldoEndPeriod.TabIndex = 3;
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
            // idAnalytic
            // 
            this.idAnalytic.DataPropertyName = "IdAnalytic";
            this.idAnalytic.HeaderText = "idAnalytic";
            this.idAnalytic.Name = "idAnalytic";
            this.idAnalytic.ReadOnly = true;
            this.idAnalytic.Visible = false;
            // 
            // idArticle
            // 
            this.idArticle.DataPropertyName = "IdArticle";
            this.idArticle.HeaderText = "idArticle";
            this.idArticle.Name = "idArticle";
            this.idArticle.ReadOnly = true;
            this.idArticle.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateSaldoEndPeriod);
            this.groupBox1.Controls.Add(this.dgvSaldoEndPeriod);
            this.groupBox1.Location = new System.Drawing.Point(1046, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 371);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сальдо на конец периода";
            // 
            // btnUpdateSaldoEndPeriod
            // 
            this.btnUpdateSaldoEndPeriod.Location = new System.Drawing.Point(8, 333);
            this.btnUpdateSaldoEndPeriod.Name = "btnUpdateSaldoEndPeriod";
            this.btnUpdateSaldoEndPeriod.Size = new System.Drawing.Size(87, 29);
            this.btnUpdateSaldoEndPeriod.TabIndex = 4;
            this.btnUpdateSaldoEndPeriod.Text = "Обновить";
            this.btnUpdateSaldoEndPeriod.UseVisualStyleBackColor = true;
            this.btnUpdateSaldoEndPeriod.Click += new System.EventHandler(this.btnUpdateSaldoEndPeriod_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateSvod);
            this.groupBox2.Controls.Add(this.dtpSvodDateTo);
            this.groupBox2.Controls.Add(this.dtpSvodDateFrom);
            this.groupBox2.Controls.Add(this.dgvSvod);
            this.groupBox2.Location = new System.Drawing.Point(13, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1013, 347);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Свод";
            // 
            // btnUpdateSvod
            // 
            this.btnUpdateSvod.Location = new System.Drawing.Point(256, 21);
            this.btnUpdateSvod.Name = "btnUpdateSvod";
            this.btnUpdateSvod.Size = new System.Drawing.Size(87, 29);
            this.btnUpdateSvod.TabIndex = 5;
            this.btnUpdateSvod.Text = "Обновить";
            this.btnUpdateSvod.UseVisualStyleBackColor = true;
            this.btnUpdateSvod.Click += new System.EventHandler(this.btnUpdateSvod_Click);
            // 
            // dtpSvodDateTo
            // 
            this.dtpSvodDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSvodDateTo.Location = new System.Drawing.Point(129, 23);
            this.dtpSvodDateTo.Name = "dtpSvodDateTo";
            this.dtpSvodDateTo.Size = new System.Drawing.Size(100, 23);
            this.dtpSvodDateTo.TabIndex = 4;
            // 
            // dtpSvodDateFrom
            // 
            this.dtpSvodDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSvodDateFrom.Location = new System.Drawing.Point(10, 23);
            this.dtpSvodDateFrom.Name = "dtpSvodDateFrom";
            this.dtpSvodDateFrom.Size = new System.Drawing.Size(100, 23);
            this.dtpSvodDateFrom.TabIndex = 3;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCosts);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет расходов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.groupBoxCosts.ResumeLayout(false);
            this.groupBoxCosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaldoEndPeriod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemReference;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnalyticsReference;
        private System.Windows.Forms.ToolStripMenuItem menuItemArticlesReference;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddSaldoBegin;
        private System.Windows.Forms.GroupBox groupBoxCosts;
        private System.Windows.Forms.ComboBox cmbCostsAnalytics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCostDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCostsArticles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostMessage;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.TextBox txtSumCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSvod;
        private System.Windows.Forms.DataGridView dgvSaldoEndPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateSaldoEndPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnalytic;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpSvodDateTo;
        private System.Windows.Forms.DateTimePicker dtpSvodDateFrom;
        private System.Windows.Forms.Button btnUpdateSvod;
    }
}


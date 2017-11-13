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
            this.menuItemAnalyticsReference = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemArticlesReference = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddSaldoBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
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
            this.menuMain.Size = new System.Drawing.Size(1142, 24);
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
            // menuItemAnalyticsReference
            // 
            this.menuItemAnalyticsReference.Name = "menuItemAnalyticsReference";
            this.menuItemAnalyticsReference.Size = new System.Drawing.Size(214, 22);
            this.menuItemAnalyticsReference.Text = "Аналитики";
            this.menuItemAnalyticsReference.Click += new System.EventHandler(this.menuItemAnalyticsReference_Click);
            // 
            // menuItemArticlesReference
            // 
            this.menuItemArticlesReference.Name = "menuItemArticlesReference";
            this.menuItemArticlesReference.Size = new System.Drawing.Size(214, 22);
            this.menuItemArticlesReference.Text = "Статьи";
            this.menuItemArticlesReference.Click += new System.EventHandler(this.menuItemArticlesReference_Click);
            // 
            // menuItemAddSaldoBegin
            // 
            this.menuItemAddSaldoBegin.Name = "menuItemAddSaldoBegin";
            this.menuItemAddSaldoBegin.Size = new System.Drawing.Size(214, 22);
            this.menuItemAddSaldoBegin.Text = "Ввести начальное сальдо";
            this.menuItemAddSaldoBegin.Click += new System.EventHandler(this.menuItemAddSaldoBegin_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 450);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет расходов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemReference;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnalyticsReference;
        private System.Windows.Forms.ToolStripMenuItem menuItemArticlesReference;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddSaldoBegin;
    }
}


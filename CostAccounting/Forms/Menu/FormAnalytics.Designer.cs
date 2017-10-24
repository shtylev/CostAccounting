namespace CostAccounting.Forms.Menu
{
    partial class FormAnalytics
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
            this.listBoxAnalytics = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxAnalytics
            // 
            this.listBoxAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAnalytics.FormattingEnabled = true;
            this.listBoxAnalytics.Location = new System.Drawing.Point(0, 0);
            this.listBoxAnalytics.Name = "listBoxAnalytics";
            this.listBoxAnalytics.Size = new System.Drawing.Size(131, 279);
            this.listBoxAnalytics.TabIndex = 0;
            // 
            // FormAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(131, 279);
            this.Controls.Add(this.listBoxAnalytics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormAnalytics";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналитики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAnalytics;
    }
}
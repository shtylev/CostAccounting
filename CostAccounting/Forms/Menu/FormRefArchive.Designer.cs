namespace CostAccounting.Forms.Menu
{
    partial class FormRefArchive
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
            this.listBoxRefArchive = new System.Windows.Forms.ListBox();
            this.cmsRefArchive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRefArchive.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRefArchive
            // 
            this.listBoxRefArchive.ContextMenuStrip = this.cmsRefArchive;
            this.listBoxRefArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRefArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRefArchive.FormattingEnabled = true;
            this.listBoxRefArchive.ItemHeight = 16;
            this.listBoxRefArchive.Location = new System.Drawing.Point(0, 0);
            this.listBoxRefArchive.Name = "listBoxRefArchive";
            this.listBoxRefArchive.Size = new System.Drawing.Size(154, 201);
            this.listBoxRefArchive.TabIndex = 0;
            // 
            // cmsRefArchive
            // 
            this.cmsRefArchive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.cmsRefArchive.Name = "contextMenuStrip1";
            this.cmsRefArchive.Size = new System.Drawing.Size(193, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "Удалить из архива";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FormRefArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 201);
            this.Controls.Add(this.listBoxRefArchive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormRefArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormRefArchive_Load);
            this.cmsRefArchive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRefArchive;
        private System.Windows.Forms.ContextMenuStrip cmsRefArchive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
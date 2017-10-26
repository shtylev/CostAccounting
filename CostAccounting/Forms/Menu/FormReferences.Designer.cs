namespace CostAccounting.Forms.Menu
{
    partial class FormReferences
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
            this.listBoxReference = new System.Windows.Forms.ListBox();
            this.cmsReference = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conMenuCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTypeReference = new System.Windows.Forms.Label();
            this.cmsReference.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxReference
            // 
            this.listBoxReference.ContextMenuStrip = this.cmsReference;
            this.listBoxReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxReference.FormattingEnabled = true;
            this.listBoxReference.ItemHeight = 16;
            this.listBoxReference.Location = new System.Drawing.Point(0, 0);
            this.listBoxReference.Name = "listBoxReference";
            this.listBoxReference.Size = new System.Drawing.Size(154, 201);
            this.listBoxReference.TabIndex = 0;
            // 
            // cmsReference
            // 
            this.cmsReference.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conMenuCreate,
            this.conMenuRename,
            this.conMenuArchive});
            this.cmsReference.Name = "cmsReference";
            this.cmsReference.Size = new System.Drawing.Size(181, 70);
            // 
            // conMenuCreate
            // 
            this.conMenuCreate.Name = "conMenuCreate";
            this.conMenuCreate.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.conMenuCreate.Size = new System.Drawing.Size(180, 22);
            this.conMenuCreate.Text = "Создать";
            this.conMenuCreate.Click += new System.EventHandler(this.conMenuCreate_Click);
            // 
            // conMenuRename
            // 
            this.conMenuRename.Name = "conMenuRename";
            this.conMenuRename.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.conMenuRename.Size = new System.Drawing.Size(180, 22);
            this.conMenuRename.Text = "Переименовать";
            this.conMenuRename.Click += new System.EventHandler(this.conMenuRename_Click);
            // 
            // conMenuArchive
            // 
            this.conMenuArchive.Name = "conMenuArchive";
            this.conMenuArchive.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.conMenuArchive.Size = new System.Drawing.Size(180, 22);
            this.conMenuArchive.Text = "Показать архив";
            // 
            // lblTypeReference
            // 
            this.lblTypeReference.AutoSize = true;
            this.lblTypeReference.Location = new System.Drawing.Point(12, 9);
            this.lblTypeReference.Name = "lblTypeReference";
            this.lblTypeReference.Size = new System.Drawing.Size(0, 13);
            this.lblTypeReference.TabIndex = 2;
            this.lblTypeReference.Visible = false;
            // 
            // FormReferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 201);
            this.Controls.Add(this.lblTypeReference);
            this.Controls.Add(this.listBoxReference);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormReferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAnalytics_Load);
            this.cmsReference.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTypeReference;
        private System.Windows.Forms.ContextMenuStrip cmsReference;
        private System.Windows.Forms.ToolStripMenuItem conMenuCreate;
        private System.Windows.Forms.ToolStripMenuItem conMenuRename;
        private System.Windows.Forms.ToolStripMenuItem conMenuArchive;
        public System.Windows.Forms.ListBox listBoxReference;
    }
}
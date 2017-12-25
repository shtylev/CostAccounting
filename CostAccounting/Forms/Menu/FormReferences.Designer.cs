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
            this.conMenuAddArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuShowArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuEditColor = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTypeReference = new System.Windows.Forms.Label();
            this.colorDialogRef = new System.Windows.Forms.ColorDialog();
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
            this.conMenuAddArchive,
            this.conMenuShowArchive,
            this.conMenuEditColor});
            this.cmsReference.Name = "cmsReference";
            this.cmsReference.Size = new System.Drawing.Size(189, 114);
            // 
            // conMenuCreate
            // 
            this.conMenuCreate.Name = "conMenuCreate";
            this.conMenuCreate.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.conMenuCreate.Size = new System.Drawing.Size(188, 22);
            this.conMenuCreate.Text = "Создать";
            this.conMenuCreate.Click += new System.EventHandler(this.conMenuCreate_Click);
            // 
            // conMenuRename
            // 
            this.conMenuRename.Name = "conMenuRename";
            this.conMenuRename.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.conMenuRename.Size = new System.Drawing.Size(188, 22);
            this.conMenuRename.Text = "Переименовать";
            this.conMenuRename.Click += new System.EventHandler(this.conMenuRename_Click);
            // 
            // conMenuAddArchive
            // 
            this.conMenuAddArchive.Name = "conMenuAddArchive";
            this.conMenuAddArchive.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.conMenuAddArchive.Size = new System.Drawing.Size(188, 22);
            this.conMenuAddArchive.Text = "Добавить в архив";
            this.conMenuAddArchive.Click += new System.EventHandler(this.conMenuAddArchive_Click);
            // 
            // conMenuShowArchive
            // 
            this.conMenuShowArchive.Name = "conMenuShowArchive";
            this.conMenuShowArchive.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.conMenuShowArchive.Size = new System.Drawing.Size(188, 22);
            this.conMenuShowArchive.Text = "Показать архив";
            this.conMenuShowArchive.Click += new System.EventHandler(this.conMenuShowArchive_Click);
            // 
            // conMenuEditColor
            // 
            this.conMenuEditColor.Name = "conMenuEditColor";
            this.conMenuEditColor.Size = new System.Drawing.Size(188, 22);
            this.conMenuEditColor.Text = "Изменить цвет";
            this.conMenuEditColor.Click += new System.EventHandler(this.conMenuEditColor_Click);
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
            // colorDialogRef
            // 
            this.colorDialogRef.FullOpen = true;
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
        private System.Windows.Forms.ToolStripMenuItem conMenuAddArchive;
        public System.Windows.Forms.ListBox listBoxReference;
        private System.Windows.Forms.ToolStripMenuItem conMenuShowArchive;
        private System.Windows.Forms.ToolStripMenuItem conMenuEditColor;
        private System.Windows.Forms.ColorDialog colorDialogRef;
    }
}
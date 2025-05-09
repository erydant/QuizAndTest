namespace QuizAndTest
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démarrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_SF = new System.Windows.Forms.Panel();
            this.paramètreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.scoreToolStripMenuItem,
            this.gestionDesQuestionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.paramètreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.démarrerToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // démarrerToolStripMenuItem
            // 
            this.démarrerToolStripMenuItem.Name = "démarrerToolStripMenuItem";
            this.démarrerToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.démarrerToolStripMenuItem.Text = "Démarrer";
            this.démarrerToolStripMenuItem.Click += new System.EventHandler(this.démarrerToolStripMenuItem_Click);
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // gestionDesQuestionsToolStripMenuItem
            // 
            this.gestionDesQuestionsToolStripMenuItem.Name = "gestionDesQuestionsToolStripMenuItem";
            this.gestionDesQuestionsToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.gestionDesQuestionsToolStripMenuItem.Text = "Gestion des questions";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnl_SF
            // 
            this.pnl_SF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.pnl_SF.Location = new System.Drawing.Point(0, 27);
            this.pnl_SF.Name = "pnl_SF";
            this.pnl_SF.Size = new System.Drawing.Size(800, 423);
            this.pnl_SF.TabIndex = 2;
            // 
            // paramètreToolStripMenuItem
            // 
            this.paramètreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDDToolStripMenuItem});
            this.paramètreToolStripMenuItem.Name = "paramètreToolStripMenuItem";
            this.paramètreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.paramètreToolStripMenuItem.Text = "paramètre";
            // 
            // bDDToolStripMenuItem
            // 
            this.bDDToolStripMenuItem.Name = "bDDToolStripMenuItem";
            this.bDDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bDDToolStripMenuItem.Text = "BDD";
            this.bDDToolStripMenuItem.Click += new System.EventHandler(this.bDDToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_SF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démarrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnl_SF;
        private System.Windows.Forms.ToolStripMenuItem paramètreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDDToolStripMenuItem;
    }
}
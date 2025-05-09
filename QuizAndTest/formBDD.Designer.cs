namespace QuizAndTest
{
    partial class formBDD
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
            this.dgv_questions = new System.Windows.Forms.DataGridView();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.txt_rechercheMot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_questions
            // 
            this.dgv_questions.AllowUserToAddRows = false;
            this.dgv_questions.AllowUserToDeleteRows = false;
            this.dgv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questions.Location = new System.Drawing.Point(22, 89);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(737, 278);
            this.dgv_questions.TabIndex = 0;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(721, -1);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(61, 21);
            this.btn_fermer.TabIndex = 21;
            this.btn_fermer.Text = "fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Location = new System.Drawing.Point(164, 45);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(182, 21);
            this.cb_difficulte.TabIndex = 22;
            this.cb_difficulte.SelectionChangeCommitted += new System.EventHandler(this.cb_difficulte_SelectionChangeCommitted);
            // 
            // txt_rechercheMot
            // 
            this.txt_rechercheMot.Location = new System.Drawing.Point(164, 19);
            this.txt_rechercheMot.Name = "txt_rechercheMot";
            this.txt_rechercheMot.Size = new System.Drawing.Size(182, 20);
            this.txt_rechercheMot.TabIndex = 23;
            this.txt_rechercheMot.TextChanged += new System.EventHandler(this.txt_rechercheMot_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Recherche de mots";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "difficulté";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_rechercheMot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_difficulte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(180, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 84);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // formBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.dgv_questions);
            this.Name = "formBDD";
            this.Text = "formBDD";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_questions;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.ComboBox cb_difficulte;
        private System.Windows.Forms.TextBox txt_rechercheMot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
using System.Drawing;

namespace QuizAndTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.lbl_rep = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.cb_difficulté = new System.Windows.Forms.ComboBox();
            this.lbl_difficulté = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_afficher
            // 
            this.txt_afficher.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_afficher.Enabled = false;
            this.txt_afficher.Location = new System.Drawing.Point(298, 157);
            this.txt_afficher.Multiline = true;
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(269, 40);
            this.txt_afficher.TabIndex = 0;
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(222, 170);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(50, 13);
            this.lbl_rep.TabIndex = 1;
            this.lbl_rep.Text = "Réponse";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(360, 327);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(222, 213);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(222, 250);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(343, 213);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(173, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(343, 247);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(173, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // cb_difficulté
            // 
            this.cb_difficulté.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_difficulté.FormattingEnabled = true;
            this.cb_difficulté.Location = new System.Drawing.Point(343, 285);
            this.cb_difficulté.Name = "cb_difficulté";
            this.cb_difficulté.Size = new System.Drawing.Size(173, 21);
            this.cb_difficulté.TabIndex = 7;
            this.cb_difficulté.SelectedIndexChanged += new System.EventHandler(this.cb_difficulté_SelectedIndexChanged);
            // 
            // lbl_difficulté
            // 
            this.lbl_difficulté.AutoSize = true;
            this.lbl_difficulté.Location = new System.Drawing.Point(225, 292);
            this.lbl_difficulté.Name = "lbl_difficulté";
            this.lbl_difficulté.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficulté.TabIndex = 8;
            this.lbl_difficulté.Text = "Difficulté :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_difficulté);
            this.Controls.Add(this.cb_difficulté);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.lbl_rep);
            this.Controls.Add(this.txt_afficher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox cb_difficulté;
        private System.Windows.Forms.Label lbl_difficulté;
    }
}


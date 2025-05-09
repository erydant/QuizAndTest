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
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.cb_difficulté = new System.Windows.Forms.ComboBox();
            this.lbl_difficulté = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(390, 329);
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
            this.lbl_name.Location = new System.Drawing.Point(230, 72);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(230, 144);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(49, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(348, 69);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(173, 20);
            this.txt_nom.TabIndex = 5;
            this.txt_nom.TextChanged += new System.EventHandler(this.nom_tb_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(348, 137);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(173, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // cb_difficulté
            // 
            this.cb_difficulté.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_difficulté.FormattingEnabled = true;
            this.cb_difficulté.Location = new System.Drawing.Point(348, 244);
            this.cb_difficulté.Name = "cb_difficulté";
            this.cb_difficulté.Size = new System.Drawing.Size(173, 21);
            this.cb_difficulté.TabIndex = 7;
            this.cb_difficulté.SelectedIndexChanged += new System.EventHandler(this.cb_difficulté_SelectedIndexChanged);
            // 
            // lbl_difficulté
            // 
            this.lbl_difficulté.AutoSize = true;
            this.lbl_difficulté.Location = new System.Drawing.Point(230, 251);
            this.lbl_difficulté.Name = "lbl_difficulté";
            this.lbl_difficulté.Size = new System.Drawing.Size(54, 13);
            this.lbl_difficulté.TabIndex = 8;
            this.lbl_difficulté.Text = "Difficulté :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_difficulté);
            this.Controls.Add(this.cb_difficulté);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox cb_difficulté;
        private System.Windows.Forms.Label lbl_difficulté;
        private System.Windows.Forms.Button button1;
    }
}


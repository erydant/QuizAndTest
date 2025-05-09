namespace QuizAndTest
{
    partial class jeu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.b_valider = new System.Windows.Forms.Button();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.txt_affichage = new System.Windows.Forms.TextBox();
            this.gb_reponse = new System.Windows.Forms.GroupBox();
            this.ckb_reponse5 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse4 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse3 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse2 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse1 = new System.Windows.Forms.CheckBox();
            this.pb_valide = new System.Windows.Forms.PictureBox();
            this.difficulte_tb = new System.Windows.Forms.TextBox();
            this.nom_tb = new System.Windows.Forms.TextBox();
            this.difficulté_lbl = new System.Windows.Forms.Label();
            this.nom_lbl = new System.Windows.Forms.Label();
            this.pb_dureeRepQuestion = new System.Windows.Forms.ProgressBar();
            this.score = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_reponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_valide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quizz And Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temps de la partie";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(153, 57);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(58, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "Question 1";
            // 
            // b_valider
            // 
            this.b_valider.Location = new System.Drawing.Point(357, 350);
            this.b_valider.Name = "b_valider";
            this.b_valider.Size = new System.Drawing.Size(75, 23);
            this.b_valider.TabIndex = 9;
            this.b_valider.Text = "Valider";
            this.b_valider.UseVisualStyleBackColor = true;
            this.b_valider.Click += new System.EventHandler(this.b_valider_Click);
            // 
            // txt_timer
            // 
            this.txt_timer.Enabled = false;
            this.txt_timer.Location = new System.Drawing.Point(610, 73);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(144, 20);
            this.txt_timer.TabIndex = 10;
            this.txt_timer.TextChanged += new System.EventHandler(this.txt_timer_TextChanged);
            // 
            // txt_affichage
            // 
            this.txt_affichage.Enabled = false;
            this.txt_affichage.Location = new System.Drawing.Point(156, 73);
            this.txt_affichage.Multiline = true;
            this.txt_affichage.Name = "txt_affichage";
            this.txt_affichage.Size = new System.Drawing.Size(419, 55);
            this.txt_affichage.TabIndex = 11;
            // 
            // gb_reponse
            // 
            this.gb_reponse.Controls.Add(this.ckb_reponse5);
            this.gb_reponse.Controls.Add(this.ckb_reponse4);
            this.gb_reponse.Controls.Add(this.ckb_reponse3);
            this.gb_reponse.Controls.Add(this.ckb_reponse2);
            this.gb_reponse.Controls.Add(this.ckb_reponse1);
            this.gb_reponse.Location = new System.Drawing.Point(156, 146);
            this.gb_reponse.Name = "gb_reponse";
            this.gb_reponse.Size = new System.Drawing.Size(419, 198);
            this.gb_reponse.TabIndex = 13;
            this.gb_reponse.TabStop = false;
            this.gb_reponse.Text = "Réponse possibles";
            // 
            // ckb_reponse5
            // 
            this.ckb_reponse5.AutoSize = true;
            this.ckb_reponse5.Location = new System.Drawing.Point(6, 158);
            this.ckb_reponse5.Name = "ckb_reponse5";
            this.ckb_reponse5.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse5.TabIndex = 15;
            this.ckb_reponse5.Text = "Réponse 5";
            this.ckb_reponse5.UseVisualStyleBackColor = true;
            this.ckb_reponse5.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse4
            // 
            this.ckb_reponse4.AutoSize = true;
            this.ckb_reponse4.Location = new System.Drawing.Point(6, 123);
            this.ckb_reponse4.Name = "ckb_reponse4";
            this.ckb_reponse4.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse4.TabIndex = 16;
            this.ckb_reponse4.Text = "Réponse 4";
            this.ckb_reponse4.UseVisualStyleBackColor = true;
            this.ckb_reponse4.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse3
            // 
            this.ckb_reponse3.AutoSize = true;
            this.ckb_reponse3.Location = new System.Drawing.Point(6, 83);
            this.ckb_reponse3.Name = "ckb_reponse3";
            this.ckb_reponse3.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse3.TabIndex = 17;
            this.ckb_reponse3.Text = "Réponse 3";
            this.ckb_reponse3.UseVisualStyleBackColor = true;
            this.ckb_reponse3.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse2
            // 
            this.ckb_reponse2.AutoSize = true;
            this.ckb_reponse2.Location = new System.Drawing.Point(6, 51);
            this.ckb_reponse2.Name = "ckb_reponse2";
            this.ckb_reponse2.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse2.TabIndex = 18;
            this.ckb_reponse2.Text = "Réponse 2";
            this.ckb_reponse2.UseVisualStyleBackColor = true;
            this.ckb_reponse2.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse1
            // 
            this.ckb_reponse1.AutoSize = true;
            this.ckb_reponse1.Location = new System.Drawing.Point(6, 19);
            this.ckb_reponse1.Name = "ckb_reponse1";
            this.ckb_reponse1.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse1.TabIndex = 14;
            this.ckb_reponse1.Text = "Réponse 1";
            this.ckb_reponse1.UseVisualStyleBackColor = true;
            this.ckb_reponse1.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // pb_valide
            // 
            this.pb_valide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_valide.Location = new System.Drawing.Point(610, 99);
            this.pb_valide.Name = "pb_valide";
            this.pb_valide.Size = new System.Drawing.Size(128, 129);
            this.pb_valide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_valide.TabIndex = 12;
            this.pb_valide.TabStop = false;
            // 
            // difficulte_tb
            // 
            this.difficulte_tb.Enabled = false;
            this.difficulte_tb.Location = new System.Drawing.Point(609, 347);
            this.difficulte_tb.Name = "difficulte_tb";
            this.difficulte_tb.Size = new System.Drawing.Size(144, 20);
            this.difficulte_tb.TabIndex = 14;
            this.difficulte_tb.TextChanged += new System.EventHandler(this.difficulte_tb_TextChanged);
            // 
            // nom_tb
            // 
            this.nom_tb.Enabled = false;
            this.nom_tb.Location = new System.Drawing.Point(609, 304);
            this.nom_tb.Name = "nom_tb";
            this.nom_tb.Size = new System.Drawing.Size(144, 20);
            this.nom_tb.TabIndex = 15;
            // 
            // difficulté_lbl
            // 
            this.difficulté_lbl.AutoSize = true;
            this.difficulté_lbl.Location = new System.Drawing.Point(607, 331);
            this.difficulté_lbl.Name = "difficulté_lbl";
            this.difficulté_lbl.Size = new System.Drawing.Size(46, 13);
            this.difficulté_lbl.TabIndex = 16;
            this.difficulté_lbl.Text = "difficulté";
            // 
            // nom_lbl
            // 
            this.nom_lbl.AutoSize = true;
            this.nom_lbl.Location = new System.Drawing.Point(607, 283);
            this.nom_lbl.Name = "nom_lbl";
            this.nom_lbl.Size = new System.Drawing.Size(27, 13);
            this.nom_lbl.TabIndex = 17;
            this.nom_lbl.Text = "nom";
            // 
            // pb_dureeRepQuestion
            // 
            this.pb_dureeRepQuestion.Location = new System.Drawing.Point(609, 252);
            this.pb_dureeRepQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.pb_dureeRepQuestion.Maximum = 15;
            this.pb_dureeRepQuestion.Name = "pb_dureeRepQuestion";
            this.pb_dureeRepQuestion.Size = new System.Drawing.Size(144, 19);
            this.pb_dureeRepQuestion.TabIndex = 18;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(646, 51);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 13);
            this.score.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(724, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 21);
            this.button1.TabIndex = 20;
            this.button1.Text = "fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.pb_dureeRepQuestion);
            this.Controls.Add(this.nom_lbl);
            this.Controls.Add(this.difficulté_lbl);
            this.Controls.Add(this.nom_tb);
            this.Controls.Add(this.difficulte_tb);
            this.Controls.Add(this.gb_reponse);
            this.Controls.Add(this.pb_valide);
            this.Controls.Add(this.txt_affichage);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.b_valider);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jeu";
            this.Text = "jeu";
            this.Load += new System.EventHandler(this.jeu_Load);
            this.gb_reponse.ResumeLayout(false);
            this.gb_reponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_valide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button b_valider;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.TextBox txt_affichage;
        private System.Windows.Forms.PictureBox pb_valide;
        private System.Windows.Forms.GroupBox gb_reponse;
        private System.Windows.Forms.CheckBox ckb_reponse5;
        private System.Windows.Forms.CheckBox ckb_reponse4;
        private System.Windows.Forms.CheckBox ckb_reponse3;
        private System.Windows.Forms.CheckBox ckb_reponse2;
        private System.Windows.Forms.CheckBox ckb_reponse1;
        private System.Windows.Forms.TextBox difficulte_tb;
        private System.Windows.Forms.TextBox nom_tb;
        private System.Windows.Forms.Label difficulté_lbl;
        private System.Windows.Forms.Label nom_lbl;
        private System.Windows.Forms.ProgressBar pb_dureeRepQuestion;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button button1;
    }
}
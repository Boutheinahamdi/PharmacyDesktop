
namespace pharmacy
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoyezUneQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.recherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.design = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonsupprimer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Quitter = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.list1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonaddcat = new System.Windows.Forms.Button();
            this.buttonsupcat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textcat = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aproposToolStripMenuItem,
            this.connexionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterProduitToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter Produit";
            // 
            // aproposToolStripMenuItem
            // 
            this.aproposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envoyezUneQuestionToolStripMenuItem});
            this.aproposToolStripMenuItem.Name = "aproposToolStripMenuItem";
            this.aproposToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aproposToolStripMenuItem.Text = "Apropos";
            // 
            // envoyezUneQuestionToolStripMenuItem
            // 
            this.envoyezUneQuestionToolStripMenuItem.Name = "envoyezUneQuestionToolStripMenuItem";
            this.envoyezUneQuestionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.envoyezUneQuestionToolStripMenuItem.Text = "Envoyez une Question";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscrirToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // inscrirToolStripMenuItem
            // 
            this.inscrirToolStripMenuItem.Name = "inscrirToolStripMenuItem";
            this.inscrirToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.inscrirToolStripMenuItem.Text = "Inscrir";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenu Au Pharmacy En Ligne";
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(217, 128);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(224, 20);
            this.recherche.TabIndex = 2;
            this.recherche.TextChanged += new System.EventHandler(this.recherche_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chercher un produit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom du Produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tan;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Tan;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Categorie";
            // 
            // nom
            // 
            this.nom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nom.Location = new System.Drawing.Point(217, 191);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(198, 20);
            this.nom.TabIndex = 10;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // design
            // 
            this.design.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.design.Location = new System.Drawing.Point(217, 240);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(198, 20);
            this.design.TabIndex = 11;
            // 
            // prix
            // 
            this.prix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prix.Location = new System.Drawing.Point(217, 277);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(198, 20);
            this.prix.TabIndex = 12;
            this.prix.TextChanged += new System.EventHandler(this.prix_TextChanged);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAjouter.BackColor = System.Drawing.Color.White;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.Color.Navy;
            this.buttonAjouter.Location = new System.Drawing.Point(592, 201);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(160, 34);
            this.buttonAjouter.TabIndex = 14;
            this.buttonAjouter.Text = "Ajouter Produit";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonsupprimer
            // 
            this.buttonsupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsupprimer.BackColor = System.Drawing.Color.White;
            this.buttonsupprimer.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupprimer.ForeColor = System.Drawing.Color.Navy;
            this.buttonsupprimer.Location = new System.Drawing.Point(781, 202);
            this.buttonsupprimer.Name = "buttonsupprimer";
            this.buttonsupprimer.Size = new System.Drawing.Size(160, 33);
            this.buttonsupprimer.TabIndex = 15;
            this.buttonsupprimer.Text = "Supprimer Produit";
            this.buttonsupprimer.UseVisualStyleBackColor = false;
            this.buttonsupprimer.Click += new System.EventHandler(this.buttonsupprimer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(423, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contact Via:pharmEnLigne@gmail.com";
            // 
            // Quitter
            // 
            this.Quitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quitter.BackColor = System.Drawing.Color.Maroon;
            this.Quitter.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.ForeColor = System.Drawing.Color.GhostWhite;
            this.Quitter.Location = new System.Drawing.Point(685, 324);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(160, 37);
            this.Quitter.TabIndex = 17;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Location = new System.Drawing.Point(217, 321);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(198, 21);
            this.list1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(421, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "chercher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ecrire Designation";
            // 
            // buttonaddcat
            // 
            this.buttonaddcat.BackColor = System.Drawing.Color.White;
            this.buttonaddcat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddcat.ForeColor = System.Drawing.Color.Navy;
            this.buttonaddcat.Location = new System.Drawing.Point(781, 264);
            this.buttonaddcat.Name = "buttonaddcat";
            this.buttonaddcat.Size = new System.Drawing.Size(160, 40);
            this.buttonaddcat.TabIndex = 22;
            this.buttonaddcat.Text = "Ajouter Categorie";
            this.buttonaddcat.UseVisualStyleBackColor = false;
            this.buttonaddcat.Click += new System.EventHandler(this.buttonaddcat_Click);
            // 
            // buttonsupcat
            // 
            this.buttonsupcat.BackColor = System.Drawing.Color.White;
            this.buttonsupcat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupcat.ForeColor = System.Drawing.Color.Navy;
            this.buttonsupcat.Location = new System.Drawing.Point(592, 267);
            this.buttonsupcat.Name = "buttonsupcat";
            this.buttonsupcat.Size = new System.Drawing.Size(160, 37);
            this.buttonsupcat.TabIndex = 23;
            this.buttonsupcat.Text = "Supprimer Categorie";
            this.buttonsupcat.UseVisualStyleBackColor = false;
            this.buttonsupcat.Click += new System.EventHandler(this.buttonsupcat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Tan;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ajouter Catagorie";
            // 
            // textcat
            // 
            this.textcat.Location = new System.Drawing.Point(217, 369);
            this.textcat.Name = "textcat";
            this.textcat.Size = new System.Drawing.Size(198, 20);
            this.textcat.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.textcat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonsupcat);
            this.Controls.Add(this.buttonaddcat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonsupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.design);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aproposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox design;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonsupprimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Quitter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoyezUneQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscrirToolStripMenuItem;
        private System.Windows.Forms.ComboBox list1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonaddcat;
        private System.Windows.Forms.Button buttonsupcat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textcat;
    }
}


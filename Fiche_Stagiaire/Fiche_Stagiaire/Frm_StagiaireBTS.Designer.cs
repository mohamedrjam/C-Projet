namespace Fiche_Stagiaire
{
    partial class Frm_StagiaireBTS
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
            this.lbl_FS = new System.Windows.Forms.Label();
            this.lbl_CD = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Sexe = new System.Windows.Forms.Label();
            this.lbl_DN = new System.Windows.Forms.Label();
            this.lbl_SB = new System.Windows.Forms.Label();
            this.lbl_NG = new System.Windows.Forms.Label();
            this.lbl_FB = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.rb_Femelle = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.dtp_DateNai = new System.Windows.Forms.DateTimePicker();
            this.cmb_Specialite = new System.Windows.Forms.ComboBox();
            this.chk_DAI = new System.Windows.Forms.CheckBox();
            this.chk_SRI = new System.Windows.Forms.CheckBox();
            this.chk_MultiMedia = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Recherche = new System.Windows.Forms.TextBox();
            this.btn_haut = new System.Windows.Forms.Button();
            this.btn_bas = new System.Windows.Forms.Button();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.btn_Imprimer = new System.Windows.Forms.Button();
            this.btn_Recherche = new System.Windows.Forms.Button();
            this.btn_Effacer = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_FS
            // 
            this.lbl_FS.AutoSize = true;
            this.lbl_FS.Font = new System.Drawing.Font("Yu Gothic UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_FS.Location = new System.Drawing.Point(409, 0);
            this.lbl_FS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FS.Name = "lbl_FS";
            this.lbl_FS.Size = new System.Drawing.Size(337, 62);
            this.lbl_FS.TabIndex = 0;
            this.lbl_FS.Text = "Fiche Stagiaire";
            // 
            // lbl_CD
            // 
            this.lbl_CD.AutoSize = true;
            this.lbl_CD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CD.Location = new System.Drawing.Point(55, 85);
            this.lbl_CD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CD.Name = "lbl_CD";
            this.lbl_CD.Size = new System.Drawing.Size(141, 21);
            this.lbl_CD.TabIndex = 1;
            this.lbl_CD.Text = "Code d\'inscription";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.Location = new System.Drawing.Point(55, 117);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(44, 21);
            this.lbl_Nom.TabIndex = 2;
            this.lbl_Nom.Text = "Nom";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prenom.Location = new System.Drawing.Point(55, 149);
            this.lbl_Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(66, 21);
            this.lbl_Prenom.TabIndex = 3;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // lbl_Sexe
            // 
            this.lbl_Sexe.AutoSize = true;
            this.lbl_Sexe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexe.Location = new System.Drawing.Point(56, 185);
            this.lbl_Sexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sexe.Name = "lbl_Sexe";
            this.lbl_Sexe.Size = new System.Drawing.Size(45, 21);
            this.lbl_Sexe.TabIndex = 4;
            this.lbl_Sexe.Text = "Sexe";
            // 
            // lbl_DN
            // 
            this.lbl_DN.AutoSize = true;
            this.lbl_DN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DN.Location = new System.Drawing.Point(595, 85);
            this.lbl_DN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DN.Name = "lbl_DN";
            this.lbl_DN.Size = new System.Drawing.Size(147, 21);
            this.lbl_DN.TabIndex = 5;
            this.lbl_DN.Text = "Date de naissance";
            // 
            // lbl_SB
            // 
            this.lbl_SB.AutoSize = true;
            this.lbl_SB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SB.Location = new System.Drawing.Point(595, 117);
            this.lbl_SB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SB.Name = "lbl_SB";
            this.lbl_SB.Size = new System.Drawing.Size(148, 21);
            this.lbl_SB.TabIndex = 6;
            this.lbl_SB.Text = "Spécialités de BAC";
            // 
            // lbl_NG
            // 
            this.lbl_NG.AutoSize = true;
            this.lbl_NG.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NG.Location = new System.Drawing.Point(595, 149);
            this.lbl_NG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NG.Name = "lbl_NG";
            this.lbl_NG.Size = new System.Drawing.Size(166, 21);
            this.lbl_NG.TabIndex = 7;
            this.lbl_NG.Text = "Note General du BAC";
            // 
            // lbl_FB
            // 
            this.lbl_FB.AutoSize = true;
            this.lbl_FB.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FB.Location = new System.Drawing.Point(595, 188);
            this.lbl_FB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FB.Name = "lbl_FB";
            this.lbl_FB.Size = new System.Drawing.Size(89, 21);
            this.lbl_FB.TabIndex = 8;
            this.lbl_FB.Text = "Filière BTS";
            // 
            // txt_Note
            // 
            this.txt_Note.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Note.Location = new System.Drawing.Point(820, 149);
            this.txt_Note.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(147, 28);
            this.txt_Note.TabIndex = 9;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prenom.Location = new System.Drawing.Point(251, 149);
            this.txt_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(167, 28);
            this.txt_Prenom.TabIndex = 10;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.Location = new System.Drawing.Point(251, 117);
            this.txt_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(167, 28);
            this.txt_Nom.TabIndex = 11;
            // 
            // txt_Code
            // 
            this.txt_Code.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Code.Location = new System.Drawing.Point(251, 85);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(167, 28);
            this.txt_Code.TabIndex = 12;
            this.txt_Code.TextChanged += new System.EventHandler(this.txt_Code_TextChanged);
            // 
            // rb_Femelle
            // 
            this.rb_Femelle.AutoSize = true;
            this.rb_Femelle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Femelle.Location = new System.Drawing.Point(329, 185);
            this.rb_Femelle.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Femelle.Name = "rb_Femelle";
            this.rb_Femelle.Size = new System.Drawing.Size(97, 25);
            this.rb_Femelle.TabIndex = 13;
            this.rb_Femelle.TabStop = true;
            this.rb_Femelle.Text = "Femelle";
            this.rb_Femelle.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(251, 186);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(71, 25);
            this.rb_Male.TabIndex = 14;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            this.rb_Male.CheckedChanged += new System.EventHandler(this.rb_Male_CheckedChanged);
            // 
            // dtp_DateNai
            // 
            this.dtp_DateNai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateNai.Location = new System.Drawing.Point(820, 85);
            this.dtp_DateNai.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DateNai.Name = "dtp_DateNai";
            this.dtp_DateNai.Size = new System.Drawing.Size(235, 28);
            this.dtp_DateNai.TabIndex = 15;
            this.dtp_DateNai.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmb_Specialite
            // 
            this.cmb_Specialite.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Specialite.FormattingEnabled = true;
            this.cmb_Specialite.Items.AddRange(new object[] {
            "Science math",
            "Science physique",
            "economie"});
            this.cmb_Specialite.Location = new System.Drawing.Point(820, 116);
            this.cmb_Specialite.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Specialite.Name = "cmb_Specialite";
            this.cmb_Specialite.Size = new System.Drawing.Size(235, 29);
            this.cmb_Specialite.TabIndex = 16;
            // 
            // chk_DAI
            // 
            this.chk_DAI.AutoSize = true;
            this.chk_DAI.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_DAI.Location = new System.Drawing.Point(819, 188);
            this.chk_DAI.Margin = new System.Windows.Forms.Padding(4);
            this.chk_DAI.Name = "chk_DAI";
            this.chk_DAI.Size = new System.Drawing.Size(65, 25);
            this.chk_DAI.TabIndex = 17;
            this.chk_DAI.Text = "DAI";
            this.chk_DAI.UseVisualStyleBackColor = true;
            // 
            // chk_SRI
            // 
            this.chk_SRI.AutoSize = true;
            this.chk_SRI.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SRI.Location = new System.Drawing.Point(889, 188);
            this.chk_SRI.Margin = new System.Windows.Forms.Padding(4);
            this.chk_SRI.Name = "chk_SRI";
            this.chk_SRI.Size = new System.Drawing.Size(63, 25);
            this.chk_SRI.TabIndex = 18;
            this.chk_SRI.Text = "SRI";
            this.chk_SRI.UseVisualStyleBackColor = true;
            // 
            // chk_MultiMedia
            // 
            this.chk_MultiMedia.AutoSize = true;
            this.chk_MultiMedia.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_MultiMedia.Location = new System.Drawing.Point(958, 188);
            this.chk_MultiMedia.Margin = new System.Windows.Forms.Padding(4);
            this.chk_MultiMedia.Name = "chk_MultiMedia";
            this.chk_MultiMedia.Size = new System.Drawing.Size(126, 25);
            this.chk_MultiMedia.TabIndex = 19;
            this.chk_MultiMedia.Text = "MultiMedia";
            this.chk_MultiMedia.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Prénom,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(60, 301);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(995, 263);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Code";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 6;
            this.Prénom.Name = "Prénom";
            this.Prénom.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sexe";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date Naissance";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Spécialités Bac";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Note Géneral";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Filière BTS";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // txt_Recherche
            // 
            this.txt_Recherche.Location = new System.Drawing.Point(791, 233);
            this.txt_Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Recherche.Name = "txt_Recherche";
            this.txt_Recherche.Size = new System.Drawing.Size(158, 22);
            this.txt_Recherche.TabIndex = 28;
            // 
            // btn_haut
            // 
            this.btn_haut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_haut.Image = global::Fiche_Stagiaire.Properties.Resources.up_arrow;
            this.btn_haut.Location = new System.Drawing.Point(1085, 342);
            this.btn_haut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_haut.Name = "btn_haut";
            this.btn_haut.Size = new System.Drawing.Size(71, 45);
            this.btn_haut.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btn_haut, "Aller au premier stagiaire du tableau");
            this.btn_haut.UseVisualStyleBackColor = true;
            this.btn_haut.Click += new System.EventHandler(this.btn_haut_Click);
            // 
            // btn_bas
            // 
            this.btn_bas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bas.Image = global::Fiche_Stagiaire.Properties.Resources.down_arrow;
            this.btn_bas.Location = new System.Drawing.Point(1085, 489);
            this.btn_bas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bas.Name = "btn_bas";
            this.btn_bas.Size = new System.Drawing.Size(71, 45);
            this.btn_bas.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btn_bas, "Aller au dernier stagiaire du tableau");
            this.btn_bas.UseVisualStyleBackColor = true;
            this.btn_bas.Click += new System.EventHandler(this.btn_bas_Click);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enregistrer.Image = global::Fiche_Stagiaire.Properties.Resources.save_file;
            this.btn_Enregistrer.Location = new System.Drawing.Point(1085, 415);
            this.btn_Enregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(71, 45);
            this.btn_Enregistrer.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btn_Enregistrer, "Sauvegarder les données dans le fichier texte");
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fermer.Image = global::Fiche_Stagiaire.Properties.Resources.cross_button;
            this.btn_Fermer.Location = new System.Drawing.Point(984, 221);
            this.btn_Fermer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(71, 46);
            this.btn_Fermer.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btn_Fermer, "Quitter l\'application");
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // btn_Imprimer
            // 
            this.btn_Imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimer.Image = global::Fiche_Stagiaire.Properties.Resources.print;
            this.btn_Imprimer.Location = new System.Drawing.Point(633, 221);
            this.btn_Imprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Imprimer.Name = "btn_Imprimer";
            this.btn_Imprimer.Size = new System.Drawing.Size(71, 45);
            this.btn_Imprimer.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btn_Imprimer, "Ouvrir et imprimer le rapport texte");
            this.btn_Imprimer.UseVisualStyleBackColor = true;
            this.btn_Imprimer.Click += new System.EventHandler(this.btn_Imprimer_Click);
            // 
            // btn_Recherche
            // 
            this.btn_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recherche.Image = global::Fiche_Stagiaire.Properties.Resources.search;
            this.btn_Recherche.Location = new System.Drawing.Point(712, 221);
            this.btn_Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Recherche.Name = "btn_Recherche";
            this.btn_Recherche.Size = new System.Drawing.Size(71, 45);
            this.btn_Recherche.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btn_Recherche, "Rechercher un stagiaire par son code");
            this.btn_Recherche.UseVisualStyleBackColor = true;
            this.btn_Recherche.Click += new System.EventHandler(this.btn_Recherche_Click);
            // 
            // btn_Effacer
            // 
            this.btn_Effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Effacer.Image = global::Fiche_Stagiaire.Properties.Resources.clear;
            this.btn_Effacer.Location = new System.Drawing.Point(553, 221);
            this.btn_Effacer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Effacer.Name = "btn_Effacer";
            this.btn_Effacer.Size = new System.Drawing.Size(70, 45);
            this.btn_Effacer.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btn_Effacer, "Vider tous les champs du formulaire");
            this.btn_Effacer.UseVisualStyleBackColor = true;
            this.btn_Effacer.Click += new System.EventHandler(this.btn_Effacer_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.Image = global::Fiche_Stagiaire.Properties.Resources.delete;
            this.btn_Supprimer.Location = new System.Drawing.Point(475, 220);
            this.btn_Supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(70, 46);
            this.btn_Supprimer.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btn_Supprimer, "Supprimer le stagiaire sélectionné");
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.Image = global::Fiche_Stagiaire.Properties.Resources.add_user;
            this.btn_Ajouter.Location = new System.Drawing.Point(397, 221);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(70, 45);
            this.btn_Ajouter.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btn_Ajouter, "Ajouter un nouveau stagiaire au tableau");
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nouveau.Image = global::Fiche_Stagiaire.Properties.Resources.create;
            this.btn_Nouveau.Location = new System.Drawing.Point(319, 220);
            this.btn_Nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(70, 46);
            this.btn_Nouveau.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btn_Nouveau, "Préparer le formulaire pour un nouveau stagiaire");
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lbl_FS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 74);
            this.panel1.TabIndex = 32;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Frm_StagiaireBTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1191, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.btn_bas);
            this.Controls.Add(this.btn_haut);
            this.Controls.Add(this.txt_Recherche);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.btn_Imprimer);
            this.Controls.Add(this.btn_Recherche);
            this.Controls.Add(this.btn_Effacer);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Nouveau);
            this.Controls.Add(this.chk_MultiMedia);
            this.Controls.Add(this.chk_SRI);
            this.Controls.Add(this.chk_DAI);
            this.Controls.Add(this.cmb_Specialite);
            this.Controls.Add(this.dtp_DateNai);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.rb_Femelle);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.lbl_FB);
            this.Controls.Add(this.lbl_NG);
            this.Controls.Add(this.lbl_SB);
            this.Controls.Add(this.lbl_DN);
            this.Controls.Add(this.lbl_Sexe);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_CD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_StagiaireBTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiche Stagiaire BTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FS;
        private System.Windows.Forms.Label lbl_CD;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Sexe;
        private System.Windows.Forms.Label lbl_DN;
        private System.Windows.Forms.Label lbl_SB;
        private System.Windows.Forms.Label lbl_NG;
        private System.Windows.Forms.Label lbl_FB;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.RadioButton rb_Femelle;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.DateTimePicker dtp_DateNai;
        private System.Windows.Forms.ComboBox cmb_Specialite;
        private System.Windows.Forms.CheckBox chk_DAI;
        private System.Windows.Forms.CheckBox chk_SRI;
        private System.Windows.Forms.CheckBox chk_MultiMedia;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Effacer;
        private System.Windows.Forms.Button btn_Recherche;
        private System.Windows.Forms.Button btn_Imprimer;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txt_Recherche;
        private System.Windows.Forms.Button btn_haut;
        private System.Windows.Forms.Button btn_bas;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace appProramme_messe.controlsUser
{
    partial class gestion_chant
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSupremer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAddChant = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.panel30 = new System.Windows.Forms.Panel();
            this.cbRecharche = new System.Windows.Forms.ComboBox();
            this.pnlAddchant = new System.Windows.Forms.Panel();
            this.txtIdChant = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCouplets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel33 = new System.Windows.Forms.Panel();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.btnModife = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cbAuteur = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgtChants = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel31.SuspendLayout();
            this.pnlAddchant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtChants)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSupremer);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.btnAddChant);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 58);
            this.panel2.TabIndex = 1;
            // 
            // btnSupremer
            // 
            this.btnSupremer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupremer.FlatAppearance.BorderSize = 0;
            this.btnSupremer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSupremer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSupremer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupremer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupremer.ForeColor = System.Drawing.Color.Black;
            this.btnSupremer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupremer.Location = new System.Drawing.Point(839, 6);
            this.btnSupremer.Name = "btnSupremer";
            this.btnSupremer.Size = new System.Drawing.Size(169, 45);
            this.btnSupremer.TabIndex = 20;
            this.btnSupremer.Text = "Supprimer";
            this.btnSupremer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupremer.UseVisualStyleBackColor = true;
            this.btnSupremer.Click += new System.EventHandler(this.btnSupremer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(417, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(156, 45);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier ";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAddChant
            // 
            this.btnAddChant.FlatAppearance.BorderSize = 0;
            this.btnAddChant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddChant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddChant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChant.ForeColor = System.Drawing.Color.Black;
            this.btnAddChant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddChant.Location = new System.Drawing.Point(15, 5);
            this.btnAddChant.Name = "btnAddChant";
            this.btnAddChant.Size = new System.Drawing.Size(186, 45);
            this.btnAddChant.TabIndex = 18;
            this.btnAddChant.Text = "Ajouter Chant";
            this.btnAddChant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddChant.UseVisualStyleBackColor = true;
            this.btnAddChant.Click += new System.EventHandler(this.btnAddChant_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.panel31);
            this.panel3.Controls.Add(this.txtRecherche);
            this.panel3.Controls.Add(this.panel30);
            this.panel3.Controls.Add(this.cbRecharche);
            this.panel3.Controls.Add(this.pnlAddchant);
            this.panel3.Controls.Add(this.dgtChants);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 607);
            this.panel3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(695, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(15, 15);
            this.button4.TabIndex = 137;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel31
            // 
            this.panel31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel31.BackColor = System.Drawing.Color.Black;
            this.panel31.Controls.Add(this.panel32);
            this.panel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel31.Location = new System.Drawing.Point(456, 46);
            this.panel31.Margin = new System.Windows.Forms.Padding(4);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(256, 3);
            this.panel31.TabIndex = 135;
            // 
            // panel32
            // 
            this.panel32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel32.Location = new System.Drawing.Point(-71, 28);
            this.panel32.Margin = new System.Windows.Forms.Padding(4);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(256, 4);
            this.panel32.TabIndex = 4;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRecherche.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.ForeColor = System.Drawing.Color.DimGray;
            this.txtRecherche.Location = new System.Drawing.Point(456, 28);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecherche.Multiline = true;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(239, 31);
            this.txtRecherche.TabIndex = 136;
            this.txtRecherche.Text = "Recherche...........................";
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.Enter += new System.EventHandler(this.txtRecherche_Enter);
            this.txtRecherche.Leave += new System.EventHandler(this.txtRecherche_Leave);
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.Black;
            this.panel30.Location = new System.Drawing.Point(291, 48);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(161, 2);
            this.panel30.TabIndex = 134;
            // 
            // cbRecharche
            // 
            this.cbRecharche.BackColor = System.Drawing.SystemColors.Control;
            this.cbRecharche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRecharche.FormattingEnabled = true;
            this.cbRecharche.Items.AddRange(new object[] {
            "TITRE",
            "CATEGORIE",
            "AUTEUR"});
            this.cbRecharche.Location = new System.Drawing.Point(292, 21);
            this.cbRecharche.Name = "cbRecharche";
            this.cbRecharche.Size = new System.Drawing.Size(161, 29);
            this.cbRecharche.TabIndex = 133;
            // 
            // pnlAddchant
            // 
            this.pnlAddchant.BackColor = System.Drawing.Color.White;
            this.pnlAddchant.Controls.Add(this.txtIdChant);
            this.pnlAddchant.Controls.Add(this.panel7);
            this.pnlAddchant.Controls.Add(this.txtCouplets);
            this.pnlAddchant.Controls.Add(this.label1);
            this.pnlAddchant.Controls.Add(this.panel33);
            this.pnlAddchant.Controls.Add(this.txtTitre);
            this.pnlAddchant.Controls.Add(this.btnModife);
            this.pnlAddchant.Controls.Add(this.btnQuitter);
            this.pnlAddchant.Controls.Add(this.panel11);
            this.pnlAddchant.Controls.Add(this.cbAuteur);
            this.pnlAddchant.Controls.Add(this.panel10);
            this.pnlAddchant.Controls.Add(this.cbCategorie);
            this.pnlAddchant.Controls.Add(this.label17);
            this.pnlAddchant.Controls.Add(this.label4);
            this.pnlAddchant.Controls.Add(this.label3);
            this.pnlAddchant.Controls.Add(this.lbTitre);
            this.pnlAddchant.Controls.Add(this.button2);
            this.pnlAddchant.Controls.Add(this.button1);
            this.pnlAddchant.Controls.Add(this.panel9);
            this.pnlAddchant.Controls.Add(this.panel6);
            this.pnlAddchant.Controls.Add(this.panel5);
            this.pnlAddchant.Controls.Add(this.panel4);
            this.pnlAddchant.Location = new System.Drawing.Point(86, 60);
            this.pnlAddchant.Name = "pnlAddchant";
            this.pnlAddchant.Size = new System.Drawing.Size(865, 533);
            this.pnlAddchant.TabIndex = 131;
            this.pnlAddchant.Visible = false;
            // 
            // txtIdChant
            // 
            this.txtIdChant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdChant.Location = new System.Drawing.Point(22, 26);
            this.txtIdChant.Name = "txtIdChant";
            this.txtIdChant.Size = new System.Drawing.Size(17, 20);
            this.txtIdChant.TabIndex = 141;
            this.txtIdChant.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(22, 473);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(807, 2);
            this.panel7.TabIndex = 140;
            // 
            // txtCouplets
            // 
            this.txtCouplets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCouplets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCouplets.Location = new System.Drawing.Point(22, 175);
            this.txtCouplets.Multiline = true;
            this.txtCouplets.Name = "txtCouplets";
            this.txtCouplets.Size = new System.Drawing.Size(806, 299);
            this.txtCouplets.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 138;
            this.label1.Text = "COUPLETS :  ";
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.Black;
            this.panel33.Location = new System.Drawing.Point(141, 90);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(697, 2);
            this.panel33.TabIndex = 137;
            // 
            // txtTitre
            // 
            this.txtTitre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitre.Location = new System.Drawing.Point(141, 71);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(696, 20);
            this.txtTitre.TabIndex = 136;
            // 
            // btnModife
            // 
            this.btnModife.FlatAppearance.BorderSize = 0;
            this.btnModife.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnModife.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModife.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModife.ForeColor = System.Drawing.Color.Black;
            this.btnModife.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModife.Location = new System.Drawing.Point(642, 487);
            this.btnModife.Name = "btnModife";
            this.btnModife.Size = new System.Drawing.Size(186, 38);
            this.btnModife.TabIndex = 134;
            this.btnModife.Text = "MODIFIER";
            this.btnModife.UseVisualStyleBackColor = true;
            this.btnModife.Click += new System.EventHandler(this.btnModife_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(817, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(44, 31);
            this.btnQuitter.TabIndex = 133;
            this.btnQuitter.Text = "Q";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(592, 132);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(245, 2);
            this.panel11.TabIndex = 46;
            // 
            // cbAuteur
            // 
            this.cbAuteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAuteur.FormattingEnabled = true;
            this.cbAuteur.Items.AddRange(new object[] {
            ""});
            this.cbAuteur.Location = new System.Drawing.Point(593, 105);
            this.cbAuteur.Name = "cbAuteur";
            this.cbAuteur.Size = new System.Drawing.Size(245, 29);
            this.cbAuteur.TabIndex = 45;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(142, 130);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(245, 2);
            this.panel10.TabIndex = 44;
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Items.AddRange(new object[] {
            "",
            "KYRIE",
            "GLORIA",
            "VD ",
            "MEDITATION PSAUME",
            "SANCTUS",
            "ACCLAMATION",
            "P.U",
            "OFFERTOIRE",
            "AD",
            "UNIVERSELLE",
            "CHANT DE NOEL",
            "CREDO",
            "PRIERRE",
            "BAPTEME"});
            this.cbCategorie.Location = new System.Drawing.Point(143, 103);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(245, 29);
            this.cbCategorie.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(466, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 19);
            this.label17.TabIndex = 34;
            this.label17.Text = "AUTEUR : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "CATEGORIE : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "TITRE : ";
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.Location = new System.Drawing.Point(300, 14);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(240, 19);
            this.lbTitre.TabIndex = 18;
            this.lbTitre.Text = "AJOUTER UN NOUVEAU CHANT";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(22, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 38);
            this.button2.TabIndex = 17;
            this.button2.Text = "ACTUALISER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(643, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "ENREGISTRER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Maroon;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2, 529);
            this.panel9.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(863, 2);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 531);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(863, 2);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(863, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 533);
            this.panel4.TabIndex = 0;
            // 
            // dgtChants
            // 
            this.dgtChants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgtChants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtChants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtChants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgtChants.Location = new System.Drawing.Point(19, 71);
            this.dgtChants.Name = "dgtChants";
            this.dgtChants.Size = new System.Drawing.Size(974, 522);
            this.dgtChants.TabIndex = 1;
            this.dgtChants.SelectionChanged += new System.EventHandler(this.dgtChants_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 37.2882F;
            this.Column1.HeaderText = "N°";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 174.3223F;
            this.Column3.HeaderText = "Titre";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 174.3223F;
            this.Column4.HeaderText = "Couplets";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 50.76142F;
            this.Column5.HeaderText = "Catégorie";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 63.30568F;
            this.Column6.HeaderText = "Auteur";
            this.Column6.Name = "Column6";
            // 
            // gestion_chant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "gestion_chant";
            this.Size = new System.Drawing.Size(1018, 668);
            this.Load += new System.EventHandler(this.gestion_chant_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.pnlAddchant.ResumeLayout(false);
            this.pnlAddchant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtChants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSupremer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAddChant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgtChants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.ComboBox cbRecharche;
        private System.Windows.Forms.Panel pnlAddchant;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtCouplets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.Button btnModife;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cbAuteur;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIdChant;
    }
}

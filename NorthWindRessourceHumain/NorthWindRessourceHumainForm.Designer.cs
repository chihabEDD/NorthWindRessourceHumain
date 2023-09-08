namespace NorthWindRessourceHumain
{
    partial class NorthWindRessourceHumainForm
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
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label nom_de_la_familleLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label fonctionLabel;
            System.Windows.Forms.Label date_de_naissancesLabel;
            System.Windows.Forms.Label date_d_embauche_Label;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label nom_du_superviseurLabel;
            System.Windows.Forms.Label prenom_superviseurLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NorthWindRessourceHumainForm));
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new NorthWindRessourceHumain.NorthwindDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.numeroLabel1 = new System.Windows.Forms.Label();
            this.nom_de_la_familleLabel1 = new System.Windows.Forms.Label();
            this.prenomLabel1 = new System.Windows.Forms.Label();
            this.fonctionLabel1 = new System.Windows.Forms.Label();
            this.date_de_naissancesLabel1 = new System.Windows.Forms.Label();
            this.date_d_embauche_Label1 = new System.Windows.Forms.Label();
            this.nom_du_superviseurLabel1 = new System.Windows.Forms.Label();
            this.prenom_superviseurLabel1 = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new NorthWindRessourceHumain.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.filtertoolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.tousVendeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousSansSupervisuerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NomFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFonctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateEmbaucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierTousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.byOrderToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.superviseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            numeroLabel = new System.Windows.Forms.Label();
            nom_de_la_familleLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            fonctionLabel = new System.Windows.Forms.Label();
            date_de_naissancesLabel = new System.Windows.Forms.Label();
            date_d_embauche_Label = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            nom_du_superviseurLabel = new System.Windows.Forms.Label();
            prenom_superviseurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(57, 90);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(58, 16);
            numeroLabel.TabIndex = 1;
            numeroLabel.Text = "Numero:";
            // 
            // nom_de_la_familleLabel
            // 
            nom_de_la_familleLabel.AutoSize = true;
            nom_de_la_familleLabel.Location = new System.Drawing.Point(57, 130);
            nom_de_la_familleLabel.Name = "nom_de_la_familleLabel";
            nom_de_la_familleLabel.Size = new System.Drawing.Size(114, 16);
            nom_de_la_familleLabel.TabIndex = 3;
            nom_de_la_familleLabel.Text = "Nom de la famille:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(57, 166);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(57, 16);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "Prenom:";
            // 
            // fonctionLabel
            // 
            fonctionLabel.AutoSize = true;
            fonctionLabel.Location = new System.Drawing.Point(57, 211);
            fonctionLabel.Name = "fonctionLabel";
            fonctionLabel.Size = new System.Drawing.Size(61, 16);
            fonctionLabel.TabIndex = 7;
            fonctionLabel.Text = "Fonction:";
            // 
            // date_de_naissancesLabel
            // 
            date_de_naissancesLabel.AutoSize = true;
            date_de_naissancesLabel.Location = new System.Drawing.Point(57, 252);
            date_de_naissancesLabel.Name = "date_de_naissancesLabel";
            date_de_naissancesLabel.Size = new System.Drawing.Size(130, 16);
            date_de_naissancesLabel.TabIndex = 9;
            date_de_naissancesLabel.Text = "Date de naissances:";
            // 
            // date_d_embauche_Label
            // 
            date_d_embauche_Label.AutoSize = true;
            date_d_embauche_Label.Location = new System.Drawing.Point(57, 295);
            date_d_embauche_Label.Name = "date_d_embauche_Label";
            date_d_embauche_Label.Size = new System.Drawing.Size(120, 16);
            date_d_embauche_Label.TabIndex = 11;
            date_d_embauche_Label.Text = "Date d\'embauche\':";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(591, 91);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(45, 16);
            photoLabel.TabIndex = 13;
            photoLabel.Text = "Photo:";
            // 
            // nom_du_superviseurLabel
            // 
            nom_du_superviseurLabel.AutoSize = true;
            nom_du_superviseurLabel.Location = new System.Drawing.Point(57, 333);
            nom_du_superviseurLabel.Name = "nom_du_superviseurLabel";
            nom_du_superviseurLabel.Size = new System.Drawing.Size(130, 16);
            nom_du_superviseurLabel.TabIndex = 15;
            nom_du_superviseurLabel.Text = "Nom du superviseur:";
            // 
            // prenom_superviseurLabel
            // 
            prenom_superviseurLabel.AutoSize = true;
            prenom_superviseurLabel.Location = new System.Drawing.Point(57, 373);
            prenom_superviseurLabel.Name = "prenom_superviseurLabel";
            prenom_superviseurLabel.Size = new System.Drawing.Size(130, 16);
            prenom_superviseurLabel.TabIndex = 17;
            prenom_superviseurLabel.Text = "Prenom superviseur:";
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = null;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = null;
            this.employeesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.filtertoolStripDropDownButton,
            this.imprimerToolStripButton,
            this.byOrderToolStripDropDownButton});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(1034, 27);
            this.employeesBindingNavigator.TabIndex = 0;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // numeroLabel1
            // 
            this.numeroLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Numero", true));
            this.numeroLabel1.Location = new System.Drawing.Point(218, 90);
            this.numeroLabel1.Name = "numeroLabel1";
            this.numeroLabel1.Size = new System.Drawing.Size(271, 23);
            this.numeroLabel1.TabIndex = 2;
            this.numeroLabel1.Text = "label1";
            // 
            // nom_de_la_familleLabel1
            // 
            this.nom_de_la_familleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_de_la_familleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Nom de la famille", true));
            this.nom_de_la_familleLabel1.Location = new System.Drawing.Point(218, 130);
            this.nom_de_la_familleLabel1.Name = "nom_de_la_familleLabel1";
            this.nom_de_la_familleLabel1.Size = new System.Drawing.Size(271, 23);
            this.nom_de_la_familleLabel1.TabIndex = 4;
            this.nom_de_la_familleLabel1.Text = "label1";
            // 
            // prenomLabel1
            // 
            this.prenomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Prenom", true));
            this.prenomLabel1.Location = new System.Drawing.Point(218, 166);
            this.prenomLabel1.Name = "prenomLabel1";
            this.prenomLabel1.Size = new System.Drawing.Size(271, 23);
            this.prenomLabel1.TabIndex = 6;
            this.prenomLabel1.Text = "label1";
            // 
            // fonctionLabel1
            // 
            this.fonctionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fonctionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Fonction", true));
            this.fonctionLabel1.Location = new System.Drawing.Point(218, 211);
            this.fonctionLabel1.Name = "fonctionLabel1";
            this.fonctionLabel1.Size = new System.Drawing.Size(271, 23);
            this.fonctionLabel1.TabIndex = 8;
            this.fonctionLabel1.Text = "label1";
            // 
            // date_de_naissancesLabel1
            // 
            this.date_de_naissancesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_de_naissancesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Date de naissances", true));
            this.date_de_naissancesLabel1.Location = new System.Drawing.Point(218, 252);
            this.date_de_naissancesLabel1.Name = "date_de_naissancesLabel1";
            this.date_de_naissancesLabel1.Size = new System.Drawing.Size(271, 23);
            this.date_de_naissancesLabel1.TabIndex = 10;
            this.date_de_naissancesLabel1.Text = "label1";
            // 
            // date_d_embauche_Label1
            // 
            this.date_d_embauche_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date_d_embauche_Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Date d\'embauche\'", true));
            this.date_d_embauche_Label1.Location = new System.Drawing.Point(218, 295);
            this.date_d_embauche_Label1.Name = "date_d_embauche_Label1";
            this.date_d_embauche_Label1.Size = new System.Drawing.Size(271, 23);
            this.date_d_embauche_Label1.TabIndex = 12;
            this.date_d_embauche_Label1.Text = "label1";
            // 
            // nom_du_superviseurLabel1
            // 
            this.nom_du_superviseurLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom_du_superviseurLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Nom du superviseur", true));
            this.nom_du_superviseurLabel1.Location = new System.Drawing.Point(218, 333);
            this.nom_du_superviseurLabel1.Name = "nom_du_superviseurLabel1";
            this.nom_du_superviseurLabel1.Size = new System.Drawing.Size(271, 23);
            this.nom_du_superviseurLabel1.TabIndex = 16;
            this.nom_du_superviseurLabel1.Text = "label1";
            // 
            // prenom_superviseurLabel1
            // 
            this.prenom_superviseurLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prenom_superviseurLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Prenom superviseur", true));
            this.prenom_superviseurLabel1.Location = new System.Drawing.Point(218, 373);
            this.prenom_superviseurLabel1.Name = "prenom_superviseurLabel1";
            this.prenom_superviseurLabel1.Size = new System.Drawing.Size(271, 23);
            this.prenom_superviseurLabel1.TabIndex = 18;
            this.prenom_superviseurLabel1.Text = "label1";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(665, 91);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(295, 306);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 14;
            this.photoPictureBox.TabStop = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // filtertoolStripDropDownButton
            // 
            this.filtertoolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filtertoolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousVendeursToolStripMenuItem,
            this.tousSansSupervisuerToolStripMenuItem,
            this.NomFamilleToolStripMenuItem,
            this.parFonctionToolStripMenuItem,
            this.dateEmbaucheToolStripMenuItem,
            this.dossierTousToolStripMenuItem});
            this.filtertoolStripDropDownButton.Image = global::NorthWindRessourceHumain.Properties.Resources.filtre;
            this.filtertoolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filtertoolStripDropDownButton.Name = "filtertoolStripDropDownButton";
            this.filtertoolStripDropDownButton.Size = new System.Drawing.Size(34, 24);
            this.filtertoolStripDropDownButton.Text = "toolStripDropDownButton1";
            this.filtertoolStripDropDownButton.Click += new System.EventHandler(this.filterageToolStripMenuItem_Click);
            // 
            // tousVendeursToolStripMenuItem
            // 
            this.tousVendeursToolStripMenuItem.Name = "tousVendeursToolStripMenuItem";
            this.tousVendeursToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.tousVendeursToolStripMenuItem.Text = "Tous les vendeurs";
            this.tousVendeursToolStripMenuItem.Click += new System.EventHandler(this.filterageToolStripMenuItem_Click);
            // 
            // tousSansSupervisuerToolStripMenuItem
            // 
            this.tousSansSupervisuerToolStripMenuItem.Name = "tousSansSupervisuerToolStripMenuItem";
            this.tousSansSupervisuerToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.tousSansSupervisuerToolStripMenuItem.Text = "Tous les employes nàyant pas de superviseur";
            this.tousSansSupervisuerToolStripMenuItem.Click += new System.EventHandler(this.filterageToolStripMenuItem_Click);
            // 
            // NomFamilleToolStripMenuItem
            // 
            this.NomFamilleToolStripMenuItem.Name = "NomFamilleToolStripMenuItem";
            this.NomFamilleToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.NomFamilleToolStripMenuItem.Text = "Par nom de famille....";
            this.NomFamilleToolStripMenuItem.Click += new System.EventHandler(this.triParNomFonctionDateToolStripMenuItem_Click);
            // 
            // parFonctionToolStripMenuItem
            // 
            this.parFonctionToolStripMenuItem.Name = "parFonctionToolStripMenuItem";
            this.parFonctionToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.parFonctionToolStripMenuItem.Text = "Par fonction";
            this.parFonctionToolStripMenuItem.Click += new System.EventHandler(this.triParNomFonctionDateToolStripMenuItem_Click);
            // 
            // dateEmbaucheToolStripMenuItem
            // 
            this.dateEmbaucheToolStripMenuItem.Name = "dateEmbaucheToolStripMenuItem";
            this.dateEmbaucheToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.dateEmbaucheToolStripMenuItem.Text = "Par date dèmbauche...";
            this.dateEmbaucheToolStripMenuItem.Click += new System.EventHandler(this.triParNomFonctionDateToolStripMenuItem_Click);
            // 
            // dossierTousToolStripMenuItem
            // 
            this.dossierTousToolStripMenuItem.Name = "dossierTousToolStripMenuItem";
            this.dossierTousToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.dossierTousToolStripMenuItem.Text = "Voir les dossiers de tous les employee";
            this.dossierTousToolStripMenuItem.Click += new System.EventHandler(this.filterageToolStripMenuItem_Click);
            // 
            // imprimerToolStripButton
            // 
            this.imprimerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimerToolStripButton.Image = global::NorthWindRessourceHumain.Properties.Resources.imprimer;
            this.imprimerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripButton.Name = "imprimerToolStripButton";
            this.imprimerToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.imprimerToolStripButton.Text = "toolStripButton1";
            this.imprimerToolStripButton.Click += new System.EventHandler(this.imprimerToolStripButton_Click);
            // 
            // byOrderToolStripDropDownButton
            // 
            this.byOrderToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.byOrderToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.superviseurToolStripMenuItem,
            this.fonctionToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.originalToolStripMenuItem});
            this.byOrderToolStripDropDownButton.Image = global::NorthWindRessourceHumain.Properties.Resources.order;
            this.byOrderToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.byOrderToolStripDropDownButton.Name = "byOrderToolStripDropDownButton";
            this.byOrderToolStripDropDownButton.Size = new System.Drawing.Size(34, 24);
            this.byOrderToolStripDropDownButton.Text = "Order";
            // 
            // superviseurToolStripMenuItem
            // 
            this.superviseurToolStripMenuItem.Image = global::NorthWindRessourceHumain.Properties.Resources.desc;
            this.superviseurToolStripMenuItem.Name = "superviseurToolStripMenuItem";
            this.superviseurToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.superviseurToolStripMenuItem.Text = "Nom et preom de superviseur";
            this.superviseurToolStripMenuItem.Click += new System.EventHandler(this.orderAscDescToolStripMenuItem_Click);
            // 
            // fonctionToolStripMenuItem
            // 
            this.fonctionToolStripMenuItem.Image = global::NorthWindRessourceHumain.Properties.Resources.asc;
            this.fonctionToolStripMenuItem.Name = "fonctionToolStripMenuItem";
            this.fonctionToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.fonctionToolStripMenuItem.Text = "Fonction, Nom et preom de l\'employe";
            this.fonctionToolStripMenuItem.Click += new System.EventHandler(this.orderAscDescToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Image = global::NorthWindRessourceHumain.Properties.Resources.asc;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.dateToolStripMenuItem.Text = "Date d\'embauche";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.orderAscDescToolStripMenuItem_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Image = global::NorthWindRessourceHumain.Properties.Resources.asc;
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.originalToolStripMenuItem.Text = "Order original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.orderAscDescToolStripMenuItem_Click);
            // 
            // NorthWindRessourceHumainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroLabel1);
            this.Controls.Add(nom_de_la_familleLabel);
            this.Controls.Add(this.nom_de_la_familleLabel1);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomLabel1);
            this.Controls.Add(fonctionLabel);
            this.Controls.Add(this.fonctionLabel1);
            this.Controls.Add(date_de_naissancesLabel);
            this.Controls.Add(this.date_de_naissancesLabel1);
            this.Controls.Add(date_d_embauche_Label);
            this.Controls.Add(this.date_d_embauche_Label1);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(nom_du_superviseurLabel);
            this.Controls.Add(this.nom_du_superviseurLabel1);
            this.Controls.Add(prenom_superviseurLabel);
            this.Controls.Add(this.prenom_superviseurLabel1);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Name = "NorthWindRessourceHumainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ressource Humain";
            this.Load += new System.EventHandler(this.NorthWindRessourceHumainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label numeroLabel1;
        private System.Windows.Forms.Label nom_de_la_familleLabel1;
        private System.Windows.Forms.Label prenomLabel1;
        private System.Windows.Forms.Label fonctionLabel1;
        private System.Windows.Forms.Label date_de_naissancesLabel1;
        private System.Windows.Forms.Label date_d_embauche_Label1;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label nom_du_superviseurLabel1;
        private System.Windows.Forms.Label prenom_superviseurLabel1;
        private System.Windows.Forms.ToolStripDropDownButton filtertoolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem tousVendeursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousSansSupervisuerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NomFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFonctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateEmbaucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierTousToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton imprimerToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton byOrderToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem superviseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
    }
}


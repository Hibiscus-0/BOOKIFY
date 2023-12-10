namespace BOOKIFY
{
    partial class AddBookPopup_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookPopup_Form));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookTitleTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.ISBNTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.publisherTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.CopyrightTxtBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.cancelBtn = new RJCodeAdvance.RJControls.RJButton();
            this.addBookBtn = new RJCodeAdvance.RJControls.RJButton();
            this.roundedPanelGenre = new BOOKIFY.RoundedPanel();
            this.customComboBoxGenre = new BOOKIFY.CustomComboBox();
            this.roundedPanelComboBoxCategory = new BOOKIFY.RoundedPanel();
            this.customComboBoxCategory = new BOOKIFY.CustomComboBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanelGenre.SuspendLayout();
            this.roundedPanelComboBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelHeader.Controls.Add(this.iconButtonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(506, 39);
            this.panelHeader.TabIndex = 62;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.ForeColor = System.Drawing.Color.Transparent;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 30;
            this.iconButtonClose.Location = new System.Drawing.Point(470, 9);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(23, 23);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.BackColor = System.Drawing.Color.Transparent;
            this.lblAddBook.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.lblAddBook.Location = new System.Drawing.Point(176, 173);
            this.lblAddBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(159, 37);
            this.lblAddBook.TabIndex = 66;
            this.lblAddBook.Text = "Add Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // bookTitleTxtBox
            // 
            this.bookTitleTxtBox.AcceptsReturn = false;
            this.bookTitleTxtBox.AcceptsTab = false;
            this.bookTitleTxtBox.AnimationSpeed = 200;
            this.bookTitleTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bookTitleTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bookTitleTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.bookTitleTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookTitleTxtBox.BackgroundImage")));
            this.bookTitleTxtBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bookTitleTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bookTitleTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bookTitleTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.bookTitleTxtBox.BorderRadius = 15;
            this.bookTitleTxtBox.BorderThickness = 2;
            this.bookTitleTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bookTitleTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookTitleTxtBox.DefaultFont = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTxtBox.DefaultText = "";
            this.bookTitleTxtBox.FillColor = System.Drawing.Color.White;
            this.bookTitleTxtBox.HideSelection = true;
            this.bookTitleTxtBox.IconLeft = null;
            this.bookTitleTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bookTitleTxtBox.IconPadding = 10;
            this.bookTitleTxtBox.IconRight = null;
            this.bookTitleTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bookTitleTxtBox.Lines = new string[0];
            this.bookTitleTxtBox.Location = new System.Drawing.Point(180, 236);
            this.bookTitleTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookTitleTxtBox.MaxLength = 32767;
            this.bookTitleTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.bookTitleTxtBox.Modified = false;
            this.bookTitleTxtBox.Multiline = false;
            this.bookTitleTxtBox.Name = "bookTitleTxtBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bookTitleTxtBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bookTitleTxtBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bookTitleTxtBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bookTitleTxtBox.OnIdleState = stateProperties4;
            this.bookTitleTxtBox.Padding = new System.Windows.Forms.Padding(2);
            this.bookTitleTxtBox.PasswordChar = '\0';
            this.bookTitleTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bookTitleTxtBox.PlaceholderText = "";
            this.bookTitleTxtBox.ReadOnly = false;
            this.bookTitleTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookTitleTxtBox.SelectedText = "";
            this.bookTitleTxtBox.SelectionLength = 0;
            this.bookTitleTxtBox.SelectionStart = 0;
            this.bookTitleTxtBox.ShortcutsEnabled = true;
            this.bookTitleTxtBox.Size = new System.Drawing.Size(299, 36);
            this.bookTitleTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bookTitleTxtBox.TabIndex = 68;
            this.bookTitleTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookTitleTxtBox.TextMarginBottom = 0;
            this.bookTitleTxtBox.TextMarginLeft = 3;
            this.bookTitleTxtBox.TextMarginTop = 0;
            this.bookTitleTxtBox.TextPlaceholder = "";
            this.bookTitleTxtBox.UseSystemPasswordChar = false;
            this.bookTitleTxtBox.WordWrap = true;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.White;
            this.lblBookTitle.Location = new System.Drawing.Point(25, 242);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(95, 22);
            this.lblBookTitle.TabIndex = 67;
            this.lblBookTitle.Text = "Book Title";
            // 
            // ISBNTxtBox
            // 
            this.ISBNTxtBox.AcceptsReturn = false;
            this.ISBNTxtBox.AcceptsTab = false;
            this.ISBNTxtBox.AnimationSpeed = 200;
            this.ISBNTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ISBNTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ISBNTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.ISBNTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ISBNTxtBox.BackgroundImage")));
            this.ISBNTxtBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.ISBNTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ISBNTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.ISBNTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.ISBNTxtBox.BorderRadius = 15;
            this.ISBNTxtBox.BorderThickness = 2;
            this.ISBNTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ISBNTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ISBNTxtBox.DefaultFont = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNTxtBox.DefaultText = "";
            this.ISBNTxtBox.FillColor = System.Drawing.Color.White;
            this.ISBNTxtBox.HideSelection = true;
            this.ISBNTxtBox.IconLeft = null;
            this.ISBNTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ISBNTxtBox.IconPadding = 10;
            this.ISBNTxtBox.IconRight = null;
            this.ISBNTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ISBNTxtBox.Lines = new string[0];
            this.ISBNTxtBox.Location = new System.Drawing.Point(180, 287);
            this.ISBNTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ISBNTxtBox.MaxLength = 32767;
            this.ISBNTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.ISBNTxtBox.Modified = false;
            this.ISBNTxtBox.Multiline = false;
            this.ISBNTxtBox.Name = "ISBNTxtBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ISBNTxtBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ISBNTxtBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ISBNTxtBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ISBNTxtBox.OnIdleState = stateProperties8;
            this.ISBNTxtBox.Padding = new System.Windows.Forms.Padding(2);
            this.ISBNTxtBox.PasswordChar = '\0';
            this.ISBNTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ISBNTxtBox.PlaceholderText = "";
            this.ISBNTxtBox.ReadOnly = false;
            this.ISBNTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ISBNTxtBox.SelectedText = "";
            this.ISBNTxtBox.SelectionLength = 0;
            this.ISBNTxtBox.SelectionStart = 0;
            this.ISBNTxtBox.ShortcutsEnabled = true;
            this.ISBNTxtBox.Size = new System.Drawing.Size(299, 36);
            this.ISBNTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.ISBNTxtBox.TabIndex = 70;
            this.ISBNTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ISBNTxtBox.TextMarginBottom = 0;
            this.ISBNTxtBox.TextMarginLeft = 3;
            this.ISBNTxtBox.TextMarginTop = 0;
            this.ISBNTxtBox.TextPlaceholder = "";
            this.ISBNTxtBox.UseSystemPasswordChar = false;
            this.ISBNTxtBox.WordWrap = true;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.White;
            this.lblISBN.Location = new System.Drawing.Point(25, 293);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(50, 22);
            this.lblISBN.TabIndex = 69;
            this.lblISBN.Text = "ISBN";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.ForeColor = System.Drawing.Color.White;
            this.labelCategory.Location = new System.Drawing.Point(25, 344);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(87, 22);
            this.labelCategory.TabIndex = 71;
            this.labelCategory.Text = "Category";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(25, 395);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 22);
            this.lblGenre.TabIndex = 73;
            this.lblGenre.Text = "Genre";
            // 
            // publisherTxtBox
            // 
            this.publisherTxtBox.AcceptsReturn = false;
            this.publisherTxtBox.AcceptsTab = false;
            this.publisherTxtBox.AnimationSpeed = 200;
            this.publisherTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.publisherTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.publisherTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.publisherTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publisherTxtBox.BackgroundImage")));
            this.publisherTxtBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.publisherTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.publisherTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.publisherTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.publisherTxtBox.BorderRadius = 15;
            this.publisherTxtBox.BorderThickness = 2;
            this.publisherTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.publisherTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTxtBox.DefaultFont = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherTxtBox.DefaultText = "";
            this.publisherTxtBox.FillColor = System.Drawing.Color.White;
            this.publisherTxtBox.HideSelection = true;
            this.publisherTxtBox.IconLeft = null;
            this.publisherTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTxtBox.IconPadding = 10;
            this.publisherTxtBox.IconRight = null;
            this.publisherTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.publisherTxtBox.Lines = new string[0];
            this.publisherTxtBox.Location = new System.Drawing.Point(180, 440);
            this.publisherTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.publisherTxtBox.MaxLength = 32767;
            this.publisherTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.publisherTxtBox.Modified = false;
            this.publisherTxtBox.Multiline = false;
            this.publisherTxtBox.Name = "publisherTxtBox";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.publisherTxtBox.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.publisherTxtBox.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.publisherTxtBox.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.publisherTxtBox.OnIdleState = stateProperties12;
            this.publisherTxtBox.Padding = new System.Windows.Forms.Padding(2);
            this.publisherTxtBox.PasswordChar = '\0';
            this.publisherTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.publisherTxtBox.PlaceholderText = "";
            this.publisherTxtBox.ReadOnly = false;
            this.publisherTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.publisherTxtBox.SelectedText = "";
            this.publisherTxtBox.SelectionLength = 0;
            this.publisherTxtBox.SelectionStart = 0;
            this.publisherTxtBox.ShortcutsEnabled = true;
            this.publisherTxtBox.Size = new System.Drawing.Size(299, 36);
            this.publisherTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.publisherTxtBox.TabIndex = 76;
            this.publisherTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.publisherTxtBox.TextMarginBottom = 0;
            this.publisherTxtBox.TextMarginLeft = 3;
            this.publisherTxtBox.TextMarginTop = 0;
            this.publisherTxtBox.TextPlaceholder = "";
            this.publisherTxtBox.UseSystemPasswordChar = false;
            this.publisherTxtBox.WordWrap = true;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.White;
            this.lblPublisher.Location = new System.Drawing.Point(25, 445);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(90, 22);
            this.lblPublisher.TabIndex = 75;
            this.lblPublisher.Text = "Publisher";
            // 
            // CopyrightTxtBox
            // 
            this.CopyrightTxtBox.AcceptsReturn = false;
            this.CopyrightTxtBox.AcceptsTab = false;
            this.CopyrightTxtBox.AnimationSpeed = 200;
            this.CopyrightTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CopyrightTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CopyrightTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightTxtBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CopyrightTxtBox.BackgroundImage")));
            this.CopyrightTxtBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.CopyrightTxtBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CopyrightTxtBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.CopyrightTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.CopyrightTxtBox.BorderRadius = 15;
            this.CopyrightTxtBox.BorderThickness = 2;
            this.CopyrightTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CopyrightTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CopyrightTxtBox.DefaultFont = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyrightTxtBox.DefaultText = "";
            this.CopyrightTxtBox.FillColor = System.Drawing.Color.White;
            this.CopyrightTxtBox.HideSelection = true;
            this.CopyrightTxtBox.IconLeft = null;
            this.CopyrightTxtBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CopyrightTxtBox.IconPadding = 10;
            this.CopyrightTxtBox.IconRight = null;
            this.CopyrightTxtBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CopyrightTxtBox.Lines = new string[0];
            this.CopyrightTxtBox.Location = new System.Drawing.Point(180, 491);
            this.CopyrightTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.CopyrightTxtBox.MaxLength = 32767;
            this.CopyrightTxtBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.CopyrightTxtBox.Modified = false;
            this.CopyrightTxtBox.Multiline = false;
            this.CopyrightTxtBox.Name = "CopyrightTxtBox";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CopyrightTxtBox.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CopyrightTxtBox.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CopyrightTxtBox.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CopyrightTxtBox.OnIdleState = stateProperties16;
            this.CopyrightTxtBox.Padding = new System.Windows.Forms.Padding(2);
            this.CopyrightTxtBox.PasswordChar = '\0';
            this.CopyrightTxtBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CopyrightTxtBox.PlaceholderText = "";
            this.CopyrightTxtBox.ReadOnly = false;
            this.CopyrightTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CopyrightTxtBox.SelectedText = "";
            this.CopyrightTxtBox.SelectionLength = 0;
            this.CopyrightTxtBox.SelectionStart = 0;
            this.CopyrightTxtBox.ShortcutsEnabled = true;
            this.CopyrightTxtBox.Size = new System.Drawing.Size(299, 36);
            this.CopyrightTxtBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CopyrightTxtBox.TabIndex = 78;
            this.CopyrightTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CopyrightTxtBox.TextMarginBottom = 0;
            this.CopyrightTxtBox.TextMarginLeft = 3;
            this.CopyrightTxtBox.TextMarginTop = 0;
            this.CopyrightTxtBox.TextPlaceholder = "";
            this.CopyrightTxtBox.UseSystemPasswordChar = false;
            this.CopyrightTxtBox.WordWrap = true;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(25, 497);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(94, 22);
            this.lblCopyright.TabIndex = 77;
            this.lblCopyright.Text = "Copyright";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(112)))));
            this.cancelBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(112)))));
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(159)))), ((int)(((byte)(112)))));
            this.cancelBtn.BorderRadius = 10;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(34, 557);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(193, 40);
            this.cancelBtn.TabIndex = 80;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextColor = System.Drawing.Color.White;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.addBookBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.addBookBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.addBookBtn.BorderRadius = 10;
            this.addBookBtn.BorderSize = 0;
            this.addBookBtn.FlatAppearance.BorderSize = 0;
            this.addBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBtn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.addBookBtn.ForeColor = System.Drawing.Color.White;
            this.addBookBtn.Location = new System.Drawing.Point(260, 557);
            this.addBookBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(194, 40);
            this.addBookBtn.TabIndex = 79;
            this.addBookBtn.Text = "Add";
            this.addBookBtn.TextColor = System.Drawing.Color.White;
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // roundedPanelGenre
            // 
            this.roundedPanelGenre.BackgroundColor = System.Drawing.Color.White;
            this.roundedPanelGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.roundedPanelGenre.BorderWidth = 2F;
            this.roundedPanelGenre.Controls.Add(this.customComboBoxGenre);
            this.roundedPanelGenre.Location = new System.Drawing.Point(180, 391);
            this.roundedPanelGenre.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanelGenre.Name = "roundedPanelGenre";
            this.roundedPanelGenre.Padding = new System.Windows.Forms.Padding(3);
            this.roundedPanelGenre.Radius = 10;
            this.roundedPanelGenre.Size = new System.Drawing.Size(299, 34);
            this.roundedPanelGenre.TabIndex = 82;
            // 
            // customComboBoxGenre
            // 
            this.customComboBoxGenre.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Teacher"});
            this.customComboBoxGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customComboBoxGenre.BackColor = System.Drawing.Color.White;
            this.customComboBoxGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxGenre.BorderRadius = 10;
            this.customComboBoxGenre.BorderSize = 0;
            this.customComboBoxGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxGenre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxGenre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxGenre.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxGenre.Location = new System.Drawing.Point(3, 3);
            this.customComboBoxGenre.Name = "customComboBoxGenre";
            this.customComboBoxGenre.Size = new System.Drawing.Size(293, 28);
            this.customComboBoxGenre.TabIndex = 6;
            this.customComboBoxGenre.Texts = "";
            // 
            // roundedPanelComboBoxCategory
            // 
            this.roundedPanelComboBoxCategory.BackgroundColor = System.Drawing.Color.White;
            this.roundedPanelComboBoxCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.roundedPanelComboBoxCategory.BorderWidth = 2F;
            this.roundedPanelComboBoxCategory.Controls.Add(this.customComboBoxCategory);
            this.roundedPanelComboBoxCategory.Location = new System.Drawing.Point(180, 340);
            this.roundedPanelComboBoxCategory.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanelComboBoxCategory.Name = "roundedPanelComboBoxCategory";
            this.roundedPanelComboBoxCategory.Padding = new System.Windows.Forms.Padding(3);
            this.roundedPanelComboBoxCategory.Radius = 10;
            this.roundedPanelComboBoxCategory.Size = new System.Drawing.Size(296, 34);
            this.roundedPanelComboBoxCategory.TabIndex = 81;
            // 
            // customComboBoxCategory
            // 
            this.customComboBoxCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "Student",
            "Teacher"});
            this.customComboBoxCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customComboBoxCategory.BackColor = System.Drawing.Color.White;
            this.customComboBoxCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxCategory.BorderRadius = 10;
            this.customComboBoxCategory.BorderSize = 0;
            this.customComboBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxCategory.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxCategory.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxCategory.Location = new System.Drawing.Point(3, 3);
            this.customComboBoxCategory.Name = "customComboBoxCategory";
            this.customComboBoxCategory.Size = new System.Drawing.Size(290, 28);
            this.customComboBoxCategory.TabIndex = 6;
            this.customComboBoxCategory.Texts = "";
            this.customComboBoxCategory.OnSelectedIndexChanged += new System.EventHandler(this.customComboBoxCategory_OnSelectedIndexChanged);
            // 
            // AddBookPopup_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(506, 639);
            this.Controls.Add(this.roundedPanelGenre);
            this.Controls.Add(this.roundedPanelComboBoxCategory);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.CopyrightTxtBox);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.publisherTxtBox);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.ISBNTxtBox);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.bookTitleTxtBox);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblAddBook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBookPopup_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBookPopup_Form";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanelGenre.ResumeLayout(false);
            this.roundedPanelComboBoxCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonClose;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox bookTitleTxtBox;
        private System.Windows.Forms.Label lblBookTitle;
        private Bunifu.UI.WinForms.BunifuTextBox ISBNTxtBox;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label lblGenre;
        private Bunifu.UI.WinForms.BunifuTextBox publisherTxtBox;
        private System.Windows.Forms.Label lblPublisher;
        private Bunifu.UI.WinForms.BunifuTextBox CopyrightTxtBox;
        private System.Windows.Forms.Label lblCopyright;
        private RJCodeAdvance.RJControls.RJButton cancelBtn;
        private RJCodeAdvance.RJControls.RJButton addBookBtn;
        private RoundedPanel roundedPanelComboBoxCategory;
        private CustomComboBox customComboBoxCategory;
        private RoundedPanel roundedPanelGenre;
        private CustomComboBox customComboBoxGenre;
    }
}
namespace BOOKIFY
{
    partial class BooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBooksHeader = new System.Windows.Forms.Panel();
            this.panelBooks = new System.Windows.Forms.Panel();
            this.labelBooks = new System.Windows.Forms.Label();
            this.panelSecondSection = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSecondSection = new System.Windows.Forms.TableLayoutPanel();
            this.panelComboBoxSortGenre = new System.Windows.Forms.Panel();
            this.panelComboBoxSortCategory = new System.Windows.Forms.Panel();
            this.panelAddbtn = new System.Windows.Forms.Panel();
            this.rjButtonBorrow = new RJCodeAdvance.RJControls.RJButton();
            this.panelComboBoxomboBoxFilterStatus = new System.Windows.Forms.Panel();
            this.panelSearchBook = new System.Windows.Forms.Panel();
            this.bunifuTextBoxSearchBook = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panelBookTable = new System.Windows.Forms.Panel();
            this.dataGridViewStudentBorrowerList = new System.Windows.Forms.DataGridView();
            this.roundedPanelomboBoxSortGenre = new BOOKIFY.RoundedPanel();
            this.customComboBoxSortGenre = new BOOKIFY.CustomComboBox();
            this.roundedPanelComboBox = new BOOKIFY.RoundedPanel();
            this.customComboBoxSortCategory = new BOOKIFY.CustomComboBox();
            this.roundedPanelComboBoxFilterStatus = new BOOKIFY.RoundedPanel();
            this.customComboBoxFilterStatus = new BOOKIFY.CustomComboBox();
            this.panelBooksHeader.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.panelSecondSection.SuspendLayout();
            this.tableLayoutPanelSecondSection.SuspendLayout();
            this.panelComboBoxSortGenre.SuspendLayout();
            this.panelComboBoxSortCategory.SuspendLayout();
            this.panelAddbtn.SuspendLayout();
            this.panelComboBoxomboBoxFilterStatus.SuspendLayout();
            this.panelSearchBook.SuspendLayout();
            this.panelBookTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentBorrowerList)).BeginInit();
            this.roundedPanelomboBoxSortGenre.SuspendLayout();
            this.roundedPanelComboBox.SuspendLayout();
            this.roundedPanelComboBoxFilterStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBooksHeader
            // 
            this.panelBooksHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelBooksHeader.Controls.Add(this.panelBooks);
            this.panelBooksHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBooksHeader.ForeColor = System.Drawing.Color.Transparent;
            this.panelBooksHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBooksHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panelBooksHeader.Name = "panelBooksHeader";
            this.panelBooksHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelBooksHeader.Size = new System.Drawing.Size(733, 120);
            this.panelBooksHeader.TabIndex = 1;
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.labelBooks);
            this.panelBooks.Location = new System.Drawing.Point(4, 3);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(371, 109);
            this.panelBooks.TabIndex = 0;
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Font = new System.Drawing.Font("Montserrat Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.labelBooks.Location = new System.Drawing.Point(-1, 27);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(217, 75);
            this.labelBooks.TabIndex = 0;
            this.labelBooks.Text = "Books";
            // 
            // panelSecondSection
            // 
            this.panelSecondSection.Controls.Add(this.tableLayoutPanelSecondSection);
            this.panelSecondSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecondSection.Location = new System.Drawing.Point(0, 120);
            this.panelSecondSection.Margin = new System.Windows.Forms.Padding(0);
            this.panelSecondSection.Name = "panelSecondSection";
            this.panelSecondSection.Padding = new System.Windows.Forms.Padding(10);
            this.panelSecondSection.Size = new System.Drawing.Size(733, 112);
            this.panelSecondSection.TabIndex = 2;
            // 
            // tableLayoutPanelSecondSection
            // 
            this.tableLayoutPanelSecondSection.ColumnCount = 5;
            this.tableLayoutPanelSecondSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSecondSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSecondSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSecondSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSecondSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSecondSection.Controls.Add(this.panelComboBoxSortGenre, 0, 0);
            this.tableLayoutPanelSecondSection.Controls.Add(this.panelComboBoxSortCategory, 0, 0);
            this.tableLayoutPanelSecondSection.Controls.Add(this.panelAddbtn, 2, 0);
            this.tableLayoutPanelSecondSection.Controls.Add(this.panelComboBoxomboBoxFilterStatus, 1, 0);
            this.tableLayoutPanelSecondSection.Controls.Add(this.panelSearchBook, 0, 0);
            this.tableLayoutPanelSecondSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSecondSection.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelSecondSection.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSecondSection.Name = "tableLayoutPanelSecondSection";
            this.tableLayoutPanelSecondSection.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelSecondSection.RowCount = 1;
            this.tableLayoutPanelSecondSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSecondSection.Size = new System.Drawing.Size(713, 92);
            this.tableLayoutPanelSecondSection.TabIndex = 0;
            // 
            // panelComboBoxSortGenre
            // 
            this.panelComboBoxSortGenre.Controls.Add(this.roundedPanelomboBoxSortGenre);
            this.panelComboBoxSortGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComboBoxSortGenre.Location = new System.Drawing.Point(286, 10);
            this.panelComboBoxSortGenre.Margin = new System.Windows.Forms.Padding(0);
            this.panelComboBoxSortGenre.Name = "panelComboBoxSortGenre";
            this.panelComboBoxSortGenre.Padding = new System.Windows.Forms.Padding(10);
            this.panelComboBoxSortGenre.Size = new System.Drawing.Size(138, 72);
            this.panelComboBoxSortGenre.TabIndex = 10;
            // 
            // panelComboBoxSortCategory
            // 
            this.panelComboBoxSortCategory.Controls.Add(this.roundedPanelComboBox);
            this.panelComboBoxSortCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComboBoxSortCategory.Location = new System.Drawing.Point(148, 10);
            this.panelComboBoxSortCategory.Margin = new System.Windows.Forms.Padding(0);
            this.panelComboBoxSortCategory.Name = "panelComboBoxSortCategory";
            this.panelComboBoxSortCategory.Padding = new System.Windows.Forms.Padding(10);
            this.panelComboBoxSortCategory.Size = new System.Drawing.Size(138, 72);
            this.panelComboBoxSortCategory.TabIndex = 9;
            // 
            // panelAddbtn
            // 
            this.panelAddbtn.Controls.Add(this.rjButtonBorrow);
            this.panelAddbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddbtn.Location = new System.Drawing.Point(562, 10);
            this.panelAddbtn.Margin = new System.Windows.Forms.Padding(0);
            this.panelAddbtn.Name = "panelAddbtn";
            this.panelAddbtn.Padding = new System.Windows.Forms.Padding(10);
            this.panelAddbtn.Size = new System.Drawing.Size(141, 72);
            this.panelAddbtn.TabIndex = 8;
            // 
            // rjButtonBorrow
            // 
            this.rjButtonBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjButtonBorrow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rjButtonBorrow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonBorrow.BorderRadius = 5;
            this.rjButtonBorrow.BorderSize = 0;
            this.rjButtonBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButtonBorrow.FlatAppearance.BorderSize = 0;
            this.rjButtonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonBorrow.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButtonBorrow.ForeColor = System.Drawing.Color.White;
            this.rjButtonBorrow.Location = new System.Drawing.Point(10, 10);
            this.rjButtonBorrow.Name = "rjButtonBorrow";
            this.rjButtonBorrow.Size = new System.Drawing.Size(121, 52);
            this.rjButtonBorrow.TabIndex = 1;
            this.rjButtonBorrow.Text = "+ Add Books";
            this.rjButtonBorrow.TextColor = System.Drawing.Color.White;
            this.rjButtonBorrow.UseVisualStyleBackColor = false;
            this.rjButtonBorrow.Click += new System.EventHandler(this.rjButtonBorrow_Click);
            // 
            // panelComboBoxomboBoxFilterStatus
            // 
            this.panelComboBoxomboBoxFilterStatus.Controls.Add(this.roundedPanelComboBoxFilterStatus);
            this.panelComboBoxomboBoxFilterStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComboBoxomboBoxFilterStatus.Location = new System.Drawing.Point(424, 10);
            this.panelComboBoxomboBoxFilterStatus.Margin = new System.Windows.Forms.Padding(0);
            this.panelComboBoxomboBoxFilterStatus.Name = "panelComboBoxomboBoxFilterStatus";
            this.panelComboBoxomboBoxFilterStatus.Padding = new System.Windows.Forms.Padding(10);
            this.panelComboBoxomboBoxFilterStatus.Size = new System.Drawing.Size(138, 72);
            this.panelComboBoxomboBoxFilterStatus.TabIndex = 7;
            // 
            // panelSearchBook
            // 
            this.panelSearchBook.Controls.Add(this.bunifuTextBoxSearchBook);
            this.panelSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchBook.Location = new System.Drawing.Point(10, 10);
            this.panelSearchBook.Margin = new System.Windows.Forms.Padding(0);
            this.panelSearchBook.Name = "panelSearchBook";
            this.panelSearchBook.Padding = new System.Windows.Forms.Padding(10);
            this.panelSearchBook.Size = new System.Drawing.Size(138, 72);
            this.panelSearchBook.TabIndex = 6;
            // 
            // bunifuTextBoxSearchBook
            // 
            this.bunifuTextBoxSearchBook.AcceptsReturn = false;
            this.bunifuTextBoxSearchBook.AcceptsTab = false;
            this.bunifuTextBoxSearchBook.AnimationSpeed = 200;
            this.bunifuTextBoxSearchBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSearchBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSearchBook.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBoxSearchBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSearchBook.BackgroundImage")));
            this.bunifuTextBoxSearchBook.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuTextBoxSearchBook.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBoxSearchBook.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuTextBoxSearchBook.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.bunifuTextBoxSearchBook.BorderRadius = 10;
            this.bunifuTextBoxSearchBook.BorderThickness = 2;
            this.bunifuTextBoxSearchBook.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBoxSearchBook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxSearchBook.DefaultFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBoxSearchBook.DefaultText = "";
            this.bunifuTextBoxSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuTextBoxSearchBook.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSearchBook.HideSelection = true;
            this.bunifuTextBoxSearchBook.IconLeft = null;
            this.bunifuTextBoxSearchBook.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxSearchBook.IconPadding = 10;
            this.bunifuTextBoxSearchBook.IconRight = null;
            this.bunifuTextBoxSearchBook.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxSearchBook.Lines = new string[0];
            this.bunifuTextBoxSearchBook.Location = new System.Drawing.Point(10, 10);
            this.bunifuTextBoxSearchBook.MaxLength = 32767;
            this.bunifuTextBoxSearchBook.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBoxSearchBook.Modified = false;
            this.bunifuTextBoxSearchBook.Multiline = false;
            this.bunifuTextBoxSearchBook.Name = "bunifuTextBoxSearchBook";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxSearchBook.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBoxSearchBook.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxSearchBook.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxSearchBook.OnIdleState = stateProperties4;
            this.bunifuTextBoxSearchBook.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBoxSearchBook.PasswordChar = '\0';
            this.bunifuTextBoxSearchBook.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBoxSearchBook.PlaceholderText = "Search Book";
            this.bunifuTextBoxSearchBook.ReadOnly = false;
            this.bunifuTextBoxSearchBook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBoxSearchBook.SelectedText = "";
            this.bunifuTextBoxSearchBook.SelectionLength = 0;
            this.bunifuTextBoxSearchBook.SelectionStart = 0;
            this.bunifuTextBoxSearchBook.ShortcutsEnabled = true;
            this.bunifuTextBoxSearchBook.Size = new System.Drawing.Size(118, 52);
            this.bunifuTextBoxSearchBook.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBoxSearchBook.TabIndex = 3;
            this.bunifuTextBoxSearchBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSearchBook.TextMarginBottom = 0;
            this.bunifuTextBoxSearchBook.TextMarginLeft = 3;
            this.bunifuTextBoxSearchBook.TextMarginTop = 0;
            this.bunifuTextBoxSearchBook.TextPlaceholder = "Search Book";
            this.bunifuTextBoxSearchBook.UseSystemPasswordChar = false;
            this.bunifuTextBoxSearchBook.WordWrap = true;
            // 
            // panelBookTable
            // 
            this.panelBookTable.Controls.Add(this.dataGridViewStudentBorrowerList);
            this.panelBookTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookTable.Location = new System.Drawing.Point(0, 232);
            this.panelBookTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelBookTable.Name = "panelBookTable";
            this.panelBookTable.Padding = new System.Windows.Forms.Padding(10);
            this.panelBookTable.Size = new System.Drawing.Size(733, 629);
            this.panelBookTable.TabIndex = 3;
            // 
            // dataGridViewStudentBorrowerList
            // 
            this.dataGridViewStudentBorrowerList.AllowUserToAddRows = false;
            this.dataGridViewStudentBorrowerList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentBorrowerList.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentBorrowerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentBorrowerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentBorrowerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.dataGridViewStudentBorrowerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentBorrowerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewStudentBorrowerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(135)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentBorrowerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudentBorrowerList.ColumnHeadersHeight = 60;
            this.dataGridViewStudentBorrowerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentBorrowerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudentBorrowerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudentBorrowerList.EnableHeadersVisualStyles = false;
            this.dataGridViewStudentBorrowerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.dataGridViewStudentBorrowerList.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewStudentBorrowerList.Name = "dataGridViewStudentBorrowerList";
            this.dataGridViewStudentBorrowerList.ReadOnly = true;
            this.dataGridViewStudentBorrowerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentBorrowerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudentBorrowerList.RowHeadersVisible = false;
            this.dataGridViewStudentBorrowerList.RowHeadersWidth = 60;
            this.dataGridViewStudentBorrowerList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewStudentBorrowerList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewStudentBorrowerList.RowTemplate.Height = 40;
            this.dataGridViewStudentBorrowerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentBorrowerList.Size = new System.Drawing.Size(713, 609);
            this.dataGridViewStudentBorrowerList.TabIndex = 12;
            // 
            // roundedPanelomboBoxSortGenre
            // 
            this.roundedPanelomboBoxSortGenre.BackgroundColor = System.Drawing.Color.White;
            this.roundedPanelomboBoxSortGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.roundedPanelomboBoxSortGenre.BorderWidth = 3F;
            this.roundedPanelomboBoxSortGenre.Controls.Add(this.customComboBoxSortGenre);
            this.roundedPanelomboBoxSortGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanelomboBoxSortGenre.Location = new System.Drawing.Point(10, 10);
            this.roundedPanelomboBoxSortGenre.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanelomboBoxSortGenre.Name = "roundedPanelomboBoxSortGenre";
            this.roundedPanelomboBoxSortGenre.Padding = new System.Windows.Forms.Padding(3);
            this.roundedPanelomboBoxSortGenre.Radius = 10;
            this.roundedPanelomboBoxSortGenre.Size = new System.Drawing.Size(118, 52);
            this.roundedPanelomboBoxSortGenre.TabIndex = 3;
            // 
            // customComboBoxSortGenre
            // 
            this.customComboBoxSortGenre.BackColor = System.Drawing.Color.White;
            this.customComboBoxSortGenre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxSortGenre.BorderRadius = 10;
            this.customComboBoxSortGenre.BorderSize = 0;
            this.customComboBoxSortGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customComboBoxSortGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxSortGenre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxSortGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxSortGenre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxSortGenre.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxSortGenre.Location = new System.Drawing.Point(3, 3);
            this.customComboBoxSortGenre.Name = "customComboBoxSortGenre";
            this.customComboBoxSortGenre.Size = new System.Drawing.Size(112, 46);
            this.customComboBoxSortGenre.TabIndex = 6;
            this.customComboBoxSortGenre.Texts = "Genre";
            // 
            // roundedPanelComboBox
            // 
            this.roundedPanelComboBox.BackgroundColor = System.Drawing.Color.White;
            this.roundedPanelComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.roundedPanelComboBox.BorderWidth = 3F;
            this.roundedPanelComboBox.Controls.Add(this.customComboBoxSortCategory);
            this.roundedPanelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanelComboBox.Location = new System.Drawing.Point(10, 10);
            this.roundedPanelComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanelComboBox.Name = "roundedPanelComboBox";
            this.roundedPanelComboBox.Padding = new System.Windows.Forms.Padding(3);
            this.roundedPanelComboBox.Radius = 10;
            this.roundedPanelComboBox.Size = new System.Drawing.Size(118, 52);
            this.roundedPanelComboBox.TabIndex = 2;
            // 
            // customComboBoxSortCategory
            // 
            this.customComboBoxSortCategory.BackColor = System.Drawing.Color.White;
            this.customComboBoxSortCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxSortCategory.BorderRadius = 10;
            this.customComboBoxSortCategory.BorderSize = 0;
            this.customComboBoxSortCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customComboBoxSortCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxSortCategory.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxSortCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxSortCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxSortCategory.Items.AddRange(new object[] {
            "All",
            "Fiction",
            "Non-Fiction",
            "Academic"});
            this.customComboBoxSortCategory.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxSortCategory.Location = new System.Drawing.Point(3, 3);
            this.customComboBoxSortCategory.Name = "customComboBoxSortCategory";
            this.customComboBoxSortCategory.Size = new System.Drawing.Size(112, 46);
            this.customComboBoxSortCategory.TabIndex = 6;
            this.customComboBoxSortCategory.Texts = "Category";
            this.customComboBoxSortCategory.OnSelectedIndexChanged += new System.EventHandler(this.customComboBoxSortCategory_OnSelectedIndexChanged);
            // 
            // roundedPanelComboBoxFilterStatus
            // 
            this.roundedPanelComboBoxFilterStatus.BackgroundColor = System.Drawing.Color.White;
            this.roundedPanelComboBoxFilterStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.roundedPanelComboBoxFilterStatus.BorderWidth = 3F;
            this.roundedPanelComboBoxFilterStatus.Controls.Add(this.customComboBoxFilterStatus);
            this.roundedPanelComboBoxFilterStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanelComboBoxFilterStatus.Location = new System.Drawing.Point(10, 10);
            this.roundedPanelComboBoxFilterStatus.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanelComboBoxFilterStatus.Name = "roundedPanelComboBoxFilterStatus";
            this.roundedPanelComboBoxFilterStatus.Padding = new System.Windows.Forms.Padding(3);
            this.roundedPanelComboBoxFilterStatus.Radius = 10;
            this.roundedPanelComboBoxFilterStatus.Size = new System.Drawing.Size(118, 52);
            this.roundedPanelComboBoxFilterStatus.TabIndex = 2;
            // 
            // customComboBoxFilterStatus
            // 
            this.customComboBoxFilterStatus.BackColor = System.Drawing.Color.White;
            this.customComboBoxFilterStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxFilterStatus.BorderRadius = 10;
            this.customComboBoxFilterStatus.BorderSize = 0;
            this.customComboBoxFilterStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customComboBoxFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBoxFilterStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBoxFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxFilterStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(146)))), ((int)(((byte)(145)))));
            this.customComboBoxFilterStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Reserved",
            "Borrowed"});
            this.customComboBoxFilterStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(70)))), ((int)(((byte)(93)))));
            this.customComboBoxFilterStatus.Location = new System.Drawing.Point(3, 3);
            this.customComboBoxFilterStatus.Name = "customComboBoxFilterStatus";
            this.customComboBoxFilterStatus.Size = new System.Drawing.Size(112, 46);
            this.customComboBoxFilterStatus.TabIndex = 6;
            this.customComboBoxFilterStatus.Texts = "Status";
            this.customComboBoxFilterStatus.OnSelectedIndexChanged += new System.EventHandler(this.customComboBoxFilterStatus_OnSelectedIndexChanged);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(733, 861);
            this.Controls.Add(this.panelBookTable);
            this.Controls.Add(this.panelSecondSection);
            this.Controls.Add(this.panelBooksHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            this.panelBooksHeader.ResumeLayout(false);
            this.panelBooks.ResumeLayout(false);
            this.panelBooks.PerformLayout();
            this.panelSecondSection.ResumeLayout(false);
            this.tableLayoutPanelSecondSection.ResumeLayout(false);
            this.panelComboBoxSortGenre.ResumeLayout(false);
            this.panelComboBoxSortCategory.ResumeLayout(false);
            this.panelAddbtn.ResumeLayout(false);
            this.panelComboBoxomboBoxFilterStatus.ResumeLayout(false);
            this.panelSearchBook.ResumeLayout(false);
            this.panelBookTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentBorrowerList)).EndInit();
            this.roundedPanelomboBoxSortGenre.ResumeLayout(false);
            this.roundedPanelComboBox.ResumeLayout(false);
            this.roundedPanelComboBoxFilterStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBooksHeader;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.Panel panelSecondSection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSecondSection;
        private System.Windows.Forms.Panel panelAddbtn;
        private System.Windows.Forms.Panel panelComboBoxomboBoxFilterStatus;
        private System.Windows.Forms.Panel panelSearchBook;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBoxSearchBook;
        private RJCodeAdvance.RJControls.RJButton rjButtonBorrow;
        private System.Windows.Forms.Panel panelBookTable;
        private System.Windows.Forms.Panel panelComboBoxSortCategory;
        private System.Windows.Forms.DataGridView dataGridViewStudentBorrowerList;
        private RoundedPanel roundedPanelComboBox;
        private CustomComboBox customComboBoxSortCategory;
        private RoundedPanel roundedPanelComboBoxFilterStatus;
        private CustomComboBox customComboBoxFilterStatus;
        private System.Windows.Forms.Panel panelComboBoxSortGenre;
        private RoundedPanel roundedPanelomboBoxSortGenre;
        private CustomComboBox customComboBoxSortGenre;
    }
}
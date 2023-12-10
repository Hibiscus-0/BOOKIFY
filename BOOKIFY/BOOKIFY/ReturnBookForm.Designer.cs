namespace BOOKIFY
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pfpLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.returnDetails = new Bunifu.UI.WinForms.BunifuPanel();
            this.returnPfp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.returnBName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.returnEnterbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.returnBID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblReturnBType = new System.Windows.Forms.Label();
            this.lblReturnBName = new System.Windows.Forms.Label();
            this.returnBType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblReturnBID = new System.Windows.Forms.Label();
            this.panelReturnBook = new System.Windows.Forms.Panel();
            this.labelReturnBook = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelReturnBookHeader = new System.Windows.Forms.Panel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dataGridViewReturnBooks = new System.Windows.Forms.DataGridView();
            this.transacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysOverdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.returnDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnPfp)).BeginInit();
            this.detailsPanel.SuspendLayout();
            this.panelReturnBook.SuspendLayout();
            this.panelReturnBookHeader.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(565, 20);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(563, 83);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Borrower’s Name:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(565, 99);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(447, 83);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Borrower’s ID:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Montserrat", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(565, 175);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(168, 83);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Type:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pfpLabel
            // 
            this.pfpLabel.AllowParentOverrides = false;
            this.pfpLabel.AutoEllipsis = false;
            this.pfpLabel.AutoSize = false;
            this.pfpLabel.BackColor = System.Drawing.Color.LightGray;
            this.pfpLabel.CursorType = null;
            this.pfpLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pfpLabel.Location = new System.Drawing.Point(79, 22);
            this.pfpLabel.Name = "pfpLabel";
            this.pfpLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pfpLabel.Size = new System.Drawing.Size(343, 269);
            this.pfpLabel.TabIndex = 6;
            this.pfpLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pfpLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // returnDetails
            // 
            this.returnDetails.BackgroundColor = System.Drawing.Color.Transparent;
            this.returnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnDetails.BackgroundImage")));
            this.returnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnDetails.BorderColor = System.Drawing.Color.Transparent;
            this.returnDetails.BorderRadius = 3;
            this.returnDetails.BorderThickness = 1;
            this.returnDetails.Controls.Add(this.returnPfp);
            this.returnDetails.Controls.Add(this.detailsPanel);
            this.returnDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.returnDetails.Location = new System.Drawing.Point(0, 113);
            this.returnDetails.Name = "returnDetails";
            this.returnDetails.ShowBorders = true;
            this.returnDetails.Size = new System.Drawing.Size(1794, 303);
            this.returnDetails.TabIndex = 7;
            // 
            // returnPfp
            // 
            this.returnPfp.AllowFocused = false;
            this.returnPfp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnPfp.AutoSizeHeight = true;
            this.returnPfp.BorderRadius = 121;
            this.returnPfp.Image = ((System.Drawing.Image)(resources.GetObject("returnPfp.Image")));
            this.returnPfp.IsCircle = true;
            this.returnPfp.Location = new System.Drawing.Point(261, 31);
            this.returnPfp.Name = "returnPfp";
            this.returnPfp.Size = new System.Drawing.Size(243, 243);
            this.returnPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnPfp.TabIndex = 0;
            this.returnPfp.TabStop = false;
            this.returnPfp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.returnPfp.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.returnBName);
            this.detailsPanel.Controls.Add(this.returnEnterbtn);
            this.detailsPanel.Controls.Add(this.returnBID);
            this.detailsPanel.Controls.Add(this.lblReturnBType);
            this.detailsPanel.Controls.Add(this.lblReturnBName);
            this.detailsPanel.Controls.Add(this.returnBType);
            this.detailsPanel.Controls.Add(this.lblReturnBID);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailsPanel.Location = new System.Drawing.Point(772, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(1022, 303);
            this.detailsPanel.TabIndex = 0;
            // 
            // returnBName
            // 
            this.returnBName.AcceptsReturn = false;
            this.returnBName.AcceptsTab = false;
            this.returnBName.AnimationSpeed = 200;
            this.returnBName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.returnBName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.returnBName.BackColor = System.Drawing.Color.Transparent;
            this.returnBName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBName.BackgroundImage")));
            this.returnBName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnBName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnBName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnBName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.returnBName.BorderRadius = 10;
            this.returnBName.BorderThickness = 3;
            this.returnBName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.returnBName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBName.DefaultFont = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.returnBName.DefaultText = "";
            this.returnBName.FillColor = System.Drawing.Color.White;
            this.returnBName.HideSelection = true;
            this.returnBName.IconLeft = null;
            this.returnBName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBName.IconPadding = 10;
            this.returnBName.IconRight = null;
            this.returnBName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBName.Lines = new string[0];
            this.returnBName.Location = new System.Drawing.Point(550, 97);
            this.returnBName.MaxLength = 32767;
            this.returnBName.MinimumSize = new System.Drawing.Size(1, 1);
            this.returnBName.Modified = false;
            this.returnBName.Multiline = false;
            this.returnBName.Name = "returnBName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.returnBName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.returnBName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.returnBName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.returnBName.OnIdleState = stateProperties4;
            this.returnBName.Padding = new System.Windows.Forms.Padding(3);
            this.returnBName.PasswordChar = '\0';
            this.returnBName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.returnBName.PlaceholderText = "";
            this.returnBName.ReadOnly = false;
            this.returnBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.returnBName.SelectedText = "";
            this.returnBName.SelectionLength = 0;
            this.returnBName.SelectionStart = 0;
            this.returnBName.ShortcutsEnabled = true;
            this.returnBName.Size = new System.Drawing.Size(420, 56);
            this.returnBName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.returnBName.TabIndex = 6;
            this.returnBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.returnBName.TextMarginBottom = 0;
            this.returnBName.TextMarginLeft = 3;
            this.returnBName.TextMarginTop = 0;
            this.returnBName.TextPlaceholder = "";
            this.returnBName.UseSystemPasswordChar = false;
            this.returnBName.WordWrap = true;
            // 
            // returnEnterbtn
            // 
            this.returnEnterbtn.AllowAnimations = true;
            this.returnEnterbtn.AllowMouseEffects = true;
            this.returnEnterbtn.AllowToggling = false;
            this.returnEnterbtn.AnimationSpeed = 200;
            this.returnEnterbtn.AutoGenerateColors = false;
            this.returnEnterbtn.AutoRoundBorders = false;
            this.returnEnterbtn.AutoSizeLeftIcon = true;
            this.returnEnterbtn.AutoSizeRightIcon = true;
            this.returnEnterbtn.BackColor = System.Drawing.Color.Transparent;
            this.returnEnterbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnEnterbtn.BackgroundImage")));
            this.returnEnterbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnEnterbtn.ButtonText = "Enter";
            this.returnEnterbtn.ButtonTextMarginLeft = 0;
            this.returnEnterbtn.ColorContrastOnClick = 45;
            this.returnEnterbtn.ColorContrastOnHover = 45;
            this.returnEnterbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.returnEnterbtn.CustomizableEdges = borderEdges1;
            this.returnEnterbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.returnEnterbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.returnEnterbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnEnterbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.returnEnterbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.returnEnterbtn.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnEnterbtn.ForeColor = System.Drawing.Color.White;
            this.returnEnterbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnEnterbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.returnEnterbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.returnEnterbtn.IconMarginLeft = 11;
            this.returnEnterbtn.IconPadding = 10;
            this.returnEnterbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnEnterbtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.returnEnterbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.returnEnterbtn.IconSize = 25;
            this.returnEnterbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.IdleBorderRadius = 15;
            this.returnEnterbtn.IdleBorderThickness = 3;
            this.returnEnterbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.IdleIconLeftImage = null;
            this.returnEnterbtn.IdleIconRightImage = null;
            this.returnEnterbtn.IndicateFocus = false;
            this.returnEnterbtn.Location = new System.Drawing.Point(707, 242);
            this.returnEnterbtn.Name = "returnEnterbtn";
            this.returnEnterbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.returnEnterbtn.OnDisabledState.BorderRadius = 15;
            this.returnEnterbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnEnterbtn.OnDisabledState.BorderThickness = 3;
            this.returnEnterbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnEnterbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.returnEnterbtn.OnDisabledState.IconLeftImage = null;
            this.returnEnterbtn.OnDisabledState.IconRightImage = null;
            this.returnEnterbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnEnterbtn.onHoverState.BorderRadius = 15;
            this.returnEnterbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnEnterbtn.onHoverState.BorderThickness = 3;
            this.returnEnterbtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnEnterbtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.returnEnterbtn.onHoverState.IconLeftImage = null;
            this.returnEnterbtn.onHoverState.IconRightImage = null;
            this.returnEnterbtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.OnIdleState.BorderRadius = 15;
            this.returnEnterbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnEnterbtn.OnIdleState.BorderThickness = 3;
            this.returnEnterbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.returnEnterbtn.OnIdleState.IconLeftImage = null;
            this.returnEnterbtn.OnIdleState.IconRightImage = null;
            this.returnEnterbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.OnPressedState.BorderRadius = 15;
            this.returnEnterbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.returnEnterbtn.OnPressedState.BorderThickness = 3;
            this.returnEnterbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(146)))));
            this.returnEnterbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.returnEnterbtn.OnPressedState.IconLeftImage = null;
            this.returnEnterbtn.OnPressedState.IconRightImage = null;
            this.returnEnterbtn.Size = new System.Drawing.Size(206, 47);
            this.returnEnterbtn.TabIndex = 3;
            this.returnEnterbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnEnterbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.returnEnterbtn.TextMarginLeft = 0;
            this.returnEnterbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.returnEnterbtn.UseDefaultRadiusAndThickness = true;
            // 
            // returnBID
            // 
            this.returnBID.AcceptsReturn = false;
            this.returnBID.AcceptsTab = false;
            this.returnBID.AnimationSpeed = 200;
            this.returnBID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.returnBID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.returnBID.BackColor = System.Drawing.Color.Transparent;
            this.returnBID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBID.BackgroundImage")));
            this.returnBID.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnBID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnBID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnBID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.returnBID.BorderRadius = 10;
            this.returnBID.BorderThickness = 3;
            this.returnBID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.returnBID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBID.DefaultFont = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.returnBID.DefaultText = "";
            this.returnBID.FillColor = System.Drawing.Color.White;
            this.returnBID.HideSelection = true;
            this.returnBID.IconLeft = null;
            this.returnBID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBID.IconPadding = 10;
            this.returnBID.IconRight = null;
            this.returnBID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.returnBID.Lines = new string[0];
            this.returnBID.Location = new System.Drawing.Point(550, 21);
            this.returnBID.MaxLength = 32767;
            this.returnBID.MinimumSize = new System.Drawing.Size(1, 1);
            this.returnBID.Modified = false;
            this.returnBID.Multiline = false;
            this.returnBID.Name = "returnBID";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.returnBID.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.returnBID.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.returnBID.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.returnBID.OnIdleState = stateProperties8;
            this.returnBID.Padding = new System.Windows.Forms.Padding(3);
            this.returnBID.PasswordChar = '\0';
            this.returnBID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.returnBID.PlaceholderText = "";
            this.returnBID.ReadOnly = false;
            this.returnBID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.returnBID.SelectedText = "";
            this.returnBID.SelectionLength = 0;
            this.returnBID.SelectionStart = 0;
            this.returnBID.ShortcutsEnabled = true;
            this.returnBID.Size = new System.Drawing.Size(420, 56);
            this.returnBID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.returnBID.TabIndex = 5;
            this.returnBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.returnBID.TextMarginBottom = 0;
            this.returnBID.TextMarginLeft = 3;
            this.returnBID.TextMarginTop = 0;
            this.returnBID.TextPlaceholder = "";
            this.returnBID.UseSystemPasswordChar = false;
            this.returnBID.WordWrap = true;
            this.returnBID.TextChanged += new System.EventHandler(this.IDTxtbox_TextChanged);
            // 
            // lblReturnBType
            // 
            this.lblReturnBType.AutoSize = true;
            this.lblReturnBType.Font = new System.Drawing.Font("Montserrat Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.lblReturnBType.Location = new System.Drawing.Point(25, 153);
            this.lblReturnBType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReturnBType.Name = "lblReturnBType";
            this.lblReturnBType.Size = new System.Drawing.Size(448, 69);
            this.lblReturnBType.TabIndex = 3;
            this.lblReturnBType.Text = "Borrower Type:";
            this.lblReturnBType.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblReturnBName
            // 
            this.lblReturnBName.AutoSize = true;
            this.lblReturnBName.Font = new System.Drawing.Font("Montserrat Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.lblReturnBName.Location = new System.Drawing.Point(25, 84);
            this.lblReturnBName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReturnBName.Name = "lblReturnBName";
            this.lblReturnBName.Size = new System.Drawing.Size(516, 69);
            this.lblReturnBName.TabIndex = 1;
            this.lblReturnBName.Text = "Borrower\'s Name:";
            this.lblReturnBName.Click += new System.EventHandler(this.label1_Click);
            // 
            // returnBType
            // 
            this.returnBType.BackColor = System.Drawing.Color.Transparent;
            this.returnBType.BackgroundColor = System.Drawing.Color.White;
            this.returnBType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.returnBType.BorderRadius = 5;
            this.returnBType.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.returnBType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.returnBType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.returnBType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.returnBType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.returnBType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.returnBType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.returnBType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.returnBType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.returnBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.returnBType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.returnBType.FillDropDown = true;
            this.returnBType.FillIndicator = false;
            this.returnBType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBType.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold);
            this.returnBType.ForeColor = System.Drawing.Color.Black;
            this.returnBType.FormattingEnabled = true;
            this.returnBType.Icon = null;
            this.returnBType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.returnBType.IndicatorColor = System.Drawing.Color.Gray;
            this.returnBType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.returnBType.ItemBackColor = System.Drawing.Color.White;
            this.returnBType.ItemBorderColor = System.Drawing.Color.White;
            this.returnBType.ItemForeColor = System.Drawing.Color.Black;
            this.returnBType.ItemHeight = 40;
            this.returnBType.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(245)))), ((int)(((byte)(198)))));
            this.returnBType.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.returnBType.Items.AddRange(new object[] {
            "---",
            "Teacher",
            "Student"});
            this.returnBType.ItemTopMargin = 3;
            this.returnBType.Location = new System.Drawing.Point(550, 176);
            this.returnBType.Name = "returnBType";
            this.returnBType.Size = new System.Drawing.Size(219, 46);
            this.returnBType.TabIndex = 3;
            this.returnBType.Text = null;
            this.returnBType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.returnBType.TextLeftMargin = 5;
            // 
            // lblReturnBID
            // 
            this.lblReturnBID.AutoSize = true;
            this.lblReturnBID.Font = new System.Drawing.Font("Montserrat Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.lblReturnBID.Location = new System.Drawing.Point(25, 15);
            this.lblReturnBID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReturnBID.Name = "lblReturnBID";
            this.lblReturnBID.Size = new System.Drawing.Size(417, 69);
            this.lblReturnBID.TabIndex = 2;
            this.lblReturnBID.Text = "Borrower\'s ID:";
            // 
            // panelReturnBook
            // 
            this.panelReturnBook.Controls.Add(this.labelReturnBook);
            this.panelReturnBook.Location = new System.Drawing.Point(8, 5);
            this.panelReturnBook.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panelReturnBook.Name = "panelReturnBook";
            this.panelReturnBook.Size = new System.Drawing.Size(585, 106);
            this.panelReturnBook.TabIndex = 0;
            // 
            // labelReturnBook
            // 
            this.labelReturnBook.AutoSize = true;
            this.labelReturnBook.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(73)))), ((int)(((byte)(72)))));
            this.labelReturnBook.Location = new System.Drawing.Point(16, 4);
            this.labelReturnBook.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReturnBook.Name = "labelReturnBook";
            this.labelReturnBook.Size = new System.Drawing.Size(537, 99);
            this.labelReturnBook.TabIndex = 0;
            this.labelReturnBook.Text = "Return Book";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 111);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1794, 328);
            this.bunifuPanel1.TabIndex = 7;
            // 
            // panelReturnBookHeader
            // 
            this.panelReturnBookHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelReturnBookHeader.Controls.Add(this.bunifuPanel1);
            this.panelReturnBookHeader.Controls.Add(this.panelReturnBook);
            this.panelReturnBookHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReturnBookHeader.ForeColor = System.Drawing.Color.Transparent;
            this.panelReturnBookHeader.Location = new System.Drawing.Point(0, 0);
            this.panelReturnBookHeader.Margin = new System.Windows.Forms.Padding(6, 5, 6, 18);
            this.panelReturnBookHeader.MinimumSize = new System.Drawing.Size(280, 0);
            this.panelReturnBookHeader.Name = "panelReturnBookHeader";
            this.panelReturnBookHeader.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.panelReturnBookHeader.Size = new System.Drawing.Size(1794, 113);
            this.panelReturnBookHeader.TabIndex = 2;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.dataGridViewReturnBooks);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 416);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1794, 690);
            this.bunifuPanel2.TabIndex = 8;
            // 
            // dataGridViewReturnBooks
            // 
            this.dataGridViewReturnBooks.AllowUserToDeleteRows = false;
            this.dataGridViewReturnBooks.AllowUserToOrderColumns = true;
            this.dataGridViewReturnBooks.AllowUserToResizeColumns = false;
            this.dataGridViewReturnBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReturnBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReturnBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReturnBooks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewReturnBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReturnBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(167)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(203)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReturnBooks.ColumnHeadersHeight = 70;
            this.dataGridViewReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewReturnBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transacID,
            this.TransactionID,
            this.Member,
            this.IssuedBookTitle,
            this.DaysOverdue,
            this.payButton});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReturnBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReturnBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReturnBooks.EnableHeadersVisualStyles = false;
            this.dataGridViewReturnBooks.GridColor = System.Drawing.Color.Black;
            this.dataGridViewReturnBooks.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewReturnBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReturnBooks.Name = "dataGridViewReturnBooks";
            this.dataGridViewReturnBooks.ReadOnly = true;
            this.dataGridViewReturnBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewReturnBooks.RowHeadersVisible = false;
            this.dataGridViewReturnBooks.RowHeadersWidth = 90;
            this.dataGridViewReturnBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(159)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBooks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewReturnBooks.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReturnBooks.RowTemplate.Height = 50;
            this.dataGridViewReturnBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReturnBooks.Size = new System.Drawing.Size(1774, 670);
            this.dataGridViewReturnBooks.TabIndex = 6;
            // 
            // transacID
            // 
            this.transacID.HeaderText = "Transaction ID";
            this.transacID.MinimumWidth = 60;
            this.transacID.Name = "transacID";
            this.transacID.ReadOnly = true;
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "Book Title";
            this.TransactionID.MinimumWidth = 60;
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            // 
            // Member
            // 
            this.Member.HeaderText = "Date Borrowed";
            this.Member.MinimumWidth = 60;
            this.Member.Name = "Member";
            this.Member.ReadOnly = true;
            // 
            // IssuedBookTitle
            // 
            this.IssuedBookTitle.HeaderText = "Due Date";
            this.IssuedBookTitle.MinimumWidth = 60;
            this.IssuedBookTitle.Name = "IssuedBookTitle";
            this.IssuedBookTitle.ReadOnly = true;
            // 
            // DaysOverdue
            // 
            this.DaysOverdue.HeaderText = "Return Date";
            this.DaysOverdue.MinimumWidth = 60;
            this.DaysOverdue.Name = "DaysOverdue";
            this.DaysOverdue.ReadOnly = true;
            // 
            // payButton
            // 
            this.payButton.HeaderText = "Pay Penalty";
            this.payButton.MinimumWidth = 60;
            this.payButton.Name = "payButton";
            this.payButton.ReadOnly = true;
            this.payButton.Text = "Pay Penalty";
            this.payButton.UseColumnTextForButtonValue = true;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(228)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1794, 1106);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.returnDetails);
            this.Controls.Add(this.panelReturnBookHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.returnDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnPfp)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.panelReturnBook.ResumeLayout(false);
            this.panelReturnBook.PerformLayout();
            this.panelReturnBookHeader.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel pfpLabel;
        private Bunifu.UI.WinForms.BunifuPanel returnDetails;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton returnEnterbtn;
        private Bunifu.UI.WinForms.BunifuDropdown returnBType;
        private Bunifu.UI.WinForms.BunifuTextBox returnBID;
        private Bunifu.UI.WinForms.BunifuPictureBox returnPfp;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label lblReturnBType;
        private System.Windows.Forms.Label lblReturnBName;
        private System.Windows.Forms.Label lblReturnBID;
        private Bunifu.UI.WinForms.BunifuTextBox returnBName;
        private System.Windows.Forms.Panel panelReturnBook;
        private System.Windows.Forms.Label labelReturnBook;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel panelReturnBookHeader;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.DataGridView dataGridViewReturnBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn transacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysOverdue;
        private System.Windows.Forms.DataGridViewButtonColumn payButton;
    }
}
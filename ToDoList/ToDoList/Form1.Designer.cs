namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.themeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.musicComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.musicTest = new MaterialSkin.Controls.MaterialButton();
            this.musicSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.tabToDoList = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.listTextAdd = new MaterialSkin.Controls.MaterialButton();
            this.listText = new MaterialSkin.Controls.MaterialTextBox2();
            this.listView = new MaterialSkin.Controls.MaterialListView();
            this.Task = new System.Windows.Forms.ColumnHeader();
            this.Yes = new System.Windows.Forms.ColumnHeader();
            this.No = new System.Windows.Forms.ColumnHeader();
            this.tabTimer = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.labelTime = new MaterialSkin.Controls.MaterialLabel();
            this.removeButton = new MaterialSkin.Controls.MaterialButton();
            this.textBoxAdd = new MaterialSkin.Controls.MaterialTextBox();
            this.startButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.timeDataGridView = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPages = new MaterialSkin.Controls.MaterialTabControl();
            this.tabSetting.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabToDoList.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).BeginInit();
            this.tabPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.materialCard3);
            this.tabSetting.Controls.Add(this.materialCard4);
            this.tabSetting.Controls.Add(this.materialLabel3);
            this.tabSetting.Controls.Add(this.materialLabel1);
            this.tabSetting.Controls.Add(this.materialCard2);
            this.tabSetting.ImageKey = "icons8-setting-48.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 24);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(583, 445);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Settings";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(73, 333);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(490, 134);
            this.materialCard3.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel2.ForeColor = System.Drawing.Color.Red;
            this.materialLabel2.Location = new System.Drawing.Point(17, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(448, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Made by Chingiz Agha";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.themeSwitch);
            this.materialCard4.Controls.Add(this.materialRadioButton6);
            this.materialCard4.Controls.Add(this.materialRadioButton5);
            this.materialCard4.Controls.Add(this.materialRadioButton4);
            this.materialCard4.Controls.Add(this.materialRadioButton3);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(358, 56);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(205, 249);
            this.materialCard4.TabIndex = 5;
            // 
            // themeSwitch
            // 
            this.themeSwitch.AutoSize = true;
            this.themeSwitch.Depth = 0;
            this.themeSwitch.Location = new System.Drawing.Point(14, 192);
            this.themeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.themeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.themeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.themeSwitch.Name = "themeSwitch";
            this.themeSwitch.Ripple = true;
            this.themeSwitch.Size = new System.Drawing.Size(107, 37);
            this.themeSwitch.TabIndex = 4;
            this.themeSwitch.Text = "Theme";
            this.themeSwitch.UseVisualStyleBackColor = true;
            this.themeSwitch.CheckedChanged += new System.EventHandler(this.themeSwitch_CheckedChanged);
            // 
            // materialRadioButton6
            // 
            this.materialRadioButton6.AutoSize = true;
            this.materialRadioButton6.Depth = 0;
            this.materialRadioButton6.Location = new System.Drawing.Point(14, 125);
            this.materialRadioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton6.Name = "materialRadioButton6";
            this.materialRadioButton6.Ripple = true;
            this.materialRadioButton6.Size = new System.Drawing.Size(80, 37);
            this.materialRadioButton6.TabIndex = 3;
            this.materialRadioButton6.TabStop = true;
            this.materialRadioButton6.Text = "Purple";
            this.materialRadioButton6.UseVisualStyleBackColor = true;
            this.materialRadioButton6.CheckedChanged += new System.EventHandler(this.materialRadioButton6_CheckedChanged);
            // 
            // materialRadioButton5
            // 
            this.materialRadioButton5.AutoSize = true;
            this.materialRadioButton5.Depth = 0;
            this.materialRadioButton5.Location = new System.Drawing.Point(14, 88);
            this.materialRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton5.Name = "materialRadioButton5";
            this.materialRadioButton5.Ripple = true;
            this.materialRadioButton5.Size = new System.Drawing.Size(86, 37);
            this.materialRadioButton5.TabIndex = 2;
            this.materialRadioButton5.TabStop = true;
            this.materialRadioButton5.Text = "Orange";
            this.materialRadioButton5.UseVisualStyleBackColor = true;
            this.materialRadioButton5.CheckedChanged += new System.EventHandler(this.materialRadioButton5_CheckedChanged);
            // 
            // materialRadioButton4
            // 
            this.materialRadioButton4.AutoSize = true;
            this.materialRadioButton4.Depth = 0;
            this.materialRadioButton4.Location = new System.Drawing.Point(14, 51);
            this.materialRadioButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton4.Name = "materialRadioButton4";
            this.materialRadioButton4.Ripple = true;
            this.materialRadioButton4.Size = new System.Drawing.Size(76, 37);
            this.materialRadioButton4.TabIndex = 1;
            this.materialRadioButton4.TabStop = true;
            this.materialRadioButton4.Text = "Green";
            this.materialRadioButton4.UseVisualStyleBackColor = true;
            this.materialRadioButton4.CheckedChanged += new System.EventHandler(this.materialRadioButton4_CheckedChanged);
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Checked = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Location = new System.Drawing.Point(14, 14);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(66, 37);
            this.materialRadioButton3.TabIndex = 0;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Blue";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(358, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Color";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(73, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Alarm";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.musicComboBox);
            this.materialCard2.Controls.Add(this.musicTest);
            this.materialCard2.Controls.Add(this.musicSwitch);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(73, 57);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(241, 248);
            this.materialCard2.TabIndex = 0;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 23);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Alarm Sound";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 78);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Alarm Type";
            // 
            // musicComboBox
            // 
            this.musicComboBox.AutoResize = false;
            this.musicComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.musicComboBox.Depth = 0;
            this.musicComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.musicComboBox.DropDownHeight = 174;
            this.musicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musicComboBox.DropDownWidth = 121;
            this.musicComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.musicComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.musicComboBox.FormattingEnabled = true;
            this.musicComboBox.IntegralHeight = false;
            this.musicComboBox.ItemHeight = 43;
            this.musicComboBox.Location = new System.Drawing.Point(17, 112);
            this.musicComboBox.MaxDropDownItems = 4;
            this.musicComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.musicComboBox.Name = "musicComboBox";
            this.musicComboBox.Size = new System.Drawing.Size(207, 49);
            this.musicComboBox.StartIndex = 0;
            this.musicComboBox.TabIndex = 5;
            // 
            // musicTest
            // 
            this.musicTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.musicTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.musicTest.Depth = 0;
            this.musicTest.HighEmphasis = true;
            this.musicTest.Icon = null;
            this.musicTest.Location = new System.Drawing.Point(17, 192);
            this.musicTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.musicTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.musicTest.Name = "musicTest";
            this.musicTest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.musicTest.Size = new System.Drawing.Size(64, 36);
            this.musicTest.TabIndex = 4;
            this.musicTest.Text = "Test";
            this.musicTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.musicTest.UseAccentColor = false;
            this.musicTest.UseVisualStyleBackColor = true;
            this.musicTest.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // musicSwitch
            // 
            this.musicSwitch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musicSwitch.Depth = 0;
            this.musicSwitch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musicSwitch.Location = new System.Drawing.Point(142, 6);
            this.musicSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.musicSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.musicSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.musicSwitch.Name = "musicSwitch";
            this.musicSwitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musicSwitch.Ripple = true;
            this.musicSwitch.Size = new System.Drawing.Size(82, 50);
            this.musicSwitch.TabIndex = 2;
            this.musicSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musicSwitch.UseVisualStyleBackColor = true;
            // 
            // tabToDoList
            // 
            this.tabToDoList.Controls.Add(this.materialCard5);
            this.tabToDoList.ImageKey = "icons8-list-50.png";
            this.tabToDoList.Location = new System.Drawing.Point(4, 24);
            this.tabToDoList.Name = "tabToDoList";
            this.tabToDoList.Padding = new System.Windows.Forms.Padding(3);
            this.tabToDoList.Size = new System.Drawing.Size(583, 445);
            this.tabToDoList.TabIndex = 1;
            this.tabToDoList.Text = "ToDoList";
            this.tabToDoList.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.listTextAdd);
            this.materialCard5.Controls.Add(this.listText);
            this.materialCard5.Controls.Add(this.listView);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(70, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(510, 450);
            this.materialCard5.TabIndex = 8;
            // 
            // listTextAdd
            // 
            this.listTextAdd.AutoSize = false;
            this.listTextAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listTextAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.listTextAdd.Depth = 0;
            this.listTextAdd.HighEmphasis = true;
            this.listTextAdd.Icon = null;
            this.listTextAdd.Location = new System.Drawing.Point(418, 88);
            this.listTextAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listTextAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.listTextAdd.Name = "listTextAdd";
            this.listTextAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.listTextAdd.Size = new System.Drawing.Size(75, 36);
            this.listTextAdd.TabIndex = 2;
            this.listTextAdd.Text = "Add";
            this.listTextAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.listTextAdd.UseAccentColor = false;
            this.listTextAdd.UseVisualStyleBackColor = true;
            this.listTextAdd.Click += new System.EventHandler(this.listTextAdd_Click);
            // 
            // listText
            // 
            this.listText.AnimateReadOnly = false;
            this.listText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.listText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.listText.Depth = 0;
            this.listText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listText.HideSelection = true;
            this.listText.LeadingIcon = null;
            this.listText.Location = new System.Drawing.Point(17, 31);
            this.listText.MaxLength = 32767;
            this.listText.MouseState = MaterialSkin.MouseState.OUT;
            this.listText.Name = "listText";
            this.listText.PasswordChar = '\0';
            this.listText.PrefixSuffixText = null;
            this.listText.ReadOnly = false;
            this.listText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listText.SelectedText = "";
            this.listText.SelectionLength = 0;
            this.listText.SelectionStart = 0;
            this.listText.ShortcutsEnabled = true;
            this.listText.Size = new System.Drawing.Size(476, 48);
            this.listText.TabIndex = 1;
            this.listText.TabStop = false;
            this.listText.Text = "Add text";
            this.listText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.listText.TrailingIcon = null;
            this.listText.UseSystemPasswordChar = false;
            // 
            // listView
            // 
            this.listView.AutoSizeTable = false;
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Task,
            this.Yes,
            this.No});
            this.listView.Depth = 0;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(17, 175);
            this.listView.MinimumSize = new System.Drawing.Size(200, 100);
            this.listView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listView.MouseState = MaterialSkin.MouseState.OUT;
            this.listView.Name = "listView";
            this.listView.OwnerDraw = true;
            this.listView.Size = new System.Drawing.Size(476, 282);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Task
            // 
            this.Task.Text = "Task";
            this.Task.Width = 300;
            // 
            // Yes
            // 
            this.Yes.Text = "Yes";
            // 
            // No
            // 
            this.No.Text = "No";
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.materialCard1);
            this.tabTimer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabTimer.ImageKey = "icons8-timer-80.png";
            this.tabTimer.Location = new System.Drawing.Point(4, 24);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(583, 445);
            this.tabTimer.TabIndex = 0;
            this.tabTimer.Text = "Timer";
            this.tabTimer.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.labelTime);
            this.materialCard1.Controls.Add(this.removeButton);
            this.materialCard1.Controls.Add(this.textBoxAdd);
            this.materialCard1.Controls.Add(this.startButton);
            this.materialCard1.Controls.Add(this.addButton);
            this.materialCard1.Controls.Add(this.timeDataGridView);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(70, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(510, 450);
            this.materialCard1.TabIndex = 7;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Depth = 0;
            this.labelTime.Font = new System.Drawing.Font("Roboto Light", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTime.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            this.labelTime.Location = new System.Drawing.Point(90, 14);
            this.labelTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(359, 115);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeButton
            // 
            this.removeButton.AutoSize = false;
            this.removeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.removeButton.Depth = 0;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.HighEmphasis = true;
            this.removeButton.Icon = null;
            this.removeButton.Location = new System.Drawing.Point(418, 225);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.removeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeButton.Name = "removeButton";
            this.removeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.removeButton.Size = new System.Drawing.Size(75, 36);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Reset";
            this.removeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.removeButton.UseAccentColor = false;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.AnimateReadOnly = false;
            this.textBoxAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAdd.Depth = 0;
            this.textBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAdd.ForeColor = System.Drawing.Color.Silver;
            this.textBoxAdd.LeadingIcon = null;
            this.textBoxAdd.Location = new System.Drawing.Point(17, 225);
            this.textBoxAdd.MaxLength = 50;
            this.textBoxAdd.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxAdd.Multiline = false;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(137, 36);
            this.textBoxAdd.TabIndex = 4;
            this.textBoxAdd.Text = "60";
            this.textBoxAdd.TrailingIcon = null;
            this.textBoxAdd.UseTallSize = false;
            this.textBoxAdd.Enter += new System.EventHandler(this.textBoxAdd_Enter);
            this.textBoxAdd.Leave += new System.EventHandler(this.textBoxAdd_Leave);
            // 
            // startButton
            // 
            this.startButton.AutoSize = false;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startButton.Depth = 0;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.HighEmphasis = true;
            this.startButton.Icon = null;
            this.startButton.Location = new System.Drawing.Point(326, 225);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startButton.Name = "startButton";
            this.startButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startButton.Size = new System.Drawing.Size(75, 36);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startButton.UseAccentColor = false;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addButton.Depth = 0;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(177, 225);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addButton.Size = new System.Drawing.Size(75, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // timeDataGridView
            // 
            this.timeDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.timeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Remove});
            this.timeDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeDataGridView.Location = new System.Drawing.Point(17, 286);
            this.timeDataGridView.Name = "timeDataGridView";
            this.timeDataGridView.RowTemplate.Height = 25;
            this.timeDataGridView.Size = new System.Drawing.Size(476, 150);
            this.timeDataGridView.TabIndex = 3;
            this.timeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timeDataGridView_CellClick);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabTimer);
            this.tabPages.Controls.Add(this.tabToDoList);
            this.tabPages.Controls.Add(this.tabSetting);
            this.tabPages.Depth = 0;
            this.tabPages.Location = new System.Drawing.Point(3, 83);
            this.tabPages.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabPages.Multiline = true;
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(591, 473);
            this.tabPages.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.tabPages);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabPages;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabToDoList.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.tabTimer.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabSetting;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialSwitch themeSwitch;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton6;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox musicComboBox;
        private MaterialSkin.Controls.MaterialButton musicTest;
        private MaterialSkin.Controls.MaterialSwitch musicSwitch;
        private System.Windows.Forms.TabPage tabToDoList;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialButton listTextAdd;
        private MaterialSkin.Controls.MaterialTextBox2 listText;
        private MaterialSkin.Controls.MaterialListView listView;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader Yes;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.TabPage tabTimer;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel labelTime;
        private MaterialSkin.Controls.MaterialButton removeButton;
        private MaterialSkin.Controls.MaterialTextBox textBoxAdd;
        private MaterialSkin.Controls.MaterialButton startButton;
        private MaterialSkin.Controls.MaterialButton addButton;
        private System.Windows.Forms.DataGridView timeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private MaterialSkin.Controls.MaterialTabControl tabPages;
    }
}

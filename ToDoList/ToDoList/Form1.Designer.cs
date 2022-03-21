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
            this.tabPages = new MaterialSkin.Controls.MaterialTabControl();
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
            this.tabToDoList = new System.Windows.Forms.TabPage();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPages.SuspendLayout();
            this.tabTimer.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).BeginInit();
            this.tabSetting.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabTimer);
            this.tabPages.Controls.Add(this.tabToDoList);
            this.tabPages.Controls.Add(this.tabSetting);
            this.tabPages.Depth = 0;
            this.tabPages.ImageList = this.imageList1;
            this.tabPages.Location = new System.Drawing.Point(6, 67);
            this.tabPages.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabPages.Multiline = true;
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(588, 527);
            this.tabPages.TabIndex = 0;
            // 
            // tabTimer
            // 
            this.tabTimer.Controls.Add(this.materialCard1);
            this.tabTimer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabTimer.ImageKey = "icons8-timer-80.png";
            this.tabTimer.Location = new System.Drawing.Point(4, 39);
            this.tabTimer.Name = "tabTimer";
            this.tabTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimer.Size = new System.Drawing.Size(580, 484);
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
            this.materialCard1.Size = new System.Drawing.Size(510, 453);
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
            this.textBoxAdd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxAdd.LeadingIcon = null;
            this.textBoxAdd.Location = new System.Drawing.Point(17, 211);
            this.textBoxAdd.MaxLength = 50;
            this.textBoxAdd.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxAdd.Multiline = false;
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(116, 50);
            this.textBoxAdd.TabIndex = 4;
            this.textBoxAdd.Text = "";
            this.textBoxAdd.TrailingIcon = null;
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
            this.addButton.Location = new System.Drawing.Point(164, 225);
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
            this.timeDataGridView.BackgroundColor = System.Drawing.Color.DarkTurquoise;
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
            // tabToDoList
            // 
            this.tabToDoList.ImageKey = "icons8-list-50.png";
            this.tabToDoList.Location = new System.Drawing.Point(4, 39);
            this.tabToDoList.Name = "tabToDoList";
            this.tabToDoList.Padding = new System.Windows.Forms.Padding(3);
            this.tabToDoList.Size = new System.Drawing.Size(580, 484);
            this.tabToDoList.TabIndex = 1;
            this.tabToDoList.Text = "ToDoList";
            this.tabToDoList.UseVisualStyleBackColor = true;
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.materialCard4);
            this.tabSetting.Controls.Add(this.materialLabel3);
            this.tabSetting.Controls.Add(this.materialCard3);
            this.tabSetting.Controls.Add(this.materialLabel2);
            this.tabSetting.Controls.Add(this.materialLabel1);
            this.tabSetting.Controls.Add(this.materialCard2);
            this.tabSetting.ImageKey = "icons8-setting-48.png";
            this.tabSetting.Location = new System.Drawing.Point(4, 39);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(580, 484);
            this.tabSetting.TabIndex = 2;
            this.tabSetting.Text = "Settings";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialRadioButton6);
            this.materialCard4.Controls.Add(this.materialRadioButton5);
            this.materialCard4.Controls.Add(this.materialRadioButton4);
            this.materialCard4.Controls.Add(this.materialRadioButton3);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(374, 56);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(189, 191);
            this.materialCard4.TabIndex = 5;
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
            this.materialLabel3.Location = new System.Drawing.Point(374, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Color";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialRadioButton2);
            this.materialCard3.Controls.Add(this.materialRadioButton1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(73, 327);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(273, 105);
            this.materialCard3.TabIndex = 3;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Checked = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(14, 51);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(71, 37);
            this.materialRadioButton2.TabIndex = 1;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Light";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(14, 14);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(68, 37);
            this.materialRadioButton1.TabIndex = 0;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Dark";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(73, 284);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 29);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Theme";
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
            this.materialCard2.Controls.Add(this.materialSlider1);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.materialSwitch1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(73, 57);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(273, 190);
            this.materialCard2.TabIndex = 0;
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(18, 76);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.Size = new System.Drawing.Size(235, 40);
            this.materialSlider1.TabIndex = 5;
            this.materialSlider1.Text = "Alarm volume";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(18, 134);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Test";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialSwitch1.Location = new System.Drawing.Point(14, 14);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(200, 50);
            this.materialSwitch1.TabIndex = 2;
            this.materialSwitch1.Text = "     Alarm Sound";
            this.materialSwitch1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-timer-80.png");
            this.imageList1.Images.SetKeyName(1, "icons8-list-50.png");
            this.imageList1.Images.SetKeyName(2, "icons8-setting-48.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.tabPages);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabPages;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabPages.ResumeLayout(false);
            this.tabTimer.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).EndInit();
            this.tabSetting.ResumeLayout(false);
            this.tabSetting.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabPages;
        private System.Windows.Forms.TabPage tabTimer;
        private System.Windows.Forms.TabPage tabToDoList;
        private System.Windows.Forms.TabPage tabSetting;
        private MaterialSkin.Controls.MaterialLabel labelTime;
        private MaterialSkin.Controls.MaterialButton addButton;
        private System.Windows.Forms.DataGridView timeDataGridView;
        private MaterialSkin.Controls.MaterialButton removeButton;
        private MaterialSkin.Controls.MaterialButton startButton;
        private MaterialSkin.Controls.MaterialTextBox textBoxAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton6;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}

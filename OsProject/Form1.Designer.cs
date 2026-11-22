namespace OsProject
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
            PathBox = new TextBox();
            PathLable = new Label();
            BrowseButton = new Button();
            QuickAccess = new Panel();
            LocalDiscCLabel = new Label();
            VideosLabel = new Label();
            DocumentsLabel = new Label();
            PicturesLabel = new Label();
            MusicLabel = new Label();
            ThisPCLabel = new Label();
            QuickAccessLable = new Label();
            panel2 = new Panel();
            ModifiedLable = new Label();
            label25 = new Label();
            CreatedLable = new Label();
            label24 = new Label();
            SizeLable = new Label();
            label22 = new Label();
            ExtensionLable = new Label();
            lable23 = new Label();
            FilePathLable = new Label();
            label21 = new Label();
            FileNameLable = new Label();
            Label = new Label();
            FileDetailsLabel = new Label();
            label6 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            ModifiedDate = new DataGridViewTextBoxColumn();
            FilesFoldersLable = new Label();
            panel4 = new Panel();
            panel7 = new Panel();
            LogBox = new RichTextBox();
            label5 = new Label();
            button10 = new Button();
            label3 = new Label();
            panel5 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel6 = new Panel();
            Per = new Label();
            CurrentThread = new Label();
            CurrentOp = new Label();
            progressBar = new ProgressBar();
            label4 = new Label();
            textBox1 = new TextBox();
            Searchlabel = new Label();
            panel8 = new Panel();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label14 = new Label();
            DiskSpaceLabel = new Label();
            label11 = new Label();
            OpenedLabel = new Label();
            label12 = new Label();
            label13 = new Label();
            DeletedLabel = new Label();
            label9 = new Label();
            label10 = new Label();
            CreatedLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            OperationsCountLabel = new Label();
            QuickAccess.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // PathBox
            // 
            PathBox.BorderStyle = BorderStyle.FixedSingle;
            PathBox.Font = new Font("Segoe UI", 13F);
            PathBox.Location = new Point(143, 19);
            PathBox.Margin = new Padding(5);
            PathBox.Multiline = true;
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(1642, 55);
            PathBox.TabIndex = 0;
            // 
            // PathLable
            // 
            PathLable.AutoSize = true;
            PathLable.Location = new Point(20, 14);
            PathLable.Margin = new Padding(5, 0, 5, 0);
            PathLable.Name = "PathLable";
            PathLable.Padding = new Padding(24, 14, 24, 14);
            PathLable.Size = new Size(113, 60);
            PathLable.TabIndex = 1;
            PathLable.Text = "Path:";
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = SystemColors.GradientInactiveCaption;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(1796, 19);
            BrowseButton.Margin = new Padding(5);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(138, 56);
            BrowseButton.TabIndex = 2;
            BrowseButton.Text = "Browse..";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // QuickAccess
            // 
            QuickAccess.BackColor = Color.White;
            QuickAccess.BorderStyle = BorderStyle.FixedSingle;
            QuickAccess.Controls.Add(LocalDiscCLabel);
            QuickAccess.Controls.Add(VideosLabel);
            QuickAccess.Controls.Add(DocumentsLabel);
            QuickAccess.Controls.Add(PicturesLabel);
            QuickAccess.Controls.Add(MusicLabel);
            QuickAccess.Controls.Add(ThisPCLabel);
            QuickAccess.Controls.Add(QuickAccessLable);
            QuickAccess.Location = new Point(36, 102);
            QuickAccess.Margin = new Padding(5);
            QuickAccess.Name = "QuickAccess";
            QuickAccess.Size = new Size(449, 621);
            QuickAccess.TabIndex = 3;
            // 
            // LocalDiscCLabel
            // 
            LocalDiscCLabel.AutoSize = true;
            LocalDiscCLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocalDiscCLabel.ForeColor = Color.Black;
            LocalDiscCLabel.Location = new Point(55, 533);
            LocalDiscCLabel.Margin = new Padding(5, 0, 5, 0);
            LocalDiscCLabel.Name = "LocalDiscCLabel";
            LocalDiscCLabel.Size = new Size(332, 42);
            LocalDiscCLabel.TabIndex = 11;
            LocalDiscCLabel.Text = "💾 Local Disk (C:)";
            LocalDiscCLabel.Click += LocalDiscCLabel_Click;
            // 
            // VideosLabel
            // 
            VideosLabel.AutoSize = true;
            VideosLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VideosLabel.ForeColor = Color.Black;
            VideosLabel.Location = new Point(36, 434);
            VideosLabel.Margin = new Padding(5, 0, 5, 0);
            VideosLabel.Name = "VideosLabel";
            VideosLabel.Size = new Size(317, 73);
            VideosLabel.TabIndex = 10;
            VideosLabel.Text = "🎬 Videos";
            VideosLabel.Click += VideosLabel_Click;
            // 
            // DocumentsLabel
            // 
            DocumentsLabel.AutoSize = true;
            DocumentsLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocumentsLabel.ForeColor = Color.Black;
            DocumentsLabel.Location = new Point(47, 214);
            DocumentsLabel.Margin = new Padding(5, 0, 5, 0);
            DocumentsLabel.Name = "DocumentsLabel";
            DocumentsLabel.Size = new Size(346, 55);
            DocumentsLabel.TabIndex = 9;
            DocumentsLabel.Text = "📄 Documents";
            DocumentsLabel.Click += DocumentsLabel_Click;
            // 
            // PicturesLabel
            // 
            PicturesLabel.AutoSize = true;
            PicturesLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PicturesLabel.ForeColor = Color.Black;
            PicturesLabel.Location = new Point(47, 285);
            PicturesLabel.Margin = new Padding(5, 0, 5, 0);
            PicturesLabel.Name = "PicturesLabel";
            PicturesLabel.Size = new Size(328, 69);
            PicturesLabel.TabIndex = 8;
            PicturesLabel.Text = "🖼️ Pictures";
            PicturesLabel.Click += PicturesLabel_Click;
            // 
            // MusicLabel
            // 
            MusicLabel.AutoSize = true;
            MusicLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MusicLabel.ForeColor = Color.Black;
            MusicLabel.Location = new Point(36, 355);
            MusicLabel.Margin = new Padding(5, 0, 5, 0);
            MusicLabel.Name = "MusicLabel";
            MusicLabel.Size = new Size(287, 73);
            MusicLabel.TabIndex = 7;
            MusicLabel.Text = "🎵 Music";
            MusicLabel.Click += MusicLabel_Click;
            // 
            // ThisPCLabel
            // 
            ThisPCLabel.AutoSize = true;
            ThisPCLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThisPCLabel.ForeColor = Color.Black;
            ThisPCLabel.Location = new Point(36, 123);
            ThisPCLabel.Margin = new Padding(5, 0, 5, 0);
            ThisPCLabel.Name = "ThisPCLabel";
            ThisPCLabel.Size = new Size(333, 73);
            ThisPCLabel.TabIndex = 5;
            ThisPCLabel.Text = "🖥️ This Pc";
            ThisPCLabel.Click += ThisPCLabel_Click;
            // 
            // QuickAccessLable
            // 
            QuickAccessLable.AutoSize = true;
            QuickAccessLable.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuickAccessLable.Location = new Point(91, -2);
            QuickAccessLable.Margin = new Padding(5, 0, 5, 0);
            QuickAccessLable.Name = "QuickAccessLable";
            QuickAccessLable.Padding = new Padding(8, 0, 24, 0);
            QuickAccessLable.Size = new Size(258, 99);
            QuickAccessLable.TabIndex = 2;
            QuickAccessLable.Text = "Quick Access";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ModifiedLable);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(CreatedLable);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(SizeLable);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(ExtensionLable);
            panel2.Controls.Add(lable23);
            panel2.Controls.Add(FilePathLable);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(FileNameLable);
            panel2.Controls.Add(Label);
            panel2.Controls.Add(FileDetailsLabel);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(36, 734);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 357);
            panel2.TabIndex = 4;
            // 
            // ModifiedLable
            // 
            ModifiedLable.AutoSize = true;
            ModifiedLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModifiedLable.Location = new Point(172, 290);
            ModifiedLable.Margin = new Padding(5, 0, 5, 0);
            ModifiedLable.Name = "ModifiedLable";
            ModifiedLable.Padding = new Padding(0, 5, 0, 5);
            ModifiedLable.Size = new Size(27, 46);
            ModifiedLable.TabIndex = 27;
            ModifiedLable.Text = "-";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(5, 290);
            label25.Margin = new Padding(5, 0, 5, 0);
            label25.Name = "label25";
            label25.Padding = new Padding(0, 5, 0, 5);
            label25.Size = new Size(143, 46);
            label25.TabIndex = 26;
            label25.Text = "Modified:";
            // 
            // CreatedLable
            // 
            CreatedLable.AutoSize = true;
            CreatedLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatedLable.Location = new Point(172, 238);
            CreatedLable.Margin = new Padding(5, 0, 5, 0);
            CreatedLable.Name = "CreatedLable";
            CreatedLable.Padding = new Padding(0, 5, 0, 5);
            CreatedLable.Size = new Size(27, 46);
            CreatedLable.TabIndex = 25;
            CreatedLable.Text = "-";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(5, 238);
            label24.Margin = new Padding(5, 0, 5, 0);
            label24.Name = "label24";
            label24.Padding = new Padding(0, 5, 0, 5);
            label24.Size = new Size(127, 46);
            label24.TabIndex = 24;
            label24.Text = "Created:";
            // 
            // SizeLable
            // 
            SizeLable.AutoSize = true;
            SizeLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SizeLable.Location = new Point(172, 192);
            SizeLable.Margin = new Padding(5, 0, 5, 0);
            SizeLable.Name = "SizeLable";
            SizeLable.Padding = new Padding(0, 5, 0, 5);
            SizeLable.Size = new Size(27, 46);
            SizeLable.TabIndex = 21;
            SizeLable.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(5, 192);
            label22.Margin = new Padding(5, 0, 5, 0);
            label22.Name = "label22";
            label22.Padding = new Padding(0, 5, 0, 5);
            label22.Size = new Size(75, 46);
            label22.TabIndex = 20;
            label22.Text = "Size:";
            // 
            // ExtensionLable
            // 
            ExtensionLable.AutoSize = true;
            ExtensionLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExtensionLable.Location = new Point(172, 139);
            ExtensionLable.Margin = new Padding(5, 0, 5, 0);
            ExtensionLable.Name = "ExtensionLable";
            ExtensionLable.Padding = new Padding(0, 5, 0, 5);
            ExtensionLable.Size = new Size(27, 46);
            ExtensionLable.TabIndex = 19;
            ExtensionLable.Text = "-";
            // 
            // lable23
            // 
            lable23.AutoSize = true;
            lable23.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lable23.Location = new Point(-2, 146);
            lable23.Margin = new Padding(5, 0, 5, 0);
            lable23.Name = "lable23";
            lable23.Padding = new Padding(0, 5, 0, 5);
            lable23.Size = new Size(149, 46);
            lable23.TabIndex = 18;
            lable23.Text = "Extension:";
            // 
            // FilePathLable
            // 
            FilePathLable.AutoSize = true;
            FilePathLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathLable.Location = new Point(172, 93);
            FilePathLable.Margin = new Padding(5, 0, 5, 0);
            FilePathLable.Name = "FilePathLable";
            FilePathLable.Padding = new Padding(0, 5, 0, 5);
            FilePathLable.Size = new Size(27, 46);
            FilePathLable.TabIndex = 17;
            FilePathLable.Text = "-";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(5, 99);
            label21.Margin = new Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Padding = new Padding(0, 5, 0, 5);
            label21.Size = new Size(134, 46);
            label21.TabIndex = 16;
            label21.Text = "File Path:";
            // 
            // FileNameLable
            // 
            FileNameLable.AutoSize = true;
            FileNameLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileNameLable.Location = new Point(172, 46);
            FileNameLable.Margin = new Padding(5, 0, 5, 0);
            FileNameLable.Name = "FileNameLable";
            FileNameLable.Padding = new Padding(0, 5, 0, 5);
            FileNameLable.Size = new Size(27, 46);
            FileNameLable.TabIndex = 15;
            FileNameLable.Text = "-";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label.Location = new Point(5, 53);
            Label.Margin = new Padding(5, 0, 5, 0);
            Label.Name = "Label";
            Label.Padding = new Padding(0, 5, 0, 5);
            Label.Size = new Size(155, 46);
            Label.TabIndex = 14;
            Label.Text = "File Name:";
            // 
            // FileDetailsLabel
            // 
            FileDetailsLabel.AutoSize = true;
            FileDetailsLabel.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FileDetailsLabel.Location = new Point(306, -6);
            FileDetailsLabel.Margin = new Padding(5, 0, 5, 0);
            FileDetailsLabel.Name = "FileDetailsLabel";
            FileDetailsLabel.Padding = new Padding(8, 0, 24, 0);
            FileDetailsLabel.Size = new Size(226, 99);
            FileDetailsLabel.TabIndex = 3;
            FileDetailsLabel.Text = "File Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 146);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(8, 0, 24, 0);
            label6.Size = new Size(32, 32);
            label6.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(FilesFoldersLable);
            panel3.Location = new Point(496, 102);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1437, 621);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(21, 66);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1387, 505);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, Type, Size, ModifiedDate });
            dataGridView1.Location = new Point(-3, -3);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 32;
            dataGridView1.Size = new Size(1389, 507);
            dataGridView1.TabIndex = 5;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 200;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 200;
            // 
            // Size
            // 
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            Size.Width = 200;
            // 
            // ModifiedDate
            // 
            ModifiedDate.HeaderText = "Modified Date";
            ModifiedDate.MinimumWidth = 6;
            ModifiedDate.Name = "ModifiedDate";
            ModifiedDate.ReadOnly = true;
            ModifiedDate.Width = 220;
            // 
            // FilesFoldersLable
            // 
            FilesFoldersLable.AutoSize = true;
            FilesFoldersLable.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilesFoldersLable.Location = new Point(-2, -2);
            FilesFoldersLable.Margin = new Padding(5, 0, 5, 0);
            FilesFoldersLable.Name = "FilesFoldersLable";
            FilesFoldersLable.Padding = new Padding(8, 0, 24, 0);
            FilesFoldersLable.Size = new Size(313, 99);
            FilesFoldersLable.TabIndex = 4;
            FilesFoldersLable.Text = "Files And Folders";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(804, 734);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1053, 357);
            panel4.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(LogBox);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(28, 70);
            panel7.Margin = new Padding(5);
            panel7.Name = "panel7";
            panel7.Size = new Size(997, 263);
            panel7.TabIndex = 7;
            // 
            // LogBox
            // 
            LogBox.Location = new Point(-3, -3);
            LogBox.Margin = new Padding(5);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.Size = new Size(997, 263);
            LogBox.TabIndex = 5;
            LogBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 72);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(8, 0, 24, 0);
            label5.Size = new Size(32, 99);
            label5.TabIndex = 4;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.GradientInactiveCaption;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(889, 11);
            button10.Margin = new Padding(5);
            button10.Name = "button10";
            button10.Size = new Size(138, 56);
            button10.TabIndex = 5;
            button10.Text = "Clear Log";
            button10.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-2, 0);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(8, 0, 24, 0);
            label3.Size = new Size(294, 99);
            label3.TabIndex = 4;
            label3.Text = "Operations Log";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(button9);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(1944, 102);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(558, 621);
            panel5.TabIndex = 7;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.GradientInactiveCaption;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(11, 523);
            button9.Margin = new Padding(5);
            button9.Name = "button9";
            button9.Size = new Size(533, 70);
            button9.TabIndex = 12;
            button9.Text = "Get Drive Info";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Cyan;
            button8.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button8.FlatAppearance.BorderSize = 2;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(11, 387);
            button8.Margin = new Padding(5);
            button8.Name = "button8";
            button8.Size = new Size(249, 91);
            button8.TabIndex = 11;
            button8.Text = "📂 Open";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 192, 128);
            button7.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(11, 283);
            button7.Margin = new Padding(5);
            button7.Name = "button7";
            button7.Size = new Size(249, 94);
            button7.TabIndex = 10;
            button7.Text = "📄 Write File";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumPurple;
            button6.FlatAppearance.BorderColor = Color.Purple;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(270, 387);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(275, 91);
            button6.TabIndex = 9;
            button6.Text = "🔍 Search Files";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Aquamarine;
            button5.FlatAppearance.BorderColor = Color.Teal;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(270, 283);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(275, 94);
            button5.TabIndex = 8;
            button5.Text = "⎘ Copy/Move";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 192, 255);
            button4.FlatAppearance.BorderColor = Color.Fuchsia;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(270, 186);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(275, 88);
            button4.TabIndex = 7;
            button4.Text = "🗃️ Read File";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.BorderColor = Color.Tomato;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(11, 186);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(249, 88);
            button3.TabIndex = 6;
            button3.Text = "🗑️ Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(270, 80);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(275, 96);
            button2.TabIndex = 4;
            button2.Text = "📁 Create Folder";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 80);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(249, 96);
            button1.TabIndex = 3;
            button1.Text = "➕ Create File";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(8, 0, 24, 0);
            label1.Size = new Size(235, 99);
            label1.TabIndex = 5;
            label1.Text = "Operations";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(Per);
            panel6.Controls.Add(CurrentThread);
            panel6.Controls.Add(CurrentOp);
            panel6.Controls.Add(progressBar);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(1869, 734);
            panel6.Margin = new Padding(5);
            panel6.Name = "panel6";
            panel6.Size = new Size(632, 357);
            panel6.TabIndex = 8;
            // 
            // Per
            // 
            Per.AutoSize = true;
            Per.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Per.Location = new Point(42, 131);
            Per.Margin = new Padding(5, 0, 5, 0);
            Per.Name = "Per";
            Per.Padding = new Padding(0, 5, 0, 5);
            Per.Size = new Size(52, 46);
            Per.TabIndex = 18;
            Per.Text = "-%";
            // 
            // CurrentThread
            // 
            CurrentThread.AutoSize = true;
            CurrentThread.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentThread.Location = new Point(6, 242);
            CurrentThread.Margin = new Padding(5, 0, 5, 0);
            CurrentThread.Name = "CurrentThread";
            CurrentThread.Padding = new Padding(0, 5, 0, 5);
            CurrentThread.Size = new Size(165, 46);
            CurrentThread.TabIndex = 17;
            CurrentThread.Text = "Running in:";
            // 
            // CurrentOp
            // 
            CurrentOp.AutoSize = true;
            CurrentOp.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentOp.Location = new Point(6, 85);
            CurrentOp.Margin = new Padding(5, 0, 5, 0);
            CurrentOp.Name = "CurrentOp";
            CurrentOp.Padding = new Padding(0, 5, 0, 5);
            CurrentOp.Size = new Size(56, 46);
            CurrentOp.TabIndex = 16;
            CurrentOp.Text = "Op";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(109, 131);
            progressBar.Margin = new Padding(5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(510, 46);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-2, 0);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(8, 0, 24, 0);
            label4.Size = new Size(335, 99);
            label4.TabIndex = 5;
            label4.Text = "Current Operation";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(1944, 19);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Search Files...";
            textBox1.Size = new Size(558, 55);
            textBox1.TabIndex = 9;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Searchlabel
            // 
            Searchlabel.AutoSize = true;
            Searchlabel.BackColor = Color.White;
            Searchlabel.FlatStyle = FlatStyle.Flat;
            Searchlabel.Location = new Point(2441, 30);
            Searchlabel.Margin = new Padding(5, 0, 5, 0);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(47, 32);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "🔍";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.GradientActiveCaption;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(DiskSpaceLabel);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(OpenedLabel);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(DeletedLabel);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(CreatedLabel);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(OperationsCountLabel);
            panel8.Location = new Point(-32, 1102);
            panel8.Margin = new Padding(5);
            panel8.Name = "panel8";
            panel8.Size = new Size(2581, 79);
            panel8.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(2197, -6);
            label17.Margin = new Padding(5, 0, 5, 0);
            label17.Name = "label17";
            label17.Padding = new Padding(0, 3, 0, 5);
            label17.Size = new Size(61, 107);
            label17.TabIndex = 19;
            label17.Text = "|";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(1722, 18);
            label18.Margin = new Padding(5, 0, 5, 0);
            label18.Name = "label18";
            label18.Padding = new Padding(0, 5, 0, 5);
            label18.Size = new Size(451, 46);
            label18.TabIndex = 17;
            label18.Text = "🔒 Synchronization: Using Mutex";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(2174, 24);
            label19.Margin = new Padding(5, 0, 5, 0);
            label19.Name = "label19";
            label19.Padding = new Padding(0, 3, 0, 5);
            label19.Size = new Size(0, 44);
            label19.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(2278, 19);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Padding = new Padding(0, 5, 0, 5);
            label14.Size = new Size(205, 46);
            label14.TabIndex = 15;
            label14.Text = "💾 Disk Space:";
            // 
            // DiskSpaceLabel
            // 
            DiskSpaceLabel.AutoSize = true;
            DiskSpaceLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiskSpaceLabel.Location = new Point(2501, 22);
            DiskSpaceLabel.Margin = new Padding(5, 0, 5, 0);
            DiskSpaceLabel.Name = "DiskSpaceLabel";
            DiskSpaceLabel.Padding = new Padding(0, 3, 0, 5);
            DiskSpaceLabel.Size = new Size(31, 44);
            DiskSpaceLabel.TabIndex = 16;
            DiskSpaceLabel.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(904, 21);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 5, 0, 5);
            label11.Size = new Size(130, 46);
            label11.TabIndex = 13;
            label11.Text = "Opened:";
            // 
            // OpenedLabel
            // 
            OpenedLabel.AutoSize = true;
            OpenedLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenedLabel.Location = new Point(1042, 22);
            OpenedLabel.Margin = new Padding(5, 0, 5, 0);
            OpenedLabel.Name = "OpenedLabel";
            OpenedLabel.Padding = new Padding(0, 3, 0, 5);
            OpenedLabel.Size = new Size(31, 44);
            OpenedLabel.TabIndex = 14;
            OpenedLabel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(835, -5);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 3, 0, 5);
            label12.Size = new Size(61, 107);
            label12.TabIndex = 12;
            label12.Text = "|";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(674, 19);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 5, 0, 5);
            label13.Size = new Size(126, 46);
            label13.TabIndex = 10;
            label13.Text = "Deleted:";
            // 
            // DeletedLabel
            // 
            DeletedLabel.AutoSize = true;
            DeletedLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeletedLabel.Location = new Point(812, 21);
            DeletedLabel.Margin = new Padding(5, 0, 5, 0);
            DeletedLabel.Name = "DeletedLabel";
            DeletedLabel.Padding = new Padding(0, 3, 0, 5);
            DeletedLabel.Size = new Size(31, 44);
            DeletedLabel.TabIndex = 11;
            DeletedLabel.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(606, -6);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 3, 0, 5);
            label9.Size = new Size(61, 107);
            label9.TabIndex = 9;
            label9.Text = "|";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(445, 18);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 5, 0, 5);
            label10.Size = new Size(127, 46);
            label10.TabIndex = 7;
            label10.Text = "Created:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatedLabel.Location = new Point(580, 21);
            CreatedLabel.Margin = new Padding(5, 0, 5, 0);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Padding = new Padding(0, 3, 0, 5);
            CreatedLabel.Size = new Size(31, 44);
            CreatedLabel.TabIndex = 8;
            CreatedLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(374, -6);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 3, 0, 5);
            label8.Size = new Size(61, 107);
            label8.TabIndex = 6;
            label8.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 18);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 5, 0, 5);
            label7.Size = new Size(259, 46);
            label7.TabIndex = 4;
            label7.Text = "Operations Count:";
            // 
            // OperationsCountLabel
            // 
            OperationsCountLabel.AutoSize = true;
            OperationsCountLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OperationsCountLabel.Location = new Point(332, 19);
            OperationsCountLabel.Margin = new Padding(5, 0, 5, 0);
            OperationsCountLabel.Name = "OperationsCountLabel";
            OperationsCountLabel.Padding = new Padding(0, 3, 0, 5);
            OperationsCountLabel.Size = new Size(31, 44);
            OperationsCountLabel.TabIndex = 5;
            OperationsCountLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(2525, 1134);
            Controls.Add(panel8);
            Controls.Add(Searchlabel);
            Controls.Add(textBox1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(QuickAccess);
            Controls.Add(BrowseButton);
            Controls.Add(PathLable);
            Controls.Add(PathBox);
            Margin = new Padding(5);
            MaximumSize = new Size(2551, 1205);
            MinimumSize = new Size(2551, 1205);
            Name = "Form1";
            Text = "File Explorer";
            Load += Form1_Load;
            QuickAccess.ResumeLayout(false);
            QuickAccess.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PathBox;
        private Label PathLable;
        private Button BrowseButton;
        private Panel QuickAccess;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox1;
        private Label Searchlabel;
        private Label QuickAccessLable;
        private Label FileDetailsLabel;
        private Label FilesFoldersLable;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button9;
        private Button button8;
        private Button button7;
        private Panel panel7;
        private Label label5;
        private Button button10;
        private Label label3;
        private Label label4;
        private Panel panel8;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label OperationsCountLabel;
        private Label label11;
        private Label OpenedLabel;
        private Label label12;
        private Label label13;
        private Label DeletedLabel;
        private Label CreatedLabel;
        private Label label14;
        private Label DiskSpaceLabel;
        private Label CurrentOp;
        private ProgressBar progressBar;
        private Label CurrentThread;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn ModifiedDate;
        private Label ThisPCLabel;
        private Label LocalDiscCLabel;
        private Label VideosLabel;
        private Label DocumentsLabel;
        private Label PicturesLabel;
        private Label MusicLabel;
        private Label Label;
        private Label FileNameLable;
        private Label SizeLable;
        private Label label22;
        private Label ExtensionLable;
        private Label lable23;
        private Label FilePathLable;
        private Label label21;
        private Label CreatedLable;
        private Label label24;
        private Label ModifiedLable;
        private Label label25;
        private RichTextBox LogBox;
        private Label Per;
    }
}

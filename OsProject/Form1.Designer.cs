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
            PathBox.Location = new Point(88, 12);
            PathBox.Multiline = true;
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(1011, 35);
            PathBox.TabIndex = 0;
            // 
            // PathLable
            // 
            PathLable.AutoSize = true;
            PathLable.Location = new Point(12, 9);
            PathLable.Name = "PathLable";
            PathLable.Padding = new Padding(15, 9, 15, 9);
            PathLable.Size = new Size(70, 38);
            PathLable.TabIndex = 1;
            PathLable.Text = "Path:";
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = SystemColors.GradientInactiveCaption;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(1105, 12);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(85, 35);
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
            QuickAccess.Location = new Point(22, 64);
            QuickAccess.Name = "QuickAccess";
            QuickAccess.Size = new Size(277, 389);
            QuickAccess.TabIndex = 3;
            // 
            // LocalDiscCLabel
            // 
            LocalDiscCLabel.AutoSize = true;
            LocalDiscCLabel.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocalDiscCLabel.ForeColor = Color.Black;
            LocalDiscCLabel.Location = new Point(34, 333);
            LocalDiscCLabel.Name = "LocalDiscCLabel";
            LocalDiscCLabel.Size = new Size(218, 29);
            LocalDiscCLabel.TabIndex = 11;
            LocalDiscCLabel.Text = "💾 Local Disk (C:)";
            LocalDiscCLabel.Click += LocalDiscCLabel_Click;
            // 
            // VideosLabel
            // 
            VideosLabel.AutoSize = true;
            VideosLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VideosLabel.ForeColor = Color.Black;
            VideosLabel.Location = new Point(22, 271);
            VideosLabel.Name = "VideosLabel";
            VideosLabel.Size = new Size(197, 46);
            VideosLabel.TabIndex = 10;
            VideosLabel.Text = "🎬 Videos";
            VideosLabel.Click += VideosLabel_Click;
            // 
            // DocumentsLabel
            // 
            DocumentsLabel.AutoSize = true;
            DocumentsLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DocumentsLabel.ForeColor = Color.Black;
            DocumentsLabel.Location = new Point(29, 134);
            DocumentsLabel.Name = "DocumentsLabel";
            DocumentsLabel.Size = new Size(219, 36);
            DocumentsLabel.TabIndex = 9;
            DocumentsLabel.Text = "📄 Documents";
            DocumentsLabel.Click += DocumentsLabel_Click;
            // 
            // PicturesLabel
            // 
            PicturesLabel.AutoSize = true;
            PicturesLabel.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PicturesLabel.ForeColor = Color.Black;
            PicturesLabel.Location = new Point(29, 178);
            PicturesLabel.Name = "PicturesLabel";
            PicturesLabel.Size = new Size(206, 42);
            PicturesLabel.TabIndex = 8;
            PicturesLabel.Text = "🖼️ Pictures";
            PicturesLabel.Click += PicturesLabel_Click;
            // 
            // MusicLabel
            // 
            MusicLabel.AutoSize = true;
            MusicLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MusicLabel.ForeColor = Color.Black;
            MusicLabel.Location = new Point(22, 222);
            MusicLabel.Name = "MusicLabel";
            MusicLabel.Size = new Size(179, 46);
            MusicLabel.TabIndex = 7;
            MusicLabel.Text = "🎵 Music";
            MusicLabel.Click += MusicLabel_Click;
            // 
            // ThisPCLabel
            // 
            ThisPCLabel.AutoSize = true;
            ThisPCLabel.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThisPCLabel.ForeColor = Color.Black;
            ThisPCLabel.Location = new Point(22, 77);
            ThisPCLabel.Name = "ThisPCLabel";
            ThisPCLabel.Size = new Size(208, 46);
            ThisPCLabel.TabIndex = 5;
            ThisPCLabel.Text = "🖥️ This Pc";
            ThisPCLabel.Click += ThisPCLabel_Click;
            // 
            // QuickAccessLable
            // 
            QuickAccessLable.AutoSize = true;
            QuickAccessLable.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuickAccessLable.Location = new Point(56, -1);
            QuickAccessLable.Name = "QuickAccessLable";
            QuickAccessLable.Padding = new Padding(5, 0, 15, 0);
            QuickAccessLable.Size = new Size(168, 62);
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
            panel2.Location = new Point(22, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(467, 224);
            panel2.TabIndex = 4;
            // 
            // ModifiedLable
            // 
            ModifiedLable.AutoSize = true;
            ModifiedLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModifiedLable.Location = new Point(106, 181);
            ModifiedLable.Name = "ModifiedLable";
            ModifiedLable.Padding = new Padding(0, 3, 0, 3);
            ModifiedLable.Size = new Size(17, 29);
            ModifiedLable.TabIndex = 27;
            ModifiedLable.Text = "-";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(3, 181);
            label25.Name = "label25";
            label25.Padding = new Padding(0, 3, 0, 3);
            label25.Size = new Size(90, 29);
            label25.TabIndex = 26;
            label25.Text = "Modified:";
            // 
            // CreatedLable
            // 
            CreatedLable.AutoSize = true;
            CreatedLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatedLable.Location = new Point(106, 149);
            CreatedLable.Name = "CreatedLable";
            CreatedLable.Padding = new Padding(0, 3, 0, 3);
            CreatedLable.Size = new Size(17, 29);
            CreatedLable.TabIndex = 25;
            CreatedLable.Text = "-";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(3, 149);
            label24.Name = "label24";
            label24.Padding = new Padding(0, 3, 0, 3);
            label24.Size = new Size(77, 29);
            label24.TabIndex = 24;
            label24.Text = "Created:";
            // 
            // SizeLable
            // 
            SizeLable.AutoSize = true;
            SizeLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SizeLable.Location = new Point(106, 120);
            SizeLable.Name = "SizeLable";
            SizeLable.Padding = new Padding(0, 3, 0, 3);
            SizeLable.Size = new Size(17, 29);
            SizeLable.TabIndex = 21;
            SizeLable.Text = "-";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(3, 120);
            label22.Name = "label22";
            label22.Padding = new Padding(0, 3, 0, 3);
            label22.Size = new Size(47, 29);
            label22.TabIndex = 20;
            label22.Text = "Size:";
            // 
            // ExtensionLable
            // 
            ExtensionLable.AutoSize = true;
            ExtensionLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExtensionLable.Location = new Point(106, 87);
            ExtensionLable.Name = "ExtensionLable";
            ExtensionLable.Padding = new Padding(0, 3, 0, 3);
            ExtensionLable.Size = new Size(17, 29);
            ExtensionLable.TabIndex = 19;
            ExtensionLable.Text = "-";
            // 
            // lable23
            // 
            lable23.AutoSize = true;
            lable23.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lable23.Location = new Point(-1, 91);
            lable23.Name = "lable23";
            lable23.Padding = new Padding(0, 3, 0, 3);
            lable23.Size = new Size(92, 29);
            lable23.TabIndex = 18;
            lable23.Text = "Extension:";
            // 
            // FilePathLable
            // 
            FilePathLable.AutoSize = true;
            FilePathLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilePathLable.Location = new Point(106, 58);
            FilePathLable.Name = "FilePathLable";
            FilePathLable.Padding = new Padding(0, 3, 0, 3);
            FilePathLable.Size = new Size(17, 29);
            FilePathLable.TabIndex = 17;
            FilePathLable.Text = "-";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(3, 62);
            label21.Name = "label21";
            label21.Padding = new Padding(0, 3, 0, 3);
            label21.Size = new Size(83, 29);
            label21.TabIndex = 16;
            label21.Text = "File Path:";
            // 
            // FileNameLable
            // 
            FileNameLable.AutoSize = true;
            FileNameLable.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FileNameLable.Location = new Point(106, 29);
            FileNameLable.Name = "FileNameLable";
            FileNameLable.Padding = new Padding(0, 3, 0, 3);
            FileNameLable.Size = new Size(17, 29);
            FileNameLable.TabIndex = 15;
            FileNameLable.Text = "-";
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label.Location = new Point(3, 33);
            Label.Name = "Label";
            Label.Padding = new Padding(0, 3, 0, 3);
            Label.Size = new Size(97, 29);
            Label.TabIndex = 14;
            Label.Text = "File Name:";
            // 
            // FileDetailsLabel
            // 
            FileDetailsLabel.AutoSize = true;
            FileDetailsLabel.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FileDetailsLabel.Location = new Point(188, -4);
            FileDetailsLabel.Name = "FileDetailsLabel";
            FileDetailsLabel.Padding = new Padding(5, 0, 15, 0);
            FileDetailsLabel.Size = new Size(148, 62);
            FileDetailsLabel.TabIndex = 3;
            FileDetailsLabel.Text = "File Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 91);
            label6.Name = "label6";
            label6.Padding = new Padding(5, 0, 15, 0);
            label6.Size = new Size(20, 20);
            label6.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(FilesFoldersLable);
            panel3.Location = new Point(305, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 389);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(13, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 317);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, Type, Size, ModifiedDate });
            dataGridView1.Location = new Point(-2, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 32;
            dataGridView1.Size = new Size(855, 317);
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
            FilesFoldersLable.Location = new Point(-1, -1);
            FilesFoldersLable.Name = "FilesFoldersLable";
            FilesFoldersLable.Padding = new Padding(5, 0, 15, 0);
            FilesFoldersLable.Size = new Size(202, 62);
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
            panel4.Location = new Point(495, 459);
            panel4.Name = "panel4";
            panel4.Size = new Size(649, 224);
            panel4.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(LogBox);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(17, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(615, 166);
            panel7.TabIndex = 7;
            // 
            // LogBox
            // 
            LogBox.Location = new Point(-2, -2);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.Size = new Size(615, 166);
            LogBox.TabIndex = 5;
            LogBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 45);
            label5.Name = "label5";
            label5.Padding = new Padding(5, 0, 15, 0);
            label5.Size = new Size(20, 62);
            label5.TabIndex = 4;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.GradientInactiveCaption;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(547, 7);
            button10.Name = "button10";
            button10.Size = new Size(85, 35);
            button10.TabIndex = 5;
            button10.Text = "Clear Log";
            button10.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 0, 15, 0);
            label3.Size = new Size(188, 62);
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
            panel5.Location = new Point(1196, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(344, 389);
            panel5.TabIndex = 7;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.GradientInactiveCaption;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(7, 327);
            button9.Name = "button9";
            button9.Size = new Size(328, 44);
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
            button8.Location = new Point(7, 242);
            button8.Name = "button8";
            button8.Size = new Size(153, 57);
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
            button7.Location = new Point(7, 177);
            button7.Name = "button7";
            button7.Size = new Size(153, 59);
            button7.TabIndex = 10;
            button7.Text = "📄 Write File";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumPurple;
            button6.FlatAppearance.BorderColor = Color.Purple;
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(166, 242);
            button6.Name = "button6";
            button6.Size = new Size(169, 57);
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
            button5.Location = new Point(166, 177);
            button5.Name = "button5";
            button5.Size = new Size(169, 59);
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
            button4.Location = new Point(166, 116);
            button4.Name = "button4";
            button4.Size = new Size(169, 55);
            button4.TabIndex = 7;
            button4.Text = "🗃️ Read File";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.FlatAppearance.BorderColor = Color.Tomato;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(7, 116);
            button3.Name = "button3";
            button3.Size = new Size(153, 55);
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
            button2.Location = new Point(166, 50);
            button2.Name = "button2";
            button2.Size = new Size(169, 60);
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
            button1.Location = new Point(7, 50);
            button1.Name = "button1";
            button1.Size = new Size(153, 60);
            button1.TabIndex = 3;
            button1.Text = "➕ Create File";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 0, 15, 0);
            label1.Size = new Size(151, 62);
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
            panel6.Location = new Point(1150, 459);
            panel6.Name = "panel6";
            panel6.Size = new Size(390, 224);
            panel6.TabIndex = 8;
            // 
            // Per
            // 
            Per.AutoSize = true;
            Per.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Per.Location = new Point(26, 82);
            Per.Name = "Per";
            Per.Padding = new Padding(0, 3, 0, 3);
            Per.Size = new Size(32, 29);
            Per.TabIndex = 18;
            Per.Text = "-%";
            // 
            // CurrentThread
            // 
            CurrentThread.AutoSize = true;
            CurrentThread.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentThread.Location = new Point(4, 151);
            CurrentThread.Name = "CurrentThread";
            CurrentThread.Padding = new Padding(0, 3, 0, 3);
            CurrentThread.Size = new Size(101, 29);
            CurrentThread.TabIndex = 17;
            CurrentThread.Text = "Running in:";
            // 
            // CurrentOp
            // 
            CurrentOp.AutoSize = true;
            CurrentOp.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentOp.Location = new Point(4, 53);
            CurrentOp.Name = "CurrentOp";
            CurrentOp.Padding = new Padding(0, 3, 0, 3);
            CurrentOp.Size = new Size(35, 29);
            CurrentOp.TabIndex = 16;
            CurrentOp.Text = "Op";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(67, 82);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(314, 29);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 15, 0);
            label4.Size = new Size(214, 62);
            label4.TabIndex = 5;
            label4.Text = "Current Operation";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(1196, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Search Files...";
            textBox1.Size = new Size(344, 35);
            textBox1.TabIndex = 9;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Searchlabel
            // 
            Searchlabel.AutoSize = true;
            Searchlabel.BackColor = Color.White;
            Searchlabel.FlatStyle = FlatStyle.Flat;
            Searchlabel.Location = new Point(1502, 19);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(30, 20);
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
            panel8.Location = new Point(-20, 689);
            panel8.Name = "panel8";
            panel8.Size = new Size(1589, 50);
            panel8.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(1352, -4);
            label17.Name = "label17";
            label17.Padding = new Padding(0, 2, 0, 3);
            label17.Size = new Size(36, 65);
            label17.TabIndex = 19;
            label17.Text = "|";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(1066, 2);
            label18.Name = "label18";
            label18.Padding = new Padding(0, 3, 0, 3);
            label18.Size = new Size(280, 29);
            label18.TabIndex = 17;
            label18.Text = "🔒 Synchronization: Using Mutex";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(1338, 15);
            label19.Name = "label19";
            label19.Padding = new Padding(0, 2, 0, 3);
            label19.Size = new Size(0, 28);
            label19.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(1394, 3);
            label14.Name = "label14";
            label14.Padding = new Padding(0, 3, 0, 3);
            label14.Size = new Size(131, 29);
            label14.TabIndex = 15;
            label14.Text = "💾 Disk Space:";
            // 
            // DiskSpaceLabel
            // 
            DiskSpaceLabel.AutoSize = true;
            DiskSpaceLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiskSpaceLabel.Location = new Point(1539, 2);
            DiskSpaceLabel.Name = "DiskSpaceLabel";
            DiskSpaceLabel.Padding = new Padding(0, 2, 0, 3);
            DiskSpaceLabel.Size = new Size(20, 28);
            DiskSpaceLabel.TabIndex = 16;
            DiskSpaceLabel.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(555, 2);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 3, 0, 3);
            label11.Size = new Size(80, 29);
            label11.TabIndex = 13;
            label11.Text = "Opened:";
            // 
            // OpenedLabel
            // 
            OpenedLabel.AutoSize = true;
            OpenedLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OpenedLabel.Location = new Point(641, 3);
            OpenedLabel.Name = "OpenedLabel";
            OpenedLabel.Padding = new Padding(0, 2, 0, 3);
            OpenedLabel.Size = new Size(20, 28);
            OpenedLabel.TabIndex = 14;
            OpenedLabel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(514, -4);
            label12.Name = "label12";
            label12.Padding = new Padding(0, 2, 0, 3);
            label12.Size = new Size(36, 65);
            label12.TabIndex = 12;
            label12.Text = "|";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(406, 2);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 3, 0, 3);
            label13.Size = new Size(79, 29);
            label13.TabIndex = 10;
            label13.Text = "Deleted:";
            // 
            // DeletedLabel
            // 
            DeletedLabel.AutoSize = true;
            DeletedLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeletedLabel.Location = new Point(491, 3);
            DeletedLabel.Name = "DeletedLabel";
            DeletedLabel.Padding = new Padding(0, 2, 0, 3);
            DeletedLabel.Size = new Size(20, 28);
            DeletedLabel.TabIndex = 11;
            DeletedLabel.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(373, -4);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 2, 0, 3);
            label9.Size = new Size(36, 65);
            label9.TabIndex = 9;
            label9.Text = "|";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(272, 1);
            label10.Name = "label10";
            label10.Padding = new Padding(0, 3, 0, 3);
            label10.Size = new Size(77, 29);
            label10.TabIndex = 7;
            label10.Text = "Created:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatedLabel.Location = new Point(358, 2);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Padding = new Padding(0, 2, 0, 3);
            CreatedLabel.Size = new Size(20, 28);
            CreatedLabel.TabIndex = 8;
            CreatedLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(230, -4);
            label8.Name = "label8";
            label8.Padding = new Padding(0, 2, 0, 3);
            label8.Size = new Size(36, 65);
            label8.TabIndex = 6;
            label8.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 3, 0, 3);
            label7.Size = new Size(157, 29);
            label7.TabIndex = 4;
            label7.Text = "Operations Count:";
            // 
            // OperationsCountLabel
            // 
            OperationsCountLabel.AutoSize = true;
            OperationsCountLabel.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OperationsCountLabel.Location = new Point(204, 2);
            OperationsCountLabel.Name = "OperationsCountLabel";
            OperationsCountLabel.Padding = new Padding(0, 2, 0, 3);
            OperationsCountLabel.Size = new Size(20, 28);
            OperationsCountLabel.TabIndex = 5;
            OperationsCountLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1559, 720);
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
            MaximumSize = new Size(1577, 767);
            MinimumSize = new Size(1577, 767);
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

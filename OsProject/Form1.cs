using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Threading;

namespace OsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Public Vars
        string CurrentFolderPath = "";
        string SelectedItemPath = "";
        private static Mutex mutex = new();
        int OpCount;
        int NumOfCreated;
        int NumOfDeleted;
        int NumOfOpened;
        int threadCounter = 0;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            CursorChange(sender, e);
            CurrentFolderPath = ViewThisPC();
            PathBox.Text = CurrentFolderPath;
            dataGridView1.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0 && args.RowIndex < dataGridView1.Rows.Count)
                {
                    var selectedRow = dataGridView1.Rows[args.RowIndex];
                    string selectedPath = selectedRow.Tag?.ToString();
                    if (!string.IsNullOrEmpty(selectedPath))
                    {
                        SelectedItemPath = selectedPath;
                        PathBox.Text = CurrentFolderPath;
                        if (File.Exists(selectedPath))
                        {
                            FileInfo fileInfo = new(selectedPath);
                            ItemInfo(fileInfo);
                        }
                        else if (Directory.Exists(selectedPath))
                        {
                            DirectoryInfo directoryInfo = new(selectedPath);
                            ItemInfo(directoryInfo);
                        }
                    }
                }
            };
        }

        private void ThisPCLabel_Click(object sender, EventArgs e)
        {
            CurrentFolderPath = ViewThisPC();
            PathBox.Text = CurrentFolderPath;
            SelectedItemPath = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SelectedItemPath))
            {
                LoadDirectory(SelectedItemPath);
                UpdateStats("Open");
                AddLog($"({new DirectoryInfo(SelectedItemPath).Name}) Opened", Color.Green);
            }
            else if (File.Exists(SelectedItemPath))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = SelectedItemPath,
                        UseShellExecute = true
                    });
                    AddLog($"({Path.GetFileName(SelectedItemPath)}) Opened", Color.Green);
                    UpdateStats("Open");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a folder to open.");
            }
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderbrowser = new();
            if (folderbrowser.ShowDialog() == DialogResult.OK)
            {
                CurrentFolderPath = folderbrowser.SelectedPath;
                PathBox.Text = CurrentFolderPath;
                LoadDirectory(CurrentFolderPath);
            }
        }
        private void DocumentsLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
        private void PicturesLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }
        private void MusicLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }
        private void VideosLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        }
        private void LocalDiscCLabel_Click(object sender, EventArgs e)
        {
            LoadDirectory(@"C:\");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedItemPath) || !File.Exists(SelectedItemPath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Click 'Yes' to Copy, 'No' to Move, or 'Cancel' to abort.",
                "Select Operation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Cancel) return;
            bool isMove = (result == DialogResult.No);
            using FolderBrowserDialog folder = new();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = SelectedItemPath;
                string destPath = Path.Combine(folder.SelectedPath, Path.GetFileName(sourcePath));

                if (sourcePath.Equals(destPath, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Source and destination paths are the same.");
                    return;
                }
                RunInThread(() => CopyOrMoveFile(sourcePath, destPath, isMove));
            }

        }

        #region Abdulrhman Nofal's Mithods
        private void ItemInfo<T>(T item) where T : FileSystemInfo
        {
            FileNameLable.Text = item.Name;
            FilePathLable.Text = item.FullName;
            ExtensionLable.Text = item is FileInfo ? item.Extension : "Folder";
            SizeLable.Text = item is FileInfo file ? $"{Math.Round(file.Length / (1024.0), 3)} kB" : "-";
            CreatedLable.Text = item.CreationTime.ToString();
            ModifiedLable.Text = item.LastWriteTime.ToString();
        }
        private string ViewThisPC()
        {
            dataGridView1.Rows.Clear();

            DriveInfo.GetDrives().Where(d => d.IsReady).ToList().ForEach(drive =>
            {
                dataGridView1.Rows.Add($"Local Disk ({drive.Name.Split(':')[0]})", drive.DriveType, Math.Round(drive.TotalSize / (1024.0 * 1024 * 1024), 2) + " GB", '-');
                dataGridView1.Rows[^1].Tag = drive.Name;
            });
            AddLog("(This Pc) Opened", Color.Green);
            return "This PC";
        }
        private void CursorChange(object sender, EventArgs e)
        {
            ThisPCLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            ThisPCLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            DocumentsLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            DocumentsLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            PicturesLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            PicturesLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            MusicLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            MusicLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            VideosLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            VideosLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };
            LocalDiscCLabel.MouseEnter += (s, args) => { Cursor = Cursors.Hand; };
            LocalDiscCLabel.MouseLeave += (s, args) => { Cursor = Cursors.Default; };

        }
        public void LoadDirectory(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new(path);
                List<FileInfo> items = [.. directoryInfo.GetFiles()];
                List<DirectoryInfo> directories = [.. directoryInfo.GetDirectories()];
                dataGridView1.Rows.Clear();
                foreach (var dir in directories)
                {
                    dataGridView1.Rows.Add(dir.Name, "Folder", "-", "-");
                    dataGridView1.Rows[^1].Tag = dir.FullName;
                }
                foreach (var file in items)
                {
                    dataGridView1.Rows.Add(file.Name, "File", Math.Round(file.Length / (1024.0), 3) + " kB", file.LastWriteTime);
                    dataGridView1.Rows[^1].Tag = file.FullName;
                }
                CurrentFolderPath = path;
                SelectedItemPath = "";
                PathBox.Text = CurrentFolderPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading directory: {ex.Message}");
            }
        }
        public void UpdateStats(string OperationType)
        {
            mutex.WaitOne();
            int totalop = 0;
            int opend = 0;
            int created = 0;
            int deleted = 0;
            try
            {
                OpCount++;
                switch (OperationType)
                {
                    case "Create":
                        NumOfCreated++;
                        break;
                    case "Open":
                        NumOfOpened++;
                        break;
                    case "Delete":
                        NumOfDeleted++;
                        break;
                }
                totalop = OpCount;
                opend = NumOfOpened;
                created = NumOfCreated;
                deleted = NumOfDeleted;
            }
            catch (Exception ex)
            {
                AddLog($"Error updating stats: {ex.Message}", Color.Red);
            }
            finally
            {
                mutex.ReleaseMutex();
            }
            this.BeginInvoke(new Action(() =>
            {
                OperationsCountLabel.Text = totalop.ToString();
                OpenedLabel.Text = opend.ToString();
                CreatedLabel.Text = created.ToString();
                DeletedLabel.Text = deleted.ToString();
            }));
        }
        public void AddLog(string Msg, Color color)
        {
            mutex.WaitOne();
            try
            {
                string LogLine = $"{Msg} - {Thread.CurrentThread.Name ?? "Main-Thread"} - {DateTime.Now:hh:mm:ss tt}\n";
                LogBox.BeginInvoke(new Action(() =>
                {
                    LogBox.SelectionStart = LogBox.TextLength;
                    LogBox.SelectionColor = color;
                    LogBox.AppendText(LogLine);
                    LogBox.ScrollToCaret();
                }));
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
        public void RunInThread(Action work)
        {
            int id = Interlocked.Increment(ref threadCounter);
            Thread thread = new(() =>
            {
                Thread.CurrentThread.Name = $"Thread-{id}";
                work();
            });
            thread.IsBackground = true;
            thread.Start();
        }
        public void UpdateProgress(string status, int percent)
        {
            string ThreadName = Thread.CurrentThread.Name ?? "Main-Thread";
            this.BeginInvoke(new Action(() =>
            {
                CurrentOp.Text = status;
                progressBar.Value = Math.Clamp(percent, 0, 100);
                Per.Text = $"{percent}%";
                CurrentThread.Text = $"Running in: {ThreadName}";
            }));
        }
        private void CopyOrMoveFile(string sourcePath, string destPath, bool isMove)
        {
            string fileName = Path.GetFileName(sourcePath);
            string actionText = isMove ? "Moving" : "Copying";
            try
            {
                UpdateProgress($"{actionText} {fileName}...", 0);
                int lastPercent = 0;

                {
                    using FileStream SourceStream = new(sourcePath, FileMode.Open, FileAccess.Read);
                    using FileStream DestStream = new(destPath, FileMode.Create, FileAccess.Write);

                    long TotalBytes = SourceStream.Length;
                    long CopiedBytes = 0;
                    byte[] Buffer = new byte[81920];
                    int BytesRead;

                    if (TotalBytes == 0)
                    {
                        UpdateProgress($"{actionText} {fileName}...", 100);
                    }
                    else
                    {
                        while ((BytesRead = SourceStream.Read(Buffer, 0, Buffer.Length)) > 0)
                        {
                            DestStream.Write(Buffer, 0, BytesRead);
                            CopiedBytes += BytesRead;

                            int percent = (int)((CopiedBytes * 100) / TotalBytes);
                            if (percent > lastPercent)
                            {
                                lastPercent = percent;
                                UpdateProgress($"{actionText} {fileName}...", percent);
                            }
                        }
                    }
                }
                if (isMove)
                {
                    File.Delete(sourcePath);
                }
                string OpType = isMove ? "Move" : "Copy";
                UpdateProgress($"{OpType} completed", 100);
                AddLog($"({fileName}) {(isMove ? "Moved" : "Copied")}", Color.Green);
                UpdateStats(OpType);

                if (CurrentFolderPath != "This PC" && Directory.Exists(CurrentFolderPath))
                {
                    this.BeginInvoke(new Action(() => LoadDirectory(CurrentFolderPath)));
                }
            }
            catch (Exception ex)
            {
                UpdateProgress("Operation failed", 0);
                AddLog($"Error {(isMove ? "moving" : "copying")} ({fileName}): {ex.Message}", Color.Red);
            }
        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            StartSearch();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents adding a new line (textBox1 is Multiline)
                StartSearch();
            }
        }
        private void StartSearch()
        {
            string searchText = textBox1.Text.Trim();

            // If the search box is empty, restore whatever view the user is currently on
            if (string.IsNullOrEmpty(searchText))
            {
                if (CurrentFolderPath == "This PC")
                {
                    CurrentFolderPath = ViewThisPC();
                    SelectedItemPath = "";
                }
                else if (Directory.Exists(CurrentFolderPath))
                {
                    LoadDirectory(CurrentFolderPath);
                }
                return;
            }

            // Decide what paths to search: all ready drives if on "This PC", otherwise just the current folder
            string[] pathsToSearch;

            if (CurrentFolderPath == "This PC")
            {
                pathsToSearch = DriveInfo.GetDrives()
                    .Where(d => d.IsReady)
                    .Select(d => d.Name)
                    .ToArray();
            }
            else if (Directory.Exists(CurrentFolderPath))
            {
                pathsToSearch = [CurrentFolderPath];
            }
            else
            {
                MessageBox.Show("Invalid folder path.");
                return;
            }

            // Run the search on a background thread so the UI stays responsive
            RunInThread(() => SearchFiles(pathsToSearch, searchText));
        }

        private void SearchFiles(string[] pathsToSearch, string searchText)
        {
            try
            {
                UpdateProgress($"Searching for {searchText}...", 0);

                // Search all subfolders automatically and skip protected Windows/system folders
                EnumerationOptions options = new()
                {
                    RecurseSubdirectories = true,
                    IgnoreInaccessible = true,
                    MatchCasing = MatchCasing.CaseInsensitive
                };

                List<FileInfo> foundFiles = [];

                // Loop through each drive (for "This PC") or the single open folder
                for (int i = 0; i < pathsToSearch.Length; i++)
                {
                    string path = pathsToSearch[i];
                    UpdateProgress($"Searching in {path} for {searchText}...", (i * 90) / pathsToSearch.Length);

                    try
                    {
                        DirectoryInfo dir = new(path);
                        foundFiles.AddRange(dir.GetFiles($"*{searchText}*", options));
                    }
                    catch (Exception)
                    {
                        // Skip a drive/folder if it becomes unavailable mid-search
                    }

                    int percent = ((i + 1) * 90) / pathsToSearch.Length;
                    UpdateProgress($"Searching for {searchText}...", percent);
                }

                // Case 1: No matching files found anywhere
                if (foundFiles.Count == 0)
                {
                    UpdateProgress("File not found", 0);
                    AddLog($"({searchText}) File not found", Color.Red);

                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show("File not found.");
                    }));
                    return;
                }

                // Case 2: Display the matching files in the table on the UI thread
                this.BeginInvoke(new Action(() =>
                {
                    dataGridView1.Rows.Clear();
                    SelectedItemPath = "";

                    foreach (FileInfo file in foundFiles)
                    {
                        dataGridView1.Rows.Add(
                            file.Name,
                            "File",
                            Math.Round(file.Length / 1024.0, 3) + " kB",
                            file.LastWriteTime
                        );
                        // Store full path in Tag so clicking or opening the result works
                        dataGridView1.Rows[^1].Tag = file.FullName;
                    }
                }));

                UpdateProgress($"Search completed ({foundFiles.Count} found)", 100);
                AddLog($"Search ({searchText}): {foundFiles.Count} file(s) found", Color.Green);
                UpdateStats("Search");
            }
            catch (Exception ex)
            {
                UpdateProgress("Search failed", 0);
                AddLog($"Error searching ({searchText}): {ex.Message}", Color.Red);
            }
        }


    }
}

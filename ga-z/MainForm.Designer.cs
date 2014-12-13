namespace ga_z
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FolderFileList = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extention = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localarea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장소로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileImageList = new System.Windows.Forms.ImageList(this.components);
            this.FTPListview = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.types = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTParea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.다운로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Connect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.즐겨찾기 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.foler_open = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.file_download = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.file_upload = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.book_mark = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BookListview = new System.Windows.Forms.ListView();
            this.Bookarea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeImageList = new System.Windows.Forms.ImageList(this.components);
            this.userListview = new System.Windows.Forms.ListView();
            this.Userarea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.storeListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Storagearea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.업로드ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BackupListview = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.백업목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.Localarea.SuspendLayout();
            this.FTParea.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.즐겨찾기.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Bookarea.SuspendLayout();
            this.Userarea.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Storagearea.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.Controls.Add(this.FolderFileList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FTPListview, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.63636F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FolderFileList
            // 
            this.FolderFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.PathName,
            this.type,
            this.filesize,
            this.extention});
            this.FolderFileList.ContextMenuStrip = this.Localarea;
            this.FolderFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderFileList.FullRowSelect = true;
            this.FolderFileList.Location = new System.Drawing.Point(489, 3);
            this.FolderFileList.Name = "FolderFileList";
            this.FolderFileList.Size = new System.Drawing.Size(516, 257);
            this.FolderFileList.SmallImageList = this.FileImageList;
            this.FolderFileList.TabIndex = 1;
            this.FolderFileList.UseCompatibleStateImageBehavior = false;
            this.FolderFileList.View = System.Windows.Forms.View.Details;
            this.FolderFileList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderFileList_MouseDoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "이름";
            this.FileName.Width = 117;
            // 
            // PathName
            // 
            this.PathName.Text = "경로";
            this.PathName.Width = 145;
            // 
            // type
            // 
            this.type.Text = "형식";
            // 
            // filesize
            // 
            this.filesize.Text = "크기";
            this.filesize.Width = 97;
            // 
            // extention
            // 
            this.extention.Text = "확장자";
            this.extention.Width = 55;
            // 
            // Localarea
            // 
            this.Localarea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.업로드ToolStripMenuItem,
            this.저장소로저장ToolStripMenuItem});
            this.Localarea.Name = "Localarea";
            this.Localarea.Size = new System.Drawing.Size(163, 70);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 업로드ToolStripMenuItem
            // 
            this.업로드ToolStripMenuItem.Name = "업로드ToolStripMenuItem";
            this.업로드ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.업로드ToolStripMenuItem.Text = "업로드";
            this.업로드ToolStripMenuItem.Click += new System.EventHandler(this.업로드ToolStripMenuItem_Click);
            // 
            // 저장소로저장ToolStripMenuItem
            // 
            this.저장소로저장ToolStripMenuItem.Name = "저장소로저장ToolStripMenuItem";
            this.저장소로저장ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.저장소로저장ToolStripMenuItem.Text = "임시저장소 저장";
            this.저장소로저장ToolStripMenuItem.Click += new System.EventHandler(this.저장소로저장ToolStripMenuItem_Click);
            // 
            // FileImageList
            // 
            this.FileImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileImageList.ImageStream")));
            this.FileImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileImageList.Images.SetKeyName(0, "folderopened_yellow .ico");
            this.FileImageList.Images.SetKeyName(1, "document.ico");
            // 
            // FTPListview
            // 
            this.FTPListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.size,
            this.date,
            this.types});
            this.FTPListview.ContextMenuStrip = this.FTParea;
            this.FTPListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FTPListview.FullRowSelect = true;
            this.FTPListview.Location = new System.Drawing.Point(3, 3);
            this.FTPListview.Name = "FTPListview";
            this.FTPListview.Size = new System.Drawing.Size(480, 257);
            this.FTPListview.SmallImageList = this.FileImageList;
            this.FTPListview.TabIndex = 0;
            this.FTPListview.UseCompatibleStateImageBehavior = false;
            this.FTPListview.View = System.Windows.Forms.View.Details;
            this.FTPListview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FTPListview_MouseDoubleClick);
            // 
            // file
            // 
            this.file.Text = "이름";
            this.file.Width = 93;
            // 
            // size
            // 
            this.size.Text = "크기";
            this.size.Width = 90;
            // 
            // date
            // 
            this.date.Text = "수정한날짜";
            this.date.Width = 107;
            // 
            // types
            // 
            this.types.Text = "형식";
            // 
            // FTParea
            // 
            this.FTParea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem1,
            this.다운로드ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.백업목록ToolStripMenuItem});
            this.FTParea.Name = "FTParea";
            this.FTParea.Size = new System.Drawing.Size(123, 92);
            // 
            // 열기ToolStripMenuItem1
            // 
            this.열기ToolStripMenuItem1.Name = "열기ToolStripMenuItem1";
            this.열기ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.열기ToolStripMenuItem1.Text = "열기";
            // 
            // 다운로드ToolStripMenuItem
            // 
            this.다운로드ToolStripMenuItem.Name = "다운로드ToolStripMenuItem";
            this.다운로드ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.다운로드ToolStripMenuItem.Text = "다운로드";
            this.다운로드ToolStripMenuItem.Click += new System.EventHandler(this.다운로드ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(914, 3);
            this.Connect.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(65, 23);
            this.Connect.TabIndex = 16;
            this.Connect.Text = "접속";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Port
            // 
            this.Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Port.FormattingEnabled = true;
            this.Port.Items.AddRange(new object[] {
            "FTP",
            "SFTP"});
            this.Port.Location = new System.Drawing.Point(833, 3);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(68, 20);
            this.Port.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(760, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 5, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Protocol";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(588, 3);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(129, 21);
            this.Password.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(503, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 5, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(292, 3);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(158, 21);
            this.User.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(245, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(50, 5, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(55, 3);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(137, 21);
            this.Host.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Host";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.Host);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.User);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.Password);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.Port);
            this.flowLayoutPanel3.Controls.Add(this.Connect);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flowLayoutPanel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(-6, 26);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1012, 27);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // 즐겨찾기
            // 
            this.즐겨찾기.Controls.Add(this.toolStrip1);
            this.즐겨찾기.Location = new System.Drawing.Point(1, -1);
            this.즐겨찾기.Name = "즐겨찾기";
            this.즐겨찾기.Size = new System.Drawing.Size(1005, 27);
            this.즐겨찾기.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foler_open,
            this.toolStripLabel1,
            this.toolStripSeparator,
            this.file_download,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.file_upload,
            this.toolStripLabel3,
            this.toolStripSeparator2,
            this.book_mark,
            this.toolStripLabel4,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripLabel5,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // foler_open
            // 
            this.foler_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foler_open.Image = ((System.Drawing.Image)(resources.GetObject("foler_open.Image")));
            this.foler_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.foler_open.Name = "foler_open";
            this.foler_open.Size = new System.Drawing.Size(23, 22);
            this.foler_open.Tag = "";
            this.foler_open.Text = "폴더불러오기";
            this.foler_open.Click += new System.EventHandler(this.열기ToolStripButton_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "폴더불러오기";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // file_download
            // 
            this.file_download.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.file_download.Image = ((System.Drawing.Image)(resources.GetObject("file_download.Image")));
            this.file_download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_download.Name = "file_download";
            this.file_download.Size = new System.Drawing.Size(23, 22);
            this.file_download.Text = "다운로드";
            this.file_download.Click += new System.EventHandler(this.file_download_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel2.Text = "다운로드";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // file_upload
            // 
            this.file_upload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.file_upload.Image = ((System.Drawing.Image)(resources.GetObject("file_upload.Image")));
            this.file_upload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file_upload.Name = "file_upload";
            this.file_upload.Size = new System.Drawing.Size(23, 22);
            this.file_upload.Text = "업로드";
            this.file_upload.Click += new System.EventHandler(this.file_upload_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel3.Text = "업로드";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // book_mark
            // 
            this.book_mark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.book_mark.Image = ((System.Drawing.Image)(resources.GetObject("book_mark.Image")));
            this.book_mark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.book_mark.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.book_mark.Name = "book_mark";
            this.book_mark.Size = new System.Drawing.Size(23, 22);
            this.book_mark.Tag = "";
            this.book_mark.Text = "즐겨찾기";
            this.book_mark.Click += new System.EventHandler(this.book_mark_Click_1);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel4.Text = "즐겨찾기";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel5.Text = "유저추가";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.20576F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79424F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel2.Controls.Add(this.BookListview, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.userListview, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tab1, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 318);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1005, 150);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BookListview
            // 
            this.BookListview.ContextMenuStrip = this.Bookarea;
            this.BookListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookListview.LargeImageList = this.LargeImageList;
            this.BookListview.Location = new System.Drawing.Point(3, 3);
            this.BookListview.Name = "BookListview";
            this.BookListview.Size = new System.Drawing.Size(238, 144);
            this.BookListview.TabIndex = 0;
            this.BookListview.UseCompatibleStateImageBehavior = false;
            this.BookListview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookListview_MouseDoubleClick);
            // 
            // Bookarea
            // 
            this.Bookarea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem1});
            this.Bookarea.Name = "Bookarea";
            this.Bookarea.Size = new System.Drawing.Size(99, 26);
            // 
            // 삭제ToolStripMenuItem1
            // 
            this.삭제ToolStripMenuItem1.Name = "삭제ToolStripMenuItem1";
            this.삭제ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem1.Text = "삭제";
            this.삭제ToolStripMenuItem1.Click += new System.EventHandler(this.삭제ToolStripMenuItem1_Click);
            // 
            // LargeImageList
            // 
            this.LargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("LargeImageList.ImageStream")));
            this.LargeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.LargeImageList.Images.SetKeyName(0, "Double-J-Design-Ravenna-3d-Book.ico");
            this.LargeImageList.Images.SetKeyName(1, "user_male.ico");
            // 
            // userListview
            // 
            this.userListview.ContextMenuStrip = this.Userarea;
            this.userListview.LargeImageList = this.LargeImageList;
            this.userListview.Location = new System.Drawing.Point(247, 3);
            this.userListview.Name = "userListview";
            this.userListview.Size = new System.Drawing.Size(236, 144);
            this.userListview.TabIndex = 1;
            this.userListview.UseCompatibleStateImageBehavior = false;
            this.userListview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.userListview_MouseDoubleClick);
            // 
            // Userarea
            // 
            this.Userarea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제ToolStripMenuItem2});
            this.Userarea.Name = "Userarea";
            this.Userarea.Size = new System.Drawing.Size(99, 26);
            this.Userarea.Text = "Userarea";
            // 
            // 삭제ToolStripMenuItem2
            // 
            this.삭제ToolStripMenuItem2.Name = "삭제ToolStripMenuItem2";
            this.삭제ToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.삭제ToolStripMenuItem2.Text = "삭제";
            this.삭제ToolStripMenuItem2.Click += new System.EventHandler(this.삭제ToolStripMenuItem2_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(489, 3);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(513, 144);
            this.tab1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.storeListview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 118);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "임시저장소";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // storeListview
            // 
            this.storeListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.storeListview.ContextMenuStrip = this.Storagearea;
            this.storeListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.storeListview.FullRowSelect = true;
            this.storeListview.Location = new System.Drawing.Point(3, 3);
            this.storeListview.Name = "storeListview";
            this.storeListview.Size = new System.Drawing.Size(499, 112);
            this.storeListview.SmallImageList = this.FileImageList;
            this.storeListview.TabIndex = 2;
            this.storeListview.UseCompatibleStateImageBehavior = false;
            this.storeListview.View = System.Windows.Forms.View.Details;
            this.storeListview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.storeListview_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "경로";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "형식";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "크기";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "확장자";
            this.columnHeader5.Width = 55;
            // 
            // Storagearea
            // 
            this.Storagearea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem2,
            this.업로드ToolStripMenuItem1,
            this.삭제ToolStripMenuItem3});
            this.Storagearea.Name = "Storagearea";
            this.Storagearea.Size = new System.Drawing.Size(111, 70);
            // 
            // 열기ToolStripMenuItem2
            // 
            this.열기ToolStripMenuItem2.Name = "열기ToolStripMenuItem2";
            this.열기ToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.열기ToolStripMenuItem2.Text = "열기";
            this.열기ToolStripMenuItem2.Click += new System.EventHandler(this.열기ToolStripMenuItem2_Click);
            // 
            // 업로드ToolStripMenuItem1
            // 
            this.업로드ToolStripMenuItem1.Name = "업로드ToolStripMenuItem1";
            this.업로드ToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.업로드ToolStripMenuItem1.Text = "업로드";
            this.업로드ToolStripMenuItem1.Click += new System.EventHandler(this.업로드ToolStripMenuItem1_Click);
            // 
            // 삭제ToolStripMenuItem3
            // 
            this.삭제ToolStripMenuItem3.Name = "삭제ToolStripMenuItem3";
            this.삭제ToolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.삭제ToolStripMenuItem3.Text = "삭제";
            this.삭제ToolStripMenuItem3.Click += new System.EventHandler(this.삭제ToolStripMenuItem3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BackupListview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 118);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "백업저장소";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BackupListview
            // 
            this.BackupListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.BackupListview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupListview.FullRowSelect = true;
            this.BackupListview.Location = new System.Drawing.Point(3, 3);
            this.BackupListview.Name = "BackupListview";
            this.BackupListview.Size = new System.Drawing.Size(499, 112);
            this.BackupListview.SmallImageList = this.FileImageList;
            this.BackupListview.TabIndex = 0;
            this.BackupListview.UseCompatibleStateImageBehavior = false;
            this.BackupListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "이름";
            this.columnHeader6.Width = 165;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "경로";
            this.columnHeader7.Width = 153;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "업로드날짜";
            this.columnHeader8.Width = 350;
            // 
            // 백업목록ToolStripMenuItem
            // 
            this.백업목록ToolStripMenuItem.Name = "백업목록ToolStripMenuItem";
            this.백업목록ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.백업목록ToolStripMenuItem.Text = "백업목록";
            this.백업목록ToolStripMenuItem.Click += new System.EventHandler(this.백업목록ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 512);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.즐겨찾기);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "GzFTP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Localarea.ResumeLayout(false);
            this.FTParea.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.즐겨찾기.ResumeLayout(false);
            this.즐겨찾기.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Bookarea.ResumeLayout(false);
            this.Userarea.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Storagearea.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList FileImageList;
        private System.Windows.Forms.ListView FTPListview;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader types;
        private System.Windows.Forms.ContextMenuStrip Localarea;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업로드ToolStripMenuItem;
        private System.Windows.Forms.ListView FolderFileList;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader PathName;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader filesize;
        private System.Windows.Forms.ColumnHeader extention;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel 즐겨찾기;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton foler_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton file_download;
        private System.Windows.Forms.ContextMenuStrip FTParea;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 다운로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton file_upload;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView BookListview;
        private System.Windows.Forms.ListView userListview;
        private System.Windows.Forms.ToolStripButton book_mark;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList LargeImageList;
        private System.Windows.Forms.ContextMenuStrip Bookarea;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip Userarea;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem2;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView BackupListview;
        private System.Windows.Forms.ListView storeListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem 저장소로저장ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Storagearea;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 업로드ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem 백업목록ToolStripMenuItem;




    }
}


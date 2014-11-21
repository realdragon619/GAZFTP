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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FTPListview = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.types = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileImageList = new System.Windows.Forms.ImageList(this.components);
            this.FolderOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FolderFileList = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extention = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Localarea = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Localarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.08333F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.577465F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.42254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Host);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.User);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 27);
            this.flowLayoutPanel1.TabIndex = 6;
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
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(55, 3);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(137, 21);
            this.Host.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(205, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 5, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(252, 3);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(158, 21);
            this.User.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.Password);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.Port);
            this.flowLayoutPanel2.Controls.Add(this.Connect);
            this.flowLayoutPanel2.Controls.Add(this.trackBar1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(486, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(519, 27);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 5, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(95, 3);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(129, 21);
            this.Password.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(267, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 5, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Protocol";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Port
            // 
            this.Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Port.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Port.FormattingEnabled = true;
            this.Port.Items.AddRange(new object[] {
            "FTP",
            "SFTP"});
            this.Port.Location = new System.Drawing.Point(340, 3);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(68, 20);
            this.Port.TabIndex = 2;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(421, 3);
            this.Connect.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(65, 23);
            this.Connect.TabIndex = 16;
            this.Connect.Text = "접속";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 32);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 17;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FTPListview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FolderOpen);
            this.splitContainer1.Size = new System.Drawing.Size(477, 306);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 8;
            // 
            // FTPListview
            // 
            this.FTPListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.size,
            this.date,
            this.types});
            this.FTPListview.FullRowSelect = true;
            this.FTPListview.Location = new System.Drawing.Point(-3, 3);
            this.FTPListview.Name = "FTPListview";
            this.FTPListview.Size = new System.Drawing.Size(478, 160);
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
            // FileImageList
            // 
            this.FileImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileImageList.ImageStream")));
            this.FileImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileImageList.Images.SetKeyName(0, "directory.ico");
            this.FileImageList.Images.SetKeyName(1, "document.ico");
            // 
            // FolderOpen
            // 
            this.FolderOpen.Location = new System.Drawing.Point(3, 3);
            this.FolderOpen.Name = "FolderOpen";
            this.FolderOpen.Size = new System.Drawing.Size(50, 27);
            this.FolderOpen.TabIndex = 1;
            this.FolderOpen.Text = "Open";
            this.FolderOpen.UseVisualStyleBackColor = true;
            this.FolderOpen.Click += new System.EventHandler(this.FolderOpen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FolderFileList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(486, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 306);
            this.panel1.TabIndex = 9;
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
            this.FolderFileList.Location = new System.Drawing.Point(0, 0);
            this.FolderFileList.Name = "FolderFileList";
            this.FolderFileList.Size = new System.Drawing.Size(519, 306);
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
            // extention
            // 
            this.extention.Text = "확장자";
            this.extention.Width = 55;
            // 
            // Localarea
            // 
            this.Localarea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.업로드ToolStripMenuItem});
            this.Localarea.Name = "Localarea";
            this.Localarea.Size = new System.Drawing.Size(111, 48);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // 업로드ToolStripMenuItem
            // 
            this.업로드ToolStripMenuItem.Name = "업로드ToolStripMenuItem";
            this.업로드ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.업로드ToolStripMenuItem.Text = "업로드";
            this.업로드ToolStripMenuItem.Click += new System.EventHandler(this.업로드ToolStripMenuItem_Click);
            // 
            // filesize
            // 
            this.filesize.Text = "크기";
            this.filesize.Width = 97;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainFrame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Localarea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FolderOpen;
        private System.Windows.Forms.ImageList FileImageList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView FTPListview;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader types;
        private System.Windows.Forms.ComboBox Port;
        private System.Windows.Forms.ListView FolderFileList;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader PathName;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader extention;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip Localarea;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업로드ToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColumnHeader filesize;




    }
}


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
            this.FolderOpen = new System.Windows.Forms.Button();
            this.FolderFileList = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FolderFileList, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.23913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.76087F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.FolderOpen);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(296, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 27);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // FolderOpen
            // 
            this.FolderOpen.Location = new System.Drawing.Point(3, 3);
            this.FolderOpen.Name = "FolderOpen";
            this.FolderOpen.Size = new System.Drawing.Size(75, 20);
            this.FolderOpen.TabIndex = 1;
            this.FolderOpen.Text = "Open";
            this.FolderOpen.UseVisualStyleBackColor = true;
            this.FolderOpen.Click += new System.EventHandler(this.FolderOpen_Click);
            // 
            // FolderFileList
            // 
            this.FolderFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.PathName});
            this.FolderFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderFileList.FullRowSelect = true;
            this.FolderFileList.GridLines = true;
            this.FolderFileList.Location = new System.Drawing.Point(296, 36);
            this.FolderFileList.Name = "FolderFileList";
            this.FolderFileList.Size = new System.Drawing.Size(287, 329);
            this.FolderFileList.SmallImageList = this.FileImageList;
            this.FolderFileList.TabIndex = 5;
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
            // FileImageList
            // 
            this.FileImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileImageList.ImageStream")));
            this.FileImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileImageList.Images.SetKeyName(0, "directory.ico");
            this.FileImageList.Images.SetKeyName(1, "document.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainFrame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button FolderOpen;
        private System.Windows.Forms.ListView FolderFileList;
        private System.Windows.Forms.ImageList FileImageList;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader PathName;




    }
}


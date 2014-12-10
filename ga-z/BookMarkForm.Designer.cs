namespace ga_z
{
    partial class BookMarkForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search_path = new System.Windows.Forms.Button();
            this.book_submit = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "즐겨찾기 제목";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(14, 27);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(126, 21);
            this.titleBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "즐겨찾기 경로";
            // 
            // search_path
            // 
            this.search_path.Location = new System.Drawing.Point(231, 69);
            this.search_path.Name = "search_path";
            this.search_path.Size = new System.Drawing.Size(62, 23);
            this.search_path.TabIndex = 3;
            this.search_path.Text = "찾아보기";
            this.search_path.UseVisualStyleBackColor = true;
            this.search_path.Click += new System.EventHandler(this.search_path_Click);
            // 
            // book_submit
            // 
            this.book_submit.Location = new System.Drawing.Point(299, 69);
            this.book_submit.Name = "book_submit";
            this.book_submit.Size = new System.Drawing.Size(55, 23);
            this.book_submit.TabIndex = 4;
            this.book_submit.Text = "등록";
            this.book_submit.UseVisualStyleBackColor = true;
            this.book_submit.Click += new System.EventHandler(this.book_submit_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(14, 71);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(214, 21);
            this.pathBox.TabIndex = 5;
            // 
            // BookMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 108);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.book_submit);
            this.Controls.Add(this.search_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookMarkForm";
            this.ShowIcon = false;
            this.Text = "BookMarkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search_path;
        private System.Windows.Forms.Button book_submit;
        private System.Windows.Forms.TextBox pathBox;
    }
}
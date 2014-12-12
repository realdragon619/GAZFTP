namespace ga_z
{
    partial class FtpUserForm
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
            this.book_submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // book_submit
            // 
            this.book_submit.Location = new System.Drawing.Point(221, 192);
            this.book_submit.Name = "book_submit";
            this.book_submit.Size = new System.Drawing.Size(55, 23);
            this.book_submit.TabIndex = 18;
            this.book_submit.Text = "등록";
            this.book_submit.UseVisualStyleBackColor = true;
            this.book_submit.Click += new System.EventHandler(this.book_submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Protocol";
            // 
            // PortBox
            // 
            this.PortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Items.AddRange(new object[] {
            "FTP",
            "SFTP"});
            this.PortBox.Location = new System.Drawing.Point(16, 192);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(68, 20);
            this.PortBox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(16, 150);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '●';
            this.PassBox.Size = new System.Drawing.Size(170, 21);
            this.PassBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "User";
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(16, 107);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(170, 21);
            this.UserBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Host";
            // 
            // HostBox
            // 
            this.HostBox.Location = new System.Drawing.Point(16, 64);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(170, 21);
            this.HostBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "유저등록 이름";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(16, 25);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(124, 21);
            this.titleBox.TabIndex = 10;
            // 
            // FtpUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 229);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.book_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FtpUserForm";
            this.ShowIcon = false;
            this.Text = "FtpUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button book_submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleBox;
    }
}
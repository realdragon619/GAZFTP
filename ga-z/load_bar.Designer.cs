namespace ga_z
{
    partial class load_bar
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
            this.byte_bar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.byte_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // byte_bar
            // 
            this.byte_bar.Location = new System.Drawing.Point(12, 67);
            this.byte_bar.Name = "byte_bar";
            this.byte_bar.Size = new System.Drawing.Size(367, 15);
            this.byte_bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.byte_bar.TabIndex = 0;
            this.byte_bar.Tag = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // byte_label
            // 
            this.byte_label.AutoSize = true;
            this.byte_label.Location = new System.Drawing.Point(12, 52);
            this.byte_label.Name = "byte_label";
            this.byte_label.Size = new System.Drawing.Size(0, 12);
            this.byte_label.TabIndex = 1;
            // 
            // load_bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 94);
            this.Controls.Add(this.byte_label);
            this.Controls.Add(this.byte_bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "load_bar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "load_bar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.load_bar_FormClosed);
            this.Load += new System.EventHandler(this.load_bar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar byte_bar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label byte_label;
    }
}
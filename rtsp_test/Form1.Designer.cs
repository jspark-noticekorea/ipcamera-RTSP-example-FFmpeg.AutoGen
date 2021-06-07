
namespace rtsp_test
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.playButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 6);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(201, 37);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "button1";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbUrl.Location = new System.Drawing.Point(381, 11);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(911, 29);
            this.tbUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(293, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "ipcam url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label1;
    }
}


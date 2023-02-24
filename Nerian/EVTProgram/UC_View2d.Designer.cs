namespace EVTProgram
{
    partial class UC_View2d
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbDepthImage = new System.Windows.Forms.PictureBox();
            this.pbBasicImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepthImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbDepthImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbBasicImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2048, 1536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbDepthImage
            // 
            this.pbDepthImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbDepthImage.Location = new System.Drawing.Point(1024, 384);
            this.pbDepthImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbDepthImage.Name = "pbDepthImage";
            this.pbDepthImage.Size = new System.Drawing.Size(1024, 768);
            this.pbDepthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDepthImage.TabIndex = 0;
            this.pbDepthImage.TabStop = false;
            this.pbDepthImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // pbBasicImage
            // 
            this.pbBasicImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBasicImage.Location = new System.Drawing.Point(0, 384);
            this.pbBasicImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbBasicImage.Name = "pbBasicImage";
            this.pbBasicImage.Size = new System.Drawing.Size(1024, 768);
            this.pbBasicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBasicImage.TabIndex = 1;
            this.pbBasicImage.TabStop = false;
            this.pbBasicImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // UC_View2d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_View2d";
            this.Size = new System.Drawing.Size(2048, 1536);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDepthImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbBasicImage;
        private System.Windows.Forms.PictureBox pbDepthImage;
    }
}

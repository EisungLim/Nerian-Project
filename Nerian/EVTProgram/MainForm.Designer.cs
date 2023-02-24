
namespace EVTProgram
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEstablishConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb2DView = new System.Windows.Forms.ToolStripButton();
            this.tsb3DView = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbzoomIn = new System.Windows.Forms.ToolStripButton();
            this.tslzoom = new System.Windows.Forms.ToolStripLabel();
            this.tsbzoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPointCloud = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCaptureDisplaySetting = new System.Windows.Forms.ToolStripButton();
            this.tsbCaptureSingle = new System.Windows.Forms.ToolStripButton();
            this.tsbSeqence = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSendImageFolder = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.EstablishConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.CaptureAndDisplaySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.SendImagesFromFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.TmCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.TmCaptureSingleFrame = new System.Windows.Forms.ToolStripMenuItem();
            this.TmCaptureSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.TmView = new System.Windows.Forms.ToolStripMenuItem();
            this.View2d = new System.Windows.Forms.ToolStripMenuItem();
            this.View3d = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.DisplayDepthAtMouseCursor = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_View2d = new EVTProgram.UC_View2d();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEstablishConnect,
            this.toolStripSeparator1,
            this.tsb2DView,
            this.tsb3DView,
            this.toolStripSeparator2,
            this.tsbzoomIn,
            this.tslzoom,
            this.tsbzoomOut,
            this.toolStripSeparator3,
            this.tsbPointCloud,
            this.toolStripSeparator4,
            this.tsbCaptureDisplaySetting,
            this.tsbCaptureSingle,
            this.tsbSeqence,
            this.toolStripSeparator5,
            this.tsbSendImageFolder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1904, 44);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEstablishConnect
            // 
            this.tsbEstablishConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEstablishConnect.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tsbEstablishConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbEstablishConnect.Image")));
            this.tsbEstablishConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEstablishConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstablishConnect.Name = "tsbEstablishConnect";
            this.tsbEstablishConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbEstablishConnect.Size = new System.Drawing.Size(35, 41);
            this.tsbEstablishConnect.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // tsb2DView
            // 
            this.tsb2DView.BackColor = System.Drawing.SystemColors.Control;
            this.tsb2DView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsb2DView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb2DView.Image = ((System.Drawing.Image)(resources.GetObject("tsb2DView.Image")));
            this.tsb2DView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb2DView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb2DView.Name = "tsb2DView";
            this.tsb2DView.Size = new System.Drawing.Size(31, 41);
            this.tsb2DView.Text = "toolStripButton2";
            this.tsb2DView.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // tsb3DView
            // 
            this.tsb3DView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb3DView.Image = ((System.Drawing.Image)(resources.GetObject("tsb3DView.Image")));
            this.tsb3DView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb3DView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb3DView.Name = "tsb3DView";
            this.tsb3DView.Size = new System.Drawing.Size(32, 41);
            this.tsb3DView.Text = "toolStripButton3";
            this.tsb3DView.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbzoomIn
            // 
            this.tsbzoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbzoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbzoomIn.Image")));
            this.tsbzoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbzoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbzoomIn.Name = "tsbzoomIn";
            this.tsbzoomIn.Size = new System.Drawing.Size(34, 41);
            this.tsbzoomIn.Text = "toolStripButton4";
            this.tsbzoomIn.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // tslzoom
            // 
            this.tslzoom.Name = "tslzoom";
            this.tslzoom.Size = new System.Drawing.Size(38, 41);
            this.tslzoom.Text = "100%";
            // 
            // tsbzoomOut
            // 
            this.tsbzoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbzoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbzoomOut.Image")));
            this.tsbzoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbzoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbzoomOut.Name = "tsbzoomOut";
            this.tsbzoomOut.Size = new System.Drawing.Size(30, 41);
            this.tsbzoomOut.Text = "toolStripButton5";
            this.tsbzoomOut.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbPointCloud
            // 
            this.tsbPointCloud.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPointCloud.Image = ((System.Drawing.Image)(resources.GetObject("tsbPointCloud.Image")));
            this.tsbPointCloud.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPointCloud.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPointCloud.Name = "tsbPointCloud";
            this.tsbPointCloud.Size = new System.Drawing.Size(38, 41);
            this.tsbPointCloud.Text = "toolStripButton6";
            this.tsbPointCloud.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbCaptureDisplaySetting
            // 
            this.tsbCaptureDisplaySetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCaptureDisplaySetting.Image = ((System.Drawing.Image)(resources.GetObject("tsbCaptureDisplaySetting.Image")));
            this.tsbCaptureDisplaySetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCaptureDisplaySetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCaptureDisplaySetting.Name = "tsbCaptureDisplaySetting";
            this.tsbCaptureDisplaySetting.Size = new System.Drawing.Size(32, 41);
            this.tsbCaptureDisplaySetting.Text = "toolStripButton7";
            this.tsbCaptureDisplaySetting.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // tsbCaptureSingle
            // 
            this.tsbCaptureSingle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCaptureSingle.Image = global::EVTProgram.Properties.Resources.captureSingle;
            this.tsbCaptureSingle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCaptureSingle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCaptureSingle.Name = "tsbCaptureSingle";
            this.tsbCaptureSingle.Size = new System.Drawing.Size(32, 41);
            this.tsbCaptureSingle.Text = "toolStripButton8";
            this.tsbCaptureSingle.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // tsbSeqence
            // 
            this.tsbSeqence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSeqence.Image = ((System.Drawing.Image)(resources.GetObject("tsbSeqence.Image")));
            this.tsbSeqence.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSeqence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeqence.Name = "tsbSeqence";
            this.tsbSeqence.Size = new System.Drawing.Size(32, 41);
            this.tsbSeqence.Text = "toolStripButton9";
            this.tsbSeqence.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbSendImageFolder
            // 
            this.tsbSendImageFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSendImageFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendImageFolder.Image")));
            this.tsbSendImageFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSendImageFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendImageFolder.Name = "tsbSendImageFolder";
            this.tsbSendImageFolder.Size = new System.Drawing.Size(33, 41);
            this.tsbSendImageFolder.Text = "toolStripButton10";
            this.tsbSendImageFolder.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TmFile,
            this.TmCapture,
            this.TmView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TmFile
            // 
            this.TmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstablishConnection,
            this.CaptureAndDisplaySettings,
            this.SendImagesFromFolder,
            this.toolStripMenuItem1,
            this.Quit});
            this.TmFile.Name = "TmFile";
            this.TmFile.Size = new System.Drawing.Size(37, 30);
            this.TmFile.Text = "File";
            // 
            // EstablishConnection
            // 
            this.EstablishConnection.Name = "EstablishConnection";
            this.EstablishConnection.Size = new System.Drawing.Size(226, 22);
            this.EstablishConnection.Text = "Establish connection";
            this.EstablishConnection.Click += new System.EventHandler(this.ToolStripMenuItemFile_Click);
            // 
            // CaptureAndDisplaySettings
            // 
            this.CaptureAndDisplaySettings.Name = "CaptureAndDisplaySettings";
            this.CaptureAndDisplaySettings.Size = new System.Drawing.Size(226, 22);
            this.CaptureAndDisplaySettings.Text = "Capture and display settings";
            this.CaptureAndDisplaySettings.Click += new System.EventHandler(this.ToolStripMenuItemFile_Click);
            // 
            // SendImagesFromFolder
            // 
            this.SendImagesFromFolder.Name = "SendImagesFromFolder";
            this.SendImagesFromFolder.Size = new System.Drawing.Size(226, 22);
            this.SendImagesFromFolder.Text = "Send images from folder";
            this.SendImagesFromFolder.Click += new System.EventHandler(this.ToolStripMenuItemFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(226, 22);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.ToolStripMenuItemFile_Click);
            // 
            // TmCapture
            // 
            this.TmCapture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TmCaptureSingleFrame,
            this.TmCaptureSequence});
            this.TmCapture.Name = "TmCapture";
            this.TmCapture.Size = new System.Drawing.Size(61, 30);
            this.TmCapture.Text = "Capture";
            // 
            // TmCaptureSingleFrame
            // 
            this.TmCaptureSingleFrame.Name = "TmCaptureSingleFrame";
            this.TmCaptureSingleFrame.Size = new System.Drawing.Size(186, 22);
            this.TmCaptureSingleFrame.Text = "Capture single frame";
            this.TmCaptureSingleFrame.Click += new System.EventHandler(this.ToolStripMenuItemCapture_Click);
            // 
            // TmCaptureSequence
            // 
            this.TmCaptureSequence.Name = "TmCaptureSequence";
            this.TmCaptureSequence.Size = new System.Drawing.Size(186, 22);
            this.TmCaptureSequence.Text = "Capture sequence";
            this.TmCaptureSequence.Click += new System.EventHandler(this.ToolStripMenuItemCapture_Click);
            // 
            // TmView
            // 
            this.TmView.CheckOnClick = true;
            this.TmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View2d,
            this.View3d,
            this.toolStripMenuItem2,
            this.ZoomIn,
            this.ZoomOut,
            this.toolStripMenuItem3,
            this.DisplayDepthAtMouseCursor});
            this.TmView.Name = "TmView";
            this.TmView.Size = new System.Drawing.Size(49, 30);
            this.TmView.Text = "View ";
            // 
            // View2d
            // 
            this.View2d.Checked = true;
            this.View2d.CheckState = System.Windows.Forms.CheckState.Checked;
            this.View2d.Name = "View2d";
            this.View2d.Size = new System.Drawing.Size(239, 22);
            this.View2d.Text = "2D View";
            this.View2d.Click += new System.EventHandler(this.ToolStripMenuItemView_Click);
            // 
            // View3d
            // 
            this.View3d.CheckOnClick = true;
            this.View3d.Name = "View3d";
            this.View3d.Size = new System.Drawing.Size(239, 22);
            this.View3d.Text = "3D View";
            this.View3d.Click += new System.EventHandler(this.ToolStripMenuItemView_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 6);
            // 
            // ZoomIn
            // 
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(239, 22);
            this.ZoomIn.Text = "Zoom in";
            this.ZoomIn.Click += new System.EventHandler(this.ToolStripMenuItemView_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(239, 22);
            this.ZoomOut.Text = "Zoom out";
            this.ZoomOut.Click += new System.EventHandler(this.ToolStripMenuItemView_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(236, 6);
            // 
            // DisplayDepthAtMouseCursor
            // 
            this.DisplayDepthAtMouseCursor.Name = "DisplayDepthAtMouseCursor";
            this.DisplayDepthAtMouseCursor.Size = new System.Drawing.Size(239, 22);
            this.DisplayDepthAtMouseCursor.Text = "Display depth at mouse cursor";
            this.DisplayDepthAtMouseCursor.Click += new System.EventHandler(this.ToolStripMenuItemView_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.26609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.226705F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.00961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.428514F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.uC_View2d);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 937);
            this.panel1.TabIndex = 2;
            // 
            // uC_View2d
            // 
            this.uC_View2d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_View2d.Location = new System.Drawing.Point(0, 0);
            this.uC_View2d.Name = "uC_View2d";
            this.uC_View2d.OnCapture = false;
            this.uC_View2d.Size = new System.Drawing.Size(1904, 937);
            this.uC_View2d.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VNC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TmFile;
        private System.Windows.Forms.ToolStripMenuItem EstablishConnection;
        private System.Windows.Forms.ToolStripMenuItem CaptureAndDisplaySettings;
        private System.Windows.Forms.ToolStripMenuItem SendImagesFromFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem TmCapture;
        private System.Windows.Forms.ToolStripMenuItem TmCaptureSingleFrame;
        private System.Windows.Forms.ToolStripMenuItem TmCaptureSequence;
        private System.Windows.Forms.ToolStripMenuItem TmView;
        private System.Windows.Forms.ToolStripMenuItem View2d;
        private System.Windows.Forms.ToolStripMenuItem View3d;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ZoomIn;
        private System.Windows.Forms.ToolStripMenuItem ZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem DisplayDepthAtMouseCursor;
        private System.Windows.Forms.ToolStripButton tsbEstablishConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb2DView;
        private System.Windows.Forms.ToolStripButton tsb3DView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbzoomIn;
        private System.Windows.Forms.ToolStripLabel tslzoom;
        private System.Windows.Forms.ToolStripButton tsbzoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbPointCloud;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbCaptureDisplaySetting;
        private System.Windows.Forms.ToolStripButton tsbCaptureSingle;
        private System.Windows.Forms.ToolStripButton tsbSeqence;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSendImageFolder;
        private System.Windows.Forms.Panel panel1;
        private UC_View2d uC_View2d;
    }
}


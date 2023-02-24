namespace EVTProgram
{
    partial class CaptureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbCaptureBasic = new System.Windows.Forms.PictureBox();
            this.pbCaptureDepth = new System.Windows.Forms.PictureBox();
            this.btnNewCapture = new System.Windows.Forms.Button();
            this.btnSaveCapture = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSaveCapture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbCaptureBasic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbCaptureDepth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNewCapture, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbCaptureBasic
            // 
            this.pbCaptureBasic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbCaptureBasic.Location = new System.Drawing.Point(6, 67);
            this.pbCaptureBasic.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pbCaptureBasic.Name = "pbCaptureBasic";
            this.pbCaptureBasic.Size = new System.Drawing.Size(394, 360);
            this.pbCaptureBasic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCaptureBasic.TabIndex = 0;
            this.pbCaptureBasic.TabStop = false;
            // 
            // pbCaptureDepth
            // 
            this.pbCaptureDepth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbCaptureDepth.Location = new System.Drawing.Point(400, 67);
            this.pbCaptureDepth.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pbCaptureDepth.Name = "pbCaptureDepth";
            this.pbCaptureDepth.Size = new System.Drawing.Size(394, 360);
            this.pbCaptureDepth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCaptureDepth.TabIndex = 1;
            this.pbCaptureDepth.TabStop = false;
            // 
            // btnNewCapture
            // 
            this.btnNewCapture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewCapture.Location = new System.Drawing.Point(0, 0);
            this.btnNewCapture.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnNewCapture.Name = "btnNewCapture";
            this.btnNewCapture.Size = new System.Drawing.Size(400, 37);
            this.btnNewCapture.TabIndex = 2;
            this.btnNewCapture.Text = "새로만들기";
            this.btnNewCapture.UseVisualStyleBackColor = true;
            this.btnNewCapture.Click += new System.EventHandler(this.btnNewCapture_Click);
            // 
            // btnSaveCapture
            // 
            this.btnSaveCapture.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveCapture.Location = new System.Drawing.Point(400, 0);
            this.btnSaveCapture.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnSaveCapture.Name = "btnSaveCapture";
            this.btnSaveCapture.Size = new System.Drawing.Size(400, 37);
            this.btnSaveCapture.TabIndex = 3;
            this.btnSaveCapture.Text = "저장하기";
            this.btnSaveCapture.UseVisualStyleBackColor = true;
            this.btnSaveCapture.Click += new System.EventHandler(this.btnSaveCapture_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CaptureForm";
            this.Text = "CaptureForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptureDepth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbCaptureDepth;
        private System.Windows.Forms.PictureBox pbCaptureBasic;
        private System.Windows.Forms.Button btnSaveCapture;
        private System.Windows.Forms.Button btnNewCapture;
    }
}
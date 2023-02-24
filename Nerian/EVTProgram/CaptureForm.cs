using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVTProgram
{
    public partial class CaptureForm : Form
    {        
        public EventHandler CaptureHandler;        

        public CaptureForm(Image bagicimg, Image depthimg)
        {
            InitializeComponent();
                        
            this.Width  = bagicimg.Width  * 2;
            this.Height = bagicimg.Height * 2;
            pbCaptureBasic.Image = bagicimg;
            pbCaptureDepth.Image = depthimg;            
        }
                
        /// <summary>
        /// 새로만들기
        /// </summary>        
        private void btnNewCapture_Click(object sender, EventArgs e)
        {
            CaptureHandler(sender, null);
            this.Close();            
        }

        /// <summary>
        /// 저장하기
        /// </summary>        
        private void btnSaveCapture_Click(object sender, EventArgs e)
        {
            CaptureHandler(sender, null);
            this.Close();
        }
    }
}

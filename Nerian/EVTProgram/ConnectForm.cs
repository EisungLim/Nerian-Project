using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace EVTProgram
{
    public partial class ConnectForm : Form
    {
        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetCameraInfo();

        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern int main();

        public delegate void MyViewHandler();
        public event MyViewHandler ViewChangedHandler;
        public event MyViewHandler PointCloudChangeHandler;

        private List<CameraModel> CameraList;        
        public ConnectForm()
        {
            InitializeComponent();         
            CameraList = new List<CameraModel>();
            //main();
        }

        // TODO : CameraModel 추가시키는 로직 다른 반복문을 통해 바꿀수 있으면 좋겠음. 개인적으로 맘에 안듬.
        private void ConnectForm_Load(object sender, EventArgs e)
        {
            
            IntPtr CharData   = GetCameraInfo();            
            string CameraSpec = Marshal.PtrToStringAnsi(CharData);
            string[] StrArray = CameraSpec.Split('/');
            
            CameraList.Add(new CameraModel(StrArray[0], 
                                           StrArray[1], 
                                           StrArray[2], 
                                           StrArray[3], 
                                           StrArray[4]));

            bsCameraModel.DataSource = CameraList;
        }

        /// <summary>
        /// 카메라 연결폼 제어 버튼
        /// </summary>        
        private void ConnectFormControlBtn_Click(object sender, EventArgs e)
        {            
            if (sender is Button ControlButton)
            {
                switch (ControlButton.Name)
                {
                    case "btnConnect"  :
                        ViewChangedHandler();
                        PointCloudChangeHandler();
                        Close();                 
                        break;
                    case "btnConfigure": Process.Start("http://192.168.10.10/status/");  break;
                    case "btnCancel"   : Close();                                        break;
                }
            }
        }
    }
}

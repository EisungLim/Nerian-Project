using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Interop;
using System.Windows.Input;
using Excel = Microsoft.Office.Interop.Excel;
using Emgu.CV.Structure;
using System.Security.Cryptography;
using System.Windows.Media;
using System.Drawing.Text;
using System.Net.NetworkInformation;
using System.Reflection;

namespace EVTProgram
{
    // 3가지 -> 포인트 클라우드 추출 핵심 
    // 1. 랙티피케이션  : 이미지 평면을 양쪽  카메라의 중심 사이의 선과 평행한 공통 평면으로 조정하는 프로세스를 말한다.
    // 2. 스테레오 매칭 : 왼쪽과 오른쪽 이미지 사이에 픽셀을 일치시켜주는 과정을 스테레오 매칭이라 하고, Disparity Map 이미지를 생성한다. 
    // 2. 삼각측량 : 두 이미지에 투영된 공간의 점을 결정하는 과정을 말한다. Disparity Map 이미지는 3D포인트 클라우드로 변환한다.
    public partial class UC_View2d : UserControl
    {
        // 기본 이미지 획득
        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetView_BasicImageView();

        // 깊이 이미지 획득 
        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetView_DepthImageView();

        // 클라우드 포인트 시각화 획득
        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetView_PointCloudView();

        // 포인트 클라우드 출력 및 포인트 클라우드 데이터 획득
        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern int GetPointCloud(float[] pointX, float[] pointY, float[] pointZ, int length, int startpX, int startpY, int imageW, int imageH);

        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]        
        private static extern IntPtr mouseEventOccured(int x, int y);

        [DllImport("EVTEngine", CallingConvention = CallingConvention.Cdecl)]
        private static extern int getLength(int len);

        private DateTime  date = DateTime.Now;
        private Rectangle rectangle;
        private Rectangle subArea;

        private ToolTip tooltip;
        private CaptureForm captureForm;

        public Thread threadDepthImage;         // 원본 이미지 및 깊이 이미지 송출 스레드 
        public Thread threadCloudImage;         // 포인트 클라우드 시각화 이미지 송출 스레드
        //public Thread threadPointCloud;           
        //public Thread threadMousePoint;         

        public Bitmap basicImage;               // 원본 이미지
        public Bitmap depthImage;               // 원본 깊이 이미지
        public Bitmap crop_basicImage;          // 부분 이미지 
        public Bitmap crop_depthImage;          // 부분 깊이 이미지 
       
        // 버튼을 눌렀을 때 받기 위한 변수 
        public bool viewers;                    // 화면 표출 부울 함수
        public bool pointer;                    // 클라우드 포인트 부울 함수
        private bool capture;                    // 화면 캡쳐 부울 함수                

        private int parsingX;
        private int parsingY;        

        public float[] targetData;

        private List<VectorModel> pointCloudList;
        public int size = 0;
        public int PCL_Length = 0;
        //public const double NAN_DATA = -431602080;
        
        public float[] PCL_X  = new float[1024 * 768]; 
        public float[] PCL_Y  = new float[1024 * 768]; 
        public float[] PCL_Z  = new float[1024 * 768];
             
        private string path = "C:\\Users\\admin\\OneDrive\\바탕 화면\\Nerian";

        public bool OnCapture
        {
            get => capture;
            set
            {
                capture = value;
                OnCaptureChanged?.Invoke(this, null);
            }
        }

        public event EventHandler OnCaptureChanged;

        /// <summary>
        /// TODO : 
        /// 1. 캡처 버튼 이미지 변경 - 2023-02-23
        /// 2. 화면 송출 속도 증가 
        /// 3. SD(z) 거리 추출 
        /// 4. z축 영역 자르기         
        /// 5. 줌 기능 구현 
        /// 6. 깊이 이미지 출력 및 시각화 
        /// 7. 예외 처리 및 구조화 작업 
        /// </summary>

        public UC_View2d()
        {            
            InitializeComponent();          
            //base.SetStyle(ControlStyles.UserPaint, true);
            //base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //base.SetStyle(ControlStyles.DoubleBuffer, true);
            //base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //base.SetStyle(ControlStyles.EnableNotifyMessage, true);
            //base.SetStyle(ControlStyles.ResizeRedraw, true);
            //base.UpdateStyles();
            tooltip = new ToolTip();            
        }

        public void Thread_ViewStart(bool connect)
        {
            if (connect)
            {
                threadDepthImage = new Thread(Thread_BasicAndDepthView);
                threadDepthImage.Start();
            }
            else
            {
                threadCloudImage = new Thread(Thread_PointCloudView);
                threadCloudImage.Start();
            }
        }


        public void Thread_PointCloudView()
        {
            GetView_PointCloudView();            
        }
                    
        public void Thread_BasicAndDepthView()
        {
            while (viewers)
            {                
                Thread.Sleep(20);
                
                IntPtr get_depthImage = GetView_DepthImageView();
                IntPtr get_basicImage = GetView_BasicImageView();

                byte[] RByte = new byte[1024 * 768 * 4];
                byte[] LByte = new byte[1024 * 768 * 3];

                Marshal.Copy(get_depthImage, RByte, 0, RByte.Length);
                Marshal.Copy(get_basicImage, LByte, 0, LByte.Length);
                Marshal.FreeHGlobal(get_depthImage);
                Marshal.FreeHGlobal(get_basicImage);
                
                GCHandle RHandler = GCHandle.Alloc(RByte, GCHandleType.Pinned); 
                GCHandle LHandler = GCHandle.Alloc(LByte, GCHandleType.Pinned);

                this.depthImage = new Bitmap(1024, 768, 1024 * 4, System.Drawing.Imaging.PixelFormat.Format32bppRgb, RHandler.AddrOfPinnedObject());
                this.basicImage = new Bitmap(1024, 768, 1024 * 3, System.Drawing.Imaging.PixelFormat.Format24bppRgb, LHandler.AddrOfPinnedObject());

                //byte[] test = RByte.Where((x, i) => i % 4 != 3).ToArray();
                //rightimage = new Bitmap(1024, 768, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                //System.Drawing.Imaging.BitmapData data = rightimage.LockBits(
                //    new Rectangle(0, 0, 1024, 768),
                //    ImageLockMode.ReadWrite,
                //    System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                //IntPtr ptr = data.Scan0;
                //Marshal.Copy(test, 0, ptr, test.Length);
                //rightimage.UnlockBits(data);

                Mat L_screen = BitmapConverter.ToMat(this.basicImage);
                Mat L_destination = new Mat();
                Mat R_screen = BitmapConverter.ToMat(this.depthImage);
                Mat R_destination = new Mat(R_screen.Size(), MatType.CV_8UC1);
                Cv2.CvtColor(L_screen, L_destination, ColorConversionCodes.RGB2BGR);
                Cv2.CvtColor(R_screen, R_destination, ColorConversionCodes.BGR2GRAY);

                this.basicImage = BitmapConverter.ToBitmap(L_destination);
                this.depthImage = BitmapConverter.ToBitmap(R_destination);
                            
                if (capture)
                {                                     
                    object _captrueLock = new object();
                    if (MessageBox.Show("Do you want to capture only a partial area?", "Captrue Type", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Monitor.TryEnter(_captrueLock))
                        {
                            //부분영역 캡처
                            pbDepthImage.MouseDown += PictureBox_MouseDown;
                            pbDepthImage.MouseMove += PictureBox_MouseMove;
                            pbDepthImage.Paint     += PictureBox_Paint;
                            pbDepthImage.MouseUp   += PictureBox_MouseUp;
                            Monitor.Exit(_captrueLock);
                        }
                    }
                    else
                    {                        
                        // 전체 영역 캡처 
                        ImageSave(date, basicImage, depthImage);                                                 
                        size = GetPointCloud(PCL_X, PCL_Y, PCL_Z, PCL_Length, 0, 0, depthImage.Width, depthImage.Height);
                        PCLExcelSaveFile(date, size);
                    }                                              
                }

                capture = false;
                pbDepthImage.Image = this.depthImage;
                pbBasicImage.Image = this.basicImage;

                RHandler.Free();
                LHandler.Free();                          
            }
        }


        private void PictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {         
            rectangle.X      = e.X;
            rectangle.Y      = e.Y;
            rectangle.Width  = 0;
            rectangle.Height = 0;
            Invalidate();          
        }

        
        object _lock = new object();
        private void PictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {            
            if (sender is PictureBox pb)
            {
                if (pointer)
                {
                    if ((pb.Image != null))
                    {
                        this.Invoke(new Action(() =>
                        {
                            parsingX = e.X * (pb.Image.Width  / pb.Width);
                            parsingY = e.Y * (pb.Image.Height / pb.Height);
                        }));
                        Task.Run(() =>
                        {
                            if (Monitor.TryEnter(_lock))
                            {                                
                                IntPtr tagetAddress = mouseEventOccured(parsingX, parsingY);                                
                                targetData = new float[4];                                
                                Marshal.Copy(tagetAddress, targetData, 0, targetData.Length);                               
                                Marshal.FreeHGlobal(tagetAddress);
                                this.Invoke(new Action(() =>
                                {                                    
                                    if (!(float.IsInfinity(targetData[0]) && float.IsInfinity(targetData[1]) && float.IsInfinity(targetData[2])))                                    
                                    {
                                        string text = $"x = {targetData[0]}, y={targetData[1]}, z={targetData[2]}, SD(z)={targetData[3]}";                                        
                                        tooltip.SetToolTip(pbDepthImage, text);
                                    }
                                }));
                                                                                            
                                Monitor.Exit(_lock);                                                                
                            }
                        });
                    }
                }
            }
            
            if (e.Button == MouseButtons.Left)
            {                
                rectangle.Width  = e.X - rectangle.X;
                rectangle.Height = e.Y - rectangle.Y;
                Invalidate();
            }
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {            
            subArea = new Rectangle();
            
            // 1사분면
            if (rectangle.Width < 0 && rectangle.Height < 0)
            {                
                subArea.X = rectangle.X + rectangle.Width ; 
                subArea.Y = rectangle.Y + rectangle.Height;                 
                subArea.Width  = -rectangle.Width ;
                subArea.Height = -rectangle.Height;                
            }
            // 2사분면 
            else if (rectangle.Width > 0 && rectangle.Height < 0)
            {               
                subArea.X = rectangle.X;
                subArea.Y = rectangle.Y + rectangle.Height;
                subArea.Width  =  rectangle.Width;
                subArea.Height = -rectangle.Height;
            }
            // 3사분면 
            else if (rectangle.Width > 0 && rectangle.Height > 0)
            {
                subArea.X = rectangle.X;
                subArea.Y = rectangle.Y;
                subArea.Width  = rectangle.Width;
                subArea.Height = rectangle.Height;                
            }
            // 4사분면
            else if (rectangle.Width < 0 && rectangle.Height > 0)
            {
                subArea.X = rectangle.X + rectangle.Width;
                subArea.Y = rectangle.Y;
                subArea.Width  = -rectangle.Width;
                subArea.Height =  rectangle.Height;
            }

            // 사각형 영역이 그림상자 외부로 나가는 것을 방지
            if (subArea.X < 0)
            {
                subArea.Width = subArea.Width + subArea.X;
                subArea.X = 0;
            }
            else
            {
                if (subArea.Width > (pbDepthImage.Width - subArea.X))
                {
                    subArea.Width = (pbDepthImage.Width - subArea.X - 1);
                }
            }
            
            if (subArea.Y < 0)
            {
                subArea.Height = subArea.Height + subArea.Y;
                subArea.Y = 0;
            }
            else
            {
                if (subArea.Height > (pbDepthImage.Height - subArea.Y))
                {
                    subArea.Height = (pbDepthImage.Height - subArea.Y - 1);
                }
            }
            
            e.Graphics.DrawRectangle(Pens.Red, subArea);
        }

        private void PictureBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {            
            crop_basicImage = new Bitmap(basicImage);
            crop_depthImage = new Bitmap(depthImage);
            
            if (subArea.Width > 0 && subArea.Height > 0)
            {
                crop_basicImage = crop_basicImage.Clone(new Rectangle(subArea.X, subArea.Y, subArea.Width, subArea.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                crop_depthImage = crop_depthImage.Clone(new Rectangle(subArea.X, subArea.Y, subArea.Width, subArea.Height), System.Drawing.Imaging.PixelFormat.DontCare);
                
                captureForm = new CaptureForm(crop_basicImage, crop_depthImage);
                captureForm.CaptureHandler += CaptureSystem;
                captureForm.FormClosed += CaptureForm_FormClosed;                
                captureForm.ShowDialog();                                           
            }                        
        }

        // 캡쳐 박스 생성 및 저장
        private void CaptureSystem(object sender, EventArgs e)
        {            
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "btnSaveCapture":
                        if (MessageBox.Show("Do you want to save a specific area?", "Captrue Area?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ImageSave(date, crop_basicImage, crop_depthImage);
                            size = GetPointCloud(PCL_X, PCL_Y, PCL_Z, PCL_Length, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
                            PCLExcelSaveFile(date, size);

                            crop_basicImage.Dispose();
                            crop_depthImage.Dispose();
                            MessageBox.Show("저장이 완료되었습니다.");                            
                        }
                        break;
                    case "btnNewCapture":                        
                        rectangle = new Rectangle();
                        pbDepthImage.MouseDown += PictureBox_MouseDown;
                        pbDepthImage.MouseMove += PictureBox_MouseMove;
                        pbDepthImage.Paint     += PictureBox_Paint;
                        pbDepthImage.MouseUp   += PictureBox_MouseUp;                                                                   
                        break;
                }
            }            
        }


        // 캡처 창이 종료될때 
        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {            
            rectangle = new Rectangle();
            pbDepthImage.MouseDown -= PictureBox_MouseDown;
            pbDepthImage.MouseMove -= PictureBox_MouseMove;
            pbDepthImage.Paint     -= PictureBox_Paint;
            pbDepthImage.MouseUp   -= PictureBox_MouseUp;
            OnCapture = false;            
        }

        private void ImageSave(DateTime date, Image basicImage, Image depthImage)
        {
            if ((basicImage != null) && (depthImage != null))
            {              
                string basicFileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-fff}_basicImage", date);
                string depthFileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-fff}_depthImage", date);

                if (Directory.Exists(path))
                {
                    this.Invoke(new Action(() =>
                    {
                        basicImage.Save(path + "\\" + basicFileName + ".png");
                        depthImage.Save(path + "\\" + depthFileName + ".png");                        
                    }));
                }
                else
                {
                    MessageBox.Show("Not Directory"); 
                }
            }
        }

        private void PCLExcelSaveFile(DateTime date, int areaSize)
        {
            pointCloudList = new List<VectorModel>();
            pointCloudList.Clear();
            
            for (int i = 0; i < areaSize; i++)
            {
                pointCloudList.Add(new VectorModel(PCL_X[i], PCL_Y[i], PCL_Z[i]));
            }

            string excelpath = Path.Combine(path, string.Format("{0:yyyy-MM-dd_hh-mm-ss-fff}_PCL.csv", date));   
            
            using(StreamWriter file = new StreamWriter(excelpath))
            {
                file.WriteLine("PCL X, PCL Y, PCL Z");

                for (int i = 0; i < areaSize; i++)
                {
                    file.WriteLine($"{PCL_X[i]},{PCL_Y[i]},{PCL_Z[i]}");
                }
            }                  
        }

        #region 줌 기능 미구현 상태 
        public void ZoomChange(int pre_value, int cur_value)
        {
            if (pre_value < cur_value && cur_value != 0)
            {
                pbBasicImage.Width  = pbBasicImage.Width  * (cur_value / 100);
                pbBasicImage.Height = pbBasicImage.Height * (cur_value / 100);
            }
            else
            {
                pbBasicImage.Width  = pbBasicImage.Width  / (cur_value / 100);
                pbBasicImage.Height = pbBasicImage.Height / (cur_value / 100);
            }
        }
        #endregion
    }
}


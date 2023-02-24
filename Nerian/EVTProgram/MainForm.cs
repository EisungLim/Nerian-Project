using Microsoft.WindowsAPICodePack.Dialogs;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace EVTProgram
{    
    public partial class MainForm : Form
    {
        private ConnectForm connectForm;
        private int ZoomPercent;
        
        public MainForm()
        {            
            InitializeComponent();
            uC_View2d.OnCaptureChanged += UC_View2d_OnCaptureChanged;
        }
        private void UC_View2d_OnCaptureChanged(object sender, EventArgs e)
        {            
            this.Invoke(new Action(() =>
            {
                tsbCaptureSingle.Image = uC_View2d.OnCapture ? Properties.Resources.captureSingleClick : Properties.Resources.captureSingle;                
            }));
        }

        /// <summary>
        /// 깊이 이미지 OR 포인트 클라우드 이미지 표출 셋팅
        /// </summary>
        public void ViewSetting()
        {
            View2d.Checked = Properties.Settings.Default.View_2D;
            View3d.Checked = Properties.Settings.Default.View_3D;            

            if (View2d.Checked == true)
            {                
                tsb2DView.Image = Properties.Resources._2DViewClick; 
                tsb3DView.Image = Properties.Resources._3DView; 
                uC_View2d.Visible     = true;
                uC_View2d.viewers = true;                         
                uC_View2d.Thread_ViewStart(uC_View2d.viewers);
            }

            if (View3d.Checked == true)
            {                
                tsb2DView.Image = Properties.Resources._2DView;      
                tsb3DView.Image = Properties.Resources._3DViewClick; 
                uC_View2d.Visible = false;
                uC_View2d.viewers = false;
                uC_View2d.Thread_ViewStart(uC_View2d.viewers);                
            }
        }

        #region 미구현 상태 : 이미지 상태에서 줌 인 / 아웃 기능 
        public void ZoomSetting()
        {
            ZoomPercent = Properties.Settings.Default.ZoomPercent;
            tslzoom.Text = ZoomPercent.ToString() + "%";
            //uC_View2d.ZoomChange(ZoomPercent);
        }
        #endregion

        /// <summary>
        /// 포인트 클라우드 표출
        /// </summary>
        public void PointCloudSetting()
        {
            DisplayDepthAtMouseCursor.Checked = Properties.Settings.Default.Display_depth_at_Mouse_cursor;

            if (DisplayDepthAtMouseCursor.Checked == true)
            {                
                tsbPointCloud.Image = Properties.Resources.cloudPointClick;
                uC_View2d.pointer = true;                              
            }
            else
            {
                tsbPointCloud.Image = Properties.Resources.cloudPoint;
                uC_View2d.pointer = false;                
            }
        }
        

        private void SaveViewSettingValue()
        {
            Properties.Settings.Default.View_2D = View2d.Checked;
            Properties.Settings.Default.View_3D = View3d.Checked;
            Properties.Settings.Default.Save();
        }

        #region - zoom 셋팅 값 저장 함수(미구현)
        private void SaveZoomSettingValue()
        {
            string[] getPercent = tslzoom.Text.ToString().Split('%');
            ZoomPercent = Int32.Parse(getPercent[0]);
            Properties.Settings.Default.ZoomPercent = ZoomPercent;
            Properties.Settings.Default.Save();
        }
        #endregion

        private void SavePointCloudSettingValue()
        {
            Properties.Settings.Default.Display_depth_at_Mouse_cursor = DisplayDepthAtMouseCursor.Checked;
            Properties.Settings.Default.Save();
        }


        private void ViewChangeSqence(string viewname)
        {
            if      ((viewname == "View2d") || (viewname == "tsb2DView")) { if (View3d.Checked == true) { View3d.Checked = false; } View2d.Checked = true;}
            else if ((viewname == "View3d") || (viewname == "tsb3DView")) { if (View2d.Checked == true) { View2d.Checked = false; } View3d.Checked = true;}            
            SaveViewSettingValue();
            ViewSetting();
        }

        #region zoom 시퀀스(미구현)
        private void ZoomChangeSqence(string zoomname)
        {           
            if(((zoomname == "zoomIn" ) || (zoomname == "tsbzoomIn" )) && ZoomPercent < 100) 
            {                
                ZoomPercent += 20; 
                tslzoom.Text = ZoomPercent.ToString() + "%";
                uC_View2d.ZoomChange(Properties.Settings.Default.ZoomPercent, ZoomPercent);
            }
            else if (((zoomname == "zoomOut") || (zoomname == "tsbzoomOut")) && ZoomPercent > 0) 
            {
                ZoomPercent -= 20;
                tslzoom.Text = ZoomPercent.ToString() + "%";
                uC_View2d.ZoomChange(Properties.Settings.Default.ZoomPercent, ZoomPercent);
            }
            SaveZoomSettingValue();
            ZoomSetting();
        }
        #endregion

        private void PointCloudChangeSqence(string PointCloudName)
        {
            if ((PointCloudName == "tsbPointCloud") || (PointCloudName == "DisplayDepthAtMouseCursor"))
            {
                if (DisplayDepthAtMouseCursor.Checked == false) 
                {
                    DisplayDepthAtMouseCursor.Checked = true;                    
                } 
                else 
                { 
                    DisplayDepthAtMouseCursor.Checked = false;
                }
            }
            SavePointCloudSettingValue();
            PointCloudSetting();
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {            
            CreateConnectForm();            
            ZoomPercent = Properties.Settings.Default.ZoomPercent;
            tslzoom.Text = ZoomPercent.ToString() + "%";
            //uC_View2d.receivePCL = true;
            //uC_View2d.PLCThread();
            //ZoomSetting();
            //test();
        }


        /// <summary>
        /// 카메라 연결 폼 생성 함수
        /// </summary>
        private void CreateConnectForm()
        {
            connectForm = new ConnectForm();            
            connectForm.ViewChangedHandler      += ViewSetting;            
            connectForm.PointCloudChangeHandler += PointCloudSetting;
            // 추가 포인트 클라우드 
            this.TopLevel = connectForm.TopLevel;
            connectForm.ShowDialog();
            //uC_View2d.StartCloudPointerView(uC_View2d.pointer);
        }

        /// <summary>
        /// 파일 관련 자식
        /// </summary>        
        private void ToolStripMenuItemFile_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem MenuItemFile)
            {
                switch (MenuItemFile.Name)
                {
                    case "EstablishConnection"       : CreateConnectForm(); break;                        
                    case "CaptureAndDisplaySettings" : break;
                    case "SendImagesFromFolder"      : break;
                    case "Quit":                    
                        Application.Exit();                        
                        break;
                }
            }
        }


        /// <summary>
        /// 캡쳐 관련 자식
        /// </summary>        
        private void ToolStripMenuItemCapture_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem MenuItemCapture)
            {
                switch (MenuItemCapture.Name)
                {
                    case "CaptureSingleFrame" : break;
                    case "CaptureSequence"    : break;                    
                }
            }
        }

        /// <summary>
        /// 뷰 관련 자식
        /// </summary>        
        private void ToolStripMenuItemView_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem MenuItemView)
            {
                switch (MenuItemView.Name)
                {
                    case "View2d" : ViewChangeSqence(MenuItemView.Name);  break;     
                    case "View3d" : ViewChangeSqence(MenuItemView.Name);  break;
                    case "ZoomIn" : ZoomChangeSqence(MenuItemView.Name);  break;
                    case "ZoomOut": ZoomChangeSqence(MenuItemView.Name);  break;
                    case "DisplayDepthAtMouseCursor":
                        PointCloudChangeSqence(MenuItemView.Name); 
                        break;
                }
            }
        }

        /// <summary>
        /// 툴바 메뉴 버튼 
        /// </summary>        
        private void toolStripButton_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripButton btn)
            {
                switch (btn.Name)
                { 
                    case "tsbEstablishConnect"      :  CreateConnectForm();               break;
                    case "tsb2DView"                :  ViewChangeSqence(btn.Name);        break;
                    case "tsb3DView"                :  ViewChangeSqence(btn.Name);        break;
                    case "tsbzoomIn"                :  ZoomChangeSqence(btn.Name);        break;
                    case "tsbzoomOut"               :  ZoomChangeSqence(btn.Name);        break;
                    case "tsbPointCloud"            :  PointCloudChangeSqence(btn.Name);  break;
                    case "tsbCaptureDisplaySetting" :                                     break;
                    case "tsbCaptureSingle"         :  uC_View2d.OnCapture = true;        break;
                    case "tsbSeqence":                                                    break;
                    case "tsbSendImageFolder":     
                        CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
                        commonOpenFileDialog.IsFolderPicker = true;
                        if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
                        {
                            string select = commonOpenFileDialog.FileName;
                        }                        
                        break;
                }
            }
        }
      
    }
}

#include "pch.h"


#define _USE_MATH_DEFINES

#ifdef _MSC_VER
// Visual studio does not come with snprintf
#define snprintf _snprintf_s
#endif

using namespace visiontransfer;
open3d::geometry::AxisAlignedBoundingBox bbox(Eigen::Vector3d(-10, -10, 0), Eigen::Vector3d(10, 10, 5));

// TODO : 1. AxisAlignedBoundingBox ���� PointCloud �ð�ȭ ��� ã�ƺ���.(�ڵ� ����)
extern "C" _declspec(dllexport) int GetView_PointCloudView() {

    try {
        bool displayPointcloud = true;

        if (devices.size() == 0) {
            std::cout << "No devices discovered!" << std::endl;
            return -1;
        }
                        
        ImageTransfer imageTransfer(devices[0]);
        //imageTransfer(devices[0]);
        // Initialize objects that will be needed later
        ImageSet image;
 /*       Reconstruct3D recon3d;*/
        Reconstruct3D recon3d;
        open3d::geometry::AxisAlignedBoundingBox bbox(Eigen::Vector3d(-10, -10, 0), Eigen::Vector3d(10, 10, 5));
        std::shared_ptr<open3d::geometry::PointCloud> cloud(new open3d::geometry::PointCloud);
        std::shared_ptr<open3d::geometry::RGBDImage> rgbdImage(new open3d::geometry::RGBDImage);
        std::shared_ptr<open3d::geometry::RGBDImage> rgbdImage2(new open3d::geometry::RGBDImage);
        open3d::camera::PinholeCameraIntrinsic camera(open3d::camera::PinholeCameraIntrinsicParameters::PrimeSenseDefault);                
    /*    (*rgbdImage) = *recon3d.createOpen3DImageRGBD(image);*/
        //camera.SetIntrinsics(1024, 768, camera.GetFocalLength().first, camera.GetFocalLength().second, camera.GetPrincipalPoint().first, camera.GetPrincipalPoint().second);        
                               
        //https://goodgodgd.github.io/ian-flow/archivers/open3d-tutorial#d-visualize-point-cloud        
        //open3d::visualization::DrawGeometries({ &((*pointCloud).points) }, "point cloud");
        //Start viewing                       
        open3d::visualization::Visualizer vis;                 
        vis.CreateVisualizerWindow("Nerian 3D viewer", 1024, 768);
        vis.PrintVisualizerHelp();
        vis.GetRenderOption().SetPointSize(2);        
        //vis.SetFullScreen(true);
        //Keep receiving new frames in a loop
        while (true) {
            // Grab frame            
            while (!imageTransfer.receiveImageSet(image)) {
                if (!vis.PollEvents()) {
                    return 0;
                }
            }    

            //(*rgbdImage) = *recon3d.createOpen3DImageRGBD(image, recon3d.COLOR_THIRD_COLOR);
            //auto pcd = open3d::geometry::PointCloud::CreateFromDepthImage((*rgbdImage).depth_, camera);
            //pcd->Transform(Eigen::Affine3d(Eigen::AngleAxis<double>(M_PI, Eigen::Vector3d(1.0, 0.0, 0.0))).matrix());
            //open3d::visualization::DrawGeometries({ pcd }, "pointCloud");                     
            //(*cloud) = *recon3d.createOpen3DCloud(image);            
            (*cloud) = *recon3d.createOpen3DCloud(image)->Crop(bbox);
            cloud->Transform(Eigen::Affine3d(Eigen::AngleAxis<double>(M_PI, Eigen::Vector3d(1.0, 0.0, 0.0))).matrix());

            ////// Rotate for visualization
            (*rgbdImage) = *recon3d.createOpen3DImageRGBD(image);
            /*rgbdImage2 = (*rgbdImage).CreateFromRedwoodFormat((*rgbdImage).color_, (*rgbdImage).depth_);*/
            //cloud->Transform(Eigen::Affine3d(Eigen::AngleAxis<double>(M_PI, Eigen::Vector3d(1.0, 0.0, 0.0))).matrix());
            /*auto pcd = (*cloud).CreateFromRGBDImage((*rgbdImage), camera);*/
            //pcd->Transform(Eigen::Affine3d(Eigen::AngleAxis<double>(M_PI, Eigen::Vector3d(1.0, 0.0, 0.0))).matrix());
            // Visualize
            if (!vis.HasGeometry()) { vis.AddGeometry(cloud); }

            vis.UpdateGeometry();
            if (!vis.PollEvents()) {
                return 0;
            }
            vis.UpdateRender();
        }
    }
    catch (const std::exception& ex) {
        std::cerr << "Exception occurred: " << ex.what() << std::endl;
    }

    return 0;
}

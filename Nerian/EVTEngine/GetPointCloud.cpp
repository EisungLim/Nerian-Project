#include "pch.h"

#ifdef _MSC_VER
// Visual studio does not come with snprintf
#define snprintf _snprintf_s
#endif

using namespace visiontransfer;


extern "C" __declspec(dllexport) int GetPointCloud(float* xdata, float *ydata, float *zdata, int length, int startX,
    int startY, int imgW, int imgH) {

    int count = 0;                      

    Reconstruct3D recon3d;
    ImageSet image;
    devices = deviceEnum.discoverDevices();
    ImageTransfer imageTransfer(devices[0]);
    while (!imageTransfer.receiveImageSet(image)) { }
      
    pcl::PointCloud<pcl::PointXYZRGB>::Ptr pointCloud(new pcl::PointCloud<pcl::PointXYZRGB>);
    pointCloud = recon3d.createXYZRGBCloud(image, "world");
        
    pcl::PointIndices::Ptr inliers(new pcl::PointIndices);
     for (unsigned int i = 0; i < pointCloud->size(); i++) {
        if (pointCloud->points[i].z < 5) {
           inliers->indices.push_back(i);
        }
    }    

    pcl::ExtractIndices<pcl::PointXYZRGB> extract;
    extract.setInputCloud(pointCloud);
    extract.setIndices(inliers);     
    extract.filterDirectly(pointCloud);   

    for (int i = startY; i < startY + imgH; i++)
    {
        for (int j = startX; j < startX + imgW; j++)
        {            
            int target = (i) * 1024 + j;
            if ((isnan(((*pointCloud).points[target]).x) == 0) && (isnan(((*pointCloud).points[target]).y) == 0) && (isnan(((*pointCloud).points[target]).z) == 0))
            {
                xdata[count] = ((*pointCloud).points[target]).x;
                ydata[count] = ((*pointCloud).points[target]).y;
                zdata[count] = ((*pointCloud).points[target]).z;
                cout << count << ",";
                cout << xdata[count] << ",";
                cout << ydata[count] << ",";
                cout << zdata[count] << endl;
                count++;
            }
        }
    }

    length = count;

    return length;
}
#include "pch.h"

#ifdef _MSC_VER
// Visual studio does not come with snprintf
#define snprintf _snprintf_s
#endif

using namespace visiontransfer;
using namespace std;

extern "C" __declspec(dllexport) float* mouseEventOccured(int x, int y) {      

    Reconstruct3D recon3d;
    devices = deviceEnum.discoverDevices();
    ImageTransfer imageTransfer(devices[0]);
    ImageSet image;

    while (!imageTransfer.receiveImageSet(image)) {}
    pcl::PointCloud<pcl::PointXYZRGB>::Ptr pointCloud = recon3d.createXYZRGBCloud(image, "world");

#pragma region MyRegion
  /*  pcl::PointIndices::Ptr inliers(new pcl::PointIndices);
    for (unsigned int i = 0; i < pointCloud->size(); i++) {
        if (pointCloud->points[i].z < 5) {
            inliers->indices.push_back(i);
        }
    }

    pcl::ExtractIndices<pcl::PointXYZRGB> extract;
    extract.setInputCloud(pointCloud);
    extract.setIndices(inliers);
    extract.filterDirectly(pointCloud);*/
#pragma endregion

    float* copyData  = (float*)LocalAlloc(LPTR, sizeof(float) * 4);
    float* pointData = new float[4];
    int target = y * 1024 + x;    
    
    cout << pointCloud->points[target].x << ",";
    cout << pointCloud->points[target].y << ",";
    cout << pointCloud->points[target].z << endl;
    pointData = pointCloud->points[target].data;                    
    /*if ((isnan(((*pointCloud).points[target]).x) == 0) && (isnan(((*pointCloud).points[target]).y) == 0) && (isnan(((*pointCloud).points[target]).z) == 0))
    {              
    }*/

    memcpy_s(copyData, sizeof(float) * 4, pointData, sizeof(float) * 4);    
    return copyData;
}
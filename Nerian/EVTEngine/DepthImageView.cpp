#include "pch.h"

#define _USE_MATH_DEFINES

#ifdef _MSC_VER
// Visual studio does not come with snprintf
#define snprintf _snprintf_s
#endif

using namespace visiontransfer;
using namespace std;


ImageSet depthImage;        


extern "C" __declspec(dllexport) char* GetView_DepthImageView() {
        
/*    Reconstruct3D recon3d;    
    ImageTransfer imageTransfer(devices[0]);
    shared_ptr<open3d::geometry::RGBDImage> rgbdImage(new open3d::geometry::RGBDImage);        
    
    while (!imageTransfer.receiveImageSet(depthImage)){}   */ 
    /*char* imageAddress = (char*)LocalAlloc(LPTR, 1024 * 768 * 4);   */            
    char* imageAddress = new char;
    //(*rgbdImage) = *recon3d.createOpen3DImageRGBD(depthImage);
    //                                              
    //const unsigned char* copyAddress = &((*rgbdImage).depth_.data_)[0];
    //memcpy_s(imageAddress, 1024 * 768 * 4, copyAddress, 1024 * 768 * 4);

    return imageAddress;
}
    
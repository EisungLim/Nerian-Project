#include "pch.h"

#define _USE_MATH_DEFINES

#ifdef _MSC_VER
// Visual studio does not come with snprintf
#define snprintf _snprintf_s
#endif

using namespace visiontransfer;

ImageSet bagicImage;

char* imageAddress;
const unsigned char* copyAddress;    

extern "C" __declspec(dllexport) char* GetView_BasicImageView() {
        
    ImageTransfer imageTransfer(devices[0]);
    while (!imageTransfer.receiveImageSet(bagicImage)){}
    imageAddress = (char*)LocalAlloc(LPTR, 1024 * 768 * 3);
    copyAddress  = &(bagicImage.getPixelData(0))[0];
    memcpy_s(imageAddress, 1024 * 768 * 3, copyAddress, 1024 * 768 * 3);        

    return imageAddress;       
}

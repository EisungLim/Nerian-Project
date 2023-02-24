#include "pch.h"

using namespace visiontransfer;

extern "C" __declspec(dllexport) int getLength(int len) {

    return len + 10;
    
}
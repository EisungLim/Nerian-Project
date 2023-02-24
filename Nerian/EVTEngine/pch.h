// pch.h: 미리 컴파일된 헤더 파일입니다.
// 아래 나열된 파일은 한 번만 컴파일되었으며, 향후 빌드에 대한 빌드 성능을 향상합니다.
// 코드 컴파일 및 여러 코드 검색 기능을 포함하여 IntelliSense 성능에도 영향을 미칩니다.
// 그러나 여기에 나열된 파일은 빌드 간 업데이트되는 경우 모두 다시 컴파일됩니다.
// 여기에 자주 업데이트할 파일을 추가하지 마세요. 그러면 성능이 저하됩니다.

#ifndef PCH_H
#define PCH_H

#include "framework.h"

#endif //PCH_H

#include <iostream>
#include <exception>
#include <string.h>
#include <stdio.h>
#include <string>
#include <memory>
#include <vector>
#include <math.h>
#include <cmath>

#include <opencv2/opencv.hpp>
#include <open3d/Open3D.h>

#include <pcl/pcl_base.h>
#include <pcl/point_types.h>
#include <pcl/io/pcd_io.h>
#include <pcl/filters/extract_indices.h>
#include <pcl/visualization/mouse_event.h>

#include <visiontransfer/deviceenumeration.h>
#include <visiontransfer/asynctransfer.h>
#include <visiontransfer/imagetransfer.h>
#include <visiontransfer/imageset.h>
#include <visiontransfer/reconstruct3d.h>


using namespace visiontransfer;
using namespace std;

extern DeviceEnumeration deviceEnum;
extern DeviceEnumeration::DeviceList devices;
extern open3d::geometry::AxisAlignedBoundingBox bbox;





 
#include "pch.h"

#ifdef _MSC_VER
// Visual studio does not come with snprintf
#define snprintf _snprintf_s
#endif

using namespace visiontransfer;
using namespace std;



string format(float f, int digits) {
	ostringstream ss;
	ss.precision(digits);
	ss << f;
	return ss.str();
}

DeviceEnumeration deviceEnum;
DeviceEnumeration::DeviceList devices;

extern "C" __declspec(dllexport) char* GetCameraInfo() {
	
	devices = deviceEnum.discoverDevices();
	if (devices.size() == 0)
	{
		std::cout << "No devices discovered!" << std::endl;			
	}

	char* camerainfo = (char*)LocalAlloc(LPTR, 100);
	
	string address  = devices[0].getIpAddress();

	string protocol;
	switch (devices[0].getNetworkProtocol())
	{		
		case DeviceInfo::PROTOCOL_TCP: protocol = "TCP"; break;
		case DeviceInfo::PROTOCOL_UDP: protocol = "UDP"; break;
	}

	string model;
	switch (devices[0].getModel())
	{
		case DeviceInfo::DeviceModel::SCENESCAN:     model = "SceneScan";     break;
		case DeviceInfo::DeviceModel::SCENESCAN_PRO: model = "SceneScan Pro"; break;
		case DeviceInfo::DeviceModel::SCARLET:       model = "Scarlet";       break;
		case DeviceInfo::DeviceModel::RUBY:          model = "Ruby";          break;
	}

	string firmware = devices[0].getFirmwareVersion();

	string isValid;		
	switch (devices[0].getStatus().isValid())
	{		
		case 0: isValid = "failure"; break;
		case 1: isValid = "OK";      break;
	}
	
	float LastFps = devices[0].getStatus().getLastFps();	
	int digist = 4;

	string value = format(LastFps, digist);	
	string status = isValid + ", " + value + " fps. Jumbo frames enabled";
	string cameraSpac = address + "/" + protocol + "/" + model + "/" + firmware + "/" + status;

	strcat_s(camerainfo, 100 , cameraSpac.c_str());
		
	return camerainfo;
}


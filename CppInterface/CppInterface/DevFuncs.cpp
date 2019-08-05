#include "DevFuncs.h"


DevFuncs::DevFuncs()
{
}


DevFuncs::~DevFuncs()
{
}

DevFuncs::rtnStrPtr DevFuncs::getVersionNamePtr = nullptr;
DevFuncs::rtnStrPtr DevFuncs::getAppNamePtr = nullptr;
DevFuncs::rtnIntPtr DevFuncs::getVersionCodePtr = nullptr;

void DevFuncs::set_versionNamePtr(rtnStrPtr ptr) 
{
	getVersionNamePtr = ptr;
}

void DevFuncs::set_versionCodePtr(rtnIntPtr ptr) 
{
	getVersionCodePtr = ptr;
}

void DevFuncs::set_appNamePtr(rtnStrPtr ptr) 
{
	getAppNamePtr = ptr;
}

std::string DevFuncs::getVersionName() 
{
	return DevFuncs::getVersionNamePtr();
}

int DevFuncs::getVersionCode()
{
	return DevFuncs::getVersionCodePtr();
}

std::string DevFuncs::getAppName()
{
	return DevFuncs::getAppNamePtr();
}

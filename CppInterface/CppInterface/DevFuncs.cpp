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
	if (DevFuncs::getVersionNamePtr != nullptr)
	{
		return DevFuncs::getVersionNamePtr();
	}
	return "";
}

int DevFuncs::getVersionCode()
{
	if (DevFuncs::getVersionCodePtr != nullptr)
	{
		return DevFuncs::getVersionCodePtr();
	}
	return -1;
}

std::string DevFuncs::getAppName()
{
	if (DevFuncs::getAppNamePtr != nullptr)
	{
		return DevFuncs::getAppNamePtr();
	}
	return "";
}

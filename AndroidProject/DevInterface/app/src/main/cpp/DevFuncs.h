#pragma once
#include<string>
class DevFuncs
{
public:
	DevFuncs();
	~DevFuncs();
	typedef char*(*rtnStrPtr)();
	typedef int(*rtnIntPtr)();
	static rtnStrPtr getVersionNamePtr;
	static rtnIntPtr getVersionCodePtr;
	static rtnStrPtr getAppNamePtr;

	static void set_versionNamePtr(rtnStrPtr ptr);
	static void set_versionCodePtr(rtnIntPtr ptr);
	static void set_appNamePtr(rtnStrPtr ptr);

	static std::string getVersionName();
	static int getVersionCode();
	static std::string getAppName();
};


// CppInterface.cpp : 定义 DLL 应用程序的导出函数。
//

#include "CppInterface.h"

extern "C"
{
	void set_versionNamePtr(DevFuncs::rtnStrPtr ptr)
	{
		DevFuncs::set_versionNamePtr(ptr);
		Debug::Log("---------------------------------getVersionName bgn");
		Debug::Log(DevFuncs::getVersionName());
		Debug::Log("---------------------------------getVersionName end");

	}

	void set_versionCodePtr(DevFuncs::rtnIntPtr ptr)
	{
		DevFuncs::set_versionCodePtr(ptr);
		Debug::Log("---------------------------------getVersionCode bgn");
		Debug::Log(DevFuncs::getVersionCode());
		Debug::Log("---------------------------------getVersionCode end");
	}

	void set_appNamePtr(DevFuncs::rtnStrPtr ptr)
	{
		DevFuncs::set_appNamePtr(ptr);
		Debug::Log("---------------------------------getAppName bgn");
		Debug::Log(DevFuncs::getAppName());
		Debug::Log("---------------------------------getAppName end");
	}

	void setDebugFuncPtr(Debug::DebugFuncPtr ptr)
	{
		Debug::setDebugFuncPtr(ptr);
	}
}

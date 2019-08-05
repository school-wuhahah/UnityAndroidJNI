#pragma once
#include "Debug.h"
#include "DevFuncs.h"
extern "C"
{
	__declspec(dllexport) void set_versionNamePtr(DevFuncs::rtnStrPtr ptr);

	__declspec(dllexport) void set_versionCodePtr(DevFuncs::rtnIntPtr ptr);

	__declspec(dllexport) void set_appNamePtr(DevFuncs::rtnStrPtr ptr);

	__declspec(dllexport) void setDebugFuncPtr(Debug::DebugFuncPtr ptr);


}
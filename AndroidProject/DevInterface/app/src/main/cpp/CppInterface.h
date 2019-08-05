#pragma once
#include "Debug.h"
#include "DevFuncs.h"



extern "C"
{
	 void set_versionNamePtr(DevFuncs::rtnStrPtr ptr);

	 void set_versionCodePtr(DevFuncs::rtnIntPtr ptr);

	 void set_appNamePtr(DevFuncs::rtnStrPtr ptr);

	 void setDebugFuncPtr(Debug::DebugFuncPtr ptr);


}
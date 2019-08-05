#pragma once
#include <iostream>
#include <sstream>

class Debug
{
public:
	typedef void(*DebugFuncPtr)(const char *);
	static DebugFuncPtr FuncPtr;

	static void setDebugFuncPtr(DebugFuncPtr ptr);
	static void Log(const std::string str);
	static void Log(int num);
	
};


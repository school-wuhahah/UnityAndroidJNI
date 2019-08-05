#include "Debug.h"
#include <string>
using namespace std;

Debug::DebugFuncPtr Debug::FuncPtr;


void Debug::setDebugFuncPtr(DebugFuncPtr ptr)
{
	FuncPtr = ptr;
}

void Debug::Log(const string str)
{
	if (FuncPtr != nullptr)
	{
		FuncPtr(str.c_str());
	}
	/*else
	{
		cout << "Cpp: " << str.c_str() << endl;
	}*/
}

void Debug::Log(int num)
{
	if (FuncPtr != nullptr)
	{
		stringstream sstream;
		sstream << num;
		string val = sstream.str();
		FuncPtr(val.c_str());
	}
}


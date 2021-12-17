#define EXPORT_API __declspec(dllexport)

#include <iostream>

extern "C"
{

	int EXPORT_API NewHP()
	{
		return 5;
	}
}
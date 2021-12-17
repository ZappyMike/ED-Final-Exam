#define EXPORT_API __declspec(dllexport)

#include <iostream>

extern "C"
{

	float EXPORT_API NewSP()
	{
		return 5.f;
	}
}
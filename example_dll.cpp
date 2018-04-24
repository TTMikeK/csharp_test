#include <stdio.h>
#include "example_dll.h"

#include <vector>

/*__stdcall*/ void hello(const char *s)
{
        printf("Hello %s\n", s);
}
int Double(int x)
{
        return 2 * x;
}
void CppFunc(void)
{
        puts("CppFunc");
}
void MyClass::func(void)
{
        puts("MyClass.func()");
}

int MikeFunc(int vec2[2]) {
	std::vector<int> Vec;
	Vec.push_back(vec2[0]+2);
	Vec.push_back(vec2[1]+2);
	// the above is just a waste, but I wanted to do it just to confirm C++ code was working
	
	return vec2[0] + vec2[1];
}
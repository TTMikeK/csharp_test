PREFIX		:=	i686-w64-mingw32-

CC		:=	$(PREFIX)gcc
CXX		:=	$(PREFIX)g++
CS		:=	csc


# /SUBSYSTEM:CONSOLE was supposed to write to console (VS2017), but apparently not

default: dll exe cs

dll:
	$(CXX) -shared -o example_dll.dll -DBUILDING_EXAMPLE_DLL example_dll.cpp -Wl,--out-implib,libexample_dll.a

cl_dll:
	cl.exe /D_USRDLL /D_WINDLL /DBUILDING_EXAMPLE_DLL example_dll.cpp /link /DLL /OUT:example.dll

dump_dll:
	dumpbin /exports example.dll

exe: dll
	$(CXX) -o example_exe.exe example_exe.cpp -L. -lexample_dll

cs:
	$(CS) hello.cs


phony: default dll exe cs

using System;
using System.Runtime.InteropServices;

public class K32 {
	[DllImport ("Kernel32.dll")]
	public static extern int GetProcessId ();
}

public class Example {
	[DllImport ("example_dll")]
	public static extern void hello([MarshalAs(UnmanagedType.LPStr)]String s);

	[DllImport ("example_dll")]
	public static extern int Double([MarshalAs(UnmanagedType.I4)]int x);

	[DllImport ("example_dll.dll")]
	public static extern void CppFunc();
}


public class HelloWorld
{
	static public void Main ()
	{
		Console.WriteLine("Hello Mono World: "+K32.GetProcessId());

		Example.CppFunc();

		//Console.WriteLine("Double: "+Example.Double(13));

//		Example.hello("Theodore McMillian");
	}
}

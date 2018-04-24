using System;
using System.Runtime.InteropServices;

public class K32 {
	[DllImport ("Kernel32.dll")]
	public static extern int GetProcessId ();
}

public class Example {
	[DllImport ("example")]
	public static extern void hello([MarshalAs(UnmanagedType.LPStr)]String s);

	[DllImport ("example")]
	public static extern int Double(int x);
//	public static extern int Double([MarshalAs(UnmanagedType.I4)]int x);

	[DllImport ("example")]
	public static extern void CppFunc();
}


public class HelloWorld
{
	static public void Main ()
	{
		Console.WriteLine("Hello Mono World: "+K32.GetProcessId());

		Example.hello("Welcome to dinner");

		//Example.CppFunc();

		Console.WriteLine("Double: "+Example.Double(13));

		//Example.hello("Theodore McMillian");
	}
}

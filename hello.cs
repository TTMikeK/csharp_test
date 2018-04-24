using System;
using System.Runtime.InteropServices;

public class K32 {
	[DllImport ("Kernel32.dll")]
	public static extern int GetProcessId ();
}

// https://docs.microsoft.com/en-us/dotnet/api/system.runtime.interopservices.unmanagedtype?view=netframework-4.7.2

public class Example {
	[DllImport ("example")]
	public static extern void hello([MarshalAs(UnmanagedType.LPStr)]String s);

	[DllImport ("example")]
	public static extern int Double(int x);
//	public static extern int Double([MarshalAs(UnmanagedType.I4)]int x);

	[DllImport ("example")]
	public static extern int MikeFunc([MarshalAs(UnmanagedType.LPArray, SizeConst=2)] int[] vec2);

	[DllImport ("example", CallingConvention = CallingConvention.Cdecl)]
	public static extern void CppFunc();
}


public class HelloWorld
{
	static public void Main ()
	{
		Console.WriteLine("Hello Mono World: "+K32.GetProcessId());

		Example.hello("Welcome to dinner");

		Console.WriteLine("Double: "+Example.Double(13));
		
		Console.WriteLine("Test: "+String.Join(", ", new[]{2, 13}));

		Console.WriteLine("Mike: "+Example.MikeFunc(new[]{2, 13}));

		// Wont work
		//Example.CppFunc();
	}
}

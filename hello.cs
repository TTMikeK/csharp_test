using System;
using System.Runtime.InteropServices;

public class K32 {
	[DllImport ("Kernel32.dll")]
	public static extern int GetProcessId ();
}

public class Example {
	[DllImport ("example_dll")]
	public static extern void hello([MarshalAs(UnmanagedType.LPStr)]String s);
}


public class HelloWorld
{
    static public void Main ()
    {
        Console.WriteLine ("Hello Mono World: "+K32.GetProcessId());
        
        Example.hello("Theodore McMillian");
    }
}

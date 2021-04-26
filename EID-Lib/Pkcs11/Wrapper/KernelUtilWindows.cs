
using System;
using System.Runtime.InteropServices;
namespace Net.Sf.Pkcs11.Wrapper
{
	/// <summary>
	/// Description of LibraryManager.
	/// </summary>
	public class KernelUtilWindows : IKernelUtil
	{
		void IKernelUtil.FreeLibrary(IntPtr handle)
		{
			FreeLibrary(handle);
		}

		public IntPtr GetProcAddress(IntPtr dllHandle, dynamic name)
		{
			return GetProcAddress(dllHandle, (string)name);
		}


		IntPtr IKernelUtil.LoadLibrary(string fileName)
		{
			return LoadLibrary(fileName);
		}


		#region KernelCalls
		[DllImport("kernel32")]
		private static extern IntPtr LoadLibrary(string fileName);

		[DllImport("kernel32.dll")]
		private static extern int FreeLibrary(IntPtr handle);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetProcAddress(IntPtr handle, string procedureName);
		#endregion

	}
}

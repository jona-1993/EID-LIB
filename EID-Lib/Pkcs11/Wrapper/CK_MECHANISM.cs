using System;
using System.Runtime.InteropServices;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Wrapper
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
	public struct CK_MECHANISM
	{
		public U_INT mechanism;
		
		public IntPtr pParameter;
		
		public U_INT ulParameterLen;
	}
}


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
	public struct CK_ATTRIBUTE{
		
		public U_INT type;

		public IntPtr pValue;

		public U_INT ulValueLen;
	}
}

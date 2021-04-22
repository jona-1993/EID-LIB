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
	public struct CK_SESSION_INFO{ 
		
		public U_INT slotID;
		
		public U_INT state;
		
		public U_INT flags;
		
		public U_INT ulDeviceError;
	}
}

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
	public struct CK_INFO
	{
        public CK_VERSION cryptokiVersion;
        
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] manufacturerID;

        public U_INT flags;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] libraryDescription;

        public CK_VERSION libraryVersion;
	}
}

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
    public struct CK_SLOT_INFO
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] slotDescription;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] manufacturerID;

        public U_INT flags;

        public CK_VERSION hardwareVersion;

        public CK_VERSION firmwareVersion;

    }
}

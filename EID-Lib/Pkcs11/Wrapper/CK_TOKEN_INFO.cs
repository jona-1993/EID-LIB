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
	public struct CK_TOKEN_INFO
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] label;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] manufacturerID;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] model;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] serialNumber;

		public U_INT flags;

		public U_INT ulMaxSessionCount;
		
		public U_INT ulSessionCount;
		
		public U_INT ulMaxRwSessionCount;
		
		public U_INT ulRwSessionCount;
		
		public U_INT ulMaxPinLen;
		
		public U_INT ulMinPinLen;
		
		public U_INT ulTotalPublicMemory;
		
		public U_INT ulFreePublicMemory;
		
		public U_INT ulTotalPrivateMemory;
		
		public U_INT ulFreePrivateMemory;
		
		public CK_VERSION hardwareVersion;
		
		public CK_VERSION firmwareVersion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] utcTime;
		
	}
}

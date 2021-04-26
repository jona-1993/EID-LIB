
using System;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Wrapper
{

	public enum CKC:U_INT
	{
		X_509 = 0x00000000 ,
		X_509_ATTR_CERT =0x00000001,
		WTLS = 0x00000002 ,
		VENDOR_DEFINED = 0x80000000
	}
}

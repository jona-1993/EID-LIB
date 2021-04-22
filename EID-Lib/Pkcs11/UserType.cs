
using System;
using Net.Sf.Pkcs11.Wrapper;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11
{
	public enum UserType:U_INT
	{SO= CKU.SO , USER=CKU.USER
	}
}

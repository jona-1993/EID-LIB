
using System;
using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Wrapper
{	
	public enum CKU:U_INT
	{
		SO = PKCS11Constants.CKU_SO,
		USER = PKCS11Constants.CKU_USER,
		CONTEXT_SPECIFIC =PKCS11Constants.CKU_CONTEXT_SPECIFIC
	}
}

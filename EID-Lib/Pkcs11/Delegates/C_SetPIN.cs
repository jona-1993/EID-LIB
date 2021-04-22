
using System;
using Net.Sf.Pkcs11.Wrapper;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Delegates
{
     [System.Runtime.InteropServices.UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	internal delegate CKR C_SetPIN(
		U_INT hSession, 
		byte[] pOldPin, 
		U_INT ulOldLen,
		byte[] pNewPin, 
		U_INT ulNewLen
	);
}

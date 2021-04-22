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
	internal delegate CKR  C_GenerateKeyPair(
		U_INT hSession,
		ref CK_MECHANISM pMechanism,
		CK_ATTRIBUTE[] pPublicKeyTemplate,
		U_INT ulPublicKeyAttributeCount,
		CK_ATTRIBUTE[] pPrivateKeyTemplate,
		U_INT ulPrivateKeyAttributeCount,
		ref U_INT phPublicKey,
		ref U_INT phPrivateKey
	);
}
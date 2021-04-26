
using System;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Wrapper
{
	/// <summary>
	/// Description of KeyPair.
	/// </summary>
	public struct KeyPairHandler 
	{
		public U_INT hPrivateKey;
		public U_INT hPublicKey;

	}
}

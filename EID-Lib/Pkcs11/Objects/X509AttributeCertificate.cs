
using System;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Objects
{
	/// <summary>
	/// Description of X509AttributeCertificate.
	/// </summary>
	public class X509AttributeCertificate:Certificate
	{
		public X509AttributeCertificate()
		{
		}
		
		public static new P11Object GetInstance(Session session, U_INT hObj)
		{
			return null;
		}
	}
}

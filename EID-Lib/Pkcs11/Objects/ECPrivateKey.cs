﻿
using System;
using Net.Sf.Pkcs11.Wrapper;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Objects
{
	/// <summary>
	/// Description of ECPrivateKey.
	/// </summary>
    /// 

	public class ECPrivateKey:PrivateKey
	{
        //CKA_EC_PARAMS with { 0x06, 0x05, 0x2b, 0x81, 0x04, 0x00, 0x22 }

        ByteArrayAttribute ecparams = new ByteArrayAttribute(CKA.EC_PARAMS);
		
		public ByteArrayAttribute ECParams {
			get { return ecparams; }
		}
		
		public ECPrivateKey()
		{
			this.KeyType.KeyType = CKK.EC;
		}
		
		public ECPrivateKey(Session session, U_INT hObj):base(session,hObj)
		{
		}
		
		public static new P11Object GetInstance(Session session, U_INT hObj)
		{
			return new ECPrivateKey(session,hObj) ;
		}
		
		public override void ReadAttributes(Session session)
		{
			base.ReadAttributes(session);
			
			ecparams= ReadAttribute(session,HObj,new ByteArrayAttribute(CKA.EC_PARAMS));
		}
		
	}
}

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
	public class DesSecretKey:SecretKey
	{
		ByteArrayAttribute value_= new ByteArrayAttribute(CKA.VALUE);
		
		public ByteArrayAttribute Value {
			get { return value_; }
		}
		
		public DesSecretKey(){
			this.KeyType.KeyType= CKK.DES;
		}
		
		public DesSecretKey(Session session, U_INT hObj):base(session,hObj)
		{
		}
		
		public override void ReadAttributes(Session session)
		{
			base.ReadAttributes(session);
			
			value_=ReadAttribute(session,HObj,new ByteArrayAttribute(CKA.VALUE));
		}
		
		public static new P11Object GetInstance(Session session, U_INT hObj)
		{
			return new DesSecretKey(session,hObj);
		}
	}
}

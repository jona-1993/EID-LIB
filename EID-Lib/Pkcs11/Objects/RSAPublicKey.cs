
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
	/// Description of RSAPublicKey.
	/// </summary>
	public class RSAPublicKey:PublicKey
	{
		
		protected ByteArrayAttribute modulus_=new ByteArrayAttribute(CKA.MODULUS);
		
		public ByteArrayAttribute Modulus {
			get { return modulus_; }
		}
		protected ByteArrayAttribute publicExponent_=new ByteArrayAttribute(CKA.PUBLIC_EXPONENT);
		
		public ByteArrayAttribute PublicExponent {
			get { return publicExponent_; }
		}
		protected UIntAttribute modulusBits_ = new UIntAttribute((U_INT)CKA.MODULUS_BITS);
		
		public UIntAttribute ModulusBits {
			get { return modulusBits_; }
		}
		
		public RSAPublicKey()
		{
			this.KeyType.KeyType= CKK.RSA;
		}
		
		public RSAPublicKey(Session session, U_INT hObj):base(session,hObj)
		{
			
		}
		
		public static new P11Object GetInstance(Session session, U_INT hObj)
		{
			return new RSAPublicKey(session,hObj) ;
		}
		
		public override void ReadAttributes(Session session)
		{
			base.ReadAttributes(session);
			
			modulus_= ReadAttribute(session,HObj,new ByteArrayAttribute(CKA.MODULUS));

			publicExponent_= ReadAttribute(session,HObj,new ByteArrayAttribute(CKA.PUBLIC_EXPONENT));
			
			modulusBits_= ReadAttribute(session,HObj,new UIntAttribute((U_INT)CKA.MODULUS_BITS));

		}
	}
}

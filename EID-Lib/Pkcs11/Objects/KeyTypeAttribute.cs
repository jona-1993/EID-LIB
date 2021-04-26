
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
	/// Description of KeyTypeAttribute.
	/// </summary>
	public class KeyTypeAttribute:UIntAttribute
	{
		public KeyTypeAttribute():base((U_INT)CKA.KEY_TYPE)
		{
		}
		
		public KeyTypeAttribute(CKK keyType):base((U_INT)CKA.KEY_TYPE)
		{
			KeyType=keyType;
		}
		
		
		public KeyTypeAttribute(CK_ATTRIBUTE ckAttr):base(ckAttr)
		{
		}
		
		public CKK KeyType {
			get { return (CKK)base.Value; }
			set { base.Value= (U_INT)value; }
		}
		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new KeyTypeAttribute(this.CK_ATTRIBUTE);
		}
	}
}

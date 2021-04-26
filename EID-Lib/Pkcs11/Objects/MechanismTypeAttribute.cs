
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
	/// Description of MechanismTypeAttribute.
	/// </summary>
	public class MechanismTypeAttribute:UIntAttribute
	{
		
		internal MechanismTypeAttribute(U_INT type ):base(type){
			
		}
		internal MechanismTypeAttribute(CKA type ):base((U_INT)type){
		}
		
		public MechanismTypeAttribute(CKA type, CKM mechanismType):base((U_INT)type)
		{
			MechanismType=mechanismType;
		}
		
		
		public MechanismTypeAttribute(CK_ATTRIBUTE ckAttr):base(ckAttr)
		{
		}
		
		public CKM MechanismType {
			get { return (CKM)base.Value; }
			set { base.Value= (U_INT)value; }
		}
		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new MechanismTypeAttribute(this.CK_ATTRIBUTE);
		}
	}
}

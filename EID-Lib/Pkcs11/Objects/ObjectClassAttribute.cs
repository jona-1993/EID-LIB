
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
	/// Description of ObjectClassAttribute.
	/// </summary>
	public class ObjectClassAttribute:UIntAttribute
	{
		public ObjectClassAttribute():base((U_INT)CKA.CLASS)
		{
		}
		
		public ObjectClassAttribute(CK_ATTRIBUTE ckAttr):base(ckAttr)
		{
		}
		public ObjectClassAttribute(CKO objectType):base((U_INT)CKA.CLASS)
		{
			ObjectType=objectType;
		}
		
		public CKO ObjectType {
			get { return (CKO)base.Value; }
			internal set { base.Value= (U_INT)value; }
		}
		
		public override string ToString()
		{
			return string.Format("[ObjectClassAttribute ObjectType={0}]", this.ObjectType);
		}
		
		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new ObjectClassAttribute(this.CK_ATTRIBUTE);
		}
	}
}

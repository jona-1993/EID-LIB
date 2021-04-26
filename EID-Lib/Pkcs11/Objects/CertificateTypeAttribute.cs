
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
	/// Description of CertificateTypeAttribute.
	/// </summary>
	public class CertificateTypeAttribute:UIntAttribute
	{
		public CertificateTypeAttribute():base((U_INT)CKA.CERTIFICATE_TYPE)
		{
		}
		
		public CertificateTypeAttribute(CK_ATTRIBUTE ckAttr):base(ckAttr)
		{
		}
		
		public CKC CertificateType {
			get { return (CKC)base.Value; }
			set { base.Value= (U_INT)value;
				IsAssigned=true;
			}
		}
		
		public override string ToString()
		{
			return string.Format("[CertificateTypeAttribute CertificateType={0}]", this.CertificateType);
		}
		
		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new CertificateTypeAttribute(this.CK_ATTRIBUTE);
		}
	}
}

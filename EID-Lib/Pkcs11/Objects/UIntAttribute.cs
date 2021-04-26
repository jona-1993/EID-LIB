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
	public class UIntAttribute : P11Attribute
	{
		
		U_INT val_;

		public U_INT Value
		{
			get { return val_; }
			set
			{
				val_ = value;
				IsAssigned = true;
			}
		}

		internal UIntAttribute(U_INT type) : base(type)
		{

		}

		internal UIntAttribute(CK_ATTRIBUTE attr) : base(attr)
		{

		}


		public override byte[] Encode(){
			return BitConverter.GetBytes(Value);
		}

		public override void Decode(byte[] val){
			Value=BitConverter.ToUInt32(val,0);
		}
		
		public override string ToString()
		{
			return Value.ToString();
		}
		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new UIntAttribute(this.CK_ATTRIBUTE);
		}
		
	}
}

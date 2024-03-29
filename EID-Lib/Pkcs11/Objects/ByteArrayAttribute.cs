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
	/// Description of ByteArrayAttribute.
	/// </summary>
	public class ByteArrayAttribute:P11Attribute
	{
		byte[] val;
		
		public byte[] Value {
			get { return val; }
			set { val = value; 
			IsAssigned=true;
			}
		}
		
		public ByteArrayAttribute(U_INT type):base(type)
		{
		}
		
		public ByteArrayAttribute(CKA type):base((U_INT)type)
		{
		}
		
		public ByteArrayAttribute(CK_ATTRIBUTE ckAttr):base(ckAttr)
		{
		}
		
		public override byte[] Encode(){
			return Value;
		}
		public override void Decode(byte[] val){
			Value= val;
		}
		
		public override string ToString()
		{
			return string.Format("[ByteArrayAttribute Value={0}]", BitConverter.ToString(val).Replace('-',' '));
		}
		
		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new ByteArrayAttribute(this.CK_ATTRIBUTE);
		}
	}
}

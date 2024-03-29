﻿
using System;
using  Net.Sf.Pkcs11.Wrapper;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Objects
{
	/// <summary>
	/// Description of CharArrayAttribute.
	/// </summary>
	public class CharArrayAttribute : P11Attribute
	{
		char[] val;
		
		public char[] Value {
			get { return val; }
			set {
				val = value;
				IsAssigned=true;
			}
		}
		
		public CharArrayAttribute()
		{
		}
		
		public CharArrayAttribute(U_INT type):base(type)
		{
		}
		public CharArrayAttribute(CKA type):base((U_INT)type)
		{
		}
		public CharArrayAttribute(CK_ATTRIBUTE ckAttr):base(ckAttr)
		{
		}
		
		public override byte[] Encode(){
			return System.Text.Encoding.UTF8.GetBytes(new String(Value));
		}
		public override void Decode(byte[] val){
			Value= System.Text.Encoding.UTF8.GetString(val).ToCharArray();
		}
		
		public override string ToString()
		{
			return string.Format("[CharArrayAttribute Value={0}]", new String(val));
		}

		
		protected override P11Attribute GetCkLoadedCopy()
		{
			return new CharArrayAttribute(this.CK_ATTRIBUTE);
		}
	}
}

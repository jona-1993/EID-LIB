﻿using System;
using Net.Sf.Pkcs11.Wrapper;
using System.Runtime.InteropServices;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Objects
{
	public abstract class P11Attribute
	{
		bool isAssigned;
		MetaData metaData=new MetaData();		
		public MetaData MetaData {
			get { return metaData; }
		}

		protected CK_ATTRIBUTE attr=new CK_ATTRIBUTE();

#if Windows
		internal U_INT Type { 
			 get { return attr.type; }
			 private set {attr.type=value;}
		}
#else
		internal UInt64 Type {
			 get { return attr.type; }
			 private set {attr.type=value;}
		}
#endif

		internal CKA CKA{
			get{
				return (CKA)attr.type;
			}
		}
		
		public bool IsAssigned {
			get { return isAssigned; }
			protected set { isAssigned = value; }
		}
		
		protected void AssignValue( byte[] val ){
#if Windows
			attr.ulValueLen=(U_INT)val.Length;
#else
			attr.ulValueLen=(UInt64)val.Length;
#endif
			attr.pValue=Marshal.AllocHGlobal(val.Length);
			Marshal.Copy(val,0,attr.pValue,val.Length);
		}
		
		protected void AssignNullValue(){
			attr.pValue=IntPtr.Zero;
			attr.ulValueLen=0;
		}
		
		internal virtual CK_ATTRIBUTE CK_ATTRIBUTE{
			get{
				if(IsAssigned)
					AssignValue(Encode());
				else AssignNullValue();

				return attr;
			}
		}
		
		public abstract byte[] Encode();
		
		public abstract void Decode(byte[] val);		
		
		internal P11Attribute(CK_ATTRIBUTE attr){
			this.attr=attr;
			this.DecodeAttr();
		}
		
		internal P11Attribute(){
			this.attr=new CK_ATTRIBUTE();
		}

#if Windows
		internal P11Attribute(U_INT type):base(){
			this.Type=type;
		}
#else
		internal P11Attribute(UInt64 type):base(){
			this.Type=type;
		}
#endif

		private byte[] getAsBinary(IntPtr ptr, int size){
			if(ptr==IntPtr.Zero)
				return null;
			else if(size==0)
				return new byte[0];
			
			byte[] val=new byte[size];
			Marshal.Copy(ptr,val,0,size);
			return val;
		}
		
		protected virtual void DecodeAttr(){
			byte[] tmp=getAsBinary(attr.pValue,(int)attr.ulValueLen);
			if( tmp!=null && tmp.Length>0  )
				Decode(tmp);
		}
		
		public P11Attribute Load(CK_ATTRIBUTE attr){
			this.attr=attr;
			this.DecodeAttr();
			return this;
		}
		
		public P11Attribute Clone(){
			P11Attribute p11= GetCkLoadedCopy();
			p11.metaData=this.metaData;
			p11.isAssigned=this.isAssigned;
			return p11;
		}
		
		protected abstract P11Attribute GetCkLoadedCopy();
	}
}

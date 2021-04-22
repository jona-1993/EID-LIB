using System;
using System.Runtime.InteropServices;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Wrapper
{
	

	public class AttributeUtil
	{
		public static CK_ATTRIBUTE CreateClassAttribute(){
			return createAttribute((U_INT)CKA.CLASS,new byte[0]);
			
		}
		
		public static CK_ATTRIBUTE CreateClassAttribute(CKO objectClass){

			return createAttribute((U_INT)CKA.CLASS,BitConverter.GetBytes((U_INT)objectClass));
		}
		
		public static CK_ATTRIBUTE createAttribute(U_INT type, byte[]val ){
			
			CK_ATTRIBUTE attr= new CK_ATTRIBUTE();
			attr.type=type;
			if(val!=null && val.Length>0){
				attr.ulValueLen=(U_INT)val.Length;
				attr.pValue=Marshal.AllocHGlobal(val.Length);
				Marshal.Copy(val,0,attr.pValue,val.Length);
			}else{
				attr.ulValueLen=(U_INT)val.Length;
				attr.pValue=IntPtr.Zero;
				
			}
			return attr;
		}
		
		public static CK_ATTRIBUTE createAttribute(U_INT type, int size ){
			return createAttribute(type,new byte[size]);
		}
		
		public static CK_ATTRIBUTE createAttribute(CKA type, int size ){
			return createAttribute((U_INT)type,new byte[size]);
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Text;

using U_INT =
#if Windows
        System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Objects
{
    public class HardwareFeature:P11Object
    {
    	
    	public static new P11Object GetInstance(Session session, U_INT hObj)
		{
			return null;
		}
    }
}

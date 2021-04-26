﻿
using System;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Wrapper
{
	/// <summary>
	/// Description of CKK.
	/// </summary>
	public enum CKK:U_INT
	{
		AES = 0x0000001F ,
		BATON = 0x0000001C ,
		BLOWFISH = 0x00000020 ,
		CAST = 0x00000016 ,
		CAST128 = 0x00000018 ,
		CAST3 = 0x00000017 ,
		CAST5 = 0x00000018 ,
		CDMF = 0x0000001E ,
		DES = 0x00000013 ,
		DES2 = 0x00000014 ,
		DES3 = 0x00000015 ,
		DH = 0x00000002 ,
		DSA = 0x00000001 ,
		EC = 0x00000003 ,
		ECDSA = 0x00000003 ,
		GENERIC_SECRET = 0x00000010 ,
		IDEA = 0x0000001A ,
		JUNIPER = 0x0000001D ,
		KEA = 0x00000005 ,
		RC2 = 0x00000011 ,
		RC4 = 0x00000012 ,
		RC5 = 0x00000019 ,
		RSA = 0x00000000 ,
		SKIPJACK = 0x0000001B ,
		TWOFISH = 0x00000021 ,
		VENDOR_DEFINED = 0x80000000 ,
		X9_42_DH = 0x00000004 ,
        GOST = PKCS11Constants.CKK_GOSTR3410
	}
}

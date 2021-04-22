
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
	/// PKCS11Constants.
	/// </summary>
	public static class PKCS11Constants
	{
		internal const U_INT CK_EFFECTIVELY_INFINITE = 0 ;
		internal const U_INT CK_INVALID_HANDLE = 0 ;
		internal const U_INT CKA_AC_ISSUER = 0x00000083 ;
		internal const U_INT CKA_ALLOWED_MECHANISMS =(CKF_ARRAY_ATTRIBUTE|0x00000600) ;
		internal const U_INT CKA_ALWAYS_AUTHENTICATE = 0x00000202 ;
		internal const U_INT CKA_ALWAYS_SENSITIVE = 0x00000165 ;
		internal const U_INT CKA_APPLICATION = 0x00000010 ;
		internal const U_INT CKA_ATTR_TYPES = 0x00000085 ;
		internal const U_INT CKA_AUTH_PIN_FLAGS = 0x00000201 /* Deprecated */ ;
		internal const U_INT CKA_BASE = 0x00000132 ;
		internal const U_INT CKA_BITS_PER_PIXEL = 0x00000406 ;
		internal const U_INT CKA_CERTIFICATE_CATEGORY = 0x00000087 ;
		internal const U_INT CKA_CERTIFICATE_TYPE = 0x00000080 ;
		internal const U_INT CKA_CHAR_COLUMNS = 0x00000404 ;
		internal const U_INT CKA_CHAR_ROWS = 0x00000403 ;
		internal const U_INT CKA_CHAR_SETS = 0x00000480 ;
		internal const U_INT CKA_CHECK_VALUE = 0x00000090 ;
		internal const U_INT CKA_CLASS = 0x00000000 ;
		internal const U_INT CKA_COEFFICIENT = 0x00000128 ;
		internal const U_INT CKA_COLOR = 0x00000405 ;
		internal const U_INT CKA_DECRYPT = 0x00000105 ;
		internal const U_INT CKA_DEFAULT_CMS_ATTRIBUTES = 0x00000502 ;
		internal const U_INT CKA_DERIVE = 0x0000010C ;
		internal const U_INT CKA_EC_PARAMS = 0x00000180 ;
		internal const U_INT CKA_EC_POINT = 0x00000181 ;
		internal const U_INT CKA_ECDSA_PARAMS = 0x00000180 ;
		internal const U_INT CKA_ENCODING_METHODS = 0x00000481 ;
		internal const U_INT CKA_ENCRYPT = 0x00000104 ;
		internal const U_INT CKA_END_DATE = 0x00000111 ;
		internal const U_INT CKA_EXPONENT_1 = 0x00000126 ;
		internal const U_INT CKA_EXPONENT_2 = 0x00000127 ;
		internal const U_INT CKA_EXTRACTABLE = 0x00000162 ;
		internal const U_INT CKA_HAS_RESET = 0x00000302 ;
		internal const U_INT CKA_HASH_OF_ISSUER_PUBLIC_KEY = 0x0000008B ;
		internal const U_INT CKA_HASH_OF_SUBJECT_PUBLIC_KEY = 0x0000008A ;
		internal const U_INT CKA_HW_FEATURE_TYPE = 0x00000300 ;
		internal const U_INT CKA_ID = 0x00000102 ;
		internal const U_INT CKA_ISSUER = 0x00000081 ;
		internal const U_INT CKA_JAVA_MIDP_SECURITY_DOMAIN = 0x00000088 ;
		internal const U_INT CKA_KEY_GEN_MECHANISM = 0x00000166 ;
		internal const U_INT CKA_KEY_TYPE = 0x00000100 ;
		internal const U_INT CKA_LABEL = 0x00000003 ;
		internal const U_INT CKA_LOCAL = 0x00000163 ;
		internal const U_INT CKA_MECHANISM_TYPE = 0x00000500 ;
		internal const U_INT CKA_MIME_TYPES = 0x00000482 ;
		internal const U_INT CKA_MODIFIABLE = 0x00000170 ;
		internal const U_INT CKA_MODULUS = 0x00000120 ;
		internal const U_INT CKA_MODULUS_BITS = 0x00000121 ;
		internal const U_INT CKA_NEVER_EXTRACTABLE = 0x00000164 ;
		internal const U_INT CKA_OBJECT_ID = 0x00000012 ;
		internal const U_INT CKA_OWNER = 0x00000084 ;
		internal const U_INT CKA_PIXEL_X = 0x00000400 ;
		internal const U_INT CKA_PIXEL_Y = 0x00000401 ;
		internal const U_INT CKA_PRIME = 0x00000130 ;
		internal const U_INT CKA_PRIME_1 = 0x00000124 ;
		internal const U_INT CKA_PRIME_2 = 0x00000125 ;
		internal const U_INT CKA_PRIME_BITS = 0x00000133 ;
		internal const U_INT CKA_PRIVATE = 0x00000002 ;
		internal const U_INT CKA_PRIVATE_EXPONENT = 0x00000123 ;
		internal const U_INT CKA_PUBLIC_EXPONENT = 0x00000122 ;
		internal const U_INT CKA_REQUIRED_CMS_ATTRIBUTES = 0x00000501 ;
		internal const U_INT CKA_RESET_ON_INIT = 0x00000301 ;
		internal const U_INT CKA_RESOLUTION = 0x00000402 ;
		internal const U_INT CKA_SECONDARY_AUTH = 0x00000200 /* Deprecated */ ;
		internal const U_INT CKA_SENSITIVE = 0x00000103 ;
		internal const U_INT CKA_SERIAL_NUMBER = 0x00000082 ;
		internal const U_INT CKA_SIGN = 0x00000108 ;
		internal const U_INT CKA_SIGN_RECOVER = 0x00000109 ;
		internal const U_INT CKA_START_DATE = 0x00000110 ;
		internal const U_INT CKA_SUBJECT = 0x00000101 ;
		internal const U_INT CKA_SUBPRIME = 0x00000131 ;
		internal const U_INT CKA_SUBPRIME_BITS = 0x00000134 ;
		internal const U_INT CKA_SUPPORTED_CMS_ATTRIBUTES = 0x00000503 ;
		internal const U_INT CKA_TOKEN = 0x00000001 ;
		internal const U_INT CKA_TRUSTED = 0x00000086 ;
		internal const U_INT CKA_UNWRAP = 0x00000107 ;
		internal const U_INT CKA_UNWRAP_TEMPLATE = (CKF_ARRAY_ATTRIBUTE|0x00000212) ;
		internal const U_INT CKA_URL = 0x00000089 ;
		internal const U_INT CKA_VALUE = 0x00000011 ;
		internal const U_INT CKA_VALUE_BITS = 0x00000160 ;
		internal const U_INT CKA_VALUE_LEN = 0x00000161 ;
		internal const U_INT CKA_VENDOR_DEFINED = 0x80000000 ;
		internal const U_INT CKA_VERIFY = 0x0000010A ;
		internal const U_INT CKA_VERIFY_RECOVER = 0x0000010B ;
		internal const U_INT CKA_WRAP = 0x00000106 ;
		internal const U_INT CKA_WRAP_TEMPLATE = (CKF_ARRAY_ATTRIBUTE|0x00000211) ;
		internal const U_INT CKA_WRAP_WITH_TRUSTED = 0x00000210 ;


        /// <summary>
        /// Набор эталонных параметров из RFC 4357,
        /// используемых в алгоритме формирования ключевой пары,
        /// описанном в ГОСТ 34.10-2001.
        /// </summary>
        internal const U_INT CKA_GOST3410PARAMS_EX = 0xD4321001;

        internal const U_INT CKA_GOSTR3410PARAMS = 0x00000250;
        internal const U_INT CKA_GOSTR3411PARAMS = 0x00000251;
        internal const U_INT CKA_GOST28147PARAMS = 0x00000252;

		internal const U_INT CKC_VENDOR_DEFINED = 0x80000000 ;
		internal const U_INT CKC_WTLS = 0x00000002 ;
		internal const U_INT CKC_X_509 = 0x00000000 ;
		internal const U_INT CKC_X_509_ATTR_CERT =0x00000001 ;

		internal const U_INT CKF_ARRAY_ATTRIBUTE = 0x40000000 ;
		internal const U_INT CKF_DONT_BLOCK = 1 ;
		internal const U_INT CKF_RW_SESSION = 0x00000002;
		internal const U_INT CKF_SERIAL_SESSION = 0x00000004;

		internal const U_INT CKH_CLOCK = 0x00000002 ;
		internal const U_INT CKH_MONOTONIC_COUNTER = 0x00000001 ;
		internal const U_INT CKH_USER_INTERFACE = 0x00000003 ;
		internal const U_INT CKH_VENDOR_DEFINED = 0x80000000 ;

		internal const U_INT CKK_AES = 0x0000001F ;
		internal const U_INT CKK_BATON = 0x0000001C ;
		internal const U_INT CKK_BLOWFISH = 0x00000020 ;
		internal const U_INT CKK_CAST = 0x00000016 ;
		internal const U_INT CKK_CAST128 = 0x00000018 ;
		internal const U_INT CKK_CAST3 = 0x00000017 ;
		internal const U_INT CKK_CAST5 = 0x00000018 ;
		internal const U_INT CKK_CDMF = 0x0000001E ;
		internal const U_INT CKK_DES = 0x00000013 ;
		internal const U_INT CKK_DES2 = 0x00000014 ;
		internal const U_INT CKK_DES3 = 0x00000015 ;
		internal const U_INT CKK_DH = 0x00000002 ;
		internal const U_INT CKK_DSA = 0x00000001 ;
		internal const U_INT CKK_EC = 0x00000003 ;
		internal const U_INT CKK_ECDSA = 0x00000003 ;
		internal const U_INT CKK_GENERIC_SECRET = 0x00000010 ;
		internal const U_INT CKK_IDEA = 0x0000001A ;
		internal const U_INT CKK_JUNIPER = 0x0000001D ;
		internal const U_INT CKK_KEA = 0x00000005 ;
		internal const U_INT CKK_RC2 = 0x00000011 ;
		internal const U_INT CKK_RC4 = 0x00000012 ;
		internal const U_INT CKK_RC5 = 0x00000019 ;
		internal const U_INT CKK_RSA = 0x00000000 ;
		internal const U_INT CKK_SKIPJACK = 0x0000001B ;
		internal const U_INT CKK_TWOFISH = 0x00000021 ;
		internal const U_INT CKK_VENDOR_DEFINED = 0x80000000 ;
		internal const U_INT CKK_X9_42_DH = 0x00000004 ;
        internal const U_INT CKK_GOSTR3410 = 0x00000030 ;

		internal const U_INT CKM_AES_CBC = 0x00001082 ;
		internal const U_INT CKM_AES_CBC_ENCRYPT_DATA = 0x00001105 ;
		internal const U_INT CKM_AES_CBC_PAD = 0x00001085 ;
		internal const U_INT CKM_AES_ECB = 0x00001081 ;
		internal const U_INT CKM_AES_ECB_ENCRYPT_DATA = 0x00001104 ;
		internal const U_INT CKM_AES_KEY_GEN = 0x00001080 ;
		internal const U_INT CKM_AES_MAC = 0x00001083 ;
		internal const U_INT CKM_AES_MAC_GENERAL = 0x00001084 ;
		internal const U_INT CKM_BATON_CBC128 = 0x00001033 ;
		internal const U_INT CKM_BATON_COUNTER = 0x00001034 ;
		internal const U_INT CKM_BATON_ECB128 = 0x00001031 ;
		internal const U_INT CKM_BATON_ECB96 = 0x00001032 ;
		internal const U_INT CKM_BATON_KEY_GEN = 0x00001030 ;
		internal const U_INT CKM_BATON_SHUFFLE = 0x00001035 ;
		internal const U_INT CKM_BATON_WRAP = 0x00001036 ;
		internal const U_INT CKM_BLOWFISH_CBC = 0x00001091 ;
		internal const U_INT CKM_BLOWFISH_KEY_GEN = 0x00001090 ;
		internal const U_INT CKM_CAST_CBC = 0x00000302 ;
		internal const U_INT CKM_CAST_CBC_PAD = 0x00000305 ;
		internal const U_INT CKM_CAST_ECB = 0x00000301 ;
		internal const U_INT CKM_CAST_KEY_GEN = 0x00000300 ;
		internal const U_INT CKM_CAST_MAC = 0x00000303 ;
		internal const U_INT CKM_CAST_MAC_GENERAL = 0x00000304 ;
		internal const U_INT CKM_CAST128_CBC = 0x00000322 ;
		internal const U_INT CKM_CAST128_CBC_PAD = 0x00000325 ;
		internal const U_INT CKM_CAST128_ECB = 0x00000321 ;
		internal const U_INT CKM_CAST128_KEY_GEN = 0x00000320 ;
		internal const U_INT CKM_CAST128_MAC = 0x00000323 ;
		internal const U_INT CKM_CAST128_MAC_GENERAL = 0x00000324 ;
		internal const U_INT CKM_CAST3_CBC = 0x00000312 ;
		internal const U_INT CKM_CAST3_CBC_PAD = 0x00000315 ;
		internal const U_INT CKM_CAST3_ECB = 0x00000311 ;
		internal const U_INT CKM_CAST3_KEY_GEN = 0x00000310 ;
		internal const U_INT CKM_CAST3_MAC = 0x00000313 ;
		internal const U_INT CKM_CAST3_MAC_GENERAL = 0x00000314 ;
		internal const U_INT CKM_CAST5_CBC = 0x00000322 ;
		internal const U_INT CKM_CAST5_CBC_PAD = 0x00000325 ;
		internal const U_INT CKM_CAST5_ECB = 0x00000321 ;
		internal const U_INT CKM_CAST5_KEY_GEN = 0x00000320 ;
		internal const U_INT CKM_CAST5_MAC = 0x00000323 ;
		internal const U_INT CKM_CAST5_MAC_GENERAL = 0x00000324 ;
		internal const U_INT CKM_CDMF_CBC = 0x00000142 ;
		internal const U_INT CKM_CDMF_CBC_PAD = 0x00000145 ;
		internal const U_INT CKM_CDMF_ECB = 0x00000141 ;
		internal const U_INT CKM_CDMF_KEY_GEN = 0x00000140 ;
		internal const U_INT CKM_CDMF_MAC = 0x00000143 ;
		internal const U_INT CKM_CDMF_MAC_GENERAL = 0x00000144 ;
		internal const U_INT CKM_CMS_SIG = 0x00000500 ;
		internal const U_INT CKM_CONCATENATE_BASE_AND_DATA = 0x00000362 ;
		internal const U_INT CKM_CONCATENATE_BASE_AND_KEY = 0x00000360 ;
		internal const U_INT CKM_CONCATENATE_DATA_AND_BASE = 0x00000363 ;
		internal const U_INT CKM_DES_CBC = 0x00000122 ;
		internal const U_INT CKM_DES_CBC_ENCRYPT_DATA = 0x00001101 ;
		internal const U_INT CKM_DES_CBC_PAD = 0x00000125 ;
		internal const U_INT CKM_DES_CFB64 = 0x00000152 ;
		internal const U_INT CKM_DES_CFB8 = 0x00000153 ;
		internal const U_INT CKM_DES_ECB = 0x00000121 ;
		internal const U_INT CKM_DES_ECB_ENCRYPT_DATA = 0x00001100 ;
		internal const U_INT CKM_DES_KEY_GEN = 0x00000120 ;
		internal const U_INT CKM_DES_MAC = 0x00000123 ;
		internal const U_INT CKM_DES_MAC_GENERAL = 0x00000124 ;
		internal const U_INT CKM_DES_OFB64 = 0x00000150 ;
		internal const U_INT CKM_DES_OFB8 = 0x00000151 ;
		internal const U_INT CKM_DES2_KEY_GEN = 0x00000130 ;
		internal const U_INT CKM_DES3_CBC = 0x00000133 ;
		internal const U_INT CKM_DES3_CBC_ENCRYPT_DATA = 0x00001103 ;
		internal const U_INT CKM_DES3_CBC_PAD = 0x00000136 ;
		internal const U_INT CKM_DES3_ECB = 0x00000132 ;
		internal const U_INT CKM_DES3_ECB_ENCRYPT_DATA = 0x00001102 ;
		internal const U_INT CKM_DES3_KEY_GEN = 0x00000131 ;
		internal const U_INT CKM_DES3_MAC = 0x00000134 ;
		internal const U_INT CKM_DES3_MAC_GENERAL = 0x00000135 ;
		internal const U_INT CKM_DH_PKCS_DERIVE = 0x00000021 ;
		internal const U_INT CKM_DH_PKCS_KEY_PAIR_GEN = 0x00000020 ;
		internal const U_INT CKM_DH_PKCS_PARAMETER_GEN = 0x00002001 ;
		internal const U_INT CKM_DSA = 0x00000011 ;
		internal const U_INT CKM_DSA_KEY_PAIR_GEN = 0x00000010 ;
		internal const U_INT CKM_DSA_PARAMETER_GEN = 0x00002000 ;
		internal const U_INT CKM_DSA_SHA1 = 0x00000012 ;
		internal const U_INT CKM_EC_KEY_PAIR_GEN = 0x00001040 ;
		internal const U_INT CKM_ECDH1_COFACTOR_DERIVE = 0x00001051 ;
		internal const U_INT CKM_ECDH1_DERIVE = 0x00001050 ;
		internal const U_INT CKM_ECDSA = 0x00001041 ;
		internal const U_INT CKM_ECDSA_KEY_PAIR_GEN = 0x00001040 ;
		internal const U_INT CKM_ECDSA_SHA1 = 0x00001042 ;
		internal const U_INT CKM_ECMQV_DERIVE = 0x00001052 ;
		internal const U_INT CKM_EXTRACT_KEY_FROM_KEY = 0x00000365 ;
		internal const U_INT CKM_FASTHASH = 0x00001070 ;
		internal const U_INT CKM_FORTEZZA_TIMESTAMP = 0x00001020 ;
		internal const U_INT CKM_GENERIC_SECRET_KEY_GEN = 0x00000350 ;
		internal const U_INT CKM_IDEA_CBC = 0x00000342 ;
		internal const U_INT CKM_IDEA_CBC_PAD = 0x00000345 ;
		internal const U_INT CKM_IDEA_ECB = 0x00000341 ;
		internal const U_INT CKM_IDEA_KEY_GEN = 0x00000340 ;
		internal const U_INT CKM_IDEA_MAC = 0x00000343 ;
		internal const U_INT CKM_IDEA_MAC_GENERAL = 0x00000344 ;
		internal const U_INT CKM_JUNIPER_CBC128 = 0x00001062 ;
		internal const U_INT CKM_JUNIPER_COUNTER = 0x00001063 ;
		internal const U_INT CKM_JUNIPER_ECB128 = 0x00001061 ;
		internal const U_INT CKM_JUNIPER_KEY_GEN = 0x00001060 ;
		internal const U_INT CKM_JUNIPER_SHUFFLE = 0x00001064 ;
		internal const U_INT CKM_JUNIPER_WRAP = 0x00001065 ;
		internal const U_INT CKM_KEA_KEY_DERIVE = 0x00001011 ;
		internal const U_INT CKM_KEA_KEY_PAIR_GEN = 0x00001010 ;
		internal const U_INT CKM_KEY_WRAP_LYNKS = 0x00000400 ;
		internal const U_INT CKM_KEY_WRAP_SET_OAEP = 0x00000401 ;
		internal const U_INT CKM_MD2 = 0x00000200 ;
		internal const U_INT CKM_MD2_HMAC = 0x00000201 ;
		internal const U_INT CKM_MD2_HMAC_GENERAL = 0x00000202 ;
		internal const U_INT CKM_MD2_KEY_DERIVATION = 0x00000391 ;
		internal const U_INT CKM_MD2_RSA_PKCS = 0x00000004 ;
		internal const U_INT CKM_MD5 = 0x00000210 ;
		internal const U_INT CKM_MD5_HMAC = 0x00000211 ;
		internal const U_INT CKM_MD5_HMAC_GENERAL = 0x00000212 ;
		internal const U_INT CKM_MD5_KEY_DERIVATION = 0x00000390 ;
		internal const U_INT CKM_MD5_RSA_PKCS = 0x00000005 ;
		internal const U_INT CKM_PBA_SHA1_WITH_SHA1_HMAC = 0x000003C0 ;
		internal const U_INT CKM_PBE_MD2_DES_CBC = 0x000003A0 ;
		internal const U_INT CKM_PBE_MD5_CAST_CBC = 0x000003A2 ;
		internal const U_INT CKM_PBE_MD5_CAST128_CBC = 0x000003A4 ;
		internal const U_INT CKM_PBE_MD5_CAST3_CBC = 0x000003A3 ;
		internal const U_INT CKM_PBE_MD5_CAST5_CBC = 0x000003A4 ;
		internal const U_INT CKM_PBE_MD5_DES_CBC = 0x000003A1 ;
		internal const U_INT CKM_PBE_SHA1_CAST128_CBC = 0x000003A5 ;
		internal const U_INT CKM_PBE_SHA1_CAST5_CBC = 0x000003A5 ;
		internal const U_INT CKM_PBE_SHA1_DES2_EDE_CBC = 0x000003A9 ;
		internal const U_INT CKM_PBE_SHA1_DES3_EDE_CBC = 0x000003A8 ;
		internal const U_INT CKM_PBE_SHA1_RC2_128_CBC = 0x000003AA ;
		internal const U_INT CKM_PBE_SHA1_RC2_40_CBC = 0x000003AB ;
		internal const U_INT CKM_PBE_SHA1_RC4_128 = 0x000003A6 ;
		internal const U_INT CKM_PBE_SHA1_RC4_40 = 0x000003A7 ;
		internal const U_INT CKM_PKCS5_PBKD2 = 0x000003B0 ;
		internal const U_INT CKM_RC2_CBC = 0x00000102 ;
		internal const U_INT CKM_RC2_CBC_PAD = 0x00000105 ;
		internal const U_INT CKM_RC2_ECB = 0x00000101 ;
		internal const U_INT CKM_RC2_KEY_GEN = 0x00000100 ;
		internal const U_INT CKM_RC2_MAC = 0x00000103 ;
		internal const U_INT CKM_RC2_MAC_GENERAL = 0x00000104 ;
		internal const U_INT CKM_RC4 = 0x00000111 ;
		internal const U_INT CKM_RC4_KEY_GEN = 0x00000110 ;
		internal const U_INT CKM_RC5_CBC = 0x00000332 ;
		internal const U_INT CKM_RC5_CBC_PAD = 0x00000335 ;
		internal const U_INT CKM_RC5_ECB = 0x00000331 ;
		internal const U_INT CKM_RC5_KEY_GEN = 0x00000330 ;
		internal const U_INT CKM_RC5_MAC = 0x00000333 ;
		internal const U_INT CKM_RC5_MAC_GENERAL = 0x00000334 ;
		internal const U_INT CKM_RIPEMD128 = 0x00000230 ;
		internal const U_INT CKM_RIPEMD128_HMAC = 0x00000231 ;
		internal const U_INT CKM_RIPEMD128_HMAC_GENERAL = 0x00000232 ;
		internal const U_INT CKM_RIPEMD128_RSA_PKCS = 0x00000007 ;
		internal const U_INT CKM_RIPEMD160 = 0x00000240 ;
		internal const U_INT CKM_RIPEMD160_HMAC = 0x00000241 ;
		internal const U_INT CKM_RIPEMD160_HMAC_GENERAL = 0x00000242 ;
		internal const U_INT CKM_RIPEMD160_RSA_PKCS = 0x00000008 ;
		internal const U_INT CKM_RSA_9796 = 0x00000002 ;
		internal const U_INT CKM_RSA_PKCS = 0x00000001 ;
		internal const U_INT CKM_RSA_PKCS_KEY_PAIR_GEN = 0x00000000 ;
		internal const U_INT CKM_RSA_PKCS_OAEP = 0x00000009 ;
		internal const U_INT CKM_RSA_PKCS_PSS = 0x0000000D ;
		internal const U_INT CKM_RSA_X_509 = 0x00000003 ;
		internal const U_INT CKM_RSA_X9_31 = 0x0000000B ;
		internal const U_INT CKM_RSA_X9_31_KEY_PAIR_GEN = 0x0000000A ;
		internal const U_INT CKM_SHA_1 = 0x00000220 ;
		internal const U_INT CKM_SHA_1_HMAC = 0x00000221 ;
		internal const U_INT CKM_SHA_1_HMAC_GENERAL = 0x00000222 ;
		internal const U_INT CKM_SHA1_KEY_DERIVATION = 0x00000392 ;
		internal const U_INT CKM_SHA1_RSA_PKCS = 0x00000006 ;
		internal const U_INT CKM_SHA1_RSA_PKCS_PSS = 0x0000000E ;
		internal const U_INT CKM_SHA1_RSA_X9_31 = 0x0000000C ;
		internal const U_INT CKM_SHA256 = 0x00000250 ;
		internal const U_INT CKM_SHA256_HMAC = 0x00000251 ;
		internal const U_INT CKM_SHA256_HMAC_GENERAL = 0x00000252 ;
		internal const U_INT CKM_SHA256_KEY_DERIVATION = 0x00000393 ;
		internal const U_INT CKM_SHA256_RSA_PKCS = 0x00000040 ;
		internal const U_INT CKM_SHA256_RSA_PKCS_PSS = 0x00000043 ;
		internal const U_INT CKM_SHA384 = 0x00000260 ;
		internal const U_INT CKM_SHA384_HMAC = 0x00000261 ;
		internal const U_INT CKM_SHA384_HMAC_GENERAL = 0x00000262 ;
		internal const U_INT CKM_SHA384_KEY_DERIVATION = 0x00000394 ;
		internal const U_INT CKM_SHA384_RSA_PKCS = 0x00000041 ;
		internal const U_INT CKM_SHA384_RSA_PKCS_PSS = 0x00000044 ;
		internal const U_INT CKM_SHA512 = 0x00000270 ;
		internal const U_INT CKM_SHA512_HMAC = 0x00000271 ;
		internal const U_INT CKM_SHA512_HMAC_GENERAL = 0x00000272 ;
		internal const U_INT CKM_SHA512_KEY_DERIVATION = 0x00000395 ;
		internal const U_INT CKM_SHA512_RSA_PKCS = 0x00000042 ;
		internal const U_INT CKM_SHA512_RSA_PKCS_PSS = 0x00000045 ;
		internal const U_INT CKM_SKIPJACK_CBC64 = 0x00001002 ;
		internal const U_INT CKM_SKIPJACK_CFB16 = 0x00001006 ;
		internal const U_INT CKM_SKIPJACK_CFB32 = 0x00001005 ;
		internal const U_INT CKM_SKIPJACK_CFB64 = 0x00001004 ;
		internal const U_INT CKM_SKIPJACK_CFB8 = 0x00001007 ;
		internal const U_INT CKM_SKIPJACK_ECB64 = 0x00001001 ;
		internal const U_INT CKM_SKIPJACK_KEY_GEN = 0x00001000 ;
		internal const U_INT CKM_SKIPJACK_OFB64 = 0x00001003 ;
		internal const U_INT CKM_SKIPJACK_PRIVATE_WRAP = 0x00001009 ;
		internal const U_INT CKM_SKIPJACK_RELAYX = 0x0000100a ;
		internal const U_INT CKM_SKIPJACK_WRAP = 0x00001008 ;
		internal const U_INT CKM_SSL3_KEY_AND_MAC_DERIVE = 0x00000372 ;
		internal const U_INT CKM_SSL3_MASTER_KEY_DERIVE = 0x00000371 ;
		internal const U_INT CKM_SSL3_MASTER_KEY_DERIVE_DH = 0x00000373 ;
		internal const U_INT CKM_SSL3_MD5_MAC = 0x00000380 ;
		internal const U_INT CKM_SSL3_PRE_MASTER_KEY_GEN = 0x00000370 ;
		internal const U_INT CKM_SSL3_SHA1_MAC = 0x00000381 ;
		internal const U_INT CKM_TLS_KEY_AND_MAC_DERIVE = 0x00000376 ;
		internal const U_INT CKM_TLS_MASTER_KEY_DERIVE = 0x00000375 ;
		internal const U_INT CKM_TLS_MASTER_KEY_DERIVE_DH = 0x00000377 ;
		internal const U_INT CKM_TLS_PRE_MASTER_KEY_GEN = 0x00000374 ;
		internal const U_INT CKM_TLS_PRF = 0x00000378 ;
		internal const U_INT CKM_TWOFISH_CBC = 0x00001093 ;
		internal const U_INT CKM_TWOFISH_KEY_GEN = 0x00001092 ;
		internal const U_INT CKM_VENDOR_DEFINED = 0x80000000 ;
		internal const U_INT CKM_WTLS_CLIENT_KEY_AND_MAC_DERIVE = 0x000003D5 ;
		internal const U_INT CKM_WTLS_MASTER_KEY_DERIVE = 0x000003D1 ;
		internal const U_INT CKM_WTLS_MASTER_KEY_DERVIE_DH_ECC = 0x000003D2 ;
		internal const U_INT CKM_WTLS_PRE_MASTER_KEY_GEN = 0x000003D0 ;
		internal const U_INT CKM_WTLS_PRF = 0x000003D3 ;
		internal const U_INT CKM_WTLS_SERVER_KEY_AND_MAC_DERIVE = 0x000003D4 ;
		internal const U_INT CKM_X9_42_DH_DERIVE = 0x00000031 ;
		internal const U_INT CKM_X9_42_DH_HYBRID_DERIVE = 0x00000032 ;
		internal const U_INT CKM_X9_42_DH_KEY_PAIR_GEN = 0x00000030 ;
		internal const U_INT CKM_X9_42_DH_PARAMETER_GEN = 0x00002002 ;
		internal const U_INT CKM_X9_42_MQV_DERIVE = 0x00000033 ;
		internal const U_INT CKM_XOR_BASE_AND_DATA = 0x00000364 ;
        
        /// <summary>
        /// Механизм для генерации и проверки ЭЦП с использованием в качестве входа
        /// ранее вычисленного значения хэш-функции (32 байта ровно).
        /// </summary>
        internal const U_INT CKM_GOSTR3410 = 0x00001201;

        /// <summary>
        /// Механизм для генерации ключевой пары.
        /// </summary>
        internal const U_INT CKM_GOSTR3410_KEY_PAIR_GEN = 0x00001200;
                
        /// <summary>
        /// Механизм для генерации ключевой пары согласно стандарту ГОСТ Р 34.10-2001.
        /// (From Etoken documentation, см. п.5.2. Параметры цифровой подписи).
        /// </summary>
        internal const U_INT CKM_GOSTR3410_KEY_PAIR_GEN_EX = 0xD4321010;

        /// <summary>
        /// Механизм для генерации и проверки ЭЦП с хэшированием подаваемых на вход данных.
        /// Размер входных данных не ограничен.
        /// </summary>
        internal const U_INT CKM_GOSTR3410_WITH_GOSTR3411 = 0x00001202;
        
        /// <summary>
        /// Механизм для выработки ключа согласования.
        /// </summary>
        internal const U_INT CKM_GOSTR3410_DERIVE = 0x00001204;

        /// <summary>
        /// Механизм вычисления хэш-функции.
        /// </summary>
        internal const U_INT CKM_GOSTR3411 = 0x00001210;

        /// <summary>
        /// Механизм шифрования данных.
        /// </summary>
        internal const U_INT CKM_GOST28147 = 0x00001222;

        /// <summary>
        /// Механизм шифрования данных с использованием метода простой замены.
        /// </summary>
        internal const U_INT CKM_GOST28147_ECB = 0x00001221;

        /// <summary>
        /// Механизм экспорта и импорта открытых ключей.
        /// </summary>
        internal const U_INT CKM_GOST28147_KEY_WRAP = 0x00001224;

        /// <summary>
        /// Механизм выработки симметричных ключей.
        /// </summary>
        internal const U_INT CKM_GOST28147_KEY_GEN = 0x00001220;      


        /// <summary>
        /// Parameters for elleptic curves (according to RFC 4357, paragraph 10.8)
        /// 
        /// Параметры эллиптических кривых (по RFC 4357, п.10.8)
        /// </summary>
        internal static byte[] SC_PARAMSET_GOSTR3410_A = { 0x06, 0x07, 0x2A, 0x85, 0x03, 0x02, 0x02, 0x23, 0x01 };
        internal static byte[] SC_PARAMSET_GOSTR3410_B = { 0x06, 0x07, 0x2A, 0x85, 0x03, 0x02, 0x02, 0x23, 0x02 };
        internal static byte[] SC_PARAMSET_GOSTR3410_C = { 0x06, 0x07, 0x2A, 0x85, 0x03, 0x02, 0x02, 0x23, 0x03 };
        internal static byte[] SC_PARAMSET_GOSTR3410_D = { 0x06, 0x07, 0x2A, 0x85, 0x03, 0x02, 0x02, 0x23, 0x04 };

		internal const U_INT CKN_SURRENDER = 0 ;

		internal const U_INT CKO_CERTIFICATE = 0x00000001 ;
		internal const U_INT CKO_DATA = 0x00000000 ;
		internal const U_INT CKO_DOMAIN_PARAMETERS = 0x00000006 ;
		internal const U_INT CKO_HW_FEATURE = 0x00000005 ;
		internal const U_INT CKO_MECHANISM = 0x00000007 ;
		internal const U_INT CKO_PRIVATE_KEY = 0x00000003 ;
		internal const U_INT CKO_PUBLIC_KEY = 0x00000002 ;
		internal const U_INT CKO_SECRET_KEY = 0x00000004 ;
		internal const U_INT CKO_VENDOR_DEFINED = 0x80000000 ;


		internal const U_INT CKR_ARGUMENTS_BAD = 0x00000007 ;
		internal const U_INT CKR_ATTRIBUTE_READ_ONLY = 0x00000010 ;
		internal const U_INT CKR_ATTRIBUTE_SENSITIVE = 0x00000011 ;
		internal const U_INT CKR_ATTRIBUTE_TYPE_INVALID = 0x00000012 ;
		internal const U_INT CKR_ATTRIBUTE_VALUE_INVALID = 0x00000013 ;
		internal const U_INT CKR_BUFFER_TOO_SMALL = 0x00000150 ;
		internal const U_INT CKR_CANCEL = 0x00000001 ;
		internal const U_INT CKR_CANT_LOCK = 0x0000000A ;
		internal const U_INT CKR_CRYPTOKI_ALREADY_INITIALIZED = 0x00000191 ;
		internal const U_INT CKR_CRYPTOKI_NOT_INITIALIZED = 0x00000190 ;
		internal const U_INT CKR_DATA_INVALID = 0x00000020 ;
		internal const U_INT CKR_DATA_LEN_RANGE = 0x00000021 ;
		internal const U_INT CKR_DEVICE_ERROR = 0x00000030 ;
		internal const U_INT CKR_DEVICE_MEMORY = 0x00000031 ;
		internal const U_INT CKR_DEVICE_REMOVED = 0x00000032 ;
		internal const U_INT CKR_DOMAIN_PARAMS_INVALID = 0x00000130 ;
		internal const U_INT CKR_ENCRYPTED_DATA_INVALID = 0x00000040 ;
		internal const U_INT CKR_ENCRYPTED_DATA_LEN_RANGE = 0x00000041 ;
		internal const U_INT CKR_FUNCTION_CANCELED = 0x00000050 ;
		internal const U_INT CKR_FUNCTION_FAILED = 0x00000006 ;
		internal const U_INT CKR_FUNCTION_NOT_PARALLEL = 0x00000051 ;
		internal const U_INT CKR_FUNCTION_NOT_SUPPORTED = 0x00000054 ;
		internal const U_INT CKR_FUNCTION_REJECTED = 0x00000200 ;
		internal const U_INT CKR_GENERAL_ERROR = 0x00000005 ;
		internal const U_INT CKR_HOST_MEMORY = 0x00000002 ;
		internal const U_INT CKR_INFORMATION_SENSITIVE = 0x00000170 ;
		internal const U_INT CKR_KEY_CHANGED = 0x00000065 ;
		internal const U_INT CKR_KEY_FUNCTION_NOT_PERMITTED = 0x00000068 ;
		internal const U_INT CKR_KEY_HANDLE_INVALID = 0x00000060 ;
		internal const U_INT CKR_KEY_INDIGESTIBLE = 0x00000067 ;
		internal const U_INT CKR_KEY_NEEDED = 0x00000066 ;
		internal const U_INT CKR_KEY_NOT_NEEDED = 0x00000064 ;
		internal const U_INT CKR_KEY_NOT_WRAPPABLE = 0x00000069 ;
		internal const U_INT CKR_KEY_SIZE_RANGE = 0x00000062 ;
		internal const U_INT CKR_KEY_TYPE_INCONSISTENT = 0x00000063 ;
		internal const U_INT CKR_KEY_UNEXTRACTABLE = 0x0000006A ;
		internal const U_INT CKR_MECHANISM_INVALID = 0x00000070 ;
		internal const U_INT CKR_MECHANISM_PARAM_INVALID = 0x00000071 ;
		internal const U_INT CKR_MUTEX_BAD = 0x000001A0 ;
		internal const U_INT CKR_MUTEX_NOT_LOCKED = 0x000001A1 ;
		internal const U_INT CKR_NEED_TO_CREATE_THREADS = 0x00000009 ;
		internal const U_INT CKR_NO_EVENT = 0x00000008 ;
		internal const U_INT CKR_OBJECT_HANDLE_INVALID = 0x00000082 ;
		internal const U_INT CKR_OK = 0x00000000 ;
		internal const U_INT CKR_OPERATION_ACTIVE = 0x00000090 ;
		internal const U_INT CKR_OPERATION_NOT_INITIALIZED = 0x00000091 ;
		internal const U_INT CKR_PIN_EXPIRED = 0x000000A3 ;
		internal const U_INT CKR_PIN_INCORRECT = 0x000000A0 ;
		internal const U_INT CKR_PIN_INVALID = 0x000000A1 ;
		internal const U_INT CKR_PIN_LEN_RANGE = 0x000000A2 ;
		internal const U_INT CKR_PIN_LOCKED = 0x000000A4 ;
		internal const U_INT CKR_RANDOM_NO_RNG = 0x00000121 ;
		internal const U_INT CKR_RANDOM_SEED_NOT_SUPPORTED = 0x00000120 ;
		internal const U_INT CKR_SAVED_STATE_INVALID = 0x00000160 ;
		internal const U_INT CKR_SESSION_CLOSED = 0x000000B0 ;
		internal const U_INT CKR_SESSION_COUNT = 0x000000B1 ;
		internal const U_INT CKR_SESSION_EXISTS = 0x000000B6 ;
		internal const U_INT CKR_SESSION_HANDLE_INVALID = 0x000000B3 ;
		internal const U_INT CKR_SESSION_PARALLEL_NOT_SUPPORTED = 0x000000B4 ;
		internal const U_INT CKR_SESSION_READ_ONLY = 0x000000B5 ;
		internal const U_INT CKR_SESSION_READ_ONLY_EXISTS = 0x000000B7 ;
		internal const U_INT CKR_SESSION_READ_WRITE_SO_EXISTS = 0x000000B8 ;
		internal const U_INT CKR_SIGNATURE_INVALID = 0x000000C0 ;
		internal const U_INT CKR_SIGNATURE_LEN_RANGE = 0x000000C1 ;
		internal const U_INT CKR_SLOT_ID_INVALID = 0x00000003 ;
		internal const U_INT CKR_STATE_UNSAVEABLE = 0x00000180 ;
		internal const U_INT CKR_TEMPLATE_INCOMPLETE = 0x000000D0 ;
		internal const U_INT CKR_TEMPLATE_INCONSISTENT = 0x000000D1 ;
		internal const U_INT CKR_TOKEN_NOT_PRESENT = 0x000000E0 ;
		internal const U_INT CKR_TOKEN_NOT_RECOGNIZED = 0x000000E1 ;
		internal const U_INT CKR_TOKEN_WRITE_PROTECTED = 0x000000E2 ;
		internal const U_INT CKR_UNWRAPPING_KEY_HANDLE_INVALID = 0x000000F0 ;
		internal const U_INT CKR_UNWRAPPING_KEY_SIZE_RANGE = 0x000000F1 ;
		internal const U_INT CKR_UNWRAPPING_KEY_TYPE_INCONSISTENT = 0x000000F2 ;
		internal const U_INT CKR_USER_ALREADY_LOGGED_IN = 0x00000100 ;
		internal const U_INT CKR_USER_ANOTHER_ALREADY_LOGGED_IN = 0x00000104 ;
		internal const U_INT CKR_USER_NOT_LOGGED_IN = 0x00000101 ;
		internal const U_INT CKR_USER_PIN_NOT_INITIALIZED = 0x00000102 ;
		internal const U_INT CKR_USER_TOO_MANY_TYPES = 0x00000105 ;
		internal const U_INT CKR_USER_TYPE_INVALID = 0x00000103 ;
		internal const U_INT CKR_VENDOR_DEFINED = 0x80000000;
		internal const U_INT CKR_WRAPPED_KEY_INVALID = 0x00000110 ;
		internal const U_INT CKR_WRAPPED_KEY_LEN_RANGE = 0x00000112 ;
		internal const U_INT CKR_WRAPPING_KEY_HANDLE_INVALID = 0x00000113 ;
		internal const U_INT CKR_WRAPPING_KEY_SIZE_RANGE = 0x00000114 ;
		internal const U_INT CKR_WRAPPING_KEY_TYPE_INCONSISTENT = 0x00000115 ;

		internal const U_INT CKS_RO_PUBLIC_SESSION = 0 ;
		internal const U_INT CKS_RO_USER_FUNCTIONS = 1 ;
		internal const U_INT CKS_RW_PUBLIC_SESSION = 2 ;
		internal const U_INT CKS_RW_SO_FUNCTIONS = 4 ;
		internal const U_INT CKS_RW_USER_FUNCTIONS = 3 ;

		internal const U_INT CKU_CONTEXT_SPECIFIC = 2 ;
		internal const U_INT CKU_SO = 0 ;
		internal const U_INT CKU_USER = 1 ;
	}
}

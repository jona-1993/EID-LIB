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
	/// Description of CKR.
	/// </summary>
	public enum CKR:U_INT{
		OK = PKCS11Constants.CKR_OK,
		CANCEL = PKCS11Constants.CKR_CANCEL,
		HOST_MEMORY = PKCS11Constants.CKR_HOST_MEMORY,
		SLOT_ID_INVALID = PKCS11Constants.CKR_SLOT_ID_INVALID,
		GENERAL_ERROR = PKCS11Constants.CKR_GENERAL_ERROR,
		FUNCTION_FAILED = PKCS11Constants.CKR_FUNCTION_FAILED,
		ARGUMENTS_BAD = PKCS11Constants.CKR_ARGUMENTS_BAD,
		NO_EVENT = PKCS11Constants.CKR_NO_EVENT,
		NEED_TO_CREATE_THREADS = PKCS11Constants.CKR_NEED_TO_CREATE_THREADS,
		CANT_LOCK = PKCS11Constants.CKR_CANT_LOCK,
		ATTRIBUTE_READ_ONLY = PKCS11Constants.CKR_ATTRIBUTE_READ_ONLY,
		ATTRIBUTE_SENSITIVE = PKCS11Constants.CKR_ATTRIBUTE_SENSITIVE,
		ATTRIBUTE_TYPE_INVALID = PKCS11Constants.CKR_ATTRIBUTE_TYPE_INVALID,
		ATTRIBUTE_VALUE_INVALID = PKCS11Constants.CKR_ATTRIBUTE_VALUE_INVALID,
		DATA_INVALID = PKCS11Constants.CKR_DATA_INVALID,
		DATA_LEN_RANGE = PKCS11Constants.CKR_DATA_LEN_RANGE,
		DEVICE_ERROR = PKCS11Constants.CKR_DEVICE_ERROR,
		DEVICE_MEMORY = PKCS11Constants.CKR_DEVICE_MEMORY,
		DEVICE_REMOVED = PKCS11Constants.CKR_DEVICE_REMOVED,
		ENCRYPTED_DATA_INVALID = PKCS11Constants.CKR_ENCRYPTED_DATA_INVALID,
		ENCRYPTED_DATA_LEN_RANGE = PKCS11Constants.CKR_ENCRYPTED_DATA_LEN_RANGE,
		FUNCTION_CANCELED = PKCS11Constants.CKR_FUNCTION_CANCELED,
		FUNCTION_NOT_PARALLEL = PKCS11Constants.CKR_FUNCTION_NOT_PARALLEL,
		FUNCTION_NOT_SUPPORTED = PKCS11Constants.CKR_FUNCTION_NOT_SUPPORTED,
		KEY_HANDLE_INVALID = PKCS11Constants.CKR_KEY_HANDLE_INVALID,
		KEY_SIZE_RANGE = PKCS11Constants.CKR_KEY_SIZE_RANGE,
		KEY_TYPE_INCONSISTENT = PKCS11Constants.CKR_KEY_TYPE_INCONSISTENT,
		KEY_NOT_NEEDED = PKCS11Constants.CKR_KEY_NOT_NEEDED,
		KEY_CHANGED = PKCS11Constants.CKR_KEY_CHANGED,
		KEY_NEEDED = PKCS11Constants.CKR_KEY_NEEDED,
		KEY_INDIGESTIBLE = PKCS11Constants.CKR_KEY_INDIGESTIBLE,
		KEY_FUNCTION_NOT_PERMITTED = PKCS11Constants.CKR_KEY_FUNCTION_NOT_PERMITTED,
		KEY_NOT_WRAPPABLE = PKCS11Constants.CKR_KEY_NOT_WRAPPABLE,
		KEY_UNEXTRACTABLE = PKCS11Constants.CKR_KEY_UNEXTRACTABLE,
		MECHANISM_INVALID = PKCS11Constants.CKR_MECHANISM_INVALID,
		MECHANISM_PARAM_INVALID = PKCS11Constants.CKR_MECHANISM_PARAM_INVALID,
		OBJECT_HANDLE_INVALID = PKCS11Constants.CKR_OBJECT_HANDLE_INVALID,
		OPERATION_ACTIVE = PKCS11Constants.CKR_OPERATION_ACTIVE,
		OPERATION_NOT_INITIALIZED = PKCS11Constants.CKR_OPERATION_NOT_INITIALIZED,
		PIN_INCORRECT = PKCS11Constants.CKR_PIN_INCORRECT,
		PIN_INVALID = PKCS11Constants.CKR_PIN_INVALID,
		PIN_LEN_RANGE = PKCS11Constants.CKR_PIN_LEN_RANGE,
		PIN_EXPIRED = PKCS11Constants.CKR_PIN_EXPIRED,
		PIN_LOCKED = PKCS11Constants.CKR_PIN_LOCKED,
		SESSION_CLOSED = PKCS11Constants.CKR_SESSION_CLOSED,
		SESSION_COUNT = PKCS11Constants.CKR_SESSION_COUNT,
		SESSION_HANDLE_INVALID = PKCS11Constants.CKR_SESSION_HANDLE_INVALID,
		SESSION_PARALLEL_NOT_SUPPORTED = PKCS11Constants.CKR_SESSION_PARALLEL_NOT_SUPPORTED,
		SESSION_READ_ONLY = PKCS11Constants.CKR_SESSION_READ_ONLY,
		SESSION_EXISTS = PKCS11Constants.CKR_SESSION_EXISTS,
		SESSION_READ_ONLY_EXISTS = PKCS11Constants.CKR_SESSION_READ_ONLY_EXISTS,
		SESSION_READ_WRITE_SO_EXISTS = PKCS11Constants.CKR_SESSION_READ_WRITE_SO_EXISTS,
		SIGNATURE_INVALID = PKCS11Constants.CKR_SIGNATURE_INVALID,
		SIGNATURE_LEN_RANGE = PKCS11Constants.CKR_SIGNATURE_LEN_RANGE,
		TEMPLATE_INCOMPLETE = PKCS11Constants.CKR_TEMPLATE_INCOMPLETE,
		TEMPLATE_INCONSISTENT = PKCS11Constants.CKR_TEMPLATE_INCONSISTENT,
		TOKEN_NOT_PRESENT = PKCS11Constants.CKR_TOKEN_NOT_PRESENT,
		TOKEN_NOT_RECOGNIZED = PKCS11Constants.CKR_TOKEN_NOT_RECOGNIZED,
		TOKEN_WRITE_PROTECTED = PKCS11Constants.CKR_TOKEN_WRITE_PROTECTED,
		UNWRAPPING_KEY_HANDLE_INVALID = PKCS11Constants.CKR_UNWRAPPING_KEY_HANDLE_INVALID,
		UNWRAPPING_KEY_SIZE_RANGE = PKCS11Constants.CKR_UNWRAPPING_KEY_SIZE_RANGE,
		UNWRAPPING_KEY_TYPE_INCONSISTENT = PKCS11Constants.CKR_UNWRAPPING_KEY_TYPE_INCONSISTENT,
		USER_ALREADY_LOGGED_IN = PKCS11Constants.CKR_USER_ALREADY_LOGGED_IN,
		USER_NOT_LOGGED_IN = PKCS11Constants.CKR_USER_NOT_LOGGED_IN,
		USER_PIN_NOT_INITIALIZED = PKCS11Constants.CKR_USER_PIN_NOT_INITIALIZED,
		USER_TYPE_INVALID = PKCS11Constants.CKR_USER_TYPE_INVALID,
		USER_ANOTHER_ALREADY_LOGGED_IN = PKCS11Constants.CKR_USER_ANOTHER_ALREADY_LOGGED_IN,
		USER_TOO_MANY_TYPES = PKCS11Constants.CKR_USER_TOO_MANY_TYPES,
		WRAPPED_KEY_INVALID = PKCS11Constants.CKR_WRAPPED_KEY_INVALID,
		WRAPPED_KEY_LEN_RANGE = PKCS11Constants.CKR_WRAPPED_KEY_LEN_RANGE,
		WRAPPING_KEY_HANDLE_INVALID = PKCS11Constants.CKR_WRAPPING_KEY_HANDLE_INVALID,
		WRAPPING_KEY_SIZE_RANGE = PKCS11Constants.CKR_WRAPPING_KEY_SIZE_RANGE,
		WRAPPING_KEY_TYPE_INCONSISTENT = PKCS11Constants.CKR_WRAPPING_KEY_TYPE_INCONSISTENT,
		RANDOM_SEED_NOT_SUPPORTED = PKCS11Constants.CKR_RANDOM_SEED_NOT_SUPPORTED,
		RANDOM_NO_RNG = PKCS11Constants.CKR_RANDOM_NO_RNG,
		DOMAIN_PARAMS_INVALID = PKCS11Constants.CKR_DOMAIN_PARAMS_INVALID,
		BUFFER_TOO_SMALL = PKCS11Constants.CKR_BUFFER_TOO_SMALL,
		SAVED_STATE_INVALID = PKCS11Constants.CKR_SAVED_STATE_INVALID,
		INFORMATION_SENSITIVE = PKCS11Constants.CKR_INFORMATION_SENSITIVE,
		STATE_UNSAVEABLE = PKCS11Constants.CKR_STATE_UNSAVEABLE,
		CRYPTOKI_NOT_INITIALIZED = PKCS11Constants.CKR_CRYPTOKI_NOT_INITIALIZED,
		CRYPTOKI_ALREADY_INITIALIZED = PKCS11Constants.CKR_CRYPTOKI_ALREADY_INITIALIZED,
		MUTEX_BAD = PKCS11Constants.CKR_MUTEX_BAD,
		MUTEX_NOT_LOCKED = PKCS11Constants.CKR_MUTEX_NOT_LOCKED,
		FUNCTION_REJECTED = PKCS11Constants.CKR_FUNCTION_REJECTED,
		VENDOR_DEFINED = PKCS11Constants.CKR_VENDOR_DEFINED
	}
}

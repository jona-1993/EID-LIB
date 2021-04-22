
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
    /// Description of GostPrivateKey.
    /// </summary>
    public class GostPrivateKey : PrivateKey
    {
        /// <summary>
        /// Params.
        /// </summary>
        protected ByteArrayAttribute params_ = new ByteArrayAttribute((U_INT)CKA.GOSTR3410PARAMS);
        public ByteArrayAttribute Params
        {
            get { return params_; }
        }

        public GostPrivateKey()
        {
            this.KeyType.KeyType = CKK.GOST;
            params_.Value = PKCS11Constants.SC_PARAMSET_GOSTR3410_A;
        }

        public GostPrivateKey(Session session, U_INT hObj)
            : base(session, hObj)
        {
            params_.Value = PKCS11Constants.SC_PARAMSET_GOSTR3410_A;
        }

        public static new P11Object GetInstance(Session session, U_INT hObj)
        {
            return new GostPrivateKey(session, hObj);
        }

        public override void ReadAttributes(Session session)
        {
            base.ReadAttributes(session);

            params_ = ReadAttribute(session, HObj, params_);
        }

    }
}

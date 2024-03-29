﻿
using System;
using Net.Sf.Pkcs11.Wrapper;
using Net.Sf.Pkcs11.Params;

using U_INT =
#if Windows
        System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11.Objects
{
    /// <summary>
    /// Description of Mechanism.
    /// </summary>
    public class Mechanism
    {
        public Mechanism(CKM ckm)
        {
            this.ckm = ckm;
            this.parameters = Parameters.GetParameters(ckm);
        }

        public Mechanism(CK_MECHANISM ckMechanism)
        {
            this.ckm = (CKM)ckMechanism.mechanism;
            this.parameters = Parameters.GetParameters(ckm);
        }

        private CKM ckm;
        private Parameters parameters;

        public Parameters Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

        public CK_MECHANISM CK_MECHANISM
        {
            get
            {
                CK_MECHANISM mech = new CK_MECHANISM();
                mech.mechanism = (U_INT)ckm;

                parameters.ApplyToMechanism(mech);

                return mech;
            }
        }
    }
}


using System;

using U_INT =
#if Windows
		System.UInt32;
#else
		System.UInt64;
#endif

namespace Net.Sf.Pkcs11
{
	/// <summary>
	/// Description of Slot.
	/// </summary>
	public class Slot
	{
		Module m;
		
		public Module Module {
			get { return m; }
		}
		U_INT slotId;
		
		public U_INT SlotId {
			get { return slotId; }
		}
		
		public SlotInfo SlotInfo {
			get{
				return new SlotInfo( m.P11Module.GetSlotInfo(slotId) );
			}
		}
		
		public Token Token{
			get{
				Token localToken = null;

				if (SlotInfo.IsTokenPresent) {
					localToken = new Token(this);
				}

				return localToken;
			}
		}
		
		public Slot(Module m, U_INT slotId){
			this.m=m;
			this.slotId=slotId;
		}
	}
}

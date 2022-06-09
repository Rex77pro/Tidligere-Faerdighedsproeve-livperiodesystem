using System;
using System.Collections.Generic;
using System.Text;

namespace Tidligere_Færdighedsprøve_livperiodesystem
{
    class HoldAktivitet : Aktivitet
    {
        public string HoldId { get; set; }
        

        public HoldAktivitet(int iD, int minAlder, int maxAlder, DateTime startPunkt, DateTime slutPunkt, string holdId) 
            : base (iD, minAlder, maxAlder, startPunkt, slutPunkt)
        {
            HoldId = holdId;
        }

        public override string ToString()
        {
            return $"ID: {ID} | Hold id. {HoldId} | Aldersgrænse: {MinAlder} - {MaxAlder} år | Starter: {StartTidsPunkt}, Slutter: {SlutTidsPunkt.TimeOfDay}";        }
    }
}

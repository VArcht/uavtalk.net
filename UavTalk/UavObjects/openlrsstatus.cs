using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum OpenLRSStatus_FailsafeActive { Inactive, Active };

    public class OpenLRSStatus: UavDataObject
    {
        public UInt16 LinkQuality {
            get { return mLinkQuality; }
            set { mLinkQuality = value; NotifyUpdated(); }
        }

        public byte LastRSSI {
            get { return mLastRSSI; }
            set { mLastRSSI = value; NotifyUpdated(); }
        }

        public OpenLRSStatus_FailsafeActive FailsafeActive {
            get { return mFailsafeActive; }
            set { mFailsafeActive = value; NotifyUpdated(); }
        }

        public OpenLRSStatus()
        {
            IsSingleInstance = true;
            ObjectId = 0xb26781ca;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mLinkQuality);
            s.Write(mLastRSSI);
            s.Write((byte)mFailsafeActive);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mLinkQuality = stream.ReadUInt16();
            this.mLastRSSI = stream.ReadByte();
            this.mFailsafeActive = (OpenLRSStatus_FailsafeActive)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("OpenLRSStatus \n");
            sb.AppendFormat("    LinkQuality: {0} \n", LinkQuality);
            sb.AppendFormat("    LastRSSI: {0} \n", LastRSSI);
            sb.AppendFormat("    FailsafeActive: {0} function\n", FailsafeActive);

            return sb.ToString();
        }

        private UInt16 mLinkQuality;
        private byte mLastRSSI;
        private OpenLRSStatus_FailsafeActive mFailsafeActive = OpenLRSStatus_FailsafeActive.Inactive;
    }
}

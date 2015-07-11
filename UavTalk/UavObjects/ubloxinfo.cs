using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class UBloxInfo: UavDataObject
    {
        public UInt32 swVersion {
            get { return mswVersion; }
            set { mswVersion = value; NotifyUpdated(); }
        }

        public UInt32 ParseErrors {
            get { return mParseErrors; }
            set { mParseErrors = value; NotifyUpdated(); }
        }

        public UInt16 hwVersion {
            get { return mhwVersion; }
            set { mhwVersion = value; NotifyUpdated(); }
        }

        public UBloxInfo()
        {
            IsSingleInstance = true;
            ObjectId = 0x4d06ca1c;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mswVersion);
            s.Write(mParseErrors);
            s.Write(mhwVersion);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mswVersion = stream.ReadUInt32();
            this.mParseErrors = stream.ReadUInt32();
            this.mhwVersion = stream.ReadUInt16();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("UBloxInfo \n");
            sb.AppendFormat("    swVersion: {0} \n", swVersion);
            sb.AppendFormat("    ParseErrors: {0} \n", ParseErrors);
            sb.AppendFormat("    hwVersion: {0} \n", hwVersion);

            return sb.ToString();
        }

        private UInt32 mswVersion;
        private UInt32 mParseErrors;
        private UInt16 mhwVersion;
    }
}

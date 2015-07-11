using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class RFM22BReceiver: UavDataObject
    {
        public Int16[] Channel {
            get { return mChannel; }
            set { mChannel = value; NotifyUpdated(); }
        }

        public RFM22BReceiver()
        {
            IsSingleInstance = true;
            ObjectId = 0xdeecd7b6;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mChannel[0]);  // NO_ELEMENT_NAME
            s.Write(mChannel[1]);  // NO_ELEMENT_NAME
            s.Write(mChannel[2]);  // NO_ELEMENT_NAME
            s.Write(mChannel[3]);  // NO_ELEMENT_NAME
            s.Write(mChannel[4]);  // NO_ELEMENT_NAME
            s.Write(mChannel[5]);  // NO_ELEMENT_NAME
            s.Write(mChannel[6]);  // NO_ELEMENT_NAME
            s.Write(mChannel[7]);  // NO_ELEMENT_NAME
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mChannel[0] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[1] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[2] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[3] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[4] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[5] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[6] = stream.ReadInt16();  // NO_ELEMENT_NAME
            this.mChannel[7] = stream.ReadInt16();  // NO_ELEMENT_NAME
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("RFM22BReceiver \n");
            sb.Append("    Channel\n");
            sb.AppendFormat("        : {0} us\n", Channel[0]);
            sb.AppendFormat("        : {0} us\n", Channel[1]);
            sb.AppendFormat("        : {0} us\n", Channel[2]);
            sb.AppendFormat("        : {0} us\n", Channel[3]);
            sb.AppendFormat("        : {0} us\n", Channel[4]);
            sb.AppendFormat("        : {0} us\n", Channel[5]);
            sb.AppendFormat("        : {0} us\n", Channel[6]);
            sb.AppendFormat("        : {0} us\n", Channel[7]);

            return sb.ToString();
        }

        private Int16[] mChannel = new Int16[8] ;
    }
}

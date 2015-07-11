using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class GeoFenceSettings: UavDataObject
    {
        public UInt16 WarningRadius {
            get { return mWarningRadius; }
            set { mWarningRadius = value; NotifyUpdated(); }
        }

        public UInt16 ErrorRadius {
            get { return mErrorRadius; }
            set { mErrorRadius = value; NotifyUpdated(); }
        }

        public GeoFenceSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xdf5ea7fe;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mWarningRadius);
            s.Write(mErrorRadius);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mWarningRadius = stream.ReadUInt16();
            this.mErrorRadius = stream.ReadUInt16();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("GeoFenceSettings \n");
            sb.AppendFormat("    WarningRadius: {0} m\n", WarningRadius);
            sb.AppendFormat("    ErrorRadius: {0} m\n", ErrorRadius);

            return sb.ToString();
        }

        private UInt16 mWarningRadius = 200;
        private UInt16 mErrorRadius = 250;
    }
}

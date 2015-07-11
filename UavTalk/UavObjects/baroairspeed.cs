using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum BaroAirspeed_BaroConnected { False, True };

    public class BaroAirspeed: UavDataObject
    {
        public float CalibratedAirspeed {
            get { return mCalibratedAirspeed; }
            set { mCalibratedAirspeed = value; NotifyUpdated(); }
        }

        public float GPSAirspeed {
            get { return mGPSAirspeed; }
            set { mGPSAirspeed = value; NotifyUpdated(); }
        }

        public float TrueAirspeed {
            get { return mTrueAirspeed; }
            set { mTrueAirspeed = value; NotifyUpdated(); }
        }

        public UInt16 SensorValue {
            get { return mSensorValue; }
            set { mSensorValue = value; NotifyUpdated(); }
        }

        public BaroAirspeed_BaroConnected BaroConnected {
            get { return mBaroConnected; }
            set { mBaroConnected = value; NotifyUpdated(); }
        }

        public BaroAirspeed()
        {
            IsSingleInstance = true;
            ObjectId = 0x10d6bd7c;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mCalibratedAirspeed);
            s.Write(mGPSAirspeed);
            s.Write(mTrueAirspeed);
            s.Write(mSensorValue);
            s.Write((byte)mBaroConnected);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mCalibratedAirspeed = stream.ReadSingle();
            this.mGPSAirspeed = stream.ReadSingle();
            this.mTrueAirspeed = stream.ReadSingle();
            this.mSensorValue = stream.ReadUInt16();
            this.mBaroConnected = (BaroAirspeed_BaroConnected)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("BaroAirspeed \n");
            sb.AppendFormat("    CalibratedAirspeed: {0} m/s\n", CalibratedAirspeed);
            sb.AppendFormat("    GPSAirspeed: {0} m/s\n", GPSAirspeed);
            sb.AppendFormat("    TrueAirspeed: {0} m/s\n", TrueAirspeed);
            sb.AppendFormat("    SensorValue: {0} raw\n", SensorValue);
            sb.AppendFormat("    BaroConnected: {0} \n", BaroConnected);

            return sb.ToString();
        }

        private float mCalibratedAirspeed;
        private float mGPSAirspeed;
        private float mTrueAirspeed;
        private UInt16 mSensorValue;
        private BaroAirspeed_BaroConnected mBaroConnected;
    }
}

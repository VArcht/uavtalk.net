using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class AltitudeHoldState: UavDataObject
    {
        public float VelocityDesired {
            get { return mVelocityDesired; }
            set { mVelocityDesired = value; NotifyUpdated(); }
        }

        public float Integral {
            get { return mIntegral; }
            set { mIntegral = value; NotifyUpdated(); }
        }

        public float AngleGain {
            get { return mAngleGain; }
            set { mAngleGain = value; NotifyUpdated(); }
        }

        public float Throttle {
            get { return mThrottle; }
            set { mThrottle = value; NotifyUpdated(); }
        }

        public AltitudeHoldState()
        {
            IsSingleInstance = true;
            ObjectId = 0x48695320;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mVelocityDesired);
            s.Write(mIntegral);
            s.Write(mAngleGain);
            s.Write(mThrottle);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mVelocityDesired = stream.ReadSingle();
            this.mIntegral = stream.ReadSingle();
            this.mAngleGain = stream.ReadSingle();
            this.mThrottle = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("AltitudeHoldState \n");
            sb.AppendFormat("    VelocityDesired: {0} m/s\n", VelocityDesired);
            sb.AppendFormat("    Integral: {0} \n", Integral);
            sb.AppendFormat("    AngleGain: {0} \n", AngleGain);
            sb.AppendFormat("    Throttle: {0} \n", Throttle);

            return sb.ToString();
        }

        private float mVelocityDesired;
        private float mIntegral;
        private float mAngleGain;
        private float mThrottle;
    }
}

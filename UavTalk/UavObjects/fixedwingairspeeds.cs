using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class FixedWingAirspeeds: UavDataObject
    {
        public float AirSpeedMax {
            get { return mAirSpeedMax; }
            set { mAirSpeedMax = value; NotifyUpdated(); }
        }

        public float CruiseSpeed {
            get { return mCruiseSpeed; }
            set { mCruiseSpeed = value; NotifyUpdated(); }
        }

        public float BestClimbRateSpeed {
            get { return mBestClimbRateSpeed; }
            set { mBestClimbRateSpeed = value; NotifyUpdated(); }
        }

        public float StallSpeedClean {
            get { return mStallSpeedClean; }
            set { mStallSpeedClean = value; NotifyUpdated(); }
        }

        public float StallSpeedDirty {
            get { return mStallSpeedDirty; }
            set { mStallSpeedDirty = value; NotifyUpdated(); }
        }

        public float VerticalVelMax {
            get { return mVerticalVelMax; }
            set { mVerticalVelMax = value; NotifyUpdated(); }
        }

        public FixedWingAirspeeds()
        {
            IsSingleInstance = true;
            ObjectId = 0x03fcf7f6;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mAirSpeedMax);
            s.Write(mCruiseSpeed);
            s.Write(mBestClimbRateSpeed);
            s.Write(mStallSpeedClean);
            s.Write(mStallSpeedDirty);
            s.Write(mVerticalVelMax);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mAirSpeedMax = stream.ReadSingle();
            this.mCruiseSpeed = stream.ReadSingle();
            this.mBestClimbRateSpeed = stream.ReadSingle();
            this.mStallSpeedClean = stream.ReadSingle();
            this.mStallSpeedDirty = stream.ReadSingle();
            this.mVerticalVelMax = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("FixedWingAirspeeds \n");
            sb.AppendFormat("    AirSpeedMax: {0} m/s\n", AirSpeedMax);
            sb.AppendFormat("    CruiseSpeed: {0} m/s\n", CruiseSpeed);
            sb.AppendFormat("    BestClimbRateSpeed: {0} m/s\n", BestClimbRateSpeed);
            sb.AppendFormat("    StallSpeedClean: {0} m/s\n", StallSpeedClean);
            sb.AppendFormat("    StallSpeedDirty: {0} m/s\n", StallSpeedDirty);
            sb.AppendFormat("    VerticalVelMax: {0} m/s\n", VerticalVelMax);

            return sb.ToString();
        }

        private float mAirSpeedMax = 20f;
        private float mCruiseSpeed = 15f;
        private float mBestClimbRateSpeed = 11f;
        private float mStallSpeedClean = 8f;
        private float mStallSpeedDirty = 8f;
        private float mVerticalVelMax = 10f;
    }
}

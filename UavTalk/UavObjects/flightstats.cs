using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum FlightStats_State { IDLE, RESET, COLLECTING };

    public class FlightStats: UavDataObject
    {
        public float DistanceTravelled {
            get { return mDistanceTravelled; }
            set { mDistanceTravelled = value; NotifyUpdated(); }
        }

        public float MaxDistanceToHome {
            get { return mMaxDistanceToHome; }
            set { mMaxDistanceToHome = value; NotifyUpdated(); }
        }

        public float MaxClimbRate {
            get { return mMaxClimbRate; }
            set { mMaxClimbRate = value; NotifyUpdated(); }
        }

        public float MaxDescentRate {
            get { return mMaxDescentRate; }
            set { mMaxDescentRate = value; NotifyUpdated(); }
        }

        public float MaxGroundSpeed {
            get { return mMaxGroundSpeed; }
            set { mMaxGroundSpeed = value; NotifyUpdated(); }
        }

        public float MaxAirSpeed {
            get { return mMaxAirSpeed; }
            set { mMaxAirSpeed = value; NotifyUpdated(); }
        }

        public UInt16 MaxAltitude {
            get { return mMaxAltitude; }
            set { mMaxAltitude = value; NotifyUpdated(); }
        }

        public UInt16 MaxRollRate {
            get { return mMaxRollRate; }
            set { mMaxRollRate = value; NotifyUpdated(); }
        }

        public UInt16 MaxPitchRate {
            get { return mMaxPitchRate; }
            set { mMaxPitchRate = value; NotifyUpdated(); }
        }

        public UInt16 MaxYawRate {
            get { return mMaxYawRate; }
            set { mMaxYawRate = value; NotifyUpdated(); }
        }

        public UInt16 ConsumedEnergy {
            get { return mConsumedEnergy; }
            set { mConsumedEnergy = value; NotifyUpdated(); }
        }

        public UInt16 InitialBatteryVoltage {
            get { return mInitialBatteryVoltage; }
            set { mInitialBatteryVoltage = value; NotifyUpdated(); }
        }

        public FlightStats_State State {
            get { return mState; }
            set { mState = value; NotifyUpdated(); }
        }

        public FlightStats()
        {
            IsSingleInstance = true;
            ObjectId = 0xd315b0b6;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mDistanceTravelled);
            s.Write(mMaxDistanceToHome);
            s.Write(mMaxClimbRate);
            s.Write(mMaxDescentRate);
            s.Write(mMaxGroundSpeed);
            s.Write(mMaxAirSpeed);
            s.Write(mMaxAltitude);
            s.Write(mMaxRollRate);
            s.Write(mMaxPitchRate);
            s.Write(mMaxYawRate);
            s.Write(mConsumedEnergy);
            s.Write(mInitialBatteryVoltage);
            s.Write((byte)mState);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mDistanceTravelled = stream.ReadSingle();
            this.mMaxDistanceToHome = stream.ReadSingle();
            this.mMaxClimbRate = stream.ReadSingle();
            this.mMaxDescentRate = stream.ReadSingle();
            this.mMaxGroundSpeed = stream.ReadSingle();
            this.mMaxAirSpeed = stream.ReadSingle();
            this.mMaxAltitude = stream.ReadUInt16();
            this.mMaxRollRate = stream.ReadUInt16();
            this.mMaxPitchRate = stream.ReadUInt16();
            this.mMaxYawRate = stream.ReadUInt16();
            this.mConsumedEnergy = stream.ReadUInt16();
            this.mInitialBatteryVoltage = stream.ReadUInt16();
            this.mState = (FlightStats_State)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("FlightStats \n");
            sb.AppendFormat("    DistanceTravelled: {0} m\n", DistanceTravelled);
            sb.AppendFormat("    MaxDistanceToHome: {0} m\n", MaxDistanceToHome);
            sb.AppendFormat("    MaxClimbRate: {0} m/s\n", MaxClimbRate);
            sb.AppendFormat("    MaxDescentRate: {0} m/s\n", MaxDescentRate);
            sb.AppendFormat("    MaxGroundSpeed: {0} m/s\n", MaxGroundSpeed);
            sb.AppendFormat("    MaxAirSpeed: {0} m/s\n", MaxAirSpeed);
            sb.AppendFormat("    MaxAltitude: {0} m\n", MaxAltitude);
            sb.AppendFormat("    MaxRollRate: {0} deg/s\n", MaxRollRate);
            sb.AppendFormat("    MaxPitchRate: {0} deg/s\n", MaxPitchRate);
            sb.AppendFormat("    MaxYawRate: {0} deg/s\n", MaxYawRate);
            sb.AppendFormat("    ConsumedEnergy: {0} mAh\n", ConsumedEnergy);
            sb.AppendFormat("    InitialBatteryVoltage: {0} mV\n", InitialBatteryVoltage);
            sb.AppendFormat("    State: {0} \n", State);

            return sb.ToString();
        }

        private float mDistanceTravelled;
        private float mMaxDistanceToHome;
        private float mMaxClimbRate;
        private float mMaxDescentRate;
        private float mMaxGroundSpeed;
        private float mMaxAirSpeed;
        private UInt16 mMaxAltitude;
        private UInt16 mMaxRollRate;
        private UInt16 mMaxPitchRate;
        private UInt16 mMaxYawRate;
        private UInt16 mConsumedEnergy;
        private UInt16 mInitialBatteryVoltage;
        private FlightStats_State mState;
    }
}

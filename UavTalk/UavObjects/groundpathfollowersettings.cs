using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum GroundPathFollowerSettings_ManualOverride { FALSE, TRUE };

    public enum GroundPathFollowerSettings_ThrottleControl { MANUAL, PROPORTIONAL, AUTO };

    public enum GroundPathFollowerSettings_VelocitySource { EKF, NEDVEL, GPSPOS };

    public enum GroundPathFollowerSettings_PositionSource { EKF, GPSPOS };

    public class GroundPathFollowerSettings: UavDataObject
    {
        public float[] HorizontalPosPI {
            get { return mHorizontalPosPI; }
            set { mHorizontalPosPI = value; NotifyUpdated(); }
        }

        public float[] HorizontalVelPID {
            get { return mHorizontalVelPID; }
            set { mHorizontalVelPID = value; NotifyUpdated(); }
        }

        public float VelocityFeedforward {
            get { return mVelocityFeedforward; }
            set { mVelocityFeedforward = value; NotifyUpdated(); }
        }

        public float MaxThrottle {
            get { return mMaxThrottle; }
            set { mMaxThrottle = value; NotifyUpdated(); }
        }

        public Int32 UpdatePeriod {
            get { return mUpdatePeriod; }
            set { mUpdatePeriod = value; NotifyUpdated(); }
        }

        public UInt16 HorizontalVelMax {
            get { return mHorizontalVelMax; }
            set { mHorizontalVelMax = value; NotifyUpdated(); }
        }

        public GroundPathFollowerSettings_ManualOverride ManualOverride {
            get { return mManualOverride; }
            set { mManualOverride = value; NotifyUpdated(); }
        }

        public GroundPathFollowerSettings_ThrottleControl ThrottleControl {
            get { return mThrottleControl; }
            set { mThrottleControl = value; NotifyUpdated(); }
        }

        public GroundPathFollowerSettings_VelocitySource VelocitySource {
            get { return mVelocitySource; }
            set { mVelocitySource = value; NotifyUpdated(); }
        }

        public GroundPathFollowerSettings_PositionSource PositionSource {
            get { return mPositionSource; }
            set { mPositionSource = value; NotifyUpdated(); }
        }

        public byte EndpointRadius {
            get { return mEndpointRadius; }
            set { mEndpointRadius = value; NotifyUpdated(); }
        }

        public GroundPathFollowerSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x09090c16;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mHorizontalPosPI[0]);  // Kp
            s.Write(mHorizontalPosPI[1]);  // Ki
            s.Write(mHorizontalPosPI[2]);  // ILimit
            s.Write(mHorizontalVelPID[0]);  // Kp
            s.Write(mHorizontalVelPID[1]);  // Ki
            s.Write(mHorizontalVelPID[2]);  // Kd
            s.Write(mHorizontalVelPID[3]);  // ILimit
            s.Write(mVelocityFeedforward);
            s.Write(mMaxThrottle);
            s.Write(mUpdatePeriod);
            s.Write(mHorizontalVelMax);
            s.Write((byte)mManualOverride);
            s.Write((byte)mThrottleControl);
            s.Write((byte)mVelocitySource);
            s.Write((byte)mPositionSource);
            s.Write(mEndpointRadius);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mHorizontalPosPI[0] = stream.ReadSingle();  // Kp
            this.mHorizontalPosPI[1] = stream.ReadSingle();  // Ki
            this.mHorizontalPosPI[2] = stream.ReadSingle();  // ILimit
            this.mHorizontalVelPID[0] = stream.ReadSingle();  // Kp
            this.mHorizontalVelPID[1] = stream.ReadSingle();  // Ki
            this.mHorizontalVelPID[2] = stream.ReadSingle();  // Kd
            this.mHorizontalVelPID[3] = stream.ReadSingle();  // ILimit
            this.mVelocityFeedforward = stream.ReadSingle();
            this.mMaxThrottle = stream.ReadSingle();
            this.mUpdatePeriod = stream.ReadInt32();
            this.mHorizontalVelMax = stream.ReadUInt16();
            this.mManualOverride = (GroundPathFollowerSettings_ManualOverride)stream.ReadByte();
            this.mThrottleControl = (GroundPathFollowerSettings_ThrottleControl)stream.ReadByte();
            this.mVelocitySource = (GroundPathFollowerSettings_VelocitySource)stream.ReadByte();
            this.mPositionSource = (GroundPathFollowerSettings_PositionSource)stream.ReadByte();
            this.mEndpointRadius = stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("GroundPathFollowerSettings \n");
            sb.Append("    HorizontalPosPI\n");
            sb.AppendFormat("        Kp: {0} (m/s)/m\n", HorizontalPosPI[0]);
            sb.AppendFormat("        Ki: {0} (m/s)/m\n", HorizontalPosPI[1]);
            sb.AppendFormat("        ILimit: {0} (m/s)/m\n", HorizontalPosPI[2]);
            sb.Append("    HorizontalVelPID\n");
            sb.AppendFormat("        Kp: {0} deg/(m/s)\n", HorizontalVelPID[0]);
            sb.AppendFormat("        Ki: {0} deg/(m/s)\n", HorizontalVelPID[1]);
            sb.AppendFormat("        Kd: {0} deg/(m/s)\n", HorizontalVelPID[2]);
            sb.AppendFormat("        ILimit: {0} deg/(m/s)\n", HorizontalVelPID[3]);
            sb.AppendFormat("    VelocityFeedforward: {0} deg/(m/s)\n", VelocityFeedforward);
            sb.AppendFormat("    MaxThrottle: {0} %\n", MaxThrottle);
            sb.AppendFormat("    UpdatePeriod: {0} ms\n", UpdatePeriod);
            sb.AppendFormat("    HorizontalVelMax: {0} m/s\n", HorizontalVelMax);
            sb.AppendFormat("    ManualOverride: {0} \n", ManualOverride);
            sb.AppendFormat("    ThrottleControl: {0} \n", ThrottleControl);
            sb.AppendFormat("    VelocitySource: {0} \n", VelocitySource);
            sb.AppendFormat("    PositionSource: {0} \n", PositionSource);
            sb.AppendFormat("    EndpointRadius: {0} m\n", EndpointRadius);

            return sb.ToString();
        }

        private float[] mHorizontalPosPI = new float[3] { 1f, 0f, 0f };
        private float[] mHorizontalVelPID = new float[4] { 5f, 0f, 1f, 0f };
        private float mVelocityFeedforward = 0f;
        private float mMaxThrottle = 1f;
        private Int32 mUpdatePeriod = 100;
        private UInt16 mHorizontalVelMax = 10;
        private GroundPathFollowerSettings_ManualOverride mManualOverride = GroundPathFollowerSettings_ManualOverride.FALSE;
        private GroundPathFollowerSettings_ThrottleControl mThrottleControl = GroundPathFollowerSettings_ThrottleControl.PROPORTIONAL;
        private GroundPathFollowerSettings_VelocitySource mVelocitySource = GroundPathFollowerSettings_VelocitySource.EKF;
        private GroundPathFollowerSettings_PositionSource mPositionSource = GroundPathFollowerSettings_PositionSource.EKF;
        private byte mEndpointRadius = 2;
    }
}

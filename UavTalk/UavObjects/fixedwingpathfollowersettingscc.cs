using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class FixedWingPathFollowerSettingsCC: UavDataObject
    {
        public float VerticalVelMax {
            get { return mVerticalVelMax; }
            set { mVerticalVelMax = value; NotifyUpdated(); }
        }

        public float VectorFollowingGain {
            get { return mVectorFollowingGain; }
            set { mVectorFollowingGain = value; NotifyUpdated(); }
        }

        public float OrbitFollowingGain {
            get { return mOrbitFollowingGain; }
            set { mOrbitFollowingGain = value; NotifyUpdated(); }
        }

        public float FollowerIntegralGain {
            get { return mFollowerIntegralGain; }
            set { mFollowerIntegralGain = value; NotifyUpdated(); }
        }

        public float VerticalPosP {
            get { return mVerticalPosP; }
            set { mVerticalPosP = value; NotifyUpdated(); }
        }

        public float[] HeadingPI {
            get { return mHeadingPI; }
            set { mHeadingPI = value; NotifyUpdated(); }
        }

        public float[] AirspeedPI {
            get { return mAirspeedPI; }
            set { mAirspeedPI = value; NotifyUpdated(); }
        }

        public float[] VerticalToPitchCrossFeed {
            get { return mVerticalToPitchCrossFeed; }
            set { mVerticalToPitchCrossFeed = value; NotifyUpdated(); }
        }

        public float[] AirspeedToVerticalCrossFeed {
            get { return mAirspeedToVerticalCrossFeed; }
            set { mAirspeedToVerticalCrossFeed = value; NotifyUpdated(); }
        }

        public float[] ThrottlePI {
            get { return mThrottlePI; }
            set { mThrottlePI = value; NotifyUpdated(); }
        }

        public float[] RollLimit {
            get { return mRollLimit; }
            set { mRollLimit = value; NotifyUpdated(); }
        }

        public float[] PitchLimit {
            get { return mPitchLimit; }
            set { mPitchLimit = value; NotifyUpdated(); }
        }

        public float[] ThrottleLimit {
            get { return mThrottleLimit; }
            set { mThrottleLimit = value; NotifyUpdated(); }
        }

        public Int16 UpdatePeriod {
            get { return mUpdatePeriod; }
            set { mUpdatePeriod = value; NotifyUpdated(); }
        }

        public FixedWingPathFollowerSettingsCC()
        {
            IsSingleInstance = true;
            ObjectId = 0xc4623504;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mVerticalVelMax);
            s.Write(mVectorFollowingGain);
            s.Write(mOrbitFollowingGain);
            s.Write(mFollowerIntegralGain);
            s.Write(mVerticalPosP);
            s.Write(mHeadingPI[0]);  // Kp
            s.Write(mHeadingPI[1]);  // Ki
            s.Write(mHeadingPI[2]);  // ILimit
            s.Write(mAirspeedPI[0]);  // Kp
            s.Write(mAirspeedPI[1]);  // Ki
            s.Write(mAirspeedPI[2]);  // ILimit
            s.Write(mVerticalToPitchCrossFeed[0]);  // Kp
            s.Write(mVerticalToPitchCrossFeed[1]);  // Max
            s.Write(mAirspeedToVerticalCrossFeed[0]);  // Kp
            s.Write(mAirspeedToVerticalCrossFeed[1]);  // Max
            s.Write(mThrottlePI[0]);  // Kp
            s.Write(mThrottlePI[1]);  // Ki
            s.Write(mThrottlePI[2]);  // ILimit
            s.Write(mRollLimit[0]);  // Min
            s.Write(mRollLimit[1]);  // Neutral
            s.Write(mRollLimit[2]);  // Max
            s.Write(mPitchLimit[0]);  // Min
            s.Write(mPitchLimit[1]);  // Neutral
            s.Write(mPitchLimit[2]);  // Max
            s.Write(mThrottleLimit[0]);  // Min
            s.Write(mThrottleLimit[1]);  // Neutral
            s.Write(mThrottleLimit[2]);  // Max
            s.Write(mUpdatePeriod);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mVerticalVelMax = stream.ReadSingle();
            this.mVectorFollowingGain = stream.ReadSingle();
            this.mOrbitFollowingGain = stream.ReadSingle();
            this.mFollowerIntegralGain = stream.ReadSingle();
            this.mVerticalPosP = stream.ReadSingle();
            this.mHeadingPI[0] = stream.ReadSingle();  // Kp
            this.mHeadingPI[1] = stream.ReadSingle();  // Ki
            this.mHeadingPI[2] = stream.ReadSingle();  // ILimit
            this.mAirspeedPI[0] = stream.ReadSingle();  // Kp
            this.mAirspeedPI[1] = stream.ReadSingle();  // Ki
            this.mAirspeedPI[2] = stream.ReadSingle();  // ILimit
            this.mVerticalToPitchCrossFeed[0] = stream.ReadSingle();  // Kp
            this.mVerticalToPitchCrossFeed[1] = stream.ReadSingle();  // Max
            this.mAirspeedToVerticalCrossFeed[0] = stream.ReadSingle();  // Kp
            this.mAirspeedToVerticalCrossFeed[1] = stream.ReadSingle();  // Max
            this.mThrottlePI[0] = stream.ReadSingle();  // Kp
            this.mThrottlePI[1] = stream.ReadSingle();  // Ki
            this.mThrottlePI[2] = stream.ReadSingle();  // ILimit
            this.mRollLimit[0] = stream.ReadSingle();  // Min
            this.mRollLimit[1] = stream.ReadSingle();  // Neutral
            this.mRollLimit[2] = stream.ReadSingle();  // Max
            this.mPitchLimit[0] = stream.ReadSingle();  // Min
            this.mPitchLimit[1] = stream.ReadSingle();  // Neutral
            this.mPitchLimit[2] = stream.ReadSingle();  // Max
            this.mThrottleLimit[0] = stream.ReadSingle();  // Min
            this.mThrottleLimit[1] = stream.ReadSingle();  // Neutral
            this.mThrottleLimit[2] = stream.ReadSingle();  // Max
            this.mUpdatePeriod = stream.ReadInt16();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("FixedWingPathFollowerSettingsCC \n");
            sb.AppendFormat("    VerticalVelMax: {0} m/s\n", VerticalVelMax);
            sb.AppendFormat("    VectorFollowingGain: {0} (m/s)/m\n", VectorFollowingGain);
            sb.AppendFormat("    OrbitFollowingGain: {0} (m/s)/m\n", OrbitFollowingGain);
            sb.AppendFormat("    FollowerIntegralGain: {0} (m/s)/m\n", FollowerIntegralGain);
            sb.AppendFormat("    VerticalPosP: {0} (m/s)/m\n", VerticalPosP);
            sb.Append("    HeadingPI\n");
            sb.AppendFormat("        Kp: {0} deg/deg\n", HeadingPI[0]);
            sb.AppendFormat("        Ki: {0} deg/deg\n", HeadingPI[1]);
            sb.AppendFormat("        ILimit: {0} deg/deg\n", HeadingPI[2]);
            sb.Append("    AirspeedPI\n");
            sb.AppendFormat("        Kp: {0} deg / (m/s^2)\n", AirspeedPI[0]);
            sb.AppendFormat("        Ki: {0} deg / (m/s^2)\n", AirspeedPI[1]);
            sb.AppendFormat("        ILimit: {0} deg / (m/s^2)\n", AirspeedPI[2]);
            sb.Append("    VerticalToPitchCrossFeed\n");
            sb.AppendFormat("        Kp: {0} deg / m\n", VerticalToPitchCrossFeed[0]);
            sb.AppendFormat("        Max: {0} deg / m\n", VerticalToPitchCrossFeed[1]);
            sb.Append("    AirspeedToVerticalCrossFeed\n");
            sb.AppendFormat("        Kp: {0} (m/s) / ((m/s)/(m/s))\n", AirspeedToVerticalCrossFeed[0]);
            sb.AppendFormat("        Max: {0} (m/s) / ((m/s)/(m/s))\n", AirspeedToVerticalCrossFeed[1]);
            sb.Append("    ThrottlePI\n");
            sb.AppendFormat("        Kp: {0} 1/(m/s)\n", ThrottlePI[0]);
            sb.AppendFormat("        Ki: {0} 1/(m/s)\n", ThrottlePI[1]);
            sb.AppendFormat("        ILimit: {0} 1/(m/s)\n", ThrottlePI[2]);
            sb.Append("    RollLimit\n");
            sb.AppendFormat("        Min: {0} deg\n", RollLimit[0]);
            sb.AppendFormat("        Neutral: {0} deg\n", RollLimit[1]);
            sb.AppendFormat("        Max: {0} deg\n", RollLimit[2]);
            sb.Append("    PitchLimit\n");
            sb.AppendFormat("        Min: {0} deg\n", PitchLimit[0]);
            sb.AppendFormat("        Neutral: {0} deg\n", PitchLimit[1]);
            sb.AppendFormat("        Max: {0} deg\n", PitchLimit[2]);
            sb.Append("    ThrottleLimit\n");
            sb.AppendFormat("        Min: {0} \n", ThrottleLimit[0]);
            sb.AppendFormat("        Neutral: {0} \n", ThrottleLimit[1]);
            sb.AppendFormat("        Max: {0} \n", ThrottleLimit[2]);
            sb.AppendFormat("    UpdatePeriod: {0} ms\n", UpdatePeriod);

            return sb.ToString();
        }

        private float mVerticalVelMax = 10f;
        private float mVectorFollowingGain = 0.5f;
        private float mOrbitFollowingGain = 0.5f;
        private float mFollowerIntegralGain = 0.0000f;
        private float mVerticalPosP = 0.05f;
        private float[] mHeadingPI = new float[3] { 0.6f,  0f,  0f };
        private float[] mAirspeedPI = new float[3] { 1f,  .05f,  5f };
        private float[] mVerticalToPitchCrossFeed = new float[2] { .2f,  10f };
        private float[] mAirspeedToVerticalCrossFeed = new float[2] { 10f,  100f };
        private float[] mThrottlePI = new float[3] { 0.001f, 0.0001f, 0.5f };
        private float[] mRollLimit = new float[3] { -35f, 0f, 35f };
        private float[] mPitchLimit = new float[3] { -10f, 0f, 10f };
        private float[] mThrottleLimit = new float[3] { 0.0f, 0.5f, 1.0f };
        private Int16 mUpdatePeriod = 100;
    }
}

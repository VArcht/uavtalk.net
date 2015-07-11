using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class MWRateSettings: UavDataObject
    {
        public float[] RollRatePID {
            get { return mRollRatePID; }
            set { mRollRatePID = value; NotifyUpdated(); }
        }

        public float[] PitchRatePID {
            get { return mPitchRatePID; }
            set { mPitchRatePID = value; NotifyUpdated(); }
        }

        public float[] YawRatePID {
            get { return mYawRatePID; }
            set { mYawRatePID = value; NotifyUpdated(); }
        }

        public float DerivativeGamma {
            get { return mDerivativeGamma; }
            set { mDerivativeGamma = value; NotifyUpdated(); }
        }

        public byte RollPitchRate {
            get { return mRollPitchRate; }
            set { mRollPitchRate = value; NotifyUpdated(); }
        }

        public byte YawRate {
            get { return mYawRate; }
            set { mYawRate = value; NotifyUpdated(); }
        }

        public MWRateSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xbd3b5f28;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mRollRatePID[0]);  // Kp
            s.Write(mRollRatePID[1]);  // Ki
            s.Write(mRollRatePID[2]);  // Kd
            s.Write(mRollRatePID[3]);  // ILimit
            s.Write(mPitchRatePID[0]);  // Kp
            s.Write(mPitchRatePID[1]);  // Ki
            s.Write(mPitchRatePID[2]);  // Kd
            s.Write(mPitchRatePID[3]);  // ILimit
            s.Write(mYawRatePID[0]);  // Kp
            s.Write(mYawRatePID[1]);  // Ki
            s.Write(mYawRatePID[2]);  // Kd
            s.Write(mYawRatePID[3]);  // ILimit
            s.Write(mDerivativeGamma);
            s.Write(mRollPitchRate);
            s.Write(mYawRate);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRollRatePID[0] = stream.ReadSingle();  // Kp
            this.mRollRatePID[1] = stream.ReadSingle();  // Ki
            this.mRollRatePID[2] = stream.ReadSingle();  // Kd
            this.mRollRatePID[3] = stream.ReadSingle();  // ILimit
            this.mPitchRatePID[0] = stream.ReadSingle();  // Kp
            this.mPitchRatePID[1] = stream.ReadSingle();  // Ki
            this.mPitchRatePID[2] = stream.ReadSingle();  // Kd
            this.mPitchRatePID[3] = stream.ReadSingle();  // ILimit
            this.mYawRatePID[0] = stream.ReadSingle();  // Kp
            this.mYawRatePID[1] = stream.ReadSingle();  // Ki
            this.mYawRatePID[2] = stream.ReadSingle();  // Kd
            this.mYawRatePID[3] = stream.ReadSingle();  // ILimit
            this.mDerivativeGamma = stream.ReadSingle();
            this.mRollPitchRate = stream.ReadByte();
            this.mYawRate = stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("MWRateSettings \n");
            sb.Append("    RollRatePID\n");
            sb.AppendFormat("        Kp: {0} \n", RollRatePID[0]);
            sb.AppendFormat("        Ki: {0} \n", RollRatePID[1]);
            sb.AppendFormat("        Kd: {0} \n", RollRatePID[2]);
            sb.AppendFormat("        ILimit: {0} \n", RollRatePID[3]);
            sb.Append("    PitchRatePID\n");
            sb.AppendFormat("        Kp: {0} \n", PitchRatePID[0]);
            sb.AppendFormat("        Ki: {0} \n", PitchRatePID[1]);
            sb.AppendFormat("        Kd: {0} \n", PitchRatePID[2]);
            sb.AppendFormat("        ILimit: {0} \n", PitchRatePID[3]);
            sb.Append("    YawRatePID\n");
            sb.AppendFormat("        Kp: {0} \n", YawRatePID[0]);
            sb.AppendFormat("        Ki: {0} \n", YawRatePID[1]);
            sb.AppendFormat("        Kd: {0} \n", YawRatePID[2]);
            sb.AppendFormat("        ILimit: {0} \n", YawRatePID[3]);
            sb.AppendFormat("    DerivativeGamma: {0} \n", DerivativeGamma);
            sb.AppendFormat("    RollPitchRate: {0} %\n", RollPitchRate);
            sb.AppendFormat("    YawRate: {0} %\n", YawRate);

            return sb.ToString();
        }

        private float[] mRollRatePID = new float[4] { 0.004f, 0.0086f, 0.00005f, 0.3f };
        private float[] mPitchRatePID = new float[4] { 0.004f, 0.0086f, 0.00005f, 0.3f };
        private float[] mYawRatePID = new float[4] { 0.0085f, 0.013f, 0f, 0.3f };
        private float mDerivativeGamma = 0f;
        private byte mRollPitchRate = 0;
        private byte mYawRate = 0;
    }
}

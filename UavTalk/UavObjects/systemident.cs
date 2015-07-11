using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class SystemIdent: UavDataObject
    {
        public float Tau {
            get { return mTau; }
            set { mTau = value; NotifyUpdated(); }
        }

        public float[] Beta {
            get { return mBeta; }
            set { mBeta = value; NotifyUpdated(); }
        }

        public float[] Bias {
            get { return mBias; }
            set { mBias = value; NotifyUpdated(); }
        }

        public float[] Noise {
            get { return mNoise; }
            set { mNoise = value; NotifyUpdated(); }
        }

        public float Period {
            get { return mPeriod; }
            set { mPeriod = value; NotifyUpdated(); }
        }

        public SystemIdent()
        {
            IsSingleInstance = true;
            ObjectId = 0xadafddf2;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mTau);
            s.Write(mBeta[0]);  // Roll
            s.Write(mBeta[1]);  // Pitch
            s.Write(mBeta[2]);  // Yaw
            s.Write(mBias[0]);  // Roll
            s.Write(mBias[1]);  // Pitch
            s.Write(mBias[2]);  // Yaw
            s.Write(mNoise[0]);  // Roll
            s.Write(mNoise[1]);  // Pitch
            s.Write(mNoise[2]);  // Yaw
            s.Write(mPeriod);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mTau = stream.ReadSingle();
            this.mBeta[0] = stream.ReadSingle();  // Roll
            this.mBeta[1] = stream.ReadSingle();  // Pitch
            this.mBeta[2] = stream.ReadSingle();  // Yaw
            this.mBias[0] = stream.ReadSingle();  // Roll
            this.mBias[1] = stream.ReadSingle();  // Pitch
            this.mBias[2] = stream.ReadSingle();  // Yaw
            this.mNoise[0] = stream.ReadSingle();  // Roll
            this.mNoise[1] = stream.ReadSingle();  // Pitch
            this.mNoise[2] = stream.ReadSingle();  // Yaw
            this.mPeriod = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("SystemIdent \n");
            sb.AppendFormat("    Tau: {0} s\n", Tau);
            sb.Append("    Beta\n");
            sb.AppendFormat("        Roll: {0} \n", Beta[0]);
            sb.AppendFormat("        Pitch: {0} \n", Beta[1]);
            sb.AppendFormat("        Yaw: {0} \n", Beta[2]);
            sb.Append("    Bias\n");
            sb.AppendFormat("        Roll: {0} \n", Bias[0]);
            sb.AppendFormat("        Pitch: {0} \n", Bias[1]);
            sb.AppendFormat("        Yaw: {0} \n", Bias[2]);
            sb.Append("    Noise\n");
            sb.AppendFormat("        Roll: {0} (deg/s)^2\n", Noise[0]);
            sb.AppendFormat("        Pitch: {0} (deg/s)^2\n", Noise[1]);
            sb.AppendFormat("        Yaw: {0} (deg/s)^2\n", Noise[2]);
            sb.AppendFormat("    Period: {0} ms\n", Period);

            return sb.ToString();
        }

        private float mTau = 0f;
        private float[] mBeta = new float[3] { 0f, 0f, 0f };
        private float[] mBias = new float[3] { 0f, 0f, 0f };
        private float[] mNoise = new float[3] { 0f, 0f, 0f };
        private float mPeriod = 0f;
    }
}

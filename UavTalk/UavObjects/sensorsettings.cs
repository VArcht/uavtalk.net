using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class SensorSettings: UavDataObject
    {
        public float[] AccelBias {
            get { return mAccelBias; }
            set { mAccelBias = value; NotifyUpdated(); }
        }

        public float[] AccelScale {
            get { return mAccelScale; }
            set { mAccelScale = value; NotifyUpdated(); }
        }

        public float[] GyroScale {
            get { return mGyroScale; }
            set { mGyroScale = value; NotifyUpdated(); }
        }

        public float[] XGyroTempCoeff {
            get { return mXGyroTempCoeff; }
            set { mXGyroTempCoeff = value; NotifyUpdated(); }
        }

        public float[] YGyroTempCoeff {
            get { return mYGyroTempCoeff; }
            set { mYGyroTempCoeff = value; NotifyUpdated(); }
        }

        public float[] ZGyroTempCoeff {
            get { return mZGyroTempCoeff; }
            set { mZGyroTempCoeff = value; NotifyUpdated(); }
        }

        public float[] MagBias {
            get { return mMagBias; }
            set { mMagBias = value; NotifyUpdated(); }
        }

        public float[] MagScale {
            get { return mMagScale; }
            set { mMagScale = value; NotifyUpdated(); }
        }

        public float ZAccelOffset {
            get { return mZAccelOffset; }
            set { mZAccelOffset = value; NotifyUpdated(); }
        }

        public SensorSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xadb3b106;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mAccelBias[0]);  // X
            s.Write(mAccelBias[1]);  // Y
            s.Write(mAccelBias[2]);  // Z
            s.Write(mAccelScale[0]);  // X
            s.Write(mAccelScale[1]);  // Y
            s.Write(mAccelScale[2]);  // Z
            s.Write(mGyroScale[0]);  // X
            s.Write(mGyroScale[1]);  // Y
            s.Write(mGyroScale[2]);  // Z
            s.Write(mXGyroTempCoeff[0]);  // 1
            s.Write(mXGyroTempCoeff[1]);  // T
            s.Write(mXGyroTempCoeff[2]);  // T2
            s.Write(mXGyroTempCoeff[3]);  // T3
            s.Write(mYGyroTempCoeff[0]);  // 1
            s.Write(mYGyroTempCoeff[1]);  // T
            s.Write(mYGyroTempCoeff[2]);  // T2
            s.Write(mYGyroTempCoeff[3]);  // T3
            s.Write(mZGyroTempCoeff[0]);  // 1
            s.Write(mZGyroTempCoeff[1]);  // T
            s.Write(mZGyroTempCoeff[2]);  // T2
            s.Write(mZGyroTempCoeff[3]);  // T3
            s.Write(mMagBias[0]);  // X
            s.Write(mMagBias[1]);  // Y
            s.Write(mMagBias[2]);  // Z
            s.Write(mMagScale[0]);  // X
            s.Write(mMagScale[1]);  // Y
            s.Write(mMagScale[2]);  // Z
            s.Write(mZAccelOffset);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mAccelBias[0] = stream.ReadSingle();  // X
            this.mAccelBias[1] = stream.ReadSingle();  // Y
            this.mAccelBias[2] = stream.ReadSingle();  // Z
            this.mAccelScale[0] = stream.ReadSingle();  // X
            this.mAccelScale[1] = stream.ReadSingle();  // Y
            this.mAccelScale[2] = stream.ReadSingle();  // Z
            this.mGyroScale[0] = stream.ReadSingle();  // X
            this.mGyroScale[1] = stream.ReadSingle();  // Y
            this.mGyroScale[2] = stream.ReadSingle();  // Z
            this.mXGyroTempCoeff[0] = stream.ReadSingle();  // 1
            this.mXGyroTempCoeff[1] = stream.ReadSingle();  // T
            this.mXGyroTempCoeff[2] = stream.ReadSingle();  // T2
            this.mXGyroTempCoeff[3] = stream.ReadSingle();  // T3
            this.mYGyroTempCoeff[0] = stream.ReadSingle();  // 1
            this.mYGyroTempCoeff[1] = stream.ReadSingle();  // T
            this.mYGyroTempCoeff[2] = stream.ReadSingle();  // T2
            this.mYGyroTempCoeff[3] = stream.ReadSingle();  // T3
            this.mZGyroTempCoeff[0] = stream.ReadSingle();  // 1
            this.mZGyroTempCoeff[1] = stream.ReadSingle();  // T
            this.mZGyroTempCoeff[2] = stream.ReadSingle();  // T2
            this.mZGyroTempCoeff[3] = stream.ReadSingle();  // T3
            this.mMagBias[0] = stream.ReadSingle();  // X
            this.mMagBias[1] = stream.ReadSingle();  // Y
            this.mMagBias[2] = stream.ReadSingle();  // Z
            this.mMagScale[0] = stream.ReadSingle();  // X
            this.mMagScale[1] = stream.ReadSingle();  // Y
            this.mMagScale[2] = stream.ReadSingle();  // Z
            this.mZAccelOffset = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("SensorSettings \n");
            sb.Append("    AccelBias\n");
            sb.AppendFormat("        X: {0} m/s^2\n", AccelBias[0]);
            sb.AppendFormat("        Y: {0} m/s^2\n", AccelBias[1]);
            sb.AppendFormat("        Z: {0} m/s^2\n", AccelBias[2]);
            sb.Append("    AccelScale\n");
            sb.AppendFormat("        X: {0} [-]\n", AccelScale[0]);
            sb.AppendFormat("        Y: {0} [-]\n", AccelScale[1]);
            sb.AppendFormat("        Z: {0} [-]\n", AccelScale[2]);
            sb.Append("    GyroScale\n");
            sb.AppendFormat("        X: {0} -\n", GyroScale[0]);
            sb.AppendFormat("        Y: {0} -\n", GyroScale[1]);
            sb.AppendFormat("        Z: {0} -\n", GyroScale[2]);
            sb.Append("    XGyroTempCoeff\n");
            sb.AppendFormat("        1: {0} (deg/s)/deg\n", XGyroTempCoeff[0]);
            sb.AppendFormat("        T: {0} (deg/s)/deg\n", XGyroTempCoeff[1]);
            sb.AppendFormat("        T2: {0} (deg/s)/deg\n", XGyroTempCoeff[2]);
            sb.AppendFormat("        T3: {0} (deg/s)/deg\n", XGyroTempCoeff[3]);
            sb.Append("    YGyroTempCoeff\n");
            sb.AppendFormat("        1: {0} (deg/s)/deg\n", YGyroTempCoeff[0]);
            sb.AppendFormat("        T: {0} (deg/s)/deg\n", YGyroTempCoeff[1]);
            sb.AppendFormat("        T2: {0} (deg/s)/deg\n", YGyroTempCoeff[2]);
            sb.AppendFormat("        T3: {0} (deg/s)/deg\n", YGyroTempCoeff[3]);
            sb.Append("    ZGyroTempCoeff\n");
            sb.AppendFormat("        1: {0} (deg/s)/deg\n", ZGyroTempCoeff[0]);
            sb.AppendFormat("        T: {0} (deg/s)/deg\n", ZGyroTempCoeff[1]);
            sb.AppendFormat("        T2: {0} (deg/s)/deg\n", ZGyroTempCoeff[2]);
            sb.AppendFormat("        T3: {0} (deg/s)/deg\n", ZGyroTempCoeff[3]);
            sb.Append("    MagBias\n");
            sb.AppendFormat("        X: {0} mGau\n", MagBias[0]);
            sb.AppendFormat("        Y: {0} mGau\n", MagBias[1]);
            sb.AppendFormat("        Z: {0} mGau\n", MagBias[2]);
            sb.Append("    MagScale\n");
            sb.AppendFormat("        X: {0} gain\n", MagScale[0]);
            sb.AppendFormat("        Y: {0} gain\n", MagScale[1]);
            sb.AppendFormat("        Z: {0} gain\n", MagScale[2]);
            sb.AppendFormat("    ZAccelOffset: {0} m/s^2\n", ZAccelOffset);

            return sb.ToString();
        }

        private float[] mAccelBias = new float[3] { 0f, 0f, 0f };
        private float[] mAccelScale = new float[3] { 1f, 1f, 1f };
        private float[] mGyroScale = new float[3] { 1f, 1f, 1f };
        private float[] mXGyroTempCoeff = new float[4] { 0f, 0f, 0f, 0f };
        private float[] mYGyroTempCoeff = new float[4] { 0f, 0f, 0f, 0f };
        private float[] mZGyroTempCoeff = new float[4] { 0f, 0f, 0f, 0f };
        private float[] mMagBias = new float[3] { 0f, 0f, 0f };
        private float[] mMagScale = new float[3] { 1f, 1f, 1f };
        private float mZAccelOffset = 0f;
    }
}

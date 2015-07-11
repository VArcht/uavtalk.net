using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum INSSettings_ComputeGyroBias { FALSE, TRUE };

    public class INSSettings: UavDataObject
    {
        public float[] AccelVar {
            get { return mAccelVar; }
            set { mAccelVar = value; NotifyUpdated(); }
        }

        public float[] GyroVar {
            get { return mGyroVar; }
            set { mGyroVar = value; NotifyUpdated(); }
        }

        public float[] MagVar {
            get { return mMagVar; }
            set { mMagVar = value; NotifyUpdated(); }
        }

        public float[] GpsVar {
            get { return mGpsVar; }
            set { mGpsVar = value; NotifyUpdated(); }
        }

        public float BaroVar {
            get { return mBaroVar; }
            set { mBaroVar = value; NotifyUpdated(); }
        }

        public float MagBiasNullingRate {
            get { return mMagBiasNullingRate; }
            set { mMagBiasNullingRate = value; NotifyUpdated(); }
        }

        public INSSettings_ComputeGyroBias ComputeGyroBias {
            get { return mComputeGyroBias; }
            set { mComputeGyroBias = value; NotifyUpdated(); }
        }

        public INSSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xe2dbc224;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mAccelVar[0]);  // X
            s.Write(mAccelVar[1]);  // Y
            s.Write(mAccelVar[2]);  // Z
            s.Write(mGyroVar[0]);  // X
            s.Write(mGyroVar[1]);  // Y
            s.Write(mGyroVar[2]);  // Z
            s.Write(mMagVar[0]);  // X
            s.Write(mMagVar[1]);  // Y
            s.Write(mMagVar[2]);  // Z
            s.Write(mGpsVar[0]);  // Pos
            s.Write(mGpsVar[1]);  // Vel
            s.Write(mGpsVar[2]);  // VertPos
            s.Write(mBaroVar);
            s.Write(mMagBiasNullingRate);
            s.Write((byte)mComputeGyroBias);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mAccelVar[0] = stream.ReadSingle();  // X
            this.mAccelVar[1] = stream.ReadSingle();  // Y
            this.mAccelVar[2] = stream.ReadSingle();  // Z
            this.mGyroVar[0] = stream.ReadSingle();  // X
            this.mGyroVar[1] = stream.ReadSingle();  // Y
            this.mGyroVar[2] = stream.ReadSingle();  // Z
            this.mMagVar[0] = stream.ReadSingle();  // X
            this.mMagVar[1] = stream.ReadSingle();  // Y
            this.mMagVar[2] = stream.ReadSingle();  // Z
            this.mGpsVar[0] = stream.ReadSingle();  // Pos
            this.mGpsVar[1] = stream.ReadSingle();  // Vel
            this.mGpsVar[2] = stream.ReadSingle();  // VertPos
            this.mBaroVar = stream.ReadSingle();
            this.mMagBiasNullingRate = stream.ReadSingle();
            this.mComputeGyroBias = (INSSettings_ComputeGyroBias)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("INSSettings \n");
            sb.Append("    AccelVar\n");
            sb.AppendFormat("        X: {0} (m/s)^2\n", AccelVar[0]);
            sb.AppendFormat("        Y: {0} (m/s)^2\n", AccelVar[1]);
            sb.AppendFormat("        Z: {0} (m/s)^2\n", AccelVar[2]);
            sb.Append("    GyroVar\n");
            sb.AppendFormat("        X: {0} (deg/s)^2\n", GyroVar[0]);
            sb.AppendFormat("        Y: {0} (deg/s)^2\n", GyroVar[1]);
            sb.AppendFormat("        Z: {0} (deg/s)^2\n", GyroVar[2]);
            sb.Append("    MagVar\n");
            sb.AppendFormat("        X: {0} mGau^2\n", MagVar[0]);
            sb.AppendFormat("        Y: {0} mGau^2\n", MagVar[1]);
            sb.AppendFormat("        Z: {0} mGau^2\n", MagVar[2]);
            sb.Append("    GpsVar\n");
            sb.AppendFormat("        Pos: {0} m^2\n", GpsVar[0]);
            sb.AppendFormat("        Vel: {0} m^2\n", GpsVar[1]);
            sb.AppendFormat("        VertPos: {0} m^2\n", GpsVar[2]);
            sb.AppendFormat("    BaroVar: {0} m^2\n", BaroVar);
            sb.AppendFormat("    MagBiasNullingRate: {0} \n", MagBiasNullingRate);
            sb.AppendFormat("    ComputeGyroBias: {0} \n", ComputeGyroBias);

            return sb.ToString();
        }

        private float[] mAccelVar = new float[3] { 0.003f, 0.003f, 0.003f };
        private float[] mGyroVar = new float[3] { 0.00001f, 0.00001f, 0.0001f };
        private float[] mMagVar = new float[3] { 10f, 10f, 100f };
        private float[] mGpsVar = new float[3] { 0.001f, 0.01f, 10f };
        private float mBaroVar = 0.01f;
        private float mMagBiasNullingRate = 0f;
        private INSSettings_ComputeGyroBias mComputeGyroBias = INSSettings_ComputeGyroBias.FALSE;
    }
}

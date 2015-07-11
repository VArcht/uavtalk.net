using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum BrushlessGimbalSettings_PowerupSequence { FALSE, TRUE };

    public class BrushlessGimbalSettings: UavDataObject
    {
        public float[] Damping {
            get { return mDamping; }
            set { mDamping = value; NotifyUpdated(); }
        }

        public UInt16[] MaxDPS {
            get { return mMaxDPS; }
            set { mMaxDPS = value; NotifyUpdated(); }
        }

        public UInt16[] SlewLimit {
            get { return mSlewLimit; }
            set { mSlewLimit = value; NotifyUpdated(); }
        }

        public byte[] PowerScale {
            get { return mPowerScale; }
            set { mPowerScale = value; NotifyUpdated(); }
        }

        public byte[] MaxAngle {
            get { return mMaxAngle; }
            set { mMaxAngle = value; NotifyUpdated(); }
        }

        public byte RollFraction {
            get { return mRollFraction; }
            set { mRollFraction = value; NotifyUpdated(); }
        }

        public BrushlessGimbalSettings_PowerupSequence PowerupSequence {
            get { return mPowerupSequence; }
            set { mPowerupSequence = value; NotifyUpdated(); }
        }

        public BrushlessGimbalSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xb50ddc74;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mDamping[0]);  // Roll
            s.Write(mDamping[1]);  // Pitch
            s.Write(mDamping[2]);  // Yaw
            s.Write(mMaxDPS[0]);  // Roll
            s.Write(mMaxDPS[1]);  // Pitch
            s.Write(mMaxDPS[2]);  // Yaw
            s.Write(mSlewLimit[0]);  // Roll
            s.Write(mSlewLimit[1]);  // Pitch
            s.Write(mSlewLimit[2]);  // Yaw
            s.Write(mPowerScale[0]);  // Roll
            s.Write(mPowerScale[1]);  // Pitch
            s.Write(mPowerScale[2]);  // Yaw
            s.Write(mMaxAngle[0]);  // Roll
            s.Write(mMaxAngle[1]);  // Pitch
            s.Write(mMaxAngle[2]);  // Yaw
            s.Write(mRollFraction);
            s.Write((byte)mPowerupSequence);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mDamping[0] = stream.ReadSingle();  // Roll
            this.mDamping[1] = stream.ReadSingle();  // Pitch
            this.mDamping[2] = stream.ReadSingle();  // Yaw
            this.mMaxDPS[0] = stream.ReadUInt16();  // Roll
            this.mMaxDPS[1] = stream.ReadUInt16();  // Pitch
            this.mMaxDPS[2] = stream.ReadUInt16();  // Yaw
            this.mSlewLimit[0] = stream.ReadUInt16();  // Roll
            this.mSlewLimit[1] = stream.ReadUInt16();  // Pitch
            this.mSlewLimit[2] = stream.ReadUInt16();  // Yaw
            this.mPowerScale[0] = stream.ReadByte();  // Roll
            this.mPowerScale[1] = stream.ReadByte();  // Pitch
            this.mPowerScale[2] = stream.ReadByte();  // Yaw
            this.mMaxAngle[0] = stream.ReadByte();  // Roll
            this.mMaxAngle[1] = stream.ReadByte();  // Pitch
            this.mMaxAngle[2] = stream.ReadByte();  // Yaw
            this.mRollFraction = stream.ReadByte();
            this.mPowerupSequence = (BrushlessGimbalSettings_PowerupSequence)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("BrushlessGimbalSettings \n");
            sb.Append("    Damping\n");
            sb.AppendFormat("        Roll: {0} deg/(deg/s)\n", Damping[0]);
            sb.AppendFormat("        Pitch: {0} deg/(deg/s)\n", Damping[1]);
            sb.AppendFormat("        Yaw: {0} deg/(deg/s)\n", Damping[2]);
            sb.Append("    MaxDPS\n");
            sb.AppendFormat("        Roll: {0} deg/s\n", MaxDPS[0]);
            sb.AppendFormat("        Pitch: {0} deg/s\n", MaxDPS[1]);
            sb.AppendFormat("        Yaw: {0} deg/s\n", MaxDPS[2]);
            sb.Append("    SlewLimit\n");
            sb.AppendFormat("        Roll: {0} deg/s^2\n", SlewLimit[0]);
            sb.AppendFormat("        Pitch: {0} deg/s^2\n", SlewLimit[1]);
            sb.AppendFormat("        Yaw: {0} deg/s^2\n", SlewLimit[2]);
            sb.Append("    PowerScale\n");
            sb.AppendFormat("        Roll: {0} %\n", PowerScale[0]);
            sb.AppendFormat("        Pitch: {0} %\n", PowerScale[1]);
            sb.AppendFormat("        Yaw: {0} %\n", PowerScale[2]);
            sb.Append("    MaxAngle\n");
            sb.AppendFormat("        Roll: {0} degs\n", MaxAngle[0]);
            sb.AppendFormat("        Pitch: {0} degs\n", MaxAngle[1]);
            sb.AppendFormat("        Yaw: {0} degs\n", MaxAngle[2]);
            sb.AppendFormat("    RollFraction: {0} %\n", RollFraction);
            sb.AppendFormat("    PowerupSequence: {0} \n", PowerupSequence);

            return sb.ToString();
        }

        private float[] mDamping = new float[3] { 0.5f, 0.5f, 0.5f };
        private UInt16[] mMaxDPS = new UInt16[3] { 65535, 65535, 65535 };
        private UInt16[] mSlewLimit = new UInt16[3] { 32000, 32000, 32000 };
        private byte[] mPowerScale = new byte[3] { 33, 33, 33 };
        private byte[] mMaxAngle = new byte[3] { 35, 35, 35 };
        private byte mRollFraction = 0;
        private BrushlessGimbalSettings_PowerupSequence mPowerupSequence = BrushlessGimbalSettings_PowerupSequence.TRUE;
    }
}

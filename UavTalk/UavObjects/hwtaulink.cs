using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwTauLink_Radio { Disabled, Telem, Telem_PPM, PPM };

    public enum HwTauLink_MainPort { Disabled, GPS, Telemetry, ComBridge };

    public enum HwTauLink_PPMPort { Disabled, PPM };

    public enum HwTauLink_VCPPort { Disabled, Telemetry, DebugConsole, ComBridge };

    public enum HwTauLink_ComSpeed { _4800, _9600, _19200, _38400, _57600, _115200 };

    public enum HwTauLink_MaxRfSpeed { _9600, _19200, _32000, _64000, _100000, _192000 };

    public enum HwTauLink_MaxRfPower { _0, _1_25, _1_6, _3_16, _6_3, _12_6, _25, _50, _100 };

    public class HwTauLink: UavDataObject
    {
        public UInt32 CoordID {
            get { return mCoordID; }
            set { mCoordID = value; NotifyUpdated(); }
        }

        public HwTauLink_Radio Radio {
            get { return mRadio; }
            set { mRadio = value; NotifyUpdated(); }
        }

        public HwTauLink_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwTauLink_PPMPort PPMPort {
            get { return mPPMPort; }
            set { mPPMPort = value; NotifyUpdated(); }
        }

        public HwTauLink_VCPPort VCPPort {
            get { return mVCPPort; }
            set { mVCPPort = value; NotifyUpdated(); }
        }

        public HwTauLink_ComSpeed ComSpeed {
            get { return mComSpeed; }
            set { mComSpeed = value; NotifyUpdated(); }
        }

        public HwTauLink_MaxRfSpeed MaxRfSpeed {
            get { return mMaxRfSpeed; }
            set { mMaxRfSpeed = value; NotifyUpdated(); }
        }

        public HwTauLink_MaxRfPower MaxRfPower {
            get { return mMaxRfPower; }
            set { mMaxRfPower = value; NotifyUpdated(); }
        }

        public byte MinChannel {
            get { return mMinChannel; }
            set { mMinChannel = value; NotifyUpdated(); }
        }

        public byte MaxChannel {
            get { return mMaxChannel; }
            set { mMaxChannel = value; NotifyUpdated(); }
        }

        public HwTauLink()
        {
            IsSingleInstance = true;
            ObjectId = 0xe0d4e21a;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mCoordID);
            s.Write((byte)mRadio);
            s.Write((byte)mMainPort);
            s.Write((byte)mPPMPort);
            s.Write((byte)mVCPPort);
            s.Write((byte)mComSpeed);
            s.Write((byte)mMaxRfSpeed);
            s.Write((byte)mMaxRfPower);
            s.Write(mMinChannel);
            s.Write(mMaxChannel);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mCoordID = stream.ReadUInt32();
            this.mRadio = (HwTauLink_Radio)stream.ReadByte();
            this.mMainPort = (HwTauLink_MainPort)stream.ReadByte();
            this.mPPMPort = (HwTauLink_PPMPort)stream.ReadByte();
            this.mVCPPort = (HwTauLink_VCPPort)stream.ReadByte();
            this.mComSpeed = (HwTauLink_ComSpeed)stream.ReadByte();
            this.mMaxRfSpeed = (HwTauLink_MaxRfSpeed)stream.ReadByte();
            this.mMaxRfPower = (HwTauLink_MaxRfPower)stream.ReadByte();
            this.mMinChannel = stream.ReadByte();
            this.mMaxChannel = stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwTauLink \n");
            sb.AppendFormat("    CoordID: {0} hex\n", CoordID);
            sb.AppendFormat("    Radio: {0} \n", Radio);
            sb.AppendFormat("    MainPort: {0} \n", MainPort);
            sb.AppendFormat("    PPMPort: {0} \n", PPMPort);
            sb.AppendFormat("    VCPPort: {0} \n", VCPPort);
            sb.AppendFormat("    ComSpeed: {0} bps\n", ComSpeed);
            sb.AppendFormat("    MaxRfSpeed: {0} bps\n", MaxRfSpeed);
            sb.AppendFormat("    MaxRfPower: {0} mW\n", MaxRfPower);
            sb.AppendFormat("    MinChannel: {0} \n", MinChannel);
            sb.AppendFormat("    MaxChannel: {0} \n", MaxChannel);

            return sb.ToString();
        }

        private UInt32 mCoordID = 0;
        private HwTauLink_Radio mRadio = HwTauLink_Radio.Disabled;
        private HwTauLink_MainPort mMainPort = HwTauLink_MainPort.Telemetry;
        private HwTauLink_PPMPort mPPMPort = HwTauLink_PPMPort.PPM;
        private HwTauLink_VCPPort mVCPPort = HwTauLink_VCPPort.Disabled;
        private HwTauLink_ComSpeed mComSpeed = HwTauLink_ComSpeed._38400;
        private HwTauLink_MaxRfSpeed mMaxRfSpeed = HwTauLink_MaxRfSpeed._64000;
        private HwTauLink_MaxRfPower mMaxRfPower = HwTauLink_MaxRfPower._3_16;
        private byte mMinChannel = 0;
        private byte mMaxChannel = 250;
    }
}

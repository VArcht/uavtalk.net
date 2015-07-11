using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwSparkyBGC_RcvrPort { Disabled, PPM, S_Bus, DSM, HoTT_SUMD, HoTT_SUMH };

    public enum HwSparkyBGC_FlexiPort { Disabled, Telemetry, DebugConsole, ComBridge, GPS, S_Bus, DSM, MavLinkTX, MavLinkTX_GPS_RX, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwSparkyBGC_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwSparkyBGC_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, Disabled };

    public enum HwSparkyBGC_GyroRange { _250, _500, _1000, _2000 };

    public enum HwSparkyBGC_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwSparkyBGC_MPU9150DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public enum HwSparkyBGC_MPU9150Rate { _200, _333, _444, _500, _666, _1000, _2000, _4000, _8000 };

    public class HwSparkyBGC: UavDataObject
    {
        public HwSparkyBGC_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_MPU9150DLPF MPU9150DLPF {
            get { return mMPU9150DLPF; }
            set { mMPU9150DLPF = value; NotifyUpdated(); }
        }

        public HwSparkyBGC_MPU9150Rate MPU9150Rate {
            get { return mMPU9150Rate; }
            set { mMPU9150Rate = value; NotifyUpdated(); }
        }

        public HwSparkyBGC()
        {
            IsSingleInstance = true;
            ObjectId = 0xd76f3a36;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mRcvrPort);
            s.Write((byte)mFlexiPort);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
            s.Write(mDSMxBind);
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU9150DLPF);
            s.Write((byte)mMPU9150Rate);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRcvrPort = (HwSparkyBGC_RcvrPort)stream.ReadByte();
            this.mFlexiPort = (HwSparkyBGC_FlexiPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwSparkyBGC_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwSparkyBGC_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwSparkyBGC_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwSparkyBGC_AccelRange)stream.ReadByte();
            this.mMPU9150DLPF = (HwSparkyBGC_MPU9150DLPF)stream.ReadByte();
            this.mMPU9150Rate = (HwSparkyBGC_MPU9150Rate)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwSparkyBGC \n");
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    FlexiPort: {0} function\n", FlexiPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU9150DLPF: {0} \n", MPU9150DLPF);
            sb.AppendFormat("    MPU9150Rate: {0} \n", MPU9150Rate);

            return sb.ToString();
        }

        private HwSparkyBGC_RcvrPort mRcvrPort = HwSparkyBGC_RcvrPort.Disabled;
        private HwSparkyBGC_FlexiPort mFlexiPort = HwSparkyBGC_FlexiPort.Disabled;
        private HwSparkyBGC_USB_HIDPort mUSB_HIDPort = HwSparkyBGC_USB_HIDPort.USBTelemetry;
        private HwSparkyBGC_USB_VCPPort mUSB_VCPPort = HwSparkyBGC_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwSparkyBGC_GyroRange mGyroRange = HwSparkyBGC_GyroRange._500;
        private HwSparkyBGC_AccelRange mAccelRange = HwSparkyBGC_AccelRange._8G;
        private HwSparkyBGC_MPU9150DLPF mMPU9150DLPF = HwSparkyBGC_MPU9150DLPF._256;
        private HwSparkyBGC_MPU9150Rate mMPU9150Rate = HwSparkyBGC_MPU9150Rate._444;
    }
}

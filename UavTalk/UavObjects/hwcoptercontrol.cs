using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwCopterControl_RcvrPort { Disabled, PWM, PPM, PPM_PWM, PPM_Outputs, Outputs };

    public enum HwCopterControl_MainPort { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, FrSKY_Sensor_Hub, LighttelemetryTx, HoTT_SUMD, HoTT_SUMH };

    public enum HwCopterControl_FlexiPort { Disabled, Telemetry, GPS, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, FrSKY_Sensor_Hub, LighttelemetryTx, HoTT_SUMD, HoTT_SUMH };

    public enum HwCopterControl_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwCopterControl_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, Disabled };

    public enum HwCopterControl_GyroRange { _250, _500, _1000, _2000 };

    public enum HwCopterControl_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwCopterControl_MPU6000Rate { _200, _333, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwCopterControl_MPU6000DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public class HwCopterControl: UavDataObject
    {
        public HwCopterControl_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwCopterControl_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwCopterControl_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwCopterControl_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwCopterControl_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwCopterControl_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwCopterControl_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwCopterControl_MPU6000Rate MPU6000Rate {
            get { return mMPU6000Rate; }
            set { mMPU6000Rate = value; NotifyUpdated(); }
        }

        public HwCopterControl_MPU6000DLPF MPU6000DLPF {
            get { return mMPU6000DLPF; }
            set { mMPU6000DLPF = value; NotifyUpdated(); }
        }

        public HwCopterControl()
        {
            IsSingleInstance = true;
            ObjectId = 0x06a90844;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mRcvrPort);
            s.Write((byte)mMainPort);
            s.Write((byte)mFlexiPort);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
            s.Write(mDSMxBind);
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU6000Rate);
            s.Write((byte)mMPU6000DLPF);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRcvrPort = (HwCopterControl_RcvrPort)stream.ReadByte();
            this.mMainPort = (HwCopterControl_MainPort)stream.ReadByte();
            this.mFlexiPort = (HwCopterControl_FlexiPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwCopterControl_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwCopterControl_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwCopterControl_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwCopterControl_AccelRange)stream.ReadByte();
            this.mMPU6000Rate = (HwCopterControl_MPU6000Rate)stream.ReadByte();
            this.mMPU6000DLPF = (HwCopterControl_MPU6000DLPF)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwCopterControl \n");
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    MainPort: {0} function\n", MainPort);
            sb.AppendFormat("    FlexiPort: {0} function\n", FlexiPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU6000Rate: {0} \n", MPU6000Rate);
            sb.AppendFormat("    MPU6000DLPF: {0} \n", MPU6000DLPF);

            return sb.ToString();
        }

        private HwCopterControl_RcvrPort mRcvrPort = HwCopterControl_RcvrPort.PWM;
        private HwCopterControl_MainPort mMainPort = HwCopterControl_MainPort.Disabled;
        private HwCopterControl_FlexiPort mFlexiPort = HwCopterControl_FlexiPort.Disabled;
        private HwCopterControl_USB_HIDPort mUSB_HIDPort = HwCopterControl_USB_HIDPort.USBTelemetry;
        private HwCopterControl_USB_VCPPort mUSB_VCPPort = HwCopterControl_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwCopterControl_GyroRange mGyroRange = HwCopterControl_GyroRange._500;
        private HwCopterControl_AccelRange mAccelRange = HwCopterControl_AccelRange._8G;
        private HwCopterControl_MPU6000Rate mMPU6000Rate = HwCopterControl_MPU6000Rate._500;
        private HwCopterControl_MPU6000DLPF mMPU6000DLPF = HwCopterControl_MPU6000DLPF._256;
    }
}

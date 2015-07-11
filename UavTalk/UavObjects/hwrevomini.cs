using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwRevoMini_RcvrPort { Disabled, PWM, PPM, PPM_PWM, PPM_Outputs, Outputs };

    public enum HwRevoMini_MainPort { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwRevoMini_FlexiPort { Disabled, Telemetry, GPS, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwRevoMini_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwRevoMini_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, PicoC, Disabled };

    public enum HwRevoMini_Radio { Disabled, Telem, Telem_PPM, PPM, OpenLRS };

    public enum HwRevoMini_MaxRfSpeed { _9600, _19200, _32000, _64000, _100000, _192000 };

    public enum HwRevoMini_MaxRfPower { _0, _1_25, _1_6, _3_16, _6_3, _12_6, _25, _50, _100 };

    public enum HwRevoMini_GyroRange { _250, _500, _1000, _2000 };

    public enum HwRevoMini_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwRevoMini_MPU6000Rate { _200, _333, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwRevoMini_MPU6000DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public class HwRevoMini: UavDataObject
    {
        public UInt32 CoordID {
            get { return mCoordID; }
            set { mCoordID = value; NotifyUpdated(); }
        }

        public HwRevoMini_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwRevoMini_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwRevoMini_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwRevoMini_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwRevoMini_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwRevoMini_Radio Radio {
            get { return mRadio; }
            set { mRadio = value; NotifyUpdated(); }
        }

        public HwRevoMini_MaxRfSpeed MaxRfSpeed {
            get { return mMaxRfSpeed; }
            set { mMaxRfSpeed = value; NotifyUpdated(); }
        }

        public HwRevoMini_MaxRfPower MaxRfPower {
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

        public byte ChannelSet {
            get { return mChannelSet; }
            set { mChannelSet = value; NotifyUpdated(); }
        }

        public HwRevoMini_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwRevoMini_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwRevoMini_MPU6000Rate MPU6000Rate {
            get { return mMPU6000Rate; }
            set { mMPU6000Rate = value; NotifyUpdated(); }
        }

        public HwRevoMini_MPU6000DLPF MPU6000DLPF {
            get { return mMPU6000DLPF; }
            set { mMPU6000DLPF = value; NotifyUpdated(); }
        }

        public HwRevoMini()
        {
            IsSingleInstance = true;
            ObjectId = 0xcbebc0a2;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mCoordID);
            s.Write((byte)mRcvrPort);
            s.Write((byte)mMainPort);
            s.Write((byte)mFlexiPort);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
            s.Write(mDSMxBind);
            s.Write((byte)mRadio);
            s.Write((byte)mMaxRfSpeed);
            s.Write((byte)mMaxRfPower);
            s.Write(mMinChannel);
            s.Write(mMaxChannel);
            s.Write(mChannelSet);
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU6000Rate);
            s.Write((byte)mMPU6000DLPF);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mCoordID = stream.ReadUInt32();
            this.mRcvrPort = (HwRevoMini_RcvrPort)stream.ReadByte();
            this.mMainPort = (HwRevoMini_MainPort)stream.ReadByte();
            this.mFlexiPort = (HwRevoMini_FlexiPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwRevoMini_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwRevoMini_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mRadio = (HwRevoMini_Radio)stream.ReadByte();
            this.mMaxRfSpeed = (HwRevoMini_MaxRfSpeed)stream.ReadByte();
            this.mMaxRfPower = (HwRevoMini_MaxRfPower)stream.ReadByte();
            this.mMinChannel = stream.ReadByte();
            this.mMaxChannel = stream.ReadByte();
            this.mChannelSet = stream.ReadByte();
            this.mGyroRange = (HwRevoMini_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwRevoMini_AccelRange)stream.ReadByte();
            this.mMPU6000Rate = (HwRevoMini_MPU6000Rate)stream.ReadByte();
            this.mMPU6000DLPF = (HwRevoMini_MPU6000DLPF)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwRevoMini \n");
            sb.AppendFormat("    CoordID: {0} hex\n", CoordID);
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    MainPort: {0} function\n", MainPort);
            sb.AppendFormat("    FlexiPort: {0} function\n", FlexiPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    Radio: {0} \n", Radio);
            sb.AppendFormat("    MaxRfSpeed: {0} bps\n", MaxRfSpeed);
            sb.AppendFormat("    MaxRfPower: {0} mW\n", MaxRfPower);
            sb.AppendFormat("    MinChannel: {0} \n", MinChannel);
            sb.AppendFormat("    MaxChannel: {0} \n", MaxChannel);
            sb.AppendFormat("    ChannelSet: {0} \n", ChannelSet);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU6000Rate: {0} \n", MPU6000Rate);
            sb.AppendFormat("    MPU6000DLPF: {0} \n", MPU6000DLPF);

            return sb.ToString();
        }

        private UInt32 mCoordID = 0;
        private HwRevoMini_RcvrPort mRcvrPort = HwRevoMini_RcvrPort.PWM;
        private HwRevoMini_MainPort mMainPort = HwRevoMini_MainPort.Telemetry;
        private HwRevoMini_FlexiPort mFlexiPort = HwRevoMini_FlexiPort.Disabled;
        private HwRevoMini_USB_HIDPort mUSB_HIDPort = HwRevoMini_USB_HIDPort.USBTelemetry;
        private HwRevoMini_USB_VCPPort mUSB_VCPPort = HwRevoMini_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwRevoMini_Radio mRadio = HwRevoMini_Radio.Disabled;
        private HwRevoMini_MaxRfSpeed mMaxRfSpeed = HwRevoMini_MaxRfSpeed._64000;
        private HwRevoMini_MaxRfPower mMaxRfPower = HwRevoMini_MaxRfPower._0;
        private byte mMinChannel = 0;
        private byte mMaxChannel = 250;
        private byte mChannelSet = 39;
        private HwRevoMini_GyroRange mGyroRange = HwRevoMini_GyroRange._500;
        private HwRevoMini_AccelRange mAccelRange = HwRevoMini_AccelRange._8G;
        private HwRevoMini_MPU6000Rate mMPU6000Rate = HwRevoMini_MPU6000Rate._666;
        private HwRevoMini_MPU6000DLPF mMPU6000DLPF = HwRevoMini_MPU6000DLPF._256;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwFreedom_Output { Disabled, PWM };

    public enum HwFreedom_MainPort { Disabled, Telemetry, GPS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwFreedom_FlexiPort { Disabled, Telemetry, GPS, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwFreedom_RcvrPort { Disabled, PPM, DSM, S_Bus, HoTT_SUMD, HoTT_SUMH };

    public enum HwFreedom_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwFreedom_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, PicoC, Disabled };

    public enum HwFreedom_Radio { Disabled, Telem, Telem_PPM, PPM };

    public enum HwFreedom_MaxRfSpeed { _9600, _19200, _32000, _64000, _100000, _192000 };

    public enum HwFreedom_MaxRfPower { _0, _1_25, _1_6, _3_16, _6_3, _12_6, _25, _50, _100 };

    public enum HwFreedom_GyroRange { _250, _500, _1000, _2000 };

    public enum HwFreedom_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwFreedom_MPU6000Rate { _200, _333, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwFreedom_MPU6000DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public class HwFreedom: UavDataObject
    {
        public UInt32 CoordID {
            get { return mCoordID; }
            set { mCoordID = value; NotifyUpdated(); }
        }

        public HwFreedom_Output Output {
            get { return mOutput; }
            set { mOutput = value; NotifyUpdated(); }
        }

        public HwFreedom_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwFreedom_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwFreedom_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwFreedom_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwFreedom_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwFreedom_Radio Radio {
            get { return mRadio; }
            set { mRadio = value; NotifyUpdated(); }
        }

        public HwFreedom_MaxRfSpeed MaxRfSpeed {
            get { return mMaxRfSpeed; }
            set { mMaxRfSpeed = value; NotifyUpdated(); }
        }

        public HwFreedom_MaxRfPower MaxRfPower {
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

        public HwFreedom_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwFreedom_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwFreedom_MPU6000Rate MPU6000Rate {
            get { return mMPU6000Rate; }
            set { mMPU6000Rate = value; NotifyUpdated(); }
        }

        public HwFreedom_MPU6000DLPF MPU6000DLPF {
            get { return mMPU6000DLPF; }
            set { mMPU6000DLPF = value; NotifyUpdated(); }
        }

        public HwFreedom()
        {
            IsSingleInstance = true;
            ObjectId = 0xc8b869bc;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mCoordID);
            s.Write((byte)mOutput);
            s.Write((byte)mMainPort);
            s.Write((byte)mFlexiPort);
            s.Write((byte)mRcvrPort);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
            s.Write(mDSMxBind);
            s.Write((byte)mRadio);
            s.Write((byte)mMaxRfSpeed);
            s.Write((byte)mMaxRfPower);
            s.Write(mMinChannel);
            s.Write(mMaxChannel);
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU6000Rate);
            s.Write((byte)mMPU6000DLPF);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mCoordID = stream.ReadUInt32();
            this.mOutput = (HwFreedom_Output)stream.ReadByte();
            this.mMainPort = (HwFreedom_MainPort)stream.ReadByte();
            this.mFlexiPort = (HwFreedom_FlexiPort)stream.ReadByte();
            this.mRcvrPort = (HwFreedom_RcvrPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwFreedom_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwFreedom_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mRadio = (HwFreedom_Radio)stream.ReadByte();
            this.mMaxRfSpeed = (HwFreedom_MaxRfSpeed)stream.ReadByte();
            this.mMaxRfPower = (HwFreedom_MaxRfPower)stream.ReadByte();
            this.mMinChannel = stream.ReadByte();
            this.mMaxChannel = stream.ReadByte();
            this.mGyroRange = (HwFreedom_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwFreedom_AccelRange)stream.ReadByte();
            this.mMPU6000Rate = (HwFreedom_MPU6000Rate)stream.ReadByte();
            this.mMPU6000DLPF = (HwFreedom_MPU6000DLPF)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwFreedom \n");
            sb.AppendFormat("    CoordID: {0} hex\n", CoordID);
            sb.AppendFormat("    Output: {0} function\n", Output);
            sb.AppendFormat("    MainPort: {0} function\n", MainPort);
            sb.AppendFormat("    FlexiPort: {0} function\n", FlexiPort);
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    Radio: {0} \n", Radio);
            sb.AppendFormat("    MaxRfSpeed: {0} bps\n", MaxRfSpeed);
            sb.AppendFormat("    MaxRfPower: {0} mW\n", MaxRfPower);
            sb.AppendFormat("    MinChannel: {0} \n", MinChannel);
            sb.AppendFormat("    MaxChannel: {0} \n", MaxChannel);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU6000Rate: {0} \n", MPU6000Rate);
            sb.AppendFormat("    MPU6000DLPF: {0} \n", MPU6000DLPF);

            return sb.ToString();
        }

        private UInt32 mCoordID = 0;
        private HwFreedom_Output mOutput = HwFreedom_Output.PWM;
        private HwFreedom_MainPort mMainPort = HwFreedom_MainPort.Telemetry;
        private HwFreedom_FlexiPort mFlexiPort = HwFreedom_FlexiPort.GPS;
        private HwFreedom_RcvrPort mRcvrPort = HwFreedom_RcvrPort.Disabled;
        private HwFreedom_USB_HIDPort mUSB_HIDPort = HwFreedom_USB_HIDPort.USBTelemetry;
        private HwFreedom_USB_VCPPort mUSB_VCPPort = HwFreedom_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwFreedom_Radio mRadio = HwFreedom_Radio.Disabled;
        private HwFreedom_MaxRfSpeed mMaxRfSpeed = HwFreedom_MaxRfSpeed._64000;
        private HwFreedom_MaxRfPower mMaxRfPower = HwFreedom_MaxRfPower._0;
        private byte mMinChannel = 0;
        private byte mMaxChannel = 250;
        private HwFreedom_GyroRange mGyroRange = HwFreedom_GyroRange._500;
        private HwFreedom_AccelRange mAccelRange = HwFreedom_AccelRange._8G;
        private HwFreedom_MPU6000Rate mMPU6000Rate = HwFreedom_MPU6000Rate._666;
        private HwFreedom_MPU6000DLPF mMPU6000DLPF = HwFreedom_MPU6000DLPF._256;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwSparky_RcvrPort { Disabled, PPM, S_Bus, DSM, HoTT_SUMD, HoTT_SUMH };

    public enum HwSparky_FlexiPort { Disabled, Telemetry, DebugConsole, ComBridge, GPS, I2C, S_Bus, DSM, MavLinkTX, MavLinkTX_GPS_RX, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwSparky_MainPort { Disabled, Telemetry, DebugConsole, ComBridge, GPS, S_Bus, DSM, MavLinkTX, MavLinkTX_GPS_RX, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwSparky_OutPort { PWM10, PWM7_3ADC, PWM8_2ADC, PWM9_PWM_IN, PWM7_PWM_IN_2ADC };

    public enum HwSparky_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwSparky_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, Disabled };

    public enum HwSparky_GyroRange { _250, _500, _1000, _2000 };

    public enum HwSparky_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwSparky_MPU9150DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public enum HwSparky_MPU9150Rate { _200, _333, _444, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwSparky_Magnetometer { Internal, ExternalI2CFlexiPort };

    public enum HwSparky_ExtMagOrientation { Top0degCW, Top90degCW, Top180degCW, Top270degCW, Bottom0degCW, Bottom90degCW, Bottom180degCW, Bottom270degCW };

    public class HwSparky: UavDataObject
    {
        public HwSparky_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwSparky_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwSparky_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwSparky_OutPort OutPort {
            get { return mOutPort; }
            set { mOutPort = value; NotifyUpdated(); }
        }

        public HwSparky_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwSparky_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwSparky_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwSparky_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwSparky_MPU9150DLPF MPU9150DLPF {
            get { return mMPU9150DLPF; }
            set { mMPU9150DLPF = value; NotifyUpdated(); }
        }

        public HwSparky_MPU9150Rate MPU9150Rate {
            get { return mMPU9150Rate; }
            set { mMPU9150Rate = value; NotifyUpdated(); }
        }

        public HwSparky_Magnetometer Magnetometer {
            get { return mMagnetometer; }
            set { mMagnetometer = value; NotifyUpdated(); }
        }

        public HwSparky_ExtMagOrientation ExtMagOrientation {
            get { return mExtMagOrientation; }
            set { mExtMagOrientation = value; NotifyUpdated(); }
        }

        public HwSparky()
        {
            IsSingleInstance = true;
            ObjectId = 0xa27c2786;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mRcvrPort);
            s.Write((byte)mFlexiPort);
            s.Write((byte)mMainPort);
            s.Write((byte)mOutPort);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
            s.Write(mDSMxBind);
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU9150DLPF);
            s.Write((byte)mMPU9150Rate);
            s.Write((byte)mMagnetometer);
            s.Write((byte)mExtMagOrientation);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRcvrPort = (HwSparky_RcvrPort)stream.ReadByte();
            this.mFlexiPort = (HwSparky_FlexiPort)stream.ReadByte();
            this.mMainPort = (HwSparky_MainPort)stream.ReadByte();
            this.mOutPort = (HwSparky_OutPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwSparky_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwSparky_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwSparky_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwSparky_AccelRange)stream.ReadByte();
            this.mMPU9150DLPF = (HwSparky_MPU9150DLPF)stream.ReadByte();
            this.mMPU9150Rate = (HwSparky_MPU9150Rate)stream.ReadByte();
            this.mMagnetometer = (HwSparky_Magnetometer)stream.ReadByte();
            this.mExtMagOrientation = (HwSparky_ExtMagOrientation)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwSparky \n");
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    FlexiPort: {0} function\n", FlexiPort);
            sb.AppendFormat("    MainPort: {0} function\n", MainPort);
            sb.AppendFormat("    OutPort: {0} function\n", OutPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU9150DLPF: {0} \n", MPU9150DLPF);
            sb.AppendFormat("    MPU9150Rate: {0} \n", MPU9150Rate);
            sb.AppendFormat("    Magnetometer: {0} function\n", Magnetometer);
            sb.AppendFormat("    ExtMagOrientation: {0} function\n", ExtMagOrientation);

            return sb.ToString();
        }

        private HwSparky_RcvrPort mRcvrPort = HwSparky_RcvrPort.Disabled;
        private HwSparky_FlexiPort mFlexiPort = HwSparky_FlexiPort.Disabled;
        private HwSparky_MainPort mMainPort = HwSparky_MainPort.Disabled;
        private HwSparky_OutPort mOutPort = HwSparky_OutPort.PWM10;
        private HwSparky_USB_HIDPort mUSB_HIDPort = HwSparky_USB_HIDPort.USBTelemetry;
        private HwSparky_USB_VCPPort mUSB_VCPPort = HwSparky_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwSparky_GyroRange mGyroRange = HwSparky_GyroRange._500;
        private HwSparky_AccelRange mAccelRange = HwSparky_AccelRange._8G;
        private HwSparky_MPU9150DLPF mMPU9150DLPF = HwSparky_MPU9150DLPF._256;
        private HwSparky_MPU9150Rate mMPU9150Rate = HwSparky_MPU9150Rate._444;
        private HwSparky_Magnetometer mMagnetometer = HwSparky_Magnetometer.Internal;
        private HwSparky_ExtMagOrientation mExtMagOrientation = HwSparky_ExtMagOrientation.Top0degCW;
    }
}

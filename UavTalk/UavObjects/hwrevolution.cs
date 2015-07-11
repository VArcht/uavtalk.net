using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwRevolution_RcvrPort { Disabled, PWM, PPM, PPM_Outputs, Outputs };

    public enum HwRevolution_AuxPort { Disabled, Telemetry, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, PicoC, FrSKY_SPort_Telemetry };

    public enum HwRevolution_AuxSBusPort { Disabled, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, PicoC, FrSKY_SPort_Telemetry };

    public enum HwRevolution_FlexiPort { Disabled, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, PicoC, FrSKY_SPort_Telemetry };

    public enum HwRevolution_TelemetryPort { Disabled, Telemetry, DebugConsole, ComBridge };

    public enum HwRevolution_GPSPort { Disabled, Telemetry, GPS, DebugConsole, ComBridge };

    public enum HwRevolution_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwRevolution_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, PicoC, Disabled };

    public enum HwRevolution_GyroRange { _250, _500, _1000, _2000 };

    public enum HwRevolution_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwRevolution_MPU6000Rate { _200, _333, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwRevolution_MPU6000DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public class HwRevolution: UavDataObject
    {
        public HwRevolution_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwRevolution_AuxPort AuxPort {
            get { return mAuxPort; }
            set { mAuxPort = value; NotifyUpdated(); }
        }

        public HwRevolution_AuxSBusPort AuxSBusPort {
            get { return mAuxSBusPort; }
            set { mAuxSBusPort = value; NotifyUpdated(); }
        }

        public HwRevolution_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwRevolution_TelemetryPort TelemetryPort {
            get { return mTelemetryPort; }
            set { mTelemetryPort = value; NotifyUpdated(); }
        }

        public HwRevolution_GPSPort GPSPort {
            get { return mGPSPort; }
            set { mGPSPort = value; NotifyUpdated(); }
        }

        public HwRevolution_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwRevolution_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwRevolution_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwRevolution_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwRevolution_MPU6000Rate MPU6000Rate {
            get { return mMPU6000Rate; }
            set { mMPU6000Rate = value; NotifyUpdated(); }
        }

        public HwRevolution_MPU6000DLPF MPU6000DLPF {
            get { return mMPU6000DLPF; }
            set { mMPU6000DLPF = value; NotifyUpdated(); }
        }

        public HwRevolution()
        {
            IsSingleInstance = true;
            ObjectId = 0xd9ac7e1a;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mRcvrPort);
            s.Write((byte)mAuxPort);
            s.Write((byte)mAuxSBusPort);
            s.Write((byte)mFlexiPort);
            s.Write((byte)mTelemetryPort);
            s.Write((byte)mGPSPort);
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
            this.mRcvrPort = (HwRevolution_RcvrPort)stream.ReadByte();
            this.mAuxPort = (HwRevolution_AuxPort)stream.ReadByte();
            this.mAuxSBusPort = (HwRevolution_AuxSBusPort)stream.ReadByte();
            this.mFlexiPort = (HwRevolution_FlexiPort)stream.ReadByte();
            this.mTelemetryPort = (HwRevolution_TelemetryPort)stream.ReadByte();
            this.mGPSPort = (HwRevolution_GPSPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwRevolution_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwRevolution_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwRevolution_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwRevolution_AccelRange)stream.ReadByte();
            this.mMPU6000Rate = (HwRevolution_MPU6000Rate)stream.ReadByte();
            this.mMPU6000DLPF = (HwRevolution_MPU6000DLPF)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwRevolution \n");
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    AuxPort: {0} function\n", AuxPort);
            sb.AppendFormat("    AuxSBusPort: {0} function\n", AuxSBusPort);
            sb.AppendFormat("    FlexiPort: {0} function\n", FlexiPort);
            sb.AppendFormat("    TelemetryPort: {0} function\n", TelemetryPort);
            sb.AppendFormat("    GPSPort: {0} function\n", GPSPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU6000Rate: {0} \n", MPU6000Rate);
            sb.AppendFormat("    MPU6000DLPF: {0} \n", MPU6000DLPF);

            return sb.ToString();
        }

        private HwRevolution_RcvrPort mRcvrPort = HwRevolution_RcvrPort.PWM;
        private HwRevolution_AuxPort mAuxPort = HwRevolution_AuxPort.Disabled;
        private HwRevolution_AuxSBusPort mAuxSBusPort = HwRevolution_AuxSBusPort.Disabled;
        private HwRevolution_FlexiPort mFlexiPort = HwRevolution_FlexiPort.Disabled;
        private HwRevolution_TelemetryPort mTelemetryPort = HwRevolution_TelemetryPort.Telemetry;
        private HwRevolution_GPSPort mGPSPort = HwRevolution_GPSPort.GPS;
        private HwRevolution_USB_HIDPort mUSB_HIDPort = HwRevolution_USB_HIDPort.USBTelemetry;
        private HwRevolution_USB_VCPPort mUSB_VCPPort = HwRevolution_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwRevolution_GyroRange mGyroRange = HwRevolution_GyroRange._500;
        private HwRevolution_AccelRange mAccelRange = HwRevolution_AccelRange._8G;
        private HwRevolution_MPU6000Rate mMPU6000Rate = HwRevolution_MPU6000Rate._666;
        private HwRevolution_MPU6000DLPF mMPU6000DLPF = HwRevolution_MPU6000DLPF._256;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwFlyingF4_RcvrPort { Disabled, PWM, PPM, PPM_PWM, PPM_Outputs, Outputs };

    public enum HwFlyingF4_Uart1 { Disabled, GPS, S_Bus, DSM, HoTT_SUMD, HoTT_SUMH, PicoC };

    public enum HwFlyingF4_Uart2 { Disabled, Telemetry, GPS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, FrSKY_Sensor_Hub, HoTT_SUMD, HoTT_SUMH, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwFlyingF4_Uart3 { Disabled, Telemetry, GPS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, FrSKY_Sensor_Hub, HoTT_SUMD, HoTT_SUMH, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwFlyingF4_Uart4 { Disabled, GPS };

    public enum HwFlyingF4_Uart5 { Disabled, GPS };

    public enum HwFlyingF4_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwFlyingF4_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, PicoC, Disabled };

    public enum HwFlyingF4_GyroRange { _250, _500, _1000, _2000 };

    public enum HwFlyingF4_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwFlyingF4_MPU6050Rate { _200, _333, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwFlyingF4_MPU6050DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public enum HwFlyingF4_Magnetometer { Disabled, ExternalI2C };

    public enum HwFlyingF4_ExtMagOrientation { Top0degCW, Top90degCW, Top180degCW, Top270degCW, Bottom0degCW, Bottom90degCW, Bottom180degCW, Bottom270degCW };

    public class HwFlyingF4: UavDataObject
    {
        public HwFlyingF4_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwFlyingF4_Uart1 Uart1 {
            get { return mUart1; }
            set { mUart1 = value; NotifyUpdated(); }
        }

        public HwFlyingF4_Uart2 Uart2 {
            get { return mUart2; }
            set { mUart2 = value; NotifyUpdated(); }
        }

        public HwFlyingF4_Uart3 Uart3 {
            get { return mUart3; }
            set { mUart3 = value; NotifyUpdated(); }
        }

        public HwFlyingF4_Uart4 Uart4 {
            get { return mUart4; }
            set { mUart4 = value; NotifyUpdated(); }
        }

        public HwFlyingF4_Uart5 Uart5 {
            get { return mUart5; }
            set { mUart5 = value; NotifyUpdated(); }
        }

        public HwFlyingF4_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwFlyingF4_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwFlyingF4_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwFlyingF4_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwFlyingF4_MPU6050Rate MPU6050Rate {
            get { return mMPU6050Rate; }
            set { mMPU6050Rate = value; NotifyUpdated(); }
        }

        public HwFlyingF4_MPU6050DLPF MPU6050DLPF {
            get { return mMPU6050DLPF; }
            set { mMPU6050DLPF = value; NotifyUpdated(); }
        }

        public HwFlyingF4_Magnetometer Magnetometer {
            get { return mMagnetometer; }
            set { mMagnetometer = value; NotifyUpdated(); }
        }

        public HwFlyingF4_ExtMagOrientation ExtMagOrientation {
            get { return mExtMagOrientation; }
            set { mExtMagOrientation = value; NotifyUpdated(); }
        }

        public HwFlyingF4()
        {
            IsSingleInstance = true;
            ObjectId = 0xb3a4a9fc;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mRcvrPort);
            s.Write((byte)mUart1);
            s.Write((byte)mUart2);
            s.Write((byte)mUart3);
            s.Write((byte)mUart4);
            s.Write((byte)mUart5);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
            s.Write(mDSMxBind);
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU6050Rate);
            s.Write((byte)mMPU6050DLPF);
            s.Write((byte)mMagnetometer);
            s.Write((byte)mExtMagOrientation);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRcvrPort = (HwFlyingF4_RcvrPort)stream.ReadByte();
            this.mUart1 = (HwFlyingF4_Uart1)stream.ReadByte();
            this.mUart2 = (HwFlyingF4_Uart2)stream.ReadByte();
            this.mUart3 = (HwFlyingF4_Uart3)stream.ReadByte();
            this.mUart4 = (HwFlyingF4_Uart4)stream.ReadByte();
            this.mUart5 = (HwFlyingF4_Uart5)stream.ReadByte();
            this.mUSB_HIDPort = (HwFlyingF4_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwFlyingF4_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwFlyingF4_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwFlyingF4_AccelRange)stream.ReadByte();
            this.mMPU6050Rate = (HwFlyingF4_MPU6050Rate)stream.ReadByte();
            this.mMPU6050DLPF = (HwFlyingF4_MPU6050DLPF)stream.ReadByte();
            this.mMagnetometer = (HwFlyingF4_Magnetometer)stream.ReadByte();
            this.mExtMagOrientation = (HwFlyingF4_ExtMagOrientation)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwFlyingF4 \n");
            sb.AppendFormat("    RcvrPort: {0} function\n", RcvrPort);
            sb.AppendFormat("    Uart1: {0} function\n", Uart1);
            sb.AppendFormat("    Uart2: {0} function\n", Uart2);
            sb.AppendFormat("    Uart3: {0} function\n", Uart3);
            sb.AppendFormat("    Uart4: {0} function\n", Uart4);
            sb.AppendFormat("    Uart5: {0} function\n", Uart5);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);
            sb.AppendFormat("    DSMxBind: {0} \n", DSMxBind);
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU6050Rate: {0} \n", MPU6050Rate);
            sb.AppendFormat("    MPU6050DLPF: {0} \n", MPU6050DLPF);
            sb.AppendFormat("    Magnetometer: {0} function\n", Magnetometer);
            sb.AppendFormat("    ExtMagOrientation: {0} function\n", ExtMagOrientation);

            return sb.ToString();
        }

        private HwFlyingF4_RcvrPort mRcvrPort = HwFlyingF4_RcvrPort.PWM;
        private HwFlyingF4_Uart1 mUart1 = HwFlyingF4_Uart1.Disabled;
        private HwFlyingF4_Uart2 mUart2 = HwFlyingF4_Uart2.Disabled;
        private HwFlyingF4_Uart3 mUart3 = HwFlyingF4_Uart3.Disabled;
        private HwFlyingF4_Uart4 mUart4 = HwFlyingF4_Uart4.Disabled;
        private HwFlyingF4_Uart5 mUart5 = HwFlyingF4_Uart5.Disabled;
        private HwFlyingF4_USB_HIDPort mUSB_HIDPort = HwFlyingF4_USB_HIDPort.USBTelemetry;
        private HwFlyingF4_USB_VCPPort mUSB_VCPPort = HwFlyingF4_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwFlyingF4_GyroRange mGyroRange = HwFlyingF4_GyroRange._500;
        private HwFlyingF4_AccelRange mAccelRange = HwFlyingF4_AccelRange._8G;
        private HwFlyingF4_MPU6050Rate mMPU6050Rate = HwFlyingF4_MPU6050Rate._666;
        private HwFlyingF4_MPU6050DLPF mMPU6050DLPF = HwFlyingF4_MPU6050DLPF._256;
        private HwFlyingF4_Magnetometer mMagnetometer = HwFlyingF4_Magnetometer.Disabled;
        private HwFlyingF4_ExtMagOrientation mExtMagOrientation = HwFlyingF4_ExtMagOrientation.Top0degCW;
    }
}

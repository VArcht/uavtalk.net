using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwQuanton_RcvrPort { Disabled, PWM, PWM_ADC, PPM, PPM_ADC, PPM_PWM, PPM_PWM_ADC, PPM_Outputs, PPM_Outputs_ADC, Outputs, Outputs_ADC };

    public enum HwQuanton_Uart1 { Disabled, Telemetry, GPS, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwQuanton_Uart2 { Disabled, Telemetry, GPS, S_BUS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwQuanton_Uart3 { Disabled, Telemetry, GPS, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwQuanton_Uart4 { Disabled, Telemetry, GPS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, LighttelemetryTx, FrSKY_Sensor_Hub, PicoC, FrSKY_SPort_Telemetry };

    public enum HwQuanton_Uart5 { Disabled, Telemetry, GPS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, PicoC, FrSKY_SPort_Telemetry };

    public enum HwQuanton_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwQuanton_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, PicoC, Disabled };

    public enum HwQuanton_GyroRange { _250, _500, _1000, _2000 };

    public enum HwQuanton_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwQuanton_MPU6000Rate { _200, _333, _500, _666, _1000, _2000, _4000, _8000 };

    public enum HwQuanton_MPU6000DLPF { _256, _188, _98, _42, _20, _10, _5 };

    public enum HwQuanton_Magnetometer { Disabled, Internal, ExternalI2CUart1, ExternalI2CUart3 };

    public enum HwQuanton_ExtMagOrientation { Top0degCW, Top90degCW, Top180degCW, Top270degCW, Bottom0degCW, Bottom90degCW, Bottom180degCW, Bottom270degCW };

    public class HwQuanton: UavDataObject
    {
        public HwQuanton_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwQuanton_Uart1 Uart1 {
            get { return mUart1; }
            set { mUart1 = value; NotifyUpdated(); }
        }

        public HwQuanton_Uart2 Uart2 {
            get { return mUart2; }
            set { mUart2 = value; NotifyUpdated(); }
        }

        public HwQuanton_Uart3 Uart3 {
            get { return mUart3; }
            set { mUart3 = value; NotifyUpdated(); }
        }

        public HwQuanton_Uart4 Uart4 {
            get { return mUart4; }
            set { mUart4 = value; NotifyUpdated(); }
        }

        public HwQuanton_Uart5 Uart5 {
            get { return mUart5; }
            set { mUart5 = value; NotifyUpdated(); }
        }

        public HwQuanton_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwQuanton_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwQuanton_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwQuanton_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwQuanton_MPU6000Rate MPU6000Rate {
            get { return mMPU6000Rate; }
            set { mMPU6000Rate = value; NotifyUpdated(); }
        }

        public HwQuanton_MPU6000DLPF MPU6000DLPF {
            get { return mMPU6000DLPF; }
            set { mMPU6000DLPF = value; NotifyUpdated(); }
        }

        public HwQuanton_Magnetometer Magnetometer {
            get { return mMagnetometer; }
            set { mMagnetometer = value; NotifyUpdated(); }
        }

        public HwQuanton_ExtMagOrientation ExtMagOrientation {
            get { return mExtMagOrientation; }
            set { mExtMagOrientation = value; NotifyUpdated(); }
        }

        public HwQuanton()
        {
            IsSingleInstance = true;
            ObjectId = 0x176384a6;
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
            s.Write((byte)mMPU6000Rate);
            s.Write((byte)mMPU6000DLPF);
            s.Write((byte)mMagnetometer);
            s.Write((byte)mExtMagOrientation);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRcvrPort = (HwQuanton_RcvrPort)stream.ReadByte();
            this.mUart1 = (HwQuanton_Uart1)stream.ReadByte();
            this.mUart2 = (HwQuanton_Uart2)stream.ReadByte();
            this.mUart3 = (HwQuanton_Uart3)stream.ReadByte();
            this.mUart4 = (HwQuanton_Uart4)stream.ReadByte();
            this.mUart5 = (HwQuanton_Uart5)stream.ReadByte();
            this.mUSB_HIDPort = (HwQuanton_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwQuanton_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwQuanton_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwQuanton_AccelRange)stream.ReadByte();
            this.mMPU6000Rate = (HwQuanton_MPU6000Rate)stream.ReadByte();
            this.mMPU6000DLPF = (HwQuanton_MPU6000DLPF)stream.ReadByte();
            this.mMagnetometer = (HwQuanton_Magnetometer)stream.ReadByte();
            this.mExtMagOrientation = (HwQuanton_ExtMagOrientation)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwQuanton \n");
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
            sb.AppendFormat("    MPU6000Rate: {0} \n", MPU6000Rate);
            sb.AppendFormat("    MPU6000DLPF: {0} \n", MPU6000DLPF);
            sb.AppendFormat("    Magnetometer: {0} function\n", Magnetometer);
            sb.AppendFormat("    ExtMagOrientation: {0} function\n", ExtMagOrientation);

            return sb.ToString();
        }

        private HwQuanton_RcvrPort mRcvrPort = HwQuanton_RcvrPort.PWM;
        private HwQuanton_Uart1 mUart1 = HwQuanton_Uart1.Disabled;
        private HwQuanton_Uart2 mUart2 = HwQuanton_Uart2.Disabled;
        private HwQuanton_Uart3 mUart3 = HwQuanton_Uart3.Disabled;
        private HwQuanton_Uart4 mUart4 = HwQuanton_Uart4.Telemetry;
        private HwQuanton_Uart5 mUart5 = HwQuanton_Uart5.GPS;
        private HwQuanton_USB_HIDPort mUSB_HIDPort = HwQuanton_USB_HIDPort.USBTelemetry;
        private HwQuanton_USB_VCPPort mUSB_VCPPort = HwQuanton_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwQuanton_GyroRange mGyroRange = HwQuanton_GyroRange._500;
        private HwQuanton_AccelRange mAccelRange = HwQuanton_AccelRange._8G;
        private HwQuanton_MPU6000Rate mMPU6000Rate = HwQuanton_MPU6000Rate._666;
        private HwQuanton_MPU6000DLPF mMPU6000DLPF = HwQuanton_MPU6000DLPF._256;
        private HwQuanton_Magnetometer mMagnetometer = HwQuanton_Magnetometer.Internal;
        private HwQuanton_ExtMagOrientation mExtMagOrientation = HwQuanton_ExtMagOrientation.Top0degCW;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwFlyingF3_RcvrPort { Disabled, PWM, PPM, PPM_PWM, PPM_Outputs, Outputs };

    public enum HwFlyingF3_Uart1 { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwFlyingF3_Uart2 { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwFlyingF3_Uart3 { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwFlyingF3_Uart4 { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwFlyingF3_Uart5 { Disabled, Telemetry, GPS, S_Bus, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, LighttelemetryTx, FrSKY_SPort_Telemetry };

    public enum HwFlyingF3_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwFlyingF3_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, Disabled };

    public enum HwFlyingF3_GyroRange { _250, _500, _1000, _2000 };

    public enum HwFlyingF3_L3GD20Rate { _380, _760 };

    public enum HwFlyingF3_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwFlyingF3_Shield { None, RCFlyer, CheBuzz, BMP085 };

    public class HwFlyingF3: UavDataObject
    {
        public HwFlyingF3_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwFlyingF3_Uart1 Uart1 {
            get { return mUart1; }
            set { mUart1 = value; NotifyUpdated(); }
        }

        public HwFlyingF3_Uart2 Uart2 {
            get { return mUart2; }
            set { mUart2 = value; NotifyUpdated(); }
        }

        public HwFlyingF3_Uart3 Uart3 {
            get { return mUart3; }
            set { mUart3 = value; NotifyUpdated(); }
        }

        public HwFlyingF3_Uart4 Uart4 {
            get { return mUart4; }
            set { mUart4 = value; NotifyUpdated(); }
        }

        public HwFlyingF3_Uart5 Uart5 {
            get { return mUart5; }
            set { mUart5 = value; NotifyUpdated(); }
        }

        public HwFlyingF3_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwFlyingF3_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwFlyingF3_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwFlyingF3_L3GD20Rate L3GD20Rate {
            get { return mL3GD20Rate; }
            set { mL3GD20Rate = value; NotifyUpdated(); }
        }

        public HwFlyingF3_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwFlyingF3_Shield Shield {
            get { return mShield; }
            set { mShield = value; NotifyUpdated(); }
        }

        public HwFlyingF3()
        {
            IsSingleInstance = true;
            ObjectId = 0x472fae5a;
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
            s.Write((byte)mL3GD20Rate);
            s.Write((byte)mAccelRange);
            s.Write((byte)mShield);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRcvrPort = (HwFlyingF3_RcvrPort)stream.ReadByte();
            this.mUart1 = (HwFlyingF3_Uart1)stream.ReadByte();
            this.mUart2 = (HwFlyingF3_Uart2)stream.ReadByte();
            this.mUart3 = (HwFlyingF3_Uart3)stream.ReadByte();
            this.mUart4 = (HwFlyingF3_Uart4)stream.ReadByte();
            this.mUart5 = (HwFlyingF3_Uart5)stream.ReadByte();
            this.mUSB_HIDPort = (HwFlyingF3_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwFlyingF3_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mGyroRange = (HwFlyingF3_GyroRange)stream.ReadByte();
            this.mL3GD20Rate = (HwFlyingF3_L3GD20Rate)stream.ReadByte();
            this.mAccelRange = (HwFlyingF3_AccelRange)stream.ReadByte();
            this.mShield = (HwFlyingF3_Shield)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwFlyingF3 \n");
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
            sb.AppendFormat("    L3GD20Rate: {0} \n", L3GD20Rate);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    Shield: {0} \n", Shield);

            return sb.ToString();
        }

        private HwFlyingF3_RcvrPort mRcvrPort = HwFlyingF3_RcvrPort.PWM;
        private HwFlyingF3_Uart1 mUart1 = HwFlyingF3_Uart1.Disabled;
        private HwFlyingF3_Uart2 mUart2 = HwFlyingF3_Uart2.Disabled;
        private HwFlyingF3_Uart3 mUart3 = HwFlyingF3_Uart3.Disabled;
        private HwFlyingF3_Uart4 mUart4 = HwFlyingF3_Uart4.Disabled;
        private HwFlyingF3_Uart5 mUart5 = HwFlyingF3_Uart5.Disabled;
        private HwFlyingF3_USB_HIDPort mUSB_HIDPort = HwFlyingF3_USB_HIDPort.USBTelemetry;
        private HwFlyingF3_USB_VCPPort mUSB_VCPPort = HwFlyingF3_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwFlyingF3_GyroRange mGyroRange = HwFlyingF3_GyroRange._500;
        private HwFlyingF3_L3GD20Rate mL3GD20Rate = HwFlyingF3_L3GD20Rate._380;
        private HwFlyingF3_AccelRange mAccelRange = HwFlyingF3_AccelRange._8G;
        private HwFlyingF3_Shield mShield = HwFlyingF3_Shield.None;
    }
}

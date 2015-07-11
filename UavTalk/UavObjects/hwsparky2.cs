using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwSparky2_RcvrPort { Disabled, PPM, S_Bus, DSM, HoTT_SUMD, HoTT_SUMH };

    public enum HwSparky2_MainPort { Disabled, Telemetry, GPS, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, FrSKY_SPort_Telemetry, LighttelemetryTx, PicoC };

    public enum HwSparky2_FlexiPort { Disabled, Telemetry, GPS, I2C, DSM, DebugConsole, ComBridge, MavLinkTX, MavLinkTX_GPS_RX, HoTT_SUMD, HoTT_SUMH, HoTT_Telemetry, FrSKY_Sensor_Hub, FrSKY_SPort_Telemetry, LighttelemetryTx, PicoC };

    public enum HwSparky2_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwSparky2_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, PicoC, Disabled };

    public enum HwSparky2_Radio { Disabled, Telem, Telem_PPM, PPM, OpenLRS };

    public enum HwSparky2_MaxRfSpeed { _9600, _19200, _32000, _64000, _100000, _192000 };

    public enum HwSparky2_MaxRfPower { _0, _1_25, _1_6, _3_16, _6_3, _12_6, _25, _50, _100 };

    public enum HwSparky2_GyroRange { _250, _500, _1000, _2000 };

    public enum HwSparky2_AccelRange { _2G, _4G, _8G, _16G };

    public enum HwSparky2_MPU9250Rate { _200, _250, _333, _500, _1000 };

    public enum HwSparky2_MPU9250GyroLPF { _250, _184, _92, _41, _20, _10, _5 };

    public enum HwSparky2_MPU9250AccelLPF { _460, _184, _92, _41, _20, _10, _5 };

    public enum HwSparky2_VTX_Ch { _1, _2, _3, _4, _5, _6, _7, _8 };

    public enum HwSparky2_Magnetometer { Internal, ExternalI2CFlexiPort, ExternalAuxI2C };

    public enum HwSparky2_ExtMagOrientation { Top0degCW, Top90degCW, Top180degCW, Top270degCW, Bottom0degCW, Bottom90degCW, Bottom180degCW, Bottom270degCW };

    public class HwSparky2: UavDataObject
    {
        public UInt32 CoordID {
            get { return mCoordID; }
            set { mCoordID = value; NotifyUpdated(); }
        }

        public HwSparky2_RcvrPort RcvrPort {
            get { return mRcvrPort; }
            set { mRcvrPort = value; NotifyUpdated(); }
        }

        public HwSparky2_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwSparky2_FlexiPort FlexiPort {
            get { return mFlexiPort; }
            set { mFlexiPort = value; NotifyUpdated(); }
        }

        public HwSparky2_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwSparky2_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public byte DSMxBind {
            get { return mDSMxBind; }
            set { mDSMxBind = value; NotifyUpdated(); }
        }

        public HwSparky2_Radio Radio {
            get { return mRadio; }
            set { mRadio = value; NotifyUpdated(); }
        }

        public HwSparky2_MaxRfSpeed MaxRfSpeed {
            get { return mMaxRfSpeed; }
            set { mMaxRfSpeed = value; NotifyUpdated(); }
        }

        public HwSparky2_MaxRfPower MaxRfPower {
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

        public HwSparky2_GyroRange GyroRange {
            get { return mGyroRange; }
            set { mGyroRange = value; NotifyUpdated(); }
        }

        public HwSparky2_AccelRange AccelRange {
            get { return mAccelRange; }
            set { mAccelRange = value; NotifyUpdated(); }
        }

        public HwSparky2_MPU9250Rate MPU9250Rate {
            get { return mMPU9250Rate; }
            set { mMPU9250Rate = value; NotifyUpdated(); }
        }

        public HwSparky2_MPU9250GyroLPF MPU9250GyroLPF {
            get { return mMPU9250GyroLPF; }
            set { mMPU9250GyroLPF = value; NotifyUpdated(); }
        }

        public HwSparky2_MPU9250AccelLPF MPU9250AccelLPF {
            get { return mMPU9250AccelLPF; }
            set { mMPU9250AccelLPF = value; NotifyUpdated(); }
        }

        public HwSparky2_VTX_Ch VTX_Ch {
            get { return mVTX_Ch; }
            set { mVTX_Ch = value; NotifyUpdated(); }
        }

        public HwSparky2_Magnetometer Magnetometer {
            get { return mMagnetometer; }
            set { mMagnetometer = value; NotifyUpdated(); }
        }

        public HwSparky2_ExtMagOrientation ExtMagOrientation {
            get { return mExtMagOrientation; }
            set { mExtMagOrientation = value; NotifyUpdated(); }
        }

        public HwSparky2()
        {
            IsSingleInstance = true;
            ObjectId = 0xf951374c;
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
            s.Write((byte)mGyroRange);
            s.Write((byte)mAccelRange);
            s.Write((byte)mMPU9250Rate);
            s.Write((byte)mMPU9250GyroLPF);
            s.Write((byte)mMPU9250AccelLPF);
            s.Write((byte)mVTX_Ch);
            s.Write((byte)mMagnetometer);
            s.Write((byte)mExtMagOrientation);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mCoordID = stream.ReadUInt32();
            this.mRcvrPort = (HwSparky2_RcvrPort)stream.ReadByte();
            this.mMainPort = (HwSparky2_MainPort)stream.ReadByte();
            this.mFlexiPort = (HwSparky2_FlexiPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwSparky2_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwSparky2_USB_VCPPort)stream.ReadByte();
            this.mDSMxBind = stream.ReadByte();
            this.mRadio = (HwSparky2_Radio)stream.ReadByte();
            this.mMaxRfSpeed = (HwSparky2_MaxRfSpeed)stream.ReadByte();
            this.mMaxRfPower = (HwSparky2_MaxRfPower)stream.ReadByte();
            this.mMinChannel = stream.ReadByte();
            this.mMaxChannel = stream.ReadByte();
            this.mGyroRange = (HwSparky2_GyroRange)stream.ReadByte();
            this.mAccelRange = (HwSparky2_AccelRange)stream.ReadByte();
            this.mMPU9250Rate = (HwSparky2_MPU9250Rate)stream.ReadByte();
            this.mMPU9250GyroLPF = (HwSparky2_MPU9250GyroLPF)stream.ReadByte();
            this.mMPU9250AccelLPF = (HwSparky2_MPU9250AccelLPF)stream.ReadByte();
            this.mVTX_Ch = (HwSparky2_VTX_Ch)stream.ReadByte();
            this.mMagnetometer = (HwSparky2_Magnetometer)stream.ReadByte();
            this.mExtMagOrientation = (HwSparky2_ExtMagOrientation)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwSparky2 \n");
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
            sb.AppendFormat("    GyroRange: {0} deg/s\n", GyroRange);
            sb.AppendFormat("    AccelRange: {0} *gravity m/s^2\n", AccelRange);
            sb.AppendFormat("    MPU9250Rate: {0} Hz\n", MPU9250Rate);
            sb.AppendFormat("    MPU9250GyroLPF: {0} Hz\n", MPU9250GyroLPF);
            sb.AppendFormat("    MPU9250AccelLPF: {0} Hz\n", MPU9250AccelLPF);
            sb.AppendFormat("    VTX_Ch: {0} Hz\n", VTX_Ch);
            sb.AppendFormat("    Magnetometer: {0} function\n", Magnetometer);
            sb.AppendFormat("    ExtMagOrientation: {0} function\n", ExtMagOrientation);

            return sb.ToString();
        }

        private UInt32 mCoordID = 0;
        private HwSparky2_RcvrPort mRcvrPort = HwSparky2_RcvrPort.Disabled;
        private HwSparky2_MainPort mMainPort = HwSparky2_MainPort.Disabled;
        private HwSparky2_FlexiPort mFlexiPort = HwSparky2_FlexiPort.Disabled;
        private HwSparky2_USB_HIDPort mUSB_HIDPort = HwSparky2_USB_HIDPort.USBTelemetry;
        private HwSparky2_USB_VCPPort mUSB_VCPPort = HwSparky2_USB_VCPPort.Disabled;
        private byte mDSMxBind = 0;
        private HwSparky2_Radio mRadio = HwSparky2_Radio.Disabled;
        private HwSparky2_MaxRfSpeed mMaxRfSpeed = HwSparky2_MaxRfSpeed._64000;
        private HwSparky2_MaxRfPower mMaxRfPower = HwSparky2_MaxRfPower._1_25;
        private byte mMinChannel = 0;
        private byte mMaxChannel = 250;
        private HwSparky2_GyroRange mGyroRange = HwSparky2_GyroRange._2000;
        private HwSparky2_AccelRange mAccelRange = HwSparky2_AccelRange._8G;
        private HwSparky2_MPU9250Rate mMPU9250Rate = HwSparky2_MPU9250Rate._500;
        private HwSparky2_MPU9250GyroLPF mMPU9250GyroLPF = HwSparky2_MPU9250GyroLPF._184;
        private HwSparky2_MPU9250AccelLPF mMPU9250AccelLPF = HwSparky2_MPU9250AccelLPF._184;
        private HwSparky2_VTX_Ch mVTX_Ch = HwSparky2_VTX_Ch._1;
        private HwSparky2_Magnetometer mMagnetometer = HwSparky2_Magnetometer.Internal;
        private HwSparky2_ExtMagOrientation mExtMagOrientation = HwSparky2_ExtMagOrientation.Top0degCW;
    }
}

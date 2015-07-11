using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum ModuleSettings_AdminState { Disabled, Enabled };

    public enum ModuleSettings_TelemetrySpeed { _2400, _4800, _9600, _19200, _38400, _57600, _115200 };

    public enum ModuleSettings_GPSSpeed { _2400, _4800, _9600, _19200, _38400, _57600, _115200, _230400 };

    public enum ModuleSettings_GPSDataProtocol { NMEA, UBX };

    public enum ModuleSettings_GPSAutoConfigure { FALSE, TRUE };

    public enum ModuleSettings_GPSConstellation { All, GPS, GLONASS };

    public enum ModuleSettings_GPSSBASConstellation { All, WAAS, EGNOS, MSAS, GAGAN, None };

    public enum ModuleSettings_GPSDynamicsMode { Portable, Pedestrian, Automotive, Airborne1G, Airborne2G, Airborne4G };

    public enum ModuleSettings_ComUsbBridgeSpeed { _2400, _4800, _9600, _19200, _38400, _57600, _115200 };

    public enum ModuleSettings_I2CVMProgramSelect { EndianTest, MathTest, None, OPBaroAltimeter, User };

    public enum ModuleSettings_MavlinkSpeed { _2400, _4800, _9600, _19200, _38400, _57600, _115200 };

    public enum ModuleSettings_LightTelemetrySpeed { _1200, _2400, _4800, _9600, _19200, _38400, _57600, _115200 };

    public class ModuleSettings: UavDataObject
    {
        public ModuleSettings_AdminState[] AdminState {
            get { return mAdminState; }
            set { mAdminState = value; NotifyUpdated(); }
        }

        public ModuleSettings_TelemetrySpeed TelemetrySpeed {
            get { return mTelemetrySpeed; }
            set { mTelemetrySpeed = value; NotifyUpdated(); }
        }

        public ModuleSettings_GPSSpeed GPSSpeed {
            get { return mGPSSpeed; }
            set { mGPSSpeed = value; NotifyUpdated(); }
        }

        public ModuleSettings_GPSDataProtocol GPSDataProtocol {
            get { return mGPSDataProtocol; }
            set { mGPSDataProtocol = value; NotifyUpdated(); }
        }

        public ModuleSettings_GPSAutoConfigure GPSAutoConfigure {
            get { return mGPSAutoConfigure; }
            set { mGPSAutoConfigure = value; NotifyUpdated(); }
        }

        public ModuleSettings_GPSConstellation GPSConstellation {
            get { return mGPSConstellation; }
            set { mGPSConstellation = value; NotifyUpdated(); }
        }

        public ModuleSettings_GPSSBASConstellation GPSSBASConstellation {
            get { return mGPSSBASConstellation; }
            set { mGPSSBASConstellation = value; NotifyUpdated(); }
        }

        public ModuleSettings_GPSDynamicsMode GPSDynamicsMode {
            get { return mGPSDynamicsMode; }
            set { mGPSDynamicsMode = value; NotifyUpdated(); }
        }

        public ModuleSettings_ComUsbBridgeSpeed ComUsbBridgeSpeed {
            get { return mComUsbBridgeSpeed; }
            set { mComUsbBridgeSpeed = value; NotifyUpdated(); }
        }

        public ModuleSettings_I2CVMProgramSelect I2CVMProgramSelect {
            get { return mI2CVMProgramSelect; }
            set { mI2CVMProgramSelect = value; NotifyUpdated(); }
        }

        public ModuleSettings_MavlinkSpeed MavlinkSpeed {
            get { return mMavlinkSpeed; }
            set { mMavlinkSpeed = value; NotifyUpdated(); }
        }

        public ModuleSettings_LightTelemetrySpeed LightTelemetrySpeed {
            get { return mLightTelemetrySpeed; }
            set { mLightTelemetrySpeed = value; NotifyUpdated(); }
        }

        public ModuleSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xb2dee4cc;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mAdminState[0]);  // Airspeed
            s.Write((byte)mAdminState[1]);  // AltitudeHold
            s.Write((byte)mAdminState[2]);  // Autotune
            s.Write((byte)mAdminState[3]);  // Battery
            s.Write((byte)mAdminState[4]);  // CameraStab
            s.Write((byte)mAdminState[5]);  // ComUsbBridge
            s.Write((byte)mAdminState[6]);  // FixedWingPathFollower
            s.Write((byte)mAdminState[7]);  // Fault
            s.Write((byte)mAdminState[8]);  // GPS
            s.Write((byte)mAdminState[9]);  // OveroSync
            s.Write((byte)mAdminState[10]);  // PathPlanner
            s.Write((byte)mAdminState[11]);  // TxPID
            s.Write((byte)mAdminState[12]);  // VtolPathFollower
            s.Write((byte)mAdminState[13]);  // GroundPathFollower
            s.Write((byte)mAdminState[14]);  // GenericI2CSensor
            s.Write((byte)mAdminState[15]);  // UAVOMavlinkBridge
            s.Write((byte)mAdminState[16]);  // UAVOLighttelemetryBridge
            s.Write((byte)mAdminState[17]);  // VibrationAnalysis
            s.Write((byte)mAdminState[18]);  // UAVOHoTTBridge
            s.Write((byte)mAdminState[19]);  // UAVOFrSKYSensorHubBridge
            s.Write((byte)mAdminState[20]);  // PicoC
            s.Write((byte)mAdminState[21]);  // UAVOFrSkySPortBridge
            s.Write((byte)mAdminState[22]);  // Geofence
            s.Write((byte)mAdminState[23]);  // Logging
            s.Write((byte)mAdminState[24]);  // FlightStats
            s.Write((byte)mTelemetrySpeed);
            s.Write((byte)mGPSSpeed);
            s.Write((byte)mGPSDataProtocol);
            s.Write((byte)mGPSAutoConfigure);
            s.Write((byte)mGPSConstellation);
            s.Write((byte)mGPSSBASConstellation);
            s.Write((byte)mGPSDynamicsMode);
            s.Write((byte)mComUsbBridgeSpeed);
            s.Write((byte)mI2CVMProgramSelect);
            s.Write((byte)mMavlinkSpeed);
            s.Write((byte)mLightTelemetrySpeed);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mAdminState[0] = (ModuleSettings_AdminState)stream.ReadByte();  // Airspeed
            this.mAdminState[1] = (ModuleSettings_AdminState)stream.ReadByte();  // AltitudeHold
            this.mAdminState[2] = (ModuleSettings_AdminState)stream.ReadByte();  // Autotune
            this.mAdminState[3] = (ModuleSettings_AdminState)stream.ReadByte();  // Battery
            this.mAdminState[4] = (ModuleSettings_AdminState)stream.ReadByte();  // CameraStab
            this.mAdminState[5] = (ModuleSettings_AdminState)stream.ReadByte();  // ComUsbBridge
            this.mAdminState[6] = (ModuleSettings_AdminState)stream.ReadByte();  // FixedWingPathFollower
            this.mAdminState[7] = (ModuleSettings_AdminState)stream.ReadByte();  // Fault
            this.mAdminState[8] = (ModuleSettings_AdminState)stream.ReadByte();  // GPS
            this.mAdminState[9] = (ModuleSettings_AdminState)stream.ReadByte();  // OveroSync
            this.mAdminState[10] = (ModuleSettings_AdminState)stream.ReadByte();  // PathPlanner
            this.mAdminState[11] = (ModuleSettings_AdminState)stream.ReadByte();  // TxPID
            this.mAdminState[12] = (ModuleSettings_AdminState)stream.ReadByte();  // VtolPathFollower
            this.mAdminState[13] = (ModuleSettings_AdminState)stream.ReadByte();  // GroundPathFollower
            this.mAdminState[14] = (ModuleSettings_AdminState)stream.ReadByte();  // GenericI2CSensor
            this.mAdminState[15] = (ModuleSettings_AdminState)stream.ReadByte();  // UAVOMavlinkBridge
            this.mAdminState[16] = (ModuleSettings_AdminState)stream.ReadByte();  // UAVOLighttelemetryBridge
            this.mAdminState[17] = (ModuleSettings_AdminState)stream.ReadByte();  // VibrationAnalysis
            this.mAdminState[18] = (ModuleSettings_AdminState)stream.ReadByte();  // UAVOHoTTBridge
            this.mAdminState[19] = (ModuleSettings_AdminState)stream.ReadByte();  // UAVOFrSKYSensorHubBridge
            this.mAdminState[20] = (ModuleSettings_AdminState)stream.ReadByte();  // PicoC
            this.mAdminState[21] = (ModuleSettings_AdminState)stream.ReadByte();  // UAVOFrSkySPortBridge
            this.mAdminState[22] = (ModuleSettings_AdminState)stream.ReadByte();  // Geofence
            this.mAdminState[23] = (ModuleSettings_AdminState)stream.ReadByte();  // Logging
            this.mAdminState[24] = (ModuleSettings_AdminState)stream.ReadByte();  // FlightStats
            this.mTelemetrySpeed = (ModuleSettings_TelemetrySpeed)stream.ReadByte();
            this.mGPSSpeed = (ModuleSettings_GPSSpeed)stream.ReadByte();
            this.mGPSDataProtocol = (ModuleSettings_GPSDataProtocol)stream.ReadByte();
            this.mGPSAutoConfigure = (ModuleSettings_GPSAutoConfigure)stream.ReadByte();
            this.mGPSConstellation = (ModuleSettings_GPSConstellation)stream.ReadByte();
            this.mGPSSBASConstellation = (ModuleSettings_GPSSBASConstellation)stream.ReadByte();
            this.mGPSDynamicsMode = (ModuleSettings_GPSDynamicsMode)stream.ReadByte();
            this.mComUsbBridgeSpeed = (ModuleSettings_ComUsbBridgeSpeed)stream.ReadByte();
            this.mI2CVMProgramSelect = (ModuleSettings_I2CVMProgramSelect)stream.ReadByte();
            this.mMavlinkSpeed = (ModuleSettings_MavlinkSpeed)stream.ReadByte();
            this.mLightTelemetrySpeed = (ModuleSettings_LightTelemetrySpeed)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("ModuleSettings \n");
            sb.Append("    AdminState\n");
            sb.AppendFormat("        Airspeed: {0} \n", AdminState[0]);
            sb.AppendFormat("        AltitudeHold: {0} \n", AdminState[1]);
            sb.AppendFormat("        Autotune: {0} \n", AdminState[2]);
            sb.AppendFormat("        Battery: {0} \n", AdminState[3]);
            sb.AppendFormat("        CameraStab: {0} \n", AdminState[4]);
            sb.AppendFormat("        ComUsbBridge: {0} \n", AdminState[5]);
            sb.AppendFormat("        FixedWingPathFollower: {0} \n", AdminState[6]);
            sb.AppendFormat("        Fault: {0} \n", AdminState[7]);
            sb.AppendFormat("        GPS: {0} \n", AdminState[8]);
            sb.AppendFormat("        OveroSync: {0} \n", AdminState[9]);
            sb.AppendFormat("        PathPlanner: {0} \n", AdminState[10]);
            sb.AppendFormat("        TxPID: {0} \n", AdminState[11]);
            sb.AppendFormat("        VtolPathFollower: {0} \n", AdminState[12]);
            sb.AppendFormat("        GroundPathFollower: {0} \n", AdminState[13]);
            sb.AppendFormat("        GenericI2CSensor: {0} \n", AdminState[14]);
            sb.AppendFormat("        UAVOMavlinkBridge: {0} \n", AdminState[15]);
            sb.AppendFormat("        UAVOLighttelemetryBridge: {0} \n", AdminState[16]);
            sb.AppendFormat("        VibrationAnalysis: {0} \n", AdminState[17]);
            sb.AppendFormat("        UAVOHoTTBridge: {0} \n", AdminState[18]);
            sb.AppendFormat("        UAVOFrSKYSensorHubBridge: {0} \n", AdminState[19]);
            sb.AppendFormat("        PicoC: {0} \n", AdminState[20]);
            sb.AppendFormat("        UAVOFrSkySPortBridge: {0} \n", AdminState[21]);
            sb.AppendFormat("        Geofence: {0} \n", AdminState[22]);
            sb.AppendFormat("        Logging: {0} \n", AdminState[23]);
            sb.AppendFormat("        FlightStats: {0} \n", AdminState[24]);
            sb.AppendFormat("    TelemetrySpeed: {0} bps\n", TelemetrySpeed);
            sb.AppendFormat("    GPSSpeed: {0} bps\n", GPSSpeed);
            sb.AppendFormat("    GPSDataProtocol: {0} \n", GPSDataProtocol);
            sb.AppendFormat("    GPSAutoConfigure: {0} \n", GPSAutoConfigure);
            sb.AppendFormat("    GPSConstellation: {0} \n", GPSConstellation);
            sb.AppendFormat("    GPSSBASConstellation: {0} \n", GPSSBASConstellation);
            sb.AppendFormat("    GPSDynamicsMode: {0} \n", GPSDynamicsMode);
            sb.AppendFormat("    ComUsbBridgeSpeed: {0} bps\n", ComUsbBridgeSpeed);
            sb.AppendFormat("    I2CVMProgramSelect: {0} \n", I2CVMProgramSelect);
            sb.AppendFormat("    MavlinkSpeed: {0} bps\n", MavlinkSpeed);
            sb.AppendFormat("    LightTelemetrySpeed: {0} bps\n", LightTelemetrySpeed);

            return sb.ToString();
        }

        private ModuleSettings_AdminState[] mAdminState = new ModuleSettings_AdminState[25] { ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled, ModuleSettings_AdminState.Disabled };
        private ModuleSettings_TelemetrySpeed mTelemetrySpeed = ModuleSettings_TelemetrySpeed._57600;
        private ModuleSettings_GPSSpeed mGPSSpeed = ModuleSettings_GPSSpeed._57600;
        private ModuleSettings_GPSDataProtocol mGPSDataProtocol = ModuleSettings_GPSDataProtocol.UBX;
        private ModuleSettings_GPSAutoConfigure mGPSAutoConfigure = ModuleSettings_GPSAutoConfigure.TRUE;
        private ModuleSettings_GPSConstellation mGPSConstellation = ModuleSettings_GPSConstellation.GPS;
        private ModuleSettings_GPSSBASConstellation mGPSSBASConstellation = ModuleSettings_GPSSBASConstellation.All;
        private ModuleSettings_GPSDynamicsMode mGPSDynamicsMode = ModuleSettings_GPSDynamicsMode.Airborne2G;
        private ModuleSettings_ComUsbBridgeSpeed mComUsbBridgeSpeed = ModuleSettings_ComUsbBridgeSpeed._57600;
        private ModuleSettings_I2CVMProgramSelect mI2CVMProgramSelect = ModuleSettings_I2CVMProgramSelect.None;
        private ModuleSettings_MavlinkSpeed mMavlinkSpeed = ModuleSettings_MavlinkSpeed._57600;
        private ModuleSettings_LightTelemetrySpeed mLightTelemetrySpeed = ModuleSettings_LightTelemetrySpeed._2400;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HoTTSettings_Sensor { Disabled, Enabled };

    public enum HoTTSettings_Warning { Disabled, Enabled };

    public class HoTTSettings: UavDataObject
    {
        public float[] Limit {
            get { return mLimit; }
            set { mLimit = value; NotifyUpdated(); }
        }

        public HoTTSettings_Sensor[] Sensor {
            get { return mSensor; }
            set { mSensor = value; NotifyUpdated(); }
        }

        public HoTTSettings_Warning[] Warning {
            get { return mWarning; }
            set { mWarning = value; NotifyUpdated(); }
        }

        public HoTTSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x6cbc1102;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mLimit[0]);  // MinSpeed
            s.Write(mLimit[1]);  // MaxSpeed
            s.Write(mLimit[2]);  // NegDifference1
            s.Write(mLimit[3]);  // PosDifference1
            s.Write(mLimit[4]);  // NegDifference2
            s.Write(mLimit[5]);  // PosDifference2
            s.Write(mLimit[6]);  // MinHeight
            s.Write(mLimit[7]);  // MaxHeight
            s.Write(mLimit[8]);  // MaxDistance
            s.Write(mLimit[9]);  // MinPowerVoltage
            s.Write(mLimit[10]);  // MaxPowerVoltage
            s.Write(mLimit[11]);  // MinSensor1Voltage
            s.Write(mLimit[12]);  // MaxSensor1Voltage
            s.Write(mLimit[13]);  // MinSensor2Voltage
            s.Write(mLimit[14]);  // MaxSensor2Voltage
            s.Write(mLimit[15]);  // MinCellVoltage
            s.Write(mLimit[16]);  // MaxCurrent
            s.Write(mLimit[17]);  // MaxUsedCapacity
            s.Write(mLimit[18]);  // MinSensor1Temp
            s.Write(mLimit[19]);  // MaxSensor1Temp
            s.Write(mLimit[20]);  // MinSensor2Temp
            s.Write(mLimit[21]);  // MaxSensor2Temp
            s.Write(mLimit[22]);  // MaxServoTemp
            s.Write(mLimit[23]);  // MinRPM
            s.Write(mLimit[24]);  // MaxRPM
            s.Write(mLimit[25]);  // MinFuel
            s.Write(mLimit[26]);  // MaxServoDifference
            s.Write((byte)mSensor[0]);  // VARIO
            s.Write((byte)mSensor[1]);  // GPS
            s.Write((byte)mSensor[2]);  // EAM
            s.Write((byte)mSensor[3]);  // GAM
            s.Write((byte)mSensor[4]);  // ESC
            s.Write((byte)mWarning[0]);  // AltitudeBeep
            s.Write((byte)mWarning[1]);  // MinSpeed
            s.Write((byte)mWarning[2]);  // MaxSpeed
            s.Write((byte)mWarning[3]);  // NegDifference1
            s.Write((byte)mWarning[4]);  // PosDifference1
            s.Write((byte)mWarning[5]);  // NegDifference2
            s.Write((byte)mWarning[6]);  // PosDifference2
            s.Write((byte)mWarning[7]);  // MinHeight
            s.Write((byte)mWarning[8]);  // MaxHeight
            s.Write((byte)mWarning[9]);  // MaxDistance
            s.Write((byte)mWarning[10]);  // MinPowerVoltage
            s.Write((byte)mWarning[11]);  // MaxPowerVoltage
            s.Write((byte)mWarning[12]);  // MinSensor1Voltage
            s.Write((byte)mWarning[13]);  // MaxSensor1Voltage
            s.Write((byte)mWarning[14]);  // MinSensor2Voltage
            s.Write((byte)mWarning[15]);  // MaxSensor2Voltage
            s.Write((byte)mWarning[16]);  // MinCellVoltage
            s.Write((byte)mWarning[17]);  // MaxCurrent
            s.Write((byte)mWarning[18]);  // MaxUsedCapacity
            s.Write((byte)mWarning[19]);  // MinSensor1Temp
            s.Write((byte)mWarning[20]);  // MaxSensor1Temp
            s.Write((byte)mWarning[21]);  // MinSensor2Temp
            s.Write((byte)mWarning[22]);  // MaxSensor2Temp
            s.Write((byte)mWarning[23]);  // MaxServoTemp
            s.Write((byte)mWarning[24]);  // MinRPM
            s.Write((byte)mWarning[25]);  // MaxRPM
            s.Write((byte)mWarning[26]);  // MinFuel
            s.Write((byte)mWarning[27]);  // MaxServoDifference
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mLimit[0] = stream.ReadSingle();  // MinSpeed
            this.mLimit[1] = stream.ReadSingle();  // MaxSpeed
            this.mLimit[2] = stream.ReadSingle();  // NegDifference1
            this.mLimit[3] = stream.ReadSingle();  // PosDifference1
            this.mLimit[4] = stream.ReadSingle();  // NegDifference2
            this.mLimit[5] = stream.ReadSingle();  // PosDifference2
            this.mLimit[6] = stream.ReadSingle();  // MinHeight
            this.mLimit[7] = stream.ReadSingle();  // MaxHeight
            this.mLimit[8] = stream.ReadSingle();  // MaxDistance
            this.mLimit[9] = stream.ReadSingle();  // MinPowerVoltage
            this.mLimit[10] = stream.ReadSingle();  // MaxPowerVoltage
            this.mLimit[11] = stream.ReadSingle();  // MinSensor1Voltage
            this.mLimit[12] = stream.ReadSingle();  // MaxSensor1Voltage
            this.mLimit[13] = stream.ReadSingle();  // MinSensor2Voltage
            this.mLimit[14] = stream.ReadSingle();  // MaxSensor2Voltage
            this.mLimit[15] = stream.ReadSingle();  // MinCellVoltage
            this.mLimit[16] = stream.ReadSingle();  // MaxCurrent
            this.mLimit[17] = stream.ReadSingle();  // MaxUsedCapacity
            this.mLimit[18] = stream.ReadSingle();  // MinSensor1Temp
            this.mLimit[19] = stream.ReadSingle();  // MaxSensor1Temp
            this.mLimit[20] = stream.ReadSingle();  // MinSensor2Temp
            this.mLimit[21] = stream.ReadSingle();  // MaxSensor2Temp
            this.mLimit[22] = stream.ReadSingle();  // MaxServoTemp
            this.mLimit[23] = stream.ReadSingle();  // MinRPM
            this.mLimit[24] = stream.ReadSingle();  // MaxRPM
            this.mLimit[25] = stream.ReadSingle();  // MinFuel
            this.mLimit[26] = stream.ReadSingle();  // MaxServoDifference
            this.mSensor[0] = (HoTTSettings_Sensor)stream.ReadByte();  // VARIO
            this.mSensor[1] = (HoTTSettings_Sensor)stream.ReadByte();  // GPS
            this.mSensor[2] = (HoTTSettings_Sensor)stream.ReadByte();  // EAM
            this.mSensor[3] = (HoTTSettings_Sensor)stream.ReadByte();  // GAM
            this.mSensor[4] = (HoTTSettings_Sensor)stream.ReadByte();  // ESC
            this.mWarning[0] = (HoTTSettings_Warning)stream.ReadByte();  // AltitudeBeep
            this.mWarning[1] = (HoTTSettings_Warning)stream.ReadByte();  // MinSpeed
            this.mWarning[2] = (HoTTSettings_Warning)stream.ReadByte();  // MaxSpeed
            this.mWarning[3] = (HoTTSettings_Warning)stream.ReadByte();  // NegDifference1
            this.mWarning[4] = (HoTTSettings_Warning)stream.ReadByte();  // PosDifference1
            this.mWarning[5] = (HoTTSettings_Warning)stream.ReadByte();  // NegDifference2
            this.mWarning[6] = (HoTTSettings_Warning)stream.ReadByte();  // PosDifference2
            this.mWarning[7] = (HoTTSettings_Warning)stream.ReadByte();  // MinHeight
            this.mWarning[8] = (HoTTSettings_Warning)stream.ReadByte();  // MaxHeight
            this.mWarning[9] = (HoTTSettings_Warning)stream.ReadByte();  // MaxDistance
            this.mWarning[10] = (HoTTSettings_Warning)stream.ReadByte();  // MinPowerVoltage
            this.mWarning[11] = (HoTTSettings_Warning)stream.ReadByte();  // MaxPowerVoltage
            this.mWarning[12] = (HoTTSettings_Warning)stream.ReadByte();  // MinSensor1Voltage
            this.mWarning[13] = (HoTTSettings_Warning)stream.ReadByte();  // MaxSensor1Voltage
            this.mWarning[14] = (HoTTSettings_Warning)stream.ReadByte();  // MinSensor2Voltage
            this.mWarning[15] = (HoTTSettings_Warning)stream.ReadByte();  // MaxSensor2Voltage
            this.mWarning[16] = (HoTTSettings_Warning)stream.ReadByte();  // MinCellVoltage
            this.mWarning[17] = (HoTTSettings_Warning)stream.ReadByte();  // MaxCurrent
            this.mWarning[18] = (HoTTSettings_Warning)stream.ReadByte();  // MaxUsedCapacity
            this.mWarning[19] = (HoTTSettings_Warning)stream.ReadByte();  // MinSensor1Temp
            this.mWarning[20] = (HoTTSettings_Warning)stream.ReadByte();  // MaxSensor1Temp
            this.mWarning[21] = (HoTTSettings_Warning)stream.ReadByte();  // MinSensor2Temp
            this.mWarning[22] = (HoTTSettings_Warning)stream.ReadByte();  // MaxSensor2Temp
            this.mWarning[23] = (HoTTSettings_Warning)stream.ReadByte();  // MaxServoTemp
            this.mWarning[24] = (HoTTSettings_Warning)stream.ReadByte();  // MinRPM
            this.mWarning[25] = (HoTTSettings_Warning)stream.ReadByte();  // MaxRPM
            this.mWarning[26] = (HoTTSettings_Warning)stream.ReadByte();  // MinFuel
            this.mWarning[27] = (HoTTSettings_Warning)stream.ReadByte();  // MaxServoDifference
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HoTTSettings \n");
            sb.Append("    Limit\n");
            sb.AppendFormat("        MinSpeed: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[0]);
            sb.AppendFormat("        MaxSpeed: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[1]);
            sb.AppendFormat("        NegDifference1: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[2]);
            sb.AppendFormat("        PosDifference1: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[3]);
            sb.AppendFormat("        NegDifference2: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[4]);
            sb.AppendFormat("        PosDifference2: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[5]);
            sb.AppendFormat("        MinHeight: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[6]);
            sb.AppendFormat("        MaxHeight: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[7]);
            sb.AppendFormat("        MaxDistance: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[8]);
            sb.AppendFormat("        MinPowerVoltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[9]);
            sb.AppendFormat("        MaxPowerVoltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[10]);
            sb.AppendFormat("        MinSensor1Voltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[11]);
            sb.AppendFormat("        MaxSensor1Voltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[12]);
            sb.AppendFormat("        MinSensor2Voltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[13]);
            sb.AppendFormat("        MaxSensor2Voltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[14]);
            sb.AppendFormat("        MinCellVoltage: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[15]);
            sb.AppendFormat("        MaxCurrent: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[16]);
            sb.AppendFormat("        MaxUsedCapacity: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[17]);
            sb.AppendFormat("        MinSensor1Temp: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[18]);
            sb.AppendFormat("        MaxSensor1Temp: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[19]);
            sb.AppendFormat("        MinSensor2Temp: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[20]);
            sb.AppendFormat("        MaxSensor2Temp: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[21]);
            sb.AppendFormat("        MaxServoTemp: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[22]);
            sb.AppendFormat("        MinRPM: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[23]);
            sb.AppendFormat("        MaxRPM: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[24]);
            sb.AppendFormat("        MinFuel: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[25]);
            sb.AppendFormat("        MaxServoDifference: {0} (km/h)/(m/s)/m/V/A/mAh/C/ml\n", Limit[26]);
            sb.Append("    Sensor\n");
            sb.AppendFormat("        VARIO: {0} \n", Sensor[0]);
            sb.AppendFormat("        GPS: {0} \n", Sensor[1]);
            sb.AppendFormat("        EAM: {0} \n", Sensor[2]);
            sb.AppendFormat("        GAM: {0} \n", Sensor[3]);
            sb.AppendFormat("        ESC: {0} \n", Sensor[4]);
            sb.Append("    Warning\n");
            sb.AppendFormat("        AltitudeBeep: {0} \n", Warning[0]);
            sb.AppendFormat("        MinSpeed: {0} \n", Warning[1]);
            sb.AppendFormat("        MaxSpeed: {0} \n", Warning[2]);
            sb.AppendFormat("        NegDifference1: {0} \n", Warning[3]);
            sb.AppendFormat("        PosDifference1: {0} \n", Warning[4]);
            sb.AppendFormat("        NegDifference2: {0} \n", Warning[5]);
            sb.AppendFormat("        PosDifference2: {0} \n", Warning[6]);
            sb.AppendFormat("        MinHeight: {0} \n", Warning[7]);
            sb.AppendFormat("        MaxHeight: {0} \n", Warning[8]);
            sb.AppendFormat("        MaxDistance: {0} \n", Warning[9]);
            sb.AppendFormat("        MinPowerVoltage: {0} \n", Warning[10]);
            sb.AppendFormat("        MaxPowerVoltage: {0} \n", Warning[11]);
            sb.AppendFormat("        MinSensor1Voltage: {0} \n", Warning[12]);
            sb.AppendFormat("        MaxSensor1Voltage: {0} \n", Warning[13]);
            sb.AppendFormat("        MinSensor2Voltage: {0} \n", Warning[14]);
            sb.AppendFormat("        MaxSensor2Voltage: {0} \n", Warning[15]);
            sb.AppendFormat("        MinCellVoltage: {0} \n", Warning[16]);
            sb.AppendFormat("        MaxCurrent: {0} \n", Warning[17]);
            sb.AppendFormat("        MaxUsedCapacity: {0} \n", Warning[18]);
            sb.AppendFormat("        MinSensor1Temp: {0} \n", Warning[19]);
            sb.AppendFormat("        MaxSensor1Temp: {0} \n", Warning[20]);
            sb.AppendFormat("        MinSensor2Temp: {0} \n", Warning[21]);
            sb.AppendFormat("        MaxSensor2Temp: {0} \n", Warning[22]);
            sb.AppendFormat("        MaxServoTemp: {0} \n", Warning[23]);
            sb.AppendFormat("        MinRPM: {0} \n", Warning[24]);
            sb.AppendFormat("        MaxRPM: {0} \n", Warning[25]);
            sb.AppendFormat("        MinFuel: {0} \n", Warning[26]);
            sb.AppendFormat("        MaxServoDifference: {0} \n", Warning[27]);

            return sb.ToString();
        }

        private float[] mLimit = new float[27] { 30f, 100f, -10f, 10f, -1f, 1f, 20f, 500f, 1500f, 5f, 30f, 5f, 30f, 5f, 30f, 3.3f, 40f, 2000f, 0f, 100f, 0f, 100f, 100f, 100f, 7000f, 1000f, 0f };
        private HoTTSettings_Sensor[] mSensor = new HoTTSettings_Sensor[5] { HoTTSettings_Sensor.Disabled, HoTTSettings_Sensor.Disabled, HoTTSettings_Sensor.Disabled, HoTTSettings_Sensor.Disabled, HoTTSettings_Sensor.Disabled };
        private HoTTSettings_Warning[] mWarning = new HoTTSettings_Warning[28] { HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled, HoTTSettings_Warning.Disabled };
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum OpenLRS_RSSI_Type { Combined, RSSI, LinkQuality };

    public class OpenLRS: UavDataObject
    {
        public UInt32 serial_baudrate {
            get { return mserial_baudrate; }
            set { mserial_baudrate = value; NotifyUpdated(); }
        }

        public UInt32 rf_frequency {
            get { return mrf_frequency; }
            set { mrf_frequency = value; NotifyUpdated(); }
        }

        public UInt32 rf_magic {
            get { return mrf_magic; }
            set { mrf_magic = value; NotifyUpdated(); }
        }

        public UInt32 beacon_frequency {
            get { return mbeacon_frequency; }
            set { mbeacon_frequency = value; NotifyUpdated(); }
        }

        public UInt32 failsafe_delay {
            get { return mfailsafe_delay; }
            set { mfailsafe_delay = value; NotifyUpdated(); }
        }

        public byte version {
            get { return mversion; }
            set { mversion = value; NotifyUpdated(); }
        }

        public byte rf_power {
            get { return mrf_power; }
            set { mrf_power = value; NotifyUpdated(); }
        }

        public byte rf_channel_spacing {
            get { return mrf_channel_spacing; }
            set { mrf_channel_spacing = value; NotifyUpdated(); }
        }

        public byte[] hopchannel {
            get { return mhopchannel; }
            set { mhopchannel = value; NotifyUpdated(); }
        }

        public byte modem_params {
            get { return mmodem_params; }
            set { mmodem_params = value; NotifyUpdated(); }
        }

        public byte flags {
            get { return mflags; }
            set { mflags = value; NotifyUpdated(); }
        }

        public byte beacon_delay {
            get { return mbeacon_delay; }
            set { mbeacon_delay = value; NotifyUpdated(); }
        }

        public byte beacon_period {
            get { return mbeacon_period; }
            set { mbeacon_period = value; NotifyUpdated(); }
        }

        public OpenLRS_RSSI_Type RSSI_Type {
            get { return mRSSI_Type; }
            set { mRSSI_Type = value; NotifyUpdated(); }
        }

        public OpenLRS()
        {
            IsSingleInstance = true;
            ObjectId = 0x44f8119a;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mserial_baudrate);
            s.Write(mrf_frequency);
            s.Write(mrf_magic);
            s.Write(mbeacon_frequency);
            s.Write(mfailsafe_delay);
            s.Write(mversion);
            s.Write(mrf_power);
            s.Write(mrf_channel_spacing);
            s.Write(mhopchannel[0]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[1]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[2]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[3]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[4]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[5]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[6]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[7]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[8]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[9]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[10]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[11]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[12]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[13]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[14]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[15]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[16]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[17]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[18]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[19]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[20]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[21]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[22]);  // NO_ELEMENT_NAME
            s.Write(mhopchannel[23]);  // NO_ELEMENT_NAME
            s.Write(mmodem_params);
            s.Write(mflags);
            s.Write(mbeacon_delay);
            s.Write(mbeacon_period);
            s.Write((byte)mRSSI_Type);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mserial_baudrate = stream.ReadUInt32();
            this.mrf_frequency = stream.ReadUInt32();
            this.mrf_magic = stream.ReadUInt32();
            this.mbeacon_frequency = stream.ReadUInt32();
            this.mfailsafe_delay = stream.ReadUInt32();
            this.mversion = stream.ReadByte();
            this.mrf_power = stream.ReadByte();
            this.mrf_channel_spacing = stream.ReadByte();
            this.mhopchannel[0] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[1] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[2] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[3] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[4] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[5] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[6] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[7] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[8] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[9] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[10] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[11] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[12] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[13] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[14] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[15] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[16] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[17] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[18] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[19] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[20] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[21] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[22] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mhopchannel[23] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mmodem_params = stream.ReadByte();
            this.mflags = stream.ReadByte();
            this.mbeacon_delay = stream.ReadByte();
            this.mbeacon_period = stream.ReadByte();
            this.mRSSI_Type = (OpenLRS_RSSI_Type)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("OpenLRS \n");
            sb.AppendFormat("    serial_baudrate: {0} \n", serial_baudrate);
            sb.AppendFormat("    rf_frequency: {0} \n", rf_frequency);
            sb.AppendFormat("    rf_magic: {0} \n", rf_magic);
            sb.AppendFormat("    beacon_frequency: {0} \n", beacon_frequency);
            sb.AppendFormat("    failsafe_delay: {0} ms\n", failsafe_delay);
            sb.AppendFormat("    version: {0} \n", version);
            sb.AppendFormat("    rf_power: {0} \n", rf_power);
            sb.AppendFormat("    rf_channel_spacing: {0} \n", rf_channel_spacing);
            sb.Append("    hopchannel\n");
            sb.AppendFormat("        : {0} \n", hopchannel[0]);
            sb.AppendFormat("        : {0} \n", hopchannel[1]);
            sb.AppendFormat("        : {0} \n", hopchannel[2]);
            sb.AppendFormat("        : {0} \n", hopchannel[3]);
            sb.AppendFormat("        : {0} \n", hopchannel[4]);
            sb.AppendFormat("        : {0} \n", hopchannel[5]);
            sb.AppendFormat("        : {0} \n", hopchannel[6]);
            sb.AppendFormat("        : {0} \n", hopchannel[7]);
            sb.AppendFormat("        : {0} \n", hopchannel[8]);
            sb.AppendFormat("        : {0} \n", hopchannel[9]);
            sb.AppendFormat("        : {0} \n", hopchannel[10]);
            sb.AppendFormat("        : {0} \n", hopchannel[11]);
            sb.AppendFormat("        : {0} \n", hopchannel[12]);
            sb.AppendFormat("        : {0} \n", hopchannel[13]);
            sb.AppendFormat("        : {0} \n", hopchannel[14]);
            sb.AppendFormat("        : {0} \n", hopchannel[15]);
            sb.AppendFormat("        : {0} \n", hopchannel[16]);
            sb.AppendFormat("        : {0} \n", hopchannel[17]);
            sb.AppendFormat("        : {0} \n", hopchannel[18]);
            sb.AppendFormat("        : {0} \n", hopchannel[19]);
            sb.AppendFormat("        : {0} \n", hopchannel[20]);
            sb.AppendFormat("        : {0} \n", hopchannel[21]);
            sb.AppendFormat("        : {0} \n", hopchannel[22]);
            sb.AppendFormat("        : {0} \n", hopchannel[23]);
            sb.AppendFormat("    modem_params: {0} \n", modem_params);
            sb.AppendFormat("    flags: {0} \n", flags);
            sb.AppendFormat("    beacon_delay: {0} s\n", beacon_delay);
            sb.AppendFormat("    beacon_period: {0} s\n", beacon_period);
            sb.AppendFormat("    RSSI_Type: {0} function\n", RSSI_Type);

            return sb.ToString();
        }

        private UInt32 mserial_baudrate = 0;
        private UInt32 mrf_frequency = 0;
        private UInt32 mrf_magic = 0;
        private UInt32 mbeacon_frequency = 462712500;
        private UInt32 mfailsafe_delay = 1000;
        private byte mversion = 0;
        private byte mrf_power = 0;
        private byte mrf_channel_spacing = 0;
        private byte[] mhopchannel = new byte[24] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private byte mmodem_params = 0;
        private byte mflags = 0;
        private byte mbeacon_delay = 30;
        private byte mbeacon_period = 15;
        private OpenLRS_RSSI_Type mRSSI_Type = OpenLRS_RSSI_Type.Combined;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum HwDiscoveryF4_MainPort { Disabled, Telemetry, DebugConsole };

    public enum HwDiscoveryF4_USB_HIDPort { USBTelemetry, RCTransmitter, Disabled };

    public enum HwDiscoveryF4_USB_VCPPort { USBTelemetry, ComBridge, DebugConsole, Disabled };

    public class HwDiscoveryF4: UavDataObject
    {
        public HwDiscoveryF4_MainPort MainPort {
            get { return mMainPort; }
            set { mMainPort = value; NotifyUpdated(); }
        }

        public HwDiscoveryF4_USB_HIDPort USB_HIDPort {
            get { return mUSB_HIDPort; }
            set { mUSB_HIDPort = value; NotifyUpdated(); }
        }

        public HwDiscoveryF4_USB_VCPPort USB_VCPPort {
            get { return mUSB_VCPPort; }
            set { mUSB_VCPPort = value; NotifyUpdated(); }
        }

        public HwDiscoveryF4()
        {
            IsSingleInstance = true;
            ObjectId = 0x416d89a8;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mMainPort);
            s.Write((byte)mUSB_HIDPort);
            s.Write((byte)mUSB_VCPPort);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mMainPort = (HwDiscoveryF4_MainPort)stream.ReadByte();
            this.mUSB_HIDPort = (HwDiscoveryF4_USB_HIDPort)stream.ReadByte();
            this.mUSB_VCPPort = (HwDiscoveryF4_USB_VCPPort)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("HwDiscoveryF4 \n");
            sb.AppendFormat("    MainPort: {0} function\n", MainPort);
            sb.AppendFormat("    USB_HIDPort: {0} function\n", USB_HIDPort);
            sb.AppendFormat("    USB_VCPPort: {0} function\n", USB_VCPPort);

            return sb.ToString();
        }

        private HwDiscoveryF4_MainPort mMainPort = HwDiscoveryF4_MainPort.DebugConsole;
        private HwDiscoveryF4_USB_HIDPort mUSB_HIDPort = HwDiscoveryF4_USB_HIDPort.USBTelemetry;
        private HwDiscoveryF4_USB_VCPPort mUSB_VCPPort = HwDiscoveryF4_USB_VCPPort.Disabled;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class RadioComBridgeStats: UavDataObject
    {
        public UInt32 TelemetryTxBytes {
            get { return mTelemetryTxBytes; }
            set { mTelemetryTxBytes = value; NotifyUpdated(); }
        }

        public UInt32 TelemetryTxFailures {
            get { return mTelemetryTxFailures; }
            set { mTelemetryTxFailures = value; NotifyUpdated(); }
        }

        public UInt32 TelemetryTxRetries {
            get { return mTelemetryTxRetries; }
            set { mTelemetryTxRetries = value; NotifyUpdated(); }
        }

        public UInt32 TelemetryRxBytes {
            get { return mTelemetryRxBytes; }
            set { mTelemetryRxBytes = value; NotifyUpdated(); }
        }

        public UInt32 TelemetryRxFailures {
            get { return mTelemetryRxFailures; }
            set { mTelemetryRxFailures = value; NotifyUpdated(); }
        }

        public UInt32 TelemetryRxSyncErrors {
            get { return mTelemetryRxSyncErrors; }
            set { mTelemetryRxSyncErrors = value; NotifyUpdated(); }
        }

        public UInt32 TelemetryRxCrcErrors {
            get { return mTelemetryRxCrcErrors; }
            set { mTelemetryRxCrcErrors = value; NotifyUpdated(); }
        }

        public UInt32 RadioTxBytes {
            get { return mRadioTxBytes; }
            set { mRadioTxBytes = value; NotifyUpdated(); }
        }

        public UInt32 RadioTxFailures {
            get { return mRadioTxFailures; }
            set { mRadioTxFailures = value; NotifyUpdated(); }
        }

        public UInt32 RadioTxRetries {
            get { return mRadioTxRetries; }
            set { mRadioTxRetries = value; NotifyUpdated(); }
        }

        public UInt32 RadioRxBytes {
            get { return mRadioRxBytes; }
            set { mRadioRxBytes = value; NotifyUpdated(); }
        }

        public UInt32 RadioRxFailures {
            get { return mRadioRxFailures; }
            set { mRadioRxFailures = value; NotifyUpdated(); }
        }

        public UInt32 RadioRxSyncErrors {
            get { return mRadioRxSyncErrors; }
            set { mRadioRxSyncErrors = value; NotifyUpdated(); }
        }

        public UInt32 RadioRxCrcErrors {
            get { return mRadioRxCrcErrors; }
            set { mRadioRxCrcErrors = value; NotifyUpdated(); }
        }

        public RadioComBridgeStats()
        {
            IsSingleInstance = true;
            ObjectId = 0x2499ae58;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mTelemetryTxBytes);
            s.Write(mTelemetryTxFailures);
            s.Write(mTelemetryTxRetries);
            s.Write(mTelemetryRxBytes);
            s.Write(mTelemetryRxFailures);
            s.Write(mTelemetryRxSyncErrors);
            s.Write(mTelemetryRxCrcErrors);
            s.Write(mRadioTxBytes);
            s.Write(mRadioTxFailures);
            s.Write(mRadioTxRetries);
            s.Write(mRadioRxBytes);
            s.Write(mRadioRxFailures);
            s.Write(mRadioRxSyncErrors);
            s.Write(mRadioRxCrcErrors);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mTelemetryTxBytes = stream.ReadUInt32();
            this.mTelemetryTxFailures = stream.ReadUInt32();
            this.mTelemetryTxRetries = stream.ReadUInt32();
            this.mTelemetryRxBytes = stream.ReadUInt32();
            this.mTelemetryRxFailures = stream.ReadUInt32();
            this.mTelemetryRxSyncErrors = stream.ReadUInt32();
            this.mTelemetryRxCrcErrors = stream.ReadUInt32();
            this.mRadioTxBytes = stream.ReadUInt32();
            this.mRadioTxFailures = stream.ReadUInt32();
            this.mRadioTxRetries = stream.ReadUInt32();
            this.mRadioRxBytes = stream.ReadUInt32();
            this.mRadioRxFailures = stream.ReadUInt32();
            this.mRadioRxSyncErrors = stream.ReadUInt32();
            this.mRadioRxCrcErrors = stream.ReadUInt32();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("RadioComBridgeStats \n");
            sb.AppendFormat("    TelemetryTxBytes: {0} bytes\n", TelemetryTxBytes);
            sb.AppendFormat("    TelemetryTxFailures: {0} count\n", TelemetryTxFailures);
            sb.AppendFormat("    TelemetryTxRetries: {0} count\n", TelemetryTxRetries);
            sb.AppendFormat("    TelemetryRxBytes: {0} bytes\n", TelemetryRxBytes);
            sb.AppendFormat("    TelemetryRxFailures: {0} count\n", TelemetryRxFailures);
            sb.AppendFormat("    TelemetryRxSyncErrors: {0} count\n", TelemetryRxSyncErrors);
            sb.AppendFormat("    TelemetryRxCrcErrors: {0} count\n", TelemetryRxCrcErrors);
            sb.AppendFormat("    RadioTxBytes: {0} bytes\n", RadioTxBytes);
            sb.AppendFormat("    RadioTxFailures: {0} count\n", RadioTxFailures);
            sb.AppendFormat("    RadioTxRetries: {0} count\n", RadioTxRetries);
            sb.AppendFormat("    RadioRxBytes: {0} bytes\n", RadioRxBytes);
            sb.AppendFormat("    RadioRxFailures: {0} count\n", RadioRxFailures);
            sb.AppendFormat("    RadioRxSyncErrors: {0} count\n", RadioRxSyncErrors);
            sb.AppendFormat("    RadioRxCrcErrors: {0} count\n", RadioRxCrcErrors);

            return sb.ToString();
        }

        private UInt32 mTelemetryTxBytes;
        private UInt32 mTelemetryTxFailures;
        private UInt32 mTelemetryTxRetries;
        private UInt32 mTelemetryRxBytes;
        private UInt32 mTelemetryRxFailures;
        private UInt32 mTelemetryRxSyncErrors;
        private UInt32 mTelemetryRxCrcErrors;
        private UInt32 mRadioTxBytes;
        private UInt32 mRadioTxFailures;
        private UInt32 mRadioTxRetries;
        private UInt32 mRadioRxBytes;
        private UInt32 mRadioRxFailures;
        private UInt32 mRadioRxSyncErrors;
        private UInt32 mRadioRxCrcErrors;
    }
}

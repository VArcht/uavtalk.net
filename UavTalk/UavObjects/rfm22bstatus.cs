using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum RFM22BStatus_LinkState { Disabled, Enabled, Disconnected, Connected };

    public class RFM22BStatus: UavDataObject
    {
        public UInt32 DeviceID {
            get { return mDeviceID; }
            set { mDeviceID = value; NotifyUpdated(); }
        }

        public UInt16 BoardRevision {
            get { return mBoardRevision; }
            set { mBoardRevision = value; NotifyUpdated(); }
        }

        public UInt16 HeapRemaining {
            get { return mHeapRemaining; }
            set { mHeapRemaining = value; NotifyUpdated(); }
        }

        public UInt16 TXRate {
            get { return mTXRate; }
            set { mTXRate = value; NotifyUpdated(); }
        }

        public UInt16 RXRate {
            get { return mRXRate; }
            set { mRXRate = value; NotifyUpdated(); }
        }

        public byte BoardType {
            get { return mBoardType; }
            set { mBoardType = value; NotifyUpdated(); }
        }

        public byte RxGood {
            get { return mRxGood; }
            set { mRxGood = value; NotifyUpdated(); }
        }

        public byte RxCorrected {
            get { return mRxCorrected; }
            set { mRxCorrected = value; NotifyUpdated(); }
        }

        public byte RxErrors {
            get { return mRxErrors; }
            set { mRxErrors = value; NotifyUpdated(); }
        }

        public byte RxSyncMissed {
            get { return mRxSyncMissed; }
            set { mRxSyncMissed = value; NotifyUpdated(); }
        }

        public byte TxMissed {
            get { return mTxMissed; }
            set { mTxMissed = value; NotifyUpdated(); }
        }

        public byte RxFailure {
            get { return mRxFailure; }
            set { mRxFailure = value; NotifyUpdated(); }
        }

        public byte Resets {
            get { return mResets; }
            set { mResets = value; NotifyUpdated(); }
        }

        public byte Timeouts {
            get { return mTimeouts; }
            set { mTimeouts = value; NotifyUpdated(); }
        }

        public SByte RSSI {
            get { return mRSSI; }
            set { mRSSI = value; NotifyUpdated(); }
        }

        public byte LinkQuality {
            get { return mLinkQuality; }
            set { mLinkQuality = value; NotifyUpdated(); }
        }

        public RFM22BStatus_LinkState LinkState {
            get { return mLinkState; }
            set { mLinkState = value; NotifyUpdated(); }
        }

        public RFM22BStatus()
        {
            IsSingleInstance = false;
            ObjectId = 0x2026fd3c;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mDeviceID);
            s.Write(mBoardRevision);
            s.Write(mHeapRemaining);
            s.Write(mTXRate);
            s.Write(mRXRate);
            s.Write(mBoardType);
            s.Write(mRxGood);
            s.Write(mRxCorrected);
            s.Write(mRxErrors);
            s.Write(mRxSyncMissed);
            s.Write(mTxMissed);
            s.Write(mRxFailure);
            s.Write(mResets);
            s.Write(mTimeouts);
            s.Write(mRSSI);
            s.Write(mLinkQuality);
            s.Write((byte)mLinkState);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mDeviceID = stream.ReadUInt32();
            this.mBoardRevision = stream.ReadUInt16();
            this.mHeapRemaining = stream.ReadUInt16();
            this.mTXRate = stream.ReadUInt16();
            this.mRXRate = stream.ReadUInt16();
            this.mBoardType = stream.ReadByte();
            this.mRxGood = stream.ReadByte();
            this.mRxCorrected = stream.ReadByte();
            this.mRxErrors = stream.ReadByte();
            this.mRxSyncMissed = stream.ReadByte();
            this.mTxMissed = stream.ReadByte();
            this.mRxFailure = stream.ReadByte();
            this.mResets = stream.ReadByte();
            this.mTimeouts = stream.ReadByte();
            this.mRSSI = stream.ReadSByte();
            this.mLinkQuality = stream.ReadByte();
            this.mLinkState = (RFM22BStatus_LinkState)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("RFM22BStatus \n");
            sb.AppendFormat("    DeviceID: {0} hex\n", DeviceID);
            sb.AppendFormat("    BoardRevision: {0} \n", BoardRevision);
            sb.AppendFormat("    HeapRemaining: {0} bytes\n", HeapRemaining);
            sb.AppendFormat("    TXRate: {0} Bps\n", TXRate);
            sb.AppendFormat("    RXRate: {0} Bps\n", RXRate);
            sb.AppendFormat("    BoardType: {0} \n", BoardType);
            sb.AppendFormat("    RxGood: {0} %\n", RxGood);
            sb.AppendFormat("    RxCorrected: {0} %\n", RxCorrected);
            sb.AppendFormat("    RxErrors: {0} %\n", RxErrors);
            sb.AppendFormat("    RxSyncMissed: {0} %\n", RxSyncMissed);
            sb.AppendFormat("    TxMissed: {0} %\n", TxMissed);
            sb.AppendFormat("    RxFailure: {0} %\n", RxFailure);
            sb.AppendFormat("    Resets: {0} \n", Resets);
            sb.AppendFormat("    Timeouts: {0} \n", Timeouts);
            sb.AppendFormat("    RSSI: {0} dBm\n", RSSI);
            sb.AppendFormat("    LinkQuality: {0} \n", LinkQuality);
            sb.AppendFormat("    LinkState: {0} function\n", LinkState);

            return sb.ToString();
        }

        private UInt32 mDeviceID = 0;
        private UInt16 mBoardRevision;
        private UInt16 mHeapRemaining;
        private UInt16 mTXRate = 0;
        private UInt16 mRXRate = 0;
        private byte mBoardType;
        private byte mRxGood = 0;
        private byte mRxCorrected = 0;
        private byte mRxErrors = 0;
        private byte mRxSyncMissed = 0;
        private byte mTxMissed = 0;
        private byte mRxFailure = 0;
        private byte mResets = 0;
        private byte mTimeouts = 0;
        private SByte mRSSI = 0;
        private byte mLinkQuality = 0;
        private RFM22BStatus_LinkState mLinkState = RFM22BStatus_LinkState.Disabled;
    }
}

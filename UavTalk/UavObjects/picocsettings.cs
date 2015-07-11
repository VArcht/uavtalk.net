using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum PicoCSettings_Startup { Disabled, OnBoot, WhenArmed };

    public enum PicoCSettings_Source { Disabled, Demo, Interactive, File };

    public enum PicoCSettings_ComSpeed { _2400, _4800, _9600, _19200, _38400, _57600, _115200 };

    public class PicoCSettings: UavDataObject
    {
        public UInt32 MaxFileSize {
            get { return mMaxFileSize; }
            set { mMaxFileSize = value; NotifyUpdated(); }
        }

        public UInt32 TaskStackSize {
            get { return mTaskStackSize; }
            set { mTaskStackSize = value; NotifyUpdated(); }
        }

        public UInt32 PicoCStackSize {
            get { return mPicoCStackSize; }
            set { mPicoCStackSize = value; NotifyUpdated(); }
        }

        public byte BootFileID {
            get { return mBootFileID; }
            set { mBootFileID = value; NotifyUpdated(); }
        }

        public PicoCSettings_Startup Startup {
            get { return mStartup; }
            set { mStartup = value; NotifyUpdated(); }
        }

        public PicoCSettings_Source Source {
            get { return mSource; }
            set { mSource = value; NotifyUpdated(); }
        }

        public PicoCSettings_ComSpeed ComSpeed {
            get { return mComSpeed; }
            set { mComSpeed = value; NotifyUpdated(); }
        }

        public PicoCSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x5db16ffe;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mMaxFileSize);
            s.Write(mTaskStackSize);
            s.Write(mPicoCStackSize);
            s.Write(mBootFileID);
            s.Write((byte)mStartup);
            s.Write((byte)mSource);
            s.Write((byte)mComSpeed);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mMaxFileSize = stream.ReadUInt32();
            this.mTaskStackSize = stream.ReadUInt32();
            this.mPicoCStackSize = stream.ReadUInt32();
            this.mBootFileID = stream.ReadByte();
            this.mStartup = (PicoCSettings_Startup)stream.ReadByte();
            this.mSource = (PicoCSettings_Source)stream.ReadByte();
            this.mComSpeed = (PicoCSettings_ComSpeed)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("PicoCSettings \n");
            sb.AppendFormat("    MaxFileSize: {0} bytes [be careful!]\n", MaxFileSize);
            sb.AppendFormat("    TaskStackSize: {0} bytes [be careful!]\n", TaskStackSize);
            sb.AppendFormat("    PicoCStackSize: {0} bytes [be careful!]\n", PicoCStackSize);
            sb.AppendFormat("    BootFileID: {0} \n", BootFileID);
            sb.AppendFormat("    Startup: {0} \n", Startup);
            sb.AppendFormat("    Source: {0} \n", Source);
            sb.AppendFormat("    ComSpeed: {0} bps\n", ComSpeed);

            return sb.ToString();
        }

        private UInt32 mMaxFileSize = 2048;
        private UInt32 mTaskStackSize = 16384;
        private UInt32 mPicoCStackSize = 16384;
        private byte mBootFileID = 0;
        private PicoCSettings_Startup mStartup = PicoCSettings_Startup.Disabled;
        private PicoCSettings_Source mSource = PicoCSettings_Source.Disabled;
        private PicoCSettings_ComSpeed mComSpeed = PicoCSettings_ComSpeed._115200;
    }
}

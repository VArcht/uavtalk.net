using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum PicoCStatus_Command { Idle, StartScript, USARTmode, GetSector, SetSector, LoadFile, SaveFile, DeleteFile, FormatPartition };

    public class PicoCStatus: UavDataObject
    {
        public Int16 ExitValue {
            get { return mExitValue; }
            set { mExitValue = value; NotifyUpdated(); }
        }

        public Int16 TestValue {
            get { return mTestValue; }
            set { mTestValue = value; NotifyUpdated(); }
        }

        public UInt16 SectorID {
            get { return mSectorID; }
            set { mSectorID = value; NotifyUpdated(); }
        }

        public byte FileID {
            get { return mFileID; }
            set { mFileID = value; NotifyUpdated(); }
        }

        public PicoCStatus_Command Command {
            get { return mCommand; }
            set { mCommand = value; NotifyUpdated(); }
        }

        public SByte CommandError {
            get { return mCommandError; }
            set { mCommandError = value; NotifyUpdated(); }
        }

        public byte[] Sector {
            get { return mSector; }
            set { mSector = value; NotifyUpdated(); }
        }

        public PicoCStatus()
        {
            IsSingleInstance = true;
            ObjectId = 0xf132538a;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mExitValue);
            s.Write(mTestValue);
            s.Write(mSectorID);
            s.Write(mFileID);
            s.Write((byte)mCommand);
            s.Write(mCommandError);
            s.Write(mSector[0]);  // NO_ELEMENT_NAME
            s.Write(mSector[1]);  // NO_ELEMENT_NAME
            s.Write(mSector[2]);  // NO_ELEMENT_NAME
            s.Write(mSector[3]);  // NO_ELEMENT_NAME
            s.Write(mSector[4]);  // NO_ELEMENT_NAME
            s.Write(mSector[5]);  // NO_ELEMENT_NAME
            s.Write(mSector[6]);  // NO_ELEMENT_NAME
            s.Write(mSector[7]);  // NO_ELEMENT_NAME
            s.Write(mSector[8]);  // NO_ELEMENT_NAME
            s.Write(mSector[9]);  // NO_ELEMENT_NAME
            s.Write(mSector[10]);  // NO_ELEMENT_NAME
            s.Write(mSector[11]);  // NO_ELEMENT_NAME
            s.Write(mSector[12]);  // NO_ELEMENT_NAME
            s.Write(mSector[13]);  // NO_ELEMENT_NAME
            s.Write(mSector[14]);  // NO_ELEMENT_NAME
            s.Write(mSector[15]);  // NO_ELEMENT_NAME
            s.Write(mSector[16]);  // NO_ELEMENT_NAME
            s.Write(mSector[17]);  // NO_ELEMENT_NAME
            s.Write(mSector[18]);  // NO_ELEMENT_NAME
            s.Write(mSector[19]);  // NO_ELEMENT_NAME
            s.Write(mSector[20]);  // NO_ELEMENT_NAME
            s.Write(mSector[21]);  // NO_ELEMENT_NAME
            s.Write(mSector[22]);  // NO_ELEMENT_NAME
            s.Write(mSector[23]);  // NO_ELEMENT_NAME
            s.Write(mSector[24]);  // NO_ELEMENT_NAME
            s.Write(mSector[25]);  // NO_ELEMENT_NAME
            s.Write(mSector[26]);  // NO_ELEMENT_NAME
            s.Write(mSector[27]);  // NO_ELEMENT_NAME
            s.Write(mSector[28]);  // NO_ELEMENT_NAME
            s.Write(mSector[29]);  // NO_ELEMENT_NAME
            s.Write(mSector[30]);  // NO_ELEMENT_NAME
            s.Write(mSector[31]);  // NO_ELEMENT_NAME
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mExitValue = stream.ReadInt16();
            this.mTestValue = stream.ReadInt16();
            this.mSectorID = stream.ReadUInt16();
            this.mFileID = stream.ReadByte();
            this.mCommand = (PicoCStatus_Command)stream.ReadByte();
            this.mCommandError = stream.ReadSByte();
            this.mSector[0] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[1] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[2] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[3] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[4] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[5] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[6] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[7] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[8] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[9] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[10] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[11] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[12] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[13] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[14] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[15] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[16] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[17] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[18] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[19] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[20] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[21] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[22] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[23] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[24] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[25] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[26] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[27] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[28] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[29] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[30] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mSector[31] = stream.ReadByte();  // NO_ELEMENT_NAME
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("PicoCStatus \n");
            sb.AppendFormat("    ExitValue: {0} \n", ExitValue);
            sb.AppendFormat("    TestValue: {0} \n", TestValue);
            sb.AppendFormat("    SectorID: {0} \n", SectorID);
            sb.AppendFormat("    FileID: {0} \n", FileID);
            sb.AppendFormat("    Command: {0} \n", Command);
            sb.AppendFormat("    CommandError: {0} \n", CommandError);
            sb.Append("    Sector\n");
            sb.AppendFormat("        : {0} \n", Sector[0]);
            sb.AppendFormat("        : {0} \n", Sector[1]);
            sb.AppendFormat("        : {0} \n", Sector[2]);
            sb.AppendFormat("        : {0} \n", Sector[3]);
            sb.AppendFormat("        : {0} \n", Sector[4]);
            sb.AppendFormat("        : {0} \n", Sector[5]);
            sb.AppendFormat("        : {0} \n", Sector[6]);
            sb.AppendFormat("        : {0} \n", Sector[7]);
            sb.AppendFormat("        : {0} \n", Sector[8]);
            sb.AppendFormat("        : {0} \n", Sector[9]);
            sb.AppendFormat("        : {0} \n", Sector[10]);
            sb.AppendFormat("        : {0} \n", Sector[11]);
            sb.AppendFormat("        : {0} \n", Sector[12]);
            sb.AppendFormat("        : {0} \n", Sector[13]);
            sb.AppendFormat("        : {0} \n", Sector[14]);
            sb.AppendFormat("        : {0} \n", Sector[15]);
            sb.AppendFormat("        : {0} \n", Sector[16]);
            sb.AppendFormat("        : {0} \n", Sector[17]);
            sb.AppendFormat("        : {0} \n", Sector[18]);
            sb.AppendFormat("        : {0} \n", Sector[19]);
            sb.AppendFormat("        : {0} \n", Sector[20]);
            sb.AppendFormat("        : {0} \n", Sector[21]);
            sb.AppendFormat("        : {0} \n", Sector[22]);
            sb.AppendFormat("        : {0} \n", Sector[23]);
            sb.AppendFormat("        : {0} \n", Sector[24]);
            sb.AppendFormat("        : {0} \n", Sector[25]);
            sb.AppendFormat("        : {0} \n", Sector[26]);
            sb.AppendFormat("        : {0} \n", Sector[27]);
            sb.AppendFormat("        : {0} \n", Sector[28]);
            sb.AppendFormat("        : {0} \n", Sector[29]);
            sb.AppendFormat("        : {0} \n", Sector[30]);
            sb.AppendFormat("        : {0} \n", Sector[31]);

            return sb.ToString();
        }

        private Int16 mExitValue = 0;
        private Int16 mTestValue = 0;
        private UInt16 mSectorID = 0;
        private byte mFileID = 0;
        private PicoCStatus_Command mCommand = PicoCStatus_Command.Idle;
        private SByte mCommandError = 0;
        private byte[] mSector = new byte[32] ;
    }
}

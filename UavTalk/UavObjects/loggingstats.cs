using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum LoggingStats_Operation { LOGGING, IDLE, DOWNLOAD, COMPLETE, ERROR };

    public class LoggingStats: UavDataObject
    {
        public UInt32 BytesLogged {
            get { return mBytesLogged; }
            set { mBytesLogged = value; NotifyUpdated(); }
        }

        public UInt16 MinFileId {
            get { return mMinFileId; }
            set { mMinFileId = value; NotifyUpdated(); }
        }

        public UInt16 MaxFileId {
            get { return mMaxFileId; }
            set { mMaxFileId = value; NotifyUpdated(); }
        }

        public UInt16 FileRequest {
            get { return mFileRequest; }
            set { mFileRequest = value; NotifyUpdated(); }
        }

        public UInt16 FileSectorNum {
            get { return mFileSectorNum; }
            set { mFileSectorNum = value; NotifyUpdated(); }
        }

        public LoggingStats_Operation Operation {
            get { return mOperation; }
            set { mOperation = value; NotifyUpdated(); }
        }

        public byte[] FileSector {
            get { return mFileSector; }
            set { mFileSector = value; NotifyUpdated(); }
        }

        public LoggingStats()
        {
            IsSingleInstance = true;
            ObjectId = 0x2360880e;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mBytesLogged);
            s.Write(mMinFileId);
            s.Write(mMaxFileId);
            s.Write(mFileRequest);
            s.Write(mFileSectorNum);
            s.Write((byte)mOperation);
            s.Write(mFileSector[0]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[1]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[2]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[3]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[4]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[5]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[6]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[7]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[8]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[9]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[10]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[11]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[12]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[13]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[14]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[15]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[16]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[17]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[18]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[19]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[20]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[21]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[22]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[23]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[24]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[25]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[26]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[27]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[28]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[29]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[30]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[31]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[32]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[33]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[34]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[35]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[36]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[37]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[38]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[39]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[40]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[41]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[42]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[43]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[44]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[45]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[46]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[47]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[48]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[49]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[50]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[51]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[52]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[53]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[54]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[55]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[56]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[57]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[58]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[59]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[60]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[61]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[62]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[63]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[64]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[65]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[66]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[67]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[68]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[69]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[70]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[71]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[72]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[73]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[74]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[75]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[76]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[77]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[78]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[79]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[80]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[81]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[82]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[83]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[84]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[85]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[86]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[87]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[88]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[89]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[90]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[91]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[92]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[93]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[94]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[95]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[96]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[97]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[98]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[99]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[100]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[101]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[102]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[103]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[104]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[105]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[106]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[107]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[108]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[109]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[110]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[111]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[112]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[113]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[114]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[115]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[116]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[117]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[118]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[119]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[120]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[121]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[122]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[123]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[124]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[125]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[126]);  // NO_ELEMENT_NAME
            s.Write(mFileSector[127]);  // NO_ELEMENT_NAME
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mBytesLogged = stream.ReadUInt32();
            this.mMinFileId = stream.ReadUInt16();
            this.mMaxFileId = stream.ReadUInt16();
            this.mFileRequest = stream.ReadUInt16();
            this.mFileSectorNum = stream.ReadUInt16();
            this.mOperation = (LoggingStats_Operation)stream.ReadByte();
            this.mFileSector[0] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[1] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[2] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[3] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[4] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[5] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[6] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[7] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[8] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[9] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[10] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[11] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[12] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[13] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[14] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[15] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[16] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[17] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[18] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[19] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[20] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[21] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[22] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[23] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[24] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[25] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[26] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[27] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[28] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[29] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[30] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[31] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[32] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[33] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[34] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[35] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[36] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[37] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[38] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[39] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[40] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[41] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[42] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[43] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[44] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[45] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[46] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[47] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[48] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[49] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[50] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[51] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[52] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[53] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[54] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[55] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[56] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[57] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[58] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[59] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[60] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[61] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[62] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[63] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[64] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[65] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[66] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[67] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[68] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[69] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[70] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[71] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[72] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[73] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[74] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[75] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[76] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[77] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[78] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[79] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[80] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[81] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[82] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[83] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[84] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[85] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[86] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[87] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[88] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[89] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[90] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[91] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[92] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[93] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[94] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[95] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[96] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[97] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[98] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[99] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[100] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[101] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[102] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[103] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[104] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[105] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[106] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[107] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[108] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[109] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[110] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[111] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[112] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[113] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[114] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[115] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[116] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[117] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[118] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[119] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[120] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[121] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[122] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[123] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[124] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[125] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[126] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mFileSector[127] = stream.ReadByte();  // NO_ELEMENT_NAME
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("LoggingStats \n");
            sb.AppendFormat("    BytesLogged: {0} bytes\n", BytesLogged);
            sb.AppendFormat("    MinFileId: {0} \n", MinFileId);
            sb.AppendFormat("    MaxFileId: {0} \n", MaxFileId);
            sb.AppendFormat("    FileRequest: {0} \n", FileRequest);
            sb.AppendFormat("    FileSectorNum: {0} \n", FileSectorNum);
            sb.AppendFormat("    Operation: {0} \n", Operation);
            sb.Append("    FileSector\n");
            sb.AppendFormat("        : {0} \n", FileSector[0]);
            sb.AppendFormat("        : {0} \n", FileSector[1]);
            sb.AppendFormat("        : {0} \n", FileSector[2]);
            sb.AppendFormat("        : {0} \n", FileSector[3]);
            sb.AppendFormat("        : {0} \n", FileSector[4]);
            sb.AppendFormat("        : {0} \n", FileSector[5]);
            sb.AppendFormat("        : {0} \n", FileSector[6]);
            sb.AppendFormat("        : {0} \n", FileSector[7]);
            sb.AppendFormat("        : {0} \n", FileSector[8]);
            sb.AppendFormat("        : {0} \n", FileSector[9]);
            sb.AppendFormat("        : {0} \n", FileSector[10]);
            sb.AppendFormat("        : {0} \n", FileSector[11]);
            sb.AppendFormat("        : {0} \n", FileSector[12]);
            sb.AppendFormat("        : {0} \n", FileSector[13]);
            sb.AppendFormat("        : {0} \n", FileSector[14]);
            sb.AppendFormat("        : {0} \n", FileSector[15]);
            sb.AppendFormat("        : {0} \n", FileSector[16]);
            sb.AppendFormat("        : {0} \n", FileSector[17]);
            sb.AppendFormat("        : {0} \n", FileSector[18]);
            sb.AppendFormat("        : {0} \n", FileSector[19]);
            sb.AppendFormat("        : {0} \n", FileSector[20]);
            sb.AppendFormat("        : {0} \n", FileSector[21]);
            sb.AppendFormat("        : {0} \n", FileSector[22]);
            sb.AppendFormat("        : {0} \n", FileSector[23]);
            sb.AppendFormat("        : {0} \n", FileSector[24]);
            sb.AppendFormat("        : {0} \n", FileSector[25]);
            sb.AppendFormat("        : {0} \n", FileSector[26]);
            sb.AppendFormat("        : {0} \n", FileSector[27]);
            sb.AppendFormat("        : {0} \n", FileSector[28]);
            sb.AppendFormat("        : {0} \n", FileSector[29]);
            sb.AppendFormat("        : {0} \n", FileSector[30]);
            sb.AppendFormat("        : {0} \n", FileSector[31]);
            sb.AppendFormat("        : {0} \n", FileSector[32]);
            sb.AppendFormat("        : {0} \n", FileSector[33]);
            sb.AppendFormat("        : {0} \n", FileSector[34]);
            sb.AppendFormat("        : {0} \n", FileSector[35]);
            sb.AppendFormat("        : {0} \n", FileSector[36]);
            sb.AppendFormat("        : {0} \n", FileSector[37]);
            sb.AppendFormat("        : {0} \n", FileSector[38]);
            sb.AppendFormat("        : {0} \n", FileSector[39]);
            sb.AppendFormat("        : {0} \n", FileSector[40]);
            sb.AppendFormat("        : {0} \n", FileSector[41]);
            sb.AppendFormat("        : {0} \n", FileSector[42]);
            sb.AppendFormat("        : {0} \n", FileSector[43]);
            sb.AppendFormat("        : {0} \n", FileSector[44]);
            sb.AppendFormat("        : {0} \n", FileSector[45]);
            sb.AppendFormat("        : {0} \n", FileSector[46]);
            sb.AppendFormat("        : {0} \n", FileSector[47]);
            sb.AppendFormat("        : {0} \n", FileSector[48]);
            sb.AppendFormat("        : {0} \n", FileSector[49]);
            sb.AppendFormat("        : {0} \n", FileSector[50]);
            sb.AppendFormat("        : {0} \n", FileSector[51]);
            sb.AppendFormat("        : {0} \n", FileSector[52]);
            sb.AppendFormat("        : {0} \n", FileSector[53]);
            sb.AppendFormat("        : {0} \n", FileSector[54]);
            sb.AppendFormat("        : {0} \n", FileSector[55]);
            sb.AppendFormat("        : {0} \n", FileSector[56]);
            sb.AppendFormat("        : {0} \n", FileSector[57]);
            sb.AppendFormat("        : {0} \n", FileSector[58]);
            sb.AppendFormat("        : {0} \n", FileSector[59]);
            sb.AppendFormat("        : {0} \n", FileSector[60]);
            sb.AppendFormat("        : {0} \n", FileSector[61]);
            sb.AppendFormat("        : {0} \n", FileSector[62]);
            sb.AppendFormat("        : {0} \n", FileSector[63]);
            sb.AppendFormat("        : {0} \n", FileSector[64]);
            sb.AppendFormat("        : {0} \n", FileSector[65]);
            sb.AppendFormat("        : {0} \n", FileSector[66]);
            sb.AppendFormat("        : {0} \n", FileSector[67]);
            sb.AppendFormat("        : {0} \n", FileSector[68]);
            sb.AppendFormat("        : {0} \n", FileSector[69]);
            sb.AppendFormat("        : {0} \n", FileSector[70]);
            sb.AppendFormat("        : {0} \n", FileSector[71]);
            sb.AppendFormat("        : {0} \n", FileSector[72]);
            sb.AppendFormat("        : {0} \n", FileSector[73]);
            sb.AppendFormat("        : {0} \n", FileSector[74]);
            sb.AppendFormat("        : {0} \n", FileSector[75]);
            sb.AppendFormat("        : {0} \n", FileSector[76]);
            sb.AppendFormat("        : {0} \n", FileSector[77]);
            sb.AppendFormat("        : {0} \n", FileSector[78]);
            sb.AppendFormat("        : {0} \n", FileSector[79]);
            sb.AppendFormat("        : {0} \n", FileSector[80]);
            sb.AppendFormat("        : {0} \n", FileSector[81]);
            sb.AppendFormat("        : {0} \n", FileSector[82]);
            sb.AppendFormat("        : {0} \n", FileSector[83]);
            sb.AppendFormat("        : {0} \n", FileSector[84]);
            sb.AppendFormat("        : {0} \n", FileSector[85]);
            sb.AppendFormat("        : {0} \n", FileSector[86]);
            sb.AppendFormat("        : {0} \n", FileSector[87]);
            sb.AppendFormat("        : {0} \n", FileSector[88]);
            sb.AppendFormat("        : {0} \n", FileSector[89]);
            sb.AppendFormat("        : {0} \n", FileSector[90]);
            sb.AppendFormat("        : {0} \n", FileSector[91]);
            sb.AppendFormat("        : {0} \n", FileSector[92]);
            sb.AppendFormat("        : {0} \n", FileSector[93]);
            sb.AppendFormat("        : {0} \n", FileSector[94]);
            sb.AppendFormat("        : {0} \n", FileSector[95]);
            sb.AppendFormat("        : {0} \n", FileSector[96]);
            sb.AppendFormat("        : {0} \n", FileSector[97]);
            sb.AppendFormat("        : {0} \n", FileSector[98]);
            sb.AppendFormat("        : {0} \n", FileSector[99]);
            sb.AppendFormat("        : {0} \n", FileSector[100]);
            sb.AppendFormat("        : {0} \n", FileSector[101]);
            sb.AppendFormat("        : {0} \n", FileSector[102]);
            sb.AppendFormat("        : {0} \n", FileSector[103]);
            sb.AppendFormat("        : {0} \n", FileSector[104]);
            sb.AppendFormat("        : {0} \n", FileSector[105]);
            sb.AppendFormat("        : {0} \n", FileSector[106]);
            sb.AppendFormat("        : {0} \n", FileSector[107]);
            sb.AppendFormat("        : {0} \n", FileSector[108]);
            sb.AppendFormat("        : {0} \n", FileSector[109]);
            sb.AppendFormat("        : {0} \n", FileSector[110]);
            sb.AppendFormat("        : {0} \n", FileSector[111]);
            sb.AppendFormat("        : {0} \n", FileSector[112]);
            sb.AppendFormat("        : {0} \n", FileSector[113]);
            sb.AppendFormat("        : {0} \n", FileSector[114]);
            sb.AppendFormat("        : {0} \n", FileSector[115]);
            sb.AppendFormat("        : {0} \n", FileSector[116]);
            sb.AppendFormat("        : {0} \n", FileSector[117]);
            sb.AppendFormat("        : {0} \n", FileSector[118]);
            sb.AppendFormat("        : {0} \n", FileSector[119]);
            sb.AppendFormat("        : {0} \n", FileSector[120]);
            sb.AppendFormat("        : {0} \n", FileSector[121]);
            sb.AppendFormat("        : {0} \n", FileSector[122]);
            sb.AppendFormat("        : {0} \n", FileSector[123]);
            sb.AppendFormat("        : {0} \n", FileSector[124]);
            sb.AppendFormat("        : {0} \n", FileSector[125]);
            sb.AppendFormat("        : {0} \n", FileSector[126]);
            sb.AppendFormat("        : {0} \n", FileSector[127]);

            return sb.ToString();
        }

        private UInt32 mBytesLogged;
        private UInt16 mMinFileId;
        private UInt16 mMaxFileId;
        private UInt16 mFileRequest;
        private UInt16 mFileSectorNum;
        private LoggingStats_Operation mOperation;
        private byte[] mFileSector = new byte[128] ;
    }
}

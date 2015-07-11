using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class I2CVMUserProgram: UavDataObject
    {
        public UInt32[] Program {
            get { return mProgram; }
            set { mProgram = value; NotifyUpdated(); }
        }

        public I2CVMUserProgram()
        {
            IsSingleInstance = true;
            ObjectId = 0xed9cc1ac;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mProgram[0]);  // NO_ELEMENT_NAME
            s.Write(mProgram[1]);  // NO_ELEMENT_NAME
            s.Write(mProgram[2]);  // NO_ELEMENT_NAME
            s.Write(mProgram[3]);  // NO_ELEMENT_NAME
            s.Write(mProgram[4]);  // NO_ELEMENT_NAME
            s.Write(mProgram[5]);  // NO_ELEMENT_NAME
            s.Write(mProgram[6]);  // NO_ELEMENT_NAME
            s.Write(mProgram[7]);  // NO_ELEMENT_NAME
            s.Write(mProgram[8]);  // NO_ELEMENT_NAME
            s.Write(mProgram[9]);  // NO_ELEMENT_NAME
            s.Write(mProgram[10]);  // NO_ELEMENT_NAME
            s.Write(mProgram[11]);  // NO_ELEMENT_NAME
            s.Write(mProgram[12]);  // NO_ELEMENT_NAME
            s.Write(mProgram[13]);  // NO_ELEMENT_NAME
            s.Write(mProgram[14]);  // NO_ELEMENT_NAME
            s.Write(mProgram[15]);  // NO_ELEMENT_NAME
            s.Write(mProgram[16]);  // NO_ELEMENT_NAME
            s.Write(mProgram[17]);  // NO_ELEMENT_NAME
            s.Write(mProgram[18]);  // NO_ELEMENT_NAME
            s.Write(mProgram[19]);  // NO_ELEMENT_NAME
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mProgram[0] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[1] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[2] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[3] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[4] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[5] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[6] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[7] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[8] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[9] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[10] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[11] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[12] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[13] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[14] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[15] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[16] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[17] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[18] = stream.ReadUInt32();  // NO_ELEMENT_NAME
            this.mProgram[19] = stream.ReadUInt32();  // NO_ELEMENT_NAME
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("I2CVMUserProgram \n");
            sb.Append("    Program\n");
            sb.AppendFormat("        : {0} \n", Program[0]);
            sb.AppendFormat("        : {0} \n", Program[1]);
            sb.AppendFormat("        : {0} \n", Program[2]);
            sb.AppendFormat("        : {0} \n", Program[3]);
            sb.AppendFormat("        : {0} \n", Program[4]);
            sb.AppendFormat("        : {0} \n", Program[5]);
            sb.AppendFormat("        : {0} \n", Program[6]);
            sb.AppendFormat("        : {0} \n", Program[7]);
            sb.AppendFormat("        : {0} \n", Program[8]);
            sb.AppendFormat("        : {0} \n", Program[9]);
            sb.AppendFormat("        : {0} \n", Program[10]);
            sb.AppendFormat("        : {0} \n", Program[11]);
            sb.AppendFormat("        : {0} \n", Program[12]);
            sb.AppendFormat("        : {0} \n", Program[13]);
            sb.AppendFormat("        : {0} \n", Program[14]);
            sb.AppendFormat("        : {0} \n", Program[15]);
            sb.AppendFormat("        : {0} \n", Program[16]);
            sb.AppendFormat("        : {0} \n", Program[17]);
            sb.AppendFormat("        : {0} \n", Program[18]);
            sb.AppendFormat("        : {0} \n", Program[19]);

            return sb.ToString();
        }

        private UInt32[] mProgram = new UInt32[20] { 134676490,  84541440,  84607232,  84673024,  84738816,  117441025,  117441282,  117441539,  100663812,  100664069,  100664326,  385875968,  168296447,  33554452,  50855927, 0, 0, 0, 0, 0 };
    }
}

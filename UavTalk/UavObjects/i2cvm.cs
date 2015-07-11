using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class I2CVM: UavDataObject
    {
        public Int32 r0 {
            get { return mr0; }
            set { mr0 = value; NotifyUpdated(); }
        }

        public Int32 r1 {
            get { return mr1; }
            set { mr1 = value; NotifyUpdated(); }
        }

        public Int32 r2 {
            get { return mr2; }
            set { mr2 = value; NotifyUpdated(); }
        }

        public Int32 r3 {
            get { return mr3; }
            set { mr3 = value; NotifyUpdated(); }
        }

        public Int32 r4 {
            get { return mr4; }
            set { mr4 = value; NotifyUpdated(); }
        }

        public Int32 r5 {
            get { return mr5; }
            set { mr5 = value; NotifyUpdated(); }
        }

        public Int32 r6 {
            get { return mr6; }
            set { mr6 = value; NotifyUpdated(); }
        }

        public UInt16 pc {
            get { return mpc; }
            set { mpc = value; NotifyUpdated(); }
        }

        public byte[] ram {
            get { return mram; }
            set { mram = value; NotifyUpdated(); }
        }

        public I2CVM()
        {
            IsSingleInstance = true;
            ObjectId = 0x2a6a5146;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mr0);
            s.Write(mr1);
            s.Write(mr2);
            s.Write(mr3);
            s.Write(mr4);
            s.Write(mr5);
            s.Write(mr6);
            s.Write(mpc);
            s.Write(mram[0]);  // NO_ELEMENT_NAME
            s.Write(mram[1]);  // NO_ELEMENT_NAME
            s.Write(mram[2]);  // NO_ELEMENT_NAME
            s.Write(mram[3]);  // NO_ELEMENT_NAME
            s.Write(mram[4]);  // NO_ELEMENT_NAME
            s.Write(mram[5]);  // NO_ELEMENT_NAME
            s.Write(mram[6]);  // NO_ELEMENT_NAME
            s.Write(mram[7]);  // NO_ELEMENT_NAME
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mr0 = stream.ReadInt32();
            this.mr1 = stream.ReadInt32();
            this.mr2 = stream.ReadInt32();
            this.mr3 = stream.ReadInt32();
            this.mr4 = stream.ReadInt32();
            this.mr5 = stream.ReadInt32();
            this.mr6 = stream.ReadInt32();
            this.mpc = stream.ReadUInt16();
            this.mram[0] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[1] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[2] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[3] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[4] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[5] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[6] = stream.ReadByte();  // NO_ELEMENT_NAME
            this.mram[7] = stream.ReadByte();  // NO_ELEMENT_NAME
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("I2CVM \n");
            sb.AppendFormat("    r0: {0} \n", r0);
            sb.AppendFormat("    r1: {0} \n", r1);
            sb.AppendFormat("    r2: {0} \n", r2);
            sb.AppendFormat("    r3: {0} \n", r3);
            sb.AppendFormat("    r4: {0} \n", r4);
            sb.AppendFormat("    r5: {0} \n", r5);
            sb.AppendFormat("    r6: {0} \n", r6);
            sb.AppendFormat("    pc: {0} \n", pc);
            sb.Append("    ram\n");
            sb.AppendFormat("        : {0} \n", ram[0]);
            sb.AppendFormat("        : {0} \n", ram[1]);
            sb.AppendFormat("        : {0} \n", ram[2]);
            sb.AppendFormat("        : {0} \n", ram[3]);
            sb.AppendFormat("        : {0} \n", ram[4]);
            sb.AppendFormat("        : {0} \n", ram[5]);
            sb.AppendFormat("        : {0} \n", ram[6]);
            sb.AppendFormat("        : {0} \n", ram[7]);

            return sb.ToString();
        }

        private Int32 mr0;
        private Int32 mr1;
        private Int32 mr2;
        private Int32 mr3;
        private Int32 mr4;
        private Int32 mr5;
        private Int32 mr6;
        private UInt16 mpc;
        private byte[] mram = new byte[8] ;
    }
}

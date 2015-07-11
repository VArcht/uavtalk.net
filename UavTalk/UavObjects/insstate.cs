using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class INSState: UavDataObject
    {
        public float[] State {
            get { return mState; }
            set { mState = value; NotifyUpdated(); }
        }

        public float[] Var {
            get { return mVar; }
            set { mVar = value; NotifyUpdated(); }
        }

        public INSState()
        {
            IsSingleInstance = true;
            ObjectId = 0xe341d5ec;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mState[0]);  // NO_ELEMENT_NAME
            s.Write(mState[1]);  // NO_ELEMENT_NAME
            s.Write(mState[2]);  // NO_ELEMENT_NAME
            s.Write(mState[3]);  // NO_ELEMENT_NAME
            s.Write(mState[4]);  // NO_ELEMENT_NAME
            s.Write(mState[5]);  // NO_ELEMENT_NAME
            s.Write(mState[6]);  // NO_ELEMENT_NAME
            s.Write(mState[7]);  // NO_ELEMENT_NAME
            s.Write(mState[8]);  // NO_ELEMENT_NAME
            s.Write(mState[9]);  // NO_ELEMENT_NAME
            s.Write(mState[10]);  // NO_ELEMENT_NAME
            s.Write(mState[11]);  // NO_ELEMENT_NAME
            s.Write(mState[12]);  // NO_ELEMENT_NAME
            s.Write(mState[13]);  // NO_ELEMENT_NAME
            s.Write(mState[14]);  // NO_ELEMENT_NAME
            s.Write(mState[15]);  // NO_ELEMENT_NAME
            s.Write(mVar[0]);  // NO_ELEMENT_NAME
            s.Write(mVar[1]);  // NO_ELEMENT_NAME
            s.Write(mVar[2]);  // NO_ELEMENT_NAME
            s.Write(mVar[3]);  // NO_ELEMENT_NAME
            s.Write(mVar[4]);  // NO_ELEMENT_NAME
            s.Write(mVar[5]);  // NO_ELEMENT_NAME
            s.Write(mVar[6]);  // NO_ELEMENT_NAME
            s.Write(mVar[7]);  // NO_ELEMENT_NAME
            s.Write(mVar[8]);  // NO_ELEMENT_NAME
            s.Write(mVar[9]);  // NO_ELEMENT_NAME
            s.Write(mVar[10]);  // NO_ELEMENT_NAME
            s.Write(mVar[11]);  // NO_ELEMENT_NAME
            s.Write(mVar[12]);  // NO_ELEMENT_NAME
            s.Write(mVar[13]);  // NO_ELEMENT_NAME
            s.Write(mVar[14]);  // NO_ELEMENT_NAME
            s.Write(mVar[15]);  // NO_ELEMENT_NAME
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mState[0] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[1] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[2] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[3] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[4] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[5] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[6] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[7] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[8] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[9] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[10] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[11] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[12] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[13] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[14] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mState[15] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[0] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[1] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[2] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[3] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[4] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[5] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[6] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[7] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[8] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[9] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[10] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[11] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[12] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[13] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[14] = stream.ReadSingle();  // NO_ELEMENT_NAME
            this.mVar[15] = stream.ReadSingle();  // NO_ELEMENT_NAME
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("INSState \n");
            sb.Append("    State\n");
            sb.AppendFormat("        : {0} \n", State[0]);
            sb.AppendFormat("        : {0} \n", State[1]);
            sb.AppendFormat("        : {0} \n", State[2]);
            sb.AppendFormat("        : {0} \n", State[3]);
            sb.AppendFormat("        : {0} \n", State[4]);
            sb.AppendFormat("        : {0} \n", State[5]);
            sb.AppendFormat("        : {0} \n", State[6]);
            sb.AppendFormat("        : {0} \n", State[7]);
            sb.AppendFormat("        : {0} \n", State[8]);
            sb.AppendFormat("        : {0} \n", State[9]);
            sb.AppendFormat("        : {0} \n", State[10]);
            sb.AppendFormat("        : {0} \n", State[11]);
            sb.AppendFormat("        : {0} \n", State[12]);
            sb.AppendFormat("        : {0} \n", State[13]);
            sb.AppendFormat("        : {0} \n", State[14]);
            sb.AppendFormat("        : {0} \n", State[15]);
            sb.Append("    Var\n");
            sb.AppendFormat("        : {0} \n", Var[0]);
            sb.AppendFormat("        : {0} \n", Var[1]);
            sb.AppendFormat("        : {0} \n", Var[2]);
            sb.AppendFormat("        : {0} \n", Var[3]);
            sb.AppendFormat("        : {0} \n", Var[4]);
            sb.AppendFormat("        : {0} \n", Var[5]);
            sb.AppendFormat("        : {0} \n", Var[6]);
            sb.AppendFormat("        : {0} \n", Var[7]);
            sb.AppendFormat("        : {0} \n", Var[8]);
            sb.AppendFormat("        : {0} \n", Var[9]);
            sb.AppendFormat("        : {0} \n", Var[10]);
            sb.AppendFormat("        : {0} \n", Var[11]);
            sb.AppendFormat("        : {0} \n", Var[12]);
            sb.AppendFormat("        : {0} \n", Var[13]);
            sb.AppendFormat("        : {0} \n", Var[14]);
            sb.AppendFormat("        : {0} \n", Var[15]);

            return sb.ToString();
        }

        private float[] mState = new float[16] ;
        private float[] mVar = new float[16] ;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class VibrationAnalysisOutput: UavDataObject
    {
        public float x {
            get { return mx; }
            set { mx = value; NotifyUpdated(); }
        }

        public float y {
            get { return my; }
            set { my = value; NotifyUpdated(); }
        }

        public float z {
            get { return mz; }
            set { mz = value; NotifyUpdated(); }
        }

        public VibrationAnalysisOutput()
        {
            IsSingleInstance = false;
            ObjectId = 0xd02b0a44;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mx);
            s.Write(my);
            s.Write(mz);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mx = stream.ReadSingle();
            this.my = stream.ReadSingle();
            this.mz = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("VibrationAnalysisOutput \n");
            sb.AppendFormat("    x: {0} m/s^2\n", x);
            sb.AppendFormat("    y: {0} m/s^2\n", y);
            sb.AppendFormat("    z: {0} m/s^2\n", z);

            return sb.ToString();
        }

        private float mx;
        private float my;
        private float mz;
    }
}

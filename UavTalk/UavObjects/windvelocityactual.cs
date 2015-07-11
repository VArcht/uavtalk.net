using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class WindVelocityActual: UavDataObject
    {
        public float North {
            get { return mNorth; }
            set { mNorth = value; NotifyUpdated(); }
        }

        public float East {
            get { return mEast; }
            set { mEast = value; NotifyUpdated(); }
        }

        public float Down {
            get { return mDown; }
            set { mDown = value; NotifyUpdated(); }
        }

        public WindVelocityActual()
        {
            IsSingleInstance = true;
            ObjectId = 0x6d31d2f8;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mNorth);
            s.Write(mEast);
            s.Write(mDown);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mNorth = stream.ReadSingle();
            this.mEast = stream.ReadSingle();
            this.mDown = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("WindVelocityActual \n");
            sb.AppendFormat("    North: {0} m/s\n", North);
            sb.AppendFormat("    East: {0} m/s\n", East);
            sb.AppendFormat("    Down: {0} m/s\n", Down);

            return sb.ToString();
        }

        private float mNorth;
        private float mEast;
        private float mDown;
    }
}

using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class NEDPosition: UavDataObject
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

        public NEDPosition()
        {
            IsSingleInstance = true;
            ObjectId = 0x1fb15a00;
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

            sb.Append("NEDPosition \n");
            sb.AppendFormat("    North: {0} m\n", North);
            sb.AppendFormat("    East: {0} m\n", East);
            sb.AppendFormat("    Down: {0} m\n", Down);

            return sb.ToString();
        }

        private float mNorth;
        private float mEast;
        private float mDown;
    }
}

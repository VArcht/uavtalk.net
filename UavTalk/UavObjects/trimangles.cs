using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class TrimAngles: UavDataObject
    {
        public float Roll {
            get { return mRoll; }
            set { mRoll = value; NotifyUpdated(); }
        }

        public float Pitch {
            get { return mPitch; }
            set { mPitch = value; NotifyUpdated(); }
        }

        public TrimAngles()
        {
            IsSingleInstance = true;
            ObjectId = 0x90b8c0de;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mRoll);
            s.Write(mPitch);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mRoll = stream.ReadSingle();
            this.mPitch = stream.ReadSingle();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("TrimAngles \n");
            sb.AppendFormat("    Roll: {0} degrees\n", Roll);
            sb.AppendFormat("    Pitch: {0} degrees\n", Pitch);

            return sb.ToString();
        }

        private float mRoll;
        private float mPitch;
    }
}

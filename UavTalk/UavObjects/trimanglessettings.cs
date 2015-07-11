using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class TrimAnglesSettings: UavDataObject
    {
        public float Roll {
            get { return mRoll; }
            set { mRoll = value; NotifyUpdated(); }
        }

        public float Pitch {
            get { return mPitch; }
            set { mPitch = value; NotifyUpdated(); }
        }

        public TrimAnglesSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x4e09a748;
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

            sb.Append("TrimAnglesSettings \n");
            sb.AppendFormat("    Roll: {0} degrees\n", Roll);
            sb.AppendFormat("    Pitch: {0} degrees\n", Pitch);

            return sb.ToString();
        }

        private float mRoll = 0f;
        private float mPitch = 0f;
    }
}

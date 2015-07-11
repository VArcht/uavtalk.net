using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum LoiterCommand_Frame { Body, Earth };

    public class LoiterCommand: UavDataObject
    {
        public float Forward {
            get { return mForward; }
            set { mForward = value; NotifyUpdated(); }
        }

        public float Right {
            get { return mRight; }
            set { mRight = value; NotifyUpdated(); }
        }

        public float Upwards {
            get { return mUpwards; }
            set { mUpwards = value; NotifyUpdated(); }
        }

        public LoiterCommand_Frame Frame {
            get { return mFrame; }
            set { mFrame = value; NotifyUpdated(); }
        }

        public LoiterCommand()
        {
            IsSingleInstance = true;
            ObjectId = 0x80d8d4ba;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mForward);
            s.Write(mRight);
            s.Write(mUpwards);
            s.Write((byte)mFrame);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mForward = stream.ReadSingle();
            this.mRight = stream.ReadSingle();
            this.mUpwards = stream.ReadSingle();
            this.mFrame = (LoiterCommand_Frame)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("LoiterCommand \n");
            sb.AppendFormat("    Forward: {0} m/s\n", Forward);
            sb.AppendFormat("    Right: {0} m/s\n", Right);
            sb.AppendFormat("    Upwards: {0} m/s\n", Upwards);
            sb.AppendFormat("    Frame: {0} \n", Frame);

            return sb.ToString();
        }

        private float mForward;
        private float mRight;
        private float mUpwards;
        private LoiterCommand_Frame mFrame;
    }
}

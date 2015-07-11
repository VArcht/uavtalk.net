using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class VtolPathFollowerStatus: UavDataObject
    {
        public byte FSM_State {
            get { return mFSM_State; }
            set { mFSM_State = value; NotifyUpdated(); }
        }

        public VtolPathFollowerStatus()
        {
            IsSingleInstance = true;
            ObjectId = 0x3238594c;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mFSM_State);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mFSM_State = stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("VtolPathFollowerStatus \n");
            sb.AppendFormat("    FSM_State: {0} \n", FSM_State);

            return sb.ToString();
        }

        private byte mFSM_State = 0;
    }
}

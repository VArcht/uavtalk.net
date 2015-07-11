using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum FlightStatsSettings_StatsBehavior { ResetOnArm, ResetOnBoot };

    public class FlightStatsSettings: UavDataObject
    {
        public FlightStatsSettings_StatsBehavior StatsBehavior {
            get { return mStatsBehavior; }
            set { mStatsBehavior = value; NotifyUpdated(); }
        }

        public FlightStatsSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x88bae028;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mStatsBehavior);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mStatsBehavior = (FlightStatsSettings_StatsBehavior)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("FlightStatsSettings \n");
            sb.AppendFormat("    StatsBehavior: {0} \n", StatsBehavior);

            return sb.ToString();
        }

        private FlightStatsSettings_StatsBehavior mStatsBehavior = FlightStatsSettings_StatsBehavior.ResetOnArm;
    }
}

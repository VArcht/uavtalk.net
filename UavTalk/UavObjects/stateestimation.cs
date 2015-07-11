using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum StateEstimation_AttitudeFilter { Complementary, INSIndoor, INSOutdoor };

    public enum StateEstimation_NavigationFilter { None, Raw, INS };

    public class StateEstimation: UavDataObject
    {
        public StateEstimation_AttitudeFilter AttitudeFilter {
            get { return mAttitudeFilter; }
            set { mAttitudeFilter = value; NotifyUpdated(); }
        }

        public StateEstimation_NavigationFilter NavigationFilter {
            get { return mNavigationFilter; }
            set { mNavigationFilter = value; NotifyUpdated(); }
        }

        public StateEstimation()
        {
            IsSingleInstance = true;
            ObjectId = 0xba09f7c2;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mAttitudeFilter);
            s.Write((byte)mNavigationFilter);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mAttitudeFilter = (StateEstimation_AttitudeFilter)stream.ReadByte();
            this.mNavigationFilter = (StateEstimation_NavigationFilter)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("StateEstimation \n");
            sb.AppendFormat("    AttitudeFilter: {0} \n", AttitudeFilter);
            sb.AppendFormat("    NavigationFilter: {0} \n", NavigationFilter);

            return sb.ToString();
        }

        private StateEstimation_AttitudeFilter mAttitudeFilter = StateEstimation_AttitudeFilter.Complementary;
        private StateEstimation_NavigationFilter mNavigationFilter = StateEstimation_NavigationFilter.None;
    }
}

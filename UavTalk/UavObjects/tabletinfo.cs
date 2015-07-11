using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum TabletInfo_Connected { False, True };

    public enum TabletInfo_TabletModeDesired { PositionHold, ReturnToHome, ReturnToTablet, PathPlanner, FollowMe, Land, CameraPOI };

    public enum TabletInfo_POI { False, True };

    public class TabletInfo: UavDataObject
    {
        public Int32 Latitude {
            get { return mLatitude; }
            set { mLatitude = value; NotifyUpdated(); }
        }

        public Int32 Longitude {
            get { return mLongitude; }
            set { mLongitude = value; NotifyUpdated(); }
        }

        public float Altitude {
            get { return mAltitude; }
            set { mAltitude = value; NotifyUpdated(); }
        }

        public TabletInfo_Connected Connected {
            get { return mConnected; }
            set { mConnected = value; NotifyUpdated(); }
        }

        public TabletInfo_TabletModeDesired TabletModeDesired {
            get { return mTabletModeDesired; }
            set { mTabletModeDesired = value; NotifyUpdated(); }
        }

        public TabletInfo_POI POI {
            get { return mPOI; }
            set { mPOI = value; NotifyUpdated(); }
        }

        public TabletInfo()
        {
            IsSingleInstance = true;
            ObjectId = 0xb80cc3b2;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mLatitude);
            s.Write(mLongitude);
            s.Write(mAltitude);
            s.Write((byte)mConnected);
            s.Write((byte)mTabletModeDesired);
            s.Write((byte)mPOI);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mLatitude = stream.ReadInt32();
            this.mLongitude = stream.ReadInt32();
            this.mAltitude = stream.ReadSingle();
            this.mConnected = (TabletInfo_Connected)stream.ReadByte();
            this.mTabletModeDesired = (TabletInfo_TabletModeDesired)stream.ReadByte();
            this.mPOI = (TabletInfo_POI)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("TabletInfo \n");
            sb.AppendFormat("    Latitude: {0} deg*10e6\n", Latitude);
            sb.AppendFormat("    Longitude: {0} deg*10e6\n", Longitude);
            sb.AppendFormat("    Altitude: {0} m\n", Altitude);
            sb.AppendFormat("    Connected: {0} \n", Connected);
            sb.AppendFormat("    TabletModeDesired: {0} \n", TabletModeDesired);
            sb.AppendFormat("    POI: {0} \n", POI);

            return sb.ToString();
        }

        private Int32 mLatitude;
        private Int32 mLongitude;
        private float mAltitude;
        private TabletInfo_Connected mConnected;
        private TabletInfo_TabletModeDesired mTabletModeDesired;
        private TabletInfo_POI mPOI;
    }
}

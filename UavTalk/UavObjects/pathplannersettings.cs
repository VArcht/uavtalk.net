using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum PathPlannerSettings_PreprogrammedPath { NONE, _10M_BOX, LOGO };

    public enum PathPlannerSettings_FlashOperation { NONE, FAILED, COMPLETED, SAVE1, SAVE2, SAVE3, SAVE4, SAVE5, LOAD1, LOAD2, LOAD3, LOAD4, LOAD5 };

    public class PathPlannerSettings: UavDataObject
    {
        public PathPlannerSettings_PreprogrammedPath PreprogrammedPath {
            get { return mPreprogrammedPath; }
            set { mPreprogrammedPath = value; NotifyUpdated(); }
        }

        public PathPlannerSettings_FlashOperation FlashOperation {
            get { return mFlashOperation; }
            set { mFlashOperation = value; NotifyUpdated(); }
        }

        public PathPlannerSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x77a9e8f0;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mPreprogrammedPath);
            s.Write((byte)mFlashOperation);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mPreprogrammedPath = (PathPlannerSettings_PreprogrammedPath)stream.ReadByte();
            this.mFlashOperation = (PathPlannerSettings_FlashOperation)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("PathPlannerSettings \n");
            sb.AppendFormat("    PreprogrammedPath: {0} \n", PreprogrammedPath);
            sb.AppendFormat("    FlashOperation: {0} \n", FlashOperation);

            return sb.ToString();
        }

        private PathPlannerSettings_PreprogrammedPath mPreprogrammedPath = PathPlannerSettings_PreprogrammedPath.NONE;
        private PathPlannerSettings_FlashOperation mFlashOperation = PathPlannerSettings_FlashOperation.NONE;
    }
}

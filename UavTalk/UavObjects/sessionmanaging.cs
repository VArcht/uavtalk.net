using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public class SessionManaging: UavDataObject
    {
        public UInt32 ObjectID {
            get { return mObjectID; }
            set { mObjectID = value; NotifyUpdated(); }
        }

        public UInt16 SessionID {
            get { return mSessionID; }
            set { mSessionID = value; NotifyUpdated(); }
        }

        public byte ObjectInstances {
            get { return mObjectInstances; }
            set { mObjectInstances = value; NotifyUpdated(); }
        }

        public byte NumberOfObjects {
            get { return mNumberOfObjects; }
            set { mNumberOfObjects = value; NotifyUpdated(); }
        }

        public byte ObjectOfInterestIndex {
            get { return mObjectOfInterestIndex; }
            set { mObjectOfInterestIndex = value; NotifyUpdated(); }
        }

        public SessionManaging()
        {
            IsSingleInstance = true;
            ObjectId = 0x89034e4a;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mObjectID);
            s.Write(mSessionID);
            s.Write(mObjectInstances);
            s.Write(mNumberOfObjects);
            s.Write(mObjectOfInterestIndex);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mObjectID = stream.ReadUInt32();
            this.mSessionID = stream.ReadUInt16();
            this.mObjectInstances = stream.ReadByte();
            this.mNumberOfObjects = stream.ReadByte();
            this.mObjectOfInterestIndex = stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("SessionManaging \n");
            sb.AppendFormat("    ObjectID: {0} \n", ObjectID);
            sb.AppendFormat("    SessionID: {0} \n", SessionID);
            sb.AppendFormat("    ObjectInstances: {0} \n", ObjectInstances);
            sb.AppendFormat("    NumberOfObjects: {0} \n", NumberOfObjects);
            sb.AppendFormat("    ObjectOfInterestIndex: {0} \n", ObjectOfInterestIndex);

            return sb.ToString();
        }

        private UInt32 mObjectID;
        private UInt16 mSessionID;
        private byte mObjectInstances;
        private byte mNumberOfObjects;
        private byte mObjectOfInterestIndex;
    }
}

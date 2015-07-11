using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum LoggingSettings_LogBehavior { LogOnStart, LogOnArm, LogOff };

    public enum LoggingSettings_LogSettingsOnStart { True, False };

    public enum LoggingSettings_MaxLogRate { _5, _10, _25, _50, _100 };

    public class LoggingSettings: UavDataObject
    {
        public LoggingSettings_LogBehavior LogBehavior {
            get { return mLogBehavior; }
            set { mLogBehavior = value; NotifyUpdated(); }
        }

        public LoggingSettings_LogSettingsOnStart LogSettingsOnStart {
            get { return mLogSettingsOnStart; }
            set { mLogSettingsOnStart = value; NotifyUpdated(); }
        }

        public LoggingSettings_MaxLogRate MaxLogRate {
            get { return mMaxLogRate; }
            set { mMaxLogRate = value; NotifyUpdated(); }
        }

        public LoggingSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0xe2787f88;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write((byte)mLogBehavior);
            s.Write((byte)mLogSettingsOnStart);
            s.Write((byte)mMaxLogRate);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mLogBehavior = (LoggingSettings_LogBehavior)stream.ReadByte();
            this.mLogSettingsOnStart = (LoggingSettings_LogSettingsOnStart)stream.ReadByte();
            this.mMaxLogRate = (LoggingSettings_MaxLogRate)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("LoggingSettings \n");
            sb.AppendFormat("    LogBehavior: {0} \n", LogBehavior);
            sb.AppendFormat("    LogSettingsOnStart: {0} \n", LogSettingsOnStart);
            sb.AppendFormat("    MaxLogRate: {0} Hz\n", MaxLogRate);

            return sb.ToString();
        }

        private LoggingSettings_LogBehavior mLogBehavior = LoggingSettings_LogBehavior.LogOnArm;
        private LoggingSettings_LogSettingsOnStart mLogSettingsOnStart = LoggingSettings_LogSettingsOnStart.True;
        private LoggingSettings_MaxLogRate mMaxLogRate = LoggingSettings_MaxLogRate._25;
    }
}

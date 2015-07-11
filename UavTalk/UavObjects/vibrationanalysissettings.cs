using System;
using System.IO;
using UavTalk;

namespace UavTalk
{

    public enum VibrationAnalysisSettings_FFTWindowSize { _16, _64, _256, _1024 };

    public enum VibrationAnalysisSettings_TestingStatus { Off, On };

    public class VibrationAnalysisSettings: UavDataObject
    {
        public UInt16 SampleRate {
            get { return mSampleRate; }
            set { mSampleRate = value; NotifyUpdated(); }
        }

        public VibrationAnalysisSettings_FFTWindowSize FFTWindowSize {
            get { return mFFTWindowSize; }
            set { mFFTWindowSize = value; NotifyUpdated(); }
        }

        public VibrationAnalysisSettings_TestingStatus TestingStatus {
            get { return mTestingStatus; }
            set { mTestingStatus = value; NotifyUpdated(); }
        }

        public VibrationAnalysisSettings()
        {
            IsSingleInstance = true;
            ObjectId = 0x5c5c96b6;
        }

        internal override void SerializeBody(BinaryWriter s)
        {
            s.Write(mSampleRate);
            s.Write((byte)mFFTWindowSize);
            s.Write((byte)mTestingStatus);
        }


        internal override void DeserializeBody(BinaryReader stream)
        {
            this.mSampleRate = stream.ReadUInt16();
            this.mFFTWindowSize = (VibrationAnalysisSettings_FFTWindowSize)stream.ReadByte();
            this.mTestingStatus = (VibrationAnalysisSettings_TestingStatus)stream.ReadByte();
        }


        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("VibrationAnalysisSettings \n");
            sb.AppendFormat("    SampleRate: {0} ms\n", SampleRate);
            sb.AppendFormat("    FFTWindowSize: {0} \n", FFTWindowSize);
            sb.AppendFormat("    TestingStatus: {0} \n", TestingStatus);

            return sb.ToString();
        }

        private UInt16 mSampleRate = 20;
        private VibrationAnalysisSettings_FFTWindowSize mFFTWindowSize = VibrationAnalysisSettings_FFTWindowSize._16;
        private VibrationAnalysisSettings_TestingStatus mTestingStatus = VibrationAnalysisSettings_TestingStatus.Off;
    }
}

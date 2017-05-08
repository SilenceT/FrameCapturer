using UTJ.FrameCapturer;

namespace UnityEngine.Recorder.FrameRecorder
{
    [ExecuteInEditMode]
    public class PNGRecorderSettings : ImageRecorderSettings
    {
        public string m_BaseFileName  = "pngFile";
        public string m_DestinationPath = "Recorder";
        public fcAPI.fcPngConfig m_PngConfig = fcAPI.fcPngConfig.default_value;

        public override bool isValid
        {
            get
            {
                return base.isValid && !string.IsNullOrEmpty(m_DestinationPath) && !string.IsNullOrEmpty(m_BaseFileName);
            }
        }
    }
}

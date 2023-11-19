
namespace Rec_radio.Models
{
    public class AudioPredictionResponse
    {
        public int status_code { get; set; } = 400;
        public string response_type { get; set; } = "";
        public string description { get; set; } = "";
        public AudioData data { get; set; } = null;
    }

    public class AudioData
    {
        public int class_ids { get; set; }
        public string class_names { get; set; }
        public double predictions { get; set; }
        public double inference_time { get; set; }
        public string predicted_at { get; set; }
    }
}

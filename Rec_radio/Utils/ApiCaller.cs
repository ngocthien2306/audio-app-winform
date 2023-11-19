using Newtonsoft.Json;
using Rec_radio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Rec_radio.Utils
{
    public static class ApiCaller
    {
        public async static Task<AudioPredictionResponse> ClassifyAudioAsync(string fileName)
        {
            string apiUrl = "http://26.52.35.245:8000/audio/v1/predict-base64"; // Replace with your API endpoint URL
            string audioFilePath = fileName; // Replace with the path to your WAV file
            AudioPredictionResponse responseCls = new AudioPredictionResponse();
            // Read the audio file and convert it to base64
            byte[] audioBytes = File.ReadAllBytes(audioFilePath);
            string audioBase64 = Convert.ToBase64String(audioBytes);

            // Create a JSON payload with the audio data
            string jsonPayload = $"{{\"audio_data\":\"{audioBase64}\"}}";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Send a POST request to the API
                    var response = await httpClient.PostAsync(apiUrl, new StringContent(jsonPayload, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the API response here
                        string responseBody = await response.Content.ReadAsStringAsync();
                        // Convert json to modelSA
                        responseCls = JsonConvert.DeserializeObject<AudioPredictionResponse>(responseBody);

                        Console.WriteLine("API Response: " + responseBody);
                        return responseCls;
                    }
                    else
                    {
                        Console.WriteLine("API request failed with status code: " + response.StatusCode);
                        return responseCls;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("API request failed with exception: " + ex.Message);
                    return responseCls;
                }
            }
        }
    }
}

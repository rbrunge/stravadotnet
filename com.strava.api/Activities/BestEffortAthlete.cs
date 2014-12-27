using Newtonsoft.Json;

namespace com.strava.api.Activities
{
    /// <summary>
    /// Athlete for best effort class
    /// <see cref="BestEffort" />
    /// </summary>
    public class BestEffortAthlete
    {
        /// <summary>
        /// Gets or sets athlete identifier
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
using System.Reflection;
using System.Text.Json;

namespace MovieRatingApp.Mobile.Configuration
{
    public class ConfigurationService
    {
        public static T GetConfiguration<T>(string resourceName) where T : new()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fullResourceName = $"{assembly.GetName().Name}.{resourceName}";

            using(var stream = assembly.GetManifestResourceStream(fullResourceName))
            {
                if(stream == null)
                {
                    throw new InvalidOperationException($"Resource {fullResourceName} not found.");
                }

                using(var reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    T result = JsonSerializer.Deserialize<T>(json);
                    return result;
                }
            }
        }
    }
}

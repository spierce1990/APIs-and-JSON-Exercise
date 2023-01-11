namespace APIsAndJSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Program
    {
        static void Main(string[] args)
        {
           
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

             string kanyeResponse = client.GetStringAsync(kanyeURL).Result;

        string ronResponse = client.GetStringAsync(ronURL).Result;
        //create end point
        //parse object

        var kanyeObject = JObject.Parse(kanyeResponse);

        var ronObject = JArray.Parse(ronResponse);
             //method json

            //write it out

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {kanyeObject["quote"]}");

                Console.WriteLine($"Ron Swanson: {ronObject[0]}");

            }
        }
    }


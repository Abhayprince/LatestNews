using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestNews;
public static class Constants
{
    // Note: I know this is not a good idea to have the Api Key in here in Client MAUI 
    // for the demo purpose, I am keeping it simple and having the api key here (Which is NOT SECURE)
    // Should not be like this for Production use

    // GRAB YOUR API KEY FROM - https://newsdata.io/
    public const string ApiKey = "YOUR_API_KEY";
}

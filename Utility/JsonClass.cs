using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace SpecFlow_Individual_Task.Utility
{
    public class JsonClass
    {
        public IConfigurationRoot configRoot;
        public JsonClass()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("JsonData.json");
            configRoot = builder.Build();   
        }

        public string ReadJsonData(string key) => configRoot[key];
    }
}

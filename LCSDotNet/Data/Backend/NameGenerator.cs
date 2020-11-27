using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LCSDotNet.Data
{
    public class NameGenerator
    {
        class NameList
        {
            public string[] boys { get; set; }
            public string[] girls { get; set; }
            public string[] last { get; set; }
            public string[] city { get; set; }

            public NameList()
            {
                boys = new string[] { };
                girls = new string[] { };
                last = new string[] { };
                city = new string[] { };
            }
        }
        
        Random rand;
        List<string> Male;
        List<string> Female;
        List<string> Neutral;
        List<string> Last;
        List<string> Cities;

        public NameGenerator(Random rand)
        {
            this.rand = rand;
            NameList l = new NameList();
            
            JsonSerializer serializer = new JsonSerializer();
            
            using(StreamReader sr = new StreamReader(".//..//..//Data//names.json"))
            using (JsonReader reader = new JsonTextReader(sr)) {
                l = serializer.Deserialize<NameList>(reader);
            }
            
            Male = new List<string>(l.boys);
            Female = new List<string>(l.girls);
            Last = new List<string>(l.last);
            Cities = new List<string>(l.city);
            Neutral = new List<string>();
            
            Neutral.AddRange(Male);
            Neutral.AddRange(Female);
        }

        public string Generate(Gender gender)
        {
            string first, last;
            if (gender == Gender.Male) {
                first = Male[rand.Next(Male.Count)];
            }
            else if (gender == Gender.Female) {
                first = Female[rand.Next(Female.Count)];
            }
            else {
                first = Neutral[rand.Next(Neutral.Count)];
            }

            last = Last[rand.Next(Last.Count)];

            return first + " " + last;
        }

        public string GenerateCity()
        {
            return Cities[rand.Next(Cities.Count)];
        }

        public List<string> RandomNames(int num, Gender gender)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < num; i++) {
                names.Add(Generate(gender));
            }

            return names;
        }
    }
}
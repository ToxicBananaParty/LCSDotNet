using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LCSDotNet.Backend
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
            
        private static NameGenerator instance;

        public static string Generate(Gender gender = Gender.Neutral)
        {
            if (instance != null) {
                return instance.generate(gender);
            }
            throw new NullReferenceException();
        }

        public static string GenerateCity()
        {
            if (instance != null) {
                return instance.generateCity();
            }
            throw new NullReferenceException();
        }

        public static List<string> RandomNames(int num, Gender gender)
        {
            if (instance != null) {
                return instance.randomNames(num, gender);
            }
            throw new NullReferenceException();
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
            
            using(StreamReader sr = new StreamReader(".//..//..//..//Data//Backend//names.json"))
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
            instance = this;
        }

        string generate(Gender gender)
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

        string generateCity()
        {
            return Cities[rand.Next(Cities.Count)];
        }

        List<string> randomNames(int num, Gender gender)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < num; i++) {
                names.Add(Generate(gender));
            }

            return names;
        }
    }
}
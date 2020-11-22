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

            public NameList()
            {
                boys = new string[] { };
                girls = new string[] { };
                last = new string[] { };
            }
        }
        
        private Random rand;
        private List<string> maleFirst, femaleFirst, neutralFirst, lastNames;
        
        public NameGenerator(Random rand)
        {
            this.rand = rand;
            NameList list = new NameList();
            
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(".//..//..//..//Data//names.json"))
            using (JsonReader reader = new JsonTextReader(sr)) {
                list = serializer.Deserialize<NameList>(reader);
            }
            
            maleFirst = new List<string>(list.boys);
            femaleFirst = new List<string>(list.girls);
            lastNames = new List<string>(list.last);
            neutralFirst = new List<string>(maleFirst.Count + femaleFirst.Count);
            neutralFirst.AddRange(maleFirst);
            neutralFirst.AddRange(femaleFirst);
        }

        public string Generate(Gender gender, int middle = 0, bool isInitial = false)
        {
            string first, last;
            
            if (gender == Gender.Female)
                first = femaleFirst[rand.Next(femaleFirst.Count)];
            else if (gender == Gender.Male)
                first = maleFirst[rand.Next(maleFirst.Count)];
            else
                first = neutralFirst[rand.Next(neutralFirst.Count)];

            last = lastNames[rand.Next(lastNames.Count)];

            return first + " " + last;
        }

        public List<string> RandomNames(int num, Gender gender = Gender.Neutral)
        {
            List<string> names = new List<string>();

            for (int i = 0; i < num; i++) {
                names.Add(Generate(gender));
            }

            return names;
        }
    }
}
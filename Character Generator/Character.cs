using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Generator
{
    public class Character
    {
        public int ID { get; set; }
        public string LifePhase { get; set; }
        public string MainTrait { get; set; }
        public string MainStrength { get; set; }
        public string MainWeakness { get; set; }
        public string Goal { get; set; }
        public string Secret { get; set; }

        //public Character(int id, string lifephase, string maintrait, string mainstrength, string mainweakness, string goal, string secret);
  
    }
}

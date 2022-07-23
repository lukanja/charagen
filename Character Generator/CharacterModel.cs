using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Generator
{
    public class CharacterModel
    {
        public int ID { get; set; }
        public int LifePhaseId { get; set; }
        public int MainTraitId { get; set; }
        public int MainStrengthId { get; set; }
        public int MainFlawId { get; set; }
        public int GoalId { get; set; }
        public int SecretId { get; set; }

        public CharacterModel(int id, int lifephase, int maintrait, int mainstrength, int mainflaw, int goal, int secret)
        {
            ID = id;
            LifePhaseId = lifephase;
            MainTraitId = maintrait;
            MainStrengthId = mainstrength;
            MainFlawId = mainflaw;
            GoalId = goal;
            SecretId = secret;
        }
  
    }
}

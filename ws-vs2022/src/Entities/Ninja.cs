using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ws_vs2022.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)  : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " usou técnica ataque das sombras";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){

                return this.Name + " usou super ataque das sombras com bonus de " + Bonus;

            }else{
                return this.Name + " usou ataque sombrio fraca com bonus de " + Bonus;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ws_vs2022.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)  : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " atacou com sua espada ";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){

                return this.Name + " realizou investida avassaladora com sua espada com bonus de " + Bonus;

            }else{
                return this.Name + " realizoui investida de soldado com sua espada com bonus de " + Bonus;
            }
        }
    }
}
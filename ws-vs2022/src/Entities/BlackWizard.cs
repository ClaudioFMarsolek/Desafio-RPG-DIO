using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ws_vs2022.src.Entities
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name, int Level, string HeroType)  : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " lançou magia obscura ";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){

                return this.Name + " lançou massiva força das trevas com bonus de " + Bonus;

            }else{
                return this.Name + " lançou magia obscura com força fraca com bonus de " + Bonus;
            }            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class Ingredient
    {
        public string Name;
        public IngredientName NameEnum;
        public string Modifier;
        public int Roll;
        public bool Double = false;
        public bool IsCommon = false;
        public bool ExtraWater = false;
        public int Number = 0;
    }
}

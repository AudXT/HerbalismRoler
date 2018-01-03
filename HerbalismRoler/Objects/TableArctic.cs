using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class TableArctic : Table
    {
        public TableArctic()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {NameEnum = IngredientName.Silver_Hibiscus },
                new Ingredient {NameEnum = IngredientName.Mortflesh_Powder},
                new Ingredient {NameEnum = IngredientName.Ironwood_Heart},
                new Ingredient {NameEnum = IngredientName.Frozen_Seedlings, Double = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {NameEnum = IngredientName.Arctic_Creeper, Double = true},
                new Ingredient {NameEnum = IngredientName.Fennel_Silk},
                new Ingredient {NameEnum = IngredientName.Friends_Ivy},
                new Ingredient {NameEnum = IngredientName.Voidroot},
            };
        }
    }
}

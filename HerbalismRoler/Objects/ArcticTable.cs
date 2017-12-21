using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerbalismRoler.Objects
{
    public class ArcticTable : Table
    {
        public ArcticTable()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient {Name = "Silver Hibiscus"},
                new Ingredient {Name = "Mortflesh Powder"},
                new Ingredient {Name = "Ironwood Heart"},
                new Ingredient {Name = "Frozen Seedlings", Double = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {IsCommon = true},
                new Ingredient {Name = "Arctic Creeper", Double = true},
                new Ingredient {Name = "Finnel Silk"},
                new Ingredient {Name = "Friend's Ivy"},
                new Ingredient {Name = "Voidroot"},
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HerbalismRoler
{
    public class Genorator
    {
        public Dictionary<String, int> IngredientsFound;

        public void rollTable(Table table, int mod, int dc)
        {
            if (Roll(20) + mod > dc)
            {
                int x = Roll(4);

                for (int i = 0; i < x; i++)
                {
                    if (Roll(100) < 75)
                    {

                        var ingredient = table.GetIngredient((Roll(6, 2)) - 1);

                        IngredientsFound[ingredient.Name] += 1;

                        if (ingredient.Double)
                            IngredientsFound[ingredient.Name] += 1;
                    }
                    else
                    {
                        IngredientsFound["Enchanted Water"] += 1;
                    }
                }
            }
        }

        public string getTable()
        {
            StringBuilder s = new StringBuilder();
            
            foreach(var n in IngredientsFound)
            {
                if(n.Value > 0)
                {
                    s.Append($"{n.Key}: {n.Value}, ");
                }
            }

            if(s.Length < 1)
            {
                s.Append("None Found");
            }

            return s.ToString();
        }

        public int Roll(int diceSize, int diceAmount = 1)
        {
            Random random = new Random();
            int result = 0;

            for (int i = 0; i < diceAmount; i++)
            {
                result += random.Next(1, diceSize);
                Thread.Sleep(100);
            }

            return result;
        }

        public Genorator()
        {
            IngredientsFound = new Dictionary<string, int>();

            IngredientsFound.Add("Arctic Creeper", 0);
            IngredientsFound.Add("Bloodgrass", 0);
            IngredientsFound.Add("Enchanted Water", 0);
            IngredientsFound.Add("Finnel Silk", 0);
            IngredientsFound.Add("Friend's Ivy", 0);
            IngredientsFound.Add("Frozen Seedlings", 0);
            IngredientsFound.Add("Ironwood Heart", 0);
            IngredientsFound.Add("Mandrake Root", 0);
            IngredientsFound.Add("Milkweed Seeds", 0);
            IngredientsFound.Add("Mortflesh Powder", 0);
            IngredientsFound.Add("Quicksilver Lichen", 0);
            IngredientsFound.Add("Silver Hibiscus", 0);
            IngredientsFound.Add("Voidroot", 0);
            IngredientsFound.Add("Wild Sageroot", 0);
            IngredientsFound.Add("Wyrmtoungue Petals", 0);
        }
    }
}

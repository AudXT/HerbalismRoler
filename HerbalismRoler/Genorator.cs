﻿using System;
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
                for (int i = 0; i < Roll(4); i++)
                {
                    if (Roll(100) < 75)
                    {

                        var ingredient = table.GetIngredient(Roll(6, 2));

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

        public int Roll(int diceSize, int diceAmount = 1)
        {
            Random random = new Random();
            int result = 0;

            for (int i = 0; i < diceAmount; i++)
            {
                result += random.Next(0, diceSize-1);
                Thread.Sleep(1000);
            }

            return result;
        }

        public Genorator()
        {
            IngredientsFound.Add("Enchanted Water", 0);
            IngredientsFound.Add("Silver Hibiscus", 0);
            IngredientsFound.Add("Mortflesh Powder", 0);
            IngredientsFound.Add("Ironwood Heart", 0);
            IngredientsFound.Add("Frozen Seedlings", 0);
            IngredientsFound.Add("Arctic Creeper", 0);
            IngredientsFound.Add("Finnel Silk", 0);
            IngredientsFound.Add("Friend's Ivy", 0);
            IngredientsFound.Add("Voidroot", 0);
            IngredientsFound.Add("Mandrake Root", 0);
            IngredientsFound.Add("Quicksilver Lichen", 0);
            IngredientsFound.Add("Wild Sageroot", 0);
            IngredientsFound.Add("Bloodgrass", 0);
            IngredientsFound.Add("Milkweed Seeds", 0);
        }
    }
}

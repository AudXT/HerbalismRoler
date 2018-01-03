using HerbalismRoler.Objects;
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
        public Dictionary<IngredientName, Ingredient> IngredientsFound;

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

                        IngredientsFound[ingredient.NameEnum].Number += 1;

                        if (ingredient.Double)
                            IngredientsFound[ingredient.NameEnum].Number += 1;

                        if (ingredient.ExtraWater)
                            IngredientsFound[IngredientName.Elemental_Water].Number += 1;
                    }
                    else
                    {
                        IngredientsFound[IngredientName.Elemental_Water].Number += 1;
                    }
                }
            }
        }

        public string getTable()
        {
            StringBuilder s = new StringBuilder();
            
            foreach(var n in IngredientsFound)
            {
                if(n.Value.Number > 0)
                {
                    s.Append($"{n.Value.Name}: {n.Value.Number}\n");
                }
            }

            if(s.Length < 1)
            {
                s.Append("None Found");
            }

            s = s.Replace('_', ' ');

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
            IngredientsFound = new Dictionary<IngredientName, Ingredient>();

            for (int i = 0; i < Enum.GetValues(typeof(IngredientName)).Length; i++)
            {
                IngredientName t = (IngredientName)i;
                IngredientsFound.Add(t, new Ingredient() { Name = t.ToString() });
            }
        }
    }
}

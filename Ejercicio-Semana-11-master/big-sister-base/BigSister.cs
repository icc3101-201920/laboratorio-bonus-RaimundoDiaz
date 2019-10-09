using System;
using System.Collections.Generic;
using System.Text;

namespace big_sister_base
{
    public class BigSister
    {
        public List<string> recipe = new List<string>
        {
            "Leche Entera", "Mantequilla", "Pimienta", "Vino Sauvignon Blanc Reserva Botella",
            "Sal Lobos", "Láminas de Lasaña", "Harina", "Carne Molida", "Aceite de Oliva",
            "Queso Rallado Parmesano", "Malla de Cebollas", "Tomates Pelados en lata", "Bolsa de Zanahorias"
        };

        public List<Product> items = new List<Product> { };
        public bool OnPayed(object source, EventArgs e)
        {
            Console.WriteLine("What you doing littleguy?");
            foreach (Product product in items)
            {
                if (recipe.Contains(product.Name))
                {
                    continue;
                }
                else
                {
                    return false;
                }

            }
            return true;
        }


        public void OnProductAdded(object source, Product product) // no se si puse algo mal, pero creo que nunca entra a este metodo
        {                                                         // cuando agrrego algo al carro no imprime nada de OnProductAdded
            Console.WriteLine("Product added");                   // no pude solucionarlo.
            LittleGuy littleGuy = (LittleGuy)source;
            Console.WriteLine(product.Name);
            if (recipe.Contains(product.Name))
            {
                Console.WriteLine("consolewriteline test");
                items.Add(product);
            }
            else
            {
                Console.WriteLine("That's not in the list littleguy");
                littleGuy.RemoveProduct(product);
            }
        }

    }
}
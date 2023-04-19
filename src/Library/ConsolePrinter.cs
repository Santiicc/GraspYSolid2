using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library;

public class Consoleprinter
{
    
    Recipe auxiliar=new Recipe();

    public Consoleprinter(Recipe receta)
    {
        this.auxiliar=receta;
    }

    public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.auxiliar.FinalProduct.Description}:");
            foreach (Step step in auxiliar.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
}
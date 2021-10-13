using System;

namespace Full_GRASP_And_SOLID.Library {
    public class ConsolePrinter : IPrinter {
        
        // Implementación de IPrinter.PrintRecipe que utiliza la clase
        // System.Console para imprimir la receta por consola.
        public void PrintRecipe(Recipe recipe) {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        
        // Implementación de IPrinter.PrintRecipe que utiliza la clase
        // System.IO.File para imprimir la receta hacia un archivo.
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}
namespace Full_GRASP_And_SOLID.Library
{
    // Tipo común a todas clases de impresoras.
    public interface IPrinter
    {
        // Operación polimórfica que es implementada por todas las clases
        // (aplicando el patrón Polymorphism) que implementan el tipo IPrinter.
        // Cada clase lo implementa de la manera más adecuada para cumplir la
        // responsabilidad de realizar la impresión en un destino diferente.
        void PrintRecipe(Recipe recipe);
    }
}

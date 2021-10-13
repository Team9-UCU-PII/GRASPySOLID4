//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private IList<Step> steps = new List<Step>();

        public Product FinalProduct { get; set; }

        // Como Recipe agrega objetos Step, por patrón Creator tiene la responsabilidad de
        // crear los objetos de dicho tipo.
        // Para ello, cambiamos la firma de AddStep, indicando que recibe todos los parámetros
        // necesarios para crear dentro del método un Step, y cambiamos el tipo de retorno
        // de void a Step para permitirnos retornar la referencia al Step creado.
        public Step AddStep(Product input, double quantity, Equipment equipment, int time)
        {
            Step step = new Step(input, quantity, equipment, time);
            this.steps.Add(step);
            return step;
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // Agregado por SRP
        public string GetTextToPrint()
        {
            string result = $"Receta de {this.FinalProduct.Description}:\n";
            foreach (Step step in this.steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agregado por Expert
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
        }

        // Agregado por Expert
        public double GetProductionCost()
        {
            double result = 0;

            foreach (Step step in this.steps)
            {
                result = result + step.GetStepCost();
            }

            return result;
        }
    }
}
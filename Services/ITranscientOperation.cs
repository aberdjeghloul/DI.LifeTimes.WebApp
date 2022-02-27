using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    /// <summary>
    /// En utilisant ce type de durée de vie, votre service sera créé à chaque fois qu’il sera demandé. 
    /// Cela veut dire, par exemple, qu’un service injecté dans le constructeur d’une classe durera “autant de temps” que l’instance de cette classe. 
    /// Pour créer un service avec une durée de vie « Transient » vous devez utiliser la méthode AddTransient()
    /// Sa valeur changera à chaque fois que le service TransientOperation sera appelé
    /// </summary>
    public interface ITranscientOperation: IOperation
    {
    }
}

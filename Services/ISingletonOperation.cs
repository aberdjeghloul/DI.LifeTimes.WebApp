using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    /// <summary>
    /// Ce type de durée de vie crée une instance du service disponible tant que l’application restera en exécution.
    /// Vous devez enregistrer un service de type « Singleton » en utilisant la méthode Add() / AddSingleton()
    /// Une fois que vous avez lancé l’application sa valeur sera toujours la même
    /// </summary>
    public interface ISingletonOperation : IOperation
    {        
    }
}

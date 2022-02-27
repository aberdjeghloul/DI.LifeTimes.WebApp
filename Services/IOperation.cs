using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    /// <summary>
    /// Plus bas niveau d'abstraction. Contrat qui stipule que toutes ses implémentations doivent comporter au moins cette propriété Id
    /// </summary>
    public interface IOperation
    {
        Guid Id { get; }
    }
}

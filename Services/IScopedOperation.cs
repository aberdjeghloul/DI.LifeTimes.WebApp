using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    /// <summary>
    /// ce type de durée de vie « Scoped » vous permet de créer une nouvelle instance d’un service par chaque demande d’un client. 
    /// Ceci est particulièrement utile dans le contexte d’ASP.NET car cela vous permet de partager la même instance de service pour la durée de traitement de la demande http. 
    /// Pour activer la durée de vie « Scoped » vous devez utiliser la méthode AddScoped()
    /// Sa valeur changera pour chaque nouvelle demande au serveur (donc ça se traduit pour vous par rafraîchir la « home page » de votre navigateur
    /// </summary>
    public interface IScopedOperation: IOperation
    {
    }
}

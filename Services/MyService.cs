using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    /// <summary>
    /// Ce service sera injecté dans le HomeController. Il nous aidera à obtenir une nouvelle instance de chaque service avec un seul appel depuis le constructeur du HomeController.    /// 
    /// </summary>
    public class MyService : IMyService
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITranscientOperation _transcientOperation;
        private readonly IScopedOperation _scopedOperation;

        public MyService(ISingletonOperation singletonOperation, ITranscientOperation transcientOperation, IScopedOperation scopedOperation)
        {
            _singletonOperation = singletonOperation;
            _transcientOperation = transcientOperation;
            _scopedOperation = scopedOperation;
        }

    }
}

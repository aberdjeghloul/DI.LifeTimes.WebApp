using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    public class TranscientOperation : ITranscientOperation
    {
        public Guid Id { get; }
        public TranscientOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}

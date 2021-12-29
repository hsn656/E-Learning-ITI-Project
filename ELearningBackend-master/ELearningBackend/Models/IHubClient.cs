using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningBackend.Models
{
    public interface IHubClient
    {
        Task broadcast();
        Task comment();
    }
}

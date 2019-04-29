using System.Collections.Generic;
using DefaultNamespace;

namespace netcore_webapp.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}
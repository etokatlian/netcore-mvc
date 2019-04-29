using System.Collections.Generic;
using DefaultNamespace;

namespace netcore_webapp.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
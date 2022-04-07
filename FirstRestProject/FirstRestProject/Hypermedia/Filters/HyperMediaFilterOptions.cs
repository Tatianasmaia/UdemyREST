using FirstRestProject.Hypermedia.Abstract;
using System.Collections.Generic;

namespace FirstRestProject.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentRespondeEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}

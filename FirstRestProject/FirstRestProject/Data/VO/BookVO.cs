using FirstRestProject.Hypermedia;
using FirstRestProject.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRestProject.Data.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LaunchDate { get; set; }
        public double Price { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

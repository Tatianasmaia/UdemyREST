//using System.Text.Json.Serialization;
using FirstRestProject.Hypermedia;
using FirstRestProject.Hypermedia.Abstract;
using System.Collections.Generic;

namespace FirstRestProject.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        //Com isto suporta HuperMedia
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace FirstRestProject.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}

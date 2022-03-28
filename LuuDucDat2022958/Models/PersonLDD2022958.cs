using System.ComponentModel.DataAnnotations;

namespace LuuDucDat2022958.Models
{
    public class PersonLDD2022958
    {
        [Key]
        public string PersonId { get; set; }
        public string PersonName { get; set; }
    }
}

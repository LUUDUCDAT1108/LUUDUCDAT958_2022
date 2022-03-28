
using System.ComponentModel.DataAnnotations;

namespace LuuDucDat2022958.Models
{
    public class LDD0958
    {
        [Key]
        public string LDDid { get; set; }
        public string LDDName { get; set; }
        public Boolean LDDGender { get; set; }
    }
}

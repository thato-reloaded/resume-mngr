using backend.Enums;

namespace backend.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }
        //relations
        public ICollection<Job> Jobs { get; set; }
    }
}

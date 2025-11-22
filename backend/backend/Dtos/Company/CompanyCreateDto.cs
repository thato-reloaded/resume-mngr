using backend.Enums;

namespace backend.Dtos.Company
{
    public class CompanyCreateDto
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }
    }
}

using AutoMapper;
using backend.Dtos.Company;
using backend.Entities;

namespace backend.AutoMapperConfig
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            #region Candidate
            #endregion

            #region Company
            CreateMap<CompanyCreateDto, Company>();
            #endregion

            #region Job
            #endregion
        }
    }
}

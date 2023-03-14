using AutoMapper;
using CalculatorInterview.BLL.Dto;
using CalculatorInterview.Web.Dto;

namespace CalculatorInterview.Mapping
{
    public class DtoProfiles : Profile
    {
        public DtoProfiles()
        {
            CreateMap<CalculateDto, ACalculatorBllDto>();
            CreateMap<CalculateDto, BCalculatorBllDto>();
            CreateMap<CalculateDto, CCalculatorBllDto>();
        }
    }
}

using AutoMapper;
using ModularCrm.Ordering.Entities;
using Volo.Abp.AutoMapper;

namespace ModularCrm.Ordering;

public class OrderingApplicationAutoMapperProfile : Profile
{
    public OrderingApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Order, OrderDto>()
            .Ignore(x => x.ProductName); // New line
    }
}

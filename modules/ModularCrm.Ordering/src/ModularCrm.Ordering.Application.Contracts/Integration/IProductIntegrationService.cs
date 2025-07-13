using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModularCrm.Products;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace ModularCrm.Ordering;

[IntegrationService]
public interface IProductIntegrationService : IApplicationService
{
    Task<List<ProductDto>> GetProductsByIdsAsync(List<Guid> ids);
}
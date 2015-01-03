using System.Collections.Generic;
using System.Threading.Tasks;
using SoFTLibrary.Framework.ComponentModels.DataModel;

namespace SoFTLibrary.Framework.Infrastructure.ProviderDataServices.ServiceRepository
{
    public interface ISampleRepository
    {
        Task<IEnumerable<MsSerialNoModel>> GetAllSerialNo();
        Task<IEnumerable<BarangModel>> GetBarang();
        Task<BarangModel> GetBarangByKode();
    }
}
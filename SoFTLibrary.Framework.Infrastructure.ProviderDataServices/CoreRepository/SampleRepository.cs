using System.Collections.Generic;
using System.Threading.Tasks;
using SoFTLibrary.Framework.ComponentModels.DataModel;
using SoFTLibrary.Framework.DataContext.MappingDataContext;
using SoFTLibrary.Framework.Infrastructure.ProviderDataServices.ServiceRepository;

namespace SoFTLibrary.Framework.Infrastructure.ProviderDataServices.CoreRepository
{
    public class SampleRepository : ISampleRepository
    {
        private readonly SampleWrapper _dataWrapper;

        public SampleRepository()
        {
            _dataWrapper = new SampleWrapper();
        }

        public async Task<IEnumerable<MsSerialNoModel>> GetAllSerialNo() 
        {
            return await _dataWrapper.GetSerialNo<MsSerialNoModel>();
        }

        public async Task<IEnumerable<BarangModel>> GetBarang() 
        {
            return await _dataWrapper.GetBarang<BarangModel>();
        }

        public async Task<BarangModel> GetBarangByKode()
        {
            return await _dataWrapper.GetBarangByKode<BarangModel>();
        }
    }
}

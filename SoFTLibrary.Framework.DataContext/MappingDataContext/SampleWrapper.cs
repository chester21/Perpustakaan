using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SoFTLibrary.Framework.DataContext.Core;

namespace SoFTLibrary.Framework.DataContext.MappingDataContext
{
    public class SampleWrapper : GenericDbProvider
    {
        public async Task<Int32> GetCountBibIndomarc()
        {
            return await MapTotalRowCount("uspGetCountPage_BIBINDOMARCRECDATA");
        }

        public async Task<IEnumerable<T>> GetBarang<T>() where T : class 
        {
            string spname = @"SELECT [KdBarang]
      ,[NmBarang]
      ,[JenisBarang]
      ,[Harga]
      ,[Stock]
      ,[StatusBarang]
      ,[CreatedBy]
      ,[CreatedDate]
      ,[UpdatedBy]
      ,[UpdatedDate]
  FROM [Belajar].[dbo].[TBL_BARANG] ";
            return await MapQueryMultipleResult<T>(spname);
        }

        public async Task<T> GetBarangByKode<T>() where T : class
        {
            string spname = @"SELECT [KdBarang]
                          ,[NmBarang]
                          ,[JenisBarang]
                          ,[Harga]
                          ,[Stock]
                          ,[StatusBarang]
                          ,[CreatedBy]
                          ,[CreatedDate]
                          ,[UpdatedBy]
                          ,[UpdatedDate]
                      FROM [Belajar].[dbo].[TBL_BARANG] WHERE KdBarang = 1";
            return await MapQueryResult<T>(spname);
        }


        public async Task<IEnumerable<T>> GetSerialNo<T>() where T : class
        {
            string spname = @"SELECT TOP 10000
                            SerialNo,
                            ItemCode,
                            OrderType,
                            ItemDescription,
                            ProdStartDateActual,
                            ProdFinishDateActual,
                            ProdStartResource,
                            ProdFinishResource,
                            QCJudgment,
                            QCJudgmentDate,
                            StorageAreaID,
                            StorageDate,
                            DeliveryOrderNo,
                            ProdOrderNo,
                            ProdOrderSeq,
                            ContainerSeq,
                            ContainerNo,
                            StatusID,
                            LastUpdateBy,
                            LastUpdateTime,
                            CreationDate,
                            PlanNumber,
                            LineID,
                            CaseNo,
                            PlanNumberSeq,
                            PlanStuffingDate,
                            ActStuffingDate,
                            SN_Status,
                            SN_Status_Date,
                            SN_Status_Reason,
                            DepartmentID,
                            CSNumber,
                            CSDate,
                            MDSNo,
                            MDSDate,
                            WrappingNo,
                            StatusTransfer,
                            SamplingDate,
                            StatusConfirm,
                            SNType,
                            DepartmentDate,
                            InvoiceNo,
                            Freeze,
                            PackingContentID,
                            BlockedDate,
                            LotID FROM MsSerialNo";
            return await base.MapQueryMultipleResult<T>(spname);
        }

    }





}

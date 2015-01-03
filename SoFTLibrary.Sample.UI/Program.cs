using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoFTLibrary.Framework.ComponentModels.DataModel;
using SoFTLibrary.Framework.Infrastructure.ProviderDataServices.CoreRepository;

namespace SoFTLibrary.Sample.UI
{
    class Program
    {
        private static long TimerTwo { get; set; }

        static void Main(string[] args)
        {
            var task = new Task(TestingPerformanceDal);
            task.Start();
            Console.WriteLine("Application is running......please hold on.");
            task.Wait();
            Console.ReadLine();
        }

        static async void TestingPerformanceDal()
        {

            #region Using Enterprise Library

            var timeEl = await SampleTaskBarang();

            #endregion

            var time2 = await SampleTaskBarangByKode();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Using Ent.Lib  : " + timeEl);
        }

        private static async Task<int> SampleTaskBarang()
        {
            await Task.Delay(1000);
            var repo = new SampleRepository();
            var data = await repo.GetBarang();
            foreach (var x in data)
            {
                Console.WriteLine(x.KdBarang + " - " + x.NmBarang + " - " + x.JenisBarang + " - " + x.Harga);// + " - "+ x.StatusBarang  + " - "+ x.Stock  + " - "+ x.CreatedBy + " - "+ x.CreatedDate + " - "+ x.UpdatedBy + " - "+ x.UpdatedDate);
            }
            return 1;
        }

        private static async Task<int> SampleTaskBarangByKode()
        {
            await Task.Delay(1000);
            var repo = new SampleRepository();
            var x = await repo.GetBarangByKode();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Just One Row Data");
            Console.WriteLine("");
            //foreach (var x in data)
            //{
                Console.WriteLine(x.KdBarang + " - " + x.NmBarang + " - " + x.JenisBarang + " - " + x.Harga);// + " - "+ x.StatusBarang  + " - "+ x.Stock  + " - "+ x.CreatedBy + " - "+ x.CreatedDate + " - "+ x.UpdatedBy + " - "+ x.UpdatedDate);
            //}
            return 1;
        }
        static async Task<int> UsingEnterpriseLibrary()
        {

            var sw = new Stopwatch();
            await Task.Delay(1000);
            sw.Start();
            var repo = new SampleRepository();
            var data = repo.GetAllSerialNo().Result;

            foreach (var codex in data.Select(x => x.ItemCode + "    " + x.SerialNo + "    " + x.OrderType
                                                   + "    " + x.ItemDescription
                                                   + "    " + x.ProdStartDateActual
                                                   + "    " + x.ProdFinishDateActual
                                                   + "    " + x.ProdStartResource
                                                   + "    " + x.ProdFinishResource
                                                   + "    " + x.QCJudgment
                                                   + "    " + x.QCJudgmentDate
                                                   + "    " + x.StorageAreaID
                                                   + "    " + x.StorageDate
                                                   + "    " + x.DeliveryOrderNo
                                                   + "    " + x.ProdOrderNo
                                                   + "    " + x.ProdOrderSeq
                                                   + "    " + x.ContainerSeq
                                                   + "    " + x.ContainerNo
                                                   + "    " + x.StatusID
                                                   + "    " + x.LastUpdateBy
                                                   + "    " + x.LastUpdateTime
                                                   + "    " + x.CreationDate
                                                   + "    " + x.PlanNumber
                                                   + "    " + x.LineID
                                                   + "    " + x.CaseNo
                                                   + "    " + x.PlanNumberSeq
                                                   + "    " + x.PlanStuffingDate
                                                   + "    " + x.ActStuffingDate
                                                   + "    " + x.SNStatus
                                                   + "    " + x.SNStatusDate
                                                   + "    " + x.SNStatusReason
                                                   + "    " + x.DepartmentID
                                                   + "    " + x.CSNumber
                                                   + "    " + x.CSDate
                                                   + "    " + x.MDSNo
                                                   + "    " + x.MDSDate
                                                   + "    " + x.WrappingNo
                                                   + "    " + x.StatusTransfer
                                                   + "    " + x.SamplingDate
                                                   + "    " + x.StatusConfirm))
            {
                Console.WriteLine(codex);
            }
            TimerTwo = sw.ElapsedTicks;

            var tm1 = (sw.ElapsedTicks / 600);
            sw.Stop();
            return (Int32)tm1;
        }

    }
}

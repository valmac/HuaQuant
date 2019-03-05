using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SmartQuant;
using SmartQuant.Data;
using SmartQuant.Instruments;
using SmartQuant.Series;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Framework.Installation.QUANTSYS = new DirectoryInfo(@"D:\Source\HuaQuant");
            Framework.Init();
            //Console.WriteLine(Framework.Installation.QUANTSYS.FullName);
            DataManager.Init();
            foreach (Instrument inst in InstrumentManager.Instruments)
            {
                Console.WriteLine(inst.Symbol);
                if (inst.Symbol == "AAPL")
                {
                    IDataSeries bs = inst.GetDataSeries(DataManager.EDataSeries.Daily);
                    foreach (IDataObject data in bs)
                    {
                        Daily daily = (Daily)data;
                        Console.WriteLine(daily.ToString());
                    }
                }

            }
            //if (InstrumentManager.Instruments["Test.000001"]!=null)
            //{
            //    Console.WriteLine("has");
            //    Instrument inst = InstrumentManager.Instruments["Test.000001"];

            //    InstrumentManager.Remove(inst);

            //}
            //Instrument newInst = new Instrument("Test.000001", "CS");
            //newInst.SecurityExchange = "Test";//市场
            //newInst.SecurityID = "000001";//代码
            //newInst.SecurityIDSource = "8";
            //newInst.Save();
            Console.ReadKey();
        }
    }
}

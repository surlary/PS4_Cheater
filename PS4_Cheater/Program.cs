namespace PS4_Cheater
{
    using System;
    using System.Windows.Forms;
    using libdebug;

    internal static class Program
    {
		public static main instance;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			instance = new main();
            Application.Run(instance);
            //test();
            //new TestPS4LIB("").ReadMemory(0, 0, 16);
        }

        private static void test()
        {
            MemoryHelper mh = new TestMemoryHelper(true, 0);
            mh.InitMemoryHandler(MemoryHelper.GetStringOfValueType(ValueType.USHORT_TYPE), "Exact Value", true);
            mh.Alignment = 2;
            mh.ParseFirstValue = true;
            mh.ParseSecondValue = true;
            
            ProcessManager pm = new ProcessManager();
            
            MappedSection sec = new MappedSection();
            sec.Length = 512 * 1024 * 1024;
            sec.Check = true;


            DateTime time = DateTime.Now;
            sec.UpdateResultList(pm, mh, "12", "0", false, true);
            
            Console.WriteLine("total({0}): {1}", sec.ResultList.Count, (DateTime.Now - time).TotalMilliseconds);
            //Console.WriteLine("asdfasdfas");
            //Console.ReadLine();
        }
    }

    class TestMemoryHelper : MemoryHelper
    {
        public TestMemoryHelper(bool defaultProcessID, int processID) : base(defaultProcessID, processID)
        {
        }

        public override byte[] ReadMemory(ulong address, int length)
        {
            DateTime time = DateTime.Now;
            byte[] fuzz = new byte[length];
            new Random().NextBytes(fuzz);
            Console.WriteLine((DateTime.Now - time).TotalMilliseconds);
            return fuzz;
        }
    }
}


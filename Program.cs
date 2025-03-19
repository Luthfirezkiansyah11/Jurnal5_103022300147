namespace Jurnal5_103022300147

{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;


        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            dynamic temp = (dynamic)data;
            dynamic tempDate = (dynamic)DateTime.Now;
            storedData.Add(temp);
            inputDates.Add(tempDate);

        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC {inputDates[i]}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            int c = 22;
            PemrosesData pD = new PemrosesData();
            Console.WriteLine("Angka Terbesar adalah: " + pD.DapatkanNilaiTerbesar(10, 30, 22));


            SimpleDataBase<int> sgc = new SimpleDataBase<int>();

            sgc.AddNewData(10);
            sgc.AddNewData(20);
            sgc.AddNewData(30);

            sgc.PrintAllData();

        }
    }
}

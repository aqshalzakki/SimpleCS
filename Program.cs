// See https://aka.ms/new-console-template for more information

namespace Simple
{
    class Simple
    {
        public string name = "John Doe";

        static int Main(string[] args)
        {
            Console.WriteLine(GetDayName(2));
            return 0;
        }

        static string GetDayName(int num)
        {
            string[] dayNames = {
                "Senin",
                "Selasa",
                "Rabu",
                "Kamis",
                "Jumat",
                "Sabtu",
                "Minggu"
            };
            return dayNames[num];
        }
    }

}
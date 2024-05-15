
namespace GenericInstnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // listeye manuel eklemeler yapar listenin uzunluğunu döndürür

            MyList<string> cities = new MyList<string>();
            cities.Add("ankara");
            cities.Add("mersin");
            cities.Add("adana");

            Console.WriteLine("eklemelerden sonra liste boyutu :"+cities.MyCount);

            foreach (var item in cities.Values)            //liste ekrana yazdırılır
            {
                Console.WriteLine(item);
            }
        }
    }
}
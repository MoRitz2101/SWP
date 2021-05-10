namespace SWP_Uebung1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Print.Instance.Log("Prgramm started not Lazy");

           //LazyPrint.SingleInstance.LogMessage("Programm started Lazy");

        }
    }


}


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 0;
            int a = 0;
            string s=null ;
            //StreamReader streamRdrr=null;
            //try
            //{
            //    streamRdrr = new StreamReader("info.txt");
            //    f = double.Parse(streamRdrr.ReadLine());
            //    a = int.Parse(streamRdrr.ReadLine());
            //    s = streamRdrr.ReadLine();

            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (streamRdrr != null)
            //    {
            //        streamRdrr.Close();
            //    }
            //}

            using (StreamReader streamRdrr = new StreamReader("info.txt"))
            {
                //try
                //{
                    f = double.Parse(streamRdrr.ReadLine());
                    a = int.Parse(streamRdrr.ReadLine());
                    s = streamRdrr.ReadLine();

                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    if (Math.Abs(f - 1E-4) < 1E-3) f = 2.0 / 157;
                //    if (a == 0) a = 5;
                //    if (s == null) s = "My String";

                //}
            }


            using (StreamWriter streamWriter = new StreamWriter("info.txt", true))
            {
                streamWriter.WriteLine("Hello, World!");
                Console.WriteLine("Hello, World!");
                streamWriter.WriteLine($"{f,17:f5}!!!!!!!!!");
                Console.WriteLine($"{f,-17:f5}!!!!!!!!!");
            }
            //streamWriter.Close();
            Console.ReadKey();
        }
    }
}

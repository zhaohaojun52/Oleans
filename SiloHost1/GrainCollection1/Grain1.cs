using System;
using System.Threading.Tasks;
using Orleans;
using MyGrainInterfaces1;

namespace GrainCollection1
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    public class Grain1 : Grain, IGrain1
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Waiting for Orleans Silo to start. Press Enter to proceed...");
            Console.ReadLine();

            Orleans.GrainClient.Initialize("DevTestClientConfiguration.xml");
        }*/
        public Task<string> SayHello(int i)
        {
            return Task.FromResult("Hello World! Grain id:"+i);
        }
    }
  
}

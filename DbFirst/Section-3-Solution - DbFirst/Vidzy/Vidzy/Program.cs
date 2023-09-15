using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new VidzyDbContext();

            db.AddVideo("Video 1", DateTime.Today, 2, (byte)Classification.Platinum);

            Console.ReadKey();
        }
    }
}

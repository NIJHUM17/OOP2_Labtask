using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab02_Interface02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ipod : ");
            Ipod ip1 = new Ipod();

            ip1.Switch(true);
            ip1.Play(true);
            ip1.PlayNext();
            ip1.PlayPrevious();
            ip1.SetVolume(12);

            Console.WriteLine();
            
            Console.WriteLine("Phone : ");
            Phone ph1 = new Phone();

            ph1.Switch(true);
            ph1.Retune(89.6);
            ph1.SetVolume(11);
            ph1.ChangeChannel();

            Console.WriteLine();
        }
    }
}

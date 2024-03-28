using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    internal class class_sayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public class_sayaTubeVideo(string tittle)
        {
            Random randomId = new Random();
            this.id = randomId.Next();
            this.title = tittle;
            playCount = 0;
            id = randomId.Next(10000, 99999);

            try
            {
                this.title = title;
                if (title == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (tittle.length > 200)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentNullException n_exc)
            {
                Console.WriteLine(n_exc.Message);
            }
            catch (ArgumentOutOfRangeException ofvexc)
            {
                Console.WriteLine(ofvexc.Message);
            }
        }
        public void increasePlayoucount(int increment)
        {
            try
            {
                checked
                {
                    playCount += increment;
                    if (playCount + increment > 25000000) throw new ArgumentException();
                }
            }
            catch (ArgumentException arger)
            {
                Console.WriteLine(arger.Message);
            }

        }
        public void printVideoDetails()

        {
            System.Console.WriteLine("id : " + id + "\n" + "judul: " + title + "\n" + "Play count: " + playCount + "\n");

        }
        public int getPlayoucount() { return playCount;}

    }









}

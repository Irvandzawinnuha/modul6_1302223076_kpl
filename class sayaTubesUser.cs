using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6
{
    internal class class_sayaTubesUser
    {
        private int id;

        private List<class_sayaTubeVideo> uploadedVideos;
        public string username;

        public class_sayaTubesUser(string nama)
         {
            this.username = nama;
            Random randomId = new Random();
            this.id = randomId.Next();
            this.uploadedVideos =  new List<class_sayaTubeVideo>();


        }
       public  int getTotalVideoPlayCount()
        {
            int total = 0;  
            for (int i = 0; i < this.uploadedVideos.Count; i++)
            {
                total += this.uploadedVideos[i].getPlayoucount();
            }
            return total;
        }
        public void addVideo(class_sayaTubeVideo video)
        {
         this.uploadedVideos.Add(video);
        }
        public void printAllVideoPlaycoubnt()
        {
            Console.WriteLine("user" + username);
           
            for (int i = 0; i < this.uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video" + i+ "judul: " + this.uploadedVideos[i].printVideoDetails);
            }
        }



    }
}

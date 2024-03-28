using modul6;

internal class Program
{
    private static void Main(string[] args)
    {
        class_sayaTubeVideo vid0 = new class_sayaTubeVideo("Dragon ball");
        class_sayaTubeVideo vid1 = new class_sayaTubeVideo("Kungfu panda");
        class_sayaTubeVideo vid2 = new class_sayaTubeVideo("Spiderman ");
        class_sayaTubeVideo vid3 = new class_sayaTubeVideo("Danur");
        class_sayaTubeVideo vid4 = new class_sayaTubeVideo("Avatar");
        class_sayaTubeVideo vid5 = new class_sayaTubeVideo("KKN desa penari ");
        class_sayaTubeVideo vid6 = new class_sayaTubeVideo("Air mata ujung sajadah ");
        class_sayaTubeVideo vid7 = new class_sayaTubeVideo("Guardian Galaxy 2 ");
        class_sayaTubeVideo vid8 = new class_sayaTubeVideo("Siksa Neraka");
        class_sayaTubeVideo vid9 = new class_sayaTubeVideo("172 Days");
        class_sayaTubesUser akun = new class_sayaTubesUser("irvan dzawin nuha ");
        akun.addVideo(vid0);
        akun.addVideo(vid1);
        akun.addVideo(vid2);
        akun.addVideo(vid3);
        akun.addVideo(vid4);
        akun.addVideo(vid5);
        akun.addVideo(vid6);
        akun.addVideo(vid7);
        akun.addVideo(vid8);
        akun.addVideo(vid9);

    }
}
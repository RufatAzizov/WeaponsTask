using System.Security.Cryptography.X509Certificates;

namespace Game
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon Ak47 = new Weapon(30,1,4,true);
            //Weapon MP4 = new Weapon(18, 18, 2, false);
            bool Run = true;
            Console.WriteLine($"Press 1 - to shoot\n" +
                        $"Press 2 - to spray\n" +
                        $"Press 3 - to check remain ammo\n" +
                        $"Press 4 - to reload\n" +
                        $"Press 5 - to change fire mode\n" +
                        $"Press 6 - to stop the program\n" +
                        $"Press 0 - to get info about your weapon\n");
            do
            {
                byte key = Convert.ToByte(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Ak47.Shoot();
                        break;
                    case 2:
                        Ak47.Fire();
                        break;
                    case 3:
                        Ak47.GetRemainBulletCount();
                        break;
                    case 4:
                        Ak47.Reload();
                        break;
                    case 5:
                        Ak47.ChangeFireMode();
                        break;
                    case 6:
                        Run = false;
                        break;
                    case 0:
                        Ak47.Info();
                        break;
                }

            }

            while (Run);

            
            

            

        }
    }
}
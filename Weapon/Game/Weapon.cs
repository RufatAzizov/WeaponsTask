using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Weapon
    {
        public uint clipSize { get; set; }
        public uint bulletsInClip { get; set; }
        public int sprayTime { get; set; }
        public bool fireMode { get; set; } // auto if true

        #region Methods
        public void Shoot() //done partly
        {
            
            
            if (bulletsInClip == 0) { Console.WriteLine("\nYou're out of ammo\n"); }
            else {
                Console.WriteLine("\nYou did shoot\n");
                bulletsInClip--;
            }
        }

        public void Fire() //done partly
        {
            if (fireMode == true && bulletsInClip < clipSize && bulletsInClip != 0)
            {
                Console.WriteLine("\nYou shot all rounds in " + (Convert.ToDouble(bulletsInClip)/clipSize*sprayTime) + " seconds\n");
                bulletsInClip = 0;
            }
            else if (fireMode == true && bulletsInClip == clipSize)
            {
                Console.WriteLine("\nYou shot all rounds in " + sprayTime + " seconds\n");
                bulletsInClip = 0;

            }
            else if (fireMode == false) { Shoot(); }
            else if (bulletsInClip == 0) { Console.WriteLine("\nYou're out of ammo\n"); }

        } //2

        public void Reload() //done
        {
            bulletsInClip = clipSize;
            Console.WriteLine($"\nReloaded, current ammo is {clipSize}\n");
        } 

        public void ChangeFireMode() //done
        {
            if (fireMode == false)
            {
                fireMode = true;
                Console.WriteLine("Switched to Auto mode\n");
            }
            else if ( fireMode == true)
            {
                fireMode = false;
                Console.WriteLine("Switched to Single fire mode\n");
            }
        } //5

        public void GetRemainBulletCount()
        {
            if (bulletsInClip > 1)
            {
                Console.WriteLine($"\nRemain ammo are {bulletsInClip} rounds\n");
            }
            else if (bulletsInClip == 0)
            {
                Console.WriteLine("\nYou're out of ammo\n");
            }
            else { Console.WriteLine($"\nRemain ammo is {bulletsInClip} round\n"); }
        } 

       

        public void Info() //done
        {
            string firemode;
            if (fireMode == true)
            {
                firemode = "Auto";
            }
            else firemode = "Single";
            
            Console.WriteLine($"\nWeapon info:\n" +
                    $"\nClip size is {clipSize} \n" +
                    $"Current ammo is {bulletsInClip} \n" +
                    $"Shoots {clipSize} rounds in {sprayTime} seconds\n" +
                    $"Current fire mode is {firemode}\n");

        }

        
       

        
        #endregion

        public Weapon(uint ClipSize, uint BulletsInClip, int SprayTime, bool FireMode)
        {
            clipSize = ClipSize;
            bulletsInClip = BulletsInClip;
            sprayTime = SprayTime;
            fireMode = FireMode;
        }
    }
}

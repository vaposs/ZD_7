using System;

namespace ZD_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {

        }
    }

    class Weapon
    {
        private const int MinBullets = 0;
        private const int CostShotingBullets = 1;

        private int _bullets;

        public bool CanShoot() => _bullets > MinBullets;

        public void Shoot() => _bullets -= CostShotingBullets;
    }
}

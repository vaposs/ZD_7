using System;

namespace ZD_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Weapon weapon = new Weapon(-1);
            //Weapon weapon = new Weapon(5);
        }
    }

    class Weapon
    {
        private const int CostPerShot = 1;

        private int _bullets;

        public int MaxBullets { get; }

        public Weapon(int maxBullets)
        {
            if (maxBullets < 0)
            {
                throw new ArgumentException("Максимальное количество пуль не может быть отрицательным", nameof(maxBullets));
            }

            MaxBullets = maxBullets;
            _bullets = maxBullets;
        }

        public int Bullets => _bullets;
        public bool CanShoot => _bullets >= CostPerShot;

        public void Shoot()
        {
            if (CanShoot == true)
                _bullets -= CostPerShot;
        }
    }
}
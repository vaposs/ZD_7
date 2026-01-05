using System;

namespace ZD_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Weapon weapon = new Weapon(-1);
        }
    }

    class Weapon
    {
        private const int CostPerShot = 1;

        private int _maxBullets;
        private int _bullets;

        public Weapon(int maxBullets)
        {
            if (maxBullets < 0)
                throw new ArgumentException("Максимальное количество пуль не может быть отрицательным", nameof(maxBullets));

            _maxBullets = maxBullets;
            _bullets = maxBullets;
        }

        public int Bullets => _bullets;
        public int MaxBullets => _maxBullets;
        public bool CanShoot => _bullets >= CostPerShot;

        public void Shoot()
        {
            if (!CanShoot)
            _bullets -= CostPerShot;
        }
    }
}

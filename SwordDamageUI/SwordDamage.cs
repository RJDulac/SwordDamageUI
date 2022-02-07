using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageUI
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultipler = 1m;
        public int FlamingDamage = 1;
        public int Damage = 0;

        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultipler) + BASE_DAMAGE + FLAME_DAMAGE;
        }

        public void SetMagic(bool isMagic)
        {
            if(isMagic)
            {
                MagicMultipler = 1.75m;
            }
            else
            {
                MagicMultipler = 1;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if(isFlaming)
            {
                Damage *= FLAME_DAMAGE;
            }
        }

    }
}

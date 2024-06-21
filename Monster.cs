using Module_17.Factories;
using Module_17.Movements;
using Module_17.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    internal class Monster
    {
        private IWeapon weapon;
        private IMovement movement;

        public Monster(IMonsterFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Move()
        {
            movement.Start();
        }
        public void Hit()
        {
            weapon.Attack();
        }
    }
}

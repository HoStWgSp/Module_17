﻿using Module_17.Movements;
using Module_17.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17.Factories
{
    internal interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Deef.GameEngine
{
    public class Monster
    {
        public MonsterMovementSystem MonsterMovementSystem;
        public MovementHelper Mover;
        public char MapSymbol;
        public Monster(World world, int placeOnMap, MapWithDetails map, char mapSymbol)
        {
            Random rdm = new Random();
            MonsterMovementSystem = new MonsterMovementSystem(world, rdm.Next(2,9));
            Mover = new MovementHelper(map, mapSymbol, world);
            Mover.MoveTo(placeOnMap);
        }
    }
}

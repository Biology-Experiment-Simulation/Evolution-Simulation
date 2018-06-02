﻿/*
Copyright (C) 2018 Matej Gomboc (https://github.com/MatejGomboc/Evolution-Simulation)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    partial class Animal
    {
        public const uint stackDepth = 1000;

        public enum Weapon
        {
            PAPER,
            ROCK,
            SCISSORS
        }

        public class ProgramCounter
        {
            public uint routineIndx;
            public uint instructionIndx;

            public ProgramCounter()
            {
                routineIndx = 0;
                instructionIndx = 0;
            }
        }

        public float health
        {
            get;
            private set;
        }

        public List<uint> claimants
        {
            get;
            private set;
        }

        public List<Weapon> claimantWeapons
        {
            get;
            private set;
        }

        public int[] memoryInt
        {
            get;
            private set;
        }

        public float[] memoryFloat
        {
            get;
            private set;
        }

        public Program program
        {
            get;
            private set;
        }

        public ProgramCounter programCounter
        {
            get;
            private set;
        }

        public Stack<ProgramCounter> stack
        {
            get;
            private set;
        }

        public Animal(Program newProgram, int[] newMemoryInt, float[] newMemoryFloat)
        {
            health = 1.0f;
            claimants = new List<uint>();
            claimantWeapons = new List<Weapon>();
            program = newProgram;
            memoryInt = newMemoryInt;
            memoryFloat = newMemoryFloat;
            stack = new Stack<ProgramCounter>();
            programCounter = new ProgramCounter();
        }

        public void eatFood(float foodEnergy)
        {
            health += foodEnergy;
        }
    }
}

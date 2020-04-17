using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratorijskeVježbe2
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGenerator;
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator.GetInstance();
        }

        //public Die(int numberOfSides, Random random)
        //{
        //    this.numberOfSides = numberOfSides;
        //    this.randomGenerator = random;
        //}

        public int Roll()
        {
            //int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);
            int rolledNumber = randomGenerator.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }

    }
}

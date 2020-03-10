using System;

namespace gun_master_9000
{
    class Cat : Target
    {

        private bool dead = false;
        private int lifes;

        //Constructor, input total lifes.
        public Cat(int lifes) {
            this.lifes = lifes;

        }

        public void Shot()
        {
            if (lifes == 0)
            {
                this.dead = true;
            } else {
                lifes -= 1;
            }
        }

        public bool IsDead()
        {
            return this.dead;

        }

    }
}
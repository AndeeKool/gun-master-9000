using System;

namespace gun_master_9000
{
    class NinjaStudent : DodgingTarget
    {
        bool isDodging = false;
        bool dodgeSkip = true;
        bool dead = false;
        public void Shot()
        {
            if (this.isDodging)
            {
                if (dodgeSkip == true)
                {
                    this.Miss();
                    dodgeSkip = false;
                } else {
                    this.Hit();
                    dodgeSkip = true;
                }
            }
            else
            {
                this.Hit();
            }
        }

        public bool IsDead()
        {
            return dead;
        }

        public void Dodge()
        {
            isDodging = true;
        }

        public void Hit()
        {
            this.dead = true;
        }

        public void Miss()
        {
            this.isDodging = false;
        }

    }

}
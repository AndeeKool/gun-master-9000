using System;

namespace gun_master_9000
{
    class NinjaMaster : DodgingTarget
    {
        bool isDodging = false;
        bool dead = false;
        bool alwaysDodge;

        public NinjaMaster(bool alwaysDodge) {
            this.alwaysDodge = alwaysDodge;
        }
        
        public void Shot() {

            if (alwaysDodge)
            {
                this.Dodge();
            }

            if (this.isDodging) {
                this.Miss();
            } else {
                this.Hit();
            }
        }

        public bool IsDead() {
            return dead;
        }

        public void Dodge() {
            isDodging = true;
        }

        public void Hit() {
            this.dead = true;
        }

        public void Miss() {
            this.isDodging = false;
        }
    }
}
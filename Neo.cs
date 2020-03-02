using System;

namespace gun_master_9000 {
    class Neo : DodgingTarget {

        bool isDodging = false;
        bool dead = false;
        public void Shot() {
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
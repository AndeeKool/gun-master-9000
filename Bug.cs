using System;

namespace gun_master_9000 {
    class Bug : Target {

        private bool dead = false;

        public void Shot() {
            this.dead = true;
        }

        public bool IsDead() {
            return this.dead;

        }

    }
}
using System;

namespace gun_master_9000{
    class Gun : Target {
        string name;

        int capacity;

        protected int rounds = 0;

        public Gun(string name, int capacity) {
            this.name = name;
            this.capacity = capacity;

        }

        public void Shoot(Target target) {
            if (target == null) {
                throw new System.ArgumentException("Target can't be null", "target");
            }

            if (rounds > 0) {
                target.Shot();
                rounds--;
            } else {
                throw new System.InvalidOperationException("Tryng to shoot a gun without bullets");
            }
        }

        virtual public void Reload() {
            this.rounds = this.capacity;

        }

        public int GetRemainingRounds() {
            return this.rounds;
        }

        public void Shot() {

        }

        public bool IsDead() {
            return false;
        }
        
    }
}
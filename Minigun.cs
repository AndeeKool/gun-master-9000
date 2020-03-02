using System;

namespace gun_master_9000
{
    class Minigun : Gun {
        public Minigun(string name, int capacity) : base(name, capacity) {
            this.rounds = capacity;
        }

        override public void Reload() {
            throw new System.InvalidOperationException("Minigun can't be reloaded.");
        }
    }

}
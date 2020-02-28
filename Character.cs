using System;

namespace gun_master_9000
{
    class Character
    {

        public string name;

        public Gun gun;

        //Constructor method, always public and class name.
        public Character(string name)
        {
            this.name = name;

        }

        public void Equip(Gun gun) {
            this.gun = gun;
        }

        public void Shoot(Target target) {
            if (this.gun == null) {
                throw new System.InvalidOperationException("Character can't shoot without a gun.");
            }
            try {
                this.gun.Shoot(target);
            } catch (System.InvalidOperationException ex) {
                Console.WriteLine("*gun clicks*");
            }
        }
    }
}
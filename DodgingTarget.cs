using System;

namespace gun_master_9000{
    interface DodgingTarget : Target {
        void Dodge();

        void Hit();

        void Miss();
    }
}
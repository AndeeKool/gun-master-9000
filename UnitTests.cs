using System;
using NUnit.Framework;

namespace gun_master_9000
{
    [TestFixture]
    class UnitTests
    {

        [Test, Description("Character without Gun can't shoot.")]
        public void CharacterWithoutGunTest()
        {
            Bug bug = new Bug();
            Character john = new Character("John");
            Exception ex = Assert.Throws<System.InvalidOperationException>(
                () =>
                {
                    john.Shoot(bug);
                }
            );

            Assert.That(ex.Message, Is.EqualTo("Character can't shoot without a gun."));
        }

        [Test, Description("Character with gun and without target can't shoot.")]
        public void CharacterWithoutTargetTest()
        {
            Character john = new Character("John");
            Gun revolver = new Gun("Revolver", 6);
            john.Equip(revolver);
            Exception ex = Assert.Throws<System.ArgumentException>(
                () =>
                {
                    john.Shoot(null);
                }
            );
        }


        [Test, Description("Character with gun and with target but without reloading can't shoot.")]
        public void CharacterShootAfterReloadTest()
        {
            Character john = new Character("John");
            Gun revolver = new Gun("Revolver", 8);
            john.Equip(revolver);
            Bug bug = new Bug();

            john.Shoot(bug);
            Assert.That(bug.IsDead(), Is.EqualTo(false));

            john.Reload();
            john.Shoot(bug);
            Assert.That(bug.IsDead(), Is.EqualTo(true));
        }
    }
}
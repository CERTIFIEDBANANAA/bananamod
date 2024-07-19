using System;
using System.Collections.Generic;
using System.Text;

namespace BananaMenu.mods
{

    internal class BananaBoost
    {
        public static void BananaBoostMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }
    }
}
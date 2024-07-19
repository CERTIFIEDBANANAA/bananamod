
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BananaMenu.Mods
{
    internal class BananaTeleport
    {
        public static void BananaTeleportmod()
            {
                Vector3 forward = GorillaLocomotion.Player.Instance.headCollider.transform.forward;
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 999999f;

           }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BananaMenu.Mods
{
    internal class BananaFly
    {
        public static void Bananaflymod()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }

}

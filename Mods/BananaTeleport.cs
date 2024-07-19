using System;
using UnityEngine;

namespace BananaMenu.Mods
{
    internal class BananaTeleport
    {
        public static void OnLeftTriggerPressed()
        {
            BananaTeleportmod();
        }
        public static void BananaTeleportmod()
        {
            // Get the forward direction of the player's head collider
            Vector3 forward = GorillaLocomotion.Player.Instance.headCollider.transform.forward;

            // Set a distance for teleportation
            float teleportDistance = 10.0f; // Adjust this value as needed

            // Calculate the target position by adding the forward direction multiplied by the teleport distance to the player's current position
            Vector3 targetPosition = GorillaLocomotion.Player.Instance.transform.position + forward * teleportDistance;

            // Teleport the player to the target position
            GorillaLocomotion.Player.Instance.transform.position = targetPosition;

            // Optionally, reset the player's jump speed if it was modified
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 10.0f; // Adjust this value as needed
        }
    }
}

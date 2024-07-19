using UnityEngine;

namespace BananaMenu.Mods
{
    internal class BananaExpansion : MonoBehaviour
    {
        void Update()
        {
            // Check for the left trigger press (this can be customized to the specific input method)
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("Left Shift pressed");
                OnLeftTriggerPressed();
            }
        }

        // Define a method to be called when the left trigger is pressed
        public static void OnLeftTriggerPressed()
        {
            // Call BananaExpansionMod regardless of conditions
            BananaExpansionMod();
        }

        public static void BananaExpansionMod()
        {
            // Check if GorillaParent.instance exists, if not, find all instances
            GorillaParent[] gorillaParents = GameObject.FindObjectsOfType<GorillaParent>();

            foreach (var gorillaParent in gorillaParents)
            {
                Debug.Log("Found GorillaParent: " + gorillaParent.name);

                if (gorillaParent.vrrigs != null)
                {
                    foreach (var vrrig in gorillaParent.vrrigs)
                    {
                        if (vrrig != null && vrrig.mainSkin != null && vrrig.mainSkin.material != null)
                        {
                            // Check if vrrig's mainSkin.material name contains "fected"
                            if (vrrig.mainSkin.material.name.ToLower().Contains("fected"))
                            {
                                Debug.Log("Infected monkey found: " + vrrig.name);

                                // Disable movement for this infected monkey
                                Rigidbody monkeyRigidbody = vrrig.GetComponent<Rigidbody>();
                                if (monkeyRigidbody != null)
                                {
                                    monkeyRigidbody.constraints = RigidbodyConstraints.FreezeAll;
                                    Debug.Log("Movement frozen for: " + vrrig.name);
                                }
                                else
                                {
                                    Debug.LogWarning("Rigidbody component not found on monkey: " + vrrig.name);
                                }
                            }
                        }
                        else
                        {
                            Debug.LogWarning("vrrig, main skin, or material is null for vrrig: " + (vrrig != null ? vrrig.name : "null"));
                        }
                    }
                }
                else
                {
                    Debug.LogWarning("vrrigs array is null for GorillaParent: " + gorillaParent.name);
                }
            }
        }
    }

    // Assuming there is a GorillaParent class definition like below
    public class GorillaParent : MonoBehaviour
    {
        public VRRig[] vrrigs;
    }

    // Assuming there is a VRRig class definition like below
    public class VRRig : MonoBehaviour
    {
        public SkinnedMeshRenderer mainSkin;
    }
}

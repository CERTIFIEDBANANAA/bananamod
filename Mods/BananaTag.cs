using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.mods
{
    internal class BananaTag
    {
        public static void BananaTagMod()
        {
            foreach (var vrrig in GorillaParent.instance.vrrigs)
                if (!vrrig.mainSkin.material.name.Contains("fected") && GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected"))
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = vrrig.transform.position;
                    GorillaTagger.Instance.leftHandTransform.position = vrrig.transform.position;
                }
        }
    }
}
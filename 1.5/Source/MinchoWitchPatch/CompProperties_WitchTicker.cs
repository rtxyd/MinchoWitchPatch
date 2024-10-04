using RimWorld;
using System.Collections.Generic;
using Verse;

namespace MinchoWitchPatch
{
    public class CompProperties_WitchTiker : HediffCompProperties
    {
        public CompProperties_WitchTiker()
        {
            this.compClass = typeof(WitchTiker);
        }
        public override void ResolveReferences(HediffDef parentDef)
        {
            base.ResolveReferences(parentDef);
        }
    }
}

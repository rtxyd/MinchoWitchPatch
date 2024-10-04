using RimWorld;
using System.Collections.Generic;
using Verse;

namespace MinchoWitchPatch
{
    public class CompProperties_WitchTicker : HediffCompProperties
    {
        public CompProperties_WitchTicker()
        {
            this.compClass = typeof(WitchTiker);
        }
        public override void ResolveReferences(HediffDef parentDef)
        {
            base.ResolveReferences(parentDef);
        }
    }
}

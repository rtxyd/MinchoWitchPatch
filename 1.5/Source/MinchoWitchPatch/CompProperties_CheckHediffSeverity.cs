using RimWorld;
using System.Collections.Generic;
using Verse;

namespace MinchoWitchPatch
{
    public class CompProperties_CheckHediffSeverity : HediffCompProperties
    {
        public HediffDef targetHediff;
        public Dictionary<float, List<AbilityDef>> triggers;

        public CompProperties_CheckHediffSeverity()
        {
            this.compClass = typeof(CheckHediffSeverity);
        }
        public override void ResolveReferences(HediffDef parentDef)
        {
            base.ResolveReferences(parentDef);
        }
    }
}

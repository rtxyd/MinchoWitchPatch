using RimWorld;
using System.Collections.Generic;
using Verse;

namespace MinchoWitchPatch
{
    public class CompProperties_CheckHediffSeverity : HediffCompProperties
    {
        public HediffDef targetHediff;
        public Dictionary<float, List<AbilityDef>> triggers;
        //private float[] triggerPoints;
        public int tickInterval = 500;

        public CompProperties_CheckHediffSeverity()
        {
            this.compClass = typeof(CompCheckHediffSeverity);
        }
        public override void ResolveReferences(HediffDef parentDef)
        {
            base.ResolveReferences(parentDef);
            //if (triggers != null)
            //{
            //    triggerPoints = triggers.Keys.OrderByDescending(t => t).ToArray();
            //}
        }
    }
}

using Verse;

namespace MinchoWitchPatch
{
    public class CompProperties_CheckHediffSeverity : CompProperties
    {
        public HediffDef targetHediff;
        public HediffDef ownHediff;
        public int tickInterval = 250;

        public CompProperties_CheckHediffSeverity()
        {
            this.compClass = typeof(CompCheckHediffSeverity);
        }
    }
}

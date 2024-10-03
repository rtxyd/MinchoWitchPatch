using Verse;

namespace MinchoWitchPatch
{
    public class CompCheckHediffSeverity : ThingComp
    {
        public CompProperties_CheckHediffSeverity Props => (CompProperties_CheckHediffSeverity)this.props;
        private int tickCounter = 0;

        public override void CompTick()
        {
            tickCounter++;
            if (tickCounter >= Props.tickInterval)
            {
                tickCounter = 0;
                Pawn pawn = this.parent as Pawn;
                if (pawn != null)
                {
                    Hediff targetHediff = pawn.health.hediffSet.GetFirstHediffOfDef(Props.targetHediff);
                    if (targetHediff != null)
                    {
                        float newSeverity = targetHediff.Severity;
                        Hediff ownHediff = pawn.health.hediffSet.GetFirstHediffOfDef(Props.ownHediff);
                        if (ownHediff != null)
                        {
                            ownHediff.Severity = newSeverity;
                        }
                    }
                }
            }
        }
    }
}
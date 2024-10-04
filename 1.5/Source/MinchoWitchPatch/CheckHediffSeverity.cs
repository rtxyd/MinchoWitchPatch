using Verse;

namespace MinchoWitchPatch
{
    public class CheckHediffSeverity : HediffComp
    {
        public CompProperties_CheckHediffSeverity Props => (CompProperties_CheckHediffSeverity)this.props;
        public Hediff targetHediff => this.Pawn.health.hediffSet.GetFirstHediffOfDef(Props.targetHediff);
        private int tickCount = 10;
        private bool end = false;
        public override void CompPostMake()
        {
            if (Props.triggers.TryGetValue(1, out var abilities))
            {
                foreach (var item in abilities)
                {
                    Pawn.abilities.GainAbility(item);
                }
            }
        }
        public override void CompPostTick(ref float severityAdjustment)
        {
            if (end)
            {
                Pawn.health.RemoveHediff(this.parent);
                return;
            }
            tickCount--;
            if (tickCount < 0 && targetHediff?.Severity > this.parent.Severity)
            {
                tickCount = 10;
                if (this.Pawn != null)
                {
                    if (targetHediff != null)
                    {
                        if (targetHediff.Severity <= 6)
                        {
                            for (var i = this.parent.Severity; i <= targetHediff.Severity; i++)
                            {
                                if (Props.triggers.TryGetValue(i, out var abilities))
                                {
                                    foreach (var item in abilities)
                                    {
                                        Pawn.abilities.GainAbility(item);
                                    }
                                }
                            }
                            this.parent.Severity = targetHediff.Severity;
                        }
                        else
                        {
                            for (var i = 1; i <= 6; i++)
                            {
                                if (Props.triggers.TryGetValue(i, out var abilities))
                                {
                                    foreach (var item in abilities)
                                    {
                                        Pawn.abilities.GainAbility(item);
                                    }
                                }
                            }
                            this.parent.Severity = 6;
                            end = true;
                        }
                    }
                }
            }
            Pawn.health.RemoveHediff(this.parent);
        }
        public override void CompExposeData()
        {
            Scribe_Values.Look(ref end, "end", false);
        }
    }
}
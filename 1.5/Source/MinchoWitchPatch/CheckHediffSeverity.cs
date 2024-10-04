using System;
using Verse;

namespace MinchoWitchPatch
{
    public class CheckHediffSeverity : HediffComp
    {
        public static Random random = new Random();
        public CompProperties_CheckHediffSeverity Props => (CompProperties_CheckHediffSeverity)base.props;
        public Hediff targetHediff => base.Pawn.health.hediffSet.GetFirstHediffOfDef(Props.targetHediff);
        private int tickCount = random.Next(100);
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
                return;
            }
            tickCount--;
            if (tickCount < 0)
            {
                tickCount = 2200;
                if (targetHediff != null && targetHediff.Severity > base.parent.Severity)
                {
                    CheckAndGainSkill();
                }
            }
        }
        public void CheckAndGainSkill()
        {
            if (base.Pawn != null)
            {
                if (targetHediff != null)
                {
                    if (targetHediff.Severity <= 6)
                    {
                        for (var i = base.parent.Severity; i <= targetHediff.Severity; i++)
                        {
                            if (Props.triggers.TryGetValue(i, out var abilities))
                            {
                                foreach (var item in abilities)
                                {
                                    Pawn.abilities.GainAbility(item);
                                }
                            }
                        }
                        base.parent.Severity = targetHediff.Severity;
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
                        base.parent.Severity = 6;
                        end = true;
                    }
                }
            }
        }
        public override void CompExposeData()
        {
            Scribe_Values.Look(ref end, "end", false);
        }
    }
}
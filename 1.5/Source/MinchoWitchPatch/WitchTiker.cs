using Verse;

namespace MinchoWitchPatch
{
    public class WitchTiker : HediffComp
    {
        private int ticks = 1000;
        public override void CompPostTick(ref float severityAdjustment)
        {
            ticks--;
            if (ticks < 0)
            {
                Pawn.health.AddHediff(MinchoWitchHediff.Mincho_Witch_Power);
                ticks = 1000;
            }
        }
    }
}
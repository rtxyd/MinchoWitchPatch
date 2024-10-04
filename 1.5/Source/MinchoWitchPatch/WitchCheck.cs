using System.Linq;
using Verse;

namespace MinchoWitchPatch
{
    public class WitchCheck : IExposable
    {
        private bool hasCheck;
        public void ExposeData()
        {
            Scribe_Values.Look(ref hasCheck, "hasCheck", false);
            if (Scribe.mode == LoadSaveMode.LoadingVars && !hasCheck)
            {
                CheckOnce();
            }
        }
        public void CheckOnce()
        {
            foreach (var mw in Find.WorldPawns.AllPawnsAliveOrDead.Where(p => p.kindDef.race.defName == "MinchoWitch").Concat(from a in Find.Maps from b in a.mapPawns.AllHumanlike where b.kindDef.race.defName == "MinchoWitch" select b))
            {
                if (mw.health.hediffSet.HasHediff(MinchoWitchHediff.Mincho_Witch))
                {
                    continue;
                }
                else
                {
                    mw.health.AddHediff(MinchoWitchHediff.Mincho_Witch);
                }
            }
            hasCheck = true;
        }
    }
}

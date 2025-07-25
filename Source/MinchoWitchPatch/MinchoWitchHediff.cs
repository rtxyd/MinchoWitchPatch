using RimWorld;
using Verse;

namespace MinchoWitchPatch
{
    [DefOf]
    public class MinchoWitchHediff
    {
        public static HediffDef MinchoWitch_PsychicCheck;
        static MinchoWitchHediff()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MinchoWitchHediff));
        }
    }
}

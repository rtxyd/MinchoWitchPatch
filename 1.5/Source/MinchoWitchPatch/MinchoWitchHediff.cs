using RimWorld;
using Verse;

namespace MinchoWitchPatch
{
    [DefOf]
    public class MinchoWitchHediff
    {
        public static HediffDef Mincho_Witch;
        static MinchoWitchHediff()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MinchoWitchHediff));
        }
    }
}

using RimWorld;
using Verse;

namespace MinchoWitchPatch
{
    [DefOf]
    public class MinchoWitchHediff
    {
        public static HediffDef Mincho_Witch;
        public static HediffDef Mincho_Witch_Power;
        static MinchoWitchHediff()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(MinchoWitchHediff));
        }
    }
}

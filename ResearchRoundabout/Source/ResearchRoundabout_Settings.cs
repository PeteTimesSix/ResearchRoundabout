using PeteTimesSix.ResearchRoundabout.HarmonyPatches;
using PeteTimesSix.ResearchRoundabout.Rimworld;
using PeteTimesSix.ResearchRoundabout.Rimworld.UI;
using RimWorld;
using System;
using UnityEngine;
using Verse;

namespace PeteTimesSix.ResearchRoundabout
{
    public class ResearchRoundabout_Settings : ModSettings
    {
        public override void ExposeData()
        {
            base.ExposeData();
        }

        internal void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.End();
        }
    }
}
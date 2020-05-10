using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using UnityEngine;
using HarmonyLib;
using System.Reflection;
using RimWorld;
using PeteTimesSix.ResearchRoundabout.Rimworld;
using PeteTimesSix.ResearchRoundabout.HarmonyPatches;

namespace PeteTimesSix.ResearchRoundabout
{
    public class ResearchRoundaboutMod : Mod
    {
        public static ResearchRoundabout_Settings settings;

        public ResearchRoundaboutMod(ModContentPack content) : base(content)
        {
            settings = GetSettings<ResearchRoundabout_Settings>();

            var harmony = new Harmony("PeteTimesSix.ResearchRoundabout");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public override string SettingsCategory()
        {
            return "ResearchRoundabout_ModTitle".Translate();
        }

        public override void DoSettingsWindowContents(Rect inRect) 
        {
            settings.DoSettingsWindowContents(inRect);
            base.DoSettingsWindowContents(inRect);
        }
	}
}

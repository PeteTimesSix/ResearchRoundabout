using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace PeteTimesSix.ResearchRoundabout.Rimworld
{
    public static class Extensions
    {
        public static Rect ContractedBy(this Rect rect, float marginX, float marginY) 
        {
            return new Rect(rect.x + marginX, rect.y + marginY, rect.width - marginX * 2, rect.height - marginY * 2);
        }
	}
}

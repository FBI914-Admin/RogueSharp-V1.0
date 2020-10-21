using System;
using RogueSharpV3Tutorial.Systems;
using RougeLikeSharp.Core;

namespace RougeLikeSharp.Interfaces
{
    public interface IBehavior
    {
        bool Act(Monster monster, CommandSystem commandSystem);
    }
}

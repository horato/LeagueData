using System;
using System.Collections.Generic;
using System.Text;
using LeagueSandbox.GameServer.Core.Data;

namespace LeagueData
{
    public sealed class BaseSpellData : IBaseSpellData
    {
        public string Name { get; }
        public int MaxLevelOverride { get; }
        public IReadOnlyList<int> UpgradeLevels { get; }

        public BaseSpellData(string name, int maxLevelOverride, IReadOnlyList<int> upgradeLevels)
        {
            Name = name;
            MaxLevelOverride = maxLevelOverride;
            UpgradeLevels = upgradeLevels;
        }
    }
}

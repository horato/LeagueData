using System;
using System.Collections.Generic;
using System.Text;
using LeagueSandbox.GameServer.Core.Domain.Enums;

namespace LeagueData
{
    internal class EnumTranslationService
    {
        public PrimaryAbilityResourceType TranslatePrimaryAbilityResourceType(PARType type)
        {
            switch (type)
            {
                case PARType.Mana:
                    return PrimaryAbilityResourceType.Mana;
                case PARType.Energy:
                    return PrimaryAbilityResourceType.Energy;
                case PARType.None:
                    return PrimaryAbilityResourceType.None;
                case PARType.Shield:
                    return PrimaryAbilityResourceType.Shield;
                case PARType.BattleFury:
                    return PrimaryAbilityResourceType.BattleFury;
                case PARType.DragonFury:
                    return PrimaryAbilityResourceType.DragonFury;
                case PARType.Rage:
                    return PrimaryAbilityResourceType.Rage;
                case PARType.Heat:
                    return PrimaryAbilityResourceType.Heat;
                case PARType.Ferocity:
                    return PrimaryAbilityResourceType.Ferocity;
                case PARType.BloodWell:
                    return PrimaryAbilityResourceType.BloodWell;
                case PARType.Gnarfury:
                    return PrimaryAbilityResourceType.GnarFury;
                case PARType.Wind:
                    return PrimaryAbilityResourceType.Wind;
                case PARType.Other:
                    return PrimaryAbilityResourceType.Other;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public LeagueSandbox.GameServer.Core.Domain.Enums.CastType TranslateCastType(LeagueData.CastType castType)
        {
            switch (castType)
            {
                case CastType.Instant:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.CastType.Instant;
                case CastType.Missile:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.CastType.Missile;
                case CastType.ChainMissile:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.CastType.ChainMissile;
                case CastType.ArcMissile:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.CastType.ArcMissile;
                case CastType.CircleMissile:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.CastType.CircleMissile;
                default:
                    throw new ArgumentOutOfRangeException(nameof(castType), castType, null);
            }
        }

        public LeagueSandbox.GameServer.Core.Data.LookAtPolicy TranslateLookAtPolicy(LookAtPolicy policy)
        {
            switch (policy)
            {
                case LookAtPolicy.Off:
                    return LeagueSandbox.GameServer.Core.Data.LookAtPolicy.Off;
                case LookAtPolicy.On:
                    return LeagueSandbox.GameServer.Core.Data.LookAtPolicy.On;
                case LookAtPolicy.Automatic:
                    return LeagueSandbox.GameServer.Core.Data.LookAtPolicy.Automatic;
                default:
                    throw new ArgumentOutOfRangeException(nameof(policy), policy, null);
            }
        }

        public LeagueSandbox.GameServer.Core.Domain.Enums.SelectionPreference TranslateSelectionPreference(SelectionPreference preference)
        {
            switch (preference)
            {
                case SelectionPreference.Invalid:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.SelectionPreference.Invalid;
                case SelectionPreference.Foe:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.SelectionPreference.Foe;
                case SelectionPreference.Friend:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.SelectionPreference.Friend;
                case SelectionPreference.None:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.SelectionPreference.None;
                default:
                    throw new ArgumentOutOfRangeException(nameof(preference), preference, null);
            }
        }

        public LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType TranslateTargetingType(TargetingType type)
        {
            switch (type)
            {
                case TargetingType.Invalid:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null); 
                case TargetingType.Self:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Self;
                case TargetingType.Target:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Target;
                case TargetingType.Area:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Area;
                case TargetingType.Cone:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Cone;
                case TargetingType.SelfAOE:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.SelfAOE;
                case TargetingType.TargetOrLocation:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.TargetOrLocation;
                case TargetingType.Location:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Location;
                case TargetingType.Direction:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Direction;
                case TargetingType.DragDirection:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.DragDirection;
                case TargetingType.LineTargetToCaster:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.LineTargetToCaster;
                case (TargetingType)10:
                    return LeagueSandbox.GameServer.Core.Domain.Enums.TargetingType.Location;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}

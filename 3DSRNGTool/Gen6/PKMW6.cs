﻿namespace Pk3DSRNGTool
{
    public enum EncounterType
    {
        Horde,
        RockSmash,
        PokeRadar,
        FriendSafari,
        CaveShadow,
        Trap,
        OldRod,
        GoodRod,
        SuperRod,
    }

    public class PKMW6 : Pokemon
    {
        public override GameVersion Version { get; protected set; } = GameVersion.Gen6;
        public EncounterType Type { get; private set; }
        public bool IsFishing => Type == EncounterType.OldRod || Type == EncounterType.GoodRod || Type == EncounterType.SuperRod;

        public readonly static PokemonList[] Species_XY =
        {
            new PokemonList
            {
                Text = "Horde",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.Horde, Delay = 174 },
                }
            },
            new PokemonList
            {
                Text = "Rock Smash",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.RockSmash, Delay = 280 },
                }
            },
            new PokemonList
            {
                Text = "Poke Radar",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.PokeRadar, Delay = 14 },
                }
            },
            new PokemonList
            {
                Text = "Fishing",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.OldRod, Delay = 14 },
                    new PKMW6 { Conceptual = true, Type = EncounterType.GoodRod, Delay = 14 },
                    new PKMW6 { Conceptual = true, Type = EncounterType.SuperRod, Delay = 14 },
                }
            },
            new PokemonList
            {
                Text = "Friend Safari",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.FriendSafari, Delay = 6 },
                }
            },
            new PokemonList
            {
                Text = "Cave Shadows",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.CaveShadow, Delay = 78, },
                }
            },
            new PokemonList
            {
                Text = "Trap",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.Trap, Delay = 32, },
                }
            }
        };

        public readonly static PokemonList[] Species_ORAS =
        {
            new PokemonList
            {
                Text = "Horde",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.Horde, Delay = 174 },
                }
            },
            new PokemonList
            {
                Text = "Rock Smash",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.RockSmash, Delay = 280 },
                }
            },
            new PokemonList
            {
                Text = "Fishing",
                List = new[]
                {
                    new PKMW6 { Conceptual = true, Type = EncounterType.OldRod, Delay = 14 },
                    new PKMW6 { Conceptual = true, Type = EncounterType.GoodRod, Delay = 14 },
                    new PKMW6 { Conceptual = true, Type = EncounterType.SuperRod, Delay = 14 },
                }
            },
        };
    }
}

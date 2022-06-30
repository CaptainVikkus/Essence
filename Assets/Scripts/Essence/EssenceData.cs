using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Essence
{
    public enum Class
    {
        Common = 1,         //Common
        Adept, Air, Armour,  Axe, Bat, Bear, Bird, Bow, Cage, Cat,
        Cattle, Chain, Cloth, Coral, Crocodile, Deer, Dog, Duck, Earth, Eye,
        Fire, Fish, Flea, Foot, Fungus, Goat, Grazen, Gun, Hair, Hammer,
        Hand, Heidel, Hunt, Iron, Knife, Lizard, Locust, Magic, Manatee, Might,
        Mouse, Needle, Net, Octopus, Pangolin, Paper, Plant, Rabbit, Rake, Rat,
        Sand, Sceptre, Shark, Shield, Shovel, Sickle, Sloth, Snake, Spear, Spider,
        Staff, Swift, Sword, Technology, Thread, Trap, Tree, Turtle, Vehicle, Wasp,
        Water, Whale, Whip, Wind, Wolf,

        Uncommon = 100,     //Uncommon
        Balance, Blood, Bone, Claw, Cloud, Cold, Dance, Dark, Death, Dust,
        Feast, Flesh, Glass, Growth, Ice, Knowledge, Life, Light, Lightning, Mirror,
        Pure, Son, Venom,

        Rare = 200,         //Rare
        Crystal, Deep, Echo, Gathering, Hunger, Moon, Resolute, Serene, Star, Sun,
        Zeal,

        Epic = 300,         //Epic
        Corrupt, Discord, Elemental, Harmonic, Malign, Omen, Potent, Renewal, Rune, 
        Shimmer,Tentacle,  Wing,

        Legendary = 400,    //Legendary
        Dimension, Myriad, Sin, Vast, Visage, Void,

        Confluence = 1000,  //Confluence
        Action, Alchemy, Ambush, Animate, Anzu, Avatar, Battlefield, Behemoth,
        Boundary, Bounty, Cataclysm, Chaotic, Charlatan, Chimera, Cyborg,
        Dawn, Desolate, Discordant, Doom, Doppelganger, Dragon, Eclipse, Edifice,
        Effigy, Empower, Fertile, Firebird, Force, Forge, Fortress, Garuda, Gate,
        Glimeron, Gorgon, Griffin, Guardian, Harpy, Harvest, Hydra, Immortal,
        Juggernaut, Karmic, Kraken, Leviathan, Lotus, Magitech, Manticore, Master,
        Ministration, Minotaur, Monolith, Mystic, Nebula, Nemesis, Oasis, Ocean,
        Onslaught, Phantasmagoria, Phoenix, Predatory, Prison, Prosperity, 
        Refracting, Resonating, Roc, Sacrifice, Scribe, Serpent, Simulacrum,
        Skirmish, Sky, Soaring, Sovereign, Stellar, Storm, Succubus, Swarm,
        Talisman, Thunderbird, Time, Tranquil, Transfiguration, Transgression,
        Troll, Twilight, Undeath, Unity, Verdant, Vessel, Vision, Volcano, Vortex,
        Weave, Wendigo, Wrath, Ziz
    }

    public enum Ability
    {

    }

    public enum Tier
    {
        Normal = 0,
        Iron,
        Bronze,
        Silver,
        Diamond
    }

    public enum Attribute
    {
        Speed,
        Power,
        Spirit,
        Recovery
    }
}

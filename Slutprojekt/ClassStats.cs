using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ClassStats
    {
        public string raceName                   { get; set; }               // Player race
        public string playerName                 { get; set; }               // Player name
        public int playerEVPoints                { get; set; }               // Defines Player's Current amount of Evaluation Points
        public int playerEXP                     { get; set; }               // Defines Player's Current experience
        public int playerLVL                     { get; set; }               // Defines Player's Current Level
        public int playerCurrency                { get; set; }               // Defines Player's Current currency
        public int playerLength                  { get; set; }               // Defines Player's Length (if (name == love) {playerLength = 160 cm}
        //^^ player ints for miscs 


        public int playerStrength                { get; set; }               // Defines Player's Strength
        public int playerAttack                  { get; set; }               // Defines Player's Attack Damage
        public int playerHP                      { get; set; }               // Defines Player's Amount of Health Points
        public int playerCarryingCapacity        { get; set; }               // Defines Player's Carrying Capacity
        //^^ player Strength ints 


        public int playerVitality                { get; set; }               // Defines Player's Vitality
        public int playerDefense                 { get; set; }               // Defines Player's Defense
        public int playerMagicDefense            { get; set; }               // Defines Player's Magic Defense
        public int playerHealthRegen             { get; set; }               // Defines Player's Health Regeneration (W.I.P)
        //^^ player Vitality ints


        public int playerDexterity               { get; set; }               // Defines Player's Dexterity
        public int playerCriticalDamage          { get; set; }               // Defines Player's Amount of extra damage dealt when successfully critally striking
        public int playerCriticalChance          { get; set; }               // Defines Player's Chance of critically striking
        public int playerAccuracy                { get; set; }               // Defines Player's Accuracy
        //^^ player Dexterity ints


        public int playerIntelligence            { get; set; }               // Defines Player's Intelligence
        public int playerMP                      { get; set; }               // Defines Player's Mana Points
        public int playerManaRegen               { get; set; }               // Defines Player's Mana Regeneration (W.I.P)
        public int playerMagicDamage             { get; set; }               // Defines Player's Magic Damage
        //^^ player Intelligence ints


        public int playerCharisma                { get; set; }               // Defines Player's Charisma
        public int playerCharm                   { get; set; }               // Defines Player's Skill in Charming
        public int playerHaggle                  { get; set; }               // Defines Player's Skill in Haggling
        public int playerBribe                   { get; set; }               // Defines Player's Skill in Bribing


        // Evaluating points into STRENGTH enables the Player to be physically stronger.
        // Affects following substats: ATTACK, HP and CARRYING CAPACITY
        //vv ints for destruktive stats vv
        public int mainStatStrength        { get; set; }
        public int subStatAttack           { get; set; }               // Player deals more damage with melee attacks
        public int subStatHP               { get; set; }               // Player has more HP
        public int subStatCarryingCapacity { get; set; }               // Player can carry more items


        // Evaluating points into VITALITY enables the Player to be more reselient to damage.
        // Affects following substats: DEFENSE, SPECIAL DEFENSE and HEALTH REGENERATION
        // (Has a lower potential "Maxed stat" in order to not be too tanky)
        //vv ints for defensive stats vv
        public int mainStatVitality        { get; set; }
        public int subStatDefense          { get; set; }               // Player takes less damage from physical attacks
        public int subStatMagicDefense     { get; set; }               // Player takes less damage from magic attacks
        public int subStatHealthRegen      { get; set; }               // Player passively regens HP out of combat


        // Evaluating points into DEXTERITY enables the Player to be more "slippery" and precise.
        // Affects following substats: CRITICAL DAMAGE, CRITICAL CHANCE, DODGE CHANCE and ACCURACY
        //vv ints for agile stats vv
        public int mainStatDexterity       { get; set; }
        public int subStatCriticalDamage   { get; set; }               // Player deals more damage when critically striking
        public int subStatCriticalChance   { get; set; }               // Player has a higher possibility of performing a critical strike
        public int subStatDodgeChance      { get; set; }               // Player has a higher chance of dodging an attack starting from 0
        public int subStatAccuracy         { get; set; }               // Player has a lower chance of missing an attack


        // Evaluating points into INTELLIGENCE enables the Player to be more capable with magic spells.
        // Affects following substats: MP, MANA REGEN, MAGIC POWER and 
        //vv ints for Magic based stats vv
        public int mainStatIntelligence    { get; set; }
        public int subStatMP               { get; set; }               // Player has more Mana Points
        public int subStatManaRegen        { get; set; }               // Player continuosly regens MP
        public int subStatMagicDamage      { get; set; }               // Player deals more magic damage.
        public int subStatMagicFind        { get; set; }               // Player might find better magical loot


       // Evaluating points into CHARISMA enables the Player to have a higher chance of convince its target.
       // Affects following substats: Charm, Haggle and Bribe
       //vv ints for personality based statsvv
        public int mainStatCharisma       { get; set; }
        public int subStatCharm           { get; set; }                // Player has a higher chance of charming their target
        public int subStatHaggle          { get; set; }                // Player has a greater haggling ability; reducing prices in the shop
        public int subStatBribe           { get; set; }                // Player has a higher chance of bribing their target
    }
    class chokladboll: ClassStats
    {
        
    }
}

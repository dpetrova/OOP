using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.GameEngine
{
    using Characters;
    using Items;

    public class Engine
    {
        private const int GameTurns = 4;

        protected List<Character> characterList = new List<Character>();
        protected List<Bonus> timeoutItems;

        public virtual void Run()
        {
            ReadUserInput();
            InitializeTimeoutItems();
            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in characterList)
                {
                    if (character.IsAlive)
                    {
                        ProcessTargetSearch(character);
                    }
                }
                ProcessItemTimeout(timeoutItems);
            }
            PrintGameOutcome();
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != "")
            {
                string[] parameters = inputLine.Split(
                    new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = GetCharacterByItem(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public void InitializeTimeoutItems()
        {
            timeoutItems = characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            var command = inputParams[0];
            switch (command)
            {
                case "status":
                    this.PrintCharactersStatus(characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }
        
        protected virtual void CreateCharacter(string[] inputParams)
        {
            var characterClass = inputParams[1].ToLower();
            var id = inputParams[2];
            var x = int.Parse(inputParams[3]);
            var y = int.Parse(inputParams[4]);
            var team = (Team)Enum.Parse(typeof(Team), inputParams[5], true);

            Character character;
            switch (characterClass)
            {
                case "warrior":
                    character = new Warrior(id, x, y, team);
                    this.characterList.Add(character);
                    break;
                case "mage":
                    character = new Mage(id, x, y, team);
                    this.characterList.Add(character);
                    break;
                case "healer":
                    character = new Healer(id, x, y, team);
                    this.characterList.Add(character);
                    break;
            }
        }

        protected void AddItem(string[] inputParams)
        {
            var characterId = inputParams[1];
            var itemClass = inputParams[2].ToLower();
            var itemId = inputParams[3];
            //var character = characterList.FirstOrDefault(c => c.Id == characterId);
            var character = this.GetCharacterById(characterId);

            Item item;
            switch (itemClass)
            {
                case "axe":
                    item = new Axe(itemId);
                    //character.Inventory.Add(item);
                    character.AddToInventory(item);
                    break;
                case "shield":
                    item = new Shield(itemId);
                    character.AddToInventory(item);
                    break;
                case "pill":
                    item = new Pill(itemId);
                    character.AddToInventory(item);
                    //this.timeoutItems.Add((Bonus)item);
                    break;
                case "injection":
                    item = new Injection(itemId);
                    character.AddToInventory(item);
                    //this.timeoutItems.Add((Bonus)item);
                    break;
            }
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = characterList
                .Where(t => IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range)).ToList();
            if (availableTargets.Count == 0)
            {
                return;
            }
            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }
            ProcessInteraction(currentCharacter, target);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY, 
            int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) + 
                (attackerY - targetY) * (attackerY - targetY)
                );
            return distance <= (double)range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);
            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }
            var aliveCharacters = characterList.Where(c => c.IsAlive);
            PrintCharactersStatus(aliveCharacters);
        }
    }
}

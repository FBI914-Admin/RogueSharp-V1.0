using RLNET;


namespace RogueSharpV3Tutorial.Core
{
    public class Player : Actor
    {
        public Player()
        {
            Attack = 2;
            AttackChance = 50;
            Awareness = 15;
            Color = Colors.Player;
            Defense = 2;
            DefenseChance = 40;
            Gold = 0;
            Health = 100;
            MaxHealth = 100;
            Name = "Rogue";
            Speed = 10;
            Symbol = '@';
        }

        public void DrawInventory(RLConsole inventoryConsole)
        {
            inventoryConsole.Print(1, 1, "Armor", RLColor.White);
            inventoryConsole.Print(1, 3, "Head: Plate", RLColor.LightGray);
            inventoryConsole.Print(1, 5, "Body: Chain", RLColor.LightGray);
            inventoryConsole.Print(1, 7, "Hand: None", RLColor.LightGray);
            inventoryConsole.Print(1, 9, "Feet: Leather", RLColor.LightGray);

            inventoryConsole.Print(28, 1, "Abilities", RLColor.White);
            inventoryConsole.Print(28, 3, "Q - Charge", RLColor.LightGray);
            inventoryConsole.Print(28, 5, "W - Whirlwind Attack", RLColor.LightGray);
            inventoryConsole.Print(28, 7, "E - Fireball", RLColor.LightGray);
            inventoryConsole.Print(28, 9, "R - Lightning Bolt", RLColor.LightGray);

            inventoryConsole.Print(55, 1, "Items", RLColor.White);
            inventoryConsole.Print(55, 3, "1 - Health Potion", RLColor.LightGray);
            inventoryConsole.Print(55, 5, "2 - Mana Potion", RLColor.LightGray);
            inventoryConsole.Print(55, 7, "3 - Scroll", RLColor.LightGray);
            inventoryConsole.Print(55, 9, "4 - Wand", RLColor.LightGray);
        }

        public void DrawStats(RLConsole statConsole)
        {
            statConsole.Print(1, 1, $"Name:    {Name}", Colors.Text);
            statConsole.Print(1, 3, $"Health:  {Health}/{MaxHealth}", Colors.Text);
            statConsole.Print(1, 5, $"Attack:  {Attack} ({AttackChance}%)", Colors.Text);
            statConsole.Print(1, 7, $"Defense: {Defense} ({DefenseChance}%)", Colors.Text);
            statConsole.Print(1, 9, $"Gold:    {Gold}", Colors.Gold);
        }
    }
}
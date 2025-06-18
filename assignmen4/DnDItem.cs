using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmen4;
// Define a class named DnDItem
    public class DnDItem
{
    // public string to get name
    public string Name { get; set; }
    // Public property to get and set the rarity 
    public Rarity ItemRarity { get; set; }
    // Public property to get and set the weight in pounds
    public double WeightLbs { get; set; }
    // Public property T or F if magical
    public bool IsMagical { get; set; }
}
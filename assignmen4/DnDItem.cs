using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmen4;
// Define a class named DnDItem
    public class DnDItem
{
    // private string to get name
    private string Name { get; set; }
    // private property to get and set the rarity 
    private Rarity ItemRarity { get; set; }
    // Public property to get and set the weight in pounds
    private double WeightLbs { get; set; }
    // private property T or F if magical
    private bool IsMagical { get; set; }
}

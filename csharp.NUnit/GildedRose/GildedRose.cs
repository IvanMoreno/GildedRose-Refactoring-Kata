using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    // Long method
    // Divergent change
    // Dead code
    // Special case
    // Magic literal
    // Feature Envy
    // Complicated boolean expression
    // Duplicated code
    public void UpdateQuality() {
        foreach (var item in Items) {
            item.UpdateQuality();
        }
    }
}
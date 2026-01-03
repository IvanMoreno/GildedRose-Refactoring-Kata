namespace GildedRoseKata;

public static class ItemFactory {
    public static Item Create(string name, int sellIn, int quality) {
        if (name == "Aged Brie") {
            return new Item.AgedBrie(name,  sellIn, quality);
        }

        if (name == "Backstage passes to a TAFKAL80ETC concert") {
            return new Item.BackstagePass(name, sellIn, quality);
        }

        if (name == "Sulfuras, Hand of Ragnaros") {
            return new Item.Sulfuras(name,  sellIn, quality);
        }
        
        return new Item.NormalItem(name, sellIn, quality);
    }
}
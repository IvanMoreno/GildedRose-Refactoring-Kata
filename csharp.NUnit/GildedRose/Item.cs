using System;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; }
    public int SellIn { get; private set; }
    public int Quality { get; private set; }

    Item(string name, int sellIn, int quality) {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public static Item CreateInstance(string name, int sellIn, int quality) {
        if (name == "Aged Brie") {
            return new AgedBrie(name,  sellIn, quality);
        }

        if (name == "Backstage passes to a TAFKAL80ETC concert") {
            return new BackstagePass(name, sellIn, quality);
        }

        if (name == "Sulfuras, Hand of Ragnaros") {
            return new Sulfuras(name,  sellIn, quality);
        }
        
        return new NormalItem(name, sellIn, quality);
    }

    class AgedBrie : Item {
        public AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality) { }
        
        public override void UpdateQuality() {
            if (Quality < 50) {
                Quality = Quality + 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0 && Quality < 50) {
                Quality = Quality + 1;
            }
        }
    }

    class BackstagePass : Item {
        public BackstagePass(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality() {
            if (Quality < 50) {
                Quality = Quality + 1;

                if (SellIn < 11) {
                    if (Quality < 50) {
                        Quality = Quality + 1;
                    }
                }

                if (SellIn < 6) {
                    if (Quality < 50) {
                        Quality = Quality + 1;
                    }
                }
            }

            SellIn = SellIn - 1;

            if (SellIn < 0) {
                Quality = Quality - Quality;
            }
        }
    }

    class Sulfuras : Item {
        public Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality) { }
        public override void UpdateQuality() {
            // Does nothing.
        }
    }

    class NormalItem : Item {
        public NormalItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }


        public override void UpdateQuality() {
            if (Quality > 0) {
                Quality = Quality - 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0) {
                if (Quality > 0) {
                    Quality = Quality - 1;
                }
            }
        }
    }

    // Long method
    // Divergent change
    // Dead code
    // Special case
    // Magic literal
    // Complicated boolean expression
    // Duplicated code
    // Uncommunicative name
    public virtual void UpdateQuality() {
        if (Name == "Aged Brie") {
            throw new NotImplementedException("Use subclass instead");
        }

        if (Name == "Backstage passes to a TAFKAL80ETC concert") {
            throw new NotImplementedException("Use subclass instead");
        }

        if (Name == "Sulfuras, Hand of Ragnaros") {
            // Do Nothing
        }
        else {
            throw new NotImplementedException("Use subclass instead");
        }
    }
}
using System;

namespace GildedRoseKata;

public abstract class Item {
    public string Name { get; }
    public int SellIn { get; private set; }
    public int Quality { get; private set; }

    Item(string name, int sellIn, int quality) {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    internal class AgedBrie : Item {
        internal AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

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

    internal class BackstagePass : Item {
        internal BackstagePass(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

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

    internal class Sulfuras : Item {
        internal Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality() {
            // Does nothing.
        }
    }

    internal class NormalItem : Item {
        internal NormalItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

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

    // Divergent change
    // Dead code
    // Magic literal
    // Uncommunicative name
    public abstract void UpdateQuality();
}
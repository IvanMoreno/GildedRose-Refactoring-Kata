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
            UpdateQualityNew();
            UpdateSellIn();
            UpdateQualityAfterSellIn();
        }

        protected override void UpdateQualityNew() {
            if (Quality < 50) {
                Quality = Quality + 1;
            }
        }

        protected override void UpdateSellIn() {
            SellIn = SellIn - 1;
        }

        protected override void UpdateQualityAfterSellIn() {
            if (SellIn < 0 && Quality < 50) {
                Quality = Quality + 1;
            }
        }
    }

    internal class BackstagePass : Item {
        internal BackstagePass(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality() {
            UpdateQualityNew();
            UpdateSellIn();
            UpdateQualityAfterSellIn();
        }

        protected override void UpdateQualityNew() {
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
        }

        protected override void UpdateSellIn() {
            SellIn = SellIn - 1;
        }

        protected override void UpdateQualityAfterSellIn() {
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

        protected override void UpdateQualityNew() {
            // Does nothing.
        }
        
        protected override void UpdateSellIn() {
            // Does nothing.
        }
        protected override void UpdateQualityAfterSellIn() {
            // Does nothing.
        }
    }

    internal class NormalItem : Item {
        internal NormalItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateQuality() {
            UpdateQualityNew();
            UpdateSellIn();
            UpdateQualityAfterSellIn();
        }

        protected override void UpdateQualityNew() {
            if (Quality > 0) {
                Quality = Quality - 1;
            }
        }
        protected override void UpdateSellIn() {
            SellIn = SellIn - 1;
        }
        protected override void UpdateQualityAfterSellIn() {
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

    protected virtual void UpdateQualityNew() {
        if (Quality < 50) {
            Quality = Quality + 1;
        }
    }

    protected virtual void UpdateSellIn() {
        SellIn = SellIn - 1;
    }

    protected virtual void UpdateQualityAfterSellIn() {
        if (SellIn < 0 && Quality < 50) {
            Quality = Quality + 1;
        }
    }
}
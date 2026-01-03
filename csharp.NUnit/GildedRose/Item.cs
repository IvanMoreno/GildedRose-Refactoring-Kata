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
        const int MaxQuality = 50;
        
        internal AgedBrie(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        protected override void UpdateQualityBeforeSellIn() {
            if (Quality >= MaxQuality) 
                return;
            
            Quality++;
        }

        protected override void UpdateSellIn() {
            SellIn--;
        }

        protected override void UpdateQualityAfterSellIn() {
            if (Quality >= MaxQuality) 
                return;
            
            if (SellIn < 0) {
                Quality++;
            }
        }
    }

    internal class BackstagePass : Item {
        const int MaxQuality = 50;
        const int LimitedThreshold = 11;
        const int VeryLimitedThreshold = 6;

        internal BackstagePass(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        protected override void UpdateQualityBeforeSellIn() {
            if (Quality >= MaxQuality) 
                return;
            
            Quality++;

            if (SellIn < LimitedThreshold && Quality < MaxQuality) {
                Quality++;
            }

            if (SellIn < VeryLimitedThreshold && Quality < MaxQuality) {
                Quality++;
            }
        }

        protected override void UpdateSellIn() {
            SellIn--;
        }

        protected override void UpdateQualityAfterSellIn() {
            if (SellIn >= 0) 
                return;
            
            Quality = 0;
        }
    }

    internal class Sulfuras : Item {
        internal Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        protected override void UpdateQualityBeforeSellIn() {
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

        protected override void UpdateQualityBeforeSellIn() {
            if (Quality <= 0) 
                return;
            
            Quality--;
        }
        
        protected override void UpdateSellIn() {
            SellIn--;
        }
        
        protected override void UpdateQualityAfterSellIn() {
            if (SellIn >= 0 || Quality <= 0) 
                return;
            
            Quality--;
        }
    }

    // Magic literal
    public void Update() {
        UpdateQualityBeforeSellIn();
        UpdateSellIn();
        UpdateQualityAfterSellIn();
    }

    protected abstract void UpdateQualityBeforeSellIn();
    protected abstract void UpdateSellIn();
    protected abstract void UpdateQualityAfterSellIn();
}
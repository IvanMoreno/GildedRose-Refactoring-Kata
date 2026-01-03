namespace GildedRoseKata;

public abstract class Item {
    const int MaxQuality = 50;
    
    public string Name { get; }
    public int SellIn { get; private set; }
    public int Quality { get; private set; }
    
    bool ReachedMaxQuality => Quality >= MaxQuality;

    Item(string name, int sellIn, int quality) {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    internal class AgedBrie : Item {
        internal AgedBrie(int sellIn, int quality) : base("Aged Brie", sellIn, quality) { }

        protected override void UpdateQualityBeforeSellIn() {
            if (ReachedMaxQuality) 
                return;
            
            Quality++;
        }

        protected override void UpdateSellIn() {
            SellIn--;
        }

        protected override void UpdateQualityAfterSellIn() {
            if (ReachedMaxQuality) 
                return;
            
            if (SellIn < 0) {
                Quality++;
            }
        }
    }

    internal class BackstagePass : Item {
        const int LimitedThreshold = 11;
        const int VeryLimitedThreshold = 6;

        internal BackstagePass(int sellIn, int quality) : base("Backstage passes to a TAFKAL80ETC concert", sellIn, quality) { }

        protected override void UpdateQualityBeforeSellIn() {
            if (ReachedMaxQuality) 
                return;
            
            Quality++;

            if (SellIn < LimitedThreshold && !ReachedMaxQuality) {
                Quality++;
            }

            if (SellIn < VeryLimitedThreshold && !ReachedMaxQuality) {
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
        internal Sulfuras(int sellIn, int quality) : base("Sulfuras, Hand of Ragnaros", sellIn, quality) { }

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

    public void Update() {
        UpdateQualityBeforeSellIn();
        UpdateSellIn();
        UpdateQualityAfterSellIn();
    }

    protected abstract void UpdateQualityBeforeSellIn();
    protected abstract void UpdateSellIn();
    protected abstract void UpdateQualityAfterSellIn();
}
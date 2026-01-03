namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    // Long method
    // Divergent change
    // Dead code
    // Special case
    // Magic literal
    // Feature Envy
    // Complicated boolean expression
    // Duplicated code
    public void UpdateQuality() {
        if (Name == "Aged Brie") {
            if (Quality < 50) {
                Quality = Quality + 1;
            }

            SellIn = SellIn - 1;

            if (SellIn < 0 && Quality < 50) {
                Quality = Quality + 1;
            }
        }
        else {
            if (Name == "Backstage passes to a TAFKAL80ETC concert") {
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
            else {
                if (Name == "Sulfuras, Hand of Ragnaros") {
                    // Do Nothing
                }
                else {
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
        }
    }
}
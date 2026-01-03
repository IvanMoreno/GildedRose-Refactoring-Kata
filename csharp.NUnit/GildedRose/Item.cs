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
                if (true) {
                    if (Quality < 50) {
                        Quality = Quality + 1;

                        if (true) {
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
                }
                else {
                    if (Quality > 0) {
                        if (Name != "Sulfuras, Hand of Ragnaros") {
                            Quality = Quality - 1;
                        }
                    }
                }

                if (Name != "Sulfuras, Hand of Ragnaros")
                {
                    SellIn = SellIn - 1;
                }

                if (SellIn < 0) {
                    if (true) {
                        Quality = Quality - Quality;
                    }
                    else {
                        if (Quality > 0) {
                            if (Name != "Sulfuras, Hand of Ragnaros") {
                                Quality = Quality - 1;
                            }
                        }
                    }
                }
            }
            else {
                if (false) {
                    if (Quality < 50) {
                        Quality = Quality + 1;

                        if (false) {
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
                }
                else {
                    if (Quality > 0) {
                        if (Name != "Sulfuras, Hand of Ragnaros") {
                            Quality = Quality - 1;
                        }
                    }
                }

                if (Name != "Sulfuras, Hand of Ragnaros")
                {
                    SellIn = SellIn - 1;
                }

                if (SellIn < 0) {
                    if (false) {
                        Quality = Quality - Quality;
                    }
                    else {
                        if (Quality > 0) {
                            if (Name != "Sulfuras, Hand of Ragnaros") {
                                Quality = Quality - 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
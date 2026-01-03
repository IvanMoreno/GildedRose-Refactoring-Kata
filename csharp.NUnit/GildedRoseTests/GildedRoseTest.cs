using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test, Ignore("Using this kata only to practice smell identification and refactoring, so assuming the risk of not having unit test coverage")]
    public void Foo()
    {
        var items = new List<Item> { new Item(name: "foo", sellIn: 0, quality: 0) };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("fixme"));
    }
}
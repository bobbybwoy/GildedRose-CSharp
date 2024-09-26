using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("foo"));
    }

    [Test]
    public void Sulfuras()
    {
        string itemName = "Sulfuras, Hand of Ragnaros";

        var items = new List<Item> { new Item { Name = itemName, SellIn = 10, Quality = 10 }};
        var app = new GildedRose(items);

        app.UpdateQuality();
    }

    [Test]
    public void AgedBrie()
    {
        string itemName = "Aged Brie";
    }

    [Test]
    public void BackstagePass()
    {
        string itemName = "Backstage passes to a TAFKAL80ETC concert";
    }

    [Test]
    public void AnyOtherItem()
    {
       string itemName = "Tulip"; 
    }

    [Test]
    public void SpecialItem()
    {
       string itemName = "Tulip"; 
    }
}
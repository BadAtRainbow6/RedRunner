using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem
{
    public string name;
    public Sprite image;
    public ItemType type;
    public int price;
    public bool purchased = false;

    public enum ItemType
    {
        HAT,
        BELT
    }

    public ShopItem (string name, Sprite image, ItemType type, int price)
    {
        this.name = name;
        this.image = image;
        this.type = type;
        this.price = price;
    }
}
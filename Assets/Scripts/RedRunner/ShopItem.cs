using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem
{
    public string name;
    public Sprite image;
    public int price;
    public bool purchased = false;

    public ShopItem (string name, Sprite image, int price)
    {
        this.name = name;
        this.image = image;
        this.price = price;
    }
}
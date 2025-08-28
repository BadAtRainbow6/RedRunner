using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem
{
    public string name;
    public Texture image;
    public int price;
    public bool purchased = false;

    public ShopItem (string name, Texture image, int price)
    {
        this.name = name;
        this.image = image;
        this.price = price;
    }
}
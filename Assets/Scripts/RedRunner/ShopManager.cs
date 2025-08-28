using RedRunner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRunner
{
    public sealed class ShopManager : MonoBehaviour
    {
        [SerializeField] Sprite[] sprites;
        private List<ShopItem> shopItems = new List<ShopItem>();

        private static ShopManager m_Singleton;

        public static ShopManager Singleton
        {
            get
            {
                return m_Singleton;
            }
        }

        void Awake()
        {
            m_Singleton = this;
            SetItems();
        }


        public void SetItems()
        {
            for (int i = 0; i < 15; i++)
            {
                ShopItem item = CreateItem(i);

                if(item != null)
                {
                    shopItems.Add(item);
                }
            }
        }

        public List<ShopItem> GetItems()
        {
            return shopItems;
        }

        public ShopItem CreateItem(int id)
        {
            if(id > sprites.Length - 1)
            {
                return null;
            }

            Sprite sprite = sprites[id];

            switch (id)
            {
                case 0:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 1:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 2:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 3:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 4:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 5:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 6:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 7:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 8:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 9:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 10:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 11:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 12:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 13:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                case 14:
                    return new ShopItem("Cowboy Hat", sprite, 2);
                default:
                    Debug.Log("No item found with id: " + id);
                    return null;
            }
        }

        public ShopItem GetItem(int id)
        {
            return shopItems[id];
        }

        public void BuyItem(int id)
        {
            shopItems[id].purchased = true;
            GameManager.Singleton.m_Coin.Value -= GetItem(id).price;
            Debug.Log("Bought item. Coins left: " + GameManager.Singleton.m_Coin.Value);
        }
    }
}
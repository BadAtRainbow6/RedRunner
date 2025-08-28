using RedRunner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRunner
{
    public sealed class ShopManager : MonoBehaviour
    {
        [SerializeField] Texture[] textures;
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
            for (int i = 0; i < 1; i++)
            {
                shopItems.Add(CreateItem(i));
            }
        }

        public ShopItem CreateItem(int id)
        {
            Texture texture = textures[id];
            switch (id)
            {
                case 0:
                    return new ShopItem("Cowboy Hat", texture, 2);
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
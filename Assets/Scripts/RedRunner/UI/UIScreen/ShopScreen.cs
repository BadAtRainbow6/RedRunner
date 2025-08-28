using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{
    public class ShopScreen : UIScreen
    {
        [SerializeField]
        protected Button ExitButton = null;
        [SerializeField]
        protected Button[] ShopButtons = null;
        [SerializeField]
        protected Image[] ShopImages = null;

        private void Start()
        {
            ExitButton.SetButtonAction(() =>
            {
                var uiManager = UIManager.Singleton;
                var StartScreen = uiManager.UISCREENS.Find(el => el.ScreenInfo == UIScreenInfo.START_SCREEN);
                if (StartScreen != null)
                {
                    uiManager.OpenScreen(StartScreen);
                }
            });

            for (int i = 0; i < ShopButtons.Length; i++)
            {
                int buttonId = i;
                ShopButtons[i].SetButtonAction(() =>
                {
                    GameManager.Singleton.ShopButton(buttonId);
                });
            }

            for (int i = 0; i < ShopManager.Singleton.GetItems().Count && i < ShopImages.Length; i++)
            {
                ShopImages[i].sprite = ShopManager.Singleton.GetItem(i).image;
                ShopImages[i].color = new Color(1f, 1f, 1f, 1f);
                ShopImages[i].preserveAspect = true;
            }
        }
        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }
}
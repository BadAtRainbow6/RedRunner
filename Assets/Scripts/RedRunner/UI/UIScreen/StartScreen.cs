using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{
    public class StartScreen : UIScreen
    {
        [SerializeField]
        protected Button PlayButton = null;
        [SerializeField]
        protected Button HelpButton = null;
        [SerializeField]
        protected Button InfoButton = null;
        [SerializeField]
        protected Button ExitButton = null;
        [SerializeField]
        protected Button ShopButton = null;

        private void Start()
        {
            PlayButton.SetButtonAction(() =>
            {
                var uiManager = UIManager.Singleton;
                var InGameScreen = uiManager.UISCREENS.Find(el => el.ScreenInfo == UIScreenInfo.IN_GAME_SCREEN);
                if (InGameScreen != null)
                {
                    uiManager.OpenScreen(InGameScreen);
                    GameManager.Singleton.StartGame();
                }
            });

            ExitButton.SetButtonAction(() =>
            {
                GameManager.Singleton.ExitGame();
            });

            ShopButton.SetButtonAction(() =>
            {
                var uiManager = UIManager.Singleton;
                var ShopScreen = uiManager.UISCREENS.Find(el => el.ScreenInfo == UIScreenInfo.SHOP_SCREEN);
                if(ShopScreen != null)
                {
                    uiManager.OpenScreen(ShopScreen);
                }
            });
        }
        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }
}
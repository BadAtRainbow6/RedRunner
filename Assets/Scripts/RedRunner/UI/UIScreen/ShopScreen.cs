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
                ShopButtons[i].SetButtonAction(() =>
                {
                    GameManager.Singleton.ShopButton(i);
                });
            }
        }
        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }
}
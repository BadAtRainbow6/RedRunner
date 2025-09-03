using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{

	public class UIShareButtons : MonoBehaviour
	{

		[SerializeField]
		protected Animator m_ShareBackground;
		[SerializeField]
		protected Animator[] m_ShareButtons;
		protected bool m_IsOpen = false;


        void Start ()
		{
            SetVisibility(false);
        }

		public void Toggle ()
		{
			if ( m_IsOpen )
			{
				m_IsOpen = false;
				SetTrigger ( "Close" );
				SetVisibility(false);
			}
			else
			{
				m_IsOpen = true;
				SetTrigger ( "Open" );
				SetVisibility(true);
				ScaleButtons();
			}
		}

        private void SetVisibility(bool isVisible)
        {
            foreach (var button in m_ShareButtons)
            {
                button.gameObject.SetActive(isVisible);
            }
        }

        private void ScaleButtons()
        {

            foreach (var button in m_ShareButtons)
            {
                RectTransform buttonRectTransform = button.gameObject.GetComponent<RectTransform>();

                // Check if RectTransform exists (for safety)
                if (buttonRectTransform != null)
                {
                    // Get the current size of the button
                    Vector2 currentSize = buttonRectTransform.sizeDelta;

                    // Double the width and height (i.e., multiply the size by 2)
                    buttonRectTransform.sizeDelta = currentSize * 2f;

                    // Alternatively, if you want to scale the buttons by adjusting the scale
                    // buttonRectTransform.localScale = new Vector3(2f, 2f, 1f);
                }
            }
        }

        public void SetTrigger ( string trigger )
		{
			m_ShareBackground.SetTrigger ( trigger );
			for ( int i = 0; i < m_ShareButtons.Length; i++ )
			{
				m_ShareButtons [ i ].SetTrigger ( trigger );
			}
		}

	}

}
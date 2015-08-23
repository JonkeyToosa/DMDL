using UnityEngine;
using System.Collections;

namespace UI
{
	public class Controls: MonoBehaviour
	{
        public enum inputChoice {
            Touch,
            Click
        };

        public inputChoice PRIMARY_INPUT = new inputChoice();
		public KeyCode UP_BUTTON    = KeyCode.UpArrow;
		public KeyCode DOWN_BUTTON  = KeyCode.DownArrow;
		public KeyCode RIGHT_BUTTON = KeyCode.RightArrow;
		public KeyCode LEFT_BUTTON  = KeyCode.LeftArrow;
	}
}
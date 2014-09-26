using UnityEngine;
using System.Collections;

public class CardTouchDetector : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var p = Input.mousePosition;
            if (p.y < Screen.height / 2)
            {
                gameObject.SendMessage("TouchCard", (int)(p.x * 3 / Screen.width));
            }
        }
    }
}

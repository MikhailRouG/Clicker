using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TouchInput : MonoBehaviour
{
    private Touch theTouch;
    private OnClick onClick;

    private void Start()
    {
        onClick = GetComponent<OnClick>();
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);
            if(theTouch.phase == TouchPhase.Began)
            {
                onClick.Click();
            }
        }
    }
}

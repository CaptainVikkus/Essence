using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
public class AutoLayoutSizer : MonoBehaviour
{
    [SerializeField] RectTransform targetRect;
    RectTransform thisRect;
    public float overrideWidth;
    public float overrideHeight;

    // Start is called before the first frame update
    private void Start()
    {
        OverrideSize();
    }

    private void OnGUI()
    {
        OverrideSize();
    }

    public void OverrideSize()
    {
        thisRect = GetComponent<RectTransform>();
        if (targetRect != null)
        {
            thisRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, targetRect.rect.width);
            thisRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, targetRect.rect.height);
        }
        else
        {
            if (overrideWidth > 0)
            {
                thisRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, overrideWidth);
            }
            if (overrideHeight > 0)
            {
                thisRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, overrideHeight);
            }
        }

    }
}

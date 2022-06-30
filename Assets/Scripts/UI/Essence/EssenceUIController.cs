using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EssenceUIController : MonoBehaviour
{
    public Essence.Essence activeEssence;
    public Image icon;
    public TextMeshProUGUI text;

    private void OnEnable()
    {
        if (activeEssence == null || activeEssence.Base.type == 0) //Empty
        {
            icon.color = new Color(1f, 1f, 1f, 0.25f);
            text.text = "Default Essence";
        }
        else
        {
            icon.sprite = activeEssence.Base.Icon;
            icon.color = activeEssence.Base.IconColor;
            text.text = activeEssence.Base.name;
        }
    }


}

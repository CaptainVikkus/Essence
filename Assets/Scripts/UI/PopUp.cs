using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using TMPro;

[RequireComponent(typeof(Animator))]
public class PopUp : MonoBehaviour
{
    public TextMeshProUGUI title;
    [SerializeField] GameObject container;
    [SerializeField] GameObject listItemPrefab;

    private Animator animator;
    private static readonly int OpenHash = Animator.StringToHash("Open");

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Open();
    }

    public void Open()
    {
        animator.SetBool(OpenHash, true);
        Debug.Log($"Opening {title.text}");
    }

    public void Close()
    {
        animator.SetBool(OpenHash, false);
        Debug.Log($"Closing {title.text}");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void AddText(string text)
    {
        var item = Instantiate(listItemPrefab, container.transform).GetComponentInChildren<TextMeshProUGUI>();
        item.text = text;
    }
}

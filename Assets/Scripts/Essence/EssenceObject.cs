using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssenceObject : MonoBehaviour
{
    //Essence Data
    public Essence.Essence essence;
    //Object Data
    public ParticleSystem particleSystem;
    public SpriteRenderer icon;

    // Start is called before the first frame update
    void Start()
    {
        if (essence == null || essence.Base.type == 0) //Empty
        {
            particleSystem.Stop();
            icon.color = new Color(1f, 1f, 1f, 0.25f);
        }
        else
        {
            var main = particleSystem.main;
            main.startColor = new ParticleSystem.MinMaxGradient(
                essence.Base.Color1,
                essence.Base.Color2);

            icon.sprite = essence.Base.Icon;
            icon.color = essence.Base.IconColor;
        }
    }

    private void Update()
    {
        transform.LookAt(Vector3.back * 100f);
    }

    public void UpdateEssence(Essence.Essence _base)
    {
        essence = _base;
        Debug.Log($"Updated Essence: {_base.Base.type}");
        Start();
    }
}

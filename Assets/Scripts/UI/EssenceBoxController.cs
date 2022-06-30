using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssenceBoxController : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] EssenceObject slot1;
    [SerializeField] EssenceObject slot2;
    [SerializeField] EssenceObject slot3;
    [SerializeField] EssenceObject slot4;

    [SerializeField] float rotationSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        slot1.UpdateEssence(player.EssenceSpd);
        slot2.UpdateEssence(player.EssencePwr);
        slot3.UpdateEssence(player.EssenceRvr);
        slot4.UpdateEssence(player.EssenceSrt);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed, Space.Self);
    }
}

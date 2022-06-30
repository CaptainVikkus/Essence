using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoadedPlayer : MonoBehaviour
{
    [SerializeField] Essence.EssenceSO essence1;
    [SerializeField] Essence.EssenceSO essence2;
    [SerializeField] Essence.EssenceSO essence3;
    [SerializeField] Essence.EssenceSO essence4;

    private Player player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GetComponent<Player>();
        player.Awaken(essence1);
        player.Awaken(essence2);
        player.Awaken(essence3);
        player.Awaken(essence4);

    }
}

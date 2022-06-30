using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Essence.Essence essenceSpeed;
    [SerializeField] Essence.Essence essencePower;
    [SerializeField] Essence.Essence essenceRecovery;
    [SerializeField] Essence.Essence essenceSpirit;

    public Essence.Essence EssenceSpd => essenceSpeed;
    public Essence.Essence EssencePwr => essencePower;
    public Essence.Essence EssenceRvr => essenceRecovery;
    public Essence.Essence EssenceSrt => essenceSpirit;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Player Available: " +
            $"\n-{essenceSpeed.Base.type}" +
            $"\n-{essencePower.Base.type}" +
            $"\n-{essenceRecovery.Base.type}" +
            $"\n-{essenceSpirit.Base.type}");
    }

    private void LoadPlayer()
    {
        throw new NotImplementedException();
    }

    public void Awaken(Essence.EssenceSO essence)
    {
        if (essencePower == null || essenceSpeed == null 
            || essenceRecovery == null || essenceSpirit == null)
        {
            //Build list of unassigned essences
            var awakenList = new List<Essence.Attribute>();
            if (essencePower == null) { awakenList.Add(Essence.Attribute.Power); }
            if (essenceSpeed == null) { awakenList.Add(Essence.Attribute.Speed); }
            if (essenceRecovery == null) { awakenList.Add(Essence.Attribute.Recovery); }
            if (essenceSpirit == null) { awakenList.Add(Essence.Attribute.Spirit); }

            //Build a new essence from scriptable object
            Essence.Essence awakenedEssence = new Essence.Essence(essence);
            //set it to a random unawakened atribute
            int index = UnityEngine.Random.Range(0, awakenList.Count);

            switch (awakenList[index])
            {
                case Essence.Attribute.Speed:
                    awakenedEssence.Awaken(Essence.Attribute.Speed);
                    essenceSpeed = awakenedEssence;
                    break;
                case Essence.Attribute.Power:
                    awakenedEssence.Awaken(Essence.Attribute.Power);
                    essencePower = awakenedEssence;
                    break;
                case Essence.Attribute.Spirit:
                    awakenedEssence.Awaken(Essence.Attribute.Spirit);
                    essenceSpirit = awakenedEssence;
                    break;
                case Essence.Attribute.Recovery:
                    awakenedEssence.Awaken(Essence.Attribute.Recovery);
                    essenceRecovery = awakenedEssence;
                    break;
                default:
                    Debug.LogWarning("Awakening Failed");
                    break;
            }

            Debug.Log($"{awakenedEssence.Base.type} Awakened to {awakenList[index]} Attribute");
        }
    }
}

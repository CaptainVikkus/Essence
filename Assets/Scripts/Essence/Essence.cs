using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Essence
{
    public class Essence
    {
        public Essence(EssenceSO Base)
        {
            essence = Base;
        }

        [SerializeField] EssenceSO essence;
        [SerializeField] Attribute boundAttribute;
        [SerializeField] Ability[] abilities = new Ability[4];

        public EssenceSO Base => essence;
        public Ability[] Abilities => abilities;

        public void Awaken(Attribute attribute)
        {
            boundAttribute = attribute;

            //TODO:: Add a first free attribute
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Essence
{
    [CreateAssetMenu(fileName = "Essence", menuName = "Essence/Create new essence")]
    public class EssenceSO : ScriptableObject
    {
        public Class type;
        [SerializeField] Sprite icon;
        [SerializeField] Color iconColor;
        [SerializeField] Color color1;
        [SerializeField] Color color2;

        public Sprite Icon => icon;
        public Color IconColor => iconColor;
        public Color Color1 => color1;
        public Color Color2 => color2;
    }

    [CustomEditor(typeof(EssenceSO))]
    public class EssenceListUpdater : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Update Essence Assets", GUILayout.Height(40)))
            {
                //Check the list of EssenceClasses available
                foreach (Class _class in System.Enum.GetValues(typeof(Class)))
                {
                    var essence = CreateInstance<EssenceSO>();
                    essence.type = _class;
                    string path = "Assets/Resources/Essence/" + essence.type.ToString() + ".asset";
                    //Only Create if path is null or empty
                    if (string.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(path)))
                    {
                        AssetDatabase.CreateAsset(essence, "Assets/Resources/Essence/" + essence.type.ToString() + ".asset");
                    }
                }
            }

        }
    }
}
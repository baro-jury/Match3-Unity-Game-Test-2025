using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinData", menuName = "ScriptableObject/SkinData")]
public class SkinData : ScriptableObject
{
    public List<SkinInfo> skinList;

    public Sprite GetSkin(NormalItem.eNormalType type)
    {
        return skinList.FirstOrDefault(s => s.TypeItem == type).Sprite;
    }
}

[Serializable]
public class SkinInfo
{
    public NormalItem.eNormalType TypeItem;
    public Sprite Sprite;
}

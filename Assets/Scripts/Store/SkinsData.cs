using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinsData", menuName = "ScriptableObjects/SkinsScriptableObject", order = 1)]
public class SkinsData : ScriptableObject
{
	public Sprite[] Skins;
	public int[] Prices;
}

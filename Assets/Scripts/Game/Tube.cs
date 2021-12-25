using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] private SkinsData skinsData;
    private SpriteRenderer spriteRenderer;
    private int choosedSkin;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        choosedSkin = PlayerPrefs.GetInt("ChoosedSkin");
        spriteRenderer.sprite = skinsData.TubeSkins[choosedSkin];
    }
}

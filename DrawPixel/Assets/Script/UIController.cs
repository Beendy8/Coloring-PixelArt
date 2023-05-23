using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private SellType[] sells;
    [SerializeField] private Image success;
    public int _nameColor;
    public Color[] _color;

    public void ChangeColor(int colorBtn)
    {
        _nameColor = colorBtn;
    }

    public void Painting(SellType sellType)
    {
        if (_nameColor == sellType.colorSell)
        {
            sellType.gameObject.GetComponent<Image>().color = _color[_nameColor];
        }
    }
    public void DestroyFank()
    {
        Destroy(gameObject);
    }

    public void Painted()
    {
        for (int i = 0; i < sells.Length; i++)
        {
            if (sells[i].finishDrow == false)
            {
                return;
            }
        }
        success.gameObject.SetActive(true);
    }
}

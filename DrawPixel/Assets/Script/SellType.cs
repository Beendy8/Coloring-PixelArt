using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SellType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image imageSell;
    [SerializeField] private UIController uIController;
    public int colorSell;
    private bool canDrow;
    public bool finishDrow;

    private void Start()
    {
        imageSell.color = uIController._color[colorSell];
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            canDrow = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canDrow = false;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (canDrow == true)
        {
            if (uIController._nameColor == colorSell)
            {
                GetComponent<Image>().color = uIController._color[colorSell];
                finishDrow = true;
                uIController.Painted();
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
            if (uIController._nameColor == colorSell)
            {
                GetComponent<Image>().color = uIController._color[colorSell];
                finishDrow = true;
                uIController.Painted();
            }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
}

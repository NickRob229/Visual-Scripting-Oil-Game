using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrowButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject rightArrow;

    private void Start()
    {
        // Initially, set arrows to be invisible
        rightArrow.SetActive(false);
    }

    // This is called when the pointer enters the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Make arrows visible
        rightArrow.SetActive(true);
    }

    // This is called when the pointer exits the button
    public void OnPointerExit(PointerEventData eventData)
    {
        // Make arrows invisible again
        rightArrow.SetActive(false);
    }
}
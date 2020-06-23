/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {

public endFinalLevel myLevel;

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition; 
            Debug.Log( eventData.pointerDrag.gameObject.name); 
            Debug.Log( gameObject.name); 
        if (eventData.pointerDrag.gameObject.name.Equals("orev")&& gameObject.name.Equals("ItemSlotOrev")){
            Debug.Log( eventData.pointerDrag.gameObject.name);
            myLevel.pic1=true;
        }
        if (eventData.pointerDrag.gameObject.name.Equals("yona")&& gameObject.name.Equals("ItemSlotYona")){
            Debug.Log( eventData.pointerDrag.gameObject.name);
            myLevel.pic2=true;
        }
         if (eventData.pointerDrag.gameObject.name.Equals("aleZait")&& gameObject.name.Equals("ItemSlotAle")){
             Debug.Log( eventData.pointerDrag.gameObject.name);
            myLevel.pic3=true;
        }
        }
    }

}

using UnityEngine;

public class UiOnOff : MonoBehaviour
{
    public GameObject UiObject;
    void Start()
    {
        UiObject.SetActive(false);
    }

    public void OnOff()
    {
        if(UiObject != null)
        {
            UiObject.SetActive(!UiObject.activeSelf);
        }
        
    }
}

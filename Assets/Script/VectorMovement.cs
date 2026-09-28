using UnityEngine;

public class VectorMovement : MonoBehaviour
{
    public GameObject target;

    Vector3 basePosition;
    Vector3 value = Vector3.zero;
    bool checkButton = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(checkButton)
            transform.position = target.transform.position;
    }

    public void CheckButtonChange()
    {
        checkButton = !checkButton;
    }

    public void ResetPosition()
    {
        checkButton = false;
        transform.position = basePosition;
    }
}

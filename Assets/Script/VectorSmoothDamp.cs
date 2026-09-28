using UnityEngine;

public class VectorSmoothDamp : MonoBehaviour
{
    public GameObject target;

    Vector3 basePosition;
    Vector3 value = Vector3.zero;
    bool checkButton = false;
    bool resetPossitionButton = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (checkButton) transform.position = Vector3.SmoothDamp(transform.position, target.transform.position, ref value, 1f);
        if (resetPossitionButton) transform.position = basePosition;
    }

    public void CheckButtonChange()
    {
        ButtonReset();
        checkButton = !checkButton;
    }

    public void ResetPosition()
    {
        ButtonReset();
        resetPossitionButton = true;
    }

    public void ButtonReset()
    {
        checkButton = false;
        resetPossitionButton = false;
    }
}

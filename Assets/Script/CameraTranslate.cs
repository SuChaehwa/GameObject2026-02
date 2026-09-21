using UnityEngine;

public class CameraTranslate : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -7);


    // Update is called once per frame
    void LateUpdate()
    {
        if (target == null) return;

        transform.position = target.position + offset;
    }
}

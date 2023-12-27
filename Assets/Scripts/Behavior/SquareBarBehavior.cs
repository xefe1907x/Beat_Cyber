using UnityEngine;

public class SquareBarBehavior : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 5.5f;

    void Start() => GetIndexInHierarchy();

    void FixedUpdate() => RotateSquareBarConstantly();

    void RotateSquareBarConstantly() => transform.Rotate(-Vector3.forward, rotationSpeed * Time.deltaTime);

    void GetIndexInHierarchy()
    {
        int objectIndex = transform.GetSiblingIndex() + 1;

        switch (objectIndex)
        {
            case 1:
                rotationSpeed = 1.5f;
                break;
            case 2:
                rotationSpeed = 1.7f;
                break;
            case 3:
                rotationSpeed = 1.9f;
                break;
            case 4:
                rotationSpeed = 2.1f;
                break;
            case 5:
                rotationSpeed = 2.3f;
                break;
            case 6:
                rotationSpeed = 2.5f;
                break;
            case 7:
                rotationSpeed = 2.7f;
                break;
            case 8:
                rotationSpeed = 2.9f;
                break;
        }
    }
}

using UnityEngine;

public class SlicedBodyBehavior : MonoBehaviour
{
    void OnEnable() => CheckIfKinematicTrue();

    void CheckIfKinematicTrue()
    {
        foreach (Transform child in this.gameObject.transform)
        {
            var rb = child.GetComponent<Rigidbody>();
            
            if (rb.isKinematic)
                rb.isKinematic = false;
        }
    }

    void SlicedPartsPosZero()
    {
        foreach (Transform child in this.gameObject.transform)
        {
            var rb = child.GetComponent<Rigidbody>();
            rb.isKinematic = true;
            
            child.localPosition = Vector3.zero;
        }
    }

    void OnDisable() => SlicedPartsPosZero();
}

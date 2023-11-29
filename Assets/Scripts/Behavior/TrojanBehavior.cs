using UnityEngine;

public class TrojanBehavior : MonoBehaviour
{
    float moveSpeed = 2.3f;

    void FixedUpdate() => MoveTrojanToPlayer();

    void MoveTrojanToPlayer() =>
        transform.position = new Vector3(transform.position.x, transform.position.y,
            transform.position.z - moveSpeed * Time.deltaTime);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneBehaviour : MonoBehaviour
{

    [SerializeField] Transform spawnpoint;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(WaitToRespawn(collision));
    }
    IEnumerator WaitToRespawn(Collider2D collider)
    {
        yield return new WaitForSeconds(2);
        collider.attachedRigidbody.transform.position = spawnpoint.position;
        collider.attachedRigidbody.velocity = Vector2.zero;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold = 2.0f;
    public float maxForce = 500.0f;

    private bool isHold;

    private void Start()
    {
        isHold = false;
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider)
    {

        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            timeHold += Time.deltaTime;
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
        }

        force = Mathf.Clamp(force, 0, maxForce);

        Rigidbody rb = collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.forward * force);
        }

        isHold = false;
    }
}

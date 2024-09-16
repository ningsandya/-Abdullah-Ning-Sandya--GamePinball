using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public float score;
    public ScoreManager scoreManager;

    public AudioManager audioManager;
    public VFXManager vfxManager;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            // Trigger animasi
            animator.SetTrigger("hit");

            //playfx
            audioManager.PlaySFX(collision.transform.position);

            //playvfx
            vfxManager.PlayVFX(collision.transform.position);

            //addscore
            scoreManager.AddScore(score);
        }
    }
}


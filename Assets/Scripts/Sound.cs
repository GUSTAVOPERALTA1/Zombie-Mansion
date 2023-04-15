using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip footstepSound; // El audio clip de los pasos
    public float footstepInterval = 0.5f; // El intervalo entre cada sonido de paso
    public float walkSpeed = 5f; // La velocidad de caminata del personaje

    private AudioSource audioSource;
    private float nextFootstepTime;
    private bool isMoving;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nextFootstepTime = 0f;
        isMoving = false;
    }

    private void Update()
    {
        // Detectar si el personaje se está moviendo
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        // Reproducir sonidos de paso si el personaje se está moviendo
        if (isMoving && Time.time >= nextFootstepTime)
        {
            audioSource.PlayOneShot(footstepSound);
            nextFootstepTime = Time.time + footstepInterval;
        }
    }
}

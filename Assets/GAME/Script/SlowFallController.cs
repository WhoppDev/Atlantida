using UnityEngine;

public class SlowFallController : MonoBehaviour
{
    private CharacterController characterController;

    // Vari�veis ajust�veis para controlar a gravidade e a velocidade de queda
    public float gravity = -9.81f;
    public float fallMultiplier = 0.2f; // Reduz a velocidade de queda

    private Vector3 velocity;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Verifica se o personagem est� no ch�o
        bool isGrounded = characterController.isGrounded;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // For�a o personagem a ficar no ch�o
        }

        // Aplica a gravidade com um multiplicador de queda lenta
        velocity.y += gravity * fallMultiplier * Time.deltaTime;

        // Move o personagem
        characterController.Move(velocity * Time.deltaTime);
    }
}

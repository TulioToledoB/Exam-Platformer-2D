using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
     [SerializeField] private KeyCode attackKey = KeyCode.C;
    [SerializeField] private KeyCode hurtKey = KeyCode.V;
    [SerializeField] private KeyCode dieKey = KeyCode.X;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("AttackTrigger");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            animator.SetTrigger("HurtTrigger");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            animator.SetTrigger("DieTrigger");
        }

        // Control para que player pueda mirar hacia la izquierda o derecha
        float inputX = Input.GetAxis("Horizontal");
        if (inputX != 0)
        {
            // Se multiplica por -1 para que la dirección sea consistente con las teclas "A" y "D"
            transform.localScale = new Vector3(Mathf.Sign(inputX) * -1, 1, 1);
        }
    }
}



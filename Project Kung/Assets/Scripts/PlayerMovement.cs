using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    // �÷��̾ ������ ������Ʈ
    // �÷��̾��� �̵� ����

    public float speed;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("����");
            animator.SetBool("Moving", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Moving", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            Debug.Log("������");

        }
        else
        {
            animator.SetBool("Moving", false);
        }


    }
}

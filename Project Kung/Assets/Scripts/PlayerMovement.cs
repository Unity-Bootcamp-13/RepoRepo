using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    // 플레이어에 부착할 컴포넌트
    // 플레이어의 이동 제어

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
            Debug.Log("왼쪽");
            animator.SetBool("Moving", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Moving", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            Debug.Log("오른쪽");

        }
        else
        {
            animator.SetBool("Moving", false);
        }


    }
}

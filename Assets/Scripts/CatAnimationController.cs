using UnityEngine;

public class CatAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Run");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Dead");
        }
    }

    // ✅ UI 버튼 연결용 함수
    public void PlayRun()
    {
        animator.SetTrigger("Run");
    }

    public void PlayDead()
    {
        animator.SetTrigger("Dead");
    }
}

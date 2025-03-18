using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Player), typeof(Rigidbody2D))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private Player player;
    private Rigidbody2D rigidbody2D;

    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Player>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        animator.SetBool("Falling", player.isFalling);
        animator.SetFloat("YVelocity", rigidbody2D.velocity.y);
    }
}

using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public Animator animator;

    public bool walk = false;
    public bool hip = false;
    public bool mac = false;
    public bool fly = false;

    void Start()
    {
        walk = true;
        SetAnimatorStates();
    }

    void Update()
    {
        // Example inputs (you can replace these with actual controls or triggers)
        if (Input.GetKeyDown(KeyCode.L))
        {
            SetBooleans(true, false, false, false); // Walk
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            SetBooleans(false, true, false, false); // Hip
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            SetBooleans(false, false, true, false); // Mac
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            SetBooleans(false, false, false, true); // Fly
        }

        SetAnimatorStates();
    }

    void SetBooleans(bool w, bool h, bool m, bool f)
    {
        walk = w;
        hip = h;
        mac = m;
        fly = f;
    }

    void SetAnimatorStates()
    {
        animator.SetBool("walk", walk);
        animator.SetBool("hip", hip);
        animator.SetBool("mac", mac);
        animator.SetBool("fly", fly);
    }
}

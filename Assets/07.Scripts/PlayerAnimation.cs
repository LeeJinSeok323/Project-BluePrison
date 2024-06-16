using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Player Player;
    Animator anim;
    void Start(){
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
       
        // 기타 키 바인딩 예제
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(anim.GetBool("isCrouch"))
                anim.SetBool("isCrouch", false);
            else
                anim.SetBool("isCrouch", true);
        }

    }
}

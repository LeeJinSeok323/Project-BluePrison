using UnityEngine;

public class FootstepParticles : MonoBehaviour
{
    public ParticleSystem footstepParticle; // 파티클 시스템 참조
    public Transform leftFoot; // 왼쪽 발 위치
    public Transform rightFoot; // 오른쪽 발 위치

    // 애니메이션 이벤트에서 호출될 메서드
    public void EmitFootstep(string foot)
    {
        if (foot == "left")
        {
            EmitAtPosition(leftFoot.position);
        }
        else if (foot == "right")
        {
            EmitAtPosition(rightFoot.position);
        }
    }

    private void EmitAtPosition(Vector3 position)
    {
        footstepParticle.transform.position = position;
        footstepParticle.Play();
    }
}

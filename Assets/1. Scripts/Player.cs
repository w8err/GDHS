using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private StageData stageData;
    [SerializeField] private KeyCode keycodeAttack = KeyCode.Space;
    private Movement movement;
    private Weapon weapon;

    void Start()
    {
        weapon = GetComponent<Weapon>();
        movement = GetComponent<Movement>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        movement.MoveTo(new Vector3(x, y, 0));

        if (Input.GetKeyDown(keycodeAttack))
        {
            weapon.StartFiring();
        }
        else if (Input.GetKeyUp(keycodeAttack))
        {
            weapon.StopFiring();
        }
    }
    // 유니티에는 ScriptableObject가 있다.
    // 공유 데이터를 저장하려면 이걸 사용 해야함.
    // StageData로 플레이어의 최대 이동가능한 필드를 ScriptableObject로 제한함

    private void LateUpdate()
    {
        // StageData로 플레이어의 최대 이동가능한 필드를 제한함(ScriptableObject 사용)
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
            Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
}

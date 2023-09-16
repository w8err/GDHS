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
    // ����Ƽ���� ScriptableObject�� �ִ�.
    // ���� �����͸� �����Ϸ��� �̰� ��� �ؾ���.
    // StageData�� �÷��̾��� �ִ� �̵������� �ʵ带 ScriptableObject�� ������

    private void LateUpdate()
    {
        // StageData�� �÷��̾��� �ִ� �̵������� �ʵ带 ������(ScriptableObject ���)
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
            Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
}

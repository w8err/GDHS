using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float attackRate = 0.1f;
    private Coroutine firingCoroutine; // ���� �̸� ����

    public void StartFiring()
    {
         firingCoroutine = StartCoroutine(TryAttack());

    }

    public void StopFiring()
    {
            StopCoroutine(firingCoroutine); // ���� �̸� ����
            firingCoroutine = null; // Coroutine ���� �ʱ�ȭ
    }

    private IEnumerator TryAttack()
    {
        while (true)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(attackRate);
        }
    }
}
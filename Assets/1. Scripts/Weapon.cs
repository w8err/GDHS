using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float attackRate = 0.1f;
    private Coroutine firingCoroutine; // 변수 이름 수정

    public void StartFiring()
    {
         firingCoroutine = StartCoroutine(TryAttack());

    }

    public void StopFiring()
    {
            StopCoroutine(firingCoroutine); // 변수 이름 수정
            firingCoroutine = null; // Coroutine 변수 초기화
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
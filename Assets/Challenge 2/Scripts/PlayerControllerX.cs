using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour{
    public GameObject dogPrefab;
    private bool isCoolDown = false;
    private float coolDown = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isCoolDown == false)
            {
                SpawnDog();
                StartCoroutine(CoolDown());
            }
        }
    }

    IEnumerator CoolDown()
    {
        isCoolDown = true;
        yield return new WaitForSeconds(coolDown);
        isCoolDown = false;
    }

    private void SpawnDog()
    {
         Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}       
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabsArray;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }
    private void SpawnAttacker()
    {
        Spawn(Random.Range(0, attackerPrefabsArray.Length));
    }

    private void Spawn(int prefabIndex)
    {
        Attacker newAttacker = Instantiate
        (attackerPrefabsArray[prefabIndex], transform.position, transform.rotation)
        as Attacker;
        newAttacker.transform.parent = transform;
    }
}

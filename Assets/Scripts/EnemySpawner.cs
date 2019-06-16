using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] List<WaveConfig> waveConfigs;
    [SerializeField] int startingWave = 0;

    void Start() {
        StartCoroutine(SpawnAllWaves());
    }

    private IEnumerator SpawnAllWaves() {
        for (int i = startingWave; i < waveConfigs.Count; i++) {
            StartCoroutine(SpawnAllEnemiesInWave(waveConfigs[i]));
            yield return new WaitForSeconds(6);
        }
    }

    private IEnumerator SpawnAllEnemiesInWave(WaveConfig waveConfig) {
        for (int i = 0; i < waveConfig.GetNumberOfEnemies(); i++) {
            var newEnemy = Instantiate(
                waveConfig.GetEnemyPrefab(),
                waveConfig.GetWaypoints()[0].transform.position,
                Quaternion.identity);
            newEnemy.GetComponent<EnemyPath>().SetWaveConfig(waveConfig);
            yield return new WaitForSeconds(waveConfig.GetTimeBetweenSpawns());
        }
    }
}

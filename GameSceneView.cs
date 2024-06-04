/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 04/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using TMPro;
using UnityEngine;

public class GameSceneView : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _waveCount;

    [SerializeField]
    private TMP_Text _waveDurationTimer;

    [SerializeField]
    private TMP_Text _waveMaterialsCount;

    [SerializeField]
    private TMP_Text _waveBagMaterialsCount;

    [SerializeField]
    private TMP_Text _playerHPCount;

    [SerializeField]
    private TMP_Text _playerLevelCount;

    private void Start()
    {
        var wave = WaveManager.GetCurrentWave();

        _waveCount.text = $"Wave {wave.Count}";
        _waveDurationTimer.text = $"{wave.Duration}";
    }
}
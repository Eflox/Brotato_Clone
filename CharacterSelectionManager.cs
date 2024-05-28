/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;

public class CharacterSelectionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;
    private PlayerController _playerController;

    public ScriptableObject testCharacter;

    private void Start()
    {
        _playerController = Instantiate(_playerPrefab).GetComponent<PlayerController>();

        _playerController.EquipItem(testCharacter);
    }

    private void LoadCharacters()
    {

    }
}
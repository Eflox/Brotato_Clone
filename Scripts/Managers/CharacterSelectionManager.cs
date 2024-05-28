/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerPrefab;
    private PlayerController _playerController;

    private void Start()
    {
        _playerController = Instantiate(_playerPrefab).GetComponent<PlayerController>();
    }

    public void LoadCharacter(CharacterSelectionButton button)
    {
        _playerController.EquipItem(button.Character);
        SceneManager.LoadScene("GameScene");
    }
}
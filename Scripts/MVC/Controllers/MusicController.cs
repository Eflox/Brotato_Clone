/*
 * MusicController.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 08/06/2024
 * Contact: c.dansembourg@icloud.com
 */

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Brotato_Clone.Controllers
{
    public class MusicController : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _musicSource;

        [SerializeField]
        private AudioClip[] _musicClips;

        private int _lastClipIndex = -1;
        private Coroutine _checkEndCoroutine;
        private string _lastSceneName;

        private static MusicController _instance;

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }

            _instance = this;

            DontDestroyOnLoad(this.gameObject);
        }

        private void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        private void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            if (scene.name == "MenuScene" && _lastSceneName != "CharacterSelectionScene")
                StartMusic();

            if (scene.name == "GameScene" && _lastSceneName == "GameScene")
                StartMusic();

            _lastSceneName = scene.name;
        }

        private void StartMusic()
        {
            if (_checkEndCoroutine != null)
            {
                StopCoroutine(_checkEndCoroutine);
            }

            int newClipIndex;

            do
            {
                newClipIndex = Random.Range(0, _musicClips.Length);
            } while (newClipIndex == _lastClipIndex);

            _lastClipIndex = newClipIndex;
            _musicSource.clip = _musicClips[newClipIndex];
            _musicSource.Play();

            _checkEndCoroutine = StartCoroutine(CheckIfClipEnded());
        }

        private IEnumerator CheckIfClipEnded()
        {
            while (true)
            {
                if (_musicSource.isPlaying && _musicSource.time >= _musicSource.clip.length - 0.1f)
                {
                    StartMusic();
                    yield break;
                }
                yield return null;
            }
        }
    }
}
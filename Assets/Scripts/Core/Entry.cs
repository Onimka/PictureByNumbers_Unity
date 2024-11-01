using System.Collections.Generic;
using UnityEngine;

namespace PictureGenerator
{   
    public class Entry : MonoBehaviour
    {
        [SerializeField] private GameObject _screen;
        [SerializeField] private GameObject _mainView;
        [SerializeField] private GameObject _pictureOverlay;
        [SerializeField] private Config _config;
      

        private void Awake()
        {
            ServiceLocator.Register(this);
            ServiceLocator.Register(_config);
            var screen = Instantiate(_screen);
            Instantiate(_mainView, screen.transform);
            var overlay = Instantiate(_pictureOverlay).GetComponent<PictureOverlay>();
            overlay.Init();
        }
    }
}
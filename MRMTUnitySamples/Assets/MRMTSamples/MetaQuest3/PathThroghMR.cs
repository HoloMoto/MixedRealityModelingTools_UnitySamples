using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using MixedReality.Toolkit.UX;

namespace MixedRealityModelingTools.Quest
{

    public class PathThroghMR : MonoBehaviour
    {
        [SerializeField] GameObject _button;
        [SerializeField] Material _MRWindowMaterial;
        public void ButtonShowAndHide()
        {
            _button.SetActive(!_button.activeSelf);
        }
        public void MRScale(SliderEventData data)
        {
           // Color color = new Color(0,0,0,data.NewValue);
           // _MRWindowMaterial.SetColor("", color);
           _MRWindowMaterial.SetFloat("_Fade", data.NewValue);
        }

    }

}

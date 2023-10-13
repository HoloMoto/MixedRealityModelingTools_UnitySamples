using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MixedRealityModelingTools.Core;
using TMPro;
using Unity.VisualScripting;

namespace MixedRealityModelingTools.Samples
{

    public class ChangeSeverUtils : MonoBehaviour
    {
        public string _newIP;
        [SerializeField] TextMeshPro _iPText;
        [SerializeField] MRMTClient _MRMTClient;

        public void InputKeyString(string _inputKey)
        {
            _newIP += _inputKey; //Add Input key as string
            _iPText.text = _newIP; //Update Text
        }
        public void BackSpace()
        {
            _newIP = _newIP.Remove(_newIP.Length - 1);
            _iPText.text = _newIP;
        }
        public void UpdateConection()
        {
            _MRMTClient._ipAddress = _newIP;
            _MRMTClient.StartConnection();
        }


        // Update is called once per frame
        void Update()
        {

        }
    }

}

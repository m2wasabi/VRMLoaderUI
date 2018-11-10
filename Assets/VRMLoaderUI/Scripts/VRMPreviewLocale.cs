using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace VRMLoader
{
    public class VRMPreviewLocale : MonoBehaviour {

        [System.Serializable]
        public struct Labels
        {
            public string Headline, Title, Version, Author, Contact, Reference;

            public string PermissionAct,
                PermissionViolent,
                PermissionSexual,
                PermissionCommercial,
                PermissionOther,
                DistributionLicense,
                DistributionOther;
        }

        [System.Serializable]
        public struct Buttons
        {
            public string BtnLoad, BtnCancel;
        }

        [System.Serializable]
        public struct Selections
        {
            public string[] PermissionAct, PermissionUsage, LicenseType;
        }

        [System.Serializable]
        public class LocaleText
        {
            public Labels labels;
            public Buttons buttons;
            public Selections selections;
        }

        private LocaleText _localeText;
        void Start () {
            
        }

        public void SetLocale(string lang = "en")
        {
            var path = Application.streamingAssetsPath + "/VRMLoaderUI/i18n/" + lang + ".json";
            if (!File.Exists(path)) return;
            var json = File.ReadAllText(path);
            Debug.Log(json);
            _localeText = JsonUtility.FromJson<LocaleText>(json);
            
            Debug.Log(_localeText.labels.DistributionLicense);
            UpdateText(_localeText);
        }

        private void UpdateText(LocaleText localeText)
        {
            
        }
    }
}
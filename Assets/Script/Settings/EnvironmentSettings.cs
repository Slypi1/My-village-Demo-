using System.Collections.Generic;
using Script.Settings.Item;
using UnityEngine;

namespace Script.Settings
{
    [CreateAssetMenu(fileName = "EnvironmentSettings", menuName = "EnvironmentSettings/EnvironmentSettings", order = 1)]
    public class EnvironmentSettings : ScriptableObject
    {
        [SerializeField] private List<BuildingSettings> _buildingSettings;

        public List<BuildingSettings> BuildingsSettings => _buildingSettings;
    }
}

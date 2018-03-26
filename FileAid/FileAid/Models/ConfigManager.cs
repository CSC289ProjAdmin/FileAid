using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAid.Models {
    public static class ConfigManager {
        public static Configs GetConfigs() {
            Configs currentSettings = DAL.ConfigManagerDAL.GetConfigs();
            return currentSettings;
        }

        public static Configs UpdateConfigs(Configs newSettings) {
            bool wasUpdated = DAL.ConfigManagerDAL.UpdateConfigs(newSettings);
            if (wasUpdated) {
                Configs updatedSettings = GetConfigs();
                return updatedSettings;
            } else {
                return null;
            }
        }
    }
}

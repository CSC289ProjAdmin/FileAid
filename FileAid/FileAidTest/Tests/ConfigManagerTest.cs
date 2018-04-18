using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileAid.Models;

namespace FileAidTest.Tests
{
    [TestClass]
    public class ConfigManagerTest
    {
        [TestMethod]
        public void GetConfigsTest()
        {
            // Get reports
            Configs configs = ConfigManager.GetConfigs();

            // Verify configs were retrieved
            Assert.IsNotNull(configs);

        }

        [TestMethod]
        public void UpdateConfigsTest()
        {
            // Get reports
            Configs initialConfigs = ConfigManager.GetConfigs();

            // Verify configs were retrieved
            Assert.IsNotNull(initialConfigs);
            initialConfigs.MasterPath = "";

            Configs c = new Configs()
            {
                ConfigID = initialConfigs.ConfigID,
                UpdateTimerInMinutes = initialConfigs.UpdateTimerInMinutes + 1,
                ShowInactive = !initialConfigs.ShowInactive,
                InUpdateMode = !initialConfigs.InUpdateMode,
                MasterPath = ""
            };

            // Verify the objects are different
            Assert.IsFalse(CompareConfigsObjs(initialConfigs,c));

            // Update the modified configs
            ConfigManager.UpdateConfigs(c);

            // Get the configs after the update
            Configs modifiedConfigs = ConfigManager.GetConfigs();

            // Verify the retrieved configs match the modified configs that were updated
            Assert.IsTrue(CompareConfigsObjs(modifiedConfigs, c));

            // Update the initial configs
            ConfigManager.UpdateConfigs(initialConfigs);
        }

        bool CompareConfigsObjs(Configs a, Configs b)
        {
            bool areEqual = false;

            if (a.ConfigID == b.ConfigID &&
                a.UpdateTimerInMinutes == b.UpdateTimerInMinutes &&
                a.ShowInactive == b.ShowInactive &&
                a.InUpdateMode == b.InUpdateMode
             )
            {
                areEqual = true;
            }

            return areEqual;
        }
    }
}

namespace InropaTC
{
    public static class SettingHelper
    {
        public static string SettingsPath { get; set; } = $@"C:\ProgramData\Inropa\InropaTC\";
        public static string SettingsFileName { get; set; } = $@"Settings.json";

        public static void SaveSettings(Setting setting)
        {
            try
            {
                Directory.CreateDirectory(SettingsPath);

                JSONHelper.SerializeObject(setting, Path.Combine(SettingsPath, SettingsFileName));
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex.Message);
            }
        }

        public static Setting LoadSettings()
        {
            if (File.Exists(Path.Combine(SettingsPath, SettingsFileName)))
            {
                try
                {
                    return JSONHelper.DeserializeObject<Setting>(Path.Combine(SettingsPath, SettingsFileName));
                }
                catch (Exception ex)
                {
                    LogHelper.LogError(ex.Message);
                    return null;
                }
            }
            else
            {
                return new Setting();
            }
        }
    }
}
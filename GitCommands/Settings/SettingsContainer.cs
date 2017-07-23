using System;
using System.Drawing;
using GitUIPluginInterfaces;

namespace GitCommands.Settings
{
    public interface ISettingsContainer //<TLowerPrioritySettingsContainer, TSettingsCache> where TLowerPrioritySettingsContainer : SettingsContainer<TLowerPrioritySettingsContainer, TSettingsCache> where TSettingsCache : SettingsCache
    {
        //TLowerPrioritySettingsContainer LowerPriority { get; }
        //TSettingsCache SettingsCache { get; }
        void LockedAction(Action action);
        //void Save();
        T GetValue<T>(string name, T defaultValue, Func<string, T> decode);

        /// <summary>
        /// Sets given value at the possible lowest priority level
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="encode"></param>
        void SetValue<T>(string name, T value, Func<T, string> encode);

        //bool TryGetValue<T>(string name, T defaultValue, Func<string, T> decode, out T value);
        //int? GetInt(string name);
        //DateTime? GetDate(string name);
        //Color? GetColor(string name);
        bool? GetBool(string name);
        bool GetBool(string name, bool defaultValue);
        Color GetColor(string name, Color defaultValue);
        DateTime GetDate(string name, DateTime defaultValue);
        T GetEnum<T>(string name, T defaultValue) where T : struct;
        T? GetNullableEnum<T>(string name) where T : struct;
        Font GetFont(string name, Font defaultValue);
        int GetInt(string name, int defaultValue);
        string GetString(string name, string defaultValue);
        void SetBool(string name, bool? value);
        void SetColor(string name, Color? value);
        void SetDate(string name, DateTime? value);
        void SetEnum<T>(string name, T value);
        void SetFont(string name, Font value);
        void SetNullableEnum<T>(string name, T? value) where T : struct;
        void SetInt(string name, int? value);
        void SetString(string name, string value);
    }

    public class SettingsContainer<TLowerPrioritySettingsContainer, TSettingsCache> : SettingsSource, ISettingsContainer 
        where TLowerPrioritySettingsContainer : SettingsContainer<TLowerPrioritySettingsContainer, TSettingsCache>
        where TSettingsCache : SettingsCache
    {
        public TLowerPrioritySettingsContainer LowerPriority { get; }
        public TSettingsCache SettingsCache { get; }

        public SettingsContainer(TLowerPrioritySettingsContainer aLowerPriority, TSettingsCache aSettingsCache)
        {
            LowerPriority = aLowerPriority;
            SettingsCache = aSettingsCache;
        }

        public void LockedAction(Action action)
        {
            SettingsCache.LockedAction(() =>
                {
                    if (LowerPriority != null)
                    {
                        LowerPriority.LockedAction(action);
                    }
                    else
                    {
                        action();
                    }
                });
        }

        public void Save()
        {
            SettingsCache.Save();
            LowerPriority?.Save();
        }

        public override T GetValue<T>(string name, T defaultValue, Func<string, T> decode)
        {
            T value;
            TryGetValue(name, defaultValue, decode, out value);
            return value;
        }

        /// <summary>
        /// sets given value at the possible lowest priority level
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="encode"></param>
        public override void SetValue<T>(string name, T value, Func<T, string> encode)
        {
            if (LowerPriority == null || SettingsCache.HasValue(name))
            {
                SettingsCache.SetValue(name, value, encode);
            }
            else
            {
                LowerPriority.SetValue(name, value, encode);
            }
        }

        public virtual bool TryGetValue<T>(string name, T defaultValue, Func<string, T> decode, out T value)
        {
            if (SettingsCache.TryGetValue(name, defaultValue, decode, out value))
            {
                return true;
            }
            return LowerPriority != null && LowerPriority.TryGetValue(name, defaultValue, decode, out value);
        }

    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace HassClient.Models
{
    /// <summary>
    /// .
    /// </summary>
    public class HassTranslations
    {
        /// <summary>
        /// .
        /// </summary>
        [JsonProperty]
        public Dictionary<string, string> Resources { get; private set; }

        /// <summary>
        /// 翻译.
        /// </summary>
        /// <param name="domain">domain.</param>
        /// <returns>结果.</returns>
        public string GetDomain(string domain)
        {
            string key = $"component.{domain}.entity_component._.name";
            return this.Resources.ContainsKey(key) ? this.Resources[key] : domain;
        }

        /// <summary>
        /// 翻译.
        /// </summary>
        /// <param name="domain">.</param>
        /// <param name="state">state.</param>
        /// <returns>翻译结果.</returns>
        public string GetState(string domain, string state)
        {
            string key = $"component.{domain}.entity_component._.state.{state}";
            return this.Resources.ContainsKey(key) ? this.Resources[key] : state;
        }

        /// <summary>
        /// 翻译.
        /// </summary>
        /// <param name="domain">.</param>
        /// <param name="name">name.</param>
        /// <returns>翻译结果.</returns>
        public string GetAttribute(string domain, string name)
        {
            string key = $"component.{domain}.entity_component._.state_attributes.{name}.name";
            return this.Resources.ContainsKey(key) ? this.Resources[key] : name;
        }

        /// <summary>
        /// 翻译.
        /// </summary>
        /// <param name="domain">域.</param>
        /// <param name="name">名称.</param>
        /// <param name="state">状态.</param>
        /// <returns>翻译结果.</returns>
        public string GetAttribute(string domain, string name, string state)
        {
            string key = $"component.{domain}.entity_component._.state_attributes.{name}.state.{state}";
            return this.Resources.ContainsKey(key) ? this.Resources[key] : state;
        }
    }
}

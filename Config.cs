namespace SCPCosmetics.Config
{
    using Exiled.API.Interfaces;
    using SCPCosmetics.Types;
    using System.Collections.Generic;
    using System.ComponentModel;
    using UnityEngine;

    public class Config : IConfig
    {

        // Required Config
        /// <summary>
        ///  Will the plugin run?
        /// </summary>
        public bool IsEnabled { get; set; } = true;
        /// <summary>
        ///  Will the plugin print Debug Text?
        /// </summary>
        public bool Debug { get; set; } = false;        
        /// <summary>
        ///  Will players be able to wear Glows?
        /// </summary>
        [Description("Will players be able to wear Glows?")]
        public bool EnableGlows { get; set; } = true;
        /// <summary>
        ///  Will glows be deleted when players die?
        /// </summary>
        [Description("Will glows be deleted when players die?")]
        public bool RemoveGlowsOnDeath { get; set; } = true;
    }
}

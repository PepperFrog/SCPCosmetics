﻿using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using System;
using System.Collections.Generic;

namespace SCPHats
{
    public class SCPHats : Plugin<Config.Config>
    {
        public override string Name => "SCPHats";
        public override string Author => "creepycats";
        public override Version Version => new Version(1, 0, 0);

        public static SCPHats Instance { get; set; }

        public List<Types.HatItemComponent> HatItems { get; set; } = new List<Types.HatItemComponent>();

        public override void OnEnabled()
        {
            Instance = this;
            Log.Info("SCPHats v" + Version + " - made for v13 by creepycats");
            if (Config.Debug)
                Log.Info("Registering events...");
            RegisterEvents();
            Log.Info("Plugin Enabled!");
        }
        public override void OnDisabled()
        {
            if (Config.Debug)
                Log.Info("Unregistering events...");
            UnregisterEvents();
            Log.Info("Disabled Plugin Successfully");
        }

        // NotesToSelf
        // OBJECT.EVENT += FUNCTION > Add Function to Callback
        // OBJECT.EVENT -= FUNCTION > Remove Function from Callback

        //private handlers.serverHandler ServerHandler;
        private handlers.playerHandler PlayerHandler;

        public void RegisterEvents() 
        {
            //ServerHandler = new handlers.serverHandler(Config);
            PlayerHandler = new handlers.playerHandler(Config);
            //Server.RoundStarted += ServerHandler.RoundStarted; < Remains from my plugin base

            Player.Spawned += PlayerHandler.Spawned;
            Player.SearchingPickup += PlayerHandler.SearchingPickup;
        }
        public void UnregisterEvents()
        {
            //Server.RoundStarted -= ServerHandler.RoundStarted; < Remains from my plugin base

            Player.Spawned -= PlayerHandler.Spawned;
            Player.SearchingPickup -= PlayerHandler.SearchingPickup;
        }
    }
}